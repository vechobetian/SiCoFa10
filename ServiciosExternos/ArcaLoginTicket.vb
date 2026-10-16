Imports System.Configuration
Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Security
Imports System.Security.Cryptography.Pkcs
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Xml
Imports SiCoFa.Entidades
Imports Vecho

Public Class ArcaLoginTicket
    Property CertFirmante As X509Certificate2
    Property TicketAcceso As LoginTicket

    Private XmlLoginTicketResponse As XmlDocument = Nothing
    Private mstrPasswordSecureString As New SecureString
    Private mstrProxy As String = Nothing
    Private mstrProxyUser As String = Nothing
    Private mstrProxyPassword As String = ""
    Private mstrServicio As String = "wsfe"
    Private mstrRutaCertX509Firmante As String

    ' Ruta del Ticket de Acceso centralizada en AppData usando Vecho
    Private mstrRutaTA As String = ConfigurationManager.AppSettings("PathSiCoFa_Server") & "Temp\TA.txt"

    Private XmlLoginTicketRequest As XmlDocument = Nothing
    Private URLWsaa As String
    Private ReadOnly XmlStrLoginTicketRequestTemplate As String = "<loginTicketRequest><header><uniqueId></uniqueId><generationTime></generationTime><expirationTime></expirationTime></header><service></service></loginTicketRequest>"
    Private Shared _globalUniqueID As UInt32 = 0

    Public Function AccesoAlWSN(ByVal argEmpCUIT As String) As Boolean

        URLWsaa = "https://wsaahomo.afip.gov.ar/ws/services/LoginCms" ' URL WSAA Homologación
        'URLWsaa = "https://wsaa.afip.gov.ar/ws/services/LoginCms" ' URL WSAA Producción

        Dim carpetaApp As String = AppDomain.CurrentDomain.BaseDirectory
        Dim rutaCertificado As String = Path.Combine(ConfigurationManager.AppSettings("PathSiCoFa_Server") & "Arca\", "CFESICOFA" & argEmpCUIT & ".pfx")

        If File.Exists(rutaCertificado) Then
            mstrRutaCertX509Firmante = rutaCertificado
        Else
            Throw New Exception(Funciones.MensajeError(Me.ToString(), "AccesoAlWSN", "No existe certificado digital: " & rutaCertificado))
        End If

        Try
            ' 1. Intentamos validar el TA local existente
            If VerificarTA() = True Then
                Return True
            End If

            ' 2. Si no existe o falló, solicitamos uno nuevo a WSAA
            If ObtenerLoginTicket() = False Then
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(Funciones.MensajeError(Me.ToString, "AccesoALWSN", ex.Message))
        End Try

    End Function

    Private Function VerificarTA() As Boolean
        Try
            If File.Exists(mstrRutaTA) = False Then
                Return False
            End If

            Dim TA As String = File.ReadAllText(mstrRutaTA)

            ' Limpieza estricta de cualquier residuo en el archivo local
            If Not String.IsNullOrEmpty(TA) Then
                If TA.Contains("&lt;") Then
                    TA = WebUtility.HtmlDecode(TA)
                End If

                Dim indexXml As Integer = TA.IndexOf("<?xml")
                If indexXml < 0 Then
                    indexXml = TA.IndexOf("<loginTicketResponse")
                End If

                If indexXml > 0 Then
                    TA = TA.Substring(indexXml)
                End If
            End If

            Dim xmlTA As New XmlDocument
            xmlTA.LoadXml(TA)

            Dim GetTagText = Function(tag As String) As String
                                 Dim nodes = xmlTA.GetElementsByTagName(tag)
                                 If nodes IsNot Nothing AndAlso nodes.Count > 0 Then
                                     Return nodes(0).InnerText
                                 End If
                                 Return String.Empty
                             End Function

            Dim strExpTime As String = GetTagText("expirationTime")
            If String.IsNullOrEmpty(strExpTime) Then
                Return False
            End If

            Dim ET As DateTime = DateTime.Parse(strExpTime)

            If ET > Now Then
                TicketAcceso = New LoginTicket
                With TicketAcceso
                    .UniqueId = UInt32.Parse(GetTagText("uniqueId"))
                    .GenerationTime = DateTime.Parse(GetTagText("generationTime"))
                    .ExpirationTime = ET
                    .Sign = GetTagText("sign")
                    .Token = GetTagText("token")
                End With
                CertFirmante = ObtenerCertificadoDesdeArchivo(mstrRutaCertX509Firmante, mstrPasswordSecureString)
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            ' Si el archivo local está dañado, lo borramos silenciosamente para forzar uno nuevo
            If File.Exists(mstrRutaTA) Then
                File.Delete(mstrRutaTA)
            End If
            Return False
        End Try
    End Function

    Private Function ObtenerLoginTicket() As Boolean

        Dim cmsFirmadoBase64 As String
        Dim loginTicketResponse As String = String.Empty

        ' PASO 1: Genero el Login Ticket Request
        Try
            _globalUniqueID += 1UI

            XmlLoginTicketRequest = New XmlDocument()
            XmlLoginTicketRequest.LoadXml(XmlStrLoginTicketRequestTemplate)

            XmlLoginTicketRequest.SelectSingleNode("//uniqueId").InnerText = CStr(_globalUniqueID)
            XmlLoginTicketRequest.SelectSingleNode("//generationTime").InnerText = DateTime.Now.AddMinutes(-10).ToString("s")
            XmlLoginTicketRequest.SelectSingleNode("//expirationTime").InnerText = DateTime.Now.AddMinutes(+10).ToString("s")
            XmlLoginTicketRequest.SelectSingleNode("//service").InnerText = mstrServicio

        Catch excepcionAlGenerarLoginTicketRequest As Exception
            Throw New Exception(Funciones.MensajeError(Me.ToString, "ObtenerLoginTicket PASO 1", excepcionAlGenerarLoginTicketRequest.Message))
        End Try

        ' PASO 2: Firmo el Login Ticket Request
        Try
            CertFirmante = ObtenerCertificadoDesdeArchivo(mstrRutaCertX509Firmante, mstrPasswordSecureString)

            Dim msgBytes As Byte() = Encoding.UTF8.GetBytes(XmlLoginTicketRequest.OuterXml)
            Dim encodedSignedCms As Byte() = FirmarBytesMensaje(msgBytes, CertFirmante)
            cmsFirmadoBase64 = Convert.ToBase64String(encodedSignedCms)

        Catch excepcionAlFirmar As Exception
            Throw New Exception(Funciones.MensajeError(Me.ToString, "ObtenerLoginTicket PASO 2", excepcionAlFirmar.Message))
        End Try

        ' PASO 3: Invoco al WSAA mediante HttpClient
        Try
            Dim soapRequest As String =
                $"<?xml version=""1.0"" encoding=""UTF-8""?>
                <soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:wsaa=""http://wsaa.view.sua.dgcme.gov.ar"">
                    <soapenv:Header/>
                    <soapenv:Body>
                        <wsaa:loginCms>
                            <wsaa:in0>{cmsFirmadoBase64}</wsaa:in0>
                        </wsaa:loginCms>
                    </soapenv:Body>
                </soapenv:Envelope>"

            File.WriteAllText(ObtenerRutaTemp("arca_wsaa_request.xml"), soapRequest)

            Dim handler As New HttpClientHandler()
            If mstrProxy IsNot Nothing Then
                handler.Proxy = New WebProxy(mstrProxy, True)
                If mstrProxyUser IsNot Nothing Then
                    handler.Proxy.Credentials = New NetworkCredential(mstrProxyUser, mstrProxyPassword)
                End If
            End If

            Using client As New HttpClient(handler)
                Dim content As New StringContent(soapRequest, Encoding.UTF8, "text/xml")
                content.Headers.Add("SOAPAction", "")

                Dim response As HttpResponseMessage = client.PostAsync(URLWsaa, content).GetAwaiter().GetResult()
                Dim respuestaStr As String = response.Content.ReadAsStringAsync().GetAwaiter().GetResult()

                File.WriteAllText(ObtenerRutaTemp("arca_wsaa_response.xml"), respuestaStr)

                If Not response.IsSuccessStatusCode Then
                    If respuestaStr.Contains("alreadyAuthenticated") Then
                        Throw New Exception("AFIP indica que ya estás autenticado (alreadyAuthenticated). Por favor, espera unos minutos a que expire la sesión en AFIP e intenta nuevamente.")
                    Else
                        Throw New Exception("Error HTTP " & response.StatusCode & " al conectar con WSAA ARCA: " & respuestaStr)
                    End If
                Else
                    Dim xmlRespSoap As New XmlDocument()
                    xmlRespSoap.LoadXml(respuestaStr)

                    ' Buscamos el nodo loginCmsReturn ignorando namespaces de SOAP
                    Dim loginCmsReturnNode As XmlNode = xmlRespSoap.SelectSingleNode("//*[local-name()='loginCmsReturn']")
                    If loginCmsReturnNode IsNot Nothing Then
                        loginTicketResponse = loginCmsReturnNode.InnerText
                    Else
                        loginTicketResponse = respuestaStr
                    End If
                End If
            End Using

            ' --- EXTRACCIÓN QUIRÚRGICA DEL TICKET PURO (SIN ENVOLTORIO SOAP NI DECLARACIONES ANIDADAS) ---
            If Not String.IsNullOrEmpty(loginTicketResponse) Then
                ' Decodificar entidades HTML (&lt; por <) si vienen codificadas dentro del XML
                If loginTicketResponse.Contains("&lt;") Then
                    loginTicketResponse = WebUtility.HtmlDecode(loginTicketResponse)
                End If

                ' Cortar desde donde empieza <loginTicketResponse> desechando el sobre SOAP y cualquier <?xml ...?> previo
                Dim indexInicio As Integer = loginTicketResponse.IndexOf("<loginTicketResponse")
                If indexInicio >= 0 Then
                    loginTicketResponse = loginTicketResponse.Substring(indexInicio)
                End If

                ' Guardar el TA.txt absolutamente limpio
                File.WriteAllText(mstrRutaTA, loginTicketResponse)
            End If

        Catch excepcionAlInvocarWsaa As Exception
            Throw New Exception(Funciones.MensajeError(Me.ToString, "ObtenerLoginTicket PASO 3", excepcionAlInvocarWsaa.Message))
        End Try

        ' PASO 4: Analizo el Login Ticket Response recibido del WSAA
        Try
            ' --- FUERZA BRUTA CONTRA ESPACIOS Y BASURA AL INICIO ---
            If Not String.IsNullOrEmpty(loginTicketResponse) Then
                loginTicketResponse = loginTicketResponse.Trim()
                Dim primerMenorQue As Integer = loginTicketResponse.IndexOf("<")
                If primerMenorQue > 0 Then
                    loginTicketResponse = loginTicketResponse.Substring(primerMenorQue)
                End If
            End If
            ' -------------------------------------------------------

            XmlLoginTicketResponse = New XmlDocument()
            XmlLoginTicketResponse.LoadXml(loginTicketResponse)

            Dim ObtenerValorNodo = Function(nombreTag As String) As String
                                       Dim nodos = XmlLoginTicketResponse.GetElementsByTagName(nombreTag)
                                       If nodos IsNot Nothing AndAlso nodos.Count > 0 Then
                                           Return nodos(0).InnerText
                                       End If
                                       Return String.Empty
                                   End Function

            TicketAcceso = New LoginTicket
            With TicketAcceso
                Dim strUniqueId = ObtenerValorNodo("uniqueId")
                .UniqueId = If(String.IsNullOrEmpty(strUniqueId), 0UI, UInt32.Parse(strUniqueId))

                Dim strGenTime = ObtenerValorNodo("generationTime")
                .GenerationTime = If(String.IsNullOrEmpty(strGenTime), DateTime.Now, DateTime.Parse(strGenTime))

                Dim strExpTime = ObtenerValorNodo("expirationTime")
                .ExpirationTime = If(String.IsNullOrEmpty(strExpTime), DateTime.Now, DateTime.Parse(strExpTime))

                .Sign = ObtenerValorNodo("sign")
                .Token = ObtenerValorNodo("token")
            End With

            If String.IsNullOrEmpty(TicketAcceso.Token) OrElse String.IsNullOrEmpty(TicketAcceso.Sign) Then
                Throw New Exception("El XML de respuesta de WSAA no contiene el Token o el Sign válidos.")
            End If

        Catch excepcionAlAnalizarLoginTicketResponse As Exception
            Throw New Exception(Funciones.MensajeError(Me.ToString, "ObtenerLoginTicket PASO 4", excepcionAlAnalizarLoginTicketResponse.Message))
        End Try

        Return True

    End Function

    Private Function FirmarBytesMensaje(ByVal argBytesMsg As Byte(), ByVal argCertFirmante As X509Certificate2) As Byte()
        Try
            Dim infoContenido As New ContentInfo(argBytesMsg)
            Dim cmsFirmado As New SignedCms(infoContenido)

            Dim cmsFirmante As New CmsSigner(argCertFirmante)
            cmsFirmante.IncludeOption = X509IncludeOption.EndCertOnly

            cmsFirmado.ComputeSignature(cmsFirmante)

            Return cmsFirmado.Encode()
        Catch excepcionAlFirmar As Exception
            Throw New Exception(Funciones.MensajeError(Me.ToString, "FirmarBytesMensaje", excepcionAlFirmar.Message))
        End Try
    End Function

    Private Function ObtenerCertificadoDesdeArchivo(ByVal argArchivo As String, ByVal argPassword As SecureString) As X509Certificate2
        Try
            Dim bytesCert As Byte() = File.ReadAllBytes(argArchivo)
            Dim objCert As X509Certificate2

            If argPassword IsNot Nothing AndAlso argPassword.Length > 0 Then
                objCert = New X509Certificate2(bytesCert, argPassword, X509KeyStorageFlags.EphemeralKeySet)
            Else
                objCert = New X509Certificate2(bytesCert, "", X509KeyStorageFlags.EphemeralKeySet)
            End If

            Return objCert
        Catch excepcionAlImportarCertificado As Exception
            Throw New Exception(Funciones.MensajeError(Me.ToString, "ObtenerCertificadoDesdeArchivo", excepcionAlImportarCertificado.Message))
        End Try
    End Function

End Class
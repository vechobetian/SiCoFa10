Imports System.IO
Imports System.Net
Imports System.Security
Imports System.Security.Cryptography.Pkcs
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Xml
'Imports SiCoFa.Datos.WSAA
Imports SiCoFa.Entidades
Public Class N_AdminLoginTicket
    Property CertFirmante As X509Certificate2
    Property TicketAcceso As LoginTicket

    Private XmlLoginTicketResponse As XmlDocument = Nothing
    Private mstrPasswordSecureString As New SecureString
    Private mstrProxy As String = Nothing
    Private mstrProxyUser As String = Nothing
    Private mstrProxyPassword As String = ""
    Private mstrServicio As String = "wsfe"
    Private mstrRutaCertX509Firmante As String
    Private mstrRutaTA As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Temp", "TA.txt")
    Private XmlLoginTicketRequest As XmlDocument = Nothing
    Private URLWsaa As String
    Private ReadOnly XmlStrLoginTicketRequestTemplate As String = "<loginTicketRequest><header><uniqueId></uniqueId><generationTime></generationTime><expirationTime></expirationTime></header><service></service></loginTicketRequest>"
    Private Shared _globalUniqueID As UInt32 = 0 ' OJO! NO ES THREAD-SAFE
    Public Function AccesoAlWSN(ByVal argEmpCUIT As String) As Boolean

        URLWsaa = "https://wsaahomo.afip.gov.ar/ws/services/LoginCms" 'URL WSAA Homologacion      
        'URLWsaa = "https://wsaa.afip.gov.ar/ws/services/LoginCms?WSDL" 'URL WSAA Produccion 

        Dim carpetaApp As String = AppDomain.CurrentDomain.BaseDirectory
        Dim rutaCertificado As String = Path.Combine(carpetaApp, "CFESICOFA" & argEmpCUIT & ".pfx")

        If File.Exists(rutaCertificado) Then
            mstrRutaCertX509Firmante = rutaCertificado
        Else
            Throw New Exception(Vecho.MensajeError(Me.ToString(), "AccesoAlWSN", "No existe certificado digital: " & rutaCertificado))
        End If

        Try
            If VerificarTA() = False Then
                If ObtenerLoginTicket() = False Then
                    Return False
                End If
            End If
            Return True

        Catch ex As Exception
            Throw New Exception(vecho.MensajeError(Me.ToString, "AccesoALWSN", ex.Message))
            Return False
        End Try

    End Function
    Private Function VerificarTA() As Boolean

        Try

            If File.Exists(mstrRutaTA) = False Then
                Return False
            End If

            Dim TA As String
            Dim xmlTA As New XmlDocument
            Dim ET As DateTime 'ExpirationTime del TA 

            TA = File.ReadAllText(mstrRutaTA)
            xmlTA.LoadXml(TA)

            ET = DateTime.Parse(xmlTA.SelectSingleNode("//expirationTime").InnerText)

            If ET > Now Then 'el tiket no esta vencido y leo el archivo
                TicketAcceso = New LoginTicket
                With TicketAcceso
                    .UniqueId = UInt32.Parse(xmlTA.SelectSingleNode("//uniqueId").InnerText)
                    .GenerationTime = DateTime.Parse(xmlTA.SelectSingleNode("//generationTime").InnerText)
                    .ExpirationTime = DateTime.Parse(xmlTA.SelectSingleNode("//expirationTime").InnerText)
                    .Sign = xmlTA.SelectSingleNode("//sign").InnerText
                    .Token = xmlTA.SelectSingleNode("//token").InnerText
                End With
                CertFirmante = ObtenerCertificadoDesdeArchivo(mstrRutaCertX509Firmante, mstrPasswordSecureString)
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Throw New Exception(vecho.MensajeError(Me.ToString, "VerificarTA", ex.Message))
            Return False
        End Try

    End Function
    Private Function ObtenerLoginTicket() As Boolean


    End Function
    Private Function FirmarBytesMensaje(ByVal argBytesMsg As Byte(), ByVal argCertFirmante As X509Certificate2) As Byte()

        Try
            ' Pongo el mensaje en un objeto ContentInfo (requerido para construir el obj SignedCms)
            Dim infoContenido As New ContentInfo(argBytesMsg)
            Dim cmsFirmado As New SignedCms(infoContenido)

            ' Creo objeto CmsSigner que tiene las caracteristicas del firmante
            Dim cmsFirmante As New CmsSigner(argCertFirmante)
            cmsFirmante.IncludeOption = X509IncludeOption.EndCertOnly

            ' Firmo el mensaje PKCS #7
            cmsFirmado.ComputeSignature(cmsFirmante)

            ' Encodeo el mensaje PKCS #7.
            Return cmsFirmado.Encode()
        Catch excepcionAlFirmar As Exception
            Throw New Exception(vecho.MensajeError(Me.ToString, "FirmarBytesMensaje", excepcionAlFirmar.Message))
            Return Nothing
        End Try
    End Function
    Private Function ObtenerCertificadoDesdeArchivo(ByVal argArchivo As String, ByVal argPassword As SecureString) As X509Certificate2

        Try
            Dim objCert As New X509Certificate2
            If argPassword.IsReadOnly Then
                objCert.Import(File.ReadAllBytes(argArchivo), argPassword, X509KeyStorageFlags.PersistKeySet)
            Else
                objCert.Import(File.ReadAllBytes(argArchivo))
            End If
            Return objCert
        Catch excepcionAlImportarCertificado As Exception
            Throw New Exception(vecho.MensajeError(Me.ToString, "ObtenerCertificadoDesdeArchivo", excepcionAlImportarCertificado.Message))
            Return Nothing
        End Try
    End Function

End Class
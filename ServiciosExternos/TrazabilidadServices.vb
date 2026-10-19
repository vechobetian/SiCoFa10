Imports System.Globalization
Imports System.IO
Imports System.Net.Http
Imports System.Security
Imports SiCoFa.Entidades
Imports Vecho

Public Class TrazabilidadServices

    Private Const MstrUrl As String = "https://trazabilidad.pami.org.ar:9050/trazamed.WebService"

    ' Cabecera SOAP fija con las credenciales de sistema de PAMI
    Private Shared ReadOnly SoapHead As String =
        "<soap:Envelope xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">" &
            "<soap:Header>" &
                "<wsse:Security soap:mustUnderstand=""1"" xmlns:wsse=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd"">" &
                    "<wsse:UsernameToken wsu:Id=""UsernameToken-2"" xmlns:wsu=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd"">" &
                        "<wsse:Username>testwservice</wsse:Username>" &
                        "<wsse:Password Type=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordText"">testwservicepsw</wsse:Password>" &
                    "</wsse:UsernameToken>" &
                "</wsse:Security>" &
            "</soap:Header>" &
            "<soap:Body>"

    Private Shared ReadOnly SoapFoot As String =
            "</soap:Body>" &
        "</soap:Envelope>"

    ' Reutilización de HttpClient para evitar Socket Exhaustion
    Private Shared ReadOnly ClientHandler As New HttpClientHandler() With {
        .UseProxy = True,
        .Proxy = System.Net.WebRequest.GetSystemWebProxy()
    }

    Private Shared ReadOnly HttpClientInstance As HttpClient = CrearHttpClient()

    Private Shared Function CrearHttpClient() As HttpClient
        Dim client As New HttpClient(ClientHandler)
        client.DefaultRequestHeaders.UserAgent.ParseAdd("MSXML")
        Return client
    End Function

    ' Propiedades de estado de la última operación
    Public Property EsError As Boolean
    Public Property CodigoError As Integer
    Public Property DescripcionError As String

    ''' <summary>
    ''' Helper estático para escapar caracteres especiales de XML
    ''' </summary>
    Private Shared Function EscaparXml(valor As String) As String
        Return SecurityElement.Escape(If(valor, String.Empty))
    End Function

    ''' <summary>
    ''' Ejecuta peticiones POST SOAP al servicio de PAMI.
    ''' </summary>
    Private Async Function EjecutarSoapAsync(cuerpoSoap As String, soapAction As String) As Task(Of XDocument)
        EsError = False
        CodigoError = 0
        DescripcionError = String.Empty

        Dim soapXml As String = SoapHead & cuerpoSoap & SoapFoot

        Try
            ' Guardado opcional de trazas para depuración
            Try
                File.WriteAllText(ObtenerRutaTemp("soap_request_trazabilidad.xml"), soapXml)
            Catch
                ' Ignoramos errores de I/O si el archivo está bloqueado
            End Try

            Dim encodingAnsi As System.Text.Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim bytes = encodingAnsi.GetBytes(soapXml)

            Using content As New ByteArrayContent(bytes)
                content.Headers.ContentType = New System.Net.Http.Headers.MediaTypeHeaderValue("text/xml")
                content.Headers.ContentType.CharSet = "ISO-8859-1"
                content.Headers.Add("SOAPAction", soapAction)

                Dim response = Await HttpClientInstance.PostAsync(MstrUrl, content)
                Dim respuestaStr = Await response.Content.ReadAsStringAsync()

                ' Guardado opcional de respuesta
                Try
                    File.WriteAllText(ObtenerRutaTemp("soap_response_trazabilidad.xml"), respuestaStr)
                Catch
                End Try

                If Not response.IsSuccessStatusCode Then
                    EsError = True
                    CodigoError = CInt(response.StatusCode)
                    DescripcionError = $"Error en servidor PAMI (HTTP {CInt(response.StatusCode)}): {respuestaStr}"
                    Return Nothing
                End If

                Dim doc = XDocument.Parse(respuestaStr)
                ValidarErroresXml(doc)
                Return doc
            End Using

        Catch ex As Exception
            EsError = True
            CodigoError = -1
            DescripcionError = "Error de comunicación SOAP: " & ex.Message
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Procesa el XML devuelto buscando respuestas con error de negocio (<resultado>false</resultado>).
    ''' </summary>
    Private Sub ValidarErroresXml(doc As XDocument)
        Dim resultadoNode = doc.Descendants().FirstOrDefault(Function(e) e.Name.LocalName = "resultado")
        If resultadoNode IsNot Nothing AndAlso resultadoNode.Value.Equals("false", StringComparison.OrdinalIgnoreCase) Then
            EsError = True
            Dim errorNode = doc.Descendants().FirstOrDefault(Function(e) e.Name.LocalName = "errores")
            If errorNode IsNot Nothing Then
                Integer.TryParse(errorNode.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_c_error")?.Value, CodigoError)
                DescripcionError = errorNode.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_d_error")?.Value
            End If
        End If
    End Sub

    ''' <summary>
    ''' Obtiene la lista de transacciones no confirmadas pendientes de procesamiento.
    ''' </summary>
    Public Async Function TransaccionesNoConfirmadasAsync(argUsuario As String, argContrasena As String, argGln As String, argDesde As String, argHasta As String) As Task(Of List(Of TransaccionTrazabilidad))
        Dim listaItems As New List(Of TransaccionTrazabilidad)()

        Dim cuerpo =
            "<ns1:getTransaccionesNoConfirmadas xmlns:ns1=""http://business.mywebservice.inssjp.com/"">" &
                $"<arg0>{EscaparXml(argUsuario)}</arg0>" &
                $"<arg1>{EscaparXml(argContrasena)}</arg1>" &
                "<arg2></arg2><arg3></arg3><arg4></arg4>" &
                $"<arg5>{EscaparXml(argGln)}</arg5>" &
                "<arg6></arg6><arg7></arg7>" &
                $"<arg8>{EscaparXml(argDesde)}</arg8>" &
                $"<arg9>{EscaparXml(argHasta)}</arg9>" &
                "<arg10></arg10><arg11></arg11><arg12></arg12><arg13></arg13><arg14></arg14><arg15></arg15><arg16></arg16><arg17></arg17><arg18></arg18><arg19></arg19><arg21></arg21>" &
            "</ns1:getTransaccionesNoConfirmadas>"

        Dim soapAction = "http://business.mywebservice.inssjp.com/getTransaccionesNoConfirmadas"
        Dim doc = Await EjecutarSoapAsync(cuerpo, soapAction)

        If EsError OrElse doc Is Nothing Then Return listaItems

        Dim returnNode = doc.Descendants().FirstOrDefault(Function(e) e.Name.LocalName = "return")
        If returnNode IsNot Nothing Then
            For Each itemXml In returnNode.Elements().Where(Function(e) e.Name.LocalName = "list")
                Dim item As New TransaccionTrazabilidad()

                Dim idTrans = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_id_transaccion")?.Value
                If IsNumeric(idTrans) Then item.IdTransaccion = CLng(idTrans)

                Dim fechaTexto = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_f_evento")?.Value
                Dim fechaConvertida As Date
                If Date.TryParse(fechaTexto, fechaConvertida) Then
                    item.FechaEvento = fechaConvertida
                End If

                item.DescripcionEvento = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_d_evento")?.Value
                item.GlnOrigen = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_gln_origen")?.Value
                item.RazonSocialOrigen = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_razon_social_origen")?.Value
                item.Comprobante = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_n_factura")?.Value
                item.Nombre = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_nombre")?.Value
                item.Gtin = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_gtin")?.Value
                item.Serie = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_numero_serial")?.Value
                item.Lote = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_lote")?.Value

                Dim venc = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_vencimiento")?.Value
                If DateTime.TryParse(venc, Nothing) Then item.Vencimiento = Convert.ToDateTime(venc)

                item.Estado = "NO CONFIRMADA"
                listaItems.Add(item)
            Next
        End If

        Return listaItems
    End Function

    ''' <summary>
    ''' Confirma una transacción específica en PAMI.
    ''' </summary>
    Public Async Function ConfirmarTransaccionAsync(argUsuario As String, argContrasena As String, argFecha As String, argIdTransaccion As Long) As Task(Of Boolean)
        Dim cuerpo =
            "<ns1:sendConfirmaTransacc xmlns:ns1=""http://business.mywebservice.inssjp.com/"">" &
                $"<arg0>{EscaparXml(argUsuario)}</arg0>" &
                $"<arg1>{EscaparXml(argContrasena)}</arg1>" &
                "<arg2>" &
                    $"<f_operacion>{EscaparXml(argFecha)}</f_operacion>" &
                    $"<p_ids_transac>{argIdTransaccion}</p_ids_transac>" &
                "</arg2>" &
            "</ns1:sendConfirmaTransacc>"

        Dim soapAction = "http://business.mywebservice.inssjp.com/sendConfirmaTransacc"
        Dim doc As XDocument = Await EjecutarSoapAsync(cuerpo, soapAction)

        If EsError OrElse doc Is Nothing Then Return False

        Dim resultadoNode = doc.Descendants().FirstOrDefault(Function(e) e.Name.LocalName = "resultado")
        If resultadoNode Is Nothing Then
            EsError = True
            DescripcionError = "La respuesta de PAMI no contiene el resultado de la confirmación."
            Return False
        End If

        If Not resultadoNode.Value.Equals("true", StringComparison.OrdinalIgnoreCase) Then
            EsError = True
            If String.IsNullOrWhiteSpace(DescripcionError) Then
                DescripcionError = "PAMI no confirmó la transacción."
            End If
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' Transmite los medicamentos informados para una receta.
    ''' </summary>
    Public Async Function InformarTransaccionAsync(
        argUsuario As String,
        argContrasena As String,
        argMiGLN As String,
        argFecha As String,
        argHora As String,
        argGTIN As String,
        argSerial As String,
        argLote As String,
        argVencimiento As Date,
        argApellido As String,
        argNombre As String,
        argNumDoc As String
    ) As Task(Of String)

        Dim vencimientoTexto As String = argVencimiento.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)

        Dim cuerpoSoap As String =
            "<ns1:sendMedicamentos xmlns:ns1=""http://business.mywebservice.inssjp.com/"">" &
                "<arg0>" &
                    $"<apellido>{EscaparXml(argApellido)}</apellido>" &
                    $"<numero_serial>{EscaparXml(argSerial)}</numero_serial>" &
                    $"<f_evento>{EscaparXml(argFecha)}</f_evento>" &
                    $"<gln_origen>{EscaparXml(argMiGLN)}</gln_origen>" &
                    $"<gtin>{EscaparXml(argGTIN)}</gtin>" &
                    $"<lote>{EscaparXml(argLote)}</lote>" &
                    $"<vencimiento>{vencimientoTexto}</vencimiento>" &
                    $"<h_evento>{EscaparXml(argHora)}</h_evento>" &
                    "<id_evento>111</id_evento>" &
                    "<id_obra_social></id_obra_social>" &
                    $"<n_documento>{EscaparXml(argNumDoc)}</n_documento>" &
                    "<n_factura></n_factura>" &
                    $"<nombres>{EscaparXml(argNombre)}</nombres>" &
                    "<nro_asociado></nro_asociado>" &
                    "<tipo_documento>96</tipo_documento>" &
                "</arg0>" &
                $"<arg1>{EscaparXml(argUsuario)}</arg1>" &
                $"<arg2>{EscaparXml(argContrasena)}</arg2>" &
            "</ns1:sendMedicamentos>"

        Dim doc As XDocument = Await EjecutarSoapAsync(cuerpoSoap, "http://business.mywebservice.inssjp.com/sendMedicamentos")

        If EsError OrElse doc Is Nothing Then Return Nothing

        Dim nodoCodigo = doc.Descendants().FirstOrDefault(Function(n) n.Name.LocalName = "codigoTransaccion")
        If nodoCodigo Is Nothing OrElse String.IsNullOrWhiteSpace(nodoCodigo.Value) Then
            EsError = True
            DescripcionError = "El servicio no devolvió el código de la transacción."
            Return Nothing
        End If

        Return nodoCodigo.Value.Trim()
    End Function

    ''' <summary>
    ''' Consulta el historial de transacciones filtrando por estado y fechas.
    ''' </summary>
    Public Async Function VerTransaccionesAsync(argUsuario As String, argContrasena As String, argGln As String, argDesde As String, argHasta As String, argIdEstado As Integer) As Task(Of List(Of TransaccionTrazabilidad))
        Dim listaItems As New List(Of TransaccionTrazabilidad)()

        Dim cuerpo =
            "<ns1:getTransaccionesWS xmlns:ns1=""http://business.mywebservice.inssjp.com/"">" &
                $"<arg0>{EscaparXml(argUsuario)}</arg0>" &
                $"<arg1>{EscaparXml(argContrasena)}</arg1>" &
                "<arg2></arg2><arg3></arg3><arg4></arg4>" &
                $"<arg5>{EscaparXml(argGln)}</arg5>" &
                "<arg6></arg6><arg7></arg7><arg8></arg8>" &
                $"<arg9>{EscaparXml(argDesde)}</arg9>" &
                $"<arg10>{EscaparXml(argHasta)}</arg10>" &
                "<arg11></arg11><arg12></arg12><arg13></arg13><arg14></arg14>" &
                $"<arg15>{argIdEstado}</arg15>" &
                "<arg16></arg16><arg17></arg17>" &
            "</ns1:getTransaccionesWS>"

        Dim estadoStr As String = String.Empty
        Select Case argIdEstado
            Case 1 : estadoStr = "INFORMADA"
            Case 2 : estadoStr = "ANULADA"
            Case 3 : estadoStr = "CONFIRMADA"
            Case 4 : estadoStr = "ALERTADA"
            Case 5 : estadoStr = "CARGADA"
        End Select

        Dim soapAction = "http://business.mywebservice.inssjp.com/getTransaccionesWS"
        Dim doc = Await EjecutarSoapAsync(cuerpo, soapAction)

        If EsError OrElse doc Is Nothing Then Return listaItems

        Dim returnNode = doc.Descendants().FirstOrDefault(Function(e) e.Name.LocalName = "return")
        If returnNode IsNot Nothing Then
            For Each itemXml In returnNode.Elements().Where(Function(e) e.Name.LocalName = "list")
                Dim item As New TransaccionTrazabilidad()

                Dim idTrans = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_id_transaccion")?.Value
                If IsNumeric(idTrans) Then item.IdTransaccion = CLng(idTrans)

                item.Nombre = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_nombre")?.Value
                item.Gtin = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_gtin")?.Value
                item.Serie = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_numero_serial")?.Value
                item.Lote = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_lote")?.Value

                Dim venc = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_vencimiento")?.Value
                If DateTime.TryParse(venc, Nothing) Then item.Vencimiento = Convert.ToDateTime(venc)

                item.GlnOrigen = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_gln_origen")?.Value
                item.RazonSocialOrigen = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_razon_social_origen")?.Value
                item.DescripcionEvento = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_descripcion_evento")?.Value

                Dim fechaTexto = itemXml.Elements().FirstOrDefault(Function(e) e.Name.LocalName = "_f_evento")?.Value
                Dim fechaConvertida As Date
                If Date.TryParse(fechaTexto, fechaConvertida) Then
                    item.FechaEvento = fechaConvertida
                End If

                item.Estado = estadoStr
                listaItems.Add(item)
            Next
        End If

        Return listaItems
    End Function

End Class
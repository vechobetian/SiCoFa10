Imports System.Globalization
Imports SiCoFa.Entidades
Imports Vecho
Imports SiCoFa.ServiciosExternos
Imports ar.gov.afip.dif.fev1
Imports System.Net.Http
Imports System.Security.Cryptography.X509Certificates
Imports System.Xml

Public Class N_AdminCAE
    Property Observaciones As String
    Property Errores As String
    Property Eventos As String
    Private URLWsn As String
    Private mvarLogin As LoginTicket
    Private mvarAuthRequest As FEAuthRequest
    Private mstrEstadoCab As String
    Private mstrEstadoDet As String

    Public Function ObtenerCAE(ByVal argComprobante As Comprobante) As CAE

        URLWsn = "https://wswhomo.afip.gov.ar/wsfev1/service.asmx"
        'URLWsn = "https://servicios1.afip.gov.ar/wsfev1/service.asmx" 

        Dim objArcaLT As New ArcaLoginTicket
        Dim objCAE As CAE = Nothing
        Dim NroCbteAutorizado As Long = 0
        Me.Observaciones = ""
        Me.Errores = ""
        Me.Eventos = ""

        Try
            ' 1. Obtenemos el Ticket de Acceso
            If objArcaLT.AccesoAlWSN(argComprobante.Empresa.Documento.Numero) = False Then
                Me.Observaciones = "No se pudo Obtener Ticket de Acceso"
                Return Nothing
            End If

            mvarLogin = objArcaLT.TicketAcceso
            mvarAuthRequest = New FEAuthRequest()
            mvarAuthRequest.Cuit = CLng(Replace(argComprobante.Empresa.Documento.Numero, "-", ""))
            mvarAuthRequest.Sign = mvarLogin.Sign
            mvarAuthRequest.Token = mvarLogin.Token

            ' Preparamos los datos del comprobante
            Dim req As New FECAERequest
            Dim cab As New FECAECabRequest
            Dim det As New FECAEDetRequest

            cab.CantReg = 1
            cab.PtoVta = CInt(argComprobante.PVenta)
            cab.CbteTipo = argComprobante.TipoComprobante.CodiTC_ARCA
            req.FeCabReq = cab

            With det
                .Concepto = 1
                .DocTipo = argComprobante.Cliente.Documento.TipoDocumento.CodiTDAFIP
                .DocNro = CLng(argComprobante.Cliente.Documento.Numero)
            End With

            ' Configuramos el Handler con el certificado digital de AFIP para el primer llamado
            Dim handler As New HttpClientHandler()
            handler.ClientCertificates.Add(objArcaLT.CertFirmante)
            handler.ServerCertificateCustomValidationCallback = Function(sender, cert, chain, sslPolicyErrors) True

            Using client As New HttpClient(handler)
                client.Timeout = TimeSpan.FromSeconds(30)

                ' --- LLAMADA 1: FECompUltimoAutorizado ---
                Dim soapUltimo As String =
                    "<?xml version=""1.0"" encoding=""utf-8""?>" &
                    "<soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">" &
                      "<soap:Body>" &
                        "<FECompUltimoAutorizado xmlns=""http://ar.gov.afip.dif.FEV1/"">" &
                          "<Auth>" &
                            "<Token>" & mvarAuthRequest.Token & "</Token>" &
                            "<Sign>" & mvarAuthRequest.Sign & "</Sign>" &
                            "<Cuit>" & mvarAuthRequest.Cuit.ToString() & "</Cuit>" &
                          "</Auth>" &
                          "<PtoVta>" & CInt(argComprobante.PVenta).ToString() & "</PtoVta>" &
                          "<CbteTipo>" & argComprobante.TipoComprobante.CodiTC_ARCA.ToString() & "</CbteTipo>" &
                        "</FECompUltimoAutorizado>" &
                      "</soap:Body>" &
                    "</soap:Envelope>"

                Dim contentUltimo As New StringContent(soapUltimo, System.Text.Encoding.UTF8, "text/xml")
                client.DefaultRequestHeaders.Clear()
                client.DefaultRequestHeaders.Add("SOAPAction", "http://ar.gov.afip.dif.FEV1/FECompUltimoAutorizado")

                Dim responseUltimo = client.PostAsync(URLWsn, contentUltimo).Result
                Dim xmlUltimoStr = responseUltimo.Content.ReadAsStringAsync().Result

                If Not responseUltimo.IsSuccessStatusCode Then
                    Throw New Exception("Error HTTP en FECompUltimoAutorizado: " & xmlUltimoStr)
                End If

                ' Parseamos el último comprobante
                Dim docUltimo As New XmlDocument()
                docUltimo.LoadXml(xmlUltimoStr)
                Dim nsMgrUltimo As New XmlNamespaceManager(docUltimo.NameTable)
                nsMgrUltimo.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/")
                nsMgrUltimo.AddNamespace("ns", "http://ar.gov.afip.dif.FEV1/")

                Dim nodeUltimo = docUltimo.SelectSingleNode("//ns:FECompUltimoAutorizadoResult/ns:CbteNro", nsMgrUltimo)
                Dim last As Integer = If(nodeUltimo IsNot Nothing, CInt(nodeUltimo.InnerText), 0)

                NroCbteAutorizado = CLng(last + 1)
                det.CbteDesde = CLng(last + 1)
                det.CbteHasta = CLng(last + 1)
                det.CbteFch = Now.ToString("yyyyMMdd")

                ' Manejo de Notas de Crédito
                If argComprobante.TipoComprobante.TipoComprobanteSLetra = "NOTA DE CREDITO" Then
                    Dim cbteAsoc As New CbteAsoc
                    With cbteAsoc
                        .Tipo = argComprobante.CompAsoc.TipoComprobante.CodiTC_ARCA
                        .PtoVta = CInt(argComprobante.CompAsoc.PVenta)
                        .Nro = CLng(argComprobante.CompAsoc.NumComp)
                    End With
                    det.CbtesAsoc = {cbteAsoc}
                End If

                ' Cálculo de importes y alícuotas
                If argComprobante.TipoComprobante.CodiTC_ARCA = 11 Or argComprobante.TipoComprobante.CodiTC_ARCA = 13 Then
                    det.ImpTotConc = 0
                    det.ImpOpEx = 0
                    det.ImpNeto = argComprobante.ImpEx + argComprobante.ImpGrav1 + argComprobante.ImpGrav2
                    det.ImpIVA = 0
                    det.ImpTotal = argComprobante.ImpEx + argComprobante.ImpGrav1 + argComprobante.ImpGrav2
                Else
                    det.ImpTotConc = 0
                    det.ImpOpEx = argComprobante.ImpEx
                    det.ImpNeto = argComprobante.ImpNeto1 + argComprobante.ImpNeto2
                    det.ImpIVA = argComprobante.ImpIVA1 + argComprobante.ImpIVA2
                    det.ImpTotal = argComprobante.ImpNeto1 + argComprobante.ImpNeto2 + argComprobante.ImpIVA1 + argComprobante.ImpIVA2 + argComprobante.ImpEx

                    Dim alicuota1 As New AlicIva
                    Dim alicuota2 As New AlicIva

                    If argComprobante.ImpIVA1 > 0 Then
                        alicuota1.Id = 4 : alicuota1.BaseImp = argComprobante.ImpNeto1 : alicuota1.Importe = argComprobante.ImpIVA1
                    End If
                    If argComprobante.ImpIVA2 > 0 Then
                        alicuota2.Id = 5 : alicuota2.BaseImp = argComprobante.ImpNeto2 : alicuota2.Importe = argComprobante.ImpIVA2
                    End If

                    If argComprobante.ImpIVA1 > 0 And argComprobante.ImpIVA2 > 0 Then
                        det.Iva = {alicuota1, alicuota2}
                    ElseIf argComprobante.ImpIVA1 > 0 Then
                        det.Iva = {alicuota1}
                    ElseIf argComprobante.ImpIVA2 > 0 Then
                        det.Iva = {alicuota2}
                    End If
                End If

                det.ImpTrib = 0
                det.MonId = "PES"
                det.MonCotizSpecified = True
                det.MonCotiz = 1
                det.CondicionIVAReceptorId = Me.IdIVAReceptor(argComprobante.Cliente.IVA.CodIVA)
            End Using

            req.FeDetReq = {det}

            ' --- LLAMADA 2: FECAESolicitar vía HttpClient puro ---
            Dim handlerCAE As New HttpClientHandler()
            handlerCAE.ClientCertificates.Add(objArcaLT.CertFirmante)
            handlerCAE.ServerCertificateCustomValidationCallback = Function(sender, cert, chain, sslPolicyErrors) True

            Using clientCAE As New HttpClient(handlerCAE)
                clientCAE.Timeout = TimeSpan.FromSeconds(30)

                Dim alrIvaXml As String = ""
                If det.Iva IsNot Nothing Then
                    For Each iv In det.Iva
                        alrIvaXml &= "<AlicIva><Id>" & iv.Id.ToString() & "</Id><BaseImp>" & iv.BaseImp.ToString(CultureInfo.InvariantCulture) & "</BaseImp><Importe>" & iv.Importe.ToString(CultureInfo.InvariantCulture) & "</Importe></AlicIva>"
                    Next
                End If

                Dim soapCAE =
                    "<?xml version=""1.0"" encoding=""utf-8""?>" &
                    "<soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">" &
                      "<soap:Body>" &
                        "<FECAESolicitar xmlns=""http://ar.gov.afip.dif.FEV1/"">" &
                          "<Auth>" &
                            "<Token>" & mvarAuthRequest.Token & "</Token>" &
                            "<Sign>" & mvarAuthRequest.Sign & "</Sign>" &
                            "<Cuit>" & mvarAuthRequest.Cuit.ToString() & "</Cuit>" &
                          "</Auth>" &
                          "<FeCAEReq>" &
                            "<FeCabReq>" &
                              "<CantReg>" & req.FeCabReq.CantReg.ToString() & "</CantReg>" &
                              "<PtoVta>" & req.FeCabReq.PtoVta.ToString() & "</PtoVta>" &
                              "<CbteTipo>" & req.FeCabReq.CbteTipo.ToString() & "</CbteTipo>" &
                            "</FeCabReq>" &
                            "<FeDetReq>" &
                              "<FECAEDetRequest>" &
                                "<Concepto>" & det.Concepto.ToString() & "</Concepto>" &
                                "<DocTipo>" & det.DocTipo.ToString() & "</DocTipo>" &
                                "<DocNro>" & det.DocNro.ToString() & "</DocNro>" &
                                "<CbteDesde>" & det.CbteDesde.ToString() & "</CbteDesde>" &
                                "<CbteHasta>" & det.CbteHasta.ToString() & "</CbteHasta>" &
                                "<CbteFch>" & det.CbteFch & "</CbteFch>" &
                                "<ImpTotal>" & det.ImpTotal.ToString(CultureInfo.InvariantCulture) & "</ImpTotal>" &
                                "<ImpTotConc>" & det.ImpTotConc.ToString(CultureInfo.InvariantCulture) & "</ImpTotConc>" &
                                "<ImpNeto>" & det.ImpNeto.ToString(CultureInfo.InvariantCulture) & "</ImpNeto>" &
                                "<ImpOpEx>" & det.ImpOpEx.ToString(CultureInfo.InvariantCulture) & "</ImpOpEx>" &
                                "<ImpTrib>" & det.ImpTrib.ToString(CultureInfo.InvariantCulture) & "</ImpTrib>" &
                                "<ImpIVA>" & det.ImpIVA.ToString(CultureInfo.InvariantCulture) & "</ImpIVA>" &
                                "<MonId>" & det.MonId & "</MonId>" &
                                "<MonCotiz>" & det.MonCotiz.ToString(CultureInfo.InvariantCulture) & "</MonCotiz>" &
                                If(det.Iva IsNot Nothing, "<Iva>" & alrIvaXml & "</Iva>", "") &
                                "<CondicionIVAReceptorId>" & det.CondicionIVAReceptorId.ToString() & "</CondicionIVAReceptorId>" &
                              "</FECAEDetRequest>" &
                            "</FeDetReq>" &
                          "</FeCAEReq>" &
                        "</FECAESolicitar>" &
                      "</soap:Body>" &
                    "</soap:Envelope>"

                Dim contentCAE As New StringContent(soapCAE, System.Text.Encoding.UTF8, "text/xml")
                clientCAE.DefaultRequestHeaders.Clear()
                clientCAE.DefaultRequestHeaders.Add("SOAPAction", "http://ar.gov.afip.dif.FEV1/FECAESolicitar")

                System.IO.File.WriteAllText("C:\temp\ultimo_soap_enviado.xml", soapCAE)

                Dim responseCAE = clientCAE.PostAsync(URLWsn, contentCAE).Result
                Dim xmlCAEStr = responseCAE.Content.ReadAsStringAsync().Result

                If Not responseCAE.IsSuccessStatusCode Then
                    Throw New Exception("Error HTTP en FECAESolicitar: " & xmlCAEStr)
                End If

                Dim docCAE As New XmlDocument()
                docCAE.LoadXml(xmlCAEStr)
                Dim nsMgrCAE As New XmlNamespaceManager(docCAE.NameTable)
                nsMgrCAE.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/")
                nsMgrCAE.AddNamespace("ns", "http://ar.gov.afip.dif.FEV1/")

                Dim nodeCabRes = docCAE.SelectSingleNode("//ns:FECAESolicitarResult/ns:FeCabResp/ns:Resultado", nsMgrCAE)
                Dim nodeDetRes = docCAE.SelectSingleNode("//ns:FECAESolicitarResult/ns:FeDetResp/ns:FECAEDetResponse/ns:Resultado", nsMgrCAE)

                mstrEstadoCab = If(nodeCabRes IsNot Nothing, nodeCabRes.InnerText, "")
                mstrEstadoDet = If(nodeDetRes IsNot Nothing, nodeDetRes.InnerText, "")

                If mstrEstadoCab = "A" And mstrEstadoDet = "A" Then
                    Dim nodeCaeNum = docCAE.SelectSingleNode("//ns:FECAESolicitarResult/ns:FeDetResp/ns:FECAEDetResponse/ns:CAE", nsMgrCAE)
                    Dim nodeCaeFch = docCAE.SelectSingleNode("//ns:FECAESolicitarResult/ns:FeDetResp/ns:FECAEDetResponse/ns:CAEFchVto", nsMgrCAE)

                    Dim caeNumStr As String = If(nodeCaeNum IsNot Nothing, nodeCaeNum.InnerText, "0")
                    Dim caeNum As String = If(IsNumeric(caeNumStr), caeNumStr, "")
                    Dim caeFchVtoStr As String = If(nodeCaeFch IsNot Nothing, nodeCaeFch.InnerText, Now.ToString("yyyyMMdd"))

                    objCAE = New CAE(NroCbteAutorizado, caeNum, DateTime.ParseExact(caeFchVtoStr, "yyyyMMdd", CultureInfo.InvariantCulture))

                    Return objCAE

                End If

                Dim errNode = docCAE.SelectSingleNode("//ns:FECAESolicitarResult/ns:Errors", nsMgrCAE)
                If errNode IsNot Nothing Then
                    Throw New Exception("Error ARCA: " & errNode.InnerText)
                End If

                Dim obsNode = docCAE.SelectSingleNode("//ns:FECAESolicitarResult/ns:FeDetResp/ns:FECAEDetResponse/ns:Observaciones", nsMgrCAE)
                If obsNode IsNot Nothing Then
                    Throw New Exception("Observación ARCA: " & obsNode.InnerText)
                End If
            End Using

        Catch ex As Exception
            Throw New Exception(Funciones.MensajeError(Me.ToString, "ObtenerCAE", ex.Message))
        End Try

        Return Nothing

    End Function

    Private Function IdIVAReceptor(IVA As String) As Integer
        Select Case IVA
            Case "RI" : Return 1
            Case "MT" : Return 6
            Case "EX" : Return 4
            Case "CF" : Return 5
            Case "S/I" : Return 15
            Case Else : Return 5
        End Select
    End Function

End Class
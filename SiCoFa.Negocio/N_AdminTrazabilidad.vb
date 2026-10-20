Imports SiCoFa.Entidades
Imports SiCoFa.Datos
Imports SiCoFa.ServiciosExternos

Public Class N_AdminTrazabilidad

    Private Class ParametrosTrazabilidad
        Public Property Gln As String
        Public Property Usuario As String
        Public Property Password As String
    End Class

    Private Function ObtenerParametros() As ParametrosTrazabilidad
        Dim adminDB As New D_AdminDB()
        Dim regParam = adminDB.ObtenerRegistro("SELECT Gln, Usuario, Password FROM parametros_trazabilidad LIMIT 1")

        If regParam Is Nothing Then
            Throw New Exception("No se encontraron los parámetros de trazabilidad configurados en la base de datos.")
        End If

        Return New ParametrosTrazabilidad With {
            .Gln = regParam("Gln").ToString(),
            .Usuario = regParam("Usuario").ToString(),
            .Password = regParam("Password").ToString()
        }
    End Function

    ' =========================================================================
    ' 1. MÉTODOS DE LLAMADA AL WEB SERVICE DE PAMI / ANMAT
    ' =========================================================================

    ''' <summary>
    ''' Obtiene las transacciones no confirmadas desde el Web Service de PAMI
    ''' </summary>
    Public Async Function ObtenerTransaccionesNoConfirmadasAsync(argDesde As String, argHasta As String) As Task(Of List(Of ItemTrazable))
        Dim param = ObtenerParametros()
        Dim servicio As New TrazabilidadServices()
        Dim lista = Await servicio.TransaccionesNoConfirmadasAsync(param.Usuario, param.Password, param.Gln, argDesde, argHasta)

        If servicio.EsError Then
            Throw New Exception(servicio.DescripcionError)
        End If

        Return lista
    End Function

    ''' <summary>
    ''' Consulta el historial de transacciones en PAMI filtrando por estado y fechas
    ''' </summary>
    Public Async Function VerTransaccionesAsync(argDesde As String, argHasta As String, argIdEstado As Integer) As Task(Of List(Of ItemTrazable))
        Dim param = ObtenerParametros()
        Dim servicio As New TrazabilidadServices()
        Dim lista = Await servicio.VerTransaccionesAsync(param.Usuario, param.Password, param.Gln, argDesde, argHasta, argIdEstado)

        If servicio.EsError Then
            Throw New Exception(servicio.DescripcionError)
        End If

        Return lista
    End Function

    ''' <summary>
    ''' Informa un medicamento/transacción hacia el Web Service de PAMI
    ''' </summary>
    Public Async Function InformarTransaccionAsync(argFecha As String, argHora As String, argGTIN As String, argSerial As String, argLote As String, argVencimiento As Date, argApellido As String, argNombre As String, argNumDoc As String) As Task(Of String)
        Dim param = ObtenerParametros()
        Dim servicio As New TrazabilidadServices()
        Dim codigoTransaccion = Await servicio.InformarTransaccionAsync(param.Usuario, param.Password, param.Gln, argFecha, argHora, argGTIN, argSerial, argLote, argVencimiento, argApellido, argNombre, argNumDoc)

        If servicio.EsError Then
            Throw New Exception(servicio.DescripcionError)
        End If

        Return codigoTransaccion
    End Function

    ''' <summary>
    ''' Notifica la confirmación de la transacción al Web Service de PAMI/ANMAT
    ''' </summary>
    Public Async Function ConfirmarTransaccionAnmatAsync(argIdTransaccion As Long) As Task(Of Boolean)
        Dim param = ObtenerParametros()
        Dim fechaTexto As String = Date.Today.ToString("dd/MM/yyyy")
        Dim servicio As New TrazabilidadServices()

        Dim confirmada = Await servicio.ConfirmarTransaccionAsync(param.Usuario, param.Password, fechaTexto, argIdTransaccion)

        If servicio.EsError Then
            Throw New Exception(servicio.DescripcionError)
        End If

        Return confirmada
    End Function

    ''' <summary>
    ''' Procesa el flujo completo de confirmación: valida artículo, confirma en ANMAT y guarda localmente
    ''' </summary>
    Public Async Function ConfirmarTransaccion(argTransaccion As ItemTrazable) As Task(Of Boolean)
        Try
            Dim adminDB As New D_AdminDB()
            Dim codBarras13 As String = If(argTransaccion.Gtin.Length >= 13, Strings.Right(argTransaccion.Gtin, 13), argTransaccion.Gtin)

            ' 1. Validar existencia del artículo localmente
            Dim existeArticulo As Boolean = CBool(adminDB.CuentaRegistros($"SELECT COUNT(*) FROM articulos WHERE CodBarras='{codBarras13}'"))

            If Not existeArticulo Then
                argTransaccion.Estado = "Dar de alta en SiCoFa"
                Return False
            End If

            ' 2. Confirmar en ANMAT / PAMI
            Dim confirmadaANMAT As Boolean = Await ConfirmarTransaccionAnmatAsync(argTransaccion.IdTransaccion)
            If Not confirmadaANMAT Then Return False

            ' 3. Actualizar GTIN e insertar registro local
            adminDB.ActualizarCampo("articulos", "Gtin", argTransaccion.Gtin, $"CodBarras='{codBarras13}'")

            Dim valoresColumnas As New Dictionary(Of String, Object) From {
                {"IdTransaccion", argTransaccion.IdTransaccion},
                {"FechaEvento", argTransaccion.FechaEvento},
                {"DescripcionEvento", argTransaccion.DescripcionEvento},
                {"GlnOrigen", argTransaccion.GlnOrigen},
                {"RazonSocialOrigen", argTransaccion.RazonSocialOrigen},
                {"Comprobante", argTransaccion.Comprobante},
                {"IdUsuario", argTransaccion.IdUsuario},
                {"Nombre", argTransaccion.Nombre},
                {"Gtin", argTransaccion.Gtin},
                {"Serie", argTransaccion.Serie},
                {"Lote", argTransaccion.Lote},
                {"Vencimiento", argTransaccion.Vencimiento},
                {"Estado", "CONFIRMADA"}
            }

            adminDB.InsertarRegistro("items_trazables", valoresColumnas)
            argTransaccion.Estado = "CONFIRMADA"

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Async Function InformarTransaccionDispensada(argTransaccion As ItemTrazable) As Task(Of Boolean)
        Try
            Dim param = ObtenerParametros()
            Dim servicio As New TrazabilidadServices()

            ' Datos para el evento de informar dispensados 
            Dim fechaStr As String = If(argTransaccion.FechaEvento <> Date.MinValue, argTransaccion.FechaEvento.ToString("dd/MM/yyyy"), Date.Today.ToString("dd/MM/yyyy"))
            Dim horaStr As String = DateTime.Now.ToString("HH:mm")

            ' Llamada al servicio SOAP de PAMI (sendMedicamentos)
            Dim codigoTransaccionStr = Await servicio.InformarTransaccionAsync(
                                            param.Usuario, param.Password, param.Gln,
                                            fechaStr, horaStr,
                                            argTransaccion.Gtin, argTransaccion.Serie, argTransaccion.Lote,
                                            argTransaccion.Vencimiento,
                                            "", ' Apellido / Nombre predeterminado si viene vacío
                                            "",
                                            ""
                                         )

            If servicio.EsError OrElse String.IsNullOrWhiteSpace(codigoTransaccionStr) Then
                argTransaccion.Estado = "Error al informar: " & servicio.DescripcionError
                Return False
            End If

            ' Si PAMI devuelve el ID de transacción, lo parseamos y actualizamos
            Dim nuevoIdTransaccion As Long
            If Long.TryParse(codigoTransaccionStr, nuevoIdTransaccion) Then

                Dim adminDB As New D_AdminDB()

                ' Actualizamos con la descripción exacta del evento
                Dim sqlUpdate As String = $"UPDATE items_trazables SET " &
                              $"IdTransaccion = {nuevoIdTransaccion}, " &
                              $"Estado = 'INFORMADA', " &
                              $"FechaEvento = STR_TO_DATE('{fechaStr}', '%d/%m/%Y'), " &
                              $"DescripcionEvento = 'DISPENSACION DEL PRODUCTO AL PACIENTE' " &
                              $"WHERE IdTransaccion = {argTransaccion.IdTransaccion}"

                Dim exito As Boolean = adminDB.ActualizarTablaUpdate(sqlUpdate)


                If Not exito Then
                    argTransaccion.Estado = "Error: No se pudo actualizar el registro en la base de datos local."
                    Return False
                End If
            Else
                argTransaccion.Estado = "Error al parsear el IdTransaccion devuelto por PAMI."
                Return False
            End If

            argTransaccion.IdTransaccion = nuevoIdTransaccion
            argTransaccion.DescripcionEvento = "DISPENSACION DEL PRODUCTO AL PACIENTE"
            argTransaccion.Estado = "INFORMADA"
            Return True

        Catch ex As Exception
            argTransaccion.Estado = "Error: " & ex.Message
            Return False
        End Try
    End Function

    ' =========================================================================
    ' 2. MÉTODOS DE CONSULTA LOCAL (BASE DE DATOS)
    ' =========================================================================

    Public Function ObtenerTransaccionesConfirmadas() As DataTable
        Dim adminDB As New D_AdminDB()
        Dim sql As String =
            "SELECT * " &
            "FROM items_trazables " &
            "WHERE Estado = 'CONFIRMADA' " &
            "ORDER BY FechaEvento DESC"
        Return adminDB.ObtenerTabla(sql)
    End Function

    Public Function ObtenerTransaccionesDispensadas() As DataTable
        Dim adminDB As New D_AdminDB()
        Dim sql As String =
            "SELECT * " &
            "FROM items_trazables " &
            "WHERE Estado = 'DISPENSADA' " &
            "ORDER BY FechaEvento DESC"
        Return adminDB.ObtenerTabla(sql)
    End Function

    Public Function ObtenerTransaccionesInformadas() As DataTable
        Dim adminDB As New D_AdminDB()
        Dim sql As String =
            "SELECT * " &
            "FROM items_trazables " &
            "WHERE Estado = 'INFORMADA' " &
            "ORDER BY FechaEvento DESC"
        Return adminDB.ObtenerTabla(sql)
    End Function

    Public Function ObtenerTransaccionesConfirmadas(argGtin As String, argSerie As String) As DataTable
        Dim adminDB As New D_AdminDB()
        Dim gtinClean As String = argGtin.Replace("'", "''")
        Dim serieClean As String = argSerie.Replace("'", "''").Replace("*", "%")

        Dim sql As String =
            $"SELECT * " &
            $"FROM items_trazables " &
            $"WHERE Gtin='{gtinClean}' " &
            $"  AND Serie LIKE '%{serieClean}%' " &
            $"  AND Estado = 'CONFIRMADA' " &
            $"ORDER BY FechaEvento DESC"

        Return adminDB.ObtenerTabla(sql)
    End Function

    Public Function ObtenerTransaccionPorIdTransaccion(argIdTransaccion As Long) As ItemTrazable
        Dim adminDB As New D_AdminDB()
        Dim sql As String =
            $"SELECT * " &
            $"FROM items_trazables " &
            $"WHERE IdTransaccion={argIdTransaccion}"

        Dim dt As DataTable = adminDB.ObtenerTabla(sql)

        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            Return Nothing
        End If

        Dim fila As DataRow = dt.Rows(0)

        Return New ItemTrazable With {
            .IdTransaccion = If(IsDBNull(fila("IdTransaccion")), 0L, Convert.ToInt64(fila("IdTransaccion"))),
            .FechaEvento = If(IsDBNull(fila("FechaEvento")), Date.MinValue, Convert.ToDateTime(fila("FechaEvento"))),
            .DescripcionEvento = If(IsDBNull(fila("DescripcionEvento")), String.Empty, Convert.ToString(fila("DescripcionEvento"))),
            .GlnOrigen = If(IsDBNull(fila("GlnOrigen")), String.Empty, Convert.ToString(fila("GlnOrigen"))),
            .RazonSocialOrigen = If(IsDBNull(fila("RazonSocialOrigen")), String.Empty, Convert.ToString(fila("RazonSocialOrigen"))),
            .Comprobante = If(IsDBNull(fila("Comprobante")), String.Empty, Convert.ToString(fila("Comprobante"))),
            .IdUsuario = If(IsDBNull(fila("IdUsuario")), 0, Convert.ToInt32(fila("IdUsuario"))),
            .Nombre = If(IsDBNull(fila("Nombre")), String.Empty, Convert.ToString(fila("Nombre"))),
            .Gtin = If(IsDBNull(fila("Gtin")), String.Empty, Convert.ToString(fila("Gtin"))),
            .Serie = If(IsDBNull(fila("Serie")), String.Empty, Convert.ToString(fila("Serie"))),
            .Lote = If(IsDBNull(fila("Lote")), String.Empty, Convert.ToString(fila("Lote"))),
            .Vencimiento = If(IsDBNull(fila("Vencimiento")), Date.MinValue, Convert.ToDateTime(fila("Vencimiento"))),
            .Estado = If(IsDBNull(fila("Estado")), String.Empty, Convert.ToString(fila("Estado"))),
            .IdItem = If(IsDBNull(fila("IdItem")), 0L, Convert.ToInt64(fila("IdItem")))
        }
    End Function

End Class
Imports SiCoFa.Entidades
Imports SiCoFa.Datos
Imports SiCoFa.ServiciosExternos

Public Class N_AdminTrazabilidad

    Private ReadOnly adminDB As New D_AdminDB()

    ''' <summary>
    ''' Estructura/Clase interna para encapsular las credenciales de trazabilidad
    ''' </summary>
    Private Class ParametrosTrazabilidad
        Public Property Gln As String
        Public Property Usuario As String
        Public Property Password As String
    End Class

    ''' <summary>
    ''' Obtiene las credenciales configuradas en la base de datos
    ''' </summary>
    Private Function ObtenerParametros() As ParametrosTrazabilidad
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

    ''' <summary>
    ''' Obtiene las transacciones no confirmadas invocando al servicio externo de PAMI
    ''' </summary>
    Public Async Function ObtenerTransaccionesNoConfirmadasAsync(argDesde As String, argHasta As String) As Task(Of List(Of TransaccionTrazabilidad))
        Dim param = ObtenerParametros()

        Dim servicio As New TrazabilidadServices()
        Dim lista = Await servicio.TransaccionesNoConfirmadasAsync(param.Usuario, param.Password, param.Gln, argDesde, argHasta)

        If servicio.EsError Then
            Throw New Exception(servicio.DescripcionError)
        End If

        Return lista
    End Function

    ''' <summary>
    ''' Notifica la confirmación de la transacción al Web Service de PAMI/ANMAT
    ''' </summary>
    Public Async Function ConfirmarTransaccionAnmatAsync(argIdTransaccion As Long) As Task(Of Boolean)
        Dim param = ObtenerParametros()

        Dim fechaTexto As String = Date.Today.ToString("dd/MM/yyyy")
        Dim servicio As New TrazabilidadServices()

        Dim transaccionConfirmada As Boolean = Await servicio.ConfirmarTransaccionAsync(param.Usuario, param.Password, fechaTexto, argIdTransaccion)

        If servicio.EsError Then
            Throw New Exception(servicio.DescripcionError)
        End If

        Return transaccionConfirmada
    End Function

    Public Async Function ConfirmarTransaccionAsync(argTransaccion As TransaccionTrazabilidad) As Task(Of Boolean)
        Try

            Dim codBarras13 As String = If(argTransaccion.Gtin.Length >= 13, Strings.Right(argTransaccion.Gtin, 13), argTransaccion.Gtin)
            Dim existeArticulo As Boolean = CBool(adminDB.CuentaRegistros($"SELECT COUNT(*) FROM articulos WHERE CodBarras='{codBarras13}'"))

            If Not existeArticulo Then
                argTransaccion.Estado = "Dar de alta en SiCoFa"
                Return False
            End If

            'Dim transaccionConfirmada As Boolean = Await ConfirmarTransaccionAnmatAsync(argTransaccion.IdTransaccion)

            'If Not transaccionConfirmada Then
            'Return False
            'End If

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

            adminDB.InsertarRegistro("transacciones_trazabilidad", valoresColumnas)

            argTransaccion.Estado = "CONFIRMADA"
            Return True

        Catch ex As Exception
            ' Opcional: Podés loguear o re-lanzar la excepción según requiera el flujo
            Return False
        End Try
    End Function

    Public Function ObtenerTransaccionesConfirmadas() As DataTable
        Dim sql As String =
            "SELECT IdTransaccion, FechaEvento, DescripcionEvento, GlnOrigen, RazonSocialOrigen, Comprobante, IdUsuario, Nombre, Gtin, Serie, Lote, Vencimiento, Estado " &
            "FROM transacciones_trazabilidad " &
            "WHERE Estado = 'CONFIRMADA' " &
            "ORDER BY FechaEvento DESC"

        Return adminDB.ObtenerTabla(sql)
    End Function

    Public Function ObtenerTransaccionesDispensadas() As DataTable
        Dim sql As String =
            "SELECT IdTransaccion, FechaEvento, DescripcionEvento, GlnOrigen, RazonSocialOrigen, Comprobante, IdUsuario, Nombre, Gtin, Serie, Lote, Vencimiento, Estado " &
            "FROM transacciones_trazabilidad " &
            "WHERE Estado = 'DISPENSADA' " &
            "ORDER BY FechaEvento DESC"

        Return adminDB.ObtenerTabla(sql)
    End Function

    Public Function ObtenerTransaccionesInformadas() As DataTable
        Dim sql As String =
            "SELECT IdTransaccion, FechaEvento, DescripcionEvento, GlnOrigen, RazonSocialOrigen, Comprobante, IdUsuario, Nombre, Gtin, Serie, Lote, Vencimiento, Estado " &
            "FROM transacciones_trazabilidad " &
            "WHERE Estado = 'INFORMADA' " &
            "ORDER BY FechaEvento DESC"

        Return adminDB.ObtenerTabla(sql)
    End Function

    Public Function ObtenerTransaccionesConfirmadas(argGtin As String, argSerie As String) As DataTable
        ' Sanitizado básico para evitar romper la consulta SQL por caracteres especiales
        Dim gtinClean As String = argGtin.Replace("'", "''")
        Dim serieClean As String = argSerie.Replace("'", "''")

        Dim sql As String =
            $"SELECT IdTransaccion, FechaEvento, DescripcionEvento, GlnOrigen, RazonSocialOrigen, Comprobante, IdUsuario, Nombre, Gtin, Serie, Lote, Vencimiento, Estado " &
            $"FROM transacciones_trazabilidad " &
            $"WHERE Gtin='{gtinClean}' " &
            $"  AND Serie LIKE '%{serieClean}%' " &
            $"  AND Estado = 'CONFIRMADA' " &
            $"ORDER BY FechaEvento DESC"

        Return adminDB.ObtenerTabla(sql)
    End Function

    Public Function ObtenerTransaccionPorIdTransaccion(argIdTransaccion As Long) As TransaccionTrazabilidad
        Dim sql As String =
            $"SELECT IdTransaccion, FechaEvento, DescripcionEvento, GlnOrigen, RazonSocialOrigen, Comprobante, IdUsuario, Nombre, Gtin, Serie, Lote, Vencimiento, Estado " &
            $"FROM transacciones_trazabilidad " &
            $"WHERE IdTransaccion={argIdTransaccion}"

        Dim dt As DataTable = adminDB.ObtenerTabla(sql)

        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            Return Nothing
        End If

        Dim fila As DataRow = dt.Rows(0)

        Return New TransaccionTrazabilidad With {
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
            .Estado = If(IsDBNull(fila("Estado")), String.Empty, Convert.ToString(fila("Estado")))
        }
    End Function

    Private Function IsNullOrEmpty(dt As DataTable) As Boolean
        Return dt Is Nothing OrElse dt.Rows.Count = 0
    End Function

End Class
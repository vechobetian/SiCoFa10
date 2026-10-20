Imports SiCoFa.Entidades
Imports SiCoFa.Negocio

Public Class FrmTransaccionesTrazabilidad

    Private bindingSourceTransacciones As New BindingSource()

    Public Sub CargarDatosEnGrilla(argTransacciones As List(Of ItemTrazable))
        Me.dgvItemsTrazables.AutoGenerateColumns = False
        Me.bindingSourceTransacciones.DataSource = argTransacciones
        Me.dgvItemsTrazables.DataSource = Me.bindingSourceTransacciones
    End Sub

    Public Sub CargarDatosEnGrilla(argTabla As DataTable)
        Me.dgvItemsTrazables.AutoGenerateColumns = False
        Me.bindingSourceTransacciones.DataSource = argTabla.DefaultView
        Me.dgvItemsTrazables.DataSource = Me.bindingSourceTransacciones
    End Sub

    ''' <summary>
    ''' Extrae un objeto TransaccionTrazabilidad sin importar si la fuente es List(Of TransaccionTrazabilidad) o DataView/DataTable
    ''' </summary>
    Private Function ObtenerTransaccionDeFila(fila As DataGridViewRow) As ItemTrazable
        If fila Is Nothing OrElse fila.DataBoundItem Is Nothing Then Return Nothing

        ' Caso 1: Si la fuente es List(Of TransaccionTrazabilidad)
        Dim obj = TryCast(fila.DataBoundItem, ItemTrazable)
        If obj IsNot Nothing Then Return obj

        ' Caso 2: Si la fuente es DataTable / DataView
        Dim rowView = TryCast(fila.DataBoundItem, DataRowView)
        If rowView IsNot Nothing Then
            Dim r = rowView.Row
            Return New ItemTrazable With {
                .IdTransaccion = If(IsDBNull(r("IdTransaccion")), 0L, Convert.ToInt64(r("IdTransaccion"))),
                .FechaEvento = If(IsDBNull(r("FechaEvento")), Date.MinValue, Convert.ToDateTime(r("FechaEvento"))),
                .DescripcionEvento = If(IsDBNull(r("DescripcionEvento")), String.Empty, Convert.ToString(r("DescripcionEvento"))),
                .GlnOrigen = If(IsDBNull(r("GlnOrigen")), String.Empty, Convert.ToString(r("GlnOrigen"))),
                .RazonSocialOrigen = If(IsDBNull(r("RazonSocialOrigen")), String.Empty, Convert.ToString(r("RazonSocialOrigen"))),
                .Comprobante = If(IsDBNull(r("Comprobante")), String.Empty, Convert.ToString(r("Comprobante"))),
                .IdUsuario = If(IsDBNull(r("IdUsuario")), 0, Convert.ToInt32(r("IdUsuario"))),
                .Nombre = If(IsDBNull(r("Nombre")), String.Empty, Convert.ToString(r("Nombre"))),
                .Gtin = If(IsDBNull(r("Gtin")), String.Empty, Convert.ToString(r("Gtin"))),
                .Serie = If(IsDBNull(r("Serie")), String.Empty, Convert.ToString(r("Serie"))),
                .Lote = If(IsDBNull(r("Lote")), String.Empty, Convert.ToString(r("Lote"))),
                .Vencimiento = If(IsDBNull(r("Vencimiento")), Date.MinValue, Convert.ToDateTime(r("Vencimiento"))),
                .Estado = If(IsDBNull(r("Estado")), String.Empty, Convert.ToString(r("Estado")))
            }
        End If

        Return Nothing
    End Function

    ''' <summary>
    ''' Sincroniza el estado devuelto en la grilla sin importar el origen de datos
    ''' </summary>
    Private Sub ActualizarEstadoEnGrilla(fila As DataGridViewRow, nuevoEstado As String)
        If fila Is Nothing OrElse fila.DataBoundItem Is Nothing Then Return

        Dim obj = TryCast(fila.DataBoundItem, ItemTrazable)
        If obj IsNot Nothing Then
            obj.Estado = nuevoEstado
            Return
        End If

        Dim rowView = TryCast(fila.DataBoundItem, DataRowView)
        If rowView IsNot Nothing AndAlso rowView.Row.Table.Columns.Contains("Estado") Then
            rowView.Row("Estado") = nuevoEstado
        End If
    End Sub

    Private Sub btnOrdenAscendente_Click(sender As Object, e As EventArgs) Handles btnOrdenAscendente.Click
        OrdenarGrilla(True)
    End Sub

    Private Sub btnOrdenDescendente_Click(sender As Object, e As EventArgs) Handles btnOrdenDescendente.Click
        OrdenarGrilla(False)
    End Sub

    Private Sub OrdenarGrilla(argAscendente As Boolean)
        If dgvItemsTrazables.CurrentCell Is Nothing Then
            MessageBox.Show("Seleccioná una celda de la columna por la cual ordenar.")
            Return
        End If

        Dim nombrePropiedad As String = dgvItemsTrazables.CurrentCell.OwningColumn.DataPropertyName
        If String.IsNullOrWhiteSpace(nombrePropiedad) Then Return

        ' Caso 1: Si la grilla se cargó desde una List(Of TransaccionTrazabilidad)
        Dim transacciones = TryCast(bindingSourceTransacciones.DataSource, List(Of ItemTrazable))
        If transacciones IsNot Nothing Then
            Select Case nombrePropiedad
                Case NameOf(ItemTrazable.IdTransaccion) : AplicarOrden(transacciones, Function(t) t.IdTransaccion, argAscendente)
                Case NameOf(ItemTrazable.FechaEvento) : AplicarOrden(transacciones, Function(t) t.FechaEvento, argAscendente)
                Case NameOf(ItemTrazable.DescripcionEvento) : AplicarOrden(transacciones, Function(t) t.DescripcionEvento, argAscendente)
                Case NameOf(ItemTrazable.GlnOrigen) : AplicarOrden(transacciones, Function(t) t.GlnOrigen, argAscendente)
                Case NameOf(ItemTrazable.RazonSocialOrigen) : AplicarOrden(transacciones, Function(t) t.RazonSocialOrigen, argAscendente)
                Case NameOf(ItemTrazable.Comprobante) : AplicarOrden(transacciones, Function(t) t.Comprobante, argAscendente)
                Case NameOf(ItemTrazable.IdUsuario) : AplicarOrden(transacciones, Function(t) t.IdUsuario, argAscendente)
                Case NameOf(ItemTrazable.Nombre) : AplicarOrden(transacciones, Function(t) t.Nombre, argAscendente)
                Case NameOf(ItemTrazable.Gtin) : AplicarOrden(transacciones, Function(t) t.Gtin, argAscendente)
                Case NameOf(ItemTrazable.Serie) : AplicarOrden(transacciones, Function(t) t.Serie, argAscendente)
                Case NameOf(ItemTrazable.Lote) : AplicarOrden(transacciones, Function(t) t.Lote, argAscendente)
                Case NameOf(ItemTrazable.Vencimiento) : AplicarOrden(transacciones, Function(t) t.Vencimiento, argAscendente)
                Case NameOf(ItemTrazable.Estado) : AplicarOrden(transacciones, Function(t) t.Estado, argAscendente)
                Case Else
                    MessageBox.Show("No hay un criterio de ordenamiento definido para esta columna.")
            End Select
            Return
        End If

        ' Caso 2: Si la grilla se cargó desde un DataTable / DataView
        Dim dv = TryCast(bindingSourceTransacciones.DataSource, DataView)
        If dv IsNot Nothing Then
            dv.Sort = $"{nombrePropiedad} " & If(argAscendente, "ASC", "DESC")
        End If
    End Sub

    Private Sub AplicarOrden(Of TKey)(argTransacciones As List(Of ItemTrazable), argSelector As Func(Of ItemTrazable, TKey), argAscendente As Boolean)
        Dim listaOrdenada As List(Of ItemTrazable)
        If argAscendente Then
            listaOrdenada = argTransacciones.OrderBy(argSelector).ToList()
        Else
            listaOrdenada = argTransacciones.OrderByDescending(argSelector).ToList()
        End If
        bindingSourceTransacciones.DataSource = listaOrdenada
    End Sub

    Private Async Sub btnConfirmarTransaccion_Click(sender As Object, e As EventArgs) Handles btnConfirmarTransaccion.Click
        Try
            If dgvItemsTrazables.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccioná una transacción.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim transaccion As ItemTrazable = ObtenerTransaccionDeFila(dgvItemsTrazables.CurrentRow)
            If transaccion Is Nothing Then Return

            Select Case If(transaccion.Estado, "").Trim().ToUpperInvariant()
                Case "NO CONFIRMADA"
                    Dim adminTrazabilidad As New N_AdminTrazabilidad()

                    Cursor = Cursors.WaitCursor
                    Dim exito As Boolean = Await adminTrazabilidad.ConfirmarTransaccion(transaccion)
                    Cursor = Cursors.Default

                    ActualizarEstadoEnGrilla(dgvItemsTrazables.CurrentRow, transaccion.Estado)
                    bindingSourceTransacciones.ResetBindings(False)
                    dgvItemsTrazables.Refresh()

                    If exito Then
                        MessageBox.Show("La transacción se confirmó con éxito.", "SiCoFa - Trazabilidad", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show($"No se pudo confirmar. Estado actual: {transaccion.Estado}", "SiCoFa - Trazabilidad", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Case "CONFIRMADA"
                    Dim adminTrazabilidad As New N_AdminTrazabilidad()

                    Cursor = Cursors.WaitCursor
                    Dim exito As Boolean = Await adminTrazabilidad.InformarTransaccionDispensada(transaccion)
                    Cursor = Cursors.Default

                    ActualizarEstadoEnGrilla(dgvItemsTrazables.CurrentRow, transaccion.Estado)
                    bindingSourceTransacciones.ResetBindings(False)
                    dgvItemsTrazables.Refresh()

                    If exito Then
                        MessageBox.Show("La transacción dispensada se informó con éxito.", "SiCoFa - Trazabilidad", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show($"No se pudo informar. Estado actual: {transaccion.Estado}", "SiCoFa - Trazabilidad", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Case "DISPENSADA"
                    Dim adminTrazabilidad As New N_AdminTrazabilidad()

                    Cursor = Cursors.WaitCursor
                    Dim exito As Boolean = Await adminTrazabilidad.InformarTransaccionDispensada(transaccion)
                    Cursor = Cursors.Default

                    ActualizarEstadoEnGrilla(dgvItemsTrazables.CurrentRow, transaccion.Estado)
                    bindingSourceTransacciones.ResetBindings(False)
                    dgvItemsTrazables.Refresh()

                    If exito Then
                        MessageBox.Show("La transacción dispensada se informó con éxito.", "SiCoFa - Trazabilidad", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show($"No se pudo informar. Estado actual: {transaccion.Estado}", "SiCoFa - Trazabilidad", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Case Else
                    MessageBox.Show("No hay un proceso definido para el estado: " & If(transaccion.Estado, "(sin estado)"), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Select

        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub btnConfirmarTransacciones_Click(sender As Object, e As EventArgs) Handles btnConfirmarTransacciones.Click
        Dim confirmadas As Integer = 0
        Dim errores As Integer = 0

        Try
            btnConfirmarTransacciones.Enabled = False
            Cursor = Cursors.WaitCursor

            Dim adminTrazabilidad As New N_AdminTrazabilidad()

            For Each fila As DataGridViewRow In dgvItemsTrazables.Rows
                If fila.IsNewRow Then Continue For

                Dim transaccion As ItemTrazable = ObtenerTransaccionDeFila(fila)
                If transaccion Is Nothing Then Continue For

                If Not String.Equals(transaccion.Estado?.Trim(), "NO CONFIRMADA", StringComparison.OrdinalIgnoreCase) Then
                    Continue For
                End If

                ' Confirmación individual hacia PAMI y BD local
                Dim exito As Boolean = Await adminTrazabilidad.ConfirmarTransaccion(transaccion)

                ActualizarEstadoEnGrilla(fila, transaccion.Estado)

                If exito Then
                    confirmadas += 1
                Else
                    errores += 1
                End If

                ' Refrescar la grilla de forma segura sin bloquear la UI
                bindingSourceTransacciones.ResetBindings(False)
                dgvItemsTrazables.Refresh()

                ' Pausa de 300ms para no saturar el Web Service de PAMI y mantener fluidez
                Await Task.Delay(300)
            Next

            MessageBox.Show(
                $"Proceso finalizado.{Environment.NewLine}Confirmadas: {confirmadas}{Environment.NewLine}Errores: {errores}",
                "SiCoFa - Trazabilidad",
                MessageBoxButtons.OK,
                If(errores = 0, MessageBoxIcon.Information, MessageBoxIcon.Warning))

        Catch ex As Exception
            MessageBox.Show(ex.Message, "SiCoFa - Trazabilidad", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
            btnConfirmarTransacciones.Enabled = True
        End Try
    End Sub

End Class
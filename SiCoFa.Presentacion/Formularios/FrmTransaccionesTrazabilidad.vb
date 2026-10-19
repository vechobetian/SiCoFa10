Imports SiCoFa.Entidades
Imports SiCoFa.Negocio

Public Class FrmTransaccionesTrazabilidad

    Private bindingSourceTransacciones As New BindingSource()

    Public Sub CargarDatosEnGrilla(argTransacciones As List(Of TransaccionTrazabilidad))
        Me.dgvTransacciones.AutoGenerateColumns = False
        Me.bindingSourceTransacciones.DataSource = argTransacciones
        Me.dgvTransacciones.DataSource = Me.bindingSourceTransacciones
    End Sub

    Public Sub CargarDatosEnGrilla(argTabla As DataTable)

        Me.dgvTransacciones.AutoGenerateColumns = False
        Me.bindingSourceTransacciones.DataSource = argTabla.DefaultView
        Me.dgvTransacciones.DataSource = Me.bindingSourceTransacciones

    End Sub

    Private Sub btnOrdenAscendente_Click(sender As Object, e As EventArgs) Handles btnOrdenAscendente.Click

        OrdenarGrilla(True)

    End Sub

    Private Sub btnOrdenDescendente_Click(sender As Object, e As EventArgs) Handles btnOrdenDescendente.Click

        OrdenarGrilla(False)

    End Sub

    Private Sub OrdenarGrilla(argAscendente As Boolean)

        If dgvTransacciones.CurrentCell Is Nothing Then
            MessageBox.Show("Seleccioná una celda de la columna por la cual ordenar.")
            Return
        End If

        Dim nombrePropiedad As String = dgvTransacciones.CurrentCell.OwningColumn.DataPropertyName

        Dim transacciones = TryCast(bindingSourceTransacciones.DataSource, List(Of TransaccionTrazabilidad))

        If transacciones Is Nothing OrElse String.IsNullOrWhiteSpace(nombrePropiedad) Then
            Return
        End If

        Select Case nombrePropiedad

            Case NameOf(TransaccionTrazabilidad.IdTransaccion)
                AplicarOrden(transacciones, Function(t) t.IdTransaccion, argAscendente)

            Case NameOf(TransaccionTrazabilidad.FechaEvento)
                AplicarOrden(transacciones, Function(t) t.FechaEvento, argAscendente)

            Case NameOf(TransaccionTrazabilidad.DescripcionEvento)
                AplicarOrden(transacciones, Function(t) t.DescripcionEvento, argAscendente)

            Case NameOf(TransaccionTrazabilidad.GlnOrigen)
                AplicarOrden(transacciones, Function(t) t.GlnOrigen, argAscendente)

            Case NameOf(TransaccionTrazabilidad.RazonSocialOrigen)
                AplicarOrden(transacciones, Function(t) t.RazonSocialOrigen, argAscendente)

            Case NameOf(TransaccionTrazabilidad.Comprobante)
                AplicarOrden(transacciones, Function(t) t.Comprobante, argAscendente)

            Case NameOf(TransaccionTrazabilidad.IdUsuario)
                AplicarOrden(transacciones, Function(t) t.IdUsuario, argAscendente)

            Case NameOf(TransaccionTrazabilidad.Nombre)
                AplicarOrden(transacciones, Function(t) t.Nombre, argAscendente)

            Case NameOf(TransaccionTrazabilidad.Gtin)
                AplicarOrden(transacciones, Function(t) t.Gtin, argAscendente)

            Case NameOf(TransaccionTrazabilidad.Serie)
                AplicarOrden(transacciones, Function(t) t.Serie, argAscendente)

            Case NameOf(TransaccionTrazabilidad.Lote)
                AplicarOrden(transacciones, Function(t) t.Lote, argAscendente)

            Case NameOf(TransaccionTrazabilidad.Vencimiento)
                AplicarOrden(transacciones, Function(t) t.Vencimiento, argAscendente)

            Case NameOf(TransaccionTrazabilidad.Estado)
                AplicarOrden(transacciones, Function(t) t.Estado, argAscendente)

            Case Else
                MessageBox.Show("No hay un criterio de ordenamiento definido para esta columna.")
                Return

        End Select

    End Sub

    Private Sub AplicarOrden(Of TKey)(argTransacciones As List(Of TransaccionTrazabilidad), argSelector As Func(Of TransaccionTrazabilidad, TKey), argAscendente As Boolean)

        Dim listaOrdenada As List(Of TransaccionTrazabilidad)

        If argAscendente Then
            listaOrdenada = argTransacciones.OrderBy(argSelector).ToList()
        Else
            listaOrdenada = argTransacciones.OrderByDescending(argSelector).ToList()
        End If

        bindingSourceTransacciones.DataSource = listaOrdenada

    End Sub

    Private Async Function ConfirmarTransaccion(argTransaccion As TransaccionTrazabilidad) As Task(Of Boolean)

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

        Try

            Dim adminDB As New N_AdminDB()
            Dim existeArticulo As Boolean = CBool(adminDB.CuentaRegistros("SELECT COUNT(*) FROM articulos WHERE CodBarras='" & Strings.Right(argTransaccion.Gtin, 13) & "'"))

            If Not existeArticulo Then
                argTransaccion.Estado = "Dar de alta en SiCoFa"
                Return False
            End If

            Dim adminTrazabilidad As New N_AdminTrazabilidad
            Dim transaccionConfirmada As Boolean = Await adminTrazabilidad.ConfirmarTransaccionAnmatAsync(argTransaccion.IdTransaccion)

            If Not transaccionConfirmada Then
                Return False
            End If

            Dim gtinActualizado As Boolean = CBool(adminDB.ActualizarCampo("articulos", "Gtin", argTransaccion.Gtin, "CodBarras='" & Strings.Right(argTransaccion.Gtin, 13) & "'"))

            adminDB.InsertarRegistro("transacciones_trazabilidad", valoresColumnas)

            argTransaccion.Estado = "CONFIRMADA"
            bindingSourceTransacciones.ResetBindings(False)

            Return True

        Catch ex As Exception
            MessageBox.Show(
            ex.Message,
            "Error al confirmar transacción",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

            Return False
        End Try

    End Function

    Private Async Sub btnConfirmarTransaccion_Click(sender As Object, e As EventArgs) Handles btnConfirmarTransaccion.Click

        Try
            If dgvTransacciones.CurrentRow Is Nothing Then
                MessageBox.Show(
                "Seleccioná una transacción.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
                Return
            End If

            Dim transaccion As TransaccionTrazabilidad = TryCast(dgvTransacciones.CurrentRow.DataBoundItem, TransaccionTrazabilidad)

            If transaccion Is Nothing Then Return

            Select Case If(transaccion.Estado, "").Trim().ToUpperInvariant()

                Case "NO CONFIRMADA"
                    Dim adminTrazabilidad As New N_AdminTrazabilidad()
                    Dim transaccionConfirmada As Boolean = Await adminTrazabilidad.ConfirmarTransaccionAsync(transaccion)

                Case "CONFIRMADA"
                    MessageBox.Show(
                    "Esta transacción ya está confirmada.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

                Case Else
                    MessageBox.Show(
                    "No hay un proceso definido para el estado: " &
                    If(transaccion.Estado, "(sin estado)"),
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)

            End Select

        Catch ex As Exception
            MessageBox.Show(
            ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try

    End Sub

    Private Async Sub btnConfirmarTransacciones_Click(sender As Object, e As EventArgs) Handles btnConfirmarTransacciones.Click

        Dim confirmadas As Integer = 0
        Dim errores As Integer = 0

        Try
            btnConfirmarTransacciones.Enabled = False
            Cursor = Cursors.WaitCursor

            For Each fila As DataGridViewRow In dgvTransacciones.Rows

                If fila.IsNewRow Then Continue For

                Dim transaccion As TransaccionTrazabilidad =
                TryCast(fila.DataBoundItem, TransaccionTrazabilidad)

                If transaccion Is Nothing Then Continue For

                If Not String.Equals(transaccion.Estado?.Trim(), "NO CONFIRMADA", StringComparison.OrdinalIgnoreCase) Then
                    Continue For
                End If

                ' Procesar una transacción por vez.
                If Await ConfirmarTransaccion(transaccion) Then
                    confirmadas += 1
                Else
                    errores += 1
                End If

                ' Actualizar la grilla para mostrar el estado actual.
                bindingSourceTransacciones.ResetBindings(False)
                dgvTransacciones.Refresh()
                Application.DoEvents()

            Next

            MessageBox.Show(
            $"Proceso finalizado.{Environment.NewLine}" &
            $"Confirmadas: {confirmadas}{Environment.NewLine}" &
            $"Errores: {errores}",
            "SiCoFa - Trazabilidad",
            MessageBoxButtons.OK,
            If(errores = 0,
               MessageBoxIcon.Information,
               MessageBoxIcon.Warning))

        Catch ex As Exception
            MessageBox.Show(
            ex.Message,
            "SiCoFa - Trazabilidad",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        Finally
            Cursor = Cursors.Default
            btnConfirmarTransacciones.Enabled = True
        End Try

    End Sub

End Class
Imports SiCoFa.Entidades

Public Class FrmTransaccionesTrazabilidad

    ' Declara el BindingSource a nivel de formulario
    Private bindingSourceTransacciones As New BindingSource()

    ''' <summary>
    ''' Carga la lista de transacciones en la grilla mediante un BindingSource.
    ''' </summary>
    Public Sub CargarDatosEnGrilla(argTransacciones As List(Of TransaccionTrazabilidad))
        Me.dgvTransacciones.AutoGenerateColumns = False

        ' Asigna la lista al BindingSource y el BindingSource a la grilla
        Me.bindingSourceTransacciones.DataSource = argTransacciones
        Me.dgvTransacciones.DataSource = Me.bindingSourceTransacciones
    End Sub

    ''' <summary>
    ''' Evento del botón de la barra de herramientas para ordenar la grilla.
    ''' </summary>
    Private Sub ToolStripButtonOrdenar_Click(sender As Object, e As EventArgs) 'Handles ToolStripButtonOrdenar.Click
        ' Validar que haya una celda/columna activa en la grilla
        If Me.dgvTransacciones.CurrentCell IsNot Nothing Then
            Dim columnaActual As DataGridViewColumn = Me.dgvTransacciones.CurrentCell.OwningColumn
            Dim nombrePropiedad As String = columnaActual.DataPropertyName

            ' Verificar que la columna esté vinculada a una propiedad de TransaccionTrazabilidad
            If String.IsNullOrEmpty(nombrePropiedad) Then
                MessageBox.Show("La columna seleccionada no tiene una propiedad vinculada (DataPropertyName).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Determinar el sentido del ordenamiento (alternar entre ASC y DESC)
            Dim ordenActual As String = Me.bindingSourceTransacciones.Sort
            Dim nuevoOrden As String = ""

            If Not String.IsNullOrEmpty(ordenActual) AndAlso ordenActual.StartsWith(nombrePropiedad) AndAlso ordenActual.EndsWith("ASC") Then
                nuevoOrden = nombrePropiedad & " DESC"
            Else
                nuevoOrden = nombrePropiedad & " ASC"
            End If

            ' Aplicar el ordenamiento
            Try
                Me.bindingSourceTransacciones.Sort = nuevoOrden
            Catch ex As Exception
                MessageBox.Show("Error al ordenar por la columna seleccionada: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Selecciona una celda en la columna por la cual deseas ordenar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
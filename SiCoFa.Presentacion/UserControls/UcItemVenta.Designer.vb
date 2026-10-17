<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcItemVenta
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        txtFraccionado = New TextBox()
        txtImporteConDescuento = New TextBox()
        txtImporteDescuento = New TextBox()
        txtPorcentajeDescuento = New TextBox()
        txtImporteSinDescuento = New TextBox()
        txtPrecioUnitario = New TextBox()
        txtAlicIVA = New TextBox()
        txtCantidad = New TextBox()
        txtDescripcion = New TextBox()
        txtCodBarra = New TextBox()
        btnEliminarItem = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 11
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 33F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 117F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 47F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 47F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 58F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 117F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 117F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 58F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 117F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 117F))
        TableLayoutPanel1.Controls.Add(txtFraccionado, 3, 0)
        TableLayoutPanel1.Controls.Add(txtImporteConDescuento, 10, 0)
        TableLayoutPanel1.Controls.Add(txtImporteDescuento, 9, 0)
        TableLayoutPanel1.Controls.Add(txtPorcentajeDescuento, 8, 0)
        TableLayoutPanel1.Controls.Add(txtImporteSinDescuento, 7, 0)
        TableLayoutPanel1.Controls.Add(txtPrecioUnitario, 6, 0)
        TableLayoutPanel1.Controls.Add(txtAlicIVA, 5, 0)
        TableLayoutPanel1.Controls.Add(txtCantidad, 4, 0)
        TableLayoutPanel1.Controls.Add(txtDescripcion, 2, 0)
        TableLayoutPanel1.Controls.Add(txtCodBarra, 1, 0)
        TableLayoutPanel1.Controls.Add(btnEliminarItem, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(4, 3, 4, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1374, 26)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' txtFraccionado
        ' 
        txtFraccionado.BorderStyle = BorderStyle.None
        txtFraccionado.Dock = DockStyle.Fill
        txtFraccionado.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFraccionado.Location = New Point(700, 3)
        txtFraccionado.Margin = New Padding(4, 3, 4, 3)
        txtFraccionado.Name = "txtFraccionado"
        txtFraccionado.Size = New Size(39, 18)
        txtFraccionado.TabIndex = 10
        txtFraccionado.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtImporteConDescuento
        ' 
        txtImporteConDescuento.BackColor = Color.White
        txtImporteConDescuento.BorderStyle = BorderStyle.None
        txtImporteConDescuento.Dock = DockStyle.Fill
        txtImporteConDescuento.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtImporteConDescuento.Location = New Point(1261, 3)
        txtImporteConDescuento.Margin = New Padding(4, 3, 4, 3)
        txtImporteConDescuento.Name = "txtImporteConDescuento"
        txtImporteConDescuento.ReadOnly = True
        txtImporteConDescuento.Size = New Size(109, 18)
        txtImporteConDescuento.TabIndex = 8
        txtImporteConDescuento.TabStop = False
        txtImporteConDescuento.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtImporteDescuento
        ' 
        txtImporteDescuento.BackColor = Color.White
        txtImporteDescuento.BorderStyle = BorderStyle.None
        txtImporteDescuento.Dock = DockStyle.Fill
        txtImporteDescuento.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtImporteDescuento.Location = New Point(1144, 3)
        txtImporteDescuento.Margin = New Padding(4, 3, 4, 3)
        txtImporteDescuento.Name = "txtImporteDescuento"
        txtImporteDescuento.ReadOnly = True
        txtImporteDescuento.Size = New Size(109, 18)
        txtImporteDescuento.TabIndex = 7
        txtImporteDescuento.TabStop = False
        txtImporteDescuento.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtPorcentajeDescuento
        ' 
        txtPorcentajeDescuento.BackColor = Color.White
        txtPorcentajeDescuento.BorderStyle = BorderStyle.None
        txtPorcentajeDescuento.Dock = DockStyle.Fill
        txtPorcentajeDescuento.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPorcentajeDescuento.Location = New Point(1086, 3)
        txtPorcentajeDescuento.Margin = New Padding(4, 3, 4, 3)
        txtPorcentajeDescuento.Name = "txtPorcentajeDescuento"
        txtPorcentajeDescuento.ReadOnly = True
        txtPorcentajeDescuento.Size = New Size(50, 18)
        txtPorcentajeDescuento.TabIndex = 6
        txtPorcentajeDescuento.TabStop = False
        txtPorcentajeDescuento.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtImporteSinDescuento
        ' 
        txtImporteSinDescuento.BackColor = Color.White
        txtImporteSinDescuento.BorderStyle = BorderStyle.None
        txtImporteSinDescuento.Dock = DockStyle.Fill
        txtImporteSinDescuento.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtImporteSinDescuento.Location = New Point(969, 3)
        txtImporteSinDescuento.Margin = New Padding(4, 3, 4, 3)
        txtImporteSinDescuento.Name = "txtImporteSinDescuento"
        txtImporteSinDescuento.ReadOnly = True
        txtImporteSinDescuento.Size = New Size(109, 18)
        txtImporteSinDescuento.TabIndex = 5
        txtImporteSinDescuento.TabStop = False
        txtImporteSinDescuento.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtPrecioUnitario
        ' 
        txtPrecioUnitario.BackColor = Color.White
        txtPrecioUnitario.BorderStyle = BorderStyle.None
        txtPrecioUnitario.Dock = DockStyle.Fill
        txtPrecioUnitario.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPrecioUnitario.Location = New Point(852, 3)
        txtPrecioUnitario.Margin = New Padding(4, 3, 4, 3)
        txtPrecioUnitario.Name = "txtPrecioUnitario"
        txtPrecioUnitario.Size = New Size(109, 18)
        txtPrecioUnitario.TabIndex = 4
        txtPrecioUnitario.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtAlicIVA
        ' 
        txtAlicIVA.BackColor = Color.White
        txtAlicIVA.BorderStyle = BorderStyle.None
        txtAlicIVA.Dock = DockStyle.Fill
        txtAlicIVA.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAlicIVA.Location = New Point(794, 3)
        txtAlicIVA.Margin = New Padding(4, 3, 4, 3)
        txtAlicIVA.Name = "txtAlicIVA"
        txtAlicIVA.ReadOnly = True
        txtAlicIVA.Size = New Size(50, 18)
        txtAlicIVA.TabIndex = 3
        txtAlicIVA.TabStop = False
        txtAlicIVA.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCantidad
        ' 
        txtCantidad.BorderStyle = BorderStyle.None
        txtCantidad.Dock = DockStyle.Fill
        txtCantidad.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCantidad.Location = New Point(747, 3)
        txtCantidad.Margin = New Padding(4, 3, 4, 3)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(39, 18)
        txtCantidad.TabIndex = 2
        txtCantidad.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.BackColor = Color.White
        txtDescripcion.BorderStyle = BorderStyle.None
        txtDescripcion.Dock = DockStyle.Fill
        txtDescripcion.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDescripcion.Location = New Point(154, 3)
        txtDescripcion.Margin = New Padding(4, 3, 4, 3)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(538, 18)
        txtDescripcion.TabIndex = 1
        ' 
        ' txtCodBarra
        ' 
        txtCodBarra.BackColor = Color.White
        txtCodBarra.BorderStyle = BorderStyle.None
        txtCodBarra.Dock = DockStyle.Fill
        txtCodBarra.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCodBarra.Location = New Point(37, 3)
        txtCodBarra.Margin = New Padding(4, 3, 4, 3)
        txtCodBarra.Name = "txtCodBarra"
        txtCodBarra.ReadOnly = True
        txtCodBarra.Size = New Size(109, 18)
        txtCodBarra.TabIndex = 0
        txtCodBarra.TabStop = False
        ' 
        ' btnEliminarItem
        ' 
        btnEliminarItem.BackColor = Color.White
        btnEliminarItem.Dock = DockStyle.Top
        btnEliminarItem.FlatAppearance.BorderSize = 0
        btnEliminarItem.FlatAppearance.MouseDownBackColor = Color.DarkGray
        btnEliminarItem.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption
        btnEliminarItem.FlatStyle = FlatStyle.Flat
        btnEliminarItem.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEliminarItem.ForeColor = Color.Red
        btnEliminarItem.Location = New Point(4, 3)
        btnEliminarItem.Margin = New Padding(4, 3, 4, 3)
        btnEliminarItem.Name = "btnEliminarItem"
        btnEliminarItem.Size = New Size(25, 20)
        btnEliminarItem.TabIndex = 9
        btnEliminarItem.Text = "X"
        btnEliminarItem.TextAlign = ContentAlignment.TopCenter
        btnEliminarItem.UseVisualStyleBackColor = False
        ' 
        ' UcItemVenta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(4, 3, 4, 3)
        Name = "UcItemVenta"
        Size = New Size(1374, 26)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtCodBarra As TextBox
    Friend WithEvents txtImporteConDescuento As TextBox
    Friend WithEvents txtImporteDescuento As TextBox
    Friend WithEvents txtPorcentajeDescuento As TextBox
    Friend WithEvents txtImporteSinDescuento As TextBox
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents txtAlicIVA As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents btnEliminarItem As Button
    Friend WithEvents txtFraccionado As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransaccionesTrazabilidad
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTransaccionesTrazabilidad))
        TableLayoutPanel1 = New TableLayoutPanel()
        dgvTransacciones = New DataGridView()
        IdTransaccion = New DataGridViewTextBoxColumn()
        FechaEvento = New DataGridViewTextBoxColumn()
        DescripcionEvento = New DataGridViewTextBoxColumn()
        GlnOrigen = New DataGridViewTextBoxColumn()
        RazonSocialOrigen = New DataGridViewTextBoxColumn()
        Comprobante = New DataGridViewTextBoxColumn()
        IdUsuario = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        Gtin = New DataGridViewTextBoxColumn()
        Serie = New DataGridViewTextBoxColumn()
        Lote = New DataGridViewTextBoxColumn()
        Vencimiento = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        ToolStrip1 = New ToolStrip()
        ClienteToolStripButton = New ToolStripButton()
        AyudaToolStripButton = New ToolStripButton()
        ToolStripButton1 = New ToolStripButton()
        SalirToolStripButton = New ToolStripButton()
        TableLayoutPanel1.SuspendLayout()
        CType(dgvTransacciones, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(dgvTransacciones, 0, 1)
        TableLayoutPanel1.Controls.Add(ToolStrip1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel1.Size = New Size(974, 519)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' dgvTransacciones
        ' 
        dgvTransacciones.AllowUserToAddRows = False
        dgvTransacciones.AllowUserToDeleteRows = False
        dgvTransacciones.AllowUserToResizeColumns = False
        dgvTransacciones.AllowUserToResizeRows = False
        dgvTransacciones.BackgroundColor = Color.White
        dgvTransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransacciones.Columns.AddRange(New DataGridViewColumn() {IdTransaccion, FechaEvento, DescripcionEvento, GlnOrigen, RazonSocialOrigen, Comprobante, IdUsuario, Nombre, Gtin, Serie, Lote, Vencimiento, Estado})
        dgvTransacciones.Dock = DockStyle.Fill
        dgvTransacciones.Location = New Point(4, 43)
        dgvTransacciones.Margin = New Padding(4, 3, 4, 3)
        dgvTransacciones.Name = "dgvTransacciones"
        dgvTransacciones.ReadOnly = True
        dgvTransacciones.RowHeadersVisible = False
        dgvTransacciones.RowHeadersWidth = 20
        dgvTransacciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTransacciones.Size = New Size(966, 433)
        dgvTransacciones.TabIndex = 5
        dgvTransacciones.TabStop = False
        ' 
        ' IdTransaccion
        ' 
        IdTransaccion.DataPropertyName = "IdTransaccion"
        IdTransaccion.HeaderText = "IdTransaccion"
        IdTransaccion.Name = "IdTransaccion"
        IdTransaccion.ReadOnly = True
        IdTransaccion.Width = 90
        ' 
        ' FechaEvento
        ' 
        FechaEvento.DataPropertyName = "FechaEvento"
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        FechaEvento.DefaultCellStyle = DataGridViewCellStyle1
        FechaEvento.HeaderText = "Fecha Evento"
        FechaEvento.Name = "FechaEvento"
        FechaEvento.ReadOnly = True
        ' 
        ' DescripcionEvento
        ' 
        DescripcionEvento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DescripcionEvento.DataPropertyName = "DescripcionEvento"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft
        DescripcionEvento.DefaultCellStyle = DataGridViewCellStyle2
        DescripcionEvento.HeaderText = "Evento"
        DescripcionEvento.Name = "DescripcionEvento"
        DescripcionEvento.ReadOnly = True
        ' 
        ' GlnOrigen
        ' 
        GlnOrigen.DataPropertyName = "GlnOrigen"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        GlnOrigen.DefaultCellStyle = DataGridViewCellStyle3
        GlnOrigen.HeaderText = "GlnOrigen"
        GlnOrigen.Name = "GlnOrigen"
        GlnOrigen.ReadOnly = True
        ' 
        ' RazonSocialOrigen
        ' 
        RazonSocialOrigen.DataPropertyName = "RazonSocialOrigen"
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopLeft
        RazonSocialOrigen.DefaultCellStyle = DataGridViewCellStyle4
        RazonSocialOrigen.HeaderText = "Razon Social Origen"
        RazonSocialOrigen.Name = "RazonSocialOrigen"
        RazonSocialOrigen.ReadOnly = True
        RazonSocialOrigen.Width = 200
        ' 
        ' Comprobante
        ' 
        Comprobante.DataPropertyName = "Comprobante"
        Comprobante.HeaderText = "Comprobante"
        Comprobante.Name = "Comprobante"
        Comprobante.ReadOnly = True
        ' 
        ' IdUsuario
        ' 
        IdUsuario.DataPropertyName = "IdUsuario"
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        IdUsuario.DefaultCellStyle = DataGridViewCellStyle5
        IdUsuario.HeaderText = "IdUsuario"
        IdUsuario.Name = "IdUsuario"
        IdUsuario.ReadOnly = True
        IdUsuario.Width = 60
        ' 
        ' Nombre
        ' 
        Nombre.DataPropertyName = "Nombre"
        Nombre.HeaderText = "Articulo"
        Nombre.Name = "Nombre"
        Nombre.ReadOnly = True
        Nombre.Width = 250
        ' 
        ' Gtin
        ' 
        Gtin.DataPropertyName = "Gtin"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        Gtin.DefaultCellStyle = DataGridViewCellStyle6
        Gtin.HeaderText = "Gtin"
        Gtin.Name = "Gtin"
        Gtin.ReadOnly = True
        ' 
        ' Serie
        ' 
        Serie.DataPropertyName = "Serie"
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        Serie.DefaultCellStyle = DataGridViewCellStyle7
        Serie.HeaderText = "Serie"
        Serie.Name = "Serie"
        Serie.ReadOnly = True
        Serie.Width = 150
        ' 
        ' Lote
        ' 
        Lote.DataPropertyName = "Lote"
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        Lote.DefaultCellStyle = DataGridViewCellStyle8
        Lote.HeaderText = "Lote"
        Lote.Name = "Lote"
        Lote.ReadOnly = True
        Lote.Width = 120
        ' 
        ' Vencimiento
        ' 
        Vencimiento.DataPropertyName = "Vencimiento"
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        Vencimiento.DefaultCellStyle = DataGridViewCellStyle9
        Vencimiento.HeaderText = "Vencimiento"
        Vencimiento.Name = "Vencimiento"
        Vencimiento.ReadOnly = True
        ' 
        ' Estado
        ' 
        Estado.DataPropertyName = "Estado"
        Estado.HeaderText = "Estado"
        Estado.Name = "Estado"
        Estado.ReadOnly = True
        Estado.Width = 120
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.AutoSize = False
        ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        ToolStrip1.Items.AddRange(New ToolStripItem() {ClienteToolStripButton, AyudaToolStripButton, ToolStripButton1, SalirToolStripButton})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(974, 38)
        ToolStrip1.TabIndex = 2
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ClienteToolStripButton
        ' 
        ClienteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ClienteToolStripButton.Image = CType(resources.GetObject("ClienteToolStripButton.Image"), Image)
        ClienteToolStripButton.ImageTransparentColor = Color.Magenta
        ClienteToolStripButton.Name = "ClienteToolStripButton"
        ClienteToolStripButton.Size = New Size(23, 35)
        ClienteToolStripButton.Text = "&Cliente"
        ' 
        ' AyudaToolStripButton
        ' 
        AyudaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AyudaToolStripButton.Image = CType(resources.GetObject("AyudaToolStripButton.Image"), Image)
        AyudaToolStripButton.ImageTransparentColor = Color.Magenta
        AyudaToolStripButton.Name = "AyudaToolStripButton"
        AyudaToolStripButton.Size = New Size(23, 35)
        AyudaToolStripButton.Text = "Ay&uda"
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(23, 35)
        ToolStripButton1.Text = "ToolStripButton1"
        ' 
        ' SalirToolStripButton
        ' 
        SalirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SalirToolStripButton.Image = CType(resources.GetObject("SalirToolStripButton.Image"), Image)
        SalirToolStripButton.ImageTransparentColor = Color.Magenta
        SalirToolStripButton.Name = "SalirToolStripButton"
        SalirToolStripButton.Size = New Size(23, 35)
        SalirToolStripButton.Text = "&Salir"
        SalirToolStripButton.ToolTipText = "Salir"
        ' 
        ' FrmTransaccionesTrazabilidad
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(974, 519)
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(4, 3, 4, 3)
        Name = "FrmTransaccionesTrazabilidad"
        Text = "Transacciones Trazabilidad"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        CType(dgvTransacciones, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ClienteToolStripButton As ToolStripButton
    Friend WithEvents AyudaToolStripButton As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents SalirToolStripButton As ToolStripButton
    Friend WithEvents dgvTransacciones As DataGridView
    Friend WithEvents IdTransaccion As DataGridViewTextBoxColumn
    Friend WithEvents FechaEvento As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionEvento As DataGridViewTextBoxColumn
    Friend WithEvents GlnOrigen As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialOrigen As DataGridViewTextBoxColumn
    Friend WithEvents Comprobante As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Gtin As DataGridViewTextBoxColumn
    Friend WithEvents Serie As DataGridViewTextBoxColumn
    Friend WithEvents Lote As DataGridViewTextBoxColumn
    Friend WithEvents Vencimiento As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
End Class

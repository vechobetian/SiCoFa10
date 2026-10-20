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
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTransaccionesTrazabilidad))
        TableLayoutPanel1 = New TableLayoutPanel()
        dgvDetalle = New DataGridView()
        IdOperacion = New DataGridViewTextBoxColumn()
        Operacion = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        ComprobanteVenta = New DataGridViewTextBoxColumn()
        FechaComp = New DataGridViewTextBoxColumn()
        Articulo = New DataGridViewTextBoxColumn()
        EstadoOperacion = New DataGridViewTextBoxColumn()
        dgvItemsTrazables = New DataGridView()
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
        IdItem = New DataGridViewTextBoxColumn()
        ToolStrip1 = New ToolStrip()
        btnOrdenAscendente = New ToolStripButton()
        btnOrdenDescendente = New ToolStripButton()
        btnInformarTransaccion = New ToolStripButton()
        btnConfirmarTransaccion = New ToolStripButton()
        btnConfirmarTransacciones = New ToolStripButton()
        btnInformarTransacciones = New ToolStripButton()
        TableLayoutPanel1.SuspendLayout()
        CType(dgvDetalle, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvItemsTrazables, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(dgvDetalle, 0, 2)
        TableLayoutPanel1.Controls.Add(dgvItemsTrazables, 0, 1)
        TableLayoutPanel1.Controls.Add(ToolStrip1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 74F))
        TableLayoutPanel1.Size = New Size(974, 519)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' dgvDetalle
        ' 
        dgvDetalle.AllowUserToAddRows = False
        dgvDetalle.AllowUserToDeleteRows = False
        dgvDetalle.AllowUserToResizeColumns = False
        dgvDetalle.AllowUserToResizeRows = False
        dgvDetalle.BackgroundColor = Color.White
        dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDetalle.Columns.AddRange(New DataGridViewColumn() {IdOperacion, Operacion, DataGridViewTextBoxColumn1, ComprobanteVenta, FechaComp, Articulo, EstadoOperacion})
        TableLayoutPanel1.SetColumnSpan(dgvDetalle, 2)
        dgvDetalle.Dock = DockStyle.Fill
        dgvDetalle.Location = New Point(4, 448)
        dgvDetalle.Margin = New Padding(4, 3, 4, 3)
        dgvDetalle.Name = "dgvDetalle"
        dgvDetalle.ReadOnly = True
        dgvDetalle.RowHeadersVisible = False
        dgvDetalle.RowHeadersWidth = 20
        dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDetalle.Size = New Size(966, 68)
        dgvDetalle.TabIndex = 6
        dgvDetalle.Visible = False
        ' 
        ' IdOperacion
        ' 
        IdOperacion.DataPropertyName = "IdOperacion"
        IdOperacion.HeaderText = "IdOperacion"
        IdOperacion.Name = "IdOperacion"
        IdOperacion.ReadOnly = True
        IdOperacion.Width = 80
        ' 
        ' Operacion
        ' 
        Operacion.DataPropertyName = "Operacion"
        Operacion.HeaderText = "Operacion"
        Operacion.Name = "Operacion"
        Operacion.ReadOnly = True
        Operacion.Width = 200
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.DataPropertyName = "IdUsuario"
        DataGridViewTextBoxColumn1.HeaderText = "IdUsuario"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        DataGridViewTextBoxColumn1.Width = 60
        ' 
        ' ComprobanteVenta
        ' 
        ComprobanteVenta.DataPropertyName = "Comprobante"
        ComprobanteVenta.HeaderText = "Comprobante"
        ComprobanteVenta.Name = "ComprobanteVenta"
        ComprobanteVenta.ReadOnly = True
        ComprobanteVenta.Width = 150
        ' 
        ' FechaComp
        ' 
        FechaComp.DataPropertyName = "FechaComp"
        FechaComp.HeaderText = "Fecha"
        FechaComp.Name = "FechaComp"
        FechaComp.ReadOnly = True
        ' 
        ' Articulo
        ' 
        Articulo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Articulo.DataPropertyName = "Articulo"
        Articulo.HeaderText = "Articulo"
        Articulo.Name = "Articulo"
        Articulo.ReadOnly = True
        ' 
        ' EstadoOperacion
        ' 
        EstadoOperacion.DataPropertyName = "EstadoOperacion"
        EstadoOperacion.HeaderText = "Estado"
        EstadoOperacion.Name = "EstadoOperacion"
        EstadoOperacion.ReadOnly = True
        EstadoOperacion.Width = 150
        ' 
        ' dgvItemsTrazables
        ' 
        dgvItemsTrazables.AllowUserToAddRows = False
        dgvItemsTrazables.AllowUserToDeleteRows = False
        dgvItemsTrazables.AllowUserToResizeColumns = False
        dgvItemsTrazables.AllowUserToResizeRows = False
        dgvItemsTrazables.BackgroundColor = Color.White
        dgvItemsTrazables.BorderStyle = BorderStyle.None
        dgvItemsTrazables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvItemsTrazables.Columns.AddRange(New DataGridViewColumn() {IdTransaccion, FechaEvento, DescripcionEvento, GlnOrigen, RazonSocialOrigen, Comprobante, IdUsuario, Nombre, Gtin, Serie, Lote, Vencimiento, Estado, IdItem})
        dgvItemsTrazables.Dock = DockStyle.Fill
        dgvItemsTrazables.Location = New Point(4, 43)
        dgvItemsTrazables.Margin = New Padding(4, 3, 4, 3)
        dgvItemsTrazables.Name = "dgvItemsTrazables"
        dgvItemsTrazables.ReadOnly = True
        dgvItemsTrazables.RowHeadersVisible = False
        dgvItemsTrazables.RowHeadersWidth = 20
        dgvItemsTrazables.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvItemsTrazables.Size = New Size(966, 399)
        dgvItemsTrazables.TabIndex = 5
        dgvItemsTrazables.TabStop = False
        ' 
        ' IdTransaccion
        ' 
        IdTransaccion.DataPropertyName = "IdTransaccion"
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        IdTransaccion.DefaultCellStyle = DataGridViewCellStyle1
        IdTransaccion.HeaderText = "IdTransaccion"
        IdTransaccion.Name = "IdTransaccion"
        IdTransaccion.ReadOnly = True
        IdTransaccion.Width = 90
        ' 
        ' FechaEvento
        ' 
        FechaEvento.DataPropertyName = "FechaEvento"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        FechaEvento.DefaultCellStyle = DataGridViewCellStyle2
        FechaEvento.HeaderText = "Fecha Evento"
        FechaEvento.Name = "FechaEvento"
        FechaEvento.ReadOnly = True
        ' 
        ' DescripcionEvento
        ' 
        DescripcionEvento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DescripcionEvento.DataPropertyName = "DescripcionEvento"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DescripcionEvento.DefaultCellStyle = DataGridViewCellStyle3
        DescripcionEvento.HeaderText = "Evento"
        DescripcionEvento.Name = "DescripcionEvento"
        DescripcionEvento.ReadOnly = True
        ' 
        ' GlnOrigen
        ' 
        GlnOrigen.DataPropertyName = "GlnOrigen"
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        GlnOrigen.DefaultCellStyle = DataGridViewCellStyle4
        GlnOrigen.HeaderText = "GlnOrigen"
        GlnOrigen.Name = "GlnOrigen"
        GlnOrigen.ReadOnly = True
        ' 
        ' RazonSocialOrigen
        ' 
        RazonSocialOrigen.DataPropertyName = "RazonSocialOrigen"
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        RazonSocialOrigen.DefaultCellStyle = DataGridViewCellStyle5
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
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        IdUsuario.DefaultCellStyle = DataGridViewCellStyle6
        IdUsuario.HeaderText = "IdUsuario"
        IdUsuario.Name = "IdUsuario"
        IdUsuario.ReadOnly = True
        IdUsuario.Width = 60
        ' 
        ' Nombre
        ' 
        Nombre.DataPropertyName = "Nombre"
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        Nombre.DefaultCellStyle = DataGridViewCellStyle7
        Nombre.HeaderText = "Articulo"
        Nombre.Name = "Nombre"
        Nombre.ReadOnly = True
        Nombre.Width = 250
        ' 
        ' Gtin
        ' 
        Gtin.DataPropertyName = "Gtin"
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        Gtin.DefaultCellStyle = DataGridViewCellStyle8
        Gtin.HeaderText = "Gtin"
        Gtin.Name = "Gtin"
        Gtin.ReadOnly = True
        ' 
        ' Serie
        ' 
        Serie.DataPropertyName = "Serie"
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        Serie.DefaultCellStyle = DataGridViewCellStyle9
        Serie.HeaderText = "Serie"
        Serie.Name = "Serie"
        Serie.ReadOnly = True
        Serie.Width = 150
        ' 
        ' Lote
        ' 
        Lote.DataPropertyName = "Lote"
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
        Lote.DefaultCellStyle = DataGridViewCellStyle10
        Lote.HeaderText = "Lote"
        Lote.Name = "Lote"
        Lote.ReadOnly = True
        Lote.Width = 120
        ' 
        ' Vencimiento
        ' 
        Vencimiento.DataPropertyName = "Vencimiento"
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter
        Vencimiento.DefaultCellStyle = DataGridViewCellStyle11
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
        Estado.Width = 150
        ' 
        ' IdItem
        ' 
        IdItem.DataPropertyName = "IdItem"
        IdItem.HeaderText = "IdItem"
        IdItem.Name = "IdItem"
        IdItem.ReadOnly = True
        IdItem.Visible = False
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.AutoSize = False
        ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        ToolStrip1.Items.AddRange(New ToolStripItem() {btnOrdenAscendente, btnOrdenDescendente, btnInformarTransaccion, btnConfirmarTransaccion, btnConfirmarTransacciones, btnInformarTransacciones})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(974, 38)
        ToolStrip1.TabIndex = 2
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' btnOrdenAscendente
        ' 
        btnOrdenAscendente.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnOrdenAscendente.Image = CType(resources.GetObject("btnOrdenAscendente.Image"), Image)
        btnOrdenAscendente.ImageTransparentColor = Color.Magenta
        btnOrdenAscendente.Name = "btnOrdenAscendente"
        btnOrdenAscendente.Size = New Size(23, 35)
        btnOrdenAscendente.ToolTipText = "Orden Ascendente"
        ' 
        ' btnOrdenDescendente
        ' 
        btnOrdenDescendente.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnOrdenDescendente.Image = CType(resources.GetObject("btnOrdenDescendente.Image"), Image)
        btnOrdenDescendente.ImageTransparentColor = Color.Magenta
        btnOrdenDescendente.Name = "btnOrdenDescendente"
        btnOrdenDescendente.Size = New Size(23, 35)
        btnOrdenDescendente.ToolTipText = "Orden Descendente"
        ' 
        ' btnInformarTransaccion
        ' 
        btnInformarTransaccion.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnInformarTransaccion.Image = CType(resources.GetObject("btnInformarTransaccion.Image"), Image)
        btnInformarTransaccion.ImageTransparentColor = Color.Magenta
        btnInformarTransaccion.Name = "btnInformarTransaccion"
        btnInformarTransaccion.Size = New Size(23, 35)
        btnInformarTransaccion.ToolTipText = "Informar Transaccion"
        btnInformarTransaccion.Visible = False
        ' 
        ' btnConfirmarTransaccion
        ' 
        btnConfirmarTransaccion.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnConfirmarTransaccion.Image = CType(resources.GetObject("btnConfirmarTransaccion.Image"), Image)
        btnConfirmarTransaccion.ImageTransparentColor = Color.Magenta
        btnConfirmarTransaccion.Name = "btnConfirmarTransaccion"
        btnConfirmarTransaccion.Size = New Size(23, 35)
        btnConfirmarTransaccion.ToolTipText = "Confirmar Transaccion"
        btnConfirmarTransaccion.Visible = False
        ' 
        ' btnConfirmarTransacciones
        ' 
        btnConfirmarTransacciones.DisplayStyle = ToolStripItemDisplayStyle.Text
        btnConfirmarTransacciones.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnConfirmarTransacciones.ImageTransparentColor = Color.Magenta
        btnConfirmarTransacciones.Name = "btnConfirmarTransacciones"
        btnConfirmarTransacciones.Size = New Size(36, 35)
        btnConfirmarTransacciones.Text = "☑"
        btnConfirmarTransacciones.ToolTipText = "Confirmar Transacciones"
        btnConfirmarTransacciones.Visible = False
        ' 
        ' btnInformarTransacciones
        ' 
        btnInformarTransacciones.DisplayStyle = ToolStripItemDisplayStyle.Text
        btnInformarTransacciones.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnInformarTransacciones.ImageTransparentColor = Color.Magenta
        btnInformarTransacciones.Name = "btnInformarTransacciones"
        btnInformarTransacciones.Size = New Size(36, 35)
        btnInformarTransacciones.Text = "☑"
        btnInformarTransacciones.ToolTipText = "Confirmar Transacciones"
        btnInformarTransacciones.Visible = False
        ' 
        ' FrmTransaccionesTrazabilidad
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(974, 519)
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(4, 3, 4, 3)
        Name = "FrmTransaccionesTrazabilidad"
        Text = "Transacciones Trazabilidad"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        CType(dgvDetalle, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvItemsTrazables, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnOrdenAscendente As ToolStripButton
    Friend WithEvents btnOrdenDescendente As ToolStripButton
    Friend WithEvents btnConfirmarTransaccion As ToolStripButton
    Friend WithEvents dgvItemsTrazables As DataGridView
    Friend WithEvents btnConfirmarTransacciones As ToolStripButton
    Friend WithEvents btnInformarTransacciones As ToolStripButton
    Friend WithEvents btnInformarTransaccion As ToolStripButton
    Friend WithEvents dgvDetalle As DataGridView
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
    Friend WithEvents IdItem As DataGridViewTextBoxColumn
    Friend WithEvents IdOperacion As DataGridViewTextBoxColumn
    Friend WithEvents Operacion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ComprobanteVenta As DataGridViewTextBoxColumn
    Friend WithEvents FechaComp As DataGridViewTextBoxColumn
    Friend WithEvents Articulo As DataGridViewTextBoxColumn
    Friend WithEvents EstadoOperacion As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVentas))
        tlyGeneral = New TableLayoutPanel()
        Panel3 = New Panel()
        tlyImportes = New TableLayoutPanel()
        lblDescuentos = New Label()
        lblImporteDescuentos = New Label()
        lblImporteSinDescuentos = New Label()
        lblImporteSinDescuentosEtiqueta = New Label()
        lblImporteConDescuentosEtiqueta = New Label()
        lblImporteConDescuentos = New Label()
        lblImporteOSEtiqueta = New Label()
        lblImporteCSEtiqueda = New Label()
        lblImporteOS = New Label()
        lblImporteCS = New Label()
        Panel2 = New Panel()
        lblRecargoGeneral = New Label()
        lblDatosOperacion = New Label()
        lblCantidadItems = New Label()
        UcReceta1 = New UcReceta()
        Panel1 = New Panel()
        ToolStrip1 = New ToolStrip()
        btnNuevaReceta = New ToolStripButton()
        btnDatosReceta = New ToolStripButton()
        btnEliminarReceta = New ToolStripButton()
        btnSolicitarAutorizacionReceta = New ToolStripButton()
        btnCancelarAutorizacion = New ToolStripButton()
        toolStripSeparator = New ToolStripSeparator()
        btnDescuentoGeneral = New ToolStripButton()
        btnRecargoGeneral = New ToolStripButton()
        ClienteToolStripButton = New ToolStripButton()
        AyudaToolStripButton = New ToolStripButton()
        ToolStripButton1 = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        SalirToolStripButton = New ToolStripButton()
        MenuStrip1 = New MenuStrip()
        mnuArchivo = New ToolStripMenuItem()
        mnuGuardar = New ToolStripMenuItem()
        mnuSalir = New ToolStripMenuItem()
        mnuEditarItemSeleccionado = New ToolStripMenuItem()
        mnuEliminarItemSeleccionado = New ToolStripMenuItem()
        mnuAplicarDescuentoItemSeleccionado = New ToolStripMenuItem()
        mnuModificarPrecioItemSeleccionado = New ToolStripMenuItem()
        mnuPresentacionesEquivalentes = New ToolStripMenuItem()
        mnuPresentacionesConIgualAccionFarmacologica = New ToolStripMenuItem()
        mnuPresentacionesConIgualMonodroga = New ToolStripMenuItem()
        mnuObrasSociales = New ToolStripMenuItem()
        mnuNuevaReceta = New ToolStripMenuItem()
        mnuDatosReceta = New ToolStripMenuItem()
        mnuElinarReceta = New ToolStripMenuItem()
        mnuAutorizarReceta = New ToolStripMenuItem()
        mnuCancelarAutorizacion = New ToolStripMenuItem()
        mnuProcesos = New ToolStripMenuItem()
        FacturarToolStripMenuItem = New ToolStripMenuItem()
        RemitoToolStripMenuItem = New ToolStripMenuItem()
        PresupuestoToolStripMenuItem = New ToolStripMenuItem()
        mnuOpciones = New ToolStripMenuItem()
        mnuDescuentoGeneral = New ToolStripMenuItem()
        mnuRecargoGeneral = New ToolStripMenuItem()
        PanelItems = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblDescripcion = New Label()
        lblCodigo = New Label()
        tlyGeneral.SuspendLayout()
        Panel3.SuspendLayout()
        tlyImportes.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tlyGeneral
        ' 
        tlyGeneral.BackColor = SystemColors.Window
        tlyGeneral.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble
        tlyGeneral.ColumnCount = 1
        tlyGeneral.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlyGeneral.Controls.Add(Panel3, 0, 3)
        tlyGeneral.Controls.Add(Panel1, 0, 0)
        tlyGeneral.Controls.Add(PanelItems, 0, 2)
        tlyGeneral.Controls.Add(TableLayoutPanel1, 0, 1)
        tlyGeneral.Dock = DockStyle.Fill
        tlyGeneral.Location = New Point(0, 0)
        tlyGeneral.Margin = New Padding(0)
        tlyGeneral.Name = "tlyGeneral"
        tlyGeneral.RowCount = 4
        tlyGeneral.RowStyles.Add(New RowStyle())
        tlyGeneral.RowStyles.Add(New RowStyle(SizeType.Absolute, 35F))
        tlyGeneral.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlyGeneral.RowStyles.Add(New RowStyle(SizeType.Absolute, 219F))
        tlyGeneral.Size = New Size(1148, 763)
        tlyGeneral.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(tlyImportes)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(7, 544)
        Panel3.Margin = New Padding(4, 3, 4, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1134, 212)
        Panel3.TabIndex = 5
        ' 
        ' tlyImportes
        ' 
        tlyImportes.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble
        tlyImportes.ColumnCount = 3
        tlyImportes.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlyImportes.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 141F))
        tlyImportes.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 184F))
        tlyImportes.Controls.Add(lblDescuentos, 1, 1)
        tlyImportes.Controls.Add(lblImporteDescuentos, 2, 1)
        tlyImportes.Controls.Add(lblImporteSinDescuentos, 2, 0)
        tlyImportes.Controls.Add(lblImporteSinDescuentosEtiqueta, 1, 0)
        tlyImportes.Controls.Add(lblImporteConDescuentosEtiqueta, 1, 4)
        tlyImportes.Controls.Add(lblImporteConDescuentos, 2, 4)
        tlyImportes.Controls.Add(lblImporteOSEtiqueta, 1, 2)
        tlyImportes.Controls.Add(lblImporteCSEtiqueda, 1, 3)
        tlyImportes.Controls.Add(lblImporteOS, 2, 2)
        tlyImportes.Controls.Add(lblImporteCS, 2, 3)
        tlyImportes.Controls.Add(Panel2, 0, 0)
        tlyImportes.Dock = DockStyle.Fill
        tlyImportes.Location = New Point(0, 0)
        tlyImportes.Margin = New Padding(4, 3, 4, 3)
        tlyImportes.Name = "tlyImportes"
        tlyImportes.RowCount = 5
        tlyImportes.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        tlyImportes.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        tlyImportes.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        tlyImportes.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        tlyImportes.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        tlyImportes.Size = New Size(1132, 210)
        tlyImportes.TabIndex = 7
        ' 
        ' lblDescuentos
        ' 
        lblDescuentos.Dock = DockStyle.Fill
        lblDescuentos.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDescuentos.Location = New Point(805, 34)
        lblDescuentos.Margin = New Padding(4, 0, 4, 0)
        lblDescuentos.Name = "lblDescuentos"
        lblDescuentos.Size = New Size(133, 28)
        lblDescuentos.TabIndex = 8
        lblDescuentos.Text = "Descuentos:"
        lblDescuentos.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblImporteDescuentos
        ' 
        lblImporteDescuentos.Dock = DockStyle.Fill
        lblImporteDescuentos.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblImporteDescuentos.Location = New Point(949, 34)
        lblImporteDescuentos.Margin = New Padding(4, 0, 4, 0)
        lblImporteDescuentos.Name = "lblImporteDescuentos"
        lblImporteDescuentos.Size = New Size(176, 28)
        lblImporteDescuentos.TabIndex = 13
        lblImporteDescuentos.Text = "$ 0,00"
        lblImporteDescuentos.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblImporteSinDescuentos
        ' 
        lblImporteSinDescuentos.Dock = DockStyle.Fill
        lblImporteSinDescuentos.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblImporteSinDescuentos.Location = New Point(949, 3)
        lblImporteSinDescuentos.Margin = New Padding(4, 0, 4, 0)
        lblImporteSinDescuentos.Name = "lblImporteSinDescuentos"
        lblImporteSinDescuentos.Size = New Size(176, 28)
        lblImporteSinDescuentos.TabIndex = 11
        lblImporteSinDescuentos.Text = "$ 0,00"
        lblImporteSinDescuentos.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblImporteSinDescuentosEtiqueta
        ' 
        lblImporteSinDescuentosEtiqueta.Dock = DockStyle.Fill
        lblImporteSinDescuentosEtiqueta.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblImporteSinDescuentosEtiqueta.Location = New Point(805, 3)
        lblImporteSinDescuentosEtiqueta.Margin = New Padding(4, 0, 4, 0)
        lblImporteSinDescuentosEtiqueta.Name = "lblImporteSinDescuentosEtiqueta"
        lblImporteSinDescuentosEtiqueta.Size = New Size(133, 28)
        lblImporteSinDescuentosEtiqueta.TabIndex = 6
        lblImporteSinDescuentosEtiqueta.Text = "Importe Bruto:"
        lblImporteSinDescuentosEtiqueta.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblImporteConDescuentosEtiqueta
        ' 
        lblImporteConDescuentosEtiqueta.Dock = DockStyle.Fill
        lblImporteConDescuentosEtiqueta.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblImporteConDescuentosEtiqueta.Location = New Point(805, 127)
        lblImporteConDescuentosEtiqueta.Margin = New Padding(4, 0, 4, 0)
        lblImporteConDescuentosEtiqueta.Name = "lblImporteConDescuentosEtiqueta"
        lblImporteConDescuentosEtiqueta.Size = New Size(133, 80)
        lblImporteConDescuentosEtiqueta.TabIndex = 20
        lblImporteConDescuentosEtiqueta.Text = "A pagar:  "
        lblImporteConDescuentosEtiqueta.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblImporteConDescuentos
        ' 
        lblImporteConDescuentos.Dock = DockStyle.Fill
        lblImporteConDescuentos.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblImporteConDescuentos.Location = New Point(949, 127)
        lblImporteConDescuentos.Margin = New Padding(4, 0, 4, 0)
        lblImporteConDescuentos.Name = "lblImporteConDescuentos"
        lblImporteConDescuentos.Size = New Size(176, 80)
        lblImporteConDescuentos.TabIndex = 14
        lblImporteConDescuentos.Text = "$ 0,00"
        lblImporteConDescuentos.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblImporteOSEtiqueta
        ' 
        lblImporteOSEtiqueta.Dock = DockStyle.Fill
        lblImporteOSEtiqueta.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblImporteOSEtiqueta.Location = New Point(805, 65)
        lblImporteOSEtiqueta.Margin = New Padding(4, 0, 4, 0)
        lblImporteOSEtiqueta.Name = "lblImporteOSEtiqueta"
        lblImporteOSEtiqueta.Size = New Size(133, 28)
        lblImporteOSEtiqueta.TabIndex = 21
        lblImporteOSEtiqueta.Text = "Obra Sociales:"
        lblImporteOSEtiqueta.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblImporteCSEtiqueda
        ' 
        lblImporteCSEtiqueda.Dock = DockStyle.Fill
        lblImporteCSEtiqueda.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblImporteCSEtiqueda.Location = New Point(805, 96)
        lblImporteCSEtiqueda.Margin = New Padding(4, 0, 4, 0)
        lblImporteCSEtiqueda.Name = "lblImporteCSEtiqueda"
        lblImporteCSEtiqueda.Size = New Size(133, 28)
        lblImporteCSEtiqueda.TabIndex = 22
        lblImporteCSEtiqueda.Text = "Coseguros:"
        lblImporteCSEtiqueda.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblImporteOS
        ' 
        lblImporteOS.Dock = DockStyle.Fill
        lblImporteOS.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblImporteOS.Location = New Point(949, 65)
        lblImporteOS.Margin = New Padding(4, 0, 4, 0)
        lblImporteOS.Name = "lblImporteOS"
        lblImporteOS.Size = New Size(176, 28)
        lblImporteOS.TabIndex = 23
        lblImporteOS.Text = "$ 0,00"
        lblImporteOS.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblImporteCS
        ' 
        lblImporteCS.Dock = DockStyle.Fill
        lblImporteCS.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblImporteCS.Location = New Point(949, 96)
        lblImporteCS.Margin = New Padding(4, 0, 4, 0)
        lblImporteCS.Name = "lblImporteCS"
        lblImporteCS.Size = New Size(176, 28)
        lblImporteCS.TabIndex = 24
        lblImporteCS.Text = "$ 0,00"
        lblImporteCS.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lblRecargoGeneral)
        Panel2.Controls.Add(lblDatosOperacion)
        Panel2.Controls.Add(lblCantidadItems)
        Panel2.Controls.Add(UcReceta1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(3, 3)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        tlyImportes.SetRowSpan(Panel2, 5)
        Panel2.Size = New Size(795, 204)
        Panel2.TabIndex = 25
        ' 
        ' lblRecargoGeneral
        ' 
        lblRecargoGeneral.AutoSize = True
        lblRecargoGeneral.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRecargoGeneral.Location = New Point(4, 31)
        lblRecargoGeneral.Margin = New Padding(4, 0, 4, 0)
        lblRecargoGeneral.Name = "lblRecargoGeneral"
        lblRecargoGeneral.Size = New Size(114, 17)
        lblRecargoGeneral.TabIndex = 32
        lblRecargoGeneral.Text = "- Recargo: 0,00 %"
        ' 
        ' lblDatosOperacion
        ' 
        lblDatosOperacion.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDatosOperacion.Location = New Point(0, 62)
        lblDatosOperacion.Margin = New Padding(0)
        lblDatosOperacion.Name = "lblDatosOperacion"
        lblDatosOperacion.Size = New Size(694, 132)
        lblDatosOperacion.TabIndex = 29
        lblDatosOperacion.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblCantidadItems
        ' 
        lblCantidadItems.AutoSize = True
        lblCantidadItems.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCantidadItems.Location = New Point(4, 3)
        lblCantidadItems.Margin = New Padding(4, 0, 4, 0)
        lblCantidadItems.Name = "lblCantidadItems"
        lblCantidadItems.Size = New Size(66, 17)
        lblCantidadItems.TabIndex = 30
        lblCantidadItems.Text = "- Items: 0"
        ' 
        ' UcReceta1
        ' 
        UcReceta1.Dock = DockStyle.Right
        UcReceta1.Location = New Point(343, 0)
        UcReceta1.Margin = New Padding(0)
        UcReceta1.Name = "UcReceta1"
        UcReceta1.Receta = Nothing
        UcReceta1.Size = New Size(358, 203)
        UcReceta1.TabIndex = 31
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.Controls.Add(ToolStrip1)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(7, 6)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1134, 68)
        Panel1.TabIndex = 0
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.AutoSize = False
        ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        ToolStrip1.Items.AddRange(New ToolStripItem() {btnNuevaReceta, btnDatosReceta, btnEliminarReceta, btnSolicitarAutorizacionReceta, btnCancelarAutorizacion, toolStripSeparator, btnDescuentoGeneral, btnRecargoGeneral, ClienteToolStripButton, AyudaToolStripButton, ToolStripButton1, ToolStripSeparator1, SalirToolStripButton})
        ToolStrip1.Location = New Point(0, 24)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1134, 44)
        ToolStrip1.TabIndex = 1
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' btnNuevaReceta
        ' 
        btnNuevaReceta.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnNuevaReceta.Image = CType(resources.GetObject("btnNuevaReceta.Image"), Image)
        btnNuevaReceta.ImageTransparentColor = Color.Magenta
        btnNuevaReceta.Name = "btnNuevaReceta"
        btnNuevaReceta.Size = New Size(23, 41)
        btnNuevaReceta.Text = "&Nueva Receta"
        btnNuevaReceta.ToolTipText = "Nueva Receta"
        ' 
        ' btnDatosReceta
        ' 
        btnDatosReceta.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnDatosReceta.Image = CType(resources.GetObject("btnDatosReceta.Image"), Image)
        btnDatosReceta.ImageTransparentColor = Color.Magenta
        btnDatosReceta.Name = "btnDatosReceta"
        btnDatosReceta.Size = New Size(23, 41)
        btnDatosReceta.Text = "&Datos Receta"
        btnDatosReceta.ToolTipText = "Datos Receta"
        ' 
        ' btnEliminarReceta
        ' 
        btnEliminarReceta.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnEliminarReceta.Image = CType(resources.GetObject("btnEliminarReceta.Image"), Image)
        btnEliminarReceta.ImageTransparentColor = Color.Magenta
        btnEliminarReceta.Name = "btnEliminarReceta"
        btnEliminarReceta.Size = New Size(23, 41)
        btnEliminarReceta.Text = "&Eliminar Receta"
        ' 
        ' btnSolicitarAutorizacionReceta
        ' 
        btnSolicitarAutorizacionReceta.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnSolicitarAutorizacionReceta.Image = CType(resources.GetObject("btnSolicitarAutorizacionReceta.Image"), Image)
        btnSolicitarAutorizacionReceta.ImageTransparentColor = Color.Magenta
        btnSolicitarAutorizacionReceta.Name = "btnSolicitarAutorizacionReceta"
        btnSolicitarAutorizacionReceta.Size = New Size(23, 41)
        btnSolicitarAutorizacionReceta.Text = "&Autorizar Receta"
        ' 
        ' btnCancelarAutorizacion
        ' 
        btnCancelarAutorizacion.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnCancelarAutorizacion.Image = CType(resources.GetObject("btnCancelarAutorizacion.Image"), Image)
        btnCancelarAutorizacion.ImageTransparentColor = Color.Magenta
        btnCancelarAutorizacion.Name = "btnCancelarAutorizacion"
        btnCancelarAutorizacion.Size = New Size(23, 41)
        btnCancelarAutorizacion.Text = "CancelarAutorizacion"
        btnCancelarAutorizacion.ToolTipText = "Cancelar Autorizacion"
        ' 
        ' toolStripSeparator
        ' 
        toolStripSeparator.Name = "toolStripSeparator"
        toolStripSeparator.Size = New Size(6, 44)
        ' 
        ' btnDescuentoGeneral
        ' 
        btnDescuentoGeneral.DisplayStyle = ToolStripItemDisplayStyle.Text
        btnDescuentoGeneral.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDescuentoGeneral.ImageTransparentColor = Color.Magenta
        btnDescuentoGeneral.Name = "btnDescuentoGeneral"
        btnDescuentoGeneral.Size = New Size(35, 41)
        btnDescuentoGeneral.Text = "↓%"
        btnDescuentoGeneral.ToolTipText = "Descuento General"
        ' 
        ' btnRecargoGeneral
        ' 
        btnRecargoGeneral.DisplayStyle = ToolStripItemDisplayStyle.Text
        btnRecargoGeneral.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRecargoGeneral.ImageTransparentColor = Color.Magenta
        btnRecargoGeneral.Name = "btnRecargoGeneral"
        btnRecargoGeneral.Size = New Size(35, 41)
        btnRecargoGeneral.Text = "↑%"
        btnRecargoGeneral.ToolTipText = "Recargo General"
        ' 
        ' ClienteToolStripButton
        ' 
        ClienteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ClienteToolStripButton.Image = CType(resources.GetObject("ClienteToolStripButton.Image"), Image)
        ClienteToolStripButton.ImageTransparentColor = Color.Magenta
        ClienteToolStripButton.Name = "ClienteToolStripButton"
        ClienteToolStripButton.Size = New Size(23, 41)
        ClienteToolStripButton.Text = "&Cliente"
        ' 
        ' AyudaToolStripButton
        ' 
        AyudaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AyudaToolStripButton.Image = CType(resources.GetObject("AyudaToolStripButton.Image"), Image)
        AyudaToolStripButton.ImageTransparentColor = Color.Magenta
        AyudaToolStripButton.Name = "AyudaToolStripButton"
        AyudaToolStripButton.Size = New Size(23, 41)
        AyudaToolStripButton.Text = "Ay&uda"
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(23, 41)
        ToolStripButton1.Text = "ToolStripButton1"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 44)
        ' 
        ' SalirToolStripButton
        ' 
        SalirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SalirToolStripButton.Image = CType(resources.GetObject("SalirToolStripButton.Image"), Image)
        SalirToolStripButton.ImageTransparentColor = Color.Magenta
        SalirToolStripButton.Name = "SalirToolStripButton"
        SalirToolStripButton.Size = New Size(23, 41)
        SalirToolStripButton.Text = "&Salir"
        SalirToolStripButton.ToolTipText = "Salir"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuArchivo, mnuEditarItemSeleccionado, mnuObrasSociales, mnuProcesos, mnuOpciones})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 2, 0, 2)
        MenuStrip1.Size = New Size(1134, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuArchivo
        ' 
        mnuArchivo.DropDownItems.AddRange(New ToolStripItem() {mnuGuardar, mnuSalir})
        mnuArchivo.Name = "mnuArchivo"
        mnuArchivo.Size = New Size(60, 20)
        mnuArchivo.Text = "&Archivo"
        ' 
        ' mnuGuardar
        ' 
        mnuGuardar.Image = CType(resources.GetObject("mnuGuardar.Image"), Image)
        mnuGuardar.Name = "mnuGuardar"
        mnuGuardar.Size = New Size(116, 22)
        mnuGuardar.Text = "&Guardar"
        ' 
        ' mnuSalir
        ' 
        mnuSalir.Image = CType(resources.GetObject("mnuSalir.Image"), Image)
        mnuSalir.Name = "mnuSalir"
        mnuSalir.Size = New Size(116, 22)
        mnuSalir.Text = "&Salir"
        ' 
        ' mnuEditarItemSeleccionado
        ' 
        mnuEditarItemSeleccionado.DropDownItems.AddRange(New ToolStripItem() {mnuEliminarItemSeleccionado, mnuAplicarDescuentoItemSeleccionado, mnuModificarPrecioItemSeleccionado, mnuPresentacionesEquivalentes, mnuPresentacionesConIgualAccionFarmacologica, mnuPresentacionesConIgualMonodroga})
        mnuEditarItemSeleccionado.Name = "mnuEditarItemSeleccionado"
        mnuEditarItemSeleccionado.Size = New Size(76, 20)
        mnuEditarItemSeleccionado.Text = "&Editar Item"
        ' 
        ' mnuEliminarItemSeleccionado
        ' 
        mnuEliminarItemSeleccionado.Image = CType(resources.GetObject("mnuEliminarItemSeleccionado.Image"), Image)
        mnuEliminarItemSeleccionado.Name = "mnuEliminarItemSeleccionado"
        mnuEliminarItemSeleccionado.ShortcutKeys = Keys.Control Or Keys.E
        mnuEliminarItemSeleccionado.Size = New Size(328, 22)
        mnuEliminarItemSeleccionado.Text = "&Elimininar Item seleccionado"
        ' 
        ' mnuAplicarDescuentoItemSeleccionado
        ' 
        mnuAplicarDescuentoItemSeleccionado.Image = CType(resources.GetObject("mnuAplicarDescuentoItemSeleccionado.Image"), Image)
        mnuAplicarDescuentoItemSeleccionado.Name = "mnuAplicarDescuentoItemSeleccionado"
        mnuAplicarDescuentoItemSeleccionado.ShortcutKeys = Keys.Control Or Keys.D
        mnuAplicarDescuentoItemSeleccionado.Size = New Size(328, 22)
        mnuAplicarDescuentoItemSeleccionado.Text = "Aplicar &Descuento Item seleccionado"
        ' 
        ' mnuModificarPrecioItemSeleccionado
        ' 
        mnuModificarPrecioItemSeleccionado.Image = CType(resources.GetObject("mnuModificarPrecioItemSeleccionado.Image"), Image)
        mnuModificarPrecioItemSeleccionado.Name = "mnuModificarPrecioItemSeleccionado"
        mnuModificarPrecioItemSeleccionado.ShortcutKeys = Keys.Control Or Keys.P
        mnuModificarPrecioItemSeleccionado.Size = New Size(328, 22)
        mnuModificarPrecioItemSeleccionado.Text = "&Modificar precio Item seleccionado"
        ' 
        ' mnuPresentacionesEquivalentes
        ' 
        mnuPresentacionesEquivalentes.Image = CType(resources.GetObject("mnuPresentacionesEquivalentes.Image"), Image)
        mnuPresentacionesEquivalentes.Name = "mnuPresentacionesEquivalentes"
        mnuPresentacionesEquivalentes.ShortcutKeys = Keys.F2
        mnuPresentacionesEquivalentes.Size = New Size(328, 22)
        mnuPresentacionesEquivalentes.Text = "Presentaciones Equivalentes"
        ' 
        ' mnuPresentacionesConIgualAccionFarmacologica
        ' 
        mnuPresentacionesConIgualAccionFarmacologica.Image = CType(resources.GetObject("mnuPresentacionesConIgualAccionFarmacologica.Image"), Image)
        mnuPresentacionesConIgualAccionFarmacologica.Name = "mnuPresentacionesConIgualAccionFarmacologica"
        mnuPresentacionesConIgualAccionFarmacologica.ShortcutKeys = Keys.F5
        mnuPresentacionesConIgualAccionFarmacologica.Size = New Size(328, 22)
        mnuPresentacionesConIgualAccionFarmacologica.Text = "Presentaciones con igual Acc.Farmacologica"
        ' 
        ' mnuPresentacionesConIgualMonodroga
        ' 
        mnuPresentacionesConIgualMonodroga.Image = CType(resources.GetObject("mnuPresentacionesConIgualMonodroga.Image"), Image)
        mnuPresentacionesConIgualMonodroga.Name = "mnuPresentacionesConIgualMonodroga"
        mnuPresentacionesConIgualMonodroga.ShortcutKeys = Keys.F6
        mnuPresentacionesConIgualMonodroga.Size = New Size(328, 22)
        mnuPresentacionesConIgualMonodroga.Text = "Presentaciones con igual Monodroga"
        ' 
        ' mnuObrasSociales
        ' 
        mnuObrasSociales.DropDownItems.AddRange(New ToolStripItem() {mnuNuevaReceta, mnuDatosReceta, mnuElinarReceta, mnuAutorizarReceta, mnuCancelarAutorizacion})
        mnuObrasSociales.Name = "mnuObrasSociales"
        mnuObrasSociales.Size = New Size(95, 20)
        mnuObrasSociales.Text = "&Obras Sociales"
        ' 
        ' mnuNuevaReceta
        ' 
        mnuNuevaReceta.Image = CType(resources.GetObject("mnuNuevaReceta.Image"), Image)
        mnuNuevaReceta.Name = "mnuNuevaReceta"
        mnuNuevaReceta.ShortcutKeyDisplayString = ""
        mnuNuevaReceta.ShortcutKeys = Keys.Control Or Keys.R
        mnuNuevaReceta.Size = New Size(190, 22)
        mnuNuevaReceta.Text = "Nueva Receta"
        ' 
        ' mnuDatosReceta
        ' 
        mnuDatosReceta.Image = CType(resources.GetObject("mnuDatosReceta.Image"), Image)
        mnuDatosReceta.Name = "mnuDatosReceta"
        mnuDatosReceta.ShortcutKeys = Keys.Control Or Keys.I
        mnuDatosReceta.Size = New Size(190, 22)
        mnuDatosReceta.Text = "Datos Receta"
        ' 
        ' mnuElinarReceta
        ' 
        mnuElinarReceta.Image = CType(resources.GetObject("mnuElinarReceta.Image"), Image)
        mnuElinarReceta.Name = "mnuElinarReceta"
        mnuElinarReceta.ShortcutKeys = Keys.Control Or Keys.T
        mnuElinarReceta.Size = New Size(190, 22)
        mnuElinarReceta.Text = "Elinar Receta"
        ' 
        ' mnuAutorizarReceta
        ' 
        mnuAutorizarReceta.Image = CType(resources.GetObject("mnuAutorizarReceta.Image"), Image)
        mnuAutorizarReceta.Name = "mnuAutorizarReceta"
        mnuAutorizarReceta.ShortcutKeys = Keys.F12
        mnuAutorizarReceta.Size = New Size(190, 22)
        mnuAutorizarReceta.Text = "Autorizar Receta"
        ' 
        ' mnuCancelarAutorizacion
        ' 
        mnuCancelarAutorizacion.Image = CType(resources.GetObject("mnuCancelarAutorizacion.Image"), Image)
        mnuCancelarAutorizacion.Name = "mnuCancelarAutorizacion"
        mnuCancelarAutorizacion.Size = New Size(190, 22)
        mnuCancelarAutorizacion.Text = "Cancelar Autorizacion"
        ' 
        ' mnuProcesos
        ' 
        mnuProcesos.DropDownItems.AddRange(New ToolStripItem() {FacturarToolStripMenuItem, RemitoToolStripMenuItem, PresupuestoToolStripMenuItem})
        mnuProcesos.Name = "mnuProcesos"
        mnuProcesos.Size = New Size(66, 20)
        mnuProcesos.Text = "&Procesos"
        ' 
        ' FacturarToolStripMenuItem
        ' 
        FacturarToolStripMenuItem.Name = "FacturarToolStripMenuItem"
        FacturarToolStripMenuItem.ShortcutKeyDisplayString = "F10"
        FacturarToolStripMenuItem.Size = New Size(158, 22)
        FacturarToolStripMenuItem.Text = "&Facturar"
        ' 
        ' RemitoToolStripMenuItem
        ' 
        RemitoToolStripMenuItem.Name = "RemitoToolStripMenuItem"
        RemitoToolStripMenuItem.ShortcutKeyDisplayString = "F9"
        RemitoToolStripMenuItem.Size = New Size(158, 22)
        RemitoToolStripMenuItem.Text = "&Remito"
        ' 
        ' PresupuestoToolStripMenuItem
        ' 
        PresupuestoToolStripMenuItem.Name = "PresupuestoToolStripMenuItem"
        PresupuestoToolStripMenuItem.ShortcutKeyDisplayString = "F8"
        PresupuestoToolStripMenuItem.Size = New Size(158, 22)
        PresupuestoToolStripMenuItem.Text = "&Presupuesto"
        ' 
        ' mnuOpciones
        ' 
        mnuOpciones.DropDownItems.AddRange(New ToolStripItem() {mnuDescuentoGeneral, mnuRecargoGeneral})
        mnuOpciones.Name = "mnuOpciones"
        mnuOpciones.Size = New Size(69, 20)
        mnuOpciones.Text = "Opcio&nes"
        ' 
        ' mnuDescuentoGeneral
        ' 
        mnuDescuentoGeneral.Name = "mnuDescuentoGeneral"
        mnuDescuentoGeneral.ShortcutKeys = Keys.F8
        mnuDescuentoGeneral.Size = New Size(211, 22)
        mnuDescuentoGeneral.Text = "↓% Descuento General"
        ' 
        ' mnuRecargoGeneral
        ' 
        mnuRecargoGeneral.Name = "mnuRecargoGeneral"
        mnuRecargoGeneral.ShortcutKeys = Keys.F7
        mnuRecargoGeneral.Size = New Size(211, 22)
        mnuRecargoGeneral.Text = "↑% Recargo General"
        ' 
        ' PanelItems
        ' 
        PanelItems.BackColor = SystemColors.Window
        PanelItems.Dock = DockStyle.Fill
        PanelItems.Location = New Point(7, 121)
        PanelItems.Margin = New Padding(4, 3, 4, 3)
        PanelItems.Name = "PanelItems"
        PanelItems.Size = New Size(1134, 414)
        PanelItems.TabIndex = 6
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 10
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 175F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 52F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 52F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 52F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 117F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 117F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 58F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 117F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 117F))
        TableLayoutPanel1.Controls.Add(Label8, 4, 0)
        TableLayoutPanel1.Controls.Add(Label7, 9, 0)
        TableLayoutPanel1.Controls.Add(Label6, 8, 0)
        TableLayoutPanel1.Controls.Add(Label5, 7, 0)
        TableLayoutPanel1.Controls.Add(Label4, 6, 0)
        TableLayoutPanel1.Controls.Add(Label3, 5, 0)
        TableLayoutPanel1.Controls.Add(Label2, 3, 0)
        TableLayoutPanel1.Controls.Add(Label1, 2, 0)
        TableLayoutPanel1.Controls.Add(lblDescripcion, 1, 0)
        TableLayoutPanel1.Controls.Add(lblCodigo, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(7, 83)
        TableLayoutPanel1.Margin = New Padding(4, 3, 4, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1134, 29)
        TableLayoutPanel1.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Dock = DockStyle.Fill
        Label8.Location = New Point(560, 0)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(44, 29)
        Label8.TabIndex = 9
        Label8.Text = "Iva"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Dock = DockStyle.Fill
        Label7.Location = New Point(1021, 0)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(109, 29)
        Label7.TabIndex = 8
        Label7.Text = "Imp. Cliente"
        Label7.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Dock = DockStyle.Fill
        Label6.Location = New Point(904, 0)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 29)
        Label6.TabIndex = 7
        Label6.Text = "Imp. Descuento"
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Fill
        Label5.Location = New Point(846, 0)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 29)
        Label5.TabIndex = 6
        Label5.Text = "% Desc"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Location = New Point(729, 0)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 29)
        Label4.TabIndex = 5
        Label4.Text = "Importe"
        Label4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Fill
        Label3.Location = New Point(612, 0)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 29)
        Label3.TabIndex = 4
        Label3.Text = "Prec. Unit."
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Location = New Point(508, 0)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 29)
        Label2.TabIndex = 3
        Label2.Text = "Cant"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Location = New Point(456, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 29)
        Label1.TabIndex = 2
        Label1.Text = "Frac"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.AutoSize = True
        lblDescripcion.Dock = DockStyle.Fill
        lblDescripcion.Location = New Point(179, 0)
        lblDescripcion.Margin = New Padding(4, 0, 4, 0)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(269, 29)
        lblDescripcion.TabIndex = 1
        lblDescripcion.Text = "Descripción"
        lblDescripcion.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblCodigo
        ' 
        lblCodigo.AutoSize = True
        lblCodigo.Dock = DockStyle.Fill
        lblCodigo.Location = New Point(4, 0)
        lblCodigo.Margin = New Padding(4, 0, 4, 0)
        lblCodigo.Name = "lblCodigo"
        lblCodigo.Size = New Size(167, 29)
        lblCodigo.TabIndex = 0
        lblCodigo.Text = "Código"
        lblCodigo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FrmVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1148, 763)
        Controls.Add(tlyGeneral)
        KeyPreview = True
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "FrmVentas"
        tlyGeneral.ResumeLayout(False)
        tlyGeneral.PerformLayout()
        Panel3.ResumeLayout(False)
        tlyImportes.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents tlyGeneral As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuArchivo As ToolStripMenuItem
    Friend WithEvents mnuEditarItemSeleccionado As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnNuevaReceta As ToolStripButton
    Friend WithEvents btnDatosReceta As ToolStripButton
    Friend WithEvents btnEliminarReceta As ToolStripButton
    Friend WithEvents btnSolicitarAutorizacionReceta As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents btnCancelarAutorizacion As ToolStripButton
    Friend WithEvents btnRecargoGeneral As ToolStripButton
    Friend WithEvents AyudaToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuEliminarItemSeleccionado As ToolStripMenuItem
    Friend WithEvents mnuAplicarDescuentoItemSeleccionado As ToolStripMenuItem
    Friend WithEvents mnuGuardar As ToolStripMenuItem
    Friend WithEvents mnuSalir As ToolStripMenuItem
    Friend WithEvents mnuModificarPrecioItemSeleccionado As ToolStripMenuItem
    Friend WithEvents SalirToolStripButton As ToolStripButton
    Friend WithEvents mnuProcesos As ToolStripMenuItem
    Friend WithEvents FacturarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemitoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PresupuestoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripButton As ToolStripButton
    Friend WithEvents btnDescuentoGeneral As ToolStripButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tlyImportes As TableLayoutPanel
    Friend WithEvents lblDescuentos As Label
    Friend WithEvents lblImporteDescuentos As Label
    Friend WithEvents lblImporteSinDescuentos As Label
    Friend WithEvents lblImporteConDescuentos As Label
    Friend WithEvents PanelItems As Panel
    Friend WithEvents lblImporteConDescuentosEtiqueta As Label
    Friend WithEvents lblImporteOSEtiqueta As Label
    Friend WithEvents lblImporteCSEtiqueda As Label
    Friend WithEvents lblImporteOS As Label
    Friend WithEvents lblImporteCS As Label
    Friend WithEvents lblImporteSinDescuentosEtiqueta As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UcReceta1 As UcReceta
    Friend WithEvents lblDatosOperacion As Label
    Friend WithEvents lblCantidadItems As Label
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents mnuObrasSociales As ToolStripMenuItem
    Friend WithEvents mnuNuevaReceta As ToolStripMenuItem
    Friend WithEvents mnuDatosReceta As ToolStripMenuItem
    Friend WithEvents mnuElinarReceta As ToolStripMenuItem
    Friend WithEvents mnuAutorizarReceta As ToolStripMenuItem
    Friend WithEvents mnuCancelarAutorizacion As ToolStripMenuItem
    Friend WithEvents mnuPresentacionesConIgualAccionFarmacologica As ToolStripMenuItem
    Friend WithEvents mnuPresentacionesEquivalentes As ToolStripMenuItem
    Friend WithEvents mnuPresentacionesConIgualMonodroga As ToolStripMenuItem
    Friend WithEvents mnuOpciones As ToolStripMenuItem
    Friend WithEvents mnuDescuentoGeneral As ToolStripMenuItem
    Friend WithEvents mnuRecargoGeneral As ToolStripMenuItem
    Friend WithEvents lblRecargoGeneral As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class

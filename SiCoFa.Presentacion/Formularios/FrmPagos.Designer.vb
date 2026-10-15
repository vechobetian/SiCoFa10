<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPagos
    'Inherits System.Windows.Forms.Form
    Inherits clsFrmBase

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPagos))
        PanelDatosCliente = New Panel()
        lblPagoElectronico = New Label()
        lblNumeroDocumento = New Label()
        lblTipoContribuyente = New Label()
        lblNombreCliente = New Label()
        lblPagoElectronicoEtiqueta = New Label()
        lblTipoDocumento = New Label()
        lblTipoContribuyenteEtiqueta = New Label()
        lblNombreClienteEtiqueta = New Label()
        Panel1 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        btnPagoElectronico = New Button()
        btnCuentaCorriente = New Button()
        txtImporteCuentaCorriente = New TextBox()
        txtImporteEfectivo = New TextBox()
        txtImporteAPagar = New TextBox()
        txtTipoComprobante = New TextBox()
        txtImportePagoElectronico = New TextBox()
        lblImportePagoElectronico = New Label()
        lblImporteCuentaCorriente = New Label()
        lblImporteEfectivo = New Label()
        lblImpAPagar = New Label()
        lblTipoComprobante = New Label()
        btnFinalizar = New Button()
        PanelDatosCliente.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelDatosCliente
        ' 
        PanelDatosCliente.BorderStyle = BorderStyle.FixedSingle
        PanelDatosCliente.Controls.Add(lblPagoElectronico)
        PanelDatosCliente.Controls.Add(lblNumeroDocumento)
        PanelDatosCliente.Controls.Add(lblTipoContribuyente)
        PanelDatosCliente.Controls.Add(lblNombreCliente)
        PanelDatosCliente.Controls.Add(lblPagoElectronicoEtiqueta)
        PanelDatosCliente.Controls.Add(lblTipoDocumento)
        PanelDatosCliente.Controls.Add(lblTipoContribuyenteEtiqueta)
        PanelDatosCliente.Controls.Add(lblNombreClienteEtiqueta)
        PanelDatosCliente.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        PanelDatosCliente.Location = New Point(14, 14)
        PanelDatosCliente.Margin = New Padding(4, 3, 4, 3)
        PanelDatosCliente.Name = "PanelDatosCliente"
        PanelDatosCliente.Size = New Size(968, 227)
        PanelDatosCliente.TabIndex = 0
        ' 
        ' lblPagoElectronico
        ' 
        lblPagoElectronico.AccessibleDescription = "IVACliente"
        lblPagoElectronico.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPagoElectronico.Location = New Point(394, 177)
        lblPagoElectronico.Margin = New Padding(4, 0, 4, 0)
        lblPagoElectronico.Name = "lblPagoElectronico"
        lblPagoElectronico.Size = New Size(568, 33)
        lblPagoElectronico.TabIndex = 7
        lblPagoElectronico.Text = "No Establecido"
        ' 
        ' lblNumeroDocumento
        ' 
        lblNumeroDocumento.AccessibleDescription = "IVACliente"
        lblNumeroDocumento.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNumeroDocumento.Location = New Point(394, 111)
        lblNumeroDocumento.Margin = New Padding(4, 0, 4, 0)
        lblNumeroDocumento.Name = "lblNumeroDocumento"
        lblNumeroDocumento.Size = New Size(563, 33)
        lblNumeroDocumento.TabIndex = 6
        lblNumeroDocumento.Text = "No Aplica"
        ' 
        ' lblTipoContribuyente
        ' 
        lblTipoContribuyente.AccessibleDescription = "IVACliente"
        lblTipoContribuyente.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTipoContribuyente.Location = New Point(394, 63)
        lblTipoContribuyente.Margin = New Padding(4, 0, 4, 0)
        lblTipoContribuyente.Name = "lblTipoContribuyente"
        lblTipoContribuyente.Size = New Size(568, 33)
        lblTipoContribuyente.TabIndex = 5
        lblTipoContribuyente.Text = "Consumidor Final"
        ' 
        ' lblNombreCliente
        ' 
        lblNombreCliente.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNombreCliente.Location = New Point(176, 10)
        lblNombreCliente.Margin = New Padding(4, 0, 4, 0)
        lblNombreCliente.Name = "lblNombreCliente"
        lblNombreCliente.Size = New Size(786, 43)
        lblNombreCliente.TabIndex = 4
        lblNombreCliente.Text = "Consumidor Final"
        ' 
        ' lblPagoElectronicoEtiqueta
        ' 
        lblPagoElectronicoEtiqueta.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPagoElectronicoEtiqueta.Location = New Point(14, 177)
        lblPagoElectronicoEtiqueta.Margin = New Padding(4, 0, 4, 0)
        lblPagoElectronicoEtiqueta.Name = "lblPagoElectronicoEtiqueta"
        lblPagoElectronicoEtiqueta.Size = New Size(382, 33)
        lblPagoElectronicoEtiqueta.TabIndex = 3
        lblPagoElectronicoEtiqueta.Text = "Tarjeta / Pago Electronico:"
        ' 
        ' lblTipoDocumento
        ' 
        lblTipoDocumento.AutoSize = True
        lblTipoDocumento.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTipoDocumento.Location = New Point(16, 111)
        lblTipoDocumento.Margin = New Padding(4, 0, 4, 0)
        lblTipoDocumento.Name = "lblTipoDocumento"
        lblTipoDocumento.Size = New Size(64, 29)
        lblTipoDocumento.TabIndex = 2
        lblTipoDocumento.Text = "DNI:"
        ' 
        ' lblTipoContribuyenteEtiqueta
        ' 
        lblTipoContribuyenteEtiqueta.AccessibleDescription = "IVACliente"
        lblTipoContribuyenteEtiqueta.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTipoContribuyenteEtiqueta.Location = New Point(14, 63)
        lblTipoContribuyenteEtiqueta.Margin = New Padding(4, 0, 4, 0)
        lblTipoContribuyenteEtiqueta.Name = "lblTipoContribuyenteEtiqueta"
        lblTipoContribuyenteEtiqueta.Size = New Size(331, 33)
        lblTipoContribuyenteEtiqueta.TabIndex = 1
        lblTipoContribuyenteEtiqueta.Text = "Tipo de Contribuyente:"
        ' 
        ' lblNombreClienteEtiqueta
        ' 
        lblNombreClienteEtiqueta.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNombreClienteEtiqueta.Location = New Point(14, 10)
        lblNombreClienteEtiqueta.Margin = New Padding(4, 0, 4, 0)
        lblNombreClienteEtiqueta.Name = "lblNombreClienteEtiqueta"
        lblNombreClienteEtiqueta.Size = New Size(155, 43)
        lblNombreClienteEtiqueta.TabIndex = 0
        lblNombreClienteEtiqueta.Text = "Cliente:"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnPagoElectronico)
        Panel1.Controls.Add(btnCuentaCorriente)
        Panel1.Controls.Add(txtImporteCuentaCorriente)
        Panel1.Controls.Add(txtImporteEfectivo)
        Panel1.Controls.Add(txtImporteAPagar)
        Panel1.Controls.Add(txtTipoComprobante)
        Panel1.Controls.Add(txtImportePagoElectronico)
        Panel1.Controls.Add(lblImportePagoElectronico)
        Panel1.Controls.Add(lblImporteCuentaCorriente)
        Panel1.Controls.Add(lblImporteEfectivo)
        Panel1.Controls.Add(lblImpAPagar)
        Panel1.Controls.Add(lblTipoComprobante)
        Panel1.Location = New Point(14, 248)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(968, 266)
        Panel1.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Enabled = False
        Button2.FlatAppearance.BorderColor = Color.White
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(316, 207)
        Button2.Margin = New Padding(4, 3, 4, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(30, 30)
        Button2.TabIndex = 10
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Enabled = False
        Button1.FlatAppearance.BorderColor = Color.White
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(316, 65)
        Button1.Margin = New Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(30, 30)
        Button1.TabIndex = 9
        Button1.Text = "$"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnPagoElectronico
        ' 
        btnPagoElectronico.Cursor = Cursors.Hand
        btnPagoElectronico.Image = CType(resources.GetObject("btnPagoElectronico.Image"), Image)
        btnPagoElectronico.Location = New Point(316, 160)
        btnPagoElectronico.Margin = New Padding(4, 3, 4, 3)
        btnPagoElectronico.Name = "btnPagoElectronico"
        btnPagoElectronico.Size = New Size(30, 30)
        btnPagoElectronico.TabIndex = 8
        btnPagoElectronico.TabStop = False
        btnPagoElectronico.UseVisualStyleBackColor = True
        ' 
        ' btnCuentaCorriente
        ' 
        btnCuentaCorriente.Cursor = Cursors.Hand
        btnCuentaCorriente.Image = CType(resources.GetObject("btnCuentaCorriente.Image"), Image)
        btnCuentaCorriente.Location = New Point(316, 113)
        btnCuentaCorriente.Margin = New Padding(4, 3, 4, 3)
        btnCuentaCorriente.Name = "btnCuentaCorriente"
        btnCuentaCorriente.Size = New Size(30, 30)
        btnCuentaCorriente.TabIndex = 7
        btnCuentaCorriente.TabStop = False
        btnCuentaCorriente.UseVisualStyleBackColor = True
        ' 
        ' txtImporteCuentaCorriente
        ' 
        txtImporteCuentaCorriente.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtImporteCuentaCorriente.Location = New Point(315, 110)
        txtImporteCuentaCorriente.Margin = New Padding(4, 3, 4, 3)
        txtImporteCuentaCorriente.Name = "txtImporteCuentaCorriente"
        txtImporteCuentaCorriente.Size = New Size(641, 35)
        txtImporteCuentaCorriente.TabIndex = 4
        txtImporteCuentaCorriente.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtImporteEfectivo
        ' 
        txtImporteEfectivo.BackColor = Color.White
        txtImporteEfectivo.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtImporteEfectivo.Location = New Point(315, 204)
        txtImporteEfectivo.Margin = New Padding(4, 3, 4, 3)
        txtImporteEfectivo.Name = "txtImporteEfectivo"
        txtImporteEfectivo.ReadOnly = True
        txtImporteEfectivo.Size = New Size(641, 35)
        txtImporteEfectivo.TabIndex = 6
        txtImporteEfectivo.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtImporteAPagar
        ' 
        txtImporteAPagar.BackColor = Color.White
        txtImporteAPagar.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtImporteAPagar.Location = New Point(315, 62)
        txtImporteAPagar.Margin = New Padding(4, 3, 4, 3)
        txtImporteAPagar.Name = "txtImporteAPagar"
        txtImporteAPagar.ReadOnly = True
        txtImporteAPagar.Size = New Size(641, 35)
        txtImporteAPagar.TabIndex = 3
        txtImporteAPagar.TabStop = False
        txtImporteAPagar.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtTipoComprobante
        ' 
        txtTipoComprobante.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTipoComprobante.Location = New Point(315, 15)
        txtTipoComprobante.Margin = New Padding(4, 3, 4, 3)
        txtTipoComprobante.Name = "txtTipoComprobante"
        txtTipoComprobante.Size = New Size(641, 35)
        txtTipoComprobante.TabIndex = 1
        txtTipoComprobante.TabStop = False
        ' 
        ' txtImportePagoElectronico
        ' 
        txtImportePagoElectronico.Enabled = False
        txtImportePagoElectronico.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtImportePagoElectronico.Location = New Point(315, 157)
        txtImportePagoElectronico.Margin = New Padding(4, 3, 4, 3)
        txtImportePagoElectronico.Name = "txtImportePagoElectronico"
        txtImportePagoElectronico.Size = New Size(641, 35)
        txtImportePagoElectronico.TabIndex = 5
        txtImportePagoElectronico.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblImportePagoElectronico
        ' 
        lblImportePagoElectronico.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblImportePagoElectronico.Location = New Point(16, 160)
        lblImportePagoElectronico.Margin = New Padding(4, 0, 4, 0)
        lblImportePagoElectronico.Name = "lblImportePagoElectronico"
        lblImportePagoElectronico.Size = New Size(292, 35)
        lblImportePagoElectronico.TabIndex = 6
        lblImportePagoElectronico.Text = "Tarjeta / Pago Elec:"
        ' 
        ' lblImporteCuentaCorriente
        ' 
        lblImporteCuentaCorriente.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblImporteCuentaCorriente.Location = New Point(16, 113)
        lblImporteCuentaCorriente.Margin = New Padding(4, 0, 4, 0)
        lblImporteCuentaCorriente.Name = "lblImporteCuentaCorriente"
        lblImporteCuentaCorriente.Size = New Size(292, 35)
        lblImporteCuentaCorriente.TabIndex = 5
        lblImporteCuentaCorriente.Text = "Importe Cta. Cte:"
        ' 
        ' lblImporteEfectivo
        ' 
        lblImporteEfectivo.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblImporteEfectivo.Location = New Point(16, 208)
        lblImporteEfectivo.Margin = New Padding(4, 0, 4, 0)
        lblImporteEfectivo.Name = "lblImporteEfectivo"
        lblImporteEfectivo.Size = New Size(292, 35)
        lblImporteEfectivo.TabIndex = 4
        lblImporteEfectivo.Text = "Importe Efectivo:"
        ' 
        ' lblImpAPagar
        ' 
        lblImpAPagar.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblImpAPagar.Location = New Point(16, 66)
        lblImpAPagar.Margin = New Padding(4, 0, 4, 0)
        lblImpAPagar.Name = "lblImpAPagar"
        lblImpAPagar.Size = New Size(292, 35)
        lblImpAPagar.TabIndex = 3
        lblImpAPagar.Text = "Importe a Pagar:"
        ' 
        ' lblTipoComprobante
        ' 
        lblTipoComprobante.AccessibleDescription = "IVACliente"
        lblTipoComprobante.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTipoComprobante.Location = New Point(18, 18)
        lblTipoComprobante.Margin = New Padding(4, 0, 4, 0)
        lblTipoComprobante.Name = "lblTipoComprobante"
        lblTipoComprobante.Size = New Size(292, 35)
        lblTipoComprobante.TabIndex = 1
        lblTipoComprobante.Text = "Comprobante:"
        ' 
        ' btnFinalizar
        ' 
        btnFinalizar.Cursor = Cursors.Hand
        btnFinalizar.FlatAppearance.BorderColor = Color.White
        btnFinalizar.FlatStyle = FlatStyle.Flat
        btnFinalizar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFinalizar.ForeColor = SystemColors.Highlight
        btnFinalizar.Image = CType(resources.GetObject("btnFinalizar.Image"), Image)
        btnFinalizar.ImageAlign = ContentAlignment.MiddleLeft
        btnFinalizar.Location = New Point(794, 531)
        btnFinalizar.Margin = New Padding(4, 3, 4, 3)
        btnFinalizar.Name = "btnFinalizar"
        btnFinalizar.Size = New Size(188, 46)
        btnFinalizar.TabIndex = 2
        btnFinalizar.TabStop = False
        btnFinalizar.Text = "&Finalizar (F10)"
        btnFinalizar.UseVisualStyleBackColor = True
        ' 
        ' FrmPagos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1000, 591)
        ControlBox = False
        Controls.Add(btnFinalizar)
        Controls.Add(Panel1)
        Controls.Add(PanelDatosCliente)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        Name = "FrmPagos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pagos del Cliente"
        PanelDatosCliente.ResumeLayout(False)
        PanelDatosCliente.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelDatosCliente As Panel
    Friend WithEvents lblNombreClienteEtiqueta As Label
    Friend WithEvents lblTipoDocumento As Label
    Friend WithEvents lblTipoContribuyenteEtiqueta As Label
    Friend WithEvents lblPagoElectronicoEtiqueta As Label
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents lblNumeroDocumento As Label
    Friend WithEvents lblTipoContribuyente As Label
    Friend WithEvents lblPagoElectronico As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblImpAPagar As Label
    Friend WithEvents lblTipoComprobante As Label
    Friend WithEvents lblImportePagoElectronico As Label
    Friend WithEvents lblImporteCuentaCorriente As Label
    Friend WithEvents lblImporteEfectivo As Label
    Friend WithEvents txtImportePagoElectronico As TextBox
    Friend WithEvents txtImporteCuentaCorriente As TextBox
    Friend WithEvents txtImporteEfectivo As TextBox
    Friend WithEvents txtImporteAPagar As TextBox
    Friend WithEvents txtTipoComprobante As TextBox
    Friend WithEvents btnCuentaCorriente As Button
    Friend WithEvents btnPagoElectronico As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents Button1 As Button
End Class

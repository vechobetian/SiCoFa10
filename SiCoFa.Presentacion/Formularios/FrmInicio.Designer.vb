<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInicio
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
        MenuStrip1 = New MenuStrip()
        mnuOperaciones = New ToolStripMenuItem()
        mnuOperacionesFacturacion = New ToolStripMenuItem()
        mnuOperacionesCC = New ToolStripMenuItem()
        mnuOperacionesCompras = New ToolStripMenuItem()
        mnuCaja = New ToolStripMenuItem()
        mnuCajaMovimientos = New ToolStripMenuItem()
        mnuCajaAsientoGastos = New ToolStripMenuItem()
        mnuFiscal = New ToolStripMenuItem()
        mnuFiscalLibroIVA = New ToolStripMenuItem()
        mnuFiscalIVADigital = New ToolStripMenuItem()
        mnuFiscalIVAExcel = New ToolStripMenuItem()
        mnuContabilidad = New ToolStripMenuItem()
        mnuContabilidadResultadosMensuales = New ToolStripMenuItem()
        mnuContabilidadSaldoCuentaPatrimoniales = New ToolStripMenuItem()
        AsientoContableToolStripMenuItem = New ToolStripMenuItem()
        CancelarCuentasIncobraToolStripMenuItem = New ToolStripMenuItem()
        CierreEjercicioAbiertoToolStripMenuItem = New ToolStripMenuItem()
        mnuAuditoria = New ToolStripMenuItem()
        mnuAuditoriaCuentasCorrientes = New ToolStripMenuItem()
        mnuAuditoriaComprobantes = New ToolStripMenuItem()
        mnuAuditoriaComprobantesEmitidos = New ToolStripMenuItem()
        mnuAuditoriaComprobantesRecibidos = New ToolStripMenuItem()
        mnuAuditoriaReporteVentas = New ToolStripMenuItem()
        mnuAuditoriaCuentasProveedores = New ToolStripMenuItem()
        mnuAuditoriaCuentasBancarias = New ToolStripMenuItem()
        mnuAuditoriaCuentasEmpleados = New ToolStripMenuItem()
        mnuAuditoriaMovimientoDeProductos = New ToolStripMenuItem()
        mnuAuditoriaRankingDeVentas = New ToolStripMenuItem()
        mnuEditar = New ToolStripMenuItem()
        mnuEditarArticulos = New ToolStripMenuItem()
        mnuEditarFraccionables = New ToolStripMenuItem()
        mnuEditarClientes = New ToolStripMenuItem()
        mnuEditarEmpleados = New ToolStripMenuItem()
        mnuEditarUsuarios = New ToolStripMenuItem()
        mnuEditarProveedores = New ToolStripMenuItem()
        mnuEditarSecciones = New ToolStripMenuItem()
        mnuEditarCuentasBancarias = New ToolStripMenuItem()
        mnuEditarMedioPE = New ToolStripMenuItem()
        mnuEditarPermisos = New ToolStripMenuItem()
        mnuObraSociales = New ToolStripMenuItem()
        mnuDatosRequeridosValidacionOS = New ToolStripMenuItem()
        mnuHerramientas = New ToolStripMenuItem()
        mnuTrazabilidad = New ToolStripMenuItem()
        mnuConfirmarRecepcionDeTrazables = New ToolStripMenuItem()
        mnuTrazablesConfirmadosStockFarmacia = New ToolStripMenuItem()
        mnuInformarTrazablesDispensados = New ToolStripMenuItem()
        mnuTrazablesInformados = New ToolStripMenuItem()
        mnuSistema = New ToolStripMenuItem()
        mnuSistemaPTerminal = New ToolStripMenuItem()
        mnuSistemaPSistema = New ToolStripMenuItem()
        mnuSistemaActualizaciones = New ToolStripMenuItem()
        mnuSistemaActualizarVersion = New ToolStripMenuItem()
        mnuAyuda = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuOperaciones, mnuCaja, mnuFiscal, mnuContabilidad, mnuAuditoria, mnuEditar, mnuObraSociales, mnuHerramientas, mnuTrazabilidad, mnuSistema, mnuAyuda})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 2, 0, 2)
        MenuStrip1.Size = New Size(933, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuOperaciones
        ' 
        mnuOperaciones.DropDownItems.AddRange(New ToolStripItem() {mnuOperacionesFacturacion, mnuOperacionesCC, mnuOperacionesCompras})
        mnuOperaciones.Name = "mnuOperaciones"
        mnuOperaciones.Size = New Size(85, 20)
        mnuOperaciones.Text = "&Operaciones"
        ' 
        ' mnuOperacionesFacturacion
        ' 
        mnuOperacionesFacturacion.Name = "mnuOperacionesFacturacion"
        mnuOperacionesFacturacion.Size = New Size(233, 22)
        mnuOperacionesFacturacion.Text = "&Facturacion"
        ' 
        ' mnuOperacionesCC
        ' 
        mnuOperacionesCC.Name = "mnuOperacionesCC"
        mnuOperacionesCC.Size = New Size(233, 22)
        mnuOperacionesCC.Text = "&Operaciones Cuenta Corriente"
        ' 
        ' mnuOperacionesCompras
        ' 
        mnuOperacionesCompras.Name = "mnuOperacionesCompras"
        mnuOperacionesCompras.Size = New Size(233, 22)
        mnuOperacionesCompras.Text = "Com&pras"
        ' 
        ' mnuCaja
        ' 
        mnuCaja.DropDownItems.AddRange(New ToolStripItem() {mnuCajaMovimientos, mnuCajaAsientoGastos})
        mnuCaja.Name = "mnuCaja"
        mnuCaja.Size = New Size(42, 20)
        mnuCaja.Text = "&Caja"
        ' 
        ' mnuCajaMovimientos
        ' 
        mnuCajaMovimientos.Name = "mnuCajaMovimientos"
        mnuCajaMovimientos.Size = New Size(186, 22)
        mnuCajaMovimientos.Text = "&Movimientos de Caja"
        ' 
        ' mnuCajaAsientoGastos
        ' 
        mnuCajaAsientoGastos.Name = "mnuCajaAsientoGastos"
        mnuCajaAsientoGastos.Size = New Size(186, 22)
        mnuCajaAsientoGastos.Text = "&Asiendo de Gastos"
        ' 
        ' mnuFiscal
        ' 
        mnuFiscal.DropDownItems.AddRange(New ToolStripItem() {mnuFiscalLibroIVA, mnuFiscalIVADigital, mnuFiscalIVAExcel})
        mnuFiscal.Name = "mnuFiscal"
        mnuFiscal.Size = New Size(48, 20)
        mnuFiscal.Text = "&Fiscal"
        ' 
        ' mnuFiscalLibroIVA
        ' 
        mnuFiscalLibroIVA.Name = "mnuFiscalLibroIVA"
        mnuFiscalLibroIVA.Size = New Size(158, 22)
        mnuFiscalLibroIVA.Text = "&Libro IVA"
        ' 
        ' mnuFiscalIVADigital
        ' 
        mnuFiscalIVADigital.Name = "mnuFiscalIVADigital"
        mnuFiscalIVADigital.Size = New Size(158, 22)
        mnuFiscalIVADigital.Text = "Libro IVA &Digital"
        ' 
        ' mnuFiscalIVAExcel
        ' 
        mnuFiscalIVAExcel.Name = "mnuFiscalIVAExcel"
        mnuFiscalIVAExcel.Size = New Size(158, 22)
        mnuFiscalIVAExcel.Text = "Libro IVA &Excel"
        ' 
        ' mnuContabilidad
        ' 
        mnuContabilidad.DropDownItems.AddRange(New ToolStripItem() {mnuContabilidadResultadosMensuales, mnuContabilidadSaldoCuentaPatrimoniales, AsientoContableToolStripMenuItem, CancelarCuentasIncobraToolStripMenuItem, CierreEjercicioAbiertoToolStripMenuItem})
        mnuContabilidad.Name = "mnuContabilidad"
        mnuContabilidad.Size = New Size(87, 20)
        mnuContabilidad.Text = "Co&ntabilidad"
        ' 
        ' mnuContabilidadResultadosMensuales
        ' 
        mnuContabilidadResultadosMensuales.Name = "mnuContabilidadResultadosMensuales"
        mnuContabilidadResultadosMensuales.Size = New Size(230, 22)
        mnuContabilidadResultadosMensuales.Text = "&Resultados Mensuales"
        ' 
        ' mnuContabilidadSaldoCuentaPatrimoniales
        ' 
        mnuContabilidadSaldoCuentaPatrimoniales.Name = "mnuContabilidadSaldoCuentaPatrimoniales"
        mnuContabilidadSaldoCuentaPatrimoniales.Size = New Size(230, 22)
        mnuContabilidadSaldoCuentaPatrimoniales.Text = "&Saldo Cuenta Patrimoniales"
        ' 
        ' AsientoContableToolStripMenuItem
        ' 
        AsientoContableToolStripMenuItem.Name = "AsientoContableToolStripMenuItem"
        AsientoContableToolStripMenuItem.Size = New Size(230, 22)
        AsientoContableToolStripMenuItem.Text = "&Asiento Contable"
        ' 
        ' CancelarCuentasIncobraToolStripMenuItem
        ' 
        CancelarCuentasIncobraToolStripMenuItem.Name = "CancelarCuentasIncobraToolStripMenuItem"
        CancelarCuentasIncobraToolStripMenuItem.Size = New Size(230, 22)
        CancelarCuentasIncobraToolStripMenuItem.Text = "&Cancelar Cuentas Incobrables"
        ' 
        ' CierreEjercicioAbiertoToolStripMenuItem
        ' 
        CierreEjercicioAbiertoToolStripMenuItem.Name = "CierreEjercicioAbiertoToolStripMenuItem"
        CierreEjercicioAbiertoToolStripMenuItem.Size = New Size(230, 22)
        CierreEjercicioAbiertoToolStripMenuItem.Text = "Cierre &Ejercicio Abierto"
        ' 
        ' mnuAuditoria
        ' 
        mnuAuditoria.DropDownItems.AddRange(New ToolStripItem() {mnuAuditoriaCuentasCorrientes, mnuAuditoriaComprobantes, mnuAuditoriaReporteVentas, mnuAuditoriaCuentasProveedores, mnuAuditoriaCuentasBancarias, mnuAuditoriaCuentasEmpleados, mnuAuditoriaMovimientoDeProductos, mnuAuditoriaRankingDeVentas})
        mnuAuditoria.Name = "mnuAuditoria"
        mnuAuditoria.Size = New Size(68, 20)
        mnuAuditoria.Text = "&Auditoría"
        ' 
        ' mnuAuditoriaCuentasCorrientes
        ' 
        mnuAuditoriaCuentasCorrientes.Name = "mnuAuditoriaCuentasCorrientes"
        mnuAuditoriaCuentasCorrientes.Size = New Size(205, 22)
        mnuAuditoriaCuentasCorrientes.Text = "&Cuentas Corrientes"
        ' 
        ' mnuAuditoriaComprobantes
        ' 
        mnuAuditoriaComprobantes.DropDownItems.AddRange(New ToolStripItem() {mnuAuditoriaComprobantesEmitidos, mnuAuditoriaComprobantesRecibidos})
        mnuAuditoriaComprobantes.Name = "mnuAuditoriaComprobantes"
        mnuAuditoriaComprobantes.Size = New Size(205, 22)
        mnuAuditoriaComprobantes.Text = "Com&probantes"
        ' 
        ' mnuAuditoriaComprobantesEmitidos
        ' 
        mnuAuditoriaComprobantesEmitidos.Name = "mnuAuditoriaComprobantesEmitidos"
        mnuAuditoriaComprobantesEmitidos.Size = New Size(207, 22)
        mnuAuditoriaComprobantesEmitidos.Text = "Comprobantes &Emitidos"
        ' 
        ' mnuAuditoriaComprobantesRecibidos
        ' 
        mnuAuditoriaComprobantesRecibidos.Name = "mnuAuditoriaComprobantesRecibidos"
        mnuAuditoriaComprobantesRecibidos.Size = New Size(207, 22)
        mnuAuditoriaComprobantesRecibidos.Text = "Comprobantes &Recibidos"
        ' 
        ' mnuAuditoriaReporteVentas
        ' 
        mnuAuditoriaReporteVentas.Name = "mnuAuditoriaReporteVentas"
        mnuAuditoriaReporteVentas.Size = New Size(205, 22)
        mnuAuditoriaReporteVentas.Text = "Reporte de &Ventas"
        ' 
        ' mnuAuditoriaCuentasProveedores
        ' 
        mnuAuditoriaCuentasProveedores.Name = "mnuAuditoriaCuentasProveedores"
        mnuAuditoriaCuentasProveedores.Size = New Size(205, 22)
        mnuAuditoriaCuentasProveedores.Text = "Cuenta Provee&dores"
        ' 
        ' mnuAuditoriaCuentasBancarias
        ' 
        mnuAuditoriaCuentasBancarias.Name = "mnuAuditoriaCuentasBancarias"
        mnuAuditoriaCuentasBancarias.Size = New Size(205, 22)
        mnuAuditoriaCuentasBancarias.Text = "Cuentas &Bancarias"
        ' 
        ' mnuAuditoriaCuentasEmpleados
        ' 
        mnuAuditoriaCuentasEmpleados.Name = "mnuAuditoriaCuentasEmpleados"
        mnuAuditoriaCuentasEmpleados.Size = New Size(205, 22)
        mnuAuditoriaCuentasEmpleados.Text = "Cuenta &Empleados"
        ' 
        ' mnuAuditoriaMovimientoDeProductos
        ' 
        mnuAuditoriaMovimientoDeProductos.Name = "mnuAuditoriaMovimientoDeProductos"
        mnuAuditoriaMovimientoDeProductos.Size = New Size(205, 22)
        mnuAuditoriaMovimientoDeProductos.Text = "Movimiento de &Articulos"
        ' 
        ' mnuAuditoriaRankingDeVentas
        ' 
        mnuAuditoriaRankingDeVentas.Name = "mnuAuditoriaRankingDeVentas"
        mnuAuditoriaRankingDeVentas.Size = New Size(205, 22)
        mnuAuditoriaRankingDeVentas.Text = "Ranking de &Ventas"
        ' 
        ' mnuEditar
        ' 
        mnuEditar.DropDownItems.AddRange(New ToolStripItem() {mnuEditarArticulos, mnuEditarFraccionables, mnuEditarClientes, mnuEditarEmpleados, mnuEditarUsuarios, mnuEditarProveedores, mnuEditarSecciones, mnuEditarCuentasBancarias, mnuEditarMedioPE, mnuEditarPermisos})
        mnuEditar.Name = "mnuEditar"
        mnuEditar.Size = New Size(49, 20)
        mnuEditar.Text = "&Editar"
        ' 
        ' mnuEditarArticulos
        ' 
        mnuEditarArticulos.Name = "mnuEditarArticulos"
        mnuEditarArticulos.Size = New Size(159, 22)
        mnuEditarArticulos.Text = "Artículos"
        ' 
        ' mnuEditarFraccionables
        ' 
        mnuEditarFraccionables.Name = "mnuEditarFraccionables"
        mnuEditarFraccionables.Size = New Size(159, 22)
        mnuEditarFraccionables.Text = "Fraccionables"
        ' 
        ' mnuEditarClientes
        ' 
        mnuEditarClientes.Name = "mnuEditarClientes"
        mnuEditarClientes.Size = New Size(159, 22)
        mnuEditarClientes.Text = "Clientes"
        ' 
        ' mnuEditarEmpleados
        ' 
        mnuEditarEmpleados.Name = "mnuEditarEmpleados"
        mnuEditarEmpleados.Size = New Size(159, 22)
        mnuEditarEmpleados.Text = "Empleados"
        ' 
        ' mnuEditarUsuarios
        ' 
        mnuEditarUsuarios.Name = "mnuEditarUsuarios"
        mnuEditarUsuarios.Size = New Size(159, 22)
        mnuEditarUsuarios.Text = "Usuarios"
        ' 
        ' mnuEditarProveedores
        ' 
        mnuEditarProveedores.Name = "mnuEditarProveedores"
        mnuEditarProveedores.Size = New Size(159, 22)
        mnuEditarProveedores.Text = "Proveedores"
        ' 
        ' mnuEditarSecciones
        ' 
        mnuEditarSecciones.Name = "mnuEditarSecciones"
        mnuEditarSecciones.Size = New Size(159, 22)
        mnuEditarSecciones.Text = "Secciones"
        ' 
        ' mnuEditarCuentasBancarias
        ' 
        mnuEditarCuentasBancarias.Name = "mnuEditarCuentasBancarias"
        mnuEditarCuentasBancarias.Size = New Size(159, 22)
        mnuEditarCuentasBancarias.Text = "Cuentas Banco"
        ' 
        ' mnuEditarMedioPE
        ' 
        mnuEditarMedioPE.Name = "mnuEditarMedioPE"
        mnuEditarMedioPE.Size = New Size(159, 22)
        mnuEditarMedioPE.Text = "Medios de Pago"
        ' 
        ' mnuEditarPermisos
        ' 
        mnuEditarPermisos.Name = "mnuEditarPermisos"
        mnuEditarPermisos.Size = New Size(159, 22)
        mnuEditarPermisos.Text = "Permisos"
        ' 
        ' mnuObraSociales
        ' 
        mnuObraSociales.DropDownItems.AddRange(New ToolStripItem() {mnuDatosRequeridosValidacionOS})
        mnuObraSociales.Name = "mnuObraSociales"
        mnuObraSociales.Size = New Size(95, 20)
        mnuObraSociales.Text = "O&bras Sociales"
        ' 
        ' mnuDatosRequeridosValidacionOS
        ' 
        mnuDatosRequeridosValidacionOS.Name = "mnuDatosRequeridosValidacionOS"
        mnuDatosRequeridosValidacionOS.Size = New Size(223, 22)
        mnuDatosRequeridosValidacionOS.Text = "Datos Requeridos Validación"
        ' 
        ' mnuHerramientas
        ' 
        mnuHerramientas.Name = "mnuHerramientas"
        mnuHerramientas.Size = New Size(90, 20)
        mnuHerramientas.Text = "&Herramientas"
        ' 
        ' mnuTrazabilidad
        ' 
        mnuTrazabilidad.DropDownItems.AddRange(New ToolStripItem() {mnuConfirmarRecepcionDeTrazables, mnuTrazablesConfirmadosStockFarmacia, mnuInformarTrazablesDispensados, mnuTrazablesInformados})
        mnuTrazabilidad.Name = "mnuTrazabilidad"
        mnuTrazabilidad.Size = New Size(81, 20)
        mnuTrazabilidad.Text = "&Trazabilidad"
        ' 
        ' mnuConfirmarRecepcionDeTrazables
        ' 
        mnuConfirmarRecepcionDeTrazables.Name = "mnuConfirmarRecepcionDeTrazables"
        mnuConfirmarRecepcionDeTrazables.Size = New Size(303, 22)
        mnuConfirmarRecepcionDeTrazables.Text = "Confirmar Recepción de Trazables"
        ' 
        ' mnuTrazablesConfirmadosStockFarmacia
        ' 
        mnuTrazablesConfirmadosStockFarmacia.Name = "mnuTrazablesConfirmadosStockFarmacia"
        mnuTrazablesConfirmadosStockFarmacia.Size = New Size(303, 22)
        mnuTrazablesConfirmadosStockFarmacia.Text = "Trazables confirmados (Stock en Farmacias)"
        ' 
        ' mnuInformarTrazablesDispensados
        ' 
        mnuInformarTrazablesDispensados.Name = "mnuInformarTrazablesDispensados"
        mnuInformarTrazablesDispensados.Size = New Size(303, 22)
        mnuInformarTrazablesDispensados.Text = "Informar Trazables Dispensados"
        ' 
        ' mnuTrazablesInformados
        ' 
        mnuTrazablesInformados.Name = "mnuTrazablesInformados"
        mnuTrazablesInformados.Size = New Size(303, 22)
        mnuTrazablesInformados.Text = "Trazables informados"
        ' 
        ' mnuSistema
        ' 
        mnuSistema.DropDownItems.AddRange(New ToolStripItem() {mnuSistemaPTerminal, mnuSistemaPSistema, mnuSistemaActualizaciones, mnuSistemaActualizarVersion})
        mnuSistema.Name = "mnuSistema"
        mnuSistema.Size = New Size(60, 20)
        mnuSistema.Text = "&Sistema"
        ' 
        ' mnuSistemaPTerminal
        ' 
        mnuSistemaPTerminal.Name = "mnuSistemaPTerminal"
        mnuSistemaPTerminal.Size = New Size(194, 22)
        mnuSistemaPTerminal.Text = "Parametros &Terminal"
        ' 
        ' mnuSistemaPSistema
        ' 
        mnuSistemaPSistema.Name = "mnuSistemaPSistema"
        mnuSistemaPSistema.Size = New Size(194, 22)
        mnuSistemaPSistema.Text = "Parametros de &Sistema"
        ' 
        ' mnuSistemaActualizaciones
        ' 
        mnuSistemaActualizaciones.Name = "mnuSistemaActualizaciones"
        mnuSistemaActualizaciones.Size = New Size(194, 22)
        mnuSistemaActualizaciones.Text = "Actualizaciones"
        ' 
        ' mnuSistemaActualizarVersion
        ' 
        mnuSistemaActualizarVersion.Name = "mnuSistemaActualizarVersion"
        mnuSistemaActualizarVersion.Size = New Size(194, 22)
        mnuSistemaActualizarVersion.Text = "Actualizar Version"
        ' 
        ' mnuAyuda
        ' 
        mnuAyuda.Name = "mnuAyuda"
        mnuAyuda.Size = New Size(53, 20)
        mnuAyuda.Text = "Ay&uda"
        ' 
        ' FrmInicio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(933, 519)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 3, 4, 3)
        Name = "FrmInicio"
        Text = "Gestión SiCoFa"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuOperaciones As ToolStripMenuItem
    Friend WithEvents mnuCaja As ToolStripMenuItem
    Friend WithEvents mnuFiscal As ToolStripMenuItem
    Friend WithEvents mnuAuditoria As ToolStripMenuItem
    Friend WithEvents mnuEditar As ToolStripMenuItem
    Friend WithEvents mnuHerramientas As ToolStripMenuItem
    Friend WithEvents mnuSistema As ToolStripMenuItem
    Friend WithEvents mnuAyuda As ToolStripMenuItem
    Friend WithEvents mnuOperacionesFacturacion As ToolStripMenuItem
    Friend WithEvents mnuEditarArticulos As ToolStripMenuItem
    Friend WithEvents mnuEditarClientes As ToolStripMenuItem
    Friend WithEvents mnuEditarEmpleados As ToolStripMenuItem
    Friend WithEvents mnuEditarUsuarios As ToolStripMenuItem
    Friend WithEvents mnuEditarProveedores As ToolStripMenuItem
    Friend WithEvents mnuEditarSecciones As ToolStripMenuItem
    Friend WithEvents mnuEditarCuentasBancarias As ToolStripMenuItem
    Friend WithEvents mnuEditarMedioPE As ToolStripMenuItem
    Friend WithEvents mnuCajaMovimientos As ToolStripMenuItem
    Friend WithEvents mnuOperacionesCC As ToolStripMenuItem
    Friend WithEvents mnuOperacionesCompras As ToolStripMenuItem
    Friend WithEvents mnuCajaAsientoGastos As ToolStripMenuItem
    Friend WithEvents mnuFiscalLibroIVA As ToolStripMenuItem
    Friend WithEvents mnuFiscalIVADigital As ToolStripMenuItem
    Friend WithEvents mnuFiscalIVAExcel As ToolStripMenuItem
    Friend WithEvents mnuContabilidad As ToolStripMenuItem
    Friend WithEvents mnuContabilidadResultadosMensuales As ToolStripMenuItem
    Friend WithEvents mnuContabilidadSaldoCuentaPatrimoniales As ToolStripMenuItem
    Friend WithEvents AsientoContableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelarCuentasIncobraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CierreEjercicioAbiertoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAuditoriaCuentasCorrientes As ToolStripMenuItem
    Friend WithEvents mnuAuditoriaComprobantes As ToolStripMenuItem
    Friend WithEvents mnuAuditoriaReporteVentas As ToolStripMenuItem
    Friend WithEvents mnuAuditoriaCuentasProveedores As ToolStripMenuItem
    Friend WithEvents mnuAuditoriaCuentasBancarias As ToolStripMenuItem
    Friend WithEvents mnuAuditoriaCuentasEmpleados As ToolStripMenuItem
    Friend WithEvents mnuAuditoriaMovimientoDeProductos As ToolStripMenuItem
    Friend WithEvents mnuAuditoriaRankingDeVentas As ToolStripMenuItem
    Friend WithEvents mnuSistemaPTerminal As ToolStripMenuItem
    Friend WithEvents mnuSistemaPSistema As ToolStripMenuItem
    Friend WithEvents mnuEditarPermisos As ToolStripMenuItem
    Friend WithEvents mnuAuditoriaComprobantesEmitidos As ToolStripMenuItem
    Friend WithEvents mnuAuditoriaComprobantesRecibidos As ToolStripMenuItem
    Friend WithEvents mnuSistemaActualizaciones As ToolStripMenuItem
    Friend WithEvents mnuSistemaActualizarVersion As ToolStripMenuItem
    Friend WithEvents mnuEditarFraccionables As ToolStripMenuItem
    Friend WithEvents mnuObraSociales As ToolStripMenuItem
    Friend WithEvents mnuDatosRequeridosValidacionOS As ToolStripMenuItem
    Friend WithEvents mnuTrazabilidad As ToolStripMenuItem
    Friend WithEvents mnuConfirmarRecepcionDeTrazables As ToolStripMenuItem
    Friend WithEvents mnuInformarTrazablesDispensados As ToolStripMenuItem
    Friend WithEvents mnuTrazablesConfirmadosStockFarmacia As ToolStripMenuItem
    Friend WithEvents mnuTrazablesInformados As ToolStripMenuItem
End Class

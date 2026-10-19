Imports SiCoFa.ServiciosExternos
Imports SiCoFa.Datos
Imports SiCoFa.Entidades

Public Class N_AdminRecetas

    Public Function ObtenerIdMensajeValidador(ByVal argValidador As String) As Long

        Dim AdminRecetas As New D_AdminRecetas
        Dim IdMensaje As Long = AdminRecetas.ObtenerIdMensajeValidador(argValidador)
        Return IdMensaje

    End Function

    Public Function ConsultaRecetasBeneficiario(argIdPC As String, argCredencial As CredencialOS, argPValidacion As ParametrosValidacion) As List(Of Receta)

        Dim iVal As IValidador = S_AdminValidadores.ObtenerValidador(argPValidacion.Validador)
        Dim idMsje As Long = Me.ObtenerIdMensajeValidador(argPValidacion.Validador)
        Dim consultaResponse As List(Of Receta) = iVal.ConsultaRecetasBeneficiario(argIdPC, argCredencial, argPValidacion, idMsje)
        Return consultaResponse

    End Function

    Public Function ConsultaRecetaElectronica(argIdPC As String, argReceta As Receta) As Receta

        Dim iVal As IValidador = S_AdminValidadores.ObtenerValidador(argReceta.Plan.OS.PValidacion.Validador)
        Dim idMsje As Long = Me.ObtenerIdMensajeValidador(argReceta.Plan.OS.PValidacion.Validador)
        Dim consultaResponse As Receta = iVal.ConsultaRecetaElectronica(argIdPC, argReceta, idMsje)
        Return consultaResponse

    End Function

    Public Sub SolicitarAutorizacion(argIdPC As String, argReceta As Receta)

        Dim iVal As IValidador = S_AdminValidadores.ObtenerValidador(argReceta.Plan.OS.PValidacion.Validador)
        Dim idMsje As Long = Me.ObtenerIdMensajeValidador(argReceta.Plan.OS.PValidacion.Validador)
        iVal.SolicitarAutorizacion(argIdPC, argReceta, idMsje)

    End Sub

    Public Sub SolicitarCancelacion(argIdPC As String, argReceta As Receta)

        Dim iVal As IValidador = S_AdminValidadores.ObtenerValidador(argReceta.Plan.OS.PValidacion.Validador)
        Dim idMsje As Long = Me.ObtenerIdMensajeValidador(argReceta.Plan.OS.PValidacion.Validador)
        iVal.CancelarAutorizacion(argIdPC, argReceta, idMsje)

    End Sub

    Public Function CoberturaOS(ByVal argArticulo As Articulo, argPlanOS As PlanOS) As CoberturaOS

        If argArticulo Is Nothing OrElse argPlanOS Is Nothing Then
            Return Nothing
            Exit Function
        End If

        Select Case argPlanOS.Proceso

            Case 1
                Return Me.Proceso1(argArticulo, argPlanOS)

            Case 2
                Return Me.Proceso2(argArticulo, argPlanOS)
            Case 3
                Return Me.Proceso3(argArticulo, argPlanOS)

            Case 4
                Return Me.Proceso4(argArticulo, argPlanOS)

            Case 12
                Return Me.Proceso12(argArticulo, argPlanOS)

            Case 13
                Return Me.Proceso13(argArticulo, argPlanOS)

            Case Else
                Return Nothing

        End Select

    End Function

    Private Function Proceso1(argArticulo As Articulo, argPlanOS As PlanOS) As CoberturaOS

        Dim codigo As Integer = argArticulo.Codigo
        Dim POS As Decimal = 0
        Dim DOS As Decimal = 0
        Dim PCS As Decimal = 0
        Dim DCS As Decimal = 0

        If argPlanOS.Vademecum1 IsNot Nothing Then
            Dim itemVdm = argPlanOS.Vademecum1.FirstOrDefault(Function(x) x.Codigo = codigo)

            If itemVdm IsNot Nothing Then
                POS = argPlanOS.DesGeneral1
                DOS = Math.Round(argArticulo.PrecioVenta * POS / 100, 2, MidpointRounding.ToEven)
                PCS = 0
                DCS = 0
            End If

        End If

        If DOS > 0 Then
            Dim cos As New CoberturaOS

            With cos
                .PorcentajeOS = POS
                .DescuentoUnitarioOS = DOS
                .PorcentajeCS = PCS
                .DescuentoUnitarioCS = DCS
            End With

            Return cos
        End If

        Return Nothing

    End Function

    Private Function Proceso2(argArticulo As Articulo, argPlanOS As PlanOS) As CoberturaOS

        Dim codigo As Integer = argArticulo.Codigo
        Dim POS As Decimal = 0
        Dim DOS As Decimal = 0
        Dim PCS As Decimal = 0
        Dim DCS As Decimal = 0

        If argPlanOS.Vademecum1 IsNot Nothing Then
            Dim itemVdm = argPlanOS.Vademecum1.FirstOrDefault(Function(x) x.Codigo = codigo)

            If itemVdm IsNot Nothing Then
                POS = itemVdm.Descuento
                DOS = Math.Round(argArticulo.PrecioVenta * POS / 100, 2, MidpointRounding.ToEven)
                PCS = 0
                DCS = 0
            End If

        End If

        If DOS > 0 Then

            Dim cos As New CoberturaOS

            With cos
                .PorcentajeOS = POS
                .DescuentoUnitarioOS = DOS
                .PorcentajeCS = PCS
                .DescuentoUnitarioCS = DCS
            End With

            Return cos

        End If

        Return Nothing

    End Function

    Private Function Proceso3(argArticulo As Articulo, argPlanOS As PlanOS) As CoberturaOS

        Dim codigo As Integer = argArticulo.Codigo
        Dim POS As Decimal = 0
        Dim DOS As Decimal = 0
        Dim PCS As Decimal = 0
        Dim DCS As Decimal = 0

        If argPlanOS.Vademecum1 IsNot Nothing Then
            Dim itemVdm = argPlanOS.Vademecum1.FirstOrDefault(Function(x) x.Codigo = codigo)

            If itemVdm IsNot Nothing Then
                POS = argPlanOS.DesGeneral1
                DOS = Math.Round(argArticulo.PrecioVenta * POS / 100, 2, MidpointRounding.ToEven)
                PCS = 0
                DCS = 0

            Else
                POS = argPlanOS.DesGeneral2
                DOS = Math.Round(argArticulo.PrecioVenta * POS / 100, 2, MidpointRounding.ToEven)
                PCS = 0
                DCS = 0

            End If

        End If

        If DOS > 0 Then

            Dim cos As New CoberturaOS

            With cos
                .PorcentajeOS = POS
                .DescuentoUnitarioOS = DOS
                .PorcentajeCS = PCS
                .DescuentoUnitarioCS = DCS
            End With

            Return cos

        End If

        Return Nothing

    End Function

    Private Function Proceso4(argArticulo As Articulo, argPlanOS As PlanOS) As CoberturaOS

        Dim POS As Decimal = 0
        Dim DOS As Decimal = 0
        Dim PCS As Decimal = 0
        Dim DCS As Decimal = 0

        POS = argPlanOS.DesGeneral1
        DOS = Math.Round(argArticulo.PrecioVenta * POS / 100, 2, MidpointRounding.ToEven)
        PCS = 0
        DCS = 0

        Dim cos As New CoberturaOS

        With cos
            .PorcentajeOS = POS
            .DescuentoUnitarioOS = DOS
            .PorcentajeCS = PCS
            .DescuentoUnitarioCS = DCS
        End With

        Return cos

    End Function

    Private Function Proceso12(argArticulo As Articulo, argPlanOS As PlanOS) As CoberturaOS


        Dim POS As Decimal = 0
        Dim DOS As Decimal = 0
        Dim PCS As Decimal = 0
        Dim DCS As Decimal = 0
        Dim strPOS As String = ""

        Do
            strPOS = InputBox("Ingrese el porcentaje de Descuento:", "Cobertura Obra Social")

            ' Si presiona Cancelar
            If strPOS = "" Then Return Nothing

            If Decimal.TryParse(strPOS, POS) AndAlso POS > 0 AndAlso POS < 101 Then
                Exit Do
            End If

            MsgBox("Debe ingresar un porcentaje válido (mayor que 0 y menor o igual a 100)", vbOKOnly, "SiCoFa")

        Loop

        DOS = Math.Round(argArticulo.PrecioVenta * POS / 100, 2, MidpointRounding.ToEven)
        PCS = 0
        DCS = 0

        Dim cos As New CoberturaOS

        With cos
            .PorcentajeOS = POS
            .DescuentoUnitarioOS = DOS
            .PorcentajeCS = PCS
            .DescuentoUnitarioCS = DCS
        End With

        Return cos

    End Function

    Private Function Proceso13(argArticulo As Articulo, argPlanOS As PlanOS) As CoberturaOS

        Dim POS As Decimal = 0
        Dim DOS As Decimal = 0
        Dim PCS As Decimal = 0
        Dim DCS As Decimal = 0

        POS = argPlanOS.DesGeneral1
        DOS = Math.Round(argArticulo.PrecioVenta * POS / 100, 2, MidpointRounding.ToEven)
        PCS = argPlanOS.DesGeneral2
        DCS = Math.Round(argArticulo.PrecioVenta * PCS / 100, 2, MidpointRounding.ToEven)

        Dim cos As New CoberturaOS

        With cos
            .PorcentajeOS = POS
            .DescuentoUnitarioOS = DOS
            .PorcentajeCS = PCS
            .DescuentoUnitarioCS = DCS
        End With

        Return cos

    End Function

End Class
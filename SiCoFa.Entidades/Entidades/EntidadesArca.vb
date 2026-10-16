Public Class FEAuthRequest
    Property Cuit As Long
    Property Token As String
    Property Sign As String
End Class

Public Class FECAECabRequest
    Property CantReg As Integer
    Property PtoVta As Integer
    Property CbteTipo As Integer
End Class

Public Class FECAEDetRequest
    Property Concepto As Integer
    Property DocTipo As Integer
    Property DocNro As Long
    Property CbteDesde As Long
    Property CbteHasta As Long
    Property CbteFch As String
    Property ImpTotal As Decimal
    Property ImpTotConc As Decimal
    Property ImpNeto As Decimal
    Property ImpOpEx As Decimal
    Property ImpTrib As Decimal
    Property ImpIVA As Decimal
    Property MonId As String
    Property MonCotizSpecified As Boolean
    Property MonCotiz As Decimal
    Property CondicionIVAReceptorId As Integer
    Property Iva As AlicIva()
    Property CbtesAsoc As CbteAsoc()
End Class

Public Class FECAERequest
    Property FeCabReq As FECAECabRequest
    Property FeDetReq As FECAEDetRequest()
End Class

Public Class AlicIva
    Property Id As Integer
    Property BaseImp As Decimal
    Property Importe As Decimal
End Class

Public Class CbteAsoc
    Property Tipo As Integer
    Property PtoVta As Integer
    Property Nro As Long
End Class
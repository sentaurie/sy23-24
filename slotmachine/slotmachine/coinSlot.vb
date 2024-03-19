Public Class coinSlot
    Public Event CoinReturnEvent(d As Integer)
    Public Property dollars As Integer
    Dim _total As Decimal

    Public ReadOnly Property total As Decimal
        Get
            _total = dollars
            Return _total
        End Get
    End Property

    Public Sub insertdollar()
        dollars += 1
    End Sub
    Public Sub insert10dollar()
        dollars += 10
    End Sub
End Class
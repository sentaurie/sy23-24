Public Class coinSlot
    Public Event CoinReturnEvent(d As Integer, q As Integer, di As Integer, n As Integer)
    Public Property quarters As Integer
    Public Property nickels As Integer
    Public Property dimes As Integer
    Public Property dollars As Integer
    Dim _total As Decimal
    Public Event dispenseProduct(p As Image)

    Public ReadOnly Property total As Decimal
        Get
            _total = nickels * 0.05 + dimes * 0.1 + quarters * 0.25 + dollars
            Return _total
        End Get
    End Property

    Public Sub insertquarter()
        quarters += 1

    End Sub

    Public Sub insertnickel()
        nickels += 1
    End Sub

    Public Sub insertdime()
        dimes += 1
    End Sub

    Public Sub insertdollar()
        dollars += 1
    End Sub

    Public Sub coinReturn()
        RaiseEvent CoinReturnEvent(dollars, quarters, dimes, nickels)
        dollars = 0
        quarters = 0
        dimes = 0
        nickels = 0
    End Sub

    Public Sub buy(p As productControl)
        If p.productCount > 0 And p.productPrice <= _total Then
            _total -= p.productPrice
            p.buy()
            dollars = 0
            quarters = 0
            dimes = 0
            nickels = _total / 0.05
            RaiseEvent dispenseProduct(p.productImage)
        End If
    End Sub

End Class

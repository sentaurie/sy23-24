Public Class Form1
    Dim WithEvents CS As New coinSlot

    Private Sub nickelButton_Click(sender As Object, e As EventArgs) Handles nickelButton.Click
        CS.insertnickel()
        Label1.Text = CS.total.ToString("C2")
    End Sub

    Private Sub dimeButton_Click(sender As Object, e As EventArgs) Handles dimeButton.Click
        CS.insertdime()
        Label1.Text = CS.total.ToString("C2")
    End Sub

    Private Sub quarterButton_Click(sender As Object, e As EventArgs) Handles quarterButton.Click
        CS.insertquarter()
        Label1.Text = CS.total.ToString("C2")
    End Sub

    Private Sub dollarButton_Click(sender As Object, e As EventArgs) Handles dollarButton.Click
        CS.insertdollar()
        Label1.Text = CS.total.ToString("C2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CS.coinReturn()
        Label1.Text = CS.total.ToString("C2")
    End Sub

    Private Sub CS_CoinReturnEvent(d As Integer, q As Integer, di As Integer, n As Integer) Handles CS.CoinReturnEvent
        If d > 0 Then
            doPictureBox.Visible = True
        Else
            doPictureBox.Visible = False
        End If

        If q > 0 Then
            qPictureBox.Visible = True
        Else
            qPictureBox.Visible = False
        End If

        If di > 0 Then
            dPictureBox.Visible = True
        Else
            dPictureBox.Visible = False
        End If

        If n > 0 Then
            nPictureBox.Visible = True
        Else
            nPictureBox.Visible = False
        End If
    End Sub

    Private Sub buyButton_Click(sender As Object, e As EventArgs) Handles buyButton.Click
        Select Case idTextBox.Text
            Case ProductControl1.productID
                CS.buy(ProductControl1)
            Case ProductControl2.productID
                CS.buy(ProductControl2)
            Case ProductControl3.productID
                CS.buy(ProductControl3)
            Case ProductControl4.productID
                CS.buy(ProductControl4)
            Case ProductControl5.productID
                CS.buy(ProductControl5)
            Case ProductControl6.productID
                CS.buy(ProductControl6)
            Case ProductControl7.productID
                CS.buy(ProductControl7)
            Case ProductControl8.productID
                CS.buy(ProductControl8)
            Case ProductControl9.productID
                CS.buy(ProductControl9)
            Case ProductControl10.productID
                CS.buy(ProductControl10)
            Case ProductControl11.productID
                CS.buy(ProductControl11)
            Case ProductControl12.productID
                CS.buy(ProductControl12)
            Case ProductControl13.productID
                CS.buy(ProductControl13)
            Case ProductControl14.productID
                CS.buy(ProductControl14)
            Case ProductControl15.productID
                CS.buy(ProductControl15)
            Case ProductControl16.productID
                CS.buy(ProductControl16)
            Case Else

        End Select
        Label1.Text = CS.total.ToString("C2")
    End Sub

    Private Sub CS_dispenseProduct(p As Image) Handles CS.dispenseProduct
        productPictureBox.Image = p
    End Sub
End Class

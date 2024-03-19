Public Class productControl
    Public Property productName As String
    Public Property productID As String
    Public Property productPrice As Decimal
    Public Property productImage As Image
    Public Property productCount As Integer

    Private Sub productControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = productImage
        IDLabel.Text = productID
        priceLabel.Text = productPrice.ToString("C2")
    End Sub

    Public Sub buy()
        If productCount > 0 Then
            productCount -= 1

        End If

        If productCount = 0 Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class

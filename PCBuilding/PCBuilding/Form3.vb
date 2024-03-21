Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserControl11.PictureBox1.Image = UserControl11.ImageList1.Images(1)
        UserControl11.priceLabel.Text = 200.ToString("C2")
        UserControl11.productNameLabel.Text = "GTX 1050 Ti"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UserControl11.PictureBox1.Image = UserControl11.ImageList1.Images(2)
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs)

    End Sub
End Class
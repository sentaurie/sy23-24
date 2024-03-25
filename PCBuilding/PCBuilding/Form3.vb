Public Class Form3
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        UserControl11.PictureBox1.Image = UserControl11.ImageList1.Images(1)
        UserControl11.priceLabel.Text = 200.ToString("C2")
        UserControl11.productNameLabel.Text = "GTX 1050 Ti"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        UserControl11.PictureBox1.Image = UserControl11.ImageList1.Images(2)
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
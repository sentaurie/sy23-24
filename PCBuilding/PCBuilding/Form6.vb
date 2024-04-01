Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button10.Click
        UserControl11.PictureBox2.Image = UserControl11.ImageList2.Images(24)
        UserControl11.priceLabela.Text = 125.ToString("C2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button9.Click
        UserControl11.PictureBox2.Image = UserControl11.ImageList2.Images(12)
        UserControl11.priceLabela.Text = 70.ToString("C2")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button8.Click
        UserControl11.PictureBox2.Image = UserControl11.ImageList2.Images(11)
        UserControl11.priceLabela.Text = 40.ToString("C2")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button7.Click
        UserControl11.PictureBox2.Image = UserControl11.ImageList2.Images(10)
        UserControl11.priceLabela.Text = 35.ToString("C2")
    End Sub
End Class
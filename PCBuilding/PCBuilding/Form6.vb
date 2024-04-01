Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button10.Click
        UserControl11.PictureBox2.Image = UserControl11.ImageList2.Images(24)
        UserControl11.priceLabela.Text = 70.ToString("C2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button9.Click
        UserControl11.PictureBox2.Image = UserControl11.ImageList2.Images(23)
        UserControl11.priceLabela.Text = 100.ToString("C2")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button8.Click
        UserControl11.PictureBox2.Image = UserControl11.ImageList2.Images(26)
        UserControl11.priceLabela.Text = 150.ToString("C2")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button7.Click
        UserControl11.PictureBox2.Image = UserControl11.ImageList2.Images(25)
        UserControl11.priceLabela.Text = 200.ToString("C2")
    End Sub
End Class
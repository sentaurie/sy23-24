Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserControl12.PictureBox2.Image = UserControl12.ImageList2.Images(13)
        UserControl12.priceLabela.Text = 125.ToString("C2")
        UserControl12.descriptionTtextbox.Text = "DDR5 6000 (PC5 48000), Timing 36-36-36-96, CAS Latency 36, Voltage 1.35V"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UserControl12.PictureBox2.Image = UserControl12.ImageList2.Images(12)
        UserControl12.priceLabela.Text = 70.ToString("C2")
        UserControl12.descriptionTtextbox.Text = "DDR4 3600 (PC4 28800), Timing 18-22-22-42, CAS Latency 18, Voltage 1.35V"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UserControl12.PictureBox2.Image = UserControl12.ImageList2.Images(11)
        UserControl12.priceLabela.Text = 40.ToString("C2")
        UserControl12.descriptionTtextbox.Text = "DDR4 3600 (PC4 28800), Timing 18-22-22-42, CAS Latency 18, Voltage 1.35V"
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        UserControl12.PictureBox2.Image = UserControl12.ImageList2.Images(10)
        UserControl12.priceLabela.Text = 35.ToString("C2")
        UserControl12.descriptionTtextbox.Text = "DDR4 3200 (PC4 25600), Timing 16-18-18-38, CAS Latency 16, Voltage 1.35V"
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UserControl12_Load(sender As Object, e As EventArgs) Handles UserControl12.Load

    End Sub
End Class
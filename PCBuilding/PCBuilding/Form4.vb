Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserControl12.PictureBox1.Image = UserControl12.ImageList1.Images(1)
        UserControl12.priceLabel.Text = 125.ToString("C2")
        UserControl12.descriptionTextBox.Text = "DDR5 6000 (PC5 48000), Timing 36-36-36-96, CAS Latency 36, Voltage 1.35V"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UserControl12.PictureBox1.Image = UserControl12.ImageList1.Images(1)
        UserControl12.priceLabel.Text = 70.ToString("C2")
        UserControl12.descriptionTextBox.Text = "DDR4 3600 (PC4 28800), Timing 18-22-22-42, CAS Latency 18, Voltage 1.35V"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UserControl12.PictureBox1.Image = UserControl12.ImageList1.Images(1)
        UserControl12.priceLabel.Text = 40.ToString("C2")
        UserControl12.descriptionTextBox.Text = "DDR4 3600 (PC4 28800), Timing 18-22-22-42, CAS Latency 18, Voltage 1.35V"
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        UserControl12.PictureBox1.Image = UserControl12.ImageList1.Images(1)
        UserControl12.priceLabel.Text = 35.ToString("C2")
        UserControl12.descriptionTextBox.Text = "DDR4 3200 (PC4 25600), Timing 16-18-18-38, CAS Latency 16, Voltage 1.35V
"
    End Sub
End Class
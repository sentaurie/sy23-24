Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserControl11.PictureBox1.Image = UserControl11.ImageList1.Images(0)
        UserControl11.priceLabel.Text = 125.ToString("C2")
        UserControl11.productNameLabel.Text = "G.SKILL Trident Z5 32GB"
        UserControl11.descriptionTextBox.Text = "DDR5 6000 (PC5 48000), Timing 36-36-36-96, CAS Latency 36, Voltage 1.35V"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UserControl11.PictureBox1.Image = UserControl11.ImageList1.Images(1)
        UserControl11.priceLabel.Text = 70.ToString("C2")
        UserControl11.productNameLabel.Text = "Team T-Force Delta 32GB"
        UserControl11.descriptionTextBox.Text = "DDR4 3600 (PC4 28800), Timing 18-22-22-42, CAS Latency 18, Voltage 1.35V"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UserControl11.PictureBox1.Image = UserControl11.ImageList1.Images(1)
        UserControl11.priceLabel.Text = 70.ToString("C2")
        UserControl11.productNameLabel.Text = ""
        UserControl11.descriptionTextBox.Text = ""
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        UserControl11.PictureBox1.Image = UserControl11.ImageList1.Images(1)
        UserControl11.priceLabel.Text = 70.ToString("C2")
        UserControl11.productNameLabel.Text = ""
        UserControl11.descriptionTextBox.Text = ""
    End Sub
End Class
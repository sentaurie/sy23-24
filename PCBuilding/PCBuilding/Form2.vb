Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserControl11.PictureBox1.Image = ImageList1.Images(0)
        UserControl11.priceLabel.Text = 200.ToString("C2")
        UserControl11.productNameLabel.Text = "GTX 1050 Ti"
        UserControl11.descriptionTextBox.Text = "4GB 128-Bit GDDR5, Core Clock 1341 MHz, 
Boost Clock 1455 MHz, 1 x DL-DVI-D 1 x HDMI 2.0 1 x DisplayPort 1.4, 
768 Cores CUDA Cores, PCI Express 3.0 x16"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UserControl11.PictureBox1.Image = ImageList1.Images(1)
        UserControl11.priceLabel.Text = 600.ToString("C2")
        UserControl11.productNameLabel.Text = "GTX 1080 Ti"
        UserControl11.descriptionTextBox.Text = "11GB 352-Bit GDDR5X, Core Clock 1556 MHz, Boost Clock 1670 MHz, 1 x DL-DVI-D 1 x HDMI 2.0 1 x DisplayPort 1.4, 3584 CUDA Cores, PCI Express 3.0 x16"
    End Sub

<<<<<<< Updated upstream
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

=======
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UserControl11.PictureBox1.Image = ImageList1.Images(2)
        UserControl11.priceLabel.Text = 1500.ToString("C2")
        UserControl11.productNameLabel.Text = "RTX 3090"
        UserControl11.descriptionTextBox.Text = "24GB 384-Bit GDDR6X, Core Clock 1890 MHz, Boost Clock OC Mode - 1890 MHz, Gaming Mode - 1860 MHz, 2 x HDMI 2.1 3 x DisplayPort 1.4a, 10496 Cores CUDA Cores, PCI Express 4.0"
>>>>>>> Stashed changes
    End Sub
End Class
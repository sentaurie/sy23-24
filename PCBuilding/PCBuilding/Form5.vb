Public Class Form5
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        UserControl11.PictureBox1.Image = UserControl11.ImageList1.Images(10)
        UserControl11.priceLabel.Text = 110.ToString("C2")
        UserControl11.descriptionTextBox.Text = "AMD AM4 Socket: Supports Ryzen processors, DDR4 Compatible: Dual Channel DDR4, Sturdy Power Design: 5+3 Digital VRM, Connectivity: PCIe 4.0, Dual NVMe M.2, Fine Tuning Features: RGB Fusion 2.0, Smart Fan 5, Q-Flash Plus"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        UserControl11.PictureBox1.Image = UserControl11.ImageList1.Images(1)
        UserControl11.priceLabel.Text = 600.ToString("C2")
        UserControl11.descriptionTextBox.Text = "11GB 352-Bit GDDR5X, Core Clock 1556 MHz, Boost Clock 1670 MHz, 1 x DL-DVI-D 1 x HDMI 2.0 1 x DisplayPort 1.4, 3584 CUDA Cores, PCI Express 3.0 x16"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button8.Click
        UserControl11.PictureBox1.Image = UserControl11.ImageList1.Images(2)
        UserControl11.priceLabel.Text = 1500.ToString("C2")
        UserControl11.descriptionTextBox.Text = "24GB 384-Bit GDDR6X, Core Clock 1890 MHz, Boost Clock OC Mode - 1890 MHz, Gaming Mode - 1860 MHz, 2 x HDMI 2.1 3 x DisplayPort 1.4a, 10496 Cores CUDA Cores, PCI Express 4.0"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button7.Click
        UserControl11.PictureBox1.Image = UserControl11.ImageList1.Images(3)
        UserControl11.priceLabel.Text = 2300.ToString("C2")
        UserControl11.descriptionTextBox.Text = "24GB 384-Bit GDDR6X, 1 x HDMI 2.1 3 x DisplayPort 1.4, 16384 CUDA Cores, PCI Express 4.0 x16"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button6.Click
        UserControl11.PictureBox1.Image = UserControl11.ImageList1.Images(4)
        UserControl11.priceLabel.Text = 350.ToString("C2")
        UserControl11.descriptionTextBox.Text = "16GB GDDR6 memory, PCI Express 4.0, WINDFORCE cooling, RGB Fusion, HDMI 2.1a x2, DisplayPort 2.1 x2"
    End Sub

End Class
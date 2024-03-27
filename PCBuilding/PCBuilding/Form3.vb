Public Class Form3
    Dim cpu As Integer
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        UserControl12.PictureBox1.Image = UserControl12.ImageList1.Images(5)
        UserControl12.priceLabel.Text = 320.ToString("C2")
        UserControl12.descriptionTextBox.Text = "14 cores, 20 threads, Intel UHD Graphics 770, Hybrid architecture for optimized performance, Up to 5.3 GHz, 24MB Cache, Compatible with Intel 600/700-series motherboards, Turbo Boost Max Technology 3.0, PCIe 5.0 & 4.0 support, Optane Memory"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        UserControl12.PictureBox1.Image = UserControl12.ImageList1.Images(6)
        UserControl12.priceLabel.Text = 400.ToString("C2")
        UserControl12.descriptionTextBox.Text = "20 cores, 28 threads, Intel UHD Graphics 770, Hybrid architecture, optimized performance, 5.6 GHz, 33MB Cache, Intel 600/700-series compatible, Turbo Boost Max Technology 3.0, PCIe support, DDR4 and DDR5 Memory support"
    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        UserControl12.PictureBox1.Image = UserControl12.ImageList1.Images(7)
        UserControl12.priceLabel.Text = 550.ToString("C2")
        UserControl12.descriptionTextBox.Text = "24 cores, 32 threads, Intel graphics, Hybrid architecture for optimized performance, Up to 6.0 GHz, 36MB Cache, Compatible with Intel 600/700-series motherboards, Turbo Boost Max Technology 3.0"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        UserControl12.PictureBox1.Image = UserControl12.ImageList1.Images(8)
        UserControl12.priceLabel.Text = 230.ToString("C2")
        UserControl12.descriptionTextBox.Text = "Ryzen AI™ feature, Dedicated AI Accelerators, 4nm 65W, 16MB L3 Cache, 8MB L2 Cache, AMD Radeon 760M"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        UserControl12.PictureBox1.Image = UserControl12.ImageList1.Images(9)
        UserControl12.priceLabel.Text = 250.ToString("C2")
        UserControl12.descriptionTextBox.Text = "7nm 105W, 96MB L3 Cache, 4MB L2 Cache, None Integrated Graphics"
    End Sub
End Class
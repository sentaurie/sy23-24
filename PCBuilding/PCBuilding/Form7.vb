Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserControl11.PictureBox2.Image = UserControl11.ImageList2.Images(19)
        UserControl11.priceLabela.Text = 200.ToString("C2")
        UserControl11.descriptionTtextbox.Text = "ATX / ATX (ATX 3.0 Compatible), Full Modular, 80 PLUS GOLD Certified, 100 - 240 V 47 - 63 Hz, +3.3V@20A, +5V@20A, +12V@62.5A, +5VSB@3A"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UserControl11.PictureBox2.Image = UserControl11.ImageList2.Images(20)
        UserControl11.priceLabela.Text = 200.ToString("C2")
        UserControl11.descriptionTtextbox.Text = "ATX, Full Modular, 80 PLUS GOLD Certified, 100 - 240 V 47 - 63 Hz, +3.3V@20A, +5V@20A, +12V@83.3A, +5VSB@3A"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UserControl11.PictureBox2.Image = UserControl11.ImageList2.Images(22)
        UserControl11.priceLabela.Text = 110.ToString("C2")
        UserControl11.descriptionTtextbox.Text = "Intel ATX 12V 2.31 & EPS 12V 2.92, Hardlined, 80 PLUS Certified, 100 - 240 V 50/60 Hz, +3.3V@20A, +5V@15A, +12V@35A, -12V@0.5A, +5VSB@2.5A"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        UserControl11.PictureBox2.Image = UserControl11.ImageList2.Images(21)
        UserControl11.priceLabela.Text = 145.ToString("C2")
        UserControl11.descriptionTtextbox.Text = "ATX12V, Full Modular, 80 PLUS GOLD Certified, 100 - 240 V 47 - 63 Hz, +3.3V@20A, +5V@20A, +12V@60.2A, -12V@0.3A, +5VSB@2.5A"
    End Sub

End Class
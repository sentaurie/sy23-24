Public Class Form1
    Dim f2 As New Form2
    Dim f3 As New Form3
    Dim f4 As New Form4
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        f2.ShowDialog()
        Me.Show()
        GPUTotalLabel.Text = f2.UserControl11.priceLabel.Text
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Me.Hide()
        f3.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Me.Hide()
        f4.ShowDialog()
        Me.Show()
    End Sub
End Class

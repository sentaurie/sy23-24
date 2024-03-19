Public Class clickercontrol
    Public Property Increment As Integer = 1
    Dim c As New clicker

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c.Increment = Increment
        c.Click()
        TextBox1.Text = c.count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c.Reset()
        TextBox1.Text = c.count
    End Sub

End Class

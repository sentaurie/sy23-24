Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BackColor = Color.Green
        Label1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BackColor = Color.Blue
        Label1.Visible = True
    End Sub
End Class

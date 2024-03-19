Public Class clicker
    Public Property count As Integer
    Public Property Increment As Integer = 1
    Public Sub Click()
        count = count + Increment
    End Sub

    Public Sub Reset()
        count = 0
    End Sub
End Class

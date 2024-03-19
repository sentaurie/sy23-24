Public Class Form1
    Dim WithEvents CS As New coinSlot
    Private Sub dollarButton_Click(sender As Object, e As EventArgs) Handles dollarButton.Click
        CS.insertdollar()
        Label4.Text = CS.total.ToString("C2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CS.insert10dollar()
        Label4.Text = CS.total.ToString("C2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CS.dollars >= 5 Then
            Timer1.Enabled = True
            Label4.Text = CS.total.ToString("C2")
            ReelControl5.Spin()
            ReelControl7.Spin()
            ReelControl8.Spin()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ReelControl5.itemValue = 0 And ReelControl7.itemValue = 0 And ReelControl8.itemValue = 0 Then
            CS.dollars = CS.dollars * 5
            Label4.Text = CS.total.ToString("C2")
        ElseIf ReelControl5.itemValue = 0 And ReelControl7.itemValue = 0 Or ReelControl5.itemValue = 0 And ReelControl8.itemValue = 0 Or ReelControl7.itemValue = 0 And ReelControl8.itemValue = 0 Then
            CS.dollars = CS.dollars * 1.2
            Label4.Text = CS.total.ToString("C2")

        ElseIf ReelControl5.itemValue = 1 And ReelControl7.itemValue = 1 And ReelControl8.itemValue = 1 Then
            CS.dollars = CS.dollars * 5
            Label4.Text = CS.total.ToString("C2")
        ElseIf ReelControl5.itemValue = 1 And ReelControl7.itemValue = 1 Or ReelControl5.itemValue = 1 And ReelControl8.itemValue = 1 Or ReelControl7.itemValue = 1 And ReelControl8.itemValue = 1 Then
            CS.dollars = CS.dollars * 1.2
            Label4.Text = CS.total.ToString("C2")

        ElseIf ReelControl5.itemValue = 2 And ReelControl7.itemValue = 2 And ReelControl8.itemValue = 2 Then
            CS.dollars = CS.dollars * 100
            Label4.Text = CS.total.ToString("C2")
        ElseIf ReelControl5.itemValue = 2 And ReelControl7.itemValue = 2 Or ReelControl5.itemValue = 2 And ReelControl8.itemValue = 2 Or ReelControl7.itemValue = 2 And ReelControl8.itemValue = 2 Then
            CS.dollars = CS.dollars * 6
            Label4.Text = CS.total.ToString("C2")

        ElseIf ReelControl5.itemValue = 3 And ReelControl7.itemValue = 3 And ReelControl8.itemValue = 3 Then
            CS.dollars = CS.dollars * 5
            Label4.Text = CS.total.ToString("C2")
        ElseIf ReelControl5.itemValue = 3 And ReelControl7.itemValue = 3 Or ReelControl5.itemValue = 3 And ReelControl8.itemValue = 3 Or ReelControl7.itemValue = 3 And ReelControl8.itemValue = 3 Then
            CS.dollars = CS.dollars * 1.2
            Label4.Text = CS.total.ToString("C2")

        ElseIf ReelControl5.itemValue = 4 And ReelControl7.itemValue = 4 And ReelControl8.itemValue = 4 Then
            CS.dollars = CS.dollars * 5
            Label4.Text = CS.total.ToString("C2")
        ElseIf ReelControl5.itemValue = 4 And ReelControl7.itemValue = 4 Or ReelControl5.itemValue = 4 And ReelControl8.itemValue = 4 Or ReelControl7.itemValue = 4 And ReelControl8.itemValue = 4 Then
            CS.dollars = CS.dollars * 1.2
            Label4.Text = CS.total.ToString("C2")

        ElseIf ReelControl5.itemValue = 5 And ReelControl7.itemValue = 5 And ReelControl8.itemValue = 5 Then
            CS.dollars = CS.dollars * 8
            Label4.Text = CS.total.ToString("C2")
        ElseIf ReelControl5.itemValue = 5 And ReelControl7.itemValue = 5 Or ReelControl5.itemValue = 5 And ReelControl8.itemValue = 5 Or ReelControl7.itemValue = 5 And ReelControl8.itemValue = 5 Then
            CS.dollars = CS.dollars * 1.7
            Label4.Text = CS.total.ToString("C2")
        Else
            CS.dollars -= 5
            CS.dollars = CS.dollars / 2
            Label4.Text = CS.total.ToString("C2")
        End If
        Timer1.Enabled = False
    End Sub
End Class

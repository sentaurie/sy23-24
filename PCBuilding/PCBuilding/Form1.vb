Imports System.Security.Cryptography

Public Class Form1
    Dim f2 As New Form2
    Dim f3 As New Form3
    Dim f4 As New Form4
    Dim f5 As New form5

    Dim gpu As Integer
    Dim cpu As Integer
    Dim mb As Integer

    Dim totalvalue As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        f2.ShowDialog()
        Me.Show()
        gpu = f2.UserControl11.priceLabel.Text
        GPUTotalLabel.Text = gpu.ToString("C2")
        totalvalue = gpu + cpu
        Label2.Text = totalvalue.ToString("C2")
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Me.Hide()
        f3.ShowDialog()
        Me.Show()
        cpu = f3.UserControl12.priceLabel.Text
        CPUTotalLabel.Text = cpu.ToString("C2")
        totalvalue = gpu + cpu
        Label2.Text = totalvalue.ToString("C2")
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Me.Hide()
        f4.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click
        Me.Hide()
        f5.ShowDialog()
        Me.Show()
        mb = f5.UserControl11.priceLabel.Text
        MotherboardTotalLabel.Text = mb.ToString("C2")
        totalvalue = gpu + cpu + mb
        Label2.Text = totalvalue.ToString("C2")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

Imports System.Security.Cryptography

Public Class Form1
    Dim f2 As New Form2
    Dim f3 As New Form3
    Dim f4 As New Form4
    Dim f5 As New Form5
    Dim f6 As New Form6
    Dim f7 As New Form7

    Dim gpu As Integer
    Dim cpu As Integer
    Dim mem As Integer
    Dim mb As Integer
    Dim pcase As Integer
    Dim ps As Integer

    Dim totalvalue As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        f2.ShowDialog()
        Me.Show()
        gpu = f2.UserControl11.priceLabela.Text
        GPUTotalLabel.Text = gpu.ToString("C2")
        totalvalue = gpu + cpu + mem + mb + pcase + ps
        Label2.Text = totalvalue.ToString("C2")
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Me.Hide()
        f3.ShowDialog()
        Me.Show()
        cpu = f3.UserControl12.priceLabela.Text
        CPUTotalLabel.Text = cpu.ToString("C2")
        totalvalue = gpu + cpu + mem + mb + pcase + ps
        Label2.Text = totalvalue.ToString("C2")
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Me.Hide()
        f4.ShowDialog()
        Me.Show()
        mem = f4.UserControl12.priceLabela.Text
        MemoryTotalLabel.Text = mem.ToString("C2")
        totalvalue = gpu + cpu + mem + mb + pcase + ps
        Label2.Text = totalvalue.ToString("C2")
    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click
        Me.Hide()
        f5.ShowDialog()
        Me.Show()
        mb = f5.UserControl11.priceLabela.Text
        MotherboardTotalLabel.Text = mb.ToString("C2")
        totalvalue = gpu + cpu + mem + mb + pcase + ps
        Label2.Text = totalvalue.ToString("C2")
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        Me.Hide()
        f6.ShowDialog()
        Me.Show()
        pcase = f6.UserControl11.priceLabela.Text
        caseTotalLabel.Text = pcase.ToString("C2")
        totalvalue = gpu + cpu + mem + mb + pcase + ps
    End Sub

    Private Sub Label42_Click(sender As Object, e As EventArgs) Handles Label42.Click

    End Sub
End Class
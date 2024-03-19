Imports System.Reflection.Emit

Public Class Form1
    Dim moveSpeed As Integer = 15
    Dim isJumping As Boolean
    Dim score As Integer
    Dim coins As Integer

    Private Sub frm2DPlatformer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
            Case Keys.Left
                tmrLeft.Start()
            Case Keys.Up
                tmrUp.Start()
                isJumping = True
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRight.Tick
        picPlayer.Left += moveSpeed
    End Sub

    Private Sub frm2DPlatformer_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
            Case Keys.Left
                tmrLeft.Stop()
            Case Keys.Up
                tmrUp.Stop()
                isJumping = False
        End Select
    End Sub

    Private Sub tmrLeft_Tick(sender As System.Object, e As System.EventArgs) Handles tmrLeft.Tick
        picPlayer.Left -= moveSpeed
    End Sub

    Private Sub tmrUp_Tick(sender As System.Object, e As System.EventArgs) Handles tmrUp.Tick
        picPlayer.Top -= moveSpeed
    End Sub

    Private Sub frm2DPlatformer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Text = score
        Label2.Text = coins
        tmrGameLogic.Start()
    End Sub


    Private Sub tmrGameLogic_Tick(sender As System.Object, e As System.EventArgs) Handles tmrGameLogic.Tick
        If picPlayer.Bounds.IntersectsWith(picAir.Bounds) Then
            If isJumping = False Then
                tmrGravity.Start()
            End If
        ElseIf picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
            tmrGravity.Stop()
        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                    End If
                ElseIf b.Tag = "spike" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        picPlayer.Location = New Point(122, 346)
                        coins -= 1
                        Label2.Text = coins
                        If coins <= -1 Then
                            PictureBox71.Visible = True
                        End If
                    End If
                ElseIf b.Tag = "banana" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        b.Location = New Point(1156, 16)
                        score += 1
                        Label1.Text = score
                    End If
                    If score = 3 Then
                        PictureBox72.Visible = False
                        PictureBox73.Visible = False
                        PictureBox72.Location = New Point(1156, 16)
                        PictureBox73.Location = New Point(1156, 16)
                    End If
                ElseIf b.Tag = "coin" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        b.Location = New Point(1156, 16)
                        coins += 1
                        Label2.Text = coins
                    End If
                End If
            End If
        Next

    End Sub

    Private Sub tmrGravity_Tick(sender As System.Object, e As System.EventArgs) Handles tmrGravity.Tick
        picPlayer.Top += moveSpeed
    End Sub

End Class

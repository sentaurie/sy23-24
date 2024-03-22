<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.UserControl11 = New PCBuilding.UserControl1()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(-4, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 59)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "G.SKILL Trident Z5 32GB"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(-4, 66)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 59)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Team T-Force Delta 32GB"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(-4, 131)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 59)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Team T-Force Vulkan Z 16GB"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(-4, 196)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(138, 59)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "G.SKILL Ripjaws 16GB"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'UserControl11
        '
        Me.UserControl11.Location = New System.Drawing.Point(368, 1)
        Me.UserControl11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.picture = Nothing
        Me.UserControl11.Size = New System.Drawing.Size(376, 447)
        Me.UserControl11.TabIndex = 32
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UserControl11)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents UserControl11 As UserControl1
End Class

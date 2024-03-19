<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dollarButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ReelControl5 = New slotmachine.ReelControl()
        Me.ReelControl7 = New slotmachine.ReelControl()
        Me.ReelControl8 = New slotmachine.ReelControl()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Brown
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Location = New System.Drawing.Point(31, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 108)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SPIN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(51, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = " "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dollarButton
        '
        Me.dollarButton.BackColor = System.Drawing.Color.White
        Me.dollarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.dollarButton.Location = New System.Drawing.Point(44, 286)
        Me.dollarButton.Name = "dollarButton"
        Me.dollarButton.Size = New System.Drawing.Size(89, 39)
        Me.dollarButton.TabIndex = 9
        Me.dollarButton.Text = " INSERT $1.00"
        Me.dollarButton.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 471)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.GrayText
        Me.PictureBox2.Location = New System.Drawing.Point(182, -7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(616, 471)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Black
        Me.PictureBox3.Location = New System.Drawing.Point(38, 248)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 32)
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(42, 331)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 39)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = " INSERT $10.00"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ReelControl5
        '
        Me.ReelControl5.BackColor = System.Drawing.Color.Transparent
        Me.ReelControl5.itemValue = 0
        Me.ReelControl5.Location = New System.Drawing.Point(239, 130)
        Me.ReelControl5.Name = "ReelControl5"
        Me.ReelControl5.Size = New System.Drawing.Size(150, 173)
        Me.ReelControl5.TabIndex = 15
        '
        'ReelControl7
        '
        Me.ReelControl7.BackColor = System.Drawing.Color.Transparent
        Me.ReelControl7.itemValue = 0
        Me.ReelControl7.Location = New System.Drawing.Point(422, 130)
        Me.ReelControl7.Name = "ReelControl7"
        Me.ReelControl7.Size = New System.Drawing.Size(150, 173)
        Me.ReelControl7.TabIndex = 16
        '
        'ReelControl8
        '
        Me.ReelControl8.BackColor = System.Drawing.Color.Transparent
        Me.ReelControl8.itemValue = 0
        Me.ReelControl8.Location = New System.Drawing.Point(605, 130)
        Me.ReelControl8.Name = "ReelControl8"
        Me.ReelControl8.Size = New System.Drawing.Size(150, 173)
        Me.ReelControl8.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReelControl8)
        Me.Controls.Add(Me.ReelControl7)
        Me.Controls.Add(Me.ReelControl5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.dollarButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ReelControl1 As ReelControl
    Friend WithEvents ReelControl2 As ReelControl
    Friend WithEvents ReelControl3 As ReelControl
    Friend WithEvents Label4 As Label
    Friend WithEvents dollarButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ReelControl4 As ReelControl
    Friend WithEvents ReelControl6 As ReelControl
    Friend WithEvents ReelControl5 As ReelControl
    Friend WithEvents ReelControl7 As ReelControl
    Friend WithEvents ReelControl8 As ReelControl
End Class

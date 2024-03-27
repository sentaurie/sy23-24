<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.GPUTotalLabel = New System.Windows.Forms.Label()
        Me.CPUTotalLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MotherboardTotalLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(434, 429)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 33)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "GPU"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(266, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 33)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "CPU"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(31, 135)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(127, 36)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Memory"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(55, 231)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(87, 33)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "Case"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(209, 136)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(190, 33)
        Me.Label30.TabIndex = 30
        Me.Label30.Text = "Motherboard"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(40, 324)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(121, 33)
        Me.Label36.TabIndex = 36
        Me.Label36.Text = "Cooling"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(200, 231)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(206, 33)
        Me.Label42.TabIndex = 42
        Me.Label42.Text = "Power Supply"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(243, 323)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(123, 33)
        Me.Label48.TabIndex = 48
        Me.Label48.Text = "Storage"
        '
        'GPUTotalLabel
        '
        Me.GPUTotalLabel.AutoSize = True
        Me.GPUTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPUTotalLabel.Location = New System.Drawing.Point(568, 51)
        Me.GPUTotalLabel.Name = "GPUTotalLabel"
        Me.GPUTotalLabel.Size = New System.Drawing.Size(0, 25)
        Me.GPUTotalLabel.TabIndex = 53
        '
        'CPUTotalLabel
        '
        Me.CPUTotalLabel.AutoSize = True
        Me.CPUTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPUTotalLabel.Location = New System.Drawing.Point(568, 98)
        Me.CPUTotalLabel.Name = "CPUTotalLabel"
        Me.CPUTotalLabel.Size = New System.Drawing.Size(0, 25)
        Me.CPUTotalLabel.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(568, 362)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 25)
        Me.Label2.TabIndex = 55
        '
        'MotherboardTotalLabel
        '
        Me.MotherboardTotalLabel.AutoSize = True
        Me.MotherboardTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotherboardTotalLabel.Location = New System.Drawing.Point(568, 145)
        Me.MotherboardTotalLabel.Name = "MotherboardTotalLabel"
        Me.MotherboardTotalLabel.Size = New System.Drawing.Size(0, 25)
        Me.MotherboardTotalLabel.TabIndex = 56
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 408)
        Me.Controls.Add(Me.MotherboardTotalLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CPUTotalLabel)
        Me.Controls.Add(Me.GPUTotalLabel)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents GPUTotalLabel As Label
    Friend WithEvents CPUTotalLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MotherboardTotalLabel As Label
End Class

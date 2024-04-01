<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl1))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.priceLabela = New System.Windows.Forms.Label()
        Me.descriptionTtextbox = New System.Windows.Forms.TextBox()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(301, 246)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'priceLabela
        '
        Me.priceLabela.AutoSize = True
        Me.priceLabela.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceLabela.Location = New System.Drawing.Point(100, 249)
        Me.priceLabela.Name = "priceLabela"
        Me.priceLabela.Size = New System.Drawing.Size(102, 33)
        Me.priceLabela.TabIndex = 1
        Me.priceLabela.Text = "Label1"
        '
        'descriptionTtextbox
        '
        Me.descriptionTtextbox.Location = New System.Drawing.Point(0, 285)
        Me.descriptionTtextbox.Multiline = True
        Me.descriptionTtextbox.Name = "descriptionTtextbox"
        Me.descriptionTtextbox.Size = New System.Drawing.Size(301, 86)
        Me.descriptionTtextbox.TabIndex = 2
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "01 gtx1050.jpg")
        Me.ImageList2.Images.SetKeyName(1, "02 gtx1080.jpg")
        Me.ImageList2.Images.SetKeyName(2, "03 3090.jpg")
        Me.ImageList2.Images.SetKeyName(3, "04 4090.jpg")
        Me.ImageList2.Images.SetKeyName(4, "05 RadeonRX7600XT.jpg")
        Me.ImageList2.Images.SetKeyName(5, "06 i5.jpg")
        Me.ImageList2.Images.SetKeyName(6, "07 i7.jpg")
        Me.ImageList2.Images.SetKeyName(7, "08 i9.jpg")
        Me.ImageList2.Images.SetKeyName(8, "09 ryzen5.jpg")
        Me.ImageList2.Images.SetKeyName(9, "10 ryzen7.jpg")
        Me.ImageList2.Images.SetKeyName(10, "11 gskilltrident.jpg")
        Me.ImageList2.Images.SetKeyName(11, "12 tforcedelta.jpg")
        Me.ImageList2.Images.SetKeyName(12, "13 tforcevulcan.jpg")
        Me.ImageList2.Images.SetKeyName(13, "14 gskillripjaw.jpg")
        Me.ImageList2.Images.SetKeyName(14, "15 aorusb550m.jpg")
        Me.ImageList2.Images.SetKeyName(15, "16 msimag.jpg")
        Me.ImageList2.Images.SetKeyName(16, "17 rogstrix.jpg")
        Me.ImageList2.Images.SetKeyName(17, "18 msiz790.png")
        Me.ImageList2.Images.SetKeyName(18, "19 asrock.jpg")
        Me.ImageList2.Images.SetKeyName(19, "CORSAIRRM750e.jpg")
        Me.ImageList2.Images.SetKeyName(20, "CORSAIRRM1000e.jpg")
        Me.ImageList2.Images.SetKeyName(21, "MSI-MAGA750GL.jpg")
        Me.ImageList2.Images.SetKeyName(22, "ThermaltakeSmartSeries.jpg")
        Me.ImageList2.Images.SetKeyName(23, "midtower.jpg")
        Me.ImageList2.Images.SetKeyName(24, "small.jpg")
        Me.ImageList2.Images.SetKeyName(25, "steel.jpg")
        Me.ImageList2.Images.SetKeyName(26, "temperedglass.jpg")
        '
        'UserControl1
        '
        Me.Controls.Add(Me.descriptionTtextbox)
        Me.Controls.Add(Me.priceLabela)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(301, 371)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents priceLabel As Label
    Friend WithEvents descriptionTextBox As TextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pri As Label
    Friend WithEvents priceLabela As Label
    Friend WithEvents descriptionTtextbox As TextBox
    Friend WithEvents ImageList2 As ImageList
End Class

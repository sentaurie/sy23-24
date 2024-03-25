<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.productNameLabel = New System.Windows.Forms.Label()
        Me.descriptionTextBox = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(282, 203)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceLabel.Location = New System.Drawing.Point(176, 240)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(77, 25)
        Me.priceLabel.TabIndex = 1
        Me.priceLabel.Text = "Label1"
        '
        'productNameLabel
        '
        Me.productNameLabel.AutoSize = True
        Me.productNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productNameLabel.Location = New System.Drawing.Point(11, 244)
        Me.productNameLabel.Name = "productNameLabel"
        Me.productNameLabel.Size = New System.Drawing.Size(57, 20)
        Me.productNameLabel.TabIndex = 2
        Me.productNameLabel.Text = "Label2"
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.Location = New System.Drawing.Point(3, 276)
        Me.descriptionTextBox.Multiline = True
        Me.descriptionTextBox.Name = "descriptionTextBox"
        Me.descriptionTextBox.ReadOnly = True
        Me.descriptionTextBox.Size = New System.Drawing.Size(276, 84)
        Me.descriptionTextBox.TabIndex = 4
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "gtx1050.jpg")
        Me.ImageList1.Images.SetKeyName(1, "gtx1080.jpg")
        Me.ImageList1.Images.SetKeyName(2, "3090.jpg")
        Me.ImageList1.Images.SetKeyName(3, "4090.jpg")
        Me.ImageList1.Images.SetKeyName(4, "RadeonRX7600XT.jpg")
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.descriptionTextBox)
        Me.Controls.Add(Me.productNameLabel)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(282, 363)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents priceLabel As Label
    Friend WithEvents productNameLabel As Label
    Friend WithEvents descriptionTextBox As TextBox
    Friend WithEvents ImageList1 As ImageList
End Class

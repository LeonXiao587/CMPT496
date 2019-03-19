<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Renting
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Renting))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Bedroom = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Bathroom = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.price = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.patio = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.den = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.sq = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(433, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Renting"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(194, 131)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Bedroom"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(645, 147)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 46)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "View"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Bedroom
        '
        Me.Bedroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Bedroom.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Bedroom.FormattingEnabled = True
        Me.Bedroom.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.Bedroom.Location = New System.Drawing.Point(199, 160)
        Me.Bedroom.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Bedroom.Name = "Bedroom"
        Me.Bedroom.Size = New System.Drawing.Size(99, 32)
        Me.Bedroom.TabIndex = 8
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 24
        Me.ListBox1.Location = New System.Drawing.Point(51, 57)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(228, 244)
        Me.ListBox1.TabIndex = 12
        '
        'Bathroom
        '
        Me.Bathroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Bathroom.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Bathroom.FormattingEnabled = True
        Me.Bathroom.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.Bathroom.Location = New System.Drawing.Point(328, 160)
        Me.Bathroom.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Bathroom.Name = "Bathroom"
        Me.Bathroom.Size = New System.Drawing.Size(99, 32)
        Me.Bathroom.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(324, 131)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Bathroom"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-446, 95)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 24)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Unit Number"
        '
        'price
        '
        Me.price.AutoSize = True
        Me.price.Location = New System.Drawing.Point(467, 262)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(178, 24)
        Me.price.TabIndex = 50
        Me.price.Text = "______________"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(335, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 24)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Price    $"
        '
        'patio
        '
        Me.patio.AutoSize = True
        Me.patio.Location = New System.Drawing.Point(467, 194)
        Me.patio.Name = "patio"
        Me.patio.Size = New System.Drawing.Size(178, 24)
        Me.patio.TabIndex = 48
        Me.patio.Text = "______________"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(335, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 24)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Patio"
        '
        'den
        '
        Me.den.AutoSize = True
        Me.den.Location = New System.Drawing.Point(468, 127)
        Me.den.Name = "den"
        Me.den.Size = New System.Drawing.Size(178, 24)
        Me.den.TabIndex = 46
        Me.den.Text = "______________"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(350, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 24)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Den"
        '
        'sq
        '
        Me.sq.AutoSize = True
        Me.sq.Location = New System.Drawing.Point(466, 57)
        Me.sq.Name = "sq"
        Me.sq.Size = New System.Drawing.Size(178, 24)
        Me.sq.TabIndex = 44
        Me.sq.Text = "______________"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(308, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 24)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "SquareFeet"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(394, 590)
        Me.Button3.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 46)
        Me.Button3.TabIndex = 51
        Me.Button3.Text = "Sign"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.sq)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.price)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.patio)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.den)
        Me.GroupBox1.Location = New System.Drawing.Point(141, 202)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(694, 369)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unit Info"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(58, 47)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'Renting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(966, 778)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Bathroom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Bedroom)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "Renting"
        Me.Text = "Renting"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Bedroom As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Bathroom As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents price As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents patio As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents den As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents sq As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
End Class

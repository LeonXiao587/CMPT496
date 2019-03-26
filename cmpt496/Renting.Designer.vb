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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Map = New System.Windows.Forms.Label()
        Me.BIDLabel = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.bedroomLabel4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.bathroomLabel12 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.OtherBuild = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Filterrect = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 21.85714!)
        Me.Label1.Location = New System.Drawing.Point(207, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Renting"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Bedroom"
        '
        'Bedroom
        '
        Me.Bedroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Bedroom.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Bedroom.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Bedroom.FormattingEnabled = True
        Me.Bedroom.Items.AddRange(New Object() {"Any", "1", "2", "3", "4"})
        Me.Bedroom.Location = New System.Drawing.Point(70, 79)
        Me.Bedroom.Name = "Bedroom"
        Me.Bedroom.Size = New System.Drawing.Size(51, 25)
        Me.Bedroom.TabIndex = 8
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(17, 27)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(116, 174)
        Me.ListBox1.TabIndex = 12
        '
        'Bathroom
        '
        Me.Bathroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Bathroom.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Bathroom.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Bathroom.FormattingEnabled = True
        Me.Bathroom.Items.AddRange(New Object() {"Any", "1", "2", "3"})
        Me.Bathroom.Location = New System.Drawing.Point(149, 79)
        Me.Bathroom.Name = "Bathroom"
        Me.Bathroom.Size = New System.Drawing.Size(51, 25)
        Me.Bathroom.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(146, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Bathroom"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-223, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 12)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Unit Number"
        '
        'price
        '
        Me.price.AutoSize = True
        Me.price.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.price.Location = New System.Drawing.Point(227, 198)
        Me.price.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(38, 17)
        Me.price.TabIndex = 50
        Me.price.Text = "______"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(161, 198)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Price    $"
        '
        'patio
        '
        Me.patio.AutoSize = True
        Me.patio.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.patio.Location = New System.Drawing.Point(227, 165)
        Me.patio.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.patio.Name = "patio"
        Me.patio.Size = New System.Drawing.Size(38, 17)
        Me.patio.TabIndex = 48
        Me.patio.Text = "______"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(161, 165)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 17)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Patio"
        '
        'den
        '
        Me.den.AutoSize = True
        Me.den.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.den.Location = New System.Drawing.Point(227, 133)
        Me.den.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.den.Name = "den"
        Me.den.Size = New System.Drawing.Size(38, 17)
        Me.den.TabIndex = 46
        Me.den.Text = "______"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(161, 133)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 17)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Den"
        '
        'sq
        '
        Me.sq.AutoSize = True
        Me.sq.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.sq.Location = New System.Drawing.Point(227, 102)
        Me.sq.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.sq.Name = "sq"
        Me.sq.Size = New System.Drawing.Size(38, 17)
        Me.sq.TabIndex = 44
        Me.sq.Text = "______"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(140, 102)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 17)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "SquareFeet"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Map)
        Me.GroupBox1.Controls.Add(Me.BIDLabel)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.bedroomLabel4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.bathroomLabel12)
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
        Me.GroupBox1.Location = New System.Drawing.Point(69, 101)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(339, 228)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unit Info"
        '
        'Map
        '
        Me.Map.AutoSize = True
        Me.Map.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Map.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Map.Location = New System.Drawing.Point(263, 15)
        Me.Map.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Map.Name = "Map"
        Me.Map.Size = New System.Drawing.Size(35, 17)
        Me.Map.TabIndex = 57
        Me.Map.Text = "Map"
        '
        'BIDLabel
        '
        Me.BIDLabel.AutoSize = True
        Me.BIDLabel.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BIDLabel.Location = New System.Drawing.Point(227, 15)
        Me.BIDLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.BIDLabel.Name = "BIDLabel"
        Me.BIDLabel.Size = New System.Drawing.Size(38, 17)
        Me.BIDLabel.TabIndex = 56
        Me.BIDLabel.Text = "______"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.Location = New System.Drawing.Point(150, 15)
        Me.Label14.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 17)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Building"
        '
        'bedroomLabel4
        '
        Me.bedroomLabel4.AutoSize = True
        Me.bedroomLabel4.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.bedroomLabel4.Location = New System.Drawing.Point(227, 42)
        Me.bedroomLabel4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.bedroomLabel4.Name = "bedroomLabel4"
        Me.bedroomLabel4.Size = New System.Drawing.Size(38, 17)
        Me.bedroomLabel4.TabIndex = 52
        Me.bedroomLabel4.Text = "______"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(146, 42)
        Me.Label10.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 17)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Bedroom"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(146, 73)
        Me.Label11.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 17)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Bathroom"
        '
        'bathroomLabel12
        '
        Me.bathroomLabel12.AutoSize = True
        Me.bathroomLabel12.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.bathroomLabel12.Location = New System.Drawing.Point(227, 73)
        Me.bathroomLabel12.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.bathroomLabel12.Name = "bathroomLabel12"
        Me.bathroomLabel12.Size = New System.Drawing.Size(38, 17)
        Me.bathroomLabel12.TabIndex = 54
        Me.bathroomLabel12.Text = "______"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(29, 23)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'OtherBuild
        '
        Me.OtherBuild.AutoSize = True
        Me.OtherBuild.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OtherBuild.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.OtherBuild.Location = New System.Drawing.Point(211, 80)
        Me.OtherBuild.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.OtherBuild.Name = "OtherBuild"
        Me.OtherBuild.Size = New System.Drawing.Size(109, 21)
        Me.OtherBuild.TabIndex = 54
        Me.OtherBuild.Text = "Other Building"
        Me.OtherBuild.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(167, 17)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 82
        Me.PictureBox1.TabStop = False
        '
        'Filterrect
        '
        Me.Filterrect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Filterrect.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.Filterrect.CornerRadius = 11
        Me.Filterrect.Location = New System.Drawing.Point(324, 69)
        Me.Filterrect.Name = "Filterrect"
        Me.Filterrect.SelectionColor = System.Drawing.SystemColors.GrayText
        Me.Filterrect.Size = New System.Drawing.Size(86, 30)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.Filterrect})
        Me.ShapeContainer1.Size = New System.Drawing.Size(487, 431)
        Me.ShapeContainer1.TabIndex = 83
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.CornerRadius = 11
        Me.RectangleShape1.Location = New System.Drawing.Point(186, 339)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.SystemColors.GrayText
        Me.RectangleShape1.Size = New System.Drawing.Size(83, 31)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(346, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 21)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Filter"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(207, 345)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 21)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Sign"
        '
        'Renting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(487, 431)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.OtherBuild)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Bathroom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Bedroom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Renting"
        Me.Text = "Renting"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents OtherBuild As CheckBox
    Friend WithEvents BIDLabel As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents bedroomLabel4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents bathroomLabel12 As Label
    Friend WithEvents Map As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Filterrect As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents ColorDialog1 As ColorDialog
End Class

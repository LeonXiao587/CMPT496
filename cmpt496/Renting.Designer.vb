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
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 21.85714!)
        Me.Label1.Location = New System.Drawing.Point(379, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Renting"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(150, 113)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Bedroom"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(614, 129)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 40)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Filter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Bedroom
        '
        Me.Bedroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Bedroom.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Bedroom.FormattingEnabled = True
        Me.Bedroom.Items.AddRange(New Object() {"Any", "1", "2", "3", "4"})
        Me.Bedroom.Location = New System.Drawing.Point(154, 138)
        Me.Bedroom.Margin = New System.Windows.Forms.Padding(5)
        Me.Bedroom.Name = "Bedroom"
        Me.Bedroom.Size = New System.Drawing.Size(91, 29)
        Me.Bedroom.TabIndex = 8
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 21
        Me.ListBox1.Location = New System.Drawing.Point(47, 50)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(209, 319)
        Me.ListBox1.TabIndex = 12
        '
        'Bathroom
        '
        Me.Bathroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Bathroom.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Bathroom.FormattingEnabled = True
        Me.Bathroom.Items.AddRange(New Object() {"Any", "1", "2", "3"})
        Me.Bathroom.Location = New System.Drawing.Point(273, 138)
        Me.Bathroom.Margin = New System.Windows.Forms.Padding(5)
        Me.Bathroom.Name = "Bathroom"
        Me.Bathroom.Size = New System.Drawing.Size(91, 29)
        Me.Bathroom.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(269, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Bathroom"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-409, 83)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 21)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Unit Number"
        '
        'price
        '
        Me.price.AutoSize = True
        Me.price.Location = New System.Drawing.Point(415, 346)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(76, 21)
        Me.price.TabIndex = 50
        Me.price.Text = "______"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(294, 346)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 21)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Price    $"
        '
        'patio
        '
        Me.patio.AutoSize = True
        Me.patio.Location = New System.Drawing.Point(416, 288)
        Me.patio.Name = "patio"
        Me.patio.Size = New System.Drawing.Size(76, 21)
        Me.patio.TabIndex = 48
        Me.patio.Text = "______"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(295, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 21)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Patio"
        '
        'den
        '
        Me.den.AutoSize = True
        Me.den.Location = New System.Drawing.Point(417, 232)
        Me.den.Name = "den"
        Me.den.Size = New System.Drawing.Size(76, 21)
        Me.den.TabIndex = 46
        Me.den.Text = "______"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(309, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 21)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Den"
        '
        'sq
        '
        Me.sq.AutoSize = True
        Me.sq.Location = New System.Drawing.Point(416, 178)
        Me.sq.Name = "sq"
        Me.sq.Size = New System.Drawing.Size(76, 21)
        Me.sq.TabIndex = 44
        Me.sq.Text = "______"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(271, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 21)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "SquareFeet"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(356, 610)
        Me.Button3.Margin = New System.Windows.Forms.Padding(5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 40)
        Me.Button3.TabIndex = 51
        Me.Button3.Text = "Sign"
        Me.Button3.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Location = New System.Drawing.Point(129, 177)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(622, 399)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unit Info"
        '
        'Map
        '
        Me.Map.AutoSize = True
        Me.Map.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Map.Location = New System.Drawing.Point(481, 27)
        Me.Map.Name = "Map"
        Me.Map.Size = New System.Drawing.Size(43, 21)
        Me.Map.TabIndex = 57
        Me.Map.Text = "Map"
        '
        'BIDLabel
        '
        Me.BIDLabel.AutoSize = True
        Me.BIDLabel.Location = New System.Drawing.Point(415, 27)
        Me.BIDLabel.Name = "BIDLabel"
        Me.BIDLabel.Size = New System.Drawing.Size(76, 21)
        Me.BIDLabel.TabIndex = 56
        Me.BIDLabel.Text = "______"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(284, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 21)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Building"
        '
        'bedroomLabel4
        '
        Me.bedroomLabel4.AutoSize = True
        Me.bedroomLabel4.Location = New System.Drawing.Point(415, 74)
        Me.bedroomLabel4.Name = "bedroomLabel4"
        Me.bedroomLabel4.Size = New System.Drawing.Size(76, 21)
        Me.bedroomLabel4.TabIndex = 52
        Me.bedroomLabel4.Text = "______"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(284, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 21)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Bedroom"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(284, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 21)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Bathroom"
        '
        'bathroomLabel12
        '
        Me.bathroomLabel12.AutoSize = True
        Me.bathroomLabel12.Location = New System.Drawing.Point(417, 127)
        Me.bathroomLabel12.Name = "bathroomLabel12"
        Me.bathroomLabel12.Size = New System.Drawing.Size(76, 21)
        Me.bathroomLabel12.TabIndex = 54
        Me.bathroomLabel12.Text = "______"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(53, 41)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'OtherBuild
        '
        Me.OtherBuild.AutoSize = True
        Me.OtherBuild.Location = New System.Drawing.Point(388, 140)
        Me.OtherBuild.Name = "OtherBuild"
        Me.OtherBuild.Size = New System.Drawing.Size(190, 25)
        Me.OtherBuild.TabIndex = 54
        Me.OtherBuild.Text = "Other Building"
        Me.OtherBuild.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(307, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 82
        Me.PictureBox1.TabStop = False
        '
        'Renting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(867, 681)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.OtherBuild)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Bathroom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Bedroom)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(5)
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
    Friend WithEvents OtherBuild As CheckBox
    Friend WithEvents BIDLabel As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents bedroomLabel4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents bathroomLabel12 As Label
    Friend WithEvents Map As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

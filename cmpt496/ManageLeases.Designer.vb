<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageLeases
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageLeases))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.searchBox1 = New System.Windows.Forms.TextBox()
        Me.UnitLabel1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PhoneBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lastnBox1 = New System.Windows.Forms.TextBox()
        Me.passwordBox7 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fistnBox6 = New System.Windows.Forms.TextBox()
        Me.emailBox5 = New System.Windows.Forms.TextBox()
        Me.CompanyBox4 = New System.Windows.Forms.TextBox()
        Me.IncomeBox3 = New System.Windows.Forms.TextBox()
        Me.OccupationBox2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(478, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 78)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Tenant"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(102, 64)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 68)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 79
        Me.PictureBox2.TabStop = False
        '
        'searchBox1
        '
        Me.searchBox1.Location = New System.Drawing.Point(486, 184)
        Me.searchBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.searchBox1.Name = "searchBox1"
        Me.searchBox1.Size = New System.Drawing.Size(206, 35)
        Me.searchBox1.TabIndex = 81
        '
        'UnitLabel1
        '
        Me.UnitLabel1.AutoSize = True
        Me.UnitLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UnitLabel1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UnitLabel1.ForeColor = System.Drawing.Color.White
        Me.UnitLabel1.Location = New System.Drawing.Point(704, 184)
        Me.UnitLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UnitLabel1.Name = "UnitLabel1"
        Me.UnitLabel1.Size = New System.Drawing.Size(120, 41)
        Me.UnitLabel1.TabIndex = 82
        Me.UnitLabel1.Text = "Search"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(358, 182)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 31)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Phone"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PhoneBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lastnBox1)
        Me.GroupBox1.Controls.Add(Me.passwordBox7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.fistnBox6)
        Me.GroupBox1.Controls.Add(Me.emailBox5)
        Me.GroupBox1.Controls.Add(Me.CompanyBox4)
        Me.GroupBox1.Controls.Add(Me.IncomeBox3)
        Me.GroupBox1.Controls.Add(Me.OccupationBox2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 10.71429!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(190, 260)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(678, 501)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tenant Info"
        '
        'PhoneBox1
        '
        Me.PhoneBox1.Location = New System.Drawing.Point(270, 372)
        Me.PhoneBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PhoneBox1.Name = "PhoneBox1"
        Me.PhoneBox1.Size = New System.Drawing.Size(258, 45)
        Me.PhoneBox1.TabIndex = 97
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(130, 372)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 31)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Phone"
        '
        'lastnBox1
        '
        Me.lastnBox1.Location = New System.Drawing.Point(402, 60)
        Me.lastnBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.lastnBox1.Name = "lastnBox1"
        Me.lastnBox1.Size = New System.Drawing.Size(126, 45)
        Me.lastnBox1.TabIndex = 95
        Me.lastnBox1.Text = "Last"
        '
        'passwordBox7
        '
        Me.passwordBox7.Location = New System.Drawing.Point(270, 438)
        Me.passwordBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.passwordBox7.Name = "passwordBox7"
        Me.passwordBox7.Size = New System.Drawing.Size(258, 45)
        Me.passwordBox7.TabIndex = 93
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(118, 438)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 31)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Password"
        '
        'fistnBox6
        '
        Me.fistnBox6.Location = New System.Drawing.Point(270, 60)
        Me.fistnBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.fistnBox6.Name = "fistnBox6"
        Me.fistnBox6.Size = New System.Drawing.Size(126, 45)
        Me.fistnBox6.TabIndex = 90
        Me.fistnBox6.Text = "First"
        '
        'emailBox5
        '
        Me.emailBox5.Location = New System.Drawing.Point(270, 122)
        Me.emailBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.emailBox5.Name = "emailBox5"
        Me.emailBox5.Size = New System.Drawing.Size(258, 45)
        Me.emailBox5.TabIndex = 89
        '
        'CompanyBox4
        '
        Me.CompanyBox4.Location = New System.Drawing.Point(270, 242)
        Me.CompanyBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.CompanyBox4.Name = "CompanyBox4"
        Me.CompanyBox4.Size = New System.Drawing.Size(258, 45)
        Me.CompanyBox4.TabIndex = 88
        '
        'IncomeBox3
        '
        Me.IncomeBox3.Location = New System.Drawing.Point(270, 306)
        Me.IncomeBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.IncomeBox3.Name = "IncomeBox3"
        Me.IncomeBox3.Size = New System.Drawing.Size(258, 45)
        Me.IncomeBox3.TabIndex = 87
        '
        'OccupationBox2
        '
        Me.OccupationBox2.Location = New System.Drawing.Point(270, 184)
        Me.OccupationBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.OccupationBox2.Name = "OccupationBox2"
        Me.OccupationBox2.Size = New System.Drawing.Size(258, 45)
        Me.OccupationBox2.TabIndex = 86
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.Location = New System.Drawing.Point(136, 68)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 31)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(140, 122)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 31)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Email"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(108, 182)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 31)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Occupation"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-446, 94)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 38)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Unit Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(118, 240)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 31)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Company"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(130, 306)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 31)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Income"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(926, 260)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 41)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Update"
        '
        'ManageLeases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1130, 808)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UnitLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.searchBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ManageLeases"
        Me.Text = "ManageLeases"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents searchBox1 As TextBox
    Friend WithEvents UnitLabel1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents fistnBox6 As TextBox
    Friend WithEvents emailBox5 As TextBox
    Friend WithEvents CompanyBox4 As TextBox
    Friend WithEvents IncomeBox3 As TextBox
    Friend WithEvents OccupationBox2 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents passwordBox7 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lastnBox1 As TextBox
    Friend WithEvents PhoneBox1 As TextBox
    Friend WithEvents Label7 As Label
End Class

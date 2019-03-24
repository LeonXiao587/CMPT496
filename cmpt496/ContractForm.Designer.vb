<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContractForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContractForm))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.unitlable = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.last_name = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.first_name = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.incomeLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(51, 43)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 54
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 21.85714!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(624, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 51)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Unit: "
        '
        'unitlable
        '
        Me.unitlable.AutoSize = True
        Me.unitlable.Font = New System.Drawing.Font("宋体", 21.85714!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.unitlable.Location = New System.Drawing.Point(753, 51)
        Me.unitlable.Name = "unitlable"
        Me.unitlable.Size = New System.Drawing.Size(178, 51)
        Me.unitlable.TabIndex = 56
        Me.unitlable.Text = "Number"
        '
        'phone
        '
        Me.phone.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.phone.Location = New System.Drawing.Point(215, 289)
        Me.phone.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(288, 31)
        Me.phone.TabIndex = 66
        '
        'id
        '
        Me.id.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.id.Location = New System.Drawing.Point(215, 218)
        Me.id.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(288, 31)
        Me.id.TabIndex = 65
        '
        'last_name
        '
        Me.last_name.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.last_name.Location = New System.Drawing.Point(215, 144)
        Me.last_name.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.last_name.Name = "last_name"
        Me.last_name.Size = New System.Drawing.Size(288, 31)
        Me.last_name.TabIndex = 64
        Me.last_name.Text = "Enter Last Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(59, 294)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 21)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Phone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 224)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 21)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "ID Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 149)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 21)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Last name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'first_name
        '
        Me.first_name.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.first_name.Location = New System.Drawing.Point(215, 75)
        Me.first_name.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.first_name.Name = "first_name"
        Me.first_name.Size = New System.Drawing.Size(288, 31)
        Me.first_name.TabIndex = 60
        Me.first_name.Text = "Enter First Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 75)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 21)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "First name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'email
        '
        Me.email.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.email.Location = New System.Drawing.Point(215, 359)
        Me.email.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(288, 31)
        Me.email.TabIndex = 68
        Me.email.Text = "Enter Email Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 364)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Email"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(665, 640)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 45)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.last_name)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.first_name)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Controls.Add(Me.email)
        Me.GroupBox1.Controls.Add(Me.phone)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(164, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 454)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tenant Information"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(186, 364)
        Me.Label16.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 21)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(186, 289)
        Me.Label15.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 21)
        Me.Label15.TabIndex = 72
        Me.Label15.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(186, 224)
        Me.Label14.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 21)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(186, 147)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 21)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(186, 75)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 21)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "*"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(552, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 82
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.incomeLabel)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(780, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(536, 454)
        Me.GroupBox2.TabIndex = 76
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Other information"
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox1.Location = New System.Drawing.Point(215, 124)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(288, 31)
        Me.TextBox1.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 21)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Previous Address"
        '
        'TextBox2
        '
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox2.Location = New System.Drawing.Point(215, 75)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(288, 31)
        Me.TextBox2.TabIndex = 60
        '
        'incomeLabel
        '
        Me.incomeLabel.AutoSize = True
        Me.incomeLabel.Location = New System.Drawing.Point(59, 124)
        Me.incomeLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.incomeLabel.Name = "incomeLabel"
        Me.incomeLabel.Size = New System.Drawing.Size(76, 21)
        Me.incomeLabel.TabIndex = 61
        Me.incomeLabel.Text = "Income"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 177)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 21)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Occupation"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(59, 222)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 21)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Company"
        '
        'TextBox3
        '
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox3.Location = New System.Drawing.Point(215, 171)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(288, 31)
        Me.TextBox3.TabIndex = 65
        '
        'TextBox5
        '
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox5.Location = New System.Drawing.Point(215, 219)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(288, 31)
        Me.TextBox5.TabIndex = 66
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(70, 272)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 21)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Email"
        '
        'TextBox4
        '
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox4.Location = New System.Drawing.Point(215, 269)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(288, 31)
        Me.TextBox4.TabIndex = 68
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(53, 325)
        Me.Label17.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 21)
        Me.Label17.TabIndex = 69
        Me.Label17.Text = "Username"
        '
        'TextBox6
        '
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox6.Location = New System.Drawing.Point(215, 375)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(288, 31)
        Me.TextBox6.TabIndex = 72
        Me.TextBox6.UseSystemPasswordChar = True
        '
        'TextBox7
        '
        Me.TextBox7.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox7.Location = New System.Drawing.Point(215, 325)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(288, 31)
        Me.TextBox7.TabIndex = 70
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(53, 378)
        Me.Label18.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(98, 21)
        Me.Label18.TabIndex = 71
        Me.Label18.Text = "Password"
        '
        'ContractForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1461, 722)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.unitlable)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "ContractForm"
        Me.Text = "Lease Signup"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents unitlable As Label
    Friend WithEvents phone As TextBox
    Friend WithEvents id As TextBox
    Friend WithEvents last_name As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents first_name As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents incomeLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label11 As Label
End Class

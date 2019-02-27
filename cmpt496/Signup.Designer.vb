<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.first_name = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.password1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.last_name = New System.Windows.Forms.TextBox()
        Me.staffid = New System.Windows.Forms.TextBox()
        Me.BID = New System.Windows.Forms.TextBox()
        Me.title = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(338, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New user sign up"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(58, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Main"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "New username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "E-mail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(461, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "First name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'username
        '
        Me.username.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.username.Location = New System.Drawing.Point(270, 129)
        Me.username.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(159, 21)
        Me.username.TabIndex = 7
        Me.username.Text = "Enter username here"
        '
        'password
        '
        Me.password.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.password.Location = New System.Drawing.Point(270, 176)
        Me.password.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(159, 21)
        Me.password.TabIndex = 8
        Me.password.Text = "Enter password here"
        '
        'email
        '
        Me.email.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.email.Location = New System.Drawing.Point(270, 262)
        Me.email.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(159, 21)
        Me.email.TabIndex = 10
        Me.email.Text = "Enter E-mail here"
        '
        'first_name
        '
        Me.first_name.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.first_name.Location = New System.Drawing.Point(546, 129)
        Me.first_name.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.first_name.Name = "first_name"
        Me.first_name.Size = New System.Drawing.Size(159, 21)
        Me.first_name.TabIndex = 11
        Me.first_name.Text = "Enter First Name"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(251, 369)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Sign Up"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(457, 369)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(461, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 12)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Last name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(461, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Staff ID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(461, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 12)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Building ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(165, 316)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 12)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Title"
        '
        'password1
        '
        Me.password1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.password1.Location = New System.Drawing.Point(270, 221)
        Me.password1.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.password1.Name = "password1"
        Me.password1.Size = New System.Drawing.Size(159, 21)
        Me.password1.TabIndex = 9
        Me.password1.Text = "Enter password again"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(165, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 12)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Re-type Password"
        '
        'last_name
        '
        Me.last_name.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.last_name.Location = New System.Drawing.Point(546, 176)
        Me.last_name.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.last_name.Name = "last_name"
        Me.last_name.Size = New System.Drawing.Size(159, 21)
        Me.last_name.TabIndex = 18
        Me.last_name.Text = "Enter Last Name"
        '
        'staffid
        '
        Me.staffid.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.staffid.Location = New System.Drawing.Point(546, 221)
        Me.staffid.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.staffid.Name = "staffid"
        Me.staffid.Size = New System.Drawing.Size(159, 21)
        Me.staffid.TabIndex = 19
        Me.staffid.Text = "Enter Staff ID"
        '
        'BID
        '
        Me.BID.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.BID.Location = New System.Drawing.Point(546, 262)
        Me.BID.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.BID.Name = "BID"
        Me.BID.Size = New System.Drawing.Size(159, 21)
        Me.BID.TabIndex = 20
        Me.BID.Text = "Enter Building ID"
        '
        'title
        '
        Me.title.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.title.Location = New System.Drawing.Point(270, 313)
        Me.title.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(159, 21)
        Me.title.TabIndex = 21
        Me.title.Text = "Enter Job Title"
        '
        'Signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 511)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.BID)
        Me.Controls.Add(Me.staffid)
        Me.Controls.Add(Me.last_name)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.first_name)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.password1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Signup"
        Me.Text = "Signup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents first_name As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents password1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents last_name As TextBox
    Friend WithEvents staffid As TextBox
    Friend WithEvents BID As TextBox
    Friend WithEvents title As TextBox
End Class

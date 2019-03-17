<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Renting
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Bedroom = New System.Windows.Forms.ComboBox()
        Me.parking = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Bathroom = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ParkingList = New System.Windows.Forms.ListBox()
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
        Me.doornumber = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(397, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Renting"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(76, 42)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Main"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(181, 162)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Bedroom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(778, 195)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Parking Type"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(508, 176)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 40)
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
        Me.Bedroom.Location = New System.Drawing.Point(185, 187)
        Me.Bedroom.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Bedroom.Name = "Bedroom"
        Me.Bedroom.Size = New System.Drawing.Size(91, 29)
        Me.Bedroom.TabIndex = 8
        '
        'parking
        '
        Me.parking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.parking.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.parking.FormattingEnabled = True
        Me.parking.Items.AddRange(New Object() {"Not Needed"})
        Me.parking.Location = New System.Drawing.Point(781, 220)
        Me.parking.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.parking.Name = "parking"
        Me.parking.Size = New System.Drawing.Size(130, 29)
        Me.parking.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(917, 140)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(352, 322)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 21
        Me.ListBox1.Items.AddRange(New Object() {"None"})
        Me.ListBox1.Location = New System.Drawing.Point(182, 269)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(209, 214)
        Me.ListBox1.TabIndex = 12
        '
        'Bathroom
        '
        Me.Bathroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Bathroom.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Bathroom.FormattingEnabled = True
        Me.Bathroom.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.Bathroom.Location = New System.Drawing.Point(304, 187)
        Me.Bathroom.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Bathroom.Name = "Bathroom"
        Me.Bathroom.Size = New System.Drawing.Size(91, 29)
        Me.Bathroom.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(300, 162)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Bathroom"
        '
        'ParkingList
        '
        Me.ParkingList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ParkingList.FormattingEnabled = True
        Me.ParkingList.ItemHeight = 21
        Me.ParkingList.Location = New System.Drawing.Point(781, 311)
        Me.ParkingList.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ParkingList.Name = "ParkingList"
        Me.ParkingList.Size = New System.Drawing.Size(130, 149)
        Me.ParkingList.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(178, 245)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 21)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Unit Number"
        '
        'price
        '
        Me.price.AutoSize = True
        Me.price.Location = New System.Drawing.Point(564, 448)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(164, 21)
        Me.price.TabIndex = 50
        Me.price.Text = "______________"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(443, 448)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 21)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Price"
        '
        'patio
        '
        Me.patio.AutoSize = True
        Me.patio.Location = New System.Drawing.Point(564, 391)
        Me.patio.Name = "patio"
        Me.patio.Size = New System.Drawing.Size(164, 21)
        Me.patio.TabIndex = 48
        Me.patio.Text = "______________"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(443, 391)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 21)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Patio"
        '
        'den
        '
        Me.den.AutoSize = True
        Me.den.Location = New System.Drawing.Point(564, 340)
        Me.den.Name = "den"
        Me.den.Size = New System.Drawing.Size(164, 21)
        Me.den.TabIndex = 46
        Me.den.Text = "______________"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(456, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 21)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Den"
        '
        'sq
        '
        Me.sq.AutoSize = True
        Me.sq.Location = New System.Drawing.Point(564, 289)
        Me.sq.Name = "sq"
        Me.sq.Size = New System.Drawing.Size(164, 21)
        Me.sq.TabIndex = 44
        Me.sq.Text = "______________"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(419, 289)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 21)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "SquareFeet"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(216, 511)
        Me.Button3.Margin = New System.Windows.Forms.Padding(5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 40)
        Me.Button3.TabIndex = 51
        Me.Button3.Text = "Detail"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'doornumber
        '
        Me.doornumber.AutoSize = True
        Me.doornumber.Location = New System.Drawing.Point(564, 245)
        Me.doornumber.Name = "doornumber"
        Me.doornumber.Size = New System.Drawing.Size(164, 21)
        Me.doornumber.TabIndex = 53
        Me.doornumber.Text = "______________"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(408, 245)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 21)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Door Number"
        '
        'Renting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1283, 681)
        Me.Controls.Add(Me.doornumber)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.patio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.den)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.sq)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ParkingList)
        Me.Controls.Add(Me.Bathroom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.parking)
        Me.Controls.Add(Me.Bedroom)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Renting"
        Me.Text = "Renting"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Bedroom As ComboBox
    Friend WithEvents parking As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Bathroom As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ParkingList As ListBox
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
    Friend WithEvents doornumber As Label
    Friend WithEvents Label11 As Label
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Parking
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Parking))
        Me.ParkingType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Building = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Parkinglist = New System.Windows.Forms.DataGridView()
        Me.searchbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Statusbox = New System.Windows.Forms.ComboBox()
        Me.Crate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Orate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip5 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip6 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip7 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Parkinglist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ParkingType
        '
        Me.ParkingType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ParkingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ParkingType.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.ParkingType.FormattingEnabled = True
        Me.ParkingType.Items.AddRange(New Object() {"All", "Outside", "Covered"})
        Me.ParkingType.Location = New System.Drawing.Point(38, 255)
        Me.ParkingType.Name = "ParkingType"
        Me.ParkingType.Size = New System.Drawing.Size(106, 20)
        Me.ParkingType.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(384, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 36)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Parking"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(342, 21)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 78
        Me.PictureBox3.TabStop = False
        '
        'Building
        '
        Me.Building.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Building.AutoSize = True
        Me.Building.BackColor = System.Drawing.Color.Transparent
        Me.Building.Font = New System.Drawing.Font("微软雅黑", 10.5!)
        Me.Building.Location = New System.Drawing.Point(232, 390)
        Me.Building.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Building.Name = "Building"
        Me.Building.Size = New System.Drawing.Size(0, 20)
        Me.Building.TabIndex = 80
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 10.5!)
        Me.Label3.Location = New System.Drawing.Point(155, 390)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Building: "
        Me.ToolTip4.SetToolTip(Me.Label3, "Current Building Number." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Parkinglist
        '
        Me.Parkinglist.AllowUserToOrderColumns = True
        Me.Parkinglist.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Parkinglist.BackgroundColor = System.Drawing.Color.White
        Me.Parkinglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Parkinglist.Location = New System.Drawing.Point(168, 77)
        Me.Parkinglist.Name = "Parkinglist"
        Me.Parkinglist.ReadOnly = True
        Me.Parkinglist.RowTemplate.Height = 23
        Me.Parkinglist.Size = New System.Drawing.Size(589, 273)
        Me.Parkinglist.TabIndex = 81
        '
        'searchbox
        '
        Me.searchbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.searchbox.Location = New System.Drawing.Point(36, 169)
        Me.searchbox.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.searchbox.Name = "searchbox"
        Me.searchbox.Size = New System.Drawing.Size(108, 21)
        Me.searchbox.TabIndex = 83
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Stall Number "
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 196)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 20)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Or"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 232)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Stall Type"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 278)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 20)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Status"
        '
        'Statusbox
        '
        Me.Statusbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Statusbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Statusbox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Statusbox.FormattingEnabled = True
        Me.Statusbox.Items.AddRange(New Object() {"All", "Vacant", "Occupied"})
        Me.Statusbox.Location = New System.Drawing.Point(38, 301)
        Me.Statusbox.Name = "Statusbox"
        Me.Statusbox.Size = New System.Drawing.Size(106, 20)
        Me.Statusbox.TabIndex = 87
        '
        'Crate
        '
        Me.Crate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Crate.Location = New System.Drawing.Point(274, 390)
        Me.Crate.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Crate.Name = "Crate"
        Me.Crate.Size = New System.Drawing.Size(73, 21)
        Me.Crate.TabIndex = 90
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(277, 364)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 20)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Covered"
        Me.ToolTip5.SetToolTip(Me.Label7, "Covered Parking Rate." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Orate
        '
        Me.Orate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Orate.Location = New System.Drawing.Point(390, 390)
        Me.Orate.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Orate.Name = "Orate"
        Me.Orate.Size = New System.Drawing.Size(73, 21)
        Me.Orate.TabIndex = 92
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(397, 364)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 20)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Outside"
        Me.ToolTip5.SetToolTip(Me.Label8, "Outside Parking Rate." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RectangleShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.CornerRadius = 11
        Me.RectangleShape2.Location = New System.Drawing.Point(508, 374)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.SelectionColor = System.Drawing.SystemColors.GrayText
        Me.RectangleShape2.Size = New System.Drawing.Size(107, 40)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape5, Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape1, Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(784, 461)
        Me.ShapeContainer1.TabIndex = 94
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape4
        '
        Me.RectangleShape4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RectangleShape4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RectangleShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape4.CornerRadius = 11
        Me.RectangleShape4.Location = New System.Drawing.Point(649, 366)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.SelectionColor = System.Drawing.SystemColors.GrayText
        Me.RectangleShape4.Size = New System.Drawing.Size(107, 40)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RectangleShape3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.CornerRadius = 11
        Me.RectangleShape3.Location = New System.Drawing.Point(52, 130)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.SelectionColor = System.Drawing.SystemColors.GrayText
        Me.RectangleShape3.Size = New System.Drawing.Size(74, 27)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.CornerRadius = 11
        Me.RectangleShape1.Location = New System.Drawing.Point(57, 342)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.SystemColors.GrayText
        Me.RectangleShape1.Size = New System.Drawing.Size(72, 27)
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(513, 384)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 21)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "Rate Adjust"
        Me.ToolTip6.SetToolTip(Me.Label9, "Click to Adjust Parking Rate." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(70, 345)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 21)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = "Load"
        Me.ToolTip3.SetToolTip(Me.Label10, "Click to Load selected Stall Type and Status." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(51, 23)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 97
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "Click to go back to Management Option screen." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(59, 133)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 21)
        Me.Label11.TabIndex = 98
        Me.Label11.Text = "Search"
        Me.ToolTip2.SetToolTip(Me.Label11, "Click to Search Inputed text." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(671, 378)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 21)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "Update"
        Me.ToolTip7.SetToolTip(Me.Label12, "Click to Edit Table information." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "BackButton"
        '
        'ToolTip2
        '
        Me.ToolTip2.ToolTipTitle = "SearchButton"
        '
        'ToolTip3
        '
        Me.ToolTip3.ToolTipTitle = "LoadButton"
        '
        'ToolTip4
        '
        Me.ToolTip4.ToolTipTitle = "Building"
        '
        'ToolTip5
        '
        Me.ToolTip5.ToolTipTitle = "Parking Rate"
        '
        'ToolTip6
        '
        Me.ToolTip6.ToolTipTitle = "Rate Adjust Button"
        '
        'ToolTip7
        '
        Me.ToolTip7.ToolTipTitle = "EditButton"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(681, 429)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 21)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "Add"
        Me.ToolTip7.SetToolTip(Me.Label13, "Click to Edit Table information." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'RectangleShape5
        '
        Me.RectangleShape5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RectangleShape5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RectangleShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape5.CornerRadius = 11
        Me.RectangleShape5.Location = New System.Drawing.Point(650, 418)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.SelectionColor = System.Drawing.SystemColors.GrayText
        Me.RectangleShape5.Size = New System.Drawing.Size(107, 40)
        '
        'Parking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Orate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Crate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Statusbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.searchbox)
        Me.Controls.Add(Me.Building)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.ParkingType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Parkinglist)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Parking"
        Me.Text = "Parking"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Parkinglist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ParkingType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Building As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Parkinglist As DataGridView
    Friend WithEvents searchbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Statusbox As ComboBox
    Friend WithEvents Crate As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Orate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents Label11 As Label
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents Label12 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents ToolTip4 As ToolTip
    Friend WithEvents ToolTip5 As ToolTip
    Friend WithEvents ToolTip6 As ToolTip
    Friend WithEvents ToolTip7 As ToolTip
    Friend WithEvents RectangleShape5 As PowerPacks.RectangleShape
    Friend WithEvents Label13 As Label
End Class

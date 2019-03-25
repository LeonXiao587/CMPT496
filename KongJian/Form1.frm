VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   7905
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   17565
   LinkTopic       =   "Form1"
   MDIChild        =   -1  'True
   Picture         =   "Form1.frx":0000
   ScaleHeight     =   7905
   ScaleWidth      =   17565
   Begin VB.PictureBox Picture1 
      Height          =   2115
      Left            =   5565
      Picture         =   "Form1.frx":7992
      ScaleHeight     =   2055
      ScaleWidth      =   5940
      TabIndex        =   11
      TabStop         =   0   'False
      Top             =   5985
      Width           =   6000
      Begin 工程1.xCheckBox xCheckBox1 
         Height          =   435
         Left            =   315
         TabIndex        =   12
         Top             =   105
         Width           =   645
         _extentx        =   1138
         _extenty        =   767
      End
   End
   Begin 工程1.xCheckBox xCheckBox4 
      Height          =   750
      Left            =   12390
      TabIndex        =   8
      Top             =   4410
      Width           =   750
      _extentx        =   1323
      _extenty        =   1323
      style           =   0
   End
   Begin 工程1.xCheckBox xCheckBox2 
      Height          =   750
      Left            =   14280
      TabIndex        =   7
      Top             =   4620
      Width           =   960
      _extentx        =   1693
      _extenty        =   1323
      shape           =   5
      style           =   3
   End
   Begin 工程1.xFrame x1 
      Height          =   3060
      Left            =   10395
      TabIndex        =   6
      Top             =   210
      Width           =   6840
      _extentx        =   12065
      _extenty        =   5398
      font            =   "Form1.frx":505E56
      transparent     =   -1  'True
      Begin 工程1.xCheckBox xCheckBox7 
         Height          =   645
         Left            =   4515
         TabIndex        =   10
         Top             =   1575
         Width           =   540
         _extentx        =   953
         _extenty        =   1138
      End
      Begin 工程1.xCheckBox xCheckBox5 
         Height          =   1800
         Left            =   1365
         TabIndex        =   9
         Top             =   840
         Width           =   2220
         _extentx        =   3916
         _extenty        =   3175
      End
   End
   Begin 工程1.safetabs xtabs1 
      Height          =   5415
      Left            =   240
      TabIndex        =   3
      Top             =   360
      Width           =   5895
      _extentx        =   10398
      _extenty        =   9551
      activetab       =   1
      backcolor       =   15790320
      caption0        =   "新标签1"
      caption1        =   "新标签2"
      caption2        =   "新标签3"
      Begin 工程1.xSideMenu xSideMenu2 
         Height          =   2160
         Left            =   1320
         TabIndex        =   5
         Top             =   960
         Width           =   2775
         _extentx        =   4895
         _extenty        =   3810
         enabled         =   -1  'True
         skin            =   1
         itemcount       =   7
         font            =   "Form1.frx":505E7A
         caption0        =   "菜单项1"
         enabled0        =   -1  'True
         caption1        =   "菜单项2"
         enabled1        =   -1  'True
         caption2        =   "菜单项3"
         enabled2        =   -1  'True
         caption3        =   "菜单项4"
         enabled3        =   -1  'True
         caption4        =   "菜单项5"
         enabled4        =   -1  'True
         caption5        =   "菜单项6"
         enabled5        =   -1  'True
         caption6        =   "菜单项7"
         enabled6        =   -1  'True
      End
      Begin 工程1.xSideMenu xSideMenu1 
         Height          =   2160
         Left            =   720
         TabIndex        =   4
         TabStop         =   0   'False
         Top             =   11320
         WhatsThisHelpID =   999
         Width           =   2895
         _extentx        =   5106
         _extenty        =   3810
         enabled         =   -1  'True
         skin            =   1
         itemcount       =   7
         font            =   "Form1.frx":505E9E
         caption0        =   "菜单项1"
         enabled0        =   -1  'True
         caption1        =   "菜单项2"
         enabled1        =   -1  'True
         caption2        =   "菜单项3"
         enabled2        =   -1  'True
         caption3        =   "菜单项4"
         enabled3        =   -1  'True
         caption4        =   "菜单项5"
         enabled4        =   -1  'True
         caption5        =   "菜单项6"
         enabled5        =   -1  'True
         caption6        =   "菜单项7"
         enabled6        =   -1  'True
      End
   End
   Begin 工程1.xButton xButton3 
      Height          =   735
      Left            =   10320
      TabIndex        =   2
      Top             =   3480
      Width           =   1215
      _extentx        =   2143
      _extenty        =   1296
      caption         =   "xButton3"
      enabled         =   -1  'True
      backcolor       =   -2147483633
      forecolor       =   0
      focusrect       =   -1  'True
      skin            =   0
      font            =   "Form1.frx":505EC2
      float           =   0   'False
      backcolor       =   -2147483633
      useico          =   -1  'True
      icowidth        =   32
      icoheight       =   32
      ico0            =   "Form1.frx":505EE6
      ico1            =   "Form1.frx":506D3A
      ico2            =   "Form1.frx":507B8E
      ico3            =   "Form1.frx":5089E2
      m_check         =   0   'False
      m_value         =   0   'False
   End
   Begin 工程1.xButton xButton2 
      Height          =   735
      Left            =   10080
      TabIndex        =   1
      Top             =   4920
      Width           =   1215
      _extentx        =   2143
      _extenty        =   1296
      caption         =   "xButton2"
      enabled         =   -1  'True
      backcolor       =   -2147483633
      forecolor       =   0
      focusrect       =   -1  'True
      skin            =   0
      font            =   "Form1.frx":5089FE
      float           =   0   'False
      backcolor       =   -2147483633
      useico          =   0   'False
      icowidth        =   0
      icoheight       =   0
      ico0            =   "Form1.frx":508A22
      ico1            =   "Form1.frx":508A3E
      ico2            =   "Form1.frx":508A5A
      ico3            =   "Form1.frx":508A76
      m_check         =   0   'False
      m_value         =   0   'False
   End
   Begin 工程1.xPropertySheet xPropertySheet1 
      Height          =   5655
      Left            =   6480
      TabIndex        =   0
      Top             =   120
      Width           =   3495
      _extentx        =   6165
      _extenty        =   9975
      nameheight      =   16
      namewidth       =   90
      sheetheadcolor  =   14469255
      tablecolor      =   16744576
      tablebackcolor1 =   16775148
      tablebackcolor2 =   12648447
      txtcolor        =   0
      txthotcolor     =   16711680
      highlightcolor  =   33023
      descriptionvisible=   -1  'True
      descriptionheight=   50
      autorefresh     =   -1  'True
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
    With xPropertySheet1
        .自动刷新 = False '同时设置属性较多可关闭自动刷新，设置完内容再允许自动刷新，以避免闪烁
        .Clear
        .AddSheet "xTab控件属性"                                        '必须先添加表头再添加项目内容
        .AddItem "activeTab", iList, "", True, "TAB控件当前页"          '参数是名称，类型，初值，是否可编辑，说明。
        .AddListText 1, 1, "第1页"
        .AddListText 1, 1, "第2页"
        .AddListText 1, 1, "第3页"
        .AddListText 1, 1, "第4页"
        .setListIndex 1, 1, 0
        
        .AddItem "caption", iString, xtabs1.Caption, True, "当前选项卡标题"     'additem默认添加到最新添加的表头下
        .AddItem "enabled", iBoolean, CStr(xtabs1.Enabled), True, "激活"
        .AddItem "height", iSingle, CStr(xtabs1.Height), True, "TAB控件高度。"
        .AddItem "width", iSingle, CStr(xtabs1.Width), True, "tab控件宽度。"
        .AddItem "tabCount", iInteger, CStr(xtabs1.TabCount), True, "选项卡页数"
        .setNumberRange 1, 6, 5, 1                                      '设置允许输入数值的范围
        
        .AddItem "skin", iList, "", True, "TAB控件皮肤"
        .AddListText 1, 7, "皮肤1"
        .AddListText 1, 7, "皮肤2"
        .AddListText 1, 7, "皮肤3"
        .AddListText 1, 7, "皮肤4"
        .AddListText 1, 7, "皮肤5"
        .AddListText 1, 7, "皮肤6"
        .AddListText 1, 7, "皮肤7"
        .setListIndex 1, 7, xtabs1.skinIndex
        
        .AddItem "labelActHeight", iInteger, CStr(xtabs1.LabelActHeight), True, "激活标签的高度"
        .AddItem "labelHeight", iInteger, CStr(xtabs1.LabelHeight), True, "未激活标签的高度"
        .AddItem "labelBlank", iInteger, CStr(xtabs1.LabelBlank), True, "标签间隔"
        .AddItem "labelWidth", iInteger, CStr(xtabs1.labelWidth), True, "标签宽度"
        .setNumberRange 1, 8, 50, 1
        .setNumberRange 1, 9, 50, 1
        .setNumberRange 1, 10, 50, 1
        .setNumberRange 1, 11, 50, 1
        .AddSheet "属性表控件属性"
        .AddItem "表格行高", iInteger, CStr(.表格行高)
        .AddItem "名称列宽", iInteger, CStr(.名称列宽)
        .AddItem "显示描述", iBoolean, CStr(.显示描述), False, "是否显示最下边的说明。尽量不要在属性表事件中修改属性表属性，事件代码未执行完毕时改变设置会引发BUG。"
        .AddItem "表头底色", iLong, CStr(.表头底色), True, "这里不能选择颜色，只能输入。"
        .AddItem "表格底色", iLong, CStr(.表格底色), True
        .AddItem "表格颜色", iLong, CStr(.表格颜色), True, "表格线颜色。"
        .AddItem "激活表格底色", iLong, CStr(.当前表格底色), True, "高亮颜色。"
        
        .自动刷新 = True
    End With
End Sub



Private Sub xButton2_Click()

End Sub

Private Sub xPropertySheet1_Change(sheet As Integer, item As Integer, newValue As String)
    Dim i As Integer
    With xPropertySheet1
        If sheet = 1 Then
            Select Case item
                Case 1
                    xtabs1.activeTab = .getListIndex(1, 1)      '取值时必须对应属性
                Case 2
                    xtabs1.Caption = .getValue(1, 2)
                Case 3
                    xtabs1.Enabled = .getBooleanValue(1, 3)
                Case 4
                    xtabs1.Height = .getSingleValue(1, 4)
                Case 5
                    xtabs1.Width = .getSingleValue(1, 5)
                Case 6
                    xtabs1.TabCount = .getIntegerValue(1, 6)
                    .clearListText 1, 1
                    For i = 1 To xtabs1.TabCount
                        .AddListText 1, 1, "第" & CStr(i) & "页"
                    Next
                Case 7
                    xtabs1.skinIndex = .getListIndex(1, 7)
                Case 8
                    xtabs1.LabelActHeight = .getIntegerValue(1, 8)
                Case 9
                    xtabs1.LabelHeight = .getIntegerValue(1, 9)
                Case 10
                    xtabs1.LabelBlank = .getIntegerValue(1, 10)
                Case 11
                    xtabs1.labelWidth = .getIntegerValue(1, 11)
            End Select
        Else
            Select Case item
                Case 1
                    .表格行高 = .getIntegerValue(2, 1)
                Case 2
                    .名称列宽 = .getIntegerValue(2, 2)
                Case 3
                    .显示描述 = .getBooleanValue(2, 3)
                Case 4
                    .表头底色 = .getLongValue(2, 4)
                Case 5
                    .表格底色 = .getLongValue(2, 5)
                Case 6
                    .表格颜色 = .getLongValue(2, 6)
                Case 7
                    .当前表格底色 = .getLongValue(2, 7)
            End Select
        End If
    End With
End Sub

Private Sub xSideMenu1_Click(itemIndex As Integer)
    xtabs1.skinIndex = itemIndex
    xPropertySheet1.setListIndex 1, 7, itemIndex
End Sub

Private Sub xSideMenu2_Click(itemIndex As Integer)
    xSideMenu2.menuSkin = itemIndex
End Sub

Private Sub xTabs1_TabSwitch(ByVal LastActiveTab As Integer)
    xPropertySheet1.setListIndex 1, 1, xtabs1.activeTab
    xPropertySheet1.setValue 1, 2, xtabs1.Caption
End Sub


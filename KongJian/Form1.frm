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
      Begin ����1.xCheckBox xCheckBox1 
         Height          =   435
         Left            =   315
         TabIndex        =   12
         Top             =   105
         Width           =   645
         _extentx        =   1138
         _extenty        =   767
      End
   End
   Begin ����1.xCheckBox xCheckBox4 
      Height          =   750
      Left            =   12390
      TabIndex        =   8
      Top             =   4410
      Width           =   750
      _extentx        =   1323
      _extenty        =   1323
      style           =   0
   End
   Begin ����1.xCheckBox xCheckBox2 
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
   Begin ����1.xFrame x1 
      Height          =   3060
      Left            =   10395
      TabIndex        =   6
      Top             =   210
      Width           =   6840
      _extentx        =   12065
      _extenty        =   5398
      font            =   "Form1.frx":505E56
      transparent     =   -1  'True
      Begin ����1.xCheckBox xCheckBox7 
         Height          =   645
         Left            =   4515
         TabIndex        =   10
         Top             =   1575
         Width           =   540
         _extentx        =   953
         _extenty        =   1138
      End
      Begin ����1.xCheckBox xCheckBox5 
         Height          =   1800
         Left            =   1365
         TabIndex        =   9
         Top             =   840
         Width           =   2220
         _extentx        =   3916
         _extenty        =   3175
      End
   End
   Begin ����1.safetabs xtabs1 
      Height          =   5415
      Left            =   240
      TabIndex        =   3
      Top             =   360
      Width           =   5895
      _extentx        =   10398
      _extenty        =   9551
      activetab       =   1
      backcolor       =   15790320
      caption0        =   "�±�ǩ1"
      caption1        =   "�±�ǩ2"
      caption2        =   "�±�ǩ3"
      Begin ����1.xSideMenu xSideMenu2 
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
         caption0        =   "�˵���1"
         enabled0        =   -1  'True
         caption1        =   "�˵���2"
         enabled1        =   -1  'True
         caption2        =   "�˵���3"
         enabled2        =   -1  'True
         caption3        =   "�˵���4"
         enabled3        =   -1  'True
         caption4        =   "�˵���5"
         enabled4        =   -1  'True
         caption5        =   "�˵���6"
         enabled5        =   -1  'True
         caption6        =   "�˵���7"
         enabled6        =   -1  'True
      End
      Begin ����1.xSideMenu xSideMenu1 
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
         caption0        =   "�˵���1"
         enabled0        =   -1  'True
         caption1        =   "�˵���2"
         enabled1        =   -1  'True
         caption2        =   "�˵���3"
         enabled2        =   -1  'True
         caption3        =   "�˵���4"
         enabled3        =   -1  'True
         caption4        =   "�˵���5"
         enabled4        =   -1  'True
         caption5        =   "�˵���6"
         enabled5        =   -1  'True
         caption6        =   "�˵���7"
         enabled6        =   -1  'True
      End
   End
   Begin ����1.xButton xButton3 
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
   Begin ����1.xButton xButton2 
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
   Begin ����1.xPropertySheet xPropertySheet1 
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
        .�Զ�ˢ�� = False 'ͬʱ�������Խ϶�ɹر��Զ�ˢ�£������������������Զ�ˢ�£��Ա�����˸
        .Clear
        .AddSheet "xTab�ؼ�����"                                        '��������ӱ�ͷ�������Ŀ����
        .AddItem "activeTab", iList, "", True, "TAB�ؼ���ǰҳ"          '���������ƣ����ͣ���ֵ���Ƿ�ɱ༭��˵����
        .AddListText 1, 1, "��1ҳ"
        .AddListText 1, 1, "��2ҳ"
        .AddListText 1, 1, "��3ҳ"
        .AddListText 1, 1, "��4ҳ"
        .setListIndex 1, 1, 0
        
        .AddItem "caption", iString, xtabs1.Caption, True, "��ǰѡ�����"     'additemĬ����ӵ�������ӵı�ͷ��
        .AddItem "enabled", iBoolean, CStr(xtabs1.Enabled), True, "����"
        .AddItem "height", iSingle, CStr(xtabs1.Height), True, "TAB�ؼ��߶ȡ�"
        .AddItem "width", iSingle, CStr(xtabs1.Width), True, "tab�ؼ���ȡ�"
        .AddItem "tabCount", iInteger, CStr(xtabs1.TabCount), True, "ѡ�ҳ��"
        .setNumberRange 1, 6, 5, 1                                      '��������������ֵ�ķ�Χ
        
        .AddItem "skin", iList, "", True, "TAB�ؼ�Ƥ��"
        .AddListText 1, 7, "Ƥ��1"
        .AddListText 1, 7, "Ƥ��2"
        .AddListText 1, 7, "Ƥ��3"
        .AddListText 1, 7, "Ƥ��4"
        .AddListText 1, 7, "Ƥ��5"
        .AddListText 1, 7, "Ƥ��6"
        .AddListText 1, 7, "Ƥ��7"
        .setListIndex 1, 7, xtabs1.skinIndex
        
        .AddItem "labelActHeight", iInteger, CStr(xtabs1.LabelActHeight), True, "�����ǩ�ĸ߶�"
        .AddItem "labelHeight", iInteger, CStr(xtabs1.LabelHeight), True, "δ�����ǩ�ĸ߶�"
        .AddItem "labelBlank", iInteger, CStr(xtabs1.LabelBlank), True, "��ǩ���"
        .AddItem "labelWidth", iInteger, CStr(xtabs1.labelWidth), True, "��ǩ���"
        .setNumberRange 1, 8, 50, 1
        .setNumberRange 1, 9, 50, 1
        .setNumberRange 1, 10, 50, 1
        .setNumberRange 1, 11, 50, 1
        .AddSheet "���Ա�ؼ�����"
        .AddItem "����и�", iInteger, CStr(.����и�)
        .AddItem "�����п�", iInteger, CStr(.�����п�)
        .AddItem "��ʾ����", iBoolean, CStr(.��ʾ����), False, "�Ƿ���ʾ���±ߵ�˵����������Ҫ�����Ա��¼����޸����Ա����ԣ��¼�����δִ�����ʱ�ı����û�����BUG��"
        .AddItem "��ͷ��ɫ", iLong, CStr(.��ͷ��ɫ), True, "���ﲻ��ѡ����ɫ��ֻ�����롣"
        .AddItem "����ɫ", iLong, CStr(.����ɫ), True
        .AddItem "�����ɫ", iLong, CStr(.�����ɫ), True, "�������ɫ��"
        .AddItem "�������ɫ", iLong, CStr(.��ǰ����ɫ), True, "������ɫ��"
        
        .�Զ�ˢ�� = True
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
                    xtabs1.activeTab = .getListIndex(1, 1)      'ȡֵʱ�����Ӧ����
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
                        .AddListText 1, 1, "��" & CStr(i) & "ҳ"
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
                    .����и� = .getIntegerValue(2, 1)
                Case 2
                    .�����п� = .getIntegerValue(2, 2)
                Case 3
                    .��ʾ���� = .getBooleanValue(2, 3)
                Case 4
                    .��ͷ��ɫ = .getLongValue(2, 4)
                Case 5
                    .����ɫ = .getLongValue(2, 5)
                Case 6
                    .�����ɫ = .getLongValue(2, 6)
                Case 7
                    .��ǰ����ɫ = .getLongValue(2, 7)
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


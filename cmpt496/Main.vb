Public Class Main
    Public SQL As New Sqlcon
    'Private statusstrip1 As Object
    'Private toolstripstatuslabel1 As Object

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Renting.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Signup.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Billing_lease.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Management.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Show webpage
        Process.Start("http://www.google.ca")
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Button1.FlatStyle = FlatStyle.Flat
        'Button1.FlatAppearance.BorderColor = BackColor
        'Button1.FlatAppearance.MouseOverBackColor = BackColor
        'Button1.FlatAppearance.MouseDownBackColor = BackColor
        'statusstrip1.ShowItemToolTips = True

        'toolstripstatuslabel1.ToolTipText = "This will display when you hover the mouse over it"
    End Sub

    'Private Sub Text1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    '    Me.Picture1.Left = Me.Text1.Left + 100 + X
    '    Me.Picture1.Top = Me.Text1.Top + 100 + Y
    '    Me.Picture1.Visible = True
    'End Sub

    'Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    '    Label2.Caption = "label2"
    'End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Renting.Show()
        LeaseForm.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If SQL.HasConnection = True Then
            login.Show()
            login.username.Clear()
            login.password.Clear()
            Me.Close()
            login.Show()
        End If
    End Sub

End Class

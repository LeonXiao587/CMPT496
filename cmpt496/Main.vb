Public Class Main
    Public SQL As New Sqlcon
    'Private statusstrip1 As Object
    'Private toolstripstatuslabel1 As Object

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If SQL.HasConnection = True Then
            login.Show()
            login.username.Clear()
            login.password.Clear()
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    Private Sub Label2_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)



    End Sub
End Class

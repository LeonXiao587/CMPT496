﻿Public Class Main
    Public SQL As New Sqlcon
    'Private statusstrip1 As Object
    'Private toolstripstatuslabel1 As Object


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Signup.Show()
        PictureBox1 = Nothing
        PictureBox2 = Nothing
        PictureBox3 = Nothing
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If SQL.HasConnection = True Then
            login.Show()
            login.username.Clear()
            login.password.Clear()
            Me.Close()
            login.Show()
        End If
    End Sub

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click
        Me.Hide()
        Renting.Show()
        PictureBox1 = Nothing
        PictureBox3 = Nothing
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Renting.Show()
        PictureBox1 = Nothing
        PictureBox3 = Nothing
    End Sub

    Private Sub Managerect_Click(sender As Object, e As EventArgs) Handles Managerect.Click
        Me.Hide()
        ManagementOption.Show()
        PictureBox1 = Nothing
        PictureBox3 = Nothing
    End Sub
    Private Sub ManageLabel5_Click(sender As Object, e As EventArgs) Handles ManageLabel5.Click
        Me.Hide()
        ManagementOption.Show()
        PictureBox1 = Nothing
        PictureBox3 = Nothing
    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click
        Me.Hide()
        Billing_lease.Show()
        PictureBox1 = Nothing
        PictureBox3 = Nothing
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Billing_lease.Show()
        PictureBox1 = Nothing
        PictureBox3 = Nothing
    End Sub

    Private Sub RectangleShape3_Click(sender As Object, e As EventArgs) Handles RectangleShape3.Click
        Me.Hide()
        Signup.Show()
        PictureBox1 = Nothing
        PictureBox3 = Nothing
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        Signup.Show()
        PictureBox1 = Nothing
        PictureBox3 = Nothing
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Hide()
        Announcement.Show()
        PictureBox1 = Nothing
        PictureBox3 = Nothing
    End Sub

    Private Sub RectangleShape4_Click(sender As Object, e As EventArgs) Handles RectangleShape4.Click
        Me.Hide()
        Announcement.Show()
        PictureBox1 = Nothing
        PictureBox3 = Nothing
    End Sub
End Class

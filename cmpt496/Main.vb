Public Class Main
    Public SQL As New Sqlcon
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If SQL.HasConnection = True Then
            login.Show()
            login.username.Clear()
            login.password.Clear()
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Renting.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Signup.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Billing_lease.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Management.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Show webpage
        Process.Start("http://www.google.ca")
    End Sub
End Class

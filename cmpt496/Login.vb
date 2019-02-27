Public Class login
    Public SQL As New Sqlcon
    Public idshow As String
    Public empname As String

    Private Function MLog() As Boolean
        If SQL.DBDS IsNot Nothing Then
            SQL.DBDS.Clear()
        End If
        If Len(username.Text) <> 0! Or Len(password.Text) <> 0! Then
            SQL.ExecQuery("SELECT Count(Username) As userCount FROM Management WHERE Username COLLATE Latin1_General_CS_AS='" & username.Text &
            "' AND SigninPassword COLLATE Latin1_General_CS_AS ='" & password.Text & "'")
            If SQL.DBDS.Tables(0).Rows(0).Item("userCount") = 1 Then
                '
                Return True
            End If
            MsgBox("Invalid id or password", MsgBoxStyle.Critical, "Failed!")
            Return False
        End If
        MsgBox("you entered nothing")
        Return False
    End Function

    Private Sub MLOGIN_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SQL.HasConnection = True Then
            If MLog() = True Then
                SQL.ExecQuery("SELECT * FROM Management WHERE Username='" & username.Text & "'")
                empname = SQL.DBDS.Tables(0).Rows(0)("Lname").ToString
                MsgBox("Login as successful!")
                Main.Show()
                Me.Hide()
                idshow = username.Text
                Main.Label2.Text = "Manager:" & empname
            End If
        End If
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Button2.Click
        username.Clear()
        password.Clear()
    End Sub

    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub
End Class
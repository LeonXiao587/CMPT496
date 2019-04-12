Public Class Signup

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If first_name.Text = "" Or last_name.Text = "" Or email.Text = "" Then
            MsgBox("Some fields missing!")
        Else
            If password.Text = password1.Text Then
                login.SQL.ExecQuery("INSERT INTO Management(Fname, Lname, Email, SigninPassword, BID, Title, Username)
                             VALUES (" & first_name.Text & "','" & last_name.Text & "','" & email.Text & "','" & password.Text & "','" & BID.Text & "','" & title.Text & "','" & username.Text & "')"
                    )
            End If
        End If
        'login.SQL.ExecQuery("INSERT INTO Management(StaffID, Fname, Lname, Email, SigninPassword, BID, Title, Username)
        'VALUES ('" & staffid.Text & "','" & first_name.Text & "','" & last_name.Text & "','" & email.Text & "','" & password.Text & "','" & BID.Text & "','" & title.Text & "','" & username.Text & "')"
        '                )
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        first_name.Clear()
        last_name.Clear()
        BID.Clear()
        email.Clear()
        password.Clear()
        password1.Clear()
        title.Clear()
        username.Clear()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
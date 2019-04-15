Imports System.Text.RegularExpressions

Public Class Signup
    Dim C_REGULAR_Letters As New Regex("^[A-Za-z]+$")

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If C_REGULAR_Letters.IsMatch(first_name.Text） = False Or C_REGULAR_Letters.IsMatch(title.Text） = False Or C_REGULAR_Letters.IsMatch(username.Text） = False Or C_REGULAR_Letters.IsMatch(last_name.Text） = False Then
            MsgBox("Invaild Input!")
            Exit Sub
        End If

        If email.Text Like "*@*.com" Or email.Text Like "*@*.net" Or email.Text Like "*@*.ca" Then
        Else
            MsgBox("Input Vaild Email Address")

            Exit Sub
        End If

        If first_name.Text = "" Or last_name.Text = "" Or email.Text = "" Then
            MsgBox("Some fields missing!")
        Else
            If password.Text = password1.Text Then
                login.SQL.ExecQuery("INSERT INTO Management(Fname, Lname, Email, SigninPassword, BID, Title, Username)
                             VALUES ('" & first_name.Text & "','" & last_name.Text & "','" & email.Text & "','" & password.Text & "', " & Main.Building.Text.ToString & " ,'" & title.Text & "','" & username.Text & "')"
                    )
                MsgBox("Done")
            Else
                MsgBox("Please input same password.")
            End If
        End If
        'login.SQL.ExecQuery("INSERT INTO Management(StaffID, Fname, Lname, Email, SigninPassword, BID, Title, Username)
        'VALUES ('" & staffid.Text & "','" & first_name.Text & "','" & last_name.Text & "','" & email.Text & "','" & password.Text & "','" & BID.Text & "','" & title.Text & "','" & username.Text & "')"
        '                )
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        first_name.Clear()
        last_name.Clear()
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
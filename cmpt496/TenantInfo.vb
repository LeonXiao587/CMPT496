Imports System.Text.RegularExpressions

Public Class TenantInfo

    Dim C_REGULAR_Letters As New Regex("^[A-Za-z]+$")

    Private Sub ContractForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TT As ToolTip
        TT = New ToolTip With {
            .InitialDelay = 0, 'tip time
            .AutoPopDelay = 5000, '显示出气泡后的延时时间（毫秒）
            .ToolTipTitle = "Tips" 'tipstitle
            }
        TT.SetToolTip(incomeLabel, "Annual Income ")
        unitlable.Text = Renting.ListBox1.SelectedItem(0).ToString
    End Sub


    'check data type and submit to database
    Private Sub SubmitTenant()

        'check for name validation

        If first_name.Text = "" Or last_name.Text = "" Or phone.Text = "" Or email.Text = "" Or id.Text = "" Or incomeBox1.Text = "" Then
            MsgBox("Input All * Information Fields Please!")
        Else
            Dim uname As String
            uname = last_name.Text + unitlable.Text
            Dim pwd As String
            pwd = first_name.Text + unitlable.Text

            If C_REGULAR_Letters.IsMatch(first_name.Text） = False Or C_REGULAR_Letters.IsMatch(last_name.Text） = False Then
                MsgBox("Input vaild name")
                Exit Sub
            End If

            If email.Text Like "*@*.com" Or email.Text Like "*@*.net" Or email.Text Like "*@*.ca" Then
            Else
                MsgBox("Input Vaild Email Address")
                Exit Sub
            End If

            If Len(phone.Text) = 10 Then
            Else
                MsgBox("Input Vaild Phone Number")
                Exit Sub

            End If

            If Len(id.Text) = 9 Then
            Else
                MsgBox("Input Vaild ID Number")
                Exit Sub

            End If

            'Check 3 fields for numbers input
            If IsNumeric(phone.Text) And IsNumeric(id.Text) And IsNumeric(incomeBox1.Text) Then
                login.SQL.ExecQuery("select * from tenant where username = '" + uname + "'")
                If login.SQL.DBDS.Tables(0).Rows.Count = 0 Then
                Else
                    'if the username already exist, add last 4 number of the phonenumber to the username

                    uname = uname + Microsoft.VisualBasic.Right(phone.Text.ToString, 4)
                End If
                login.SQL.ExecQuery("insert into Tenant (Phone,First_name,Last_name,Email, username, password, Credits,ID,PAddress,Income,Occupation,Company) Values ('" + phone.Text.ToString + "','" + first_name.Text + "','" + last_name.Text + "','" + email.Text + "','" + uname + "','" + pwd + "',0," + id.Text.ToString + ",'" + addressbox.Text.ToString + "'," + incomeBox1.Text.ToString + ",'" + occupationBox3.Text.ToString + "','" + companyBox5.Text.ToString + "')")
                MsgBox("Please Inform Customer:" + vbCrLf + "Username: " & uname + vbCrLf + "Password: " + pwd)
                LeaseForm.Show()
                Me.Hide()
            Else
                MsgBox("Please Input Number for ID, Phone Number, and Income!")
            End If
        End If


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Renting.Show()
    End Sub

    Private Sub CmdClose_Click()
        Me.Close()
        Main.Show()
    End Sub


    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click
        SubmitTenant()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        SubmitTenant()

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Cosigner.Show()
    End Sub
End Class
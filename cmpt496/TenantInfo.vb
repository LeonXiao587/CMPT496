Public Class TenantInfo
    Private Sub ContractForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TT As ToolTip
        TT = New ToolTip With {
            .InitialDelay = 0, '出现前的延时（毫秒）
            .AutoPopDelay = 5000, '显示出气泡后的延时时间（毫秒）
            .ToolTipTitle = "提示" '提示信息标题
            }
        TT.SetToolTip(incomeLabel, "Annual Income ")
        unitlable.Text = Renting.ListBox1.SelectedItem(0).ToString
    End Sub

    Private Sub SubmitTenant()
        If first_name.Text = "" Or last_name.Text = "" Or phone.Text = "" Or email.Text = "" Or id.Text = "" Then
            MsgBox("Input all fields please!")
        Else
            Dim uname As String
            uname = last_name.Text + unitlable.Text
            Dim pwd As String
            pwd = first_name.Text + unitlable.Text
            If IsNumeric(phone.Text) Or IsNumeric(id.Text) Then

                login.SQL.ExecQuery("insert into Tenant (Phone,First_name,Last_name,Email, username, password, Credits,ID,PAddress,Income,Occupation,Company) Values ('" + phone.Text.ToString + "','" + first_name.Text + "','" + last_name.Text + "','" + email.Text + "','" + uname + "','" + pwd + "',0," + id.Text.ToString + ",'" + addressbox.Text.ToString + "'," + incomeBox1.Text.ToString + ",'" + occupationBox3.Text.ToString + "','" + companyBox5.Text.ToString + "')")
            Else
                MsgBox("Please input Numbers for ID and Phone Number and Income!")
            End If
            MsgBox("Your Username: " & uname + vbCrLf + "Password: " + pwd)
                LeaseForm.Show()
                Me.Hide()
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

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click
        Me.Hide()
        SubmitTenant()
        PictureBox1 = Nothing
        PictureBox2 = Nothing

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        SubmitTenant()
        PictureBox1 = Nothing
        PictureBox2 = Nothing

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Cosigner.Show()
    End Sub
End Class
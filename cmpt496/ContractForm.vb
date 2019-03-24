Public Class ContractForm
    Private Sub ContractForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TT As ToolTip
        TT = New ToolTip()
        TT.InitialDelay = 0 '出现前的延时（毫秒）
        TT.AutoPopDelay = 5000 '显示出气泡后的延时时间（毫秒）
        TT.ToolTipTitle = "提示" '提示信息标题
        TT.SetToolTip(incomeLabel, "Annual Income ")
        unitlable.Text = Renting.ListBox1.SelectedItem(0).ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If first_name.Text = "" Or last_name.Text = "" Or phone.Text = "" Or email.Text = "" Or id.Text = "" Then
            MsgBox("Input all fields please!")
        Else
            Dim uname As String
            uname = last_name.Text + unitlable.Text
            Dim pwd As String
            pwd = first_name.Text + unitlable.Text
            login.SQL.ExecQuery("insert into Tenant (Phone,First_name,Last_name,Email, username, password, leaseNumber, Credits,ID) Values (" + phone.Text + ",'" + first_name.Text + "','" + last_name.Text + "','" + email.Text + "','" + uname + "','" + pwd + "',NULL,0," + id.Text + ")")
            LeaseForm.Show()
            Me.Hide()
        End If


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Renting.Show()
    End Sub

    Private Sub cmdClose_Click()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
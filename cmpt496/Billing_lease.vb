Imports System.Data.SqlClient

Public Class Billing_lease
    'Public SQL As New Sqlcon


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadGrid()
    End Sub

    Private Sub LoadGrid()
        Dim idsearch As Integer
        idsearch = 0
        Dim searchstr As String
        searchstr = TextBox1.Text.ToString
        If (IsNumeric(TextBox1.Text)) Then
            idsearch = TextBox1.Text
        End If

        Dim t As String
        Dim cbox1 = ComboBox1
        Dim cbox2 = ComboBox2
        Dim cbox3 = ComboBox3


        t = Replace(DateTimePicker1.Value.Date.ToString("yyyy/MM/dd"), "/", "-")

        'ComboBox1
        ' stored proc will not compatible with the gridview data update and delete!!! May have to use simpler way
        login.SQL.ExecQuery("select * from Lease where LeaseID =" + idsearch.ToString + "," + searchstr)
        'login.SQL.ExecQuery("select * from Client where CLientID = " + idsearch.ToString + "or Name like '%" + searchstr + "%' or Pemail like '%" + searchstr + "%'")
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)

        DateTimePicker1.Refresh()
        TextBox1.Clear()
        ComboBox1.Refresh()
        ComboBox2.Refresh()
        ComboBox3.Refresh()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Dim intResult As Integer
        'intResult = MessageBox.Show("You sure you want to make these changes", "Waring", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        'If intResult = DialogResult.OK Then
        'Dim scb As SqlCommandBuilder = New SqlCommandBuilder(login.SQL.DBDA)
        'login.SQL.DBDA.Update(login.SQL.DBDS)
        'MsgBox("Changes updated!")
        'End If
        Me.Close()
        Email.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Payment.Show()
    End Sub


    Private Sub Billing_lease_Load(sender As Object, e As EventArgs)
        'Dim connection As New SqlConnection("Server=tcp:apamanagement.database.windows.net,1433;Initial Catalog=496;Persist Security Info=False;User ID=leonxiao;Password=CMPT496a;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

        'Dim command As New SqlCommand("select * from Lease", connection)

        'Dim adapter As New SqlDataAdapter(command)

        'Dim table As New DataTable()

        'adapter.Fill(table)

        'ComboBox1.DataSource = table

        'ComboBox1.DisplayMember = "LeaseID"
        'ComboBox1.ValueMember = "Id"

    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        Me.Close()
        Main.Show()
    End Sub
End Class
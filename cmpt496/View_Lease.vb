Imports System.Data.SqlClient

Public Class View_Lease
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Billing_lease.Show()
    End Sub

    Private Sub View_Lease_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        login.SQL.ExecQuery("select * from Lease ")
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
        DataGridView1.MultiSelect = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub LoadGrid()
        Dim idsearch As Integer
        idsearch = 0
        Dim searchstr As String
        searchstr = TextBox1.Text.ToString
        If (IsNumeric(TextBox1.Text)) Then
            idsearch = TextBox1.Text
        End If


        'login.SQL.ExecQuery("select * from Client where CLientID = " + idsearch.ToString + "or Name like '%" + searchstr + "%' or Pemail like '%" + searchstr + "%'")
        login.SQL.ExecQuery("select * from Lease where LeaseID = " + idsearch.ToString + "or DoorNumber =" + idsearch.ToString + "or TID =" + idsearch.ToString + "or BID =" + idsearch.ToString)
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadGrid()
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim intResult As Integer
        intResult = MessageBox.Show("You sure you want to make these changes", "Waring", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If intResult = DialogResult.OK Then
            Dim scb As SqlCommandBuilder = New SqlCommandBuilder(login.SQL.DBDA)
            login.SQL.DBDA.Update(login.SQL.DBDS)
            MsgBox("Changes updated!")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim intResult As Integer
        intResult = MessageBox.Show("Are you sure to remove this lease", "Waring", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If intResult = DialogResult.OK Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
            Dim scb As SqlCommandBuilder = New SqlCommandBuilder(login.SQL.DBDA)
            login.SQL.DBDA.Update(login.SQL.DBDS)
            MsgBox("Removed!")
        End If
    End Sub
End Class
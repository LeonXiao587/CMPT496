Imports System.Data.SqlClient

Public Class Management
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.SQL.ExecQuery("select * from Management")
        For i = 0 To login.SQL.DBDS.Tables(0).Rows.Count - 1
            ComboBox1.Items.Add(login.SQL.DBDS.Tables(0).Rows(i)(0).ToString)
        Next
        'login.SQL.ExecQuery("select * from Lease")
        For i = 0 To login.SQL.DBDS.Tables(0).Rows.Count - 1
            ComboBox2.Items.Add(login.SQL.DBDS.Tables(0).Rows(i)(5).ToString)
        Next
        For i = 0 To login.SQL.DBDS.Tables(0).Rows.Count - 1
            ComboBox3.Items.Add(login.SQL.DBDS.Tables(0).Rows(i)(1).ToString + login.SQL.DBDS.Tables(0).Rows(i)(2).ToString)
        Next
    End Sub

    Private Sub Show_Click(sender As Object, e As EventArgs) Handles View.Click
        ComboBox1.Refresh()
        ComboBox2.Refresh()
        ComboBox3.Refresh()
        LoadGrid()
    End Sub

    Private Sub LoadGrid()
        login.SQL.ExecQuery("select * from Management")

        'login.SQL.ExecQuery("select * from Client where CLientID = " + idsearch.ToString + "or Name like '%" + searchstr + "%' or Pemail like '%" + searchstr + "%'")
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
        'Throw New NotImplementedException()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intResult As Integer
        intResult = MessageBox.Show("Are you sure you want to make these changes", "Waring", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If intResult = DialogResult.OK Then
            Dim scb As SqlCommandBuilder = New SqlCommandBuilder(login.SQL.DBDA)
            login.SQL.DBDA.Update(login.SQL.DBDS)
            MsgBox("Changes updated!")


        Else
            MessageBox.Show("Please make a selection before removing")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim intResult As Integer
        intResult = MessageBox.Show("Delete this Client?", "Waring", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If intResult = DialogResult.OK Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
            Dim scb As SqlCommandBuilder = New SqlCommandBuilder(login.SQL.DBDA)
            login.SQL.DBDA.Update(login.SQL.DBDS)
            MsgBox("Deleted")

            If (DataGridView1.SelectedCells.Count > 0) Then
                intResult = MessageBox.Show("You sure you want to cancel this order", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                If intResult = DialogResult.OK Then
                    DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
                    Dim bbb As SqlCommandBuilder = New SqlCommandBuilder(login.SQL.DBDA)
                    login.SQL.DBDA.Update(login.SQL.DBDS)
                    MsgBox("Deleted")
                Else
                    MessageBox.Show("Please make a selection before removing")
                End If

            End If
        End If
    End Sub
End Class
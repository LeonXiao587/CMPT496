Imports System.Data.SqlClient

Public Class Billing_lease
    Private ReadOnly idsearch As Object

    Private Sub LoadGrid()
        Dim idsearch As Integer
        idsearch = 0
        Dim searchstr As String
        searchstr = TextBox1.Text.ToString
        If (IsNumeric(TextBox1.Text)) Then
            idsearch = TextBox1.Text
        End If

        'With Me.DataGridView1
        '    Dim cnt As Integer
        '    For cnt = 0 To .Rows.Count - 1
        '        If .Rows(cnt).Visible Then
        '            Dim i As Integer = cnt
        '            While .Rows(i).Cells("PartNumber").Value = .Rows(i + 1).Cells("PartNumber").Value
        '                .Rows(i + 1).Visible = False
        '                i = i + 1
        '            End While
        '        End If
        '    Next
        'End With

        Dim f As Integer
        Dim t As Integer

        f = CInt(Replace(StartDate.Value.Date.ToString("yyyy-MM-dd"), "-", ""))
        t = CInt(Replace(EndDate.Value.Date.ToString("yyyy-MM-dd"), "-", ""))


        'f = Format(StartDate.Value, "yyyy-MM-dd")
        't = Format(EndDate.Value, "yyyy-MM-dd")

        'login.SQL.ExecQuery("Select DISTINCT Lease.LeaseID, Lease.DoorNumber, 
        '                     Lease.BID, Lease.TID, Tenant.First_name, Tenant.Last_name,
        '                     Lease.Monthlyrate, Lease.Startdate, Lease.Enddate, Tenant.Email
        '                     From Lease,Tenant,Unit
        '                     Where Lease.TID=Tenant.TID AND Lease.BID=Unit.BID 
        '                     AND Lease.DoorNumber=Unit.DoorNumber or Lease.LeaseID = " + idsearch.ToString + "
        '                     or Lease.DoorNumber = " + idsearch.ToString + " or Lease.BID = " + idsearch.ToString + "
        '                     or Lease.TID = " + idsearch.ToString + " or Tenant.First_name like '%" + searchstr + "%' 
        '                     or Tenant.Last_name like '%" + searchstr + "%' or Lease.Monthlyrate = " + idsearch.ToString + "
        '                     and replace (Lease.Startdate, '-', '' ) >= " + t.ToString + " and replace (Lease.Enddate, '-', '' ) <=" + f.ToString + "
        '                     or Tenant.Email like '%" + searchstr + "%'")
        login.SQL.ExecQuery("Select DISTINCT LeaseID, DoorNumber, 
                             BID, TID, First_name, Last_name,
                             Monthlyrate, Startdate, Enddate, Email
                             From billing_view
                             Where LeaseID = " + idsearch.ToString + "
                             or DoorNumber = " + idsearch.ToString + " or BID = " + idsearch.ToString + "
                             or TID = " + idsearch.ToString + " or First_name like '%" + searchstr + "%' 
                             or Last_name like '%" + searchstr + "%' or Monthlyrate = " + idsearch.ToString + "
                             and replace(Startdate, '-', '' ) >= " + t.ToString + " and replace(Enddate, '-', '' ) <=" + f.ToString + "
                             or Email like '%" + searchstr + "%'")


        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        'Dim intResult As Integer
        'intResult = MessageBox.Show("You sure you want to make these changes", "Waring", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        'If intResult = DialogResult.OK Then
        'Dim scb As SqlCommandBuilder = New SqlCommandBuilder(login.SQL.DBDA)
        'login.SQL.DBDA.Update(login.SQL.DBDS)
        'MsgBox("Changes updated!")
        'End If
        'Me.Close()
        'Email.Show()
    End Sub


    Private Sub Billing_lease_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim connection As New SqlConnection("Server=tcp:apamanagement.database.windows.net,1433;Initial Catalog=496;Persist Security Info=False;User ID=leonxiao;Password=CMPT496a;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

        'Dim command As New SqlCommand("select * from Lease", connection)

        'Dim adapter As New SqlDataAdapter(command)

        'Dim table As New DataTable()

        'adapter.Fill(table)

        'ComboBox1.DataSource = table

        'ComboBox1.DisplayMember = "LeaseID"
        'ComboBox1.ValueMember = "Id"

        'login.SQL.ExecQuery("Select * FROM Lease")
        'For i = 0 To login.SQL.DBDS.Tables(0).Rows.Count - 1
        '    ComboBox1.Items.Add(login.SQL.DBDS.Tables(0).Rows(i)(0).ToString)
        'Next
        ''login.SQL.ExecQuery("select * from Lease")
        'For i = 0 To login.SQL.DBDS.Tables(0).Rows.Count - 1
        '    ComboBox2.Items.Add(login.SQL.DBDS.Tables(0).Rows(i)(1).ToString)
        'Next
        'For i = 0 To login.SQL.DBDS.Tables(0).Rows.Count - 1
        '    ComboBox3.Items.Add(login.SQL.DBDS.Tables(0).Rows(i)(7).ToString)
        'Next

        'login.SQL.ExecQuery("Select distinct Lease.LeaseID, Lease.DoorNumber, Lease.BID, Tenant.First_name, Tenant.Last_name,
        'Lease.Monthlyrate, Lease.Startdate, Lease.Enddate
        'From Lease,Tenant,Unit
        'where Lease.TID=Tenant.TID AND Lease.BID=Unit.BID AND Lease.DoorNumber=Unit.DoorNumber")
        'DataGridView1.DataSource = login.SQL.DBDS.Tables(0)

        DataGridView1.MultiSelect = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    '    Dim intResult As Integer
    '    intResult = MessageBox.Show("You sure you want to make these changes", "Waring", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
    '    If intResult = DialogResult.OK Then
    '        Dim scb As SqlCommandBuilder = New SqlCommandBuilder(login.SQL.DBDA)
    '        login.SQL.DBDA.Update(login.SQL.DBDS)
    '        MsgBox("Changes updated!")
    '    End If
    'End Sub

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click
        LoadGrid()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        LoadGrid()
    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click
        StartDate.Refresh()
        EndDate.Refresh()
        TextBox1.Clear()
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        StartDate.Refresh()
        EndDate.Refresh()
        TextBox1.Clear()
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
    End Sub

    Private Sub RectangleShape4_Click(sender As Object, e As EventArgs) Handles RectangleShape4.Click
        Me.Hide()
        Payment.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Payment.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        View_Lease.Show()
    End Sub

    Private Sub RectangleShape5_Click(sender As Object, e As EventArgs) Handles RectangleShape5.Click
        Me.Hide()
        View_Lease.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'DataGridView1.MultiSelect = False
        'DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    'Private rowIndex As Integer = 0
    'Private Sub DataGridView1_CellMouseUp_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseUp
    '    If e.Button = MouseButtons.Right Then
    '        Me.DataGridView1.Rows(e.RowIndex).Selected = True
    '        Me.rowIndex = e.RowIndex
    '        Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(e.RowIndex).Cells(1)
    '        Me.ContextMenuStrip1.Show(Me.DataGridView1, e.Location)
    '        ContextMenuStrip1.Show(Cursor.Position)
    '    End If
    'End Sub

    'Private Sub ContextMenuStrip1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextMenuStrip1.Click
    '    If Not Me.DataGridView1.Rows(Me.rowIndex).IsNewRow Then
    '        Me.DataGridView1.Rows.RemoveAt(Me.rowIndex)
    '    End If
    'End Sub
End Class
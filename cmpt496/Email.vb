Imports System.Data.SqlClient

Public Class Email
    Public NewMonthList As New List(Of Integer)

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        LoadGrid()
    End Sub

    Private Sub LoadGrid()

        Dim t As String

        't = Replace(DateTimePicker1.Value.Date.ToString("yyyy/MM/dd"), "/", "-")
        'Throw New NotImplementedException()
        t = CInt(Replace(DateTimePicker1.Value.Date.ToString("yyyy/MM/dd"), "/", ""))
        login.SQL.ExecQuery("Select * From Payment where replace (Paymentdate, '-', '' ) = " + t.ToString)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Billing_lease.Show()
    End Sub

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click
        LoadGrid()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        LoadGrid()
    End Sub

    Private Sub Email_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim currentDate As DateTime = DateTime.Now
        'login.SQL.ExecQuery("Select distinct Contractors.CID,Contractors.LName+' '+Contractors.FName as Name,Contractors.Cemail 
        '                    from Contractors,Contracts
        '                    where  Contractors.CID=Contracts.CID and Contractors.cid not in (select cid from timesheet where Status='emailed' or month =" + currentDate.Month.ToString + ")")

        'DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
        'For i As Integer = 0 To login.SQL.DBDS.Tables(0).Rows.Count - 1
        '    NewMonthList.Add(login.SQL.DBDS.Tables(0).Rows(i)(0))
        'Next

        DataGridView1.MultiSelect = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        login.SQL.ExecQuery("Select distinct Lease.LeaseID, Lease.DoorNumber, Lease.BID, Tenant.First_name, Tenant.Last_name, 
                             Lease.Monthlyrate, Lease.Startdate, Lease.Enddate
                             From Lease,Tenant,Unit
                             Where Lease.TID=Tenant.TID AND Lease.BID=Unit.BID AND Lease.DoorNumber=Unit.DoorNumber")
        'login.SQL.ExecQuery("Select distinct Lease.LeaseID, Lease.DoorNumber, Lease.BID, Tenant.First_name, Tenant.Last_name,
        'Lease.Monthlyrate, Lease.Startdate, Lease.Enddate
        'From Lease,Tenant,Unit
        'where Lease.TID=Tenant.TID AND Lease.BID=Unit.BID AND Lease.DoorNumber=Unit.DoorNumber")

        'login.SQL.ExecQuery("select * from Client where CLientID = " + idsearch.ToString + "or Name like '%" + searchstr + "%' or Pemail like '%" + searchstr + "%'")
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
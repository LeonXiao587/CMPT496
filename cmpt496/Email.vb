﻿Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class Email
    Public NewMonthList As New List(Of Integer)

    Public list As New List(Of String)
    Public receiverlist As New List(Of String)
    Public Function SendeEmail(ByVal ReceiveAddressList As List(Of String))
        Dim Emailmessage As New MailMessage
        Dim smtp As New SmtpClient
        Dim t As Integer

        t = CInt(Replace(DateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), "-", ""))
        login.SQL.ExecQuery("Select * From Payment where replace (Paymentdate, '-', '' ) =" + t.ToString)

        smtp.Host = login.SQL.DBDS.Tables(0).Rows(0)(1).ToString
        smtp.UseDefaultCredentials = False
        smtp.Port = login.SQL.DBDS.Tables(0).Rows(0)(2)
        smtp.EnableSsl = True
        smtp.Credentials = New System.Net.NetworkCredential(login.SQL.DBDS.Tables(0).Rows(0)(3).ToString, login.SQL.DBDS.Tables(0).Rows(0)(4).ToString)
        Emailmessage.From = New MailAddress(login.SQL.DBDS.Tables(0).Rows(0)(3).ToString)

        ' I added the part to read all the emails from the datagridview and add it to the mailing list

        If receiverlist.Count = 0 Then Return False
        For i = 0 To receiverlist.Count - 1
            Emailmessage.To.Add(receiverlist(i))
        Next

        Emailmessage.Subject = login.SQL.DBDS.Tables(0).Rows(0)(5).ToString 'get email field from database
        Emailmessage.Body = login.SQL.DBDS.Tables(0).Rows(0)(6).ToString

        Try
            smtp.Send(Emailmessage)
            MessageBox.Show("Email Send！")
            Return True
        Catch
            MessageBox.Show("Failed！")
            Return False
        Finally
            Emailmessage.Dispose()

        End Try

    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        LoadGrid()
    End Sub

    Private Sub LoadGrid()

        Dim t As Integer

        't = Replace(DateTimePicker1.Value.Date.ToString("yyyy/MM/dd"), "/", "-")
        'Throw New NotImplementedException()

        t = CInt(Replace(DateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), "-", ""))
        login.SQL.ExecQuery("Select * From Payment where replace (Paymentdate, '-', '' ) =" + t.ToString)
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

        'login.SQL.ExecQuery("Select distinct Lease.LeaseID, Lease.DoorNumber, Lease.BID, Tenant.First_name, Tenant.Last_name, 
        '                     Lease.Monthlyrate, Lease.Startdate, Lease.Enddate
        '                     From Lease,Tenant,Unit
        '                     Where Lease.TID=Tenant.TID AND Lease.BID=Unit.BID AND Lease.DoorNumber=Unit.DoorNumber")

        Dim t As Integer

        t = CInt(Replace(DateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), "-", ""))

        login.SQL.ExecQuery("Select * From Payment where replace (Paymentdate, '-', '' ) =" + t.ToString)

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
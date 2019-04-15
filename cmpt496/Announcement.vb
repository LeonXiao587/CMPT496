Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class Announcement

    Public NewMonthList As New List(Of Integer)

    Public list As New List(Of String)
    Public receiverlist As New List(Of String)

    Public Function SendeEmail(ByVal ReceiveAddressList As List(Of String))
        Dim Emailmessage As New MailMessage
        Dim smtp As New SmtpClient
        login.SQL.ExecQuery("SELECT * from email where duty = 'sendInvoice'")
        smtp.Host = login.SQL.DBDS.Tables(0).Rows(0)(1).ToString
        smtp.UseDefaultCredentials = False
        smtp.Port = login.SQL.DBDS.Tables(0).Rows(0)(2)
        smtp.EnableSsl = True
        smtp.Credentials = New System.Net.NetworkCredential(login.SQL.DBDS.Tables(0).Rows(0)(3).ToString, login.SQL.DBDS.Tables(0).Rows(0)(4).ToString)
        Emailmessage.From = New MailAddress(login.SQL.DBDS.Tables(0).Rows(0)(3).ToString)

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
    Private Sub Announcement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        login.SQL.ExecQuery("Select DISTINCT Unit.Floors, Unit.DoorNumber, Tenant.Email
                             From Unit, Tenant, Lease
                             Where Unit.DoorNumber = Lease.DoorNumber and Lease.TID = Tenant.TID")
        For i = 0 To login.SQL.DBDS.Tables(0).Rows.Count - 1
            ComboBox1.Items.Add(login.SQL.DBDS.Tables(0).Rows(i)(0).ToString)
        Next
        For i = 0 To login.SQL.DBDS.Tables(0).Rows.Count - 1
            CheckedListBox1.Items.Add(login.SQL.DBDS.Tables(0).Rows(i)(1).ToString)
        Next

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim checked As Boolean = False   ' Set to True or False, as required.
        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, checked)
        Next
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim checked As Boolean = True   ' Set to True or False, as required.
        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, checked)
        Next
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class
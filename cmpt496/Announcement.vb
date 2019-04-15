Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class Announcement

    Public NewMonthList As New List(Of Integer)

    Public list As New List(Of String)
    Public receiverlist As New List(Of String)

    Public Function SendeEmail(ByVal ReceiveAddressList As List(Of String))
        Dim Emailmessage As New MailMessage()

        'login.SQL.ExecQuery("SELECT * from email where duty = 'sendInvoice'")
        'smtp.Host = 587
        Dim smtp As New SmtpClient With {
            .UseDefaultCredentials = False,
            .Port = 587,
            .EnableSsl = True,
            .Host = "smtp.gmail.com",
            .Credentials = New System.Net.NetworkCredential("monthlyhourcollector@gmail.com", "cmpt395test")
        }

        Emailmessage.IsBodyHtml = True
        Emailmessage.From = New MailAddress("monthlyhourcollector@gmail.com")

        If receiverlist.Count = 0 Then Return False
        For i = 0 To receiverlist.Count - 1
            Emailmessage.To.Add(receiverlist(i))
        Next

        Emailmessage.Subject = TextBox1.Text
        Emailmessage.Body = TextBox2.Text
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
        login.SQL.ExecQuery("Select DISTINCT Unit.Floors, Unit.DoorNumber, Tenant.Email
                             From Unit, Tenant, Lease
                             Where Unit.DoorNumber = Lease.DoorNumber and Lease.TID = Tenant.TID")
        If CheckedListBox1.CheckedItems Is Nothing Then
            MsgBox("Please Select a Unit Number to Send Email.")
        Else
            'Dim s As String
            For i As Integer = 0 To CheckedListBox1.CheckedItems.Count - 1
                If login.SQL.DBDS.Tables(0).Rows(i)(1).ToString = CheckedListBox1.CheckedItems(0).ToString Then
                    'MsgBox(CheckedListBox1.CheckedItems(0) + "     " + login.SQL.DBDS.Tables(0).Rows(i)(2).ToString)
                    list.Add(login.SQL.DBDS.Tables(0).Rows(i)(2).ToString)
                End If

                'list.Add(login.SQL.DBDS.Tables(0).Rows(i)(2).ToString)
            Next

            For Each item In list
                String.Join(",", item)
                receiverlist.Add(item)
            Next
            'MsgBox(receiverlist(0).ToString)
            SendeEmail(receiverlist)
        End If
    End Sub
End Class
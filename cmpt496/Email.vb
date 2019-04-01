Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class Email
    'Public NewMonthList As New List(Of Integer)

    'Public list As New List(Of String)
    'Public receiverlist As New List(Of String)

    'Public Function SendeEmail(ByVal ReceiveAddressList As List(Of String))
    '    Dim Emailmessage As New MailMessage
    '    Dim smtp As New SmtpClient
    '    login.SQL.ExecQuery("SELECT * from email where duty = 'sendInvoice'")
    '    smtp.Host = login.SQL.DBDS.Tables(0).Rows(0)(1).ToString
    '    smtp.UseDefaultCredentials = False
    '    smtp.Port = login.SQL.DBDS.Tables(0).Rows(0)(2)
    '    smtp.EnableSsl = True
    '    smtp.Credentials = New System.Net.NetworkCredential(login.SQL.DBDS.Tables(0).Rows(0)(3).ToString, login.SQL.DBDS.Tables(0).Rows(0)(4).ToString)
    '    Emailmessage.From = New MailAddress(login.SQL.DBDS.Tables(0).Rows(0)(3).ToString)

    '    If receiverlist.Count = 0 Then Return False
    '    For i = 0 To receiverlist.Count - 1
    '        Emailmessage.To.Add(receiverlist(i))
    '    Next

    '    Emailmessage.Subject = login.SQL.DBDS.Tables(0).Rows(0)(5).ToString 'get email field from database
    '    Emailmessage.Body = login.SQL.DBDS.Tables(0).Rows(0)(6).ToString
    '    Try
    '        smtp.Send(Emailmessage)
    '        MessageBox.Show("Email Send！")
    '        Return True
    '    Catch
    '        MessageBox.Show("Failed！")
    '        Return False
    '    Finally
    '        Emailmessage.Dispose()

    '    End Try

    'End Function

    Private Sub LoadGrid()
        Dim t As Integer
        t = CInt(Replace(DateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), "-", ""))
        login.SQL.ExecQuery("Select Payment.InvoiceID, Payment.TID, Payment.Amount, Payment.Paymentdate, 
                             Tenant.First_name, Tenant.Last_name, Tenant.Email
                             From Payment, Tenant where Payment.TID = Tenant.TID AND replace (Paymentdate, '-', '' ) =" + t.ToString)
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
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

        'DataGridView1.DataSource = login.SQL.DBDS.Tables(0)

        DataGridView1.MultiSelect = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click
        Dim EmailMessage As New MailMessage()
        Try
            EmailMessage.From = New MailAddress("monthlyhourcollector@gmail.com")
            EmailMessage.To.Add(DataGridView1.SelectedRows(0).Cells(6).Value.ToString)
            EmailMessage.Subject = "Payment Notice"
            EmailMessage.Body = "Here is your payment information. vbCr" + "Name: " + DataGridView1.SelectedRows(0).Cells(4).Value.ToString + "vbTab" + DataGridView1.SelectedRows(0).Cells(5).Value.ToString + "vbCr Amount: " + DataGridView1.SelectedRows(0).Cells(2).Value.ToString + "vbCr Date: " + DataGridView1.SelectedRows(0).Cells(3).Value.ToString + "vbCr InvoiveID: " + DataGridView1.SelectedRows(0).Cells(0).Value.ToString + "vbCr TID: " + DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            Dim SMTP As New SmtpClient("smtp.gmail.com") With {
                .Port = 587,
                .EnableSsl = True,
                .Credentials = New System.Net.NetworkCredential("monthlyhourcollector@gmail.com", "cmpt395test")
            }
            SMTP.Send(EmailMessage)

            MessageBox.Show("Email has been send!")
            Me.Close()
            Billing_lease.Show()

        Catch ex As Exception
            MessageBox.Show("Please try again!")
            Me.Close()
            Billing_lease.Show()
        End Try

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim EmailMessage As New MailMessage()
        Try
            EmailMessage.From = New MailAddress("monthlyhourcollector@gmail.com")
            EmailMessage.To.Add(DataGridView1.SelectedRows(0).Cells(6).Value.ToString)
            EmailMessage.Subject = "Payment Notice"
            EmailMessage.Body = "Here is your payment information." + "Name:" + DataGridView1.SelectedRows(0).Cells(4).Value.ToString + DataGridView1.SelectedRows(0).Cells(5).Value.ToString + "Amount:" + DataGridView1.SelectedRows(0).Cells(2).Value.ToString + "Date:" + DataGridView1.SelectedRows(0).Cells(3).Value.ToString + "InvoiveID:" + DataGridView1.SelectedRows(0).Cells(0).Value.ToString + "TID:" + DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            Dim SMTP As New SmtpClient("smtp.gmail.com") With {
                .Port = 587,
                .EnableSsl = True,
                .Credentials = New System.Net.NetworkCredential("monthlyhourcollector@gmail.com", "cmpt395test")
            }
            SMTP.Send(EmailMessage)

            MessageBox.Show("Email has been send!")
            Me.Close()
            Billing_lease.Show()

        Catch ex As Exception
            MessageBox.Show("Please try again!")
            Me.Close()
            Billing_lease.Show()
        End Try
    End Sub
End Class
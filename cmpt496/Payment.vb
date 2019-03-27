Public Class Payment
    Public Fname As String
    Public Lname As String
    Public Tenant_ID As String
    Public TEmail As String
    Public PAmount As String

    Private Sub LoadGrid()
        'login.SQL.ExecQuery("select * from Payment")

        ''login.SQL.ExecQuery("select * from Client where CLientID = " + idsearch.ToString + "or Name like '%" + searchstr + "%' or Pemail like '%" + searchstr + "%'")
        'DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
        ''Throw New NotImplementedException()
    End Sub

    'Select distinct Lease.LeaseID, Lease.BID, Unit.UnitID, Tenant.First_name, Tenant.Last_name, Lease.Monthlyrate, Lease.Startdate, Lease.Enddate
    'From Lease,Tenant,Unit Where Lease.TID=Tenant.TID AND Lease.BID=Unit.BID
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'login.SQL.ExecQuery("select Tenant.First_name, Tenant.Last_name, Tenant.TID, Tenant.Email, Payment.Amount
        '                     From Tenant, Payment Where Tenant.TID=Payment.TID")
        'Fname = login.SQL.DBDS.Tables(0).Rows(0)(0).ToString
        'Lname = login.SQL.DBDS.Tables(0).Rows(0)(1).ToString
        'Tenant_ID = login.SQL.DBDS.Tables(0).Rows(0)(2).ToString
        'TEmail = login.SQL.DBDS.Tables(0).Rows(0)(3).ToString
        'PAmount = login.SQL.DBDS.Tables(0).Rows(0)(4).ToString
        'Label7.Text = Fname & Lname
        'Label8.Text = Tenant_ID
        'Label9.Text = TEmail
        'Label10.Text = PAmount
        If Billing_lease.DataGridView1.Rows.Count > 1 Then
            Label7.Text = Billing_lease.DataGridView1.SelectedRows(0).Cells(4).Value.ToString & Billing_lease.DataGridView1.SelectedRows(0).Cells(5).Value.ToString
            Label8.Text = Billing_lease.DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            Label9.Text = Billing_lease.DataGridView1.SelectedRows(0).Cells(9).Value.ToString
            Label10.Text = Billing_lease.DataGridView1.SelectedRows(0).Cells(6).Value.ToString

        ElseIf Billing_lease.DataGridView1.Rows.Count < 1 Then
            MessageBox.Show("Please Select a row to view payment!")
            Me.Close()
            Billing_lease.Show()
        End If


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Billing_lease.Show()
    End Sub


    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click
        Dim regDate As Date = Date.Now()
        'Dim strDate As String = regDate.ToString("ddMMMyyyy")
        'LoadGrid()

        login.SQL.ExecQuery("INSERT INTO Payment(Amount, TID, Paymentdate)
                             VALUES ('" & TextBox1.Text & "','" & Label8.Text & "','" & regDate & "')"
                            )


        MessageBox.Show("Add New Payment Done!")
        TextBox1.Clear()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click

        Dim regDate As Date = Date.Now()
        'Dim strDate As String = regDate.ToString("ddMMMyyyy")
        'LoadGrid()

        login.SQL.ExecQuery("INSERT INTO Payment(Amount, TID, Paymentdate)
                             VALUES ('" & TextBox1.Text & "','" & Label8.Text & "','" & regDate & "')"
                            )


        MessageBox.Show("Add New Payment Done!")
        TextBox1.Clear()

    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click
        Me.Close()
        Email.Show()
    End Sub

    Private Sub SendEmail_Click(sender As Object, e As EventArgs) Handles SendEmail.Click
        Me.Close()
        Email.Show()
    End Sub
End Class
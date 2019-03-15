Public Class Payment
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Billing_lease.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadGrid()
    End Sub

    Private Sub LoadGrid()
        login.SQL.ExecQuery("select * from Payment")

        'login.SQL.ExecQuery("select * from Client where CLientID = " + idsearch.ToString + "or Name like '%" + searchstr + "%' or Pemail like '%" + searchstr + "%'")
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
        'Throw New NotImplementedException()
    End Sub
End Class
Public Class ManageLeases
    Private Sub Loadinfo()
        Dim idsearch As Integer
        idsearch = 0
        Dim searchstr As String
        searchstr = searchBox1.Text.ToString
        If (IsNumeric(searchBox1.Text)) Then
            idsearch = searchBox1.Text
        End If
        login.SQL.ExecQuery("Select First_name + '' + Last_name as name,TID,Phone, Email, Occupation, Company, Income, ID,password from Tenant where TID = " + searchBox1.Text.ToString)
    End Sub

    Private Sub UnitLabel1_Click(sender As Object, e As EventArgs) Handles UnitLabel1.Click

    End Sub
End Class
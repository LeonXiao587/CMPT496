Public Class ManageLeases
    Private Sub Loadinfo()
        If (IsNumeric(searchBox1.Text)) Then
            login.SQL.ExecQuery("Select First_name, Last_name, Email, Occupation, Company, Income,password from Tenant where phone = '" + searchBox1.Text.ToString + "'")
            If login.SQL.DBDS.Tables(0).Rows.Count = 0 Then
                MsgBox("No Result!")
            Else
                fistnBox6.Text = login.SQL.DBDS.Tables(0).Rows(0)(0).ToString
                lastnBox1.Text = login.SQL.DBDS.Tables(0).Rows(0)(1).ToString
                emailBox5.Text = login.SQL.DBDS.Tables(0).Rows(0)(2).ToString
                OccupationBox2.Text = login.SQL.DBDS.Tables(0).Rows(0)(3).ToString
                CompanyBox4.Text = login.SQL.DBDS.Tables(0).Rows(0)(4).ToString
                IncomeBox3.Text = login.SQL.DBDS.Tables(0).Rows(0)(5).ToString
                passwordBox7.Text = login.SQL.DBDS.Tables(0).Rows(0)(6).ToString
                PhoneBox1.Text = searchBox1.Text.ToString
            End If
        Else
            MsgBox("Invalid Phone")
        End If
    End Sub

    Private Sub UnitLabel1_Click(sender As Object, e As EventArgs) Handles UnitLabel1.Click, Label7.Enter
        Loadinfo()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        login.SQL.ExecQuery("update Tenant set email = '" + emailBox5.Text.ToString + "', Occupation = '" + OccupationBox2.Text.ToString + "', Company = '" + CompanyBox4.Text.ToString + "', income = " + IncomeBox3.Text.ToString + ", password = '" + passwordBox7.Text.ToString + "', Phone = '" + PhoneBox1.Text.ToString + "' where Phone = '" + searchBox1.Text.ToString + "'")
        'MsgBox("update Tenant set email = '" + emailBox5.Text.ToString + "', Occupation = '" + OccupationBox2.Text.ToString + "', Company = '" + CompanyBox4.Text.ToString + "', income = " + IncomeBox3.Text.ToString + ", password = '" + passwordBox7.Text.ToString + "', phone = '" + PhoneBox1.Text.ToString + "'  where phone = '56565656'")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        ManagementOption.Show()

    End Sub

End Class
Public Class Cosigner
    Public Cid As String = "Null"

    Private Sub SubmitCosigner()
        If first_name.Text = "" Or last_name.Text = "" Or phone.Text = "" Or email.Text = "" Or id.Text = "" Then
            MsgBox("Input all fields please!")
        Else
            If IsNumeric(phone.Text) Or IsNumeric(id.Text) Then
                login.SQL.ExecQuery("insert into Tenant (Phone,First_name,Last_name,Email, Credits,ID,PAddress,Income,Occupation,Company) Values ('" + phone.Text.ToString + "','" + first_name.Text.ToString + "','" + last_name.Text.ToString + "','" + email.Text.ToString + "',0," + id.Text.ToString + ",'" + addressbox.Text.ToString + "'," + incomeBox1.Text.ToString + ",'" + occupationBox3.Text.ToString + "','" + companyBox5.Text.ToString + "')")
                login.SQL.ExecQuery("select TID from tenant where phone = '" + phone.Text.ToString + "'")
                Cid = login.SQL.DBDS.Tables(0).Rows(0)(0).ToString()
                MsgBox("Done!")
                Me.Hide()
            Else
                MsgBox("Please input Numbers for ID and Phone Number and Income!")
            End If

        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        SubmitCosigner()

    End Sub

End Class
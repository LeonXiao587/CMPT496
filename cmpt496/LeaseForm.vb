Public Class LeaseForm
    Private Sub parking_SelectedIndexChanged(sender As Object, e As EventArgs) Handles parking.SelectedIndexChanged
        If parking.SelectedIndex <> 0 Then
            login.SQL.ExecQuery("Select top 1 StallID,Rate from ParkRate where BID = " + Main.Building.Text.ToString + " And RentStatus = 'Vacant' and Stalltype = '" + parking.SelectedItem.ToString + "' order by newid()")
            stallnumber.Text = login.SQL.DBDS.Tables(0).Rows(0)(0).ToString
            Label11.Text = login.SQL.DBDS.Tables(0).Rows(0)(1).ToString
            ratebox.Text = CInt(Label11.Text) + CInt(Renting.price.Text)
        Else
            Label11.Text = 0
            ratebox.Text = CInt(Label11.Text) + CInt(Renting.price.Text)
        End If
    End Sub

    Private Sub LeaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Renting.ListBox1.SelectedItem(0).ToString()
        parking.SelectedIndex = 0
    End Sub
End Class
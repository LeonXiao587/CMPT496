Public Class AddParking
    Private Sub RectangleShape4_Click(sender As Object, e As EventArgs) Handles RectangleShape5.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        login.SQL.ExecQuery("insert into Parking  (BID,RentStatus,Stalltype) Values (" + Main.Building.Text.ToString + ",'Vacant','" + ComboBox1.SelectedText + "')")
        MsgBox("Done")

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class
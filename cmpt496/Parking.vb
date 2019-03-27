Public Class Parking

    'Private Sub Main0_Click(sender As Object, e As EventArgs) Handles Main0.Click
    '    Me.Hide()
    '    Main.Show()
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Room_view.Show()
    End Sub

    Private Sub Parking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Building.Text = Main.Building.Text
        ParkingType.SelectedIndex = 0
    End Sub

    Private Sub ParkingType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ParkingType.SelectedIndexChanged
        Dim Type As String
        Type = ParkingType.SelectedText
        If ParkingType.SelectedIndex = 0 Then
            Type = "Stalltype"
        Else
            Type = "'" + ParkingType.SelectedItem + "'"
        End If
        login.SQL.ExecQuery("Select * from Parking where  BID = " + Building.Text + " and Stalltype = " + Type + "")
        Parkinglist.DataSource = login.SQL.DBDS.Tables(0)
    End Sub
End Class
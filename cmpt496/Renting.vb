Public Class Renting
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Main.Show()

    End Sub

    Private Sub Renting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.SQL.ExecQuery("select distinct Stalltype from Parking")
        For i = 0 To login.SQL.DBDS.Tables(0).Rows.Count - 1
            parking.Items.Add(login.SQL.DBDS.Tables(0).Rows(i)(0).ToString)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bed As Integer
        Dim bath As Integer
        bed = Bedroom.SelectedItem
        bath = Bathroom.SelectedItem
        login.SQL.ExecQuery("select distinct Unit from Parking where")
    End Sub
End Class
Public Class ManagementOption
    Private Sub Parkinglable_Click(sender As Object, e As EventArgs) Handles Parkinglable.Click
        Parking.Show()
        Me.Close()
    End Sub

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click
        Parking.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub EmployeeLabel4_Click(sender As Object, e As EventArgs) Handles EmployeeLabel4.Click
        Management.Show()
        Me.Close()

    End Sub
End Class
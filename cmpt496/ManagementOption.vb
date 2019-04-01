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
    Private Sub RectangleShape3_Click(sender As Object, e As EventArgs) Handles RectangleShape3.Click
        Management.Show()
        Me.Close()
    End Sub

    Private Sub Leaselable_Click(sender As Object, e As EventArgs) Handles Leaselable.Click
        ManageLeases.Show()
        Me.Close()
    End Sub
    Private Sub RectangleShape4_Click(sender As Object, e As EventArgs) Handles RectangleShape4.Click
        ManageLeases.Show()
        Me.Close()
    End Sub

    Private Sub UnitLabel1_Click(sender As Object, e As EventArgs) Handles UnitLabel1.Click
        Room_view.Show()
        Me.Close()
    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click
        Room_view.Show()
        Me.Close()
    End Sub


End Class
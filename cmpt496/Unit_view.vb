Public Class Unit_view
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Renting.Show()
    End Sub

    Private Sub Main_Click(sender As Object, e As EventArgs) Handles Main.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Room_view.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Parking.Show()
    End Sub
End Class
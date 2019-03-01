Public Class Room_view
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Unit_view.Show()
    End Sub

    Private Sub Main0_Click(sender As Object, e As EventArgs) Handles Main0.Click
        Me.Hide()
        Main.Show()
    End Sub
End Class
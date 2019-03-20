Public Class ContractForm
    Private Sub ContractForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        parking.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If first_name.Text = "" Or last_name.Text = "" Or phone.Text = "" Or email.Text = "" Or id.Text = "" Then
            MsgBox("Input all fields please!")
        End If

    End Sub
End Class
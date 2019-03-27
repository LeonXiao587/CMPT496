Imports System.Data.SqlClient

Public Class Email
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Billing_lease.Show()
    End Sub

    Private Sub Main0_Click(sender As Object, e As EventArgs) Handles Main0.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoadGrid()
    End Sub

    Private Sub LoadGrid()

        Dim t As String

        t = Replace(DateTimePicker1.Value.Date.ToString("yyyy/MM/dd"), "/", "-")
        'Throw New NotImplementedException()
        login.SQL.ExecQuery("Select * From Payment where paymentdate = " + t)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim intResult As Integer
        intResult = MessageBox.Show("You sure you want to make these changes", "Waring", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If intResult = DialogResult.OK Then
            Dim scb As SqlCommandBuilder = New SqlCommandBuilder(login.SQL.DBDA)
            login.SQL.DBDA.Update(login.SQL.DBDS)
            MsgBox("Changes updated!")
        End If
    End Sub

End Class
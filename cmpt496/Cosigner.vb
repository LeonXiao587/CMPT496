Imports System.Text.RegularExpressions

Public Class Cosigner
    Public Cid As String = "Null"
    Dim C_REGULAR_Letters As New Regex("^[A-Za-z]+$")

    Private Sub SubmitCosigner()

        'check for name validation


        If first_name.Text = "" Or last_name.Text = "" Or phone.Text = "" Or email.Text = "" Or id.Text = "" Or incomeBox1.Text = "" Then
            MsgBox("Input All * Information Fields Please!")
            Exit Sub
        Else

            If C_REGULAR_Letters.IsMatch(first_name.Text） = False Or C_REGULAR_Letters.IsMatch(last_name.Text） = False Then
                MsgBox("Input Vaild Name")
                Exit Sub
            End If

            If email.Text Like "*@*.com" Or email.Text Like "*@*.net" Or email.Text Like "*@*.ca" Then
            Else
                MsgBox("Input Vaild Email Address")

                Exit Sub
            End If

            If Len(phone.Text) = 10 Then
            Else
                MsgBox("Input Vaild Phone Number")
                Exit Sub

            End If

            If Len(id.Text) = 9 Then
            Else
                MsgBox("Input Vaild ID Number")
                Exit Sub

            End If


            If IsNumeric(phone.Text) And IsNumeric(id.Text) And IsNumeric(incomeBox1.Text) Then
                    login.SQL.ExecQuery("insert into Tenant (Phone,First_name,Last_name,Email, Credits,ID,PAddress,Income,Occupation,Company) Values ('" + phone.Text.ToString + "','" + first_name.Text + "','" + last_name.Text + "','" + email.Text + "',0," + id.Text.ToString + ",'" + addressbox.Text.ToString + "'," + incomeBox1.Text.ToString + ",'" + occupationBox3.Text.ToString + "','" + companyBox5.Text.ToString + "')")
                    Me.Close()
                Else
                    MsgBox("Please Input Number for ID, Phone Number, and Income!")
                End If

            End If

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        SubmitCosigner()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click
        SubmitCosigner()
    End Sub

    Private Sub Cosigner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        unitlable.Text = Renting.ListBox1.SelectedItem(0).ToString
    End Sub
End Class
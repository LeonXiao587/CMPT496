Public Class ParkingChange
    Private Sub RectangleShape3_Click(sender As Object, e As EventArgs) Handles RectangleShape4.Click, RectangleShape1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        ManageLeases.Show()
    End Sub

    Private Sub ParkingChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.SQL.ExecQuery("Select * from Parking where TID = " + ManageLeases.GroupBox1.Text.ToString)
        If login.SQL.DBDS.Tables(0).Rows.Count = 0 Then
            stallidLabel2.Text = "NA"
            stalltypeLabel3.Text = "NA"
            makeBox1.Enabled = False
            plateBox7.Enabled = False
        Else
            stallidLabel2.Text = login.SQL.DBDS.Tables(0).Rows(0)(0).ToString
            stalltypeLabel3.Text = login.SQL.DBDS.Tables(0).Rows(0)(6).ToString
            makeBox1.Text = login.SQL.DBDS.Tables(0).Rows(0)(4).ToString
            plateBox7.Text = login.SQL.DBDS.Tables(0).Rows(0)(5).ToString
        End If

    End Sub

    Private Sub Cancelbutton_Click(sender As Object, e As EventArgs) Handles Cancelbutton.Click
        Dim intResult As Integer
        intResult = MessageBox.Show("Cancel the Parking Stall?", "Waring", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)

        If intResult = DialogResult.OK Then
            login.SQL.ExecQuery("update Parking set TID = NULL,Make=NULL,Plate=NULL, RentStatus = 'Vacant' where TID =" + ManageLeases.GroupBox1.Text.ToString)
            login.SQL.ExecQuery("update Lease set StallID = NULL, Monthlyrate = Monthlyrate- (select rate from ParkRate where StallID = " + stallidLabel2.Text.ToString + ") where TID =" + ManageLeases.GroupBox1.Text.ToString)

            MsgBox("Canceled!")
            Me.Close()
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        login.SQL.ExecQuery("update Parking set Make='" + makeBox1.Text.ToString + "',Plate='" + plateBox7.Text.ToString + "' where TID =" + ManageLeases.GroupBox1.Text.ToString)
        MsgBox("Updated")
        Me.Close()

    End Sub
End Class
Public Class LeaseForm
    Private Sub Parking_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Parking.SelectedIndexChanged
        If Parking.SelectedIndex <> 0 Then
            login.SQL.ExecQuery("Select top 1 StallID,Rate from ParkRate where BID = " + Main.Building.Text.ToString + " And RentStatus = 'Vacant' and Stalltype = '" + Parking.SelectedItem.ToString + "' order by newid()")

            If login.SQL.DBDS.Tables(0).Rows.Count = 0 Then
                Label11.Text = 0
                stallnumber.Text = "NA"
                ratebox.Text = CInt(Label11.Text) + CInt(Renting.price.Text)
                MakeBox1.Enabled = False
                Platebox2.Enabled = False
            Else
                MakeBox1.Enabled = True
                Platebox2.Enabled = True
                stallnumber.Text = login.SQL.DBDS.Tables(0).Rows(0)(0).ToString
                Label11.Text = login.SQL.DBDS.Tables(0).Rows(0)(1).ToString
                ratebox.Text = CInt(Label11.Text) + CInt(Renting.price.Text)
            End If
        Else
            MakeBox1.Enabled = False
            Platebox2.Enabled = False
            Label11.Text = 0
            stallnumber.Text = "__"
            ratebox.Text = CInt(Label11.Text) + CInt(Renting.price.Text)
        End If
    End Sub

    Private Sub LeaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        yearbox.SelectedIndex = 0
        Renting.ListBox1.SelectedItem(0).ToString()
        Parking.SelectedIndex = 0
        unitlable.Text = Renting.ListBox1.SelectedItem(0).ToString
    End Sub

    Private Sub FinishWork()
        ' validation of amount input
        If IsNumeric(ratebox.Text) Then
        Else
            MsgBox("Invalid Amount!")
            Exit Sub
        End If

        Dim startdate As String = DateTimePicker1.Value.Date.ToString("yyyy-MM-dd")
        Dim den As Integer = CInt(Microsoft.VisualBasic.Left(startdate, 4)) + CInt(yearbox.SelectedIndex + 1)
        Dim enddate As String = den.ToString + Microsoft.VisualBasic.Right(startdate, 6)
        login.SQL.ExecQuery("select TID from tenant where phone = '" + TenantInfo.phone.Text.ToString + "'")
        ' store tid from tenant info page
        Dim tid As String = login.SQL.DBDS.Tables(0).Rows(0)(0).ToString
        If Parking.SelectedIndex = 0 Or stallnumber.Text = "NA" Then
            login.SQL.ExecQuery("insert into lease (TID,BID,DoorNumber,Startdate,Enddate,Monthlyrate,Note,CoTID) values (" + tid + "," + Main.Building.Text.ToString + "," + unitlable.Text.ToString + ",'" + startdate + "','" + enddate + "'," + ratebox.Text.ToString + ",'" + Notebox.Text.ToString + "'," + Cosigner.Cid.ToString + ")")
        Else
            login.SQL.ExecQuery("insert into lease (TID,BID,DoorNumber,Startdate,Enddate,StallID,Monthlyrate,Note,CoTID) values (" + tid + "," + Main.Building.Text.ToString + "," + unitlable.Text.ToString + ",'" + startdate + "','" + enddate + "'," + stallnumber.Text.ToString + "," + ratebox.Text.ToString + ",'" + Notebox.Text.ToString + "'," + Cosigner.Cid.ToString + ")")
            login.SQL.ExecQuery("update Parking set Rentstatus = 'Occupied', Make = '" + MakeBox1.Text.ToString + "',TID =" + tid + ", Plate = '" + PlateBox2.Text.ToString + "' where StallID = " + stallnumber.Text.ToString)

        End If
        login.SQL.ExecQuery("update Unit set Rentstatus = 'Occupied' where BID = " + Main.Building.Text.ToString + " and DoorNumber = " + unitlable.Text.ToString)

        Me.Close()
        TenantInfo.Close()
        Renting.Close()
        MsgBox("Sucess!")
        Main.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub CmdClose_Click()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click
        FinishWork()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        FinishWork()
    End Sub

End Class
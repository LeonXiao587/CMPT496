Public Class LeaseForm
    Private Sub parking_SelectedIndexChanged(sender As Object, e As EventArgs) Handles parking.SelectedIndexChanged
        If parking.SelectedIndex <> 0 Then
            login.SQL.ExecQuery("Select top 1 StallID,Rate from ParkRate where BID = " + Main.Building.Text.ToString + " And RentStatus = 'Vacant' and Stalltype = '" + parking.SelectedItem.ToString + "' order by newid()")
            If login.SQL.DBDS.Tables(0).Rows.Count = 0 Then
                Label11.Text = 0
                stallnumber.Text = "__"
                ratebox.Text = CInt(Label11.Text) + CInt(Renting.price.Text)
            Else
                stallnumber.Text = login.SQL.DBDS.Tables(0).Rows(0)(0).ToString
                Label11.Text = login.SQL.DBDS.Tables(0).Rows(0)(1).ToString
                ratebox.Text = CInt(Label11.Text) + CInt(Renting.price.Text)
            End If
        Else
            Label11.Text = 0
            stallnumber.Text = "__"
            ratebox.Text = CInt(Label11.Text) + CInt(Renting.price.Text)
        End If
    End Sub

    Private Sub LeaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        yearbox.SelectedIndex = 0
        Renting.ListBox1.SelectedItem(0).ToString()
        parking.SelectedIndex = 0
        unitlable.Text = Renting.ListBox1.SelectedItem(0).ToString
    End Sub

    Private Sub FinishWork()
        Dim startdate As String = DateTimePicker1.Value.Date.ToString("yyyy-MM-dd")
        Dim den As Integer = CInt(Microsoft.VisualBasic.Left(startdate, 4)) + CInt(yearbox.SelectedIndex + 1)
        Dim enddate As String = den.ToString + Microsoft.VisualBasic.Right(startdate, 6)
        login.SQL.ExecQuery("select TID from tenant where phone = '" + TenantInfo.phone.Text.ToString + "'")
        Dim tid As String = login.SQL.DBDS.Tables(0).Rows(0)(0).ToString
        If parking.SelectedIndex = 0 Then
            login.SQL.ExecQuery("insert into lease (TID,BID,DoorNumber,Startdate,Enddate,Monthlyrate) values (" + tid + "," + Main.Building.Text.ToString + "," + unitlable.Text.ToString + ",'" + startdate + "','" + enddate + "'," + ratebox.Text.ToString + ",'" + Notebox.Text.ToString + "')")
        Else
            login.SQL.ExecQuery("insert into lease (TID,BID,DoorNumber,Startdate,Enddate,StallID,Monthlyrate,Note) values (" + tid + "," + Main.Building.Text.ToString + "," + unitlable.Text.ToString + ",'" + startdate + "','" + enddate + "'," + stallnumber.Text.ToString + "," + ratebox.Text.ToString + ",'" + Notebox.Text.ToString + "')")
            login.SQL.ExecQuery("update Parking set Rentstatus = 'Occupied' where StallID = " + stallnumber.Text.ToString)
        End If
        login.SQL.ExecQuery("update Unit set Rentstatus = 'Occupied' where BID = " + Main.Building.Text.ToString + " and DoorNumber = " + unitlable.Text.ToString)

        Me.Close()
        TenantInfo.Close()
        Renting.Close()
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
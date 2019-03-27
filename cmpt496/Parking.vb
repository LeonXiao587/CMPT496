Imports System.Data.SqlClient

Public Class Parking
    Private Sub Editfunc()
        Dim intResult As Integer
        intResult = MessageBox.Show("Are you sure you want to make these changes", "Waring", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If intResult = DialogResult.OK Then
            Dim scb As SqlCommandBuilder = New SqlCommandBuilder(login.SQL.DBDA)
            login.SQL.DBDA.Update(login.SQL.DBDS)
            MsgBox("Changes updated!")


        Else
            MessageBox.Show("Please make a selection before removing")
        End If
    End Sub

    Private Sub Main0_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Room_view.Show()
    End Sub

    Private Sub Parking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Building.Text = Main.Building.Text
        ParkingType.SelectedIndex = 0
        login.SQL.ExecQuery("Select * from ParkingRate where  BID = " + Building.Text)
        Crate.Text = login.SQL.DBDS.Tables(0).Rows(0)(2)
        Orate.Text = login.SQL.DBDS.Tables(0).Rows(1)(2)

    End Sub

    Private Sub ParkingType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ParkingType.SelectedIndexChanged

    End Sub

    Private Sub SearchFunc()
        Dim Type As String
        Type = ParkingType.SelectedText
        If ParkingType.SelectedIndex = 0 Then
            Type = "Stalltype"
        Else
            Type = "'" + ParkingType.SelectedItem + "'"
        End If

        Dim Search As String
        If searchbox.Text.Length = 0 Then
            Search = "StallID"
        Else
            Search = searchbox.Text.ToString
        End If
        login.SQL.ExecQuery("Select StallID, TID, RentStatus, Make, Plate, Stalltype from Parking where  BID = " + Building.Text + " and Stalltype = " + Type + " and StallID = " + Search)
        Parkinglist.DataSource = login.SQL.DBDS.Tables(0)
    End Sub


    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click
        Loaddata()
    End Sub

    Private Sub RectangleShape3_Click(sender As Object, e As EventArgs) Handles RectangleShape3.Click
        SearchFunc()
    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click
        login.SQL.ExecQuery("update ParkingRate set Rate = " + Crate.Text.ToString + " where Stalltype = 'Covered' and BID = " + Building.Text)
        login.SQL.ExecQuery("update ParkingRate set Rate = " + Orate.Text.ToString + " where Stalltype = 'Outside' and BID = " + Building.Text)
        MsgBox("Done")
    End Sub

    Private Sub RectangleShape4_Click(sender As Object, e As EventArgs) Handles RectangleShape4.Click
        Editfunc()
    End Sub

    Private Sub Loaddata()
        Dim Type As String
        searchbox.Clear()
        Type = ParkingType.SelectedText
        If ParkingType.SelectedIndex = 0 Then
            Type = "Stalltype"
        Else
            Type = "'" + ParkingType.SelectedItem + "'"
        End If

        Dim Status As String
        If Statusbox.SelectedIndex = 0 Then
            Status = "RentStatus"
        Else
            Status = "'" + Statusbox.SelectedItem + "'"
        End If

        login.SQL.ExecQuery("Select StallID, TID, RentStatus, Make, Plate, Stalltype from Parking where  BID = " + Building.Text + " and Stalltype = " + Type + " and RentStatus = " + Status)
        Parkinglist.DataSource = login.SQL.DBDS.Tables(0)
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Loaddata()
    End Sub


    Private Sub Label9_Click_1(sender As Object, e As EventArgs) Handles Label9.Click
        login.SQL.ExecQuery("update ParkingRate set Rate = " + Crate.Text.ToString + " where Stalltype = 'Covered' and BID = " + Building.Text)
        login.SQL.ExecQuery("update ParkingRate set Rate = " + Orate.Text.ToString + " where Stalltype = 'Outside' and BID = " + Building.Text)
        MsgBox("Done")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        SearchFunc()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Editfunc()
    End Sub
End Class
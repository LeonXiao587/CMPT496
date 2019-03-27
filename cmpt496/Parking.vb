
Imports System.Data.SqlClient


'﻿Public Class Parking

'Private Sub Main0_Click(sender As Object, e As EventArgs) Handles Main0.Click
'    Me.Hide()
'    Main.Show()
'End Sub
Public Class Parking
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Type As String
        Type = ParkingType.SelectedText
        If ParkingType.SelectedIndex = 0 Then
            Type = "Stalltype"
        Else
            Type = "'" + ParkingType.SelectedItem + "'"
        End If

        login.SQL.ExecQuery("Select * from Parking where  BID = " + Building.Text + " and Stalltype = " + Type + "")


        Dim Search As String
        If searchbox.Text.Length = 0 Then
            Search = "StallID"
        Else
            Search = searchbox.Text.ToString
        End If
        login.SQL.ExecQuery("Select StallID, TID, RentStatus, Make, Plate, Stalltype from Parking where  BID = " + Building.Text + " and Stalltype = " + Type + " and StallID = " + Search)

        Parkinglist.DataSource = login.SQL.DBDS.Tables(0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        login.SQL.ExecQuery("update ParkingRate set Rate = " + Crate.Text.ToString + " where Stalltype = 'Covered' and BID = " + Building.Text)
        login.SQL.ExecQuery("update ParkingRate set Rate = " + Orate.Text.ToString + " where Stalltype = 'Outside' and BID = " + Building.Text)
        MsgBox("Done")
    End Sub
End Class
Imports System.Text.RegularExpressions

Public Class ManageLeases
    Dim C_REGULAR_Letters As New Regex("^[A-Za-z]+$")


    ' For displaying note on the lease
    Private Sub Note_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Note.MouseEnter
        Dim LabelFont As Font = New Font(Note.Font.Name, Note.Font.Size, FontStyle.Underline)
        Note.Font.Dispose()
        Note.Font = LabelFont
    End Sub
    ' remove underline when mouse move on to label Map
    Private Sub Note_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Note.MouseLeave
        Dim LabelFont As Font = New Font(Note.Font.Name, Note.Font.Size, FontStyle.Regular)
        Note.Font.Dispose()
        Note.Font = LabelFont
    End Sub
    Private Sub Loadinfo()
        If (IsNumeric(searchBox1.Text)) Then
            login.SQL.ExecQuery("Select First_name, Last_name, Email, Occupation, Company, Income,password,TID from Tenant where phone = '" + searchBox1.Text.ToString + "'")

            If login.SQL.DBDS.Tables(0).Rows.Count = 0 Then
                MsgBox("No Result!")
                fistnBox6.Text = "First"
                lastnBox1.Text = "Last"
                PhoneBox1.Clear()
                emailBox5.Clear()
                passwordBox7.Clear()
                IncomeBox3.Clear()
                OccupationBox2.Clear()
                CompanyBox4.Clear()
                searchBox1.Clear()

                TextBox8.Clear()
                BIDBox5.Clear()
                monthlyrateBox1.Clear()
                StartBox6.Clear()
                EndBox7.Clear()
            Else

                GroupBox1.Text = login.SQL.DBDS.Tables(0).Rows(0)(7).ToString
                fistnBox6.Text = login.SQL.DBDS.Tables(0).Rows(0)(0).ToString
                lastnBox1.Text = login.SQL.DBDS.Tables(0).Rows(0)(1).ToString
                emailBox5.Text = login.SQL.DBDS.Tables(0).Rows(0)(2).ToString
                OccupationBox2.Text = login.SQL.DBDS.Tables(0).Rows(0)(3).ToString
                CompanyBox4.Text = login.SQL.DBDS.Tables(0).Rows(0)(4).ToString
                IncomeBox3.Text = login.SQL.DBDS.Tables(0).Rows(0)(5).ToString
                passwordBox7.Text = login.SQL.DBDS.Tables(0).Rows(0)(6).ToString
                PhoneBox1.Text = searchBox1.Text.ToString
                login.SQL.ExecQuery("Select * from lease where BID = " + Main.Building.Text.ToString + " and TID = " + GroupBox1.Text.ToString)
                If login.SQL.DBDS.Tables(0).Rows.Count = 0 Then
                Else
                    BIDBox5.Text = login.SQL.DBDS.Tables(0).Rows(0)(2).ToString
                    TextBox8.Text = login.SQL.DBDS.Tables(0).Rows(0)(3).ToString
                    StartBox6.Text = login.SQL.DBDS.Tables(0).Rows(0)(4).ToString
                    EndBox7.Text = login.SQL.DBDS.Tables(0).Rows(0)(5).ToString
                    monthlyrateBox1.Text = login.SQL.DBDS.Tables(0).Rows(0)(7).ToString
                End If



            End If
        Else
            MsgBox("Invalid Phone")
        End If
    End Sub

    Private Sub UnitLabel1_Click(sender As Object, e As EventArgs) Handles UnitLabel1.Click, Label7.Enter
        Loadinfo()
    End Sub

    Private Sub Updateinfo()
        'when no phone for search -> empty textboxes
        If searchBox1.Text = "" Then
            MsgBox("No data input")
            Exit Sub
        End If

        If C_REGULAR_Letters.IsMatch(fistnBox6.Text） = False Or C_REGULAR_Letters.IsMatch(lastnBox1.Text） = False Then
            MsgBox("Input Vaild Name")
            Exit Sub
        End If

        If emailBox5.Text Like "*@*.com" Or emailBox5.Text Like "*@*.net" Or emailBox5.Text Like "*@*.ca" Then
        Else
            MsgBox("Input Vaild Email Address")

            Exit Sub
        End If

        If Len(PhoneBox1.Text) = 10 Then
        Else
            MsgBox("Input Vaild Phone Number")
            Exit Sub

        End If

        If fistnBox6.Text = "" Or lastnBox1.Text = "" Or PhoneBox1.Text = "" Or Email.Text = "" Or IncomeBox3.Text = "" Then
            MsgBox("Input All Information Fields Please!")
            Exit Sub
        End If

        If IsNumeric(PhoneBox1.Text) And IsNumeric(IncomeBox3.Text) Then
        Else
            MsgBox("Input Numbers for Income and Phone Number!")
            Exit Sub
        End If


        login.SQL.ExecQuery("update Tenant set email = '" + emailBox5.Text.ToString + "',First_name = '" + fistnBox6.Text.ToString + "',Last_name = '" + lastnBox1.Text.ToString + "',Occupation = '" + OccupationBox2.Text.ToString + "', Company = '" + CompanyBox4.Text.ToString + "', income = " + IncomeBox3.Text.ToString + ", password = '" + passwordBox7.Text.ToString + "', Phone = '" + PhoneBox1.Text.ToString + "' where Phone = '" + searchBox1.Text.ToString + "'")
        MsgBox("Updated!")
        fistnBox6.Text = "First"
        lastnBox1.Text = "Last"
        PhoneBox1.Clear()
        emailBox5.Clear()
        passwordBox7.Clear()
        IncomeBox3.Clear()
        OccupationBox2.Clear()
        CompanyBox4.Clear()
        searchBox1.Clear()

        TextBox8.Clear()
        BIDBox5.Clear()
        monthlyrateBox1.Clear()
        StartBox6.Clear()
        EndBox7.Clear()

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Updateinfo()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        ManagementOption.Show()

    End Sub

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click
        Updateinfo()
    End Sub

    Private Sub RectangleShape3_Click(sender As Object, e As EventArgs) Handles RectangleShape3.Click, RectangleShape1.Click, RectangleShape4.Click, RectangleShape2.Click
        Loadinfo()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        If searchBox1.Text = "" Then
            MsgBox("No Result!")
        Else
            ParkingChange.Show()

        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If searchBox1.Text = "" Then
            MsgBox("No Result!")
        Else
            If BIDBox5.Text = Main.Building.Text.ToString Then


                Dim intResult As Integer
                intResult = MessageBox.Show("Cancel the Lease?", "Waring", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)

                If intResult = DialogResult.OK Then
                    login.SQL.ExecQuery("update Unit set RentStatus = 'Vacant' where BID = " + Main.Building.Text.ToString + " and DoorNumber = ( select DoorNumber from Lease where BID = " + Main.Building.Text.ToString + " and TID = " + GroupBox1.Text.ToString + ")")

                    login.SQL.ExecQuery("delete from Lease where TID =" + GroupBox1.Text.ToString)

                    MsgBox("Canceled!")
                    Me.Close()
                    ManagementOption.Show()
                End If
            Else
                MsgBox("Belongs to Other Building!")
            End If
        End If
    End Sub

    Private Sub Note_Click(sender As Object, e As EventArgs) Handles Note.Click
        If IsNumeric(GroupBox1.Text) Then


            login.SQL.ExecQuery("Select Note from lease where BID = " + Main.Building.Text.ToString + " and TID = " + GroupBox1.Text.ToString)
            If login.SQL.DBDS.Tables(0).Rows.Count = 0 Then
                MsgBox("Not Fount")
            Else
                MsgBox(login.SQL.DBDS.Tables(0).Rows(0)(0).ToString)
            End If
        Else
            MsgBox("Nothing!")
        End If
    End Sub
End Class
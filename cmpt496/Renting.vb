Imports System.Text
Public Class Renting
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Main.Show()

    End Sub

    Private Sub Renting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'login.SQL.ExecQuery("select distinct Stalltype from Parking")
        'For i = 0 To login.SQL.DBDS.Tables(0).Rows.Count - 1
        '    parking.Items.Add(login.SQL.DBDS.Tables(0).Rows(i)(0).ToString)
        'Next
        login.SQL.ExecQuery("select DoorNumber, Unit.TypeID,BID,UnitType.Bedrooms, UnitType.Bathrooms,UnitType.Squarefeet,UnitType.Den,UnitType.Patio,UnitType.Price from Unit, UnitType 
                            where Unit.TypeID =UnitType.TypeID and Unit.BID = " + Main.Building.Text.ToString + " and Unit.RentStatus = 'Vacant'")
        ListBox1.DataSource = login.SQL.DBDS.Tables(0)
        ListBox1.DisplayMember = "DoorNumber"
        ListBox1.ValueMember = "TypeID"
        ListBox1.SelectedIndex = 0
        Bedroom.SelectedIndex = 0
        Bathroom.SelectedIndex = 0
        'doornumber.Text = ListBox1.SelectedValue.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        LoadList()
        'login.SQL.ExecQuery("select * from UnitType where TypeID = " + doornumber.Text.ToString)
        'price.Text = login.SQL.DBDS.Tables(0).Rows(0)(3).ToString()
    End Sub
    Private Sub LoadList()
        Dim Bedrooms, Bathrooms, Building As String
        If Bedroom.SelectedIndex = 0 Then
            Bedrooms = "UnitType.Bedrooms"
        Else
            Bedrooms = Bedroom.SelectedItem.ToString
        End If

        If Bathroom.SelectedIndex = 0 Then
            Bathrooms = "UnitType.Bathrooms"
        Else
            Bathrooms = Bathroom.SelectedItem.ToString
        End If

        If OtherBuild.Checked = True Then
            Building = "Unit.BID != " + Main.Building.Text.ToString
        Else
            Building = "Unit.BID = " + Main.Building.Text.ToString
        End If
        login.SQL.ExecQuery("select DoorNumber, Unit.TypeID,BID,UnitType.Bedrooms, UnitType.Bathrooms,UnitType.Squarefeet,UnitType.Den,UnitType.Patio,UnitType.Price from Unit, UnitType 
                            where Unit.TypeID =UnitType.TypeID and UnitType.Bedrooms = " + Bedrooms + " and UnitType.Bathrooms = " + Bathrooms + " and " + Building + " and Unit.RentStatus = 'Vacant'")
        ListBox1.DataSource = login.SQL.DBDS.Tables(0)
        ListBox1.DisplayMember = "DoorNumber"
        ListBox1.ValueMember = "TypeID"
        If ListBox1.Items.Count <> 0 Then
            ListBox1.SelectedIndex = 0
        Else
            price.Text = "_____"
            den.Text = "_____"
            BIDLabel.Text = "_____"
            bedroomLabel4.Text = "_____"
            bathroomLabel12.Text = "_____"
            sq.Text = "_____"
            patio.Text = "_____"
        End If
    End Sub

    'display all information for the selected unit number'
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'doornumber.Text = ListBox1.SelectedValue.ToString
        price.Text = login.SQL.DBDS.Tables(0).Rows(ListBox1.SelectedIndex)(8).ToString()
        den.Text = login.SQL.DBDS.Tables(0).Rows(ListBox1.SelectedIndex)(6).ToString()
        BIDLabel.Text = login.SQL.DBDS.Tables(0).Rows(ListBox1.SelectedIndex)(2).ToString()
        bedroomLabel4.Text = login.SQL.DBDS.Tables(0).Rows(ListBox1.SelectedIndex)(3).ToString()
        bathroomLabel12.Text = login.SQL.DBDS.Tables(0).Rows(ListBox1.SelectedIndex)(4).ToString()
        If login.SQL.DBDS.Tables(0).Rows(ListBox1.SelectedIndex)(7).ToString() = 0 Then
            patio.Text = "Yes"
        Else
            patio.Text = "No"
        End If
        sq.Text = login.SQL.DBDS.Tables(0).Rows(ListBox1.SelectedIndex)(5).ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        ContractForm.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Main.Show()
    End Sub

    ' add underline when mouse move on to label Map
    Private Sub Map_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Map.MouseEnter
        Dim LabelFont As Font = New Font(Map.Font.Name, Map.Font.Size, FontStyle.Underline)
        Map.Font.Dispose()
        Map.Font = LabelFont
    End Sub
    ' remove underline when mouse move on to label Map
    Private Sub Map_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Map.MouseLeave
        Dim LabelFont As Font = New Font(Map.Font.Name, Map.Font.Size, FontStyle.Regular)
        Map.Font.Dispose()
        Map.Font = LabelFont
    End Sub

    Private Sub Map_Click(sender As Object, e As EventArgs) Handles Map.Click
        Try
            Dim queryAddress As New StringBuilder
            queryAddress.Append("http://maps.google.com/maps?q=")
            If IsNumeric(BIDLabel.Text) Then
                login.SQL.ExecQuery("Select * from Building where BID = " + BIDLabel.Text)
                queryAddress.Append(login.SQL.DBDS.Tables(0).Rows(0)(2).ToString() + "," & "+")
                queryAddress.Append(login.SQL.DBDS.Tables(0).Rows(0)(1).ToString() + "," & "+ Edmonton")
            End If
            Mapform.Show()
            Mapform.WebBrowser1.Navigate(queryAddress.ToString)
        Catch ex As Exception
            MessageBox.Show("Unable to retrive data")
        End Try
    End Sub

    Private Sub cmdClose_Click()
        Me.Close()
        Main.Show()
    End Sub
End Class
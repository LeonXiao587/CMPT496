Imports System.IO
Imports System.Net

Public Class Room_view
    Dim Table As Object


    'Public Function PIC(Url)
    '    Dim url1 As String = Table.Rows(0)(1)
    '    Dim Http As HttpWebRequest = WebRequest.Create(url1)
    '    Dim Response As WebResponse = Http.GetResponse
    '    Dim Stream As Stream = Response.GetResponseStream()
    '    PictureBox1.Image = Image.FromStream(Stream)

    'End Function


    Private Sub Room_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.SQL.ExecQuery("select * from Unitpic")
        Table = login.SQL.DBDS.Tables(0)

        'Dim url As String = Table.Rows(0)(1)


        'Dim Http As HttpWebRequest = WebRequest.Create(url)
        'Dim Response As WebResponse = Http.GetResponse
        'Dim Stream As Stream = Response.GetResponseStream()

        'PictureBox1.Image = Image.FromStream(Stream)

        'For i = 0 To Table.Rows.Count
        '    Dim url As String = Table.Rows(i)(1)
        '    Dim Http As HttpWebRequest = WebRequest.Create(url)
        '    Dim Response As WebResponse = Http.GetResponse
        '    Dim Stream As Stream = Response.GetResponseStream()
        '    PictureBox1.Image = Image.FromStream(Stream)
        'Next

        ''url = Table.Rows(1)(1)
        ''PictureBox2.Image = Image.FromStream(Stream)

    End Sub



    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PictureBox1 = Nothing
        PictureBox2 = Nothing
        PictureBox3 = Nothing
        PictureBox4 = Nothing
        Me.Close()

        Main.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        PictureBox1 = Nothing
        PictureBox2 = Nothing
        PictureBox3 = Nothing
        PictureBox4 = Nothing
        Me.Close()
        ManagementOption.Show()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim url1 As String = Table.Rows(0)(1)

        Dim Http As HttpWebRequest = WebRequest.Create(url1)
        Dim Response As WebResponse = Http.GetResponse
        Dim Stream As Stream = Response.GetResponseStream()
        PictureBox1.Image = Image.FromStream(Stream)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim url2 As String = Table.Rows(1)(1)

        Dim Http As HttpWebRequest = WebRequest.Create(url2)
        Dim Response As WebResponse = Http.GetResponse
        Dim Stream As Stream = Response.GetResponseStream()
        PictureBox2.Image = Image.FromStream(Stream)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim url3 As String = Table.Rows(2)(1)

        Dim Http As HttpWebRequest = WebRequest.Create(url3)
        Dim Response As WebResponse = Http.GetResponse
        Dim Stream As Stream = Response.GetResponseStream()
        PictureBox3.Image = Image.FromStream(Stream)
    End Sub



    'Private Sub WebBrowser1_DocumentCompleted_1(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
    '    Dim Images As HtmlElementCollection = WebBrowser1.Document.Images
    '    For Each de As HtmlElement In Images
    '        If de.Id = "qrimage" Then
    '            Dim url As String = "http:" & Split(Split(de.OuterHtml, "src=" & Chr(34) & "")(1), """")(0)
    '            url = url.Replace("&amp;", "&")
    '            Dim Http As HttpWebRequest = WebRequest.Create(url)
    '            Dim Response As WebResponse = Http.GetResponse
    '            Dim Stream As Stream = Response.GetResponseStream()
    '            PictureBox1.Image = Image.FromStream(Stream)
    '        End If
    '    Next
    'End Sub
End Class
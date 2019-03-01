﻿Imports System.Data.SqlClient
Imports cmpt496

Public Class Sqlcon
    'DESKTOP-UUM78C3 Williams Desktop
    'DESKTOP-1NVLP4D  Leon Desktop
    '0O0              Yuhang's Desktop
    'DESKTOP-4M90S2P\LEONXIAO  leon laptop
    Private DBCon As New SqlConnection("Server=tcp:apamanagement.database.windows.net,1433;Initial Catalog=496;Persist Security Info=False;User ID=leonxiao;Password=CMPT496a;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
    Private DBCmd As SqlCommand
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable
    Public Params As New List(Of SqlParameter)
    Public RecordCount As Integer
    Public Exception As String
    Public DBDS As DataSet
    Public Sub New()
    End Sub
    Public Sub New(ConnectionString As String)
        DBCon = New SqlConnection(ConnectionString)
    End Sub

    Public Function HasConnection() As Boolean
        Try
            DBCon.Open()
            DBCon.Close()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Sub ExecQuery(Query As String)
        'reset query stats
        ' RecordCount = 0
        Try
            DBCon.Open()
            'database cmd
            DBCmd = New SqlCommand(Query, DBCon)
            'load param into db command
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))
            Params.Clear()
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            DBDS = New DataSet
            DBDA.Fill(DBDS)
            'RecordCount = DBDA.Fill(DBDT)
        Catch ex As Exception
            MsgBox(ex.Message)
            'close connection
            If DBCon.State = ConnectionState.Open Then
                DBCon.Close()
            End If
        Finally
            DBCon.Close()
        End Try
        'DBCon.Close()
    End Sub

    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    'Public Shared Widening Operator CType(v As Sqlcon) As Sqlcon
    'Throw New NotImplementedException()
    'End Operator
End Class

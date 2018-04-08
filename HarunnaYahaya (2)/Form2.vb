Imports System.Data.OleDb

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub con()
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HMB.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""")
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim dt1 As New DataTable
        Dim dt2 As New DataTable
        Dim dt3 As New DataTable

        cmd.Connection = conn
        conn.Open()
        Dim dtSheets As DataTable =
              conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
        Dim listSheet As New List(Of String)
        Dim drSheet As DataRow
        cmd.CommandType = CommandType.Text
        For Each drSheet In dtSheets.Rows
            listSheet.Add(drSheet("TABLE_NAME").ToString())
        Next
        MsgBox(Val(listSheet))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con()
    End Sub
End Class
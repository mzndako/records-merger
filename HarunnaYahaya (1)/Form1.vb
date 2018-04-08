Imports System.Data.OleDb
Imports Scripting

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub checkfoldes()
        Dim foldas As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        foldas = My.Computer.FileSystem.GetDirectories("c:\files")
        'For Each xc In foldas
        MsgBox(foldas.Count)
        ' Next

    End Sub
    Public Function FileCount(PathName As String) As Long
        Dim FSO As New FileSystemObject
        Dim fld As Folder
        '  PathName = 
        If FSO.FolderExists(PathName) Then
            fld = FSO.GetFolder(PathName)
            FileCount = fld.Files.Count
            MsgBox(FileCount.ToString)
        End If
    End Function
    Sub getnames()
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

        For Each drSheet In dtSheets.Rows
            listSheet.Add(drSheet("TABLE_NAME").ToString())
        Next

        'show sheetname in textbox where multiline is true
        For Each sheet As String In listSheet
            TextBox1.Text = TextBox1.Text & sheet & vbNewLine
        Next

        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'getnames()
        checkfoldes()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FileCount("c:\files\AIICO\")
    End Sub
End Class

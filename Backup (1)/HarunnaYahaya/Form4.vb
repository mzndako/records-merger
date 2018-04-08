Imports System.Data.OleDb

Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con()
    End Sub

    Public Sub con()
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HMB.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""")
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim dt1 As New DataTable
        Dim dt2 As New DataTable
        Dim dt3 As New DataTable

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        'sheet name is the name of your sheet
        cmd.CommandText = "select NAME,TOTAL from [a$]"
        da.SelectCommand = cmd
        da.Fill(dt1)

        'cmd.CommandText = "select * from [sheetname2$]"
        'da.SelectCommand = cmd
        'da.Fill(dt2)

        'cmd.CommandText = "select * from [sheetname3$]"
        'da.SelectCommand = cmd
        'da.Fill(dt3)

        DataGridView1.DataSource = dt1
        ' DataGridView2.DataSource = dt2
        ' DataGridView3.DataSource = dt3
    End Sub
End Class

Imports Excel
'Imports 
Imports System.Security
Imports System.Data.OleDb
Imports Microsoft.VisualBasic.ApplicationServices


Module dbcon
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HMB.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""")
    Public userisok As Boolean = False
    'userisok = false
    Public Sub connectnow()
        conn.Open()
    End Sub
   
End Module

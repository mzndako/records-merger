Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Text.RegularExpressions

Module Module1
    Class mytable
        Dim table As DataTable
        Dim list As Hashtable
        Dim listdou As Hashtable
        
        Public Function contains()
            Return ""
        End Function

        Private Function getDou(ByVal val As String) As ArrayList
            Try
                If Not list.Contains(val) Then
                    list.Add(val, New ArrayList)
                End If
            Catch ex As Exception

            End Try
            Return list(val)
        End Function

        Public Sub addRow(ByVal rw As DataRow, ByVal arr As String())
            Try
                For Each s In arr
                    Dim x As ArrayList = getDou(s)
                    If x.Contains(rw(s)) Then

                    End If
                Next
            Catch ex As Exception

            End Try
            table.Rows.Add(rw)
        End Sub

        Public ReadOnly Property columns As DataColumnCollection
            Get
                Return table.Columns
            End Get
        End Property

        Public Sub New()
            table = New DataTable
            list = New Hashtable
        End Sub


    End Class

    Dim x As mytable = New mytable


    Public Function getTable() As DataTable
        x.columns.Add("")

        Dim table As New DataTable
        table.Columns.Add("sn")
        table.Columns.Add("name")
        table.Columns.Add("pen")
        table.Columns.Add("psn")
        table.Columns.Add("cno")
        table.Columns.Add("pfa")
        table.Columns.Add("mdas")
        table.Columns.Add("2007")
        table.Columns.Add("2008")
        table.Columns.Add("2009")
        table.Columns.Add("2010")
        table.Columns.Add("2011")
        table.Columns.Add("2012")
        table.Columns.Add("2013")
        table.Columns.Add("2014")
        table.Columns.Add("total")
        table.Columns.Add("grp")
        Return table
    End Function

    Public Function getTable2() As DataTable
        x.columns.Add("")

        Dim table As New DataTable
        table.Columns.Add("sn")
        table.Columns.Add("name")
        table.Columns.Add("pen")
        table.Columns.Add("psn")
        table.Columns.Add("cno")
        table.Columns.Add("pfa")
        table.Columns.Add("mdas")
        table.Columns.Add("2007")
        table.Columns.Add("2008")
        table.Columns.Add("2009")
        table.Columns.Add("2010")
        table.Columns.Add("2011")
        table.Columns.Add("2012")
        table.Columns.Add("2013")
        table.Columns.Add("2014")
        table.Columns.Add("total")
        Return table
    End Function

    Public Sub startcon()
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|datadirectory|\dbase.mdb;")
        conn.Open()

    End Sub
    Sub changeLe(ByVal nm As DataTable)


    End Sub

    

    Public Sub setHeader(ByRef datagrid As DataGridView)
        For i = 0 To datagrid.Columns.Count - 1
            Dim head = datagrid.Columns(i).HeaderText

            Dim newhead = head.ToUpper
            If head = "sn" Then
                newhead = "S/N"
            End If

            If head = "cno" Then
                newhead = "Control No"
            End If

            If head = "grp" Then
                datagrid.Columns(i).Visible = False
            End If
            datagrid.Columns(i).HeaderText = newhead
        Next
        '        sortTable(datagrid)
    End Sub

    Public Sub sortTable(ByRef datagrid As DataGridView)
        For r = 0 To datagrid.RowCount - 1
            datagrid("sn", r).Value = r + 1
        Next
    End Sub

    Public Sub setHeader2(ByRef datagrid As DataGridView)
        For i = 0 To datagrid.Columns.Count - 1
            Dim head = datagrid.Columns(i).HeaderText

            Dim newhead = head.ToUpper
            If head = "sn" Then
                newhead = "S/N"
            End If

            If head = "cno" Then
                newhead = "Control No"
            End If

            If head = "grp" Then
                datagrid.Columns(i).Visible = False
            End If
            datagrid.Columns(i).HeaderText = newhead
        Next
        sortTable(datagrid)
    End Sub

    Public Sub sortTable2(ByRef datagrid As DataGridView)
        For r = 0 To datagrid.RowCount - 1
            datagrid(0, r).Value = r + 1
        Next
    End Sub


    Public Sub savedExcel(ByRef datagrid As DataGridView)
        Dim xlApp As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application
        'Dim xlApp As Microsoft.Office.Interop.Excel.Application = Microsoft.Office.Interop.Excel.Application.
        xlApp.SheetsInNewWorkbook = 1

        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Add
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet = xlWorkBook.Worksheets.Item(1)


        xlWorkSheet.Name = "mda"

        For nCol = 0 To datagrid.Columns.Count - 1
            Console.WriteLine(nCol & "=" & datagrid.Columns.Count)
            Console.WriteLine(datagrid.Columns(nCol).HeaderText & " ")
            xlWorkSheet.Cells(1, nCol + 1) = datagrid.Columns(nCol).HeaderText.ToUpper
            xlWorkSheet.Cells(1, nCol + 1).Font.Bold = True
        Next

        Dim file As SaveFileDialog = New SaveFileDialog
        file.Filter = "excel files (*.xlsx)|*.xlsx"
        file.RestoreDirectory = True
        Dim loc As String = ""

        If file.ShowDialog = DialogResult.OK Then
            loc = file.FileName
        Else
            Return
        End If


        For nRow = 0 To datagrid.Rows.Count - 1

            For nCol = 0 To datagrid.Columns.Count - 1
                xlWorkSheet.Cells(nRow + 2, nCol + 1) = datagrid.Rows(nRow).Cells(nCol).Value
            Next nCol

        Next nRow

        xlApp.DisplayAlerts = False

        

        Try


            xlWorkBook.SaveAs(loc, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, Type.Missing, Type.Missing, _
                               Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlLocalSessionChanges)

            xlWorkBook.Close()
            xlApp.Quit()

            MsgBox("Successfully Exported")
        Catch ex As Exception
            MsgBox("ERROR = " & ex.Message)
        End Try
    End Sub

    Public Sub savedExcelAll(ByVal hash As ArrayList, ByVal form As Form8, ByVal loc As String)
        Dim xlApp As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application

        xlApp.SheetsInNewWorkbook = 1
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Add

        For i = 0 To 3
            xlWorkBook.Worksheets.Add()
        Next


        Dim str As String() = {"Consolidated Records", "Duplicate Names", "Duplicate PEN", "Duplicate PSN", "Duplicate Control No"}
        Dim y = 0
        For lt = 0 To hash.Count - 1
            Dim key = str(lt)
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet = xlWorkBook.Worksheets.Item(lt + 1)

            xlWorkSheet.Columns.NumberFormat = "@"
            xlWorkSheet.Name = key
            Console.Write(key & "=" & (lt + 1))
            Dim table As DataTable = hash(lt)
            For nCol = 0 To table.Columns.Count - 1
                Dim head = table.Columns(nCol).ColumnName

                Dim newhead = head.ToUpper
                If head = "sn" Then
                    newhead = "S/N"
                End If
                If head = "cno" Then
                    newhead = "Control No"
                End If
                If head = "sn" Then
                    newhead = "S/N"
                End If
                If head = "cno" Then
                    newhead = "Control No"
                End If
                
                If head = "grp" Then
                    Continue For
                End If

                xlWorkSheet.Cells(1, nCol + 1) = newhead
                xlWorkSheet.Cells(1, nCol + 1).Font.Bold = True
            Next

            For nRow = 0 To table.Rows.Count - 1

                For nCol = 0 To table.Columns.Count - 1
                    Dim head = table.Columns(nCol).ColumnName
                    If head = "grp" Then
                        Continue For
                    End If
                    Try
                        xlWorkSheet.Cells(nRow + 2, nCol + 1) = table.Rows(nRow).Item(nCol).ToString
                    Catch ex As Exception
                    End Try
                Next nCol
                form.updateBar()
            Next nRow
        Next

        'xlApp.DisplayAlerts = False
        Try


            xlWorkBook.SaveAs(loc, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, Type.Missing, Type.Missing, _
                               Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlLocalSessionChanges)


            xlWorkBook.Close()
            xlApp.Quit()
            xlApp.Quit()
            xlApp.Quit()
            xlApp.Quit()
            xlApp.Quit()
            MsgBox("Successfully Exported")
            Process.Start("taskkill.exe", "/im excel.exe /f")
        Catch ex As Exception
            MsgBox("ERROR = " & ex.Message)
        End Try

    End Sub

    Public Sub savedExcelAll2(ByVal hash As ArrayList, ByVal form As Form8, ByVal loc As String)
        Dim xlApp As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application

        xlApp.SheetsInNewWorkbook = 1
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Add

        For i = 0 To hash.Count - 2
            xlWorkBook.Worksheets.Add()
        Next


        Dim str As String() = {"Consolidated Records", "Duplicate Names", "Duplicate PEN", "Duplicate PSN", "Duplicate Control No",
                               "Duplicate Within - PEN", "Duplicate Within - PSN", "Duplicate Within - Control No"}
        Dim y = 0
        For lt = 0 To hash.Count - 1
            Dim key = str(lt)
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet = xlWorkBook.Worksheets.Item(lt + 1)

            xlWorkSheet.Columns.NumberFormat = "@"
            xlWorkSheet.Name = key
            Console.Write(key & "=" & (lt + 1))
            Dim table As DataTable = hash(lt)
            For nCol = 0 To table.Columns.Count - 1
                Dim head = table.Columns(nCol).ColumnName

                Dim newhead = head.ToUpper
                If head = "sn" Then
                    newhead = "S/N"
                End If
                If head = "cno" Then
                    newhead = "Control No"
                End If
                If head = "sn" Then
                    newhead = "S/N"
                End If
                If head = "cno" Then
                    newhead = "Control No"
                End If

                If head = "grp" Then
                    Continue For
                End If

                xlWorkSheet.Cells(1, nCol + 1) = newhead
                xlWorkSheet.Cells(1, nCol + 1).Font.Bold = True
            Next

            For nRow = 0 To table.Rows.Count - 1

                For nCol = 0 To table.Columns.Count - 1
                    Dim head = table.Columns(nCol).ColumnName
                    If head = "grp" Then
                        Continue For
                    End If
                    Try
                        xlWorkSheet.Cells(nRow + 2, nCol + 1) = table.Rows(nRow).Item(nCol).ToString
                    Catch ex As Exception
                    End Try
                Next nCol
                form.updateBar()
            Next nRow
        Next

        'xlApp.DisplayAlerts = False
        Try


            xlWorkBook.SaveAs(loc, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, Type.Missing, Type.Missing, _
                               Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlLocalSessionChanges)


            xlWorkBook.Close()
            xlApp.Quit()
            xlApp.Quit()
            xlApp.Quit()
            xlApp.Quit()
            xlApp.Quit()
            MsgBox("Successfully Exported")
            Process.Start("taskkill.exe", "/im excel.exe /f")
        Catch ex As Exception
            MsgBox("ERROR = " & ex.Message)
        End Try

    End Sub

End Module

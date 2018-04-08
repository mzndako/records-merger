Imports System.IO
Imports Excel

Public Class Form9
    Dim filename() As String = Nothing
    Private Sub MergeRecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MergeRecordsToolStripMenuItem.Click
        Dim file As OpenFileDialog = New OpenFileDialog
        file.Filter = "Excel files (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls"
        file.RestoreDirectory = True
        file.Multiselect = True
        If file.ShowDialog = DialogResult.OK Then
            filename = file.FileNames
            showned = False
            Dim thread = New Threading.Thread(AddressOf startnow)
            thread.Start()
        Else
            Return
        End If
    End Sub

    Sub showform()
        form.ShowDialog()
        form.Timer1.Start()
    End Sub

    Dim tb = 0
    Dim form As Form8 = New Form8
    Dim str As String() = {"Consolidated Records", "Duplicate Names", "Duplicate PEN", "Duplicate PSN", "Duplicate Control No"}
    Dim mytableall() As DataTable = Nothing
    Sub startnow()
        form.start = 0
        form.tb = (filename.Count * 2) * str.Length
        mytableall = New DataTable() {getTable2(), getTable2(), getTable2(), getTable2(), getTable2()}
        Me.BeginInvoke(New MethodInvoker(AddressOf showform))

        Dim err As Boolean = False
        For Each wookbook In filename
            form.updateBar()
            Dim stream As FileStream = Nothing
            Try
                stream = File.Open(wookbook, FileMode.Open, FileAccess.Read)
            Catch ex As Exception
                MsgBox(ex.Message)
                GoTo endme
            End Try

            Dim excelReader As IExcelDataReader = ExcelReaderFactory.CreateOpenXmlReader(stream)

            excelReader.IsFirstRowAsColumnNames = True
            Dim result As DataSet = excelReader.AsDataSet()


            tb = result.Tables.Count
            For t = 0 To str.Length - 1
                Dim sheetname = str(t)
                Dim distable = mytableall(t)

                Dim table As DataTable = Nothing
                For x = 0 To result.Tables.Count - 1
                    Dim name As String = result.Tables(x).TableName
                    If name.ToLower = sheetname.ToLower Then
                        table = result.Tables(x)
                    End If
                Next


                If table Is Nothing Then
                    form.updateBar()
                    Continue For
                End If
                Try
                    For Each rw As DataRow In table.Rows
                        distable.Rows.Add(rw.ItemArray)
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                form.updateBar()

            Next
        Next
endme:
        Me.BeginInvoke(New MethodInvoker(AddressOf fillview))
    End Sub

    Sub fillview()
        DataGridView1.DataSource = mytableall(0)
        sortTable(DataGridView1)
        form.Hide()
        form.Timer1.Stop()
        sortTable2(DataGridView1)
    End Sub

    Private Sub PINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PINToolStripMenuItem.Click
        loadit(tablepen)
    End Sub

    Sub loadit(ByVal table As DataTable)
        minetb = table
        Form11.Show()
        prep()
        sortTable2(DataGridView1)
        shownow()
    End Sub

    Sub shownow()
        Form11.DataGridView1.DataSource = minetb
        form.Timer1.Stop()
        form.Hide()

    End Sub

    Dim minetb As DataTable = Nothing
    Dim tablecno As DataTable = getTable2()
    Dim tablepen As DataTable = getTable2()
    Dim tablepsn As DataTable = getTable2()
    Dim showned = False
    Sub prep()
        If Not showned Then
            Dim allcno As ArrayList = New ArrayList
            Dim allpen As ArrayList = New ArrayList
            Dim allpsn As ArrayList = New ArrayList
            Dim dcno As ArrayList = New ArrayList
            Dim dpen As ArrayList = New ArrayList
            Dim dpsn As ArrayList = New ArrayList

            Dim deletelist As ArrayList = New ArrayList

            For Each rw As DataRow In mytableall(0).Rows
                Dim cno = sq(rw("cno")).Trim
                Dim cpen = sq(rw("pen")).Trim
                Dim cpsn = sq(rw("psn")).Trim

                If cno <> "" Then
                    If allcno.Contains(cno) Then
                        dcno.Add(cno)
                    Else
                        allcno.Add(cno)
                    End If
                End If

                If cpen <> "" Then
                    If allpen.Contains(cpen) Then
                        dpen.Add(cpen)
                    Else
                        allpen.Add(cpen)
                    End If
                End If

                If cpsn <> "" Then
                    If allpsn.Contains(cpsn) Then
                        dpsn.Add(cpsn)
                    Else
                        allpsn.Add(cpsn)
                    End If
                End If
            Next

            For Each rw As DataRow In mytableall(0).Rows
                Dim cno = sq(rw("cno")).Trim
                Dim cpen = sq(rw("pen")).Trim
                Dim cpsn = sq(rw("psn")).Trim
                If cno <> "" Then
                    If dcno.Contains(cno) Then
                        tablecno.Rows.Add(rw.ItemArray)
                        deletelist.Add(rw)
                    End If
                End If

                If cpen <> "" Then
                    If dpen.Contains(cpen) Then
                        tablepen.Rows.Add(rw.ItemArray)
                        deletelist.Add(rw)
                    End If
                End If

                If cpsn <> "" Then
                    If dpsn.Contains(cpsn) Then
                        tablepsn.Rows.Add(rw.ItemArray)
                        deletelist.Add(rw)
                    End If
                End If
            Next

            For Each rw As DataRow In deletelist
                Try
                    mytableall(0).Rows.Remove(rw)
                Catch ex As Exception

                End Try
            Next



        End If
        showned = True
    End Sub

    Function sq(ByVal v As Object) As String
        If IsDBNull(v) Then
            Return ""
        End If
        Return v.ToString & ""
    End Function

    Private Sub PSNToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PSNToolStripMenuItem.Click
        loadit(tablepsn)
    End Sub

    Private Sub ControlNOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlNOToolStripMenuItem.Click
        loadit(tablecno)
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        savedExcel(DataGridView1)
    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 1
    End Sub

    Private Sub DataGridView1_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseClick
        sortTable2(DataGridView1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim table As DataTable = DataGridView1.DataSource
        mytableall(0).DefaultView.RowFilter = "pfa = '" & ComboBox1.SelectedItem & "'"

        'DataGridView1.DataSource = table
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        mytableall(0).DefaultView.RowFilter = ""
    End Sub

    Private Sub NamesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NamesToolStripMenuItem.Click
        setTable(mytableall(1))
    End Sub

    Sub setTable(ByVal table As DataTable)
        Form11.Show()
        Form11.DataGridView1.DataSource = table
    End Sub

    Private Sub PENToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PENToolStripMenuItem.Click
        setTable(mytableall(2))
    End Sub

    Private Sub PSNToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PSNToolStripMenuItem1.Click
        setTable(mytableall(3))
    End Sub

    Private Sub ControlNoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlNoToolStripMenuItem1.Click
        setTable(mytableall(4))
    End Sub

    Dim lloc = ""
    Private Sub ExportAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportAllToolStripMenuItem.Click
        form.start = 0
        form.Timer1.Start()
        Dim file As SaveFileDialog = New SaveFileDialog
        file.Filter = "excel files (*.xlsx)|*.xlsx"
        file.RestoreDirectory = True


        If file.ShowDialog = DialogResult.OK Then
            lloc = file.FileName
            form.Show()
            form.Timer1.Start()
            Dim thread = New Threading.Thread(AddressOf export)
            thread.Start()
        Else
            Return
        End If

    End Sub

    Sub export()
        Dim hash = New ArrayList
        Dim str As String() = {"Consolidated Records", "Duplicate Names", "Duplicate PEN", "Duplicate PSN", "Duplicate Control No"}
        hash.Add(mytableall(0))
        'hash.Add(unique)
        hash.Add(mytableall(1))
        hash.Add(mytableall(2))
        hash.Add(mytableall(3))
        hash.Add(mytableall(4))

        hash.Add(tablepen)
        hash.Add(tablepsn)
        hash.Add(tablecno)

        form.start = 0
        form.tb = mytableall(0).Rows.Count + mytableall(1).Rows.Count + mytableall(2).Rows.Count + mytableall(3).Rows.Count + mytableall(4).Rows.Count _
             + tablepen.Rows.Count + tablepsn.Rows.Count + tablecno.Rows.Count

        prep()
        savedExcelAll2(hash, form, lloc)

        Me.BeginInvoke(New MethodInvoker(AddressOf quitForm))
    End Sub

    Sub quitForm()
        form.quit()
    End Sub

End Class
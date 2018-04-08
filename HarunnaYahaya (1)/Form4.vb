Imports System.Data.OleDb
Imports System.IO
Imports System.Text.RegularExpressions
'Imports Microsoft.Office.Interop.Excel
Imports Excel
Imports HarunnaYahaya.Form8

'dim xsheet As New Excel.
Public Class Form4

    Dim filename = ""
    Dim altmda As String = ""
    Public pfa As String = ""
    Public meth As Integer = 1
    Private Sub refreshMe()
        mydoubles = {getTable(), getTable(), getTable(), getTable()}
        table = getTable()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'con()
        refreshMe()
        Dim file As OpenFileDialog = New OpenFileDialog
        file.Filter = "Excel files (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls"
        file.RestoreDirectory = True

        If file.ShowDialog = DialogResult.OK Then
            filename = file.FileName
            altmda = file.SafeFileName
            altmda = altmda.Substring(0, altmda.Length - 5)
            Dim thread = New Threading.Thread(AddressOf startnow)
            thread.Start()
        Else
            Return
        End If

        
    End Sub



    Function excape(ByVal text As String) As String
        Return text.Replace("'", "''")
    End Function

    Sub startnow()
        If meth = 1 Then
            runme()
        Else
            runme2()
        End If

    End Sub

    Dim form As Form8 = New Form8()
    Sub fillview()
        DataGridView1.DataSource = table
        form.Timer1.Stop()
        form.Hide()
        setHeader(DataGridView1)
    End Sub

    Dim cmda() As String = {"mdas", "mda"}
    Dim cpen() As String = {"pen", "rsa pin", "pin", "rsa pin number"}
    Dim cpsn() As String = {"psn"}
    Dim ccno() As String = {"id", "control", "i.d", "cno", "control id", "control_no", "c/no", "code", "staf i.d"}
    Dim ctotal() As String = {"total", "total_contribution"}

    Function iscFound(ByVal value As String) As Integer()
        Dim isf As Integer() = {-1, -1, -1, -1}
        For i = 0 To 3
            isf(i) = search(value, cno(i))
        Next
        Return isf
    End Function


    Dim cno As Integer() = {}
    Dim cname As String() = {}
    ReadOnly equavalentcname As String() = {"cno", "pen", "psn", "name"}
    Dim tt As New DataTable
    Dim mydoubles() As Object = {getTable(), getTable(), getTable(), getTable()} 'name=4 pen=1 psn=2
    Dim doublen As DataTable = getTable()
    Dim doublepsn As DataTable = getTable()
    Dim doublepen As DataTable = getTable()

    Dim unique As DataTable = getTable()


    Function sq(ByVal v As Object) As String
        If IsDBNull(v) Then
            Return ""
        End If
        Return v.ToString & ""
    End Function


    Function count() As Object()
        Dim repeated = {New List(Of String), New List(Of String), New List(Of String), New List(Of String)} '"cno", "pen", "psn", realname
        Dim dd = {New List(Of String), New List(Of String), New List(Of String), New List(Of String)} '"cno", "pen", "psn", "name"
        Dim c = 0

        For Each rw In tt.Rows
            Dim cmn = sq(rw(realname)).ToString.Trim
            If cmn = "" Then
                Continue For
            End If

            Dim mycno = ""
            If cname(0) <> "" Then
                mycno = sq(rw(cname(0))).ToString.Trim
            End If

            Dim mypen = ""
            If cname(1) <> "" Then
                mypen = sq(rw(cname(1))).ToString.Trim
            End If

            Dim mypsn = ""
            If cname(2) <> "" Then
                mypsn = sq(rw(cname(2))).ToString.Trim
            End If

            If mycno <> "" Then
                If dd(0).Contains(mycno) Then
                    repeated(0).Add(mycno)
                Else
                    dd(0).Add(mycno)
                End If
            End If

            If mypen <> "" Then
                If dd(1).Contains(mypen) Then
                    repeated(1).Add(mypen)
                Else
                    dd(1).Add(mypen)
                End If
            End If

            If mypsn <> "" Then
                If dd(2).Contains(mypsn) Then
                    repeated(2).Add(mypsn)
                Else
                    dd(2).Add(mypsn)
                End If
            End If

            If cmn <> "" Then
                If dd(3).Contains(cmn) Then
                    repeated(3).Add(cmn)
                Else
                    dd(3).Add(cmn)
                End If
            End If
        Next

        Return repeated
        Console.WriteLine(repeated(0).Count & ">>>>>>>>>>>>>>>>>>>>>>>")
    End Function

    Dim grp As ArrayList = New ArrayList
    Function getgrp() As String
        Dim x = grp.Count
        Dim y = "" & (x + 1)
        grp.Add(y)

        Return (y)
    End Function

    Dim repeated As Object() = {New List(Of String), New List(Of String), New List(Of String)} 'name pen psn
    Dim mda As String = ""
    Dim err As String = ""
    Sub combine()
        'Dim mydoublesv As Object() = {New List(Of String), New List(Of String), New List(Of String), New List(Of String), New List(Of String)}
        Dim alldoubles As List(Of String) = New List(Of String)

        Dim match = Regex.Replace(tt.TableName, "[a-zA-Z'$,#]", "")
        match = match.Replace("-", "")
        match = match.Replace(".", "")
        Dim yr As Integer = Val(match.Trim())
        'Console.WriteLine(tt.TableName & " = " & yr)
        If yr.ToString.Trim.Length <> 4 Then
            err = "The sheet name does not contain a valid year at Sheet: " & tt.TableName
            Throw New ApplicationException(err)
        End If

        cname = getAvailableC()
        If realname = "" Then
            Throw New ApplicationException("This sheet does not contain the correct name heading = " & tt.TableName)
        End If

        repeated = count()

        'For i = 0 To tt.Columns.Count - 1
        'Console.WriteLine("colouns = " & tt.Columns(i).ColumnName & "=" & tt.TableName)
        'Next


        Dim thisgrp = getgrp()
        For i = 0 To tt.Rows.Count - 1
over:
            Dim rw As DataRow = tt.Rows(i)
            Dim ucol = ""
            Dim ecol = -1
            Dim nnn = 0

            Dim cmn = sq(rw(realname)).ToString.Trim
            If cmn = "" Then
                Continue For
            End If



            Dim mycno = ""
            If cname(0) <> "" Then
                mycno = sq(rw(cname(0))).ToString.Trim
            End If

            Dim mypen = ""
            If cname(1) <> "" Then
                mypen = sq(rw(cname(1))).ToString.Trim
            End If

            Dim mypsn = ""
            If cname(2) <> "" Then
                mypsn = sq(rw(cname(2))).ToString.Trim
            End If

            

            Dim isd = False, stilladd = False
            Dim duplicateexit = False
            Dim rep As List(Of String) = repeated(3)
            Dim isdoblename = False
            Dim skip = False

            If rep.Contains(cmn) Then
                Dim contin = False
                'Console.WriteLine("double name" & cmn & mypen & mycno & mypsn)

                If mycno <> "" Then
                    contin = True
                End If

                If mypsn <> "" Then
                    contin = True
                End If

                If mypen <> "" Then
                    contin = True
                End If
                If contin Then
                    GoTo contn
                End If

doublename:
                Dim newrw = mydoubles(3).NewRow
                newrw("name") = cmn
                newrw("cno") = mycno
                newrw("pen") = mypen
                newrw("psn") = mypsn
                newrw.Item("sn") = tt.TableName
                newrw.Item("mdas") = getMDA(rw)
                newrw.Item("grp") = thisgrp
                newrw.Item("pfa") = pfa
                newrw.Item(yr.ToString) = sq(getTotal(rw))
                newrw.Item("total") = sq(getTotal(rw))
                newrw.Item("grp") = tt.TableName
                mydoubles(3).Rows.Add(newrw)

                If skip Then
                    Continue For
                End If
contn:
                If Not contin Then
                    duplicateexit = True
                Else
                    isdoblename = True
                End If

            End If

continexit:
            For r = 0 To 2
                rep = repeated(r)
                Dim sh As String = mycno
                If r = 1 Then
                    sh = mypen
                ElseIf r = 2 Then
                    sh = mypsn
                End If

                If sh.Trim = "" Then
                    Continue For
                End If

                If rep.Contains(sh) Then
                    Dim newrw = mydoubles(r).NewRow
                    newrw("cno") = mycno
                    newrw("name") = cmn
                    newrw("pen") = mypen
                    newrw("psn") = mypsn
                    newrw.Item("sn") = tt.TableName
                    newrw.Item("mdas") = getMDA(rw)
                    newrw.Item("grp") = thisgrp
                    newrw.Item("pfa") = pfa
                    newrw.Item("grp") = tt.TableName
                    newrw.Item("total") = sq(getTotal(rw))
                    newrw.Item(yr.ToString) = sq(getTotal(rw))
                    mydoubles(r).Rows.Add(newrw)
                    duplicateexit = True
                End If
            Next


            If duplicateexit Then
                Continue For
            End If

            If isdoblename Then
                skip = True
                GoTo doublename
            End If

addtable:


            Dim isdouble = False
            For n = nnn To cname.Length - 1
                If cname(n) <> "" Then
                    Dim vv = sq(cname(n)).Trim
                    If vv <> "" Then
                        ucol = cname(n)
                        ecol = n
                        nnn = n
                        nnn += 1
                        Exit For
                    End If
                End If
            Next

startagain:
            '   Console.Write(ucol & "  ====================  " & ecol)
            Dim foundn = -1
            Try
                If ecol <> -1 Then
                    foundn = search(sq(rw(ucol)), equavalentcname(ecol))
                End If

            Catch ex As Exception
                Console.WriteLine("MY NULL ----------- " & ex.Message)
                Continue For
            End Try


            nnn += 1
            If foundn > -1 Then
                Try
                    Dim yesdouble = False
                    If isdouble And ucol = "name" Then
                        GoTo cont
                    End If

                    Console.WriteLine()
                    Console.WriteLine(tt.TableName)
                    For n = 0 To cname.Length - 1

                        If cname(n) <> "" Then
                            Dim vt = table.Rows(foundn).Item(equavalentcname(n)).ToString.Trim
                            Dim vr = sq(rw(cname(n))).ToString.Trim
                            If vt.Length = 0 Then
                                table.Rows(foundn).Item(equavalentcname(n)) = sq(rw(cname(n)))
                                'Console.WriteLine(String.Format("equ={0}|cname={1}|v real table={2}|tt={3}|n={4}", equavalentcname(n),
                                ' cname(n), vt, vr, n))
                                '            unique.Rows(foundn).Item(equavalentcname(n)) = sq(rw(cname(n)))
                            End If
                        End If
                    Next

                    If yesdouble Then
                        GoTo cont
                    End If

                    Dim ft As Double = Val(table.Rows(foundn).Item(yr.ToString).ToString)
                    Dim ftt As Double = Val(table.Rows(foundn).Item("total").ToString)
                    Dim vv As Double = Val(getTotal(rw))
                    Dim nt As Double = vv + ft
                    Dim ntt As Double = ftt + vv
                    'Console.WriteLine(nt & " == " & ft & "-----------------------")
                    table.Rows(foundn).Item(yr.ToString) = nt
                    table.Rows(foundn).Item("total") = ntt


                    'unique.Rows(foundn).Item(yr.ToString) = nt
                    'unique.Rows(foundn).Item("total") = ntt


                    Dim m = table.Rows(foundn).Item("mdas").ToString.Trim

                    If m = "" Then
                        table.Rows(foundn).Item("mdas") = getMDA(rw)
                        'unique.Rows(foundn).Item("mdas") = getMDA(rw)
                    End If

                    'table.Rows(foundn).Item("pin") = foundn

                Catch ee As Exception
                    MsgBox(ee.Message)
                End Try
            Else
                If ecol = -1 Then
                    GoTo cont
                End If

                isdouble = False
                For n = nnn To cname.Length - 1
                    If cname(n) <> "" Then
                        Dim vv = sq(cname(n)).Trim
                        If vv <> "" Then
                            ucol = cname(n)
                            ecol = n
                            nnn = n
                            nnn += 1
                            GoTo startagain
                        End If
                    End If
                Next

cont:
                Try
                    Dim newrw = table.NewRow
                    For n = 0 To cname.Length - 1
                        If cname(n) <> "" Then
                            newrw.Item(equavalentcname(n)) = sq(rw(cname(n)))
                        End If
                    Next
                    'newrw.Item("pin") = find("pin", rw)
                    newrw.Item("sn") = table.Rows.Count + 1

                    Dim tt = getTotal(rw)
                    newrw.Item(yr.ToString) = tt
                    newrw.Item("total") = tt
                    Dim mmddaa = getMDA(rw)
                    newrw.Item("mdas") = mmddaa
                    newrw.Item("pfa") = pfa
                    table.Rows.Add(newrw)

                    ' unique.Rows.Add(newrw.ItemArray)
                Catch ee As Exception
                    MsgBox(ee.Message)
                End Try

            End If

        Next

    End Sub

    Dim doublearrears As DataTable = getTable()
    Sub getarrears(ByVal tables As DataTableCollection, ByVal arrears As ArrayList)
        Dim deletelist As Hashtable = New Hashtable()

        For Each ar As List(Of String) In arrears
            Dim table As DataTable = getTable()
            Dim tset = True

            For Each tbn As String In ar
                Dim tt As DataTable = tables(tbn)
                Dim match = Regex.Replace(tt.TableName, "[a-zA-Z'$,#]", "")
                match = match.Replace("-", "")
                match = match.Replace(".", "")
                Dim yr As Integer = Val(match.Trim())
                Dim cname() As String = getAvailableC(tt)

                For Each rw In tt.Rows
                    Dim nnn = 0
                    Dim ucol = ""
                    Dim ecol = -1
                    ' Console.WriteLine(rw("name") & "========" & tset)
                    If tset Then
                        GoTo cont
                    End If

startagain:
                    For n = nnn To cname.Length - 1
                        If cname(n) <> "" Then
                            Dim vv = sq(cname(n)).Trim
                            If vv <> "" Then
                                ucol = cname(n)
                                ecol = n
                                nnn = n
                                nnn += 1
                                Exit For
                            End If
                        End If
                    Next
                    Dim found = -1
                    Try
                        If ecol <> -1 Then
                            found = search(sq(rw(ucol)), equavalentcname(ecol), table)
                        End If
                    Catch ex As Exception

                    End Try

                    If found > -1 Then
cont:
                        Dim newrw = doublearrears.NewRow

                        If tset Then
                            newrw = table.NewRow
                        End If

                        For n = 0 To cname.Length - 1
                            If cname(n) <> "" Then
                                newrw.Item(equavalentcname(n)) = sq(rw(cname(n)))
                            End If
                        Next

                        newrw.Item("sn") = table.Rows.Count + 1
                        Dim total = getTotal(rw)
                        newrw.Item(yr.ToString) = total
                        newrw.Item("total") = total

                        Dim mmddaa = getMDA(rw)
                        newrw.Item("mdas") = mmddaa

                        If tset Then
                            table.Rows.Add(newrw)
                        Else
                            Dim newrw2 = doublearrears.NewRow
                            For col = 0 To table.Columns.Count - 1
                                newrw2.Item(col) = sq(table.Rows(found).Item(col))
                            Next
                            doublearrears.Rows.Add(newrw)
                            doublearrears.Rows.Add(newrw2)
                            'tt.Rows.Remove(rw)

                        End If
                    Else

                        For n = nnn To cname.Length - 1
                            If cname(n) <> "" Then
                                Dim vv = sq(cname(n)).Trim
                                If vv <> "" Then
                                    ucol = cname(n)
                                    ecol = n
                                    nnn = n
                                    nnn += 1
                                    GoTo startagain
                                End If
                            End If
                        Next

                    End If

                Next
                tset = False
            Next
        Next

        For Each rw As DataRow In deletelist.Keys
            Dim table As DataTable = deletelist(rw)
            '    Console.WriteLine(sq(rw("name")) & "=" & table.TableName)
            table.Rows.Remove(rw)
        Next
    End Sub

    Function getMDA(ByVal rw As DataRow)
        If mda <> "" Then
            Return sq(rw(mda))
        End If
        Return altmda
    End Function

    Function showrtostring(ByVal rw As DataRow)
        Dim x = ""
        For i = 0 To rw.Table.Columns.Count - 1
            x &= "  NEXT-" & rw.Table.Columns(i).ColumnName & "=" & rw.Item(i).ToString & "==" & rw.Item(i).GetType().FullName
        Next
        Return x
    End Function

    Dim showned = False
    Dim deleteRows As ArrayList = New ArrayList
    Sub finalizetable()
        If Not showned Then
            'Me.BeginInvoke(New MethodInvoker(AddressOf showform))
            Dim allcno As ArrayList = New ArrayList
            Dim allpen As ArrayList = New ArrayList
            Dim allpsn As ArrayList = New ArrayList
            Dim dcno As ArrayList = New ArrayList
            Dim dpen As ArrayList = New ArrayList
            Dim dpsn As ArrayList = New ArrayList
            deleteRows.Clear()

            For Each rw As DataRow In table.Rows
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
                'form.updateBar()
            Next

            For Each rw As DataRow In table.Rows
                Dim cno = sq(rw("cno")).Trim
                Dim cpen = sq(rw("pen")).Trim
                Dim cpsn = sq(rw("psn")).Trim
                If cno <> "" Then
                    If dcno.Contains(cno) Then
                        add2delete(rw)
                        mydoubles(0).Rows.Add(rw.ItemArray)
                    End If
                End If

                If cpen <> "" Then
                    If dpen.Contains(cpen) Then
                        add2delete(rw)
                        mydoubles(1).Rows.Add(rw.ItemArray)
                    End If
                End If

                If cpsn <> "" Then
                    If dpsn.Contains(cpsn) Then
                        add2delete(rw)
                        mydoubles(2).Rows.Add(rw.ItemArray)
                    End If
                End If
                'form.updateBar()
            Next

            For Each rw As DataRow In deleteRows
                table.Rows.Remove(rw)
            Next

        End If

    End Sub

    Sub add2delete(ByRef rw As DataRow)

        rw("sn") = 0
        If Not deleteRows.Contains(rw) Then
            deleteRows.Add(rw)
        End If
    End Sub

    Function getTotal(ByVal rw As DataRow) As String
        For i = 0 To ctotal.Length - 1
            Dim x = ctotal(i)
            Try
                If tt.Columns.Contains(ctotal(i)) Then
                    Dim y = sq(rw(ctotal(i))).ToString.Trim
                    If y.Length <> 0 Then
                        Return y.Trim.Replace(",", "")
                    End If
                End If
            Catch ex As Exception

            End Try
        Next
        Return ""
    End Function

    Dim realname = ""
    Function getAvailableC(ByVal tt As DataTable) As String()
        Dim no = {"", "", "", "name"}
        mda = ""
        realname = ""

        Dim col As ArrayList = New ArrayList
        For r = 0 To tt.Columns.Count - 1
            tt.Columns(r).ColumnName = tt.Columns(r).ColumnName.ToString.Trim.ToLower
            col.Add(tt.Columns(r).ColumnName.ToString)
        Next

        For i = 0 To 2
            Dim sh() As String = {}
            If i = 0 Then
                sh = ccno
            ElseIf i = 1 Then
                sh = cpen
            ElseIf i = 2 Then
                sh = cpsn
            End If

            For Each s In sh
                If col.Contains(s) Then
                    no(i) = s
                    Exit For
                End If
            Next

        Next

        For Each m In cmda
            If col.Contains(m) Then
                mda = m
            End If

        Next


        If col.Contains("name") Then
            realname = "name"
        ElseIf col.Contains("names") Then
            realname = "names"
        End If
        no(3) = realname
        Return no
    End Function

    Function getcolumnNo(ByVal tt As DataTable) As Integer()
        Dim no = {-1, -1, -1, -1}

        For i = 0 To 2
            Dim sh() As String = {}
            If i = 1 Then

            ElseIf i = 2 Then
                sh = cpen
            ElseIf i = 3 Then
                sh = cpsn
            ElseIf i = 4 Then
                sh = ccno
            End If

            For Each s In sh
                Dim v = findcolumn(s, tt)
                If v > -1 Then
                    no(i) = v
                    Exit For
                End If
            Next
        Next
        Return no
    End Function

    Function getColumnNo()
        Return getColumnNo(tt)
    End Function

    Function getAvailableC()
        Return getAvailableC(tt)
    End Function


    Function findcolumn(ByVal name As String, ByVal tt As DataTable) As Integer
        For i = 0 To tt.Columns.Count - 1
            If name.ToLower = tt.Columns(i).ToString.Trim.ToLower Then
                Return i
            End If
        Next
        Return -1
    End Function

    Function find(ByVal what As String, ByVal rw As DataRow) As String
        Return ""
    End Function

    Function search(ByVal what As String, ByVal where As Integer) As Integer
        If where = -1 Then
            Return -1
        End If
        Return search(what, tt.Columns(where).ColumnName)
    End Function

    Function search(ByVal what As String, ByVal where As String, ByVal table As DataTable) As Integer
        Try
            If what.Trim.Length = 0 Then
                Return -1
            End If
            For i = 0 To table.Rows.Count - 1
                Dim x = table.Rows(i).Item(where).ToString.Trim
                If x.ToLower = what.ToLower.Trim Then
                    ' Console.WriteLine("found" & where & "==" & what & "==" & table.Rows(i).Item("name"))
                    Return i
                End If
            Next
        Catch ex As Exception

        End Try
        'Console.WriteLine("NOT FOUND" & where & "==" & what)
        Return -1
    End Function

    Function search(ByVal what As String, ByVal where As String) As Integer
        Return search(what, where, table)
    End Function


    Dim cont = 1
    Public table As DataTable = getTable()
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

        For Each drSheet In dtSheets.Rows
            listSheet.Add(drSheet("TABLE_NAME").ToString())
        Next

        cmd.CommandType = CommandType.Text
        'sheet name is the name of your sheet

        'MsgBox(listSheet.Count)
        Dim y = 0

        For Each xx In listSheet
            If y = 5 Then
                Exit For
            End If
            xx = "'JULY - DEC# 2008$'"
            cmd.CommandText = "select * from [" & xx & "]"
            'Console.Write(cmd.CommandText)
            ' MsgBox(cmd.CommandText)
            da.SelectCommand = cmd
            tt = New DataTable
            tt.Columns.Add("PIN")
            tt.Columns.Add("mz")
            tt.Columns("PIN").DataType = System.Type.GetType("System.String")

            da.Fill(tt)
            tt.TableName = xx

            DataGridView1.DataSource = tt
            'MsgBox(tt.Rows.Count & tt.TableName)

            Return
            Try
                combine()
            Catch ex As Exception
                MsgBox(ex.Message)
                Console.WriteLine(ex.Message & " main error........")
            End Try
            y += 1
            cont += 1

        Next


        Dim dtDistinct As DataTable = table.Clone
        Dim dtDuplicates As DataTable = table.Clone

        'For Each dr As DataRow In table.Rows
        'Dim m = excape(dr("name"))
        'CountOfRows = table.Compute("Count(name)", "name = '" & m & "'")
        'If CountOfRows > 1 Then
        'dtDuplicates.Rows.Add(dr.ItemArray)
        'Else
        'dtDistinct.Rows.Add(dr.ItemArray)
        'End If
        'Next
        'MsgBox(cmd.CommandText)
        'cmd.CommandText = "SELECT * FROM [a$]"

        'MsgBox(dt1.Columns.ToString)
        'cmd.CommandText = "select * from [sheetname2$]"
        'da.SelectCommand = cmd
        'da.Fill(dt2)

        'cmd.CommandText = "select * from [sheetname3$]"
        'da.SelectCommand = cmd
        'da.Fill(dt3)

        DataGridView1.DataSource = table
        ' DataGridView2.DataSource = dt2
        ' DataGridView3.DataSource = dt3
    End Sub




    Sub runmeagain()
        runme()
    End Sub


    Sub showform()
        form.ShowDialog()
    End Sub

    Dim starty = 1
    Sub updateBar()
        Dim x As Double = Val(starty)
        Dim y As Double = Val(tb)
        Dim t As Double = (x / y) * 100

        Dim yy As Integer = Val(t)
        If yy > 100 Then
            yy = 100
        End If
        'Console.WriteLine("ttt=" & x & "/" & y & "=" & t & " = " & yy & " --" & Form8.start)
        form.start = yy
        starty += 1
    End Sub

    Dim tb = 0


    Sub runme()
        Me.BeginInvoke(New MethodInvoker(AddressOf showform))
        'Dim shetname As 
        Dim stream As FileStream = Nothing
        Try

            stream = File.Open(filename, FileMode.Open, FileAccess.Read)

        Catch ex As Exception
            MsgBox(ex.Message)
            GoTo endme
        End Try

        'Dim stream As FileStream = File.Open("C:\PEN ASG\trustfund\STATE (JANUARY-APRIL 2014).xlsx", FileMode.Open, FileAccess.Read)

        '1. Reading from a binary Excel file '97-2003 format; *.xls)
        Dim excelReader As IExcelDataReader = Nothing
        If Not filename.ToString.EndsWith(".xlsx") Then
            'MsgBox("2003")
            excelReader = ExcelReaderFactory.CreateBinaryReader(stream)
        Else
            'MsgBox("2007")
            excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream)
        End If

        '...
        '2. Reading from a OpenXml Excel file (2007 format; *.xlsx)




        '...
        ' excelReader.JULY - DEC. 200
        '3. DataSet - The result of each spreadsheet will be created in the result.Tables
        excelReader.IsFirstRowAsColumnNames = True
        Dim result As DataSet = excelReader.AsDataSet()


        '...
        '4. DataSet - Create column names from first row
        ' For Each

        'Dim result As DataSet = excelReader.AsDataSet()

        Dim arrears As ArrayList = New ArrayList
        Dim darrs As ArrayList = New ArrayList
        tb = result.Tables.Count
        Try
            For x = 0 To tb - 1
                Dim name As String = result.Tables(x).TableName
                If name.ToLower.IndexOf("arrear") > -1 Or name.ToLower.IndexOf("supplementary") > -1 Then
                    arrears.Add(name)
                End If
            Next

            For Each arr In arrears
                Dim xx As List(Of String) = New List(Of String)

                Dim index = 0
                If arr.tolower.indexof("arrear") > -1 Then
                    index = arr.indexof("arrear")
                Else
                    index = arr.indexof("supplementary")
                End If

                If index = -1 Then
                    Continue For
                End If

                Dim aa = arr.ToString.Substring(0, index).Trim.Replace(".", "").Replace("-", "").Replace(",", "").Replace(" ", "")
                'Console.WriteLine(aa)

                For x = 0 To tb - 1
                    Dim name As String = result.Tables(x).TableName
                    Dim bb = name.Trim.Replace(".", "").Replace("-", "").Replace(",", "").Replace(" ", "")
                    If aa.ToLower = bb.ToLower Then
                        xx.Add(name)
                    End If
                Next
                If xx.Count > 0 Then
                    xx.Add(arr)
                End If
                darrs.Add(xx)
            Next
            getarrears(result.Tables, darrs)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



        For x = 0 To result.Tables.Count - 1
            If x = 2 Then
                'Exit For
            End If

            updateBar()
            Console.WriteLine(result.Tables(x).TableName & " == " & x & " = " & result.Tables.Count)
            tt = result.Tables(x)
            Try
                '   Console.WriteLine(result.Tables(x).TableName)
                combine()
            Catch ex As Exception
                Dim a = MsgBox(ex.Message & vbNewLine & "Do you want to continue?", MsgBoxStyle.YesNo, "Error")
                If a = MsgBoxResult.No Then
                    Exit For
                End If
                Console.WriteLine(ex.Message & " main error........")
            End Try
            'x += 1
            'Exit For
        Next
        FinalizeTable()
endme:
        Me.BeginInvoke(New MethodInvoker(AddressOf fillview))


        '5. Data Reader methods sup arrear
        'While excelReader.Read()
        'excelReader.GetInt32(0);
        'MsgBox(excelReader.GetString(0))
        'MsgBox(excelReader.GetString(1))
        '        End While

        '6. Free resources (IExcelDataReader is IDisposable)
        ';excelReader.Close()

    End Sub


    Sub runme2()
        Me.BeginInvoke(New MethodInvoker(AddressOf showform))
        'Dim shetname As 
        Dim stream As FileStream = Nothing
        Try

            stream = File.Open(filename, FileMode.Open, FileAccess.Read)
            Dim excelReader As IExcelDataReader = Nothing
            If Not filename.ToString.EndsWith(".xlsx") Then
                'MsgBox("2003")
                excelReader = ExcelReaderFactory.CreateBinaryReader(stream)
            Else
                'MsgBox("2007")
                excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream)
            End If

            excelReader.IsFirstRowAsColumnNames = True
            Dim result As DataSet = excelReader.AsDataSet()


            tb = result.Tables.Count
            Dim str As String() = {"Consolidated Records", "Duplicate Names", "Duplicate PEN", "Duplicate PSN", "Duplicate Control No"}
            For Each ttab As DataTable In result.Tables
                If ttab.TableName = "Consolidated Records" Then
                    table = ttab
                End If

                If ttab.TableName = "Duplicate Names" Then
                    mydoubles(3) = ttab
                End If

                If ttab.TableName = "Duplicate PEN" Then
                    mydoubles(1) = ttab
                End If

                If ttab.TableName = "Duplicate PSN" Then
                    mydoubles(2) = ttab
                End If

                If ttab.TableName = "Duplicate Control No" Then
                    mydoubles(0) = ttab
                End If

                For i = 0 To ttab.Columns.Count - 1
                    If ttab.Columns(i).ColumnName = "Control No" Then
                        ttab.Columns(i).ColumnName = "cno"
                        ttab.Columns(i).Caption = "Control No"
                    End If

                    If ttab.Columns(i).ColumnName = "S/N" Then
                        ttab.Columns(i).ColumnName = "sn"
                        ttab.Columns(i).Caption = "S/N"
                    End If
                Next

            Next

            'table = result.Tables(0)
            'Console.WriteLine(result.Tables(0).TableName)
            'mydoubles(3) = result.Tables(1)
            'Console.WriteLine(result.Tables(1).TableName)
            'mydoubles(1) = result.Tables(2)
            'Console.WriteLine(result.Tables(2).TableName)
            'mydoubles(2) = result.Tables(3)
            'Console.WriteLine(result.Tables(3).TableName)
            'Console.WriteLine(result.Tables(4).TableName)
            'mydoubles(0) = result.Tables(4)
            'Console.WriteLine(result.Tables(4).TableName)


            finalizetable()
        Catch ex As Exception
            MsgBox(ex.Message)
            GoTo endme
        End Try

        
endme:
        Me.BeginInvoke(New MethodInvoker(AddressOf fillview))

    End Sub


    Sub runme3()
        Me.BeginInvoke(New MethodInvoker(AddressOf showform))
        'Dim shetname As 
        Dim xlApp As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application
        'Dim xlApp As Microsoft.Office.Interop.Excel.Application = Microsoft.Office.Interop.Excel.Application.
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook = Nothing

        Try
            xlWorkBook = xlApp.Workbooks.Open(filename)
        Catch ex As Exception
            MsgBox(ex.Message)
            GoTo endme
        End Try



        Dim arrears As ArrayList = New ArrayList
        Dim darrs As ArrayList = New ArrayList
        tb = xlWorkBook.Worksheets.Count

        Try
            For x = 1 To xlWorkBook.Worksheets.Count
                Dim name As String = xlWorkBook.Worksheets(x).Name
                If name.ToLower.IndexOf("arrear") > -1 Or name.ToLower.IndexOf("supplementary") > -1 Then
                    arrears.Add(name)
                End If
            Next

            For Each arr In arrears
                Dim xx As List(Of String) = New List(Of String)

                Dim index = 0
                If arr.tolower.indexof("arrear") > -1 Then
                    index = arr.indexof("arrear")
                Else
                    index = arr.indexof("supplementary")
                End If

                If index = -1 Then
                    Continue For
                End If

                Dim aa = arr.ToString.Substring(0, index).Trim.Replace(".", "").Replace("-", "").Replace(",", "").Replace(" ", "")
                'Console.WriteLine(aa)

                For x = 1 To xlWorkBook.Worksheets.Count
                    Dim name As String = xlWorkBook.Worksheets(x).Name
                    Dim bb = name.Trim.Replace(".", "").Replace("-", "").Replace(",", "").Replace(" ", "")
                    If aa.ToLower = bb.ToLower Then
                        xx.Add(name)
                    End If
                Next
                If xx.Count > 0 Then
                    xx.Add(arr)
                End If
                darrs.Add(xx)
            Next
            'getarrears(result.Tables, darrs)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



        For x = 1 To xlWorkBook.Worksheets.Count

            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet = xlWorkBook.Worksheets(x)

            If x = 2 Then
                'Exit For
            End If

            updateBar()

            fillnewtable(xlWorkSheet)
            Try
                '   Console.WriteLine(result.Tables(x).TableName)
                '    combine()
            Catch ex As Exception
                Dim a = MsgBox(ex.Message & vbNewLine & "Do you want to continue?", MsgBoxStyle.YesNo, "Error")
                If a = MsgBoxResult.No Then
                    Exit For
                End If
                Console.WriteLine(ex.Message & " main error........")
            End Try
            'x += 1
            Exit For
        Next
endme:
        Me.BeginInvoke(New MethodInvoker(AddressOf fillview))


        '5. Data Reader methods sup arrear
        'While excelReader.Read()
        'excelReader.GetInt32(0);
        'MsgBox(excelReader.GetString(0))
        'MsgBox(excelReader.GetString(1))
        '        End While

        '6. Free resources (IExcelDataReader is IDisposable)
        ';excelReader.Close()

    End Sub

    Function fillnewtable(ByVal sheet As Microsoft.Office.Interop.Excel.Worksheet) As DataTable
        Dim oRng As Microsoft.Office.Interop.Excel.Range
        Dim t As DataTable = New DataTable
        Dim dr As DataRow
        'Dim sb = New StringBu
        Dim jValue = sheet.UsedRange.Cells.Columns.Count
        Dim iValue = sheet.UsedRange.Cells.Rows.Count
        '  get data column
        For j = 1 To jValue
            t.Columns.Add("column" & j, System.Type.GetType("System.String"))
        Next


        '//string colString = sb.ToString().Trim();

        '//string[] colArray = colString.Split(':');


        '    //  get data in cell
        For i = 1 To iValue
            dr = t.NewRow()
            For j = 1 To jValue
                'oRng = sheet.Range(i, j)
                '[Dim strValue As String = oRng.Text.ToString()
                dr("column" & j) = sheet.Cells(i, j).text
                Console.WriteLine(sheet.Cells(i, j).text)
            Next
            t.Rows.Add(dr)
        Next

        Return t
    End Function

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Form3.Show()
        con()
    End Sub

    Private Sub nextbtn_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form1.Show()
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        Dim datagridview1 As DataTable = Me.DataGridView1.DataSource
        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        For i = 0 To datagridview1.Rows.Count - 1
            For j = 0 To datagridview1.Columns.Count - 1
                For k As Integer = 1 To datagridview1.Columns.Count
                    xlWorkSheet.Cells(1, k) = datagridview1.Columns(k - 1).ColumnName
                    xlWorkSheet.Cells(i + 2, j + 1) = datagridview1.Rows(i).Item(j).ToString()
                Next
            Next
        Next

        xlWorkSheet.SaveAs("c:\Qt\vbexcel.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        'Dim res As MsgBoxResult
        'res = MsgBox("Process completed, Would you like to open file?", MsgBoxStyle.YesNo)
        'If (res = MsgBoxResult.Yes) Then
        '    Process.Start("d:\vbexcel.xlsx")
        'End If

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub


    Private Sub ShowDuplicateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowDuplicateToolStripMenuItem.Click
        'prepare()

    End Sub

    Private Sub ShowDistinctToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowDistinctToolStripMenuItem.Click
        prep()
        Form5.Show()
        Form5.DataGridView1.DataSource = table
    End Sub

    Function searchTable(ByVal what As String, ByVal where As String, ByVal tb As DataTable) As Integer
        Try
            If what.Trim.Length = 0 Then
                Return -1
            End If
            For i = 0 To tb.Rows.Count - 1
                Dim x = tb.Rows(i).Item(where).ToString.Trim
                If x.ToLower = what.ToLower.Trim Then
                    Return i
                End If
            Next
        Catch ex As Exception

        End Try
        Return -1
    End Function

    Dim yrs As String() = {"2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014"}
    Function findamount2(ByVal rw As DataGridViewRow) As String
        For Each y In yrs
            Dim x = sq(rw.Cells(y).Value).Trim
            If x <> "" Then
                Return y
            End If
        Next
        Return ""
    End Function

    Function findallamount(ByVal rw As DataGridViewRow) As ArrayList
        Dim amt As ArrayList = New ArrayList
        For Each y In yrs
            Dim x = sq(rw.Cells(y).Value).Trim
            If x <> "" Then
                amt.Add(y)
            End If
        Next
        Return amt
    End Function

    Function findamount(ByVal rw As DataRow) As String
        For Each y In yrs
            Dim x = sq(rw(y)).Trim
            If x <> "" Then
                Return y
            End If
        Next
        Return ""
    End Function

    Dim sorted = False
    Sub prep()
        Return
        Dim doun As DataTable = mydoubles(0)

        If Not sorted Then
            Dim cnoTable = New Hashtable()
            Dim deletelist = New ArrayList()


            '   MsgBox(doun.Rows.Count)
            For Each g In grp
                Dim dd As ArrayList = New ArrayList
                Dim doucno As ArrayList = New ArrayList

                Dim rws() As DataRow = doun.Select("grp = " & g)
                'MsgBox(rws.Count)
                For Each rw As DataRow In rws

                    Dim cno = sq(rw("cno")).Trim
                    If cno <> "" Then
                        If dd.Contains(cno) Then
                            ' Console.WriteLine(g & "double = " & cno & "=" & sq(rw("name")))
                            doucno.Add(cno)
                        Else
                            dd.Add(cno)
                        End If
                    End If
                Next

                For Each rw As DataRow In rws

                    Dim cdname = sq(rw(realname))
                    Dim cdno = sq(rw("cno")).Trim
                    Dim cdpen = sq(rw("pen"))
                    Dim cdpsn = sq(rw("psn"))

                    If cdno = "" And cdpen = "" And cdpsn = "" Then
                        Console.WriteLine("skipped")
                        Continue For
                    End If

                    Dim seen = -1
                    If cdno <> "" Then
                        If doucno.Contains(cdno) Then
                            Console.WriteLine("skipeed 2" & cdno & rw(realname))
                            Continue For
                        Else
                            seen = search(cdno, "cno")
                        End If
                    End If

                    If seen > -1 Then
                        Dim tcno = sq(table.Rows(seen).Item("cno").ToString).Trim
                        Dim tcpen = sq(table.Rows(seen).Item("pen").ToString).Trim
                        Dim tcpsn = sq(table.Rows(seen).Item("psn").ToString).Trim

                        If tcno = "" Then
                            table.Rows(seen).Item("cno") = cdno
                        End If

                        If tcpen = "" Then
                            table.Rows(seen).Item("pen") = cdpen
                        End If

                        If tcpsn = "" Then
                            table.Rows(seen).Item("psn") = cdpsn
                        End If


                        Dim amtcol = findamount(rw)
                        If amtcol <> "" Then
                            Dim tamt As Double = Val(sq(table.Rows(seen).Item(amtcol).ToString))
                            Dim camt As Double = Val(sq(rw(amtcol)))
                            Dim comb As Double = tamt + camt
                            table.Rows(seen).Item(amtcol) = comb
                        End If
                    Else
                        table.Rows.Add(rw.ItemArray)
                    End If

                    deletelist.Add(rw)
                Next
                '    MsgBox("next")
            Next

            For Each rw As DataRow In deletelist
                Console.WriteLine("remove" & rw(realname) & " = " & rw("grp"))
                doun.Rows.Remove(rw)

            Next

        End If
        'MsgBox(doun.Rows.Count)
        sorted = True
        ' MsgBox(doun.Rows.Count)
    End Sub

    Dim isprepare = False
    Private Sub prepare()

        If Not isprepare And False Then

            Dim pinTable = New Hashtable()
            Dim psnTable = New Hashtable()
            Dim penTable = New Hashtable()
            Dim cnoTable = New Hashtable()

            Dim duplicateList = New ArrayList()

            For Each rw As DataRow In unique.Rows
                If cnoTable.Contains(sq(rw("cno")).Trim) Then
                    duplicateList.Add(rw)
                Else
                    If sq(rw("cno")).Trim <> "" Then
                        cnoTable.Add(sq(rw("cno")).Trim, String.Empty)
                    End If
                End If

                If psnTable.Contains(sq(rw("psn")).Trim) Then
                    duplicateList.Add(rw)
                Else
                    If sq(rw("psn")).Trim <> "" Then
                        psnTable.Add(rw("psn").trim, String.Empty)
                    End If
                End If

                If penTable.Contains(sq(rw("pen")).Trim) Then
                    duplicateList.Add(rw)
                Else
                    If sq(rw("pen")).Trim <> "" Then
                        penTable.Add(rw("pen").trim, String.Empty)
                    End If
                End If

            Next

            For Each ss As DataRow In duplicateList
                unique.Rows.Remove(ss)
            Next

        End If

        isprepare = True
    End Sub

    Private Sub ShowDuplicatePENToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameToolStripMenuItem.Click

        Form5.Show()
        'prep()
        Form5.DataGridView1.DataSource = mydoubles(3)
        setHead()
    End Sub

    Private Sub PINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PINToolStripMenuItem.Click
        prep()
        Form5.Show()
        Form5.DataGridView1.DataSource = mydoubles(1)
        setHead()
    End Sub

    Private Sub PSNToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PSNToolStripMenuItem.Click
        prep()
        Form5.Show()
        Form5.DataGridView1.DataSource = mydoubles(2)
        setHead()
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub ControlNoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form5.Show()
        Form5.DataGridView1.DataSource = mydoubles(3)
        setHead()
    End Sub

    Private Sub setHead()
        setHeader(Form5.DataGridView1)
    End Sub

    Private Sub CalculateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim thread = New Threading.Thread(AddressOf calnow)
        thread.Start()
    End Sub

    Sub calnow()
        For Each rw In table.Rows

        Next
    End Sub

    Private Sub PrepareToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrepareToolStripMenuItem.Click
        prep()
        Form5.Show()
        Form5.DataGridView1.DataSource = doublearrears
        setHead()
    End Sub

    Private Sub cmdprint_Click()
        'Dim oexcel As Object
        'Dim obook As Object
        'Dim osheet As Object

        'oexcel = CreateObject("excel.application")
        'obook = oexcel.workbooks.add

        'dim dataarray(1 to 200, 1 to 4) as variant

        'Dim r As Integer
        'Dim numberofrows As Integer
        'numberofrows = adodrf.recordset.recordcount
        'adodrf.recordset.movefirst()

        'For r = 1 To numberofrows
        '    dataarray(r, 1) = adodrf.recordset.fields("srno")
        '    dataarray(r, 2) = adodrf.recordset.fields("date")
        '    dataarray(r, 3) = adodrf.recordset.fields("name")
        '    dataarray(r, 4) = adodrf.recordset.fields("address")

        '    adodrf.recordset.movenext()
        'Next
        'osheet = obook.worksheets(1)
        'osheet.range("a1:d1").font.bold = True

        'osheet.range("a1:d1").value = Array("sr.no", "date", "name", "address")                                                 ' put headers of fields to excel file


        'osheet.range("a2").resize(numberofrows, 4).value = dataarray

        'obook.saveas("c:\drf.xls")
        'oexcel.quit()

        'adodrf.recordset.movefirst()

        'MsgBox("report file format  file saved", 64, "info")
    End Sub

    Private Sub DataGridView1_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseClick
        sortTable(DataGridView1)
    End Sub

    Private Sub SavedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavedToolStripMenuItem.Click
        savedExcel(DataGridView1)
    End Sub

    Dim lloc As String = ""
    Private Sub ExportAllRecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportAllRecordsToolStripMenuItem.Click
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

    Sub clearme()
        DataGridView1.Columns.Clear()
    End Sub

    Sub export()
        Dim hash = New ArrayList
        'Dim str As String() = {"Consolidated Records", "Unique Records", "Duplicate Names", "Duplicate PEN", "Duplicate PSN"}
        Dim str As String() = {"Consolidated Records", "Duplicate Names", "Duplicate PEN", "Duplicate PSN", "Duplicate Control No"}
        hash.Add(table)
        'hash.Add(unique)
        hash.Add(mydoubles(3))
        hash.Add(mydoubles(1))
        hash.Add(mydoubles(2))
        hash.Add(mydoubles(0))
        form.start = 0
        form.tb = table.Rows.Count + mydoubles(0).Rows.Count + mydoubles(1).Rows.Count + mydoubles(2).Rows.Count + mydoubles(3).Rows.Count
        prep()
        savedExcelAll(hash, form, lloc)

        Me.BeginInvoke(New MethodInvoker(AddressOf quitForm))
    End Sub

    Sub quitForm()
        form.quit()
    End Sub



    Private Sub ControlNoToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlNoToolStripMenuItem.Click
        prep()
        Form5.Show()
        Form5.DataGridView1.DataSource = mydoubles(0)
        setHead()
    End Sub

    Private Sub Form4_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Form5.Close()
    End Sub

    Private Sub StartMergingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Dim colyrs As String() = {"", "", "", "", "", "", "", ""}
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        mergenow(e.RowIndex)
    End Sub

    Private Sub mergenow(ByVal rowindex As Integer)
        If rowindex < 0 Then
            Return
        End If

        Dim newrow = False
        If rowindex > DataGridView1.Rows.Count Then
            newrow = True
        End If

        Dim totaldoubl() As Double = {0, 0, 0, 0, 0, 0, 0, 0, 0}

        If Form5.startmerging Then
            Dim totalhash As Hashtable = New Hashtable()
            For Each y In yrs
                totalhash.Add(y, 0)
            Next
            totalhash.Add("total", 0)

            Dim deletelist As ArrayList = New ArrayList

            If Form5.DataGridView1.SelectedRows.Count = 0 Then
                Form5.TopMost = False
                MsgBox("You did not select any entry in the duplicate list before merging")
                Form5.TopMost = True
                Return
            End If

            Dim tt As DataGridView = Form5.DataGridView1
            Dim allna = "", allcno = "", allpen = "", allpsn = "", allmda = "", allpfa = ""


            Dim ends = Form5.DataGridView1.SelectedRows.Count
            While (ends > 0)
                Dim indx As Integer = Form5.DataGridView1.SelectedRows(ends - 1).Index
                Console.WriteLine(ends & "==-sss--" & indx)
                'Console.WriteLine(Form5.selct.Item(0))
                If indx >= tt.Rows.Count Then
                    ends -= 1
                    Continue While
                End If

                Dim rw As DataGridViewRow = tt.Rows(indx)
                Dim cmn = sq(rw.Cells("name").Value).ToString.Trim
                Dim mycno = sq(rw.Cells("cno").Value).ToString.Trim
                Dim mypen = sq(rw.Cells("pen").Value).ToString.Trim
                Dim mypsn = sq(rw.Cells("psn").Value).ToString.Trim
                allmda = sq(rw.Cells("mdas").Value).ToString.Trim
                allpfa = sq(rw.Cells("pfa").Value).ToString.Trim

                If allna = "" Then
                    allna = cmn
                End If
                If allcno = "" Then
                    allcno = mycno
                End If

                If allpen = "" Then
                    allpen = mypen
                End If
                If allpsn = "" Then
                    allpsn = mypsn
                End If

                'Dim yr = findamount2(rw)
                Dim yrs As ArrayList = findallamount(rw)

                For Each yr In yrs
                    Dim inx = -1
                    Dim tota As Double = Val(sq(rw.Cells(yr).Value))
                    Dim prev As Double = Val(totalhash(yr))
                    Dim alltota = tota + prev
                    totalhash(yr) = alltota

                    Dim mytotal As Double = Val(totalhash("total"))
                    totalhash("total") = mytotal + tota


                    'For r = 0 To yrs.Count - 1
                    '    If yrs(r) = yr Then
                    '        prev = totaldoubl(r)
                    '        inx = r
                    '        Exit For
                    '    End If
                    'Next

                Next

                deletelist.Add(rw)
                ends -= 1
            End While

            If newrow Then
                Dim ttable As DataTable = DataGridView1.DataSource
                Dim rwa As DataRow = ttable.NewRow
                rwa("name") = allna
                rwa("cno") = allcno
                rwa("pen") = allpen
                rwa("psn") = allpsn
                rwa("mdas") = allmda
                rwa("pfa") = allpfa

                Dim mytotal As Double = 0

                For i = 0 To yrs.Length - 1
                    Dim myy = yrs(i)

                    Dim v As Double = Val(totalhash(myy))
                    Dim pre As Double = Val(sq(rwa(myy).Value))
                    Dim taa As Double = Val(v + pre)
                    rwa(myy) = taa
                    mytotal += taa
                Next



                rwa("total") = mytotal
                ttable.Rows.Add(rwa)
                'DataGridView1.Rows.Add(rwa.ItemArray)
                DataGridView1.ClearSelection()
                DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows.Count - 1
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).Selected = True
                sortTable(DataGridView1)

                If Form5.CheckBox6.Checked Then
                    For Each rr As DataGridViewRow In deletelist
                        tt.Rows.Remove(rr)
                    Next
                End If

            Else
                Dim rwa As DataGridViewRow = DataGridView1.Rows(rowindex)
                Dim na = sq(rwa.Cells("name").Value).ToString.Trim
                Dim no = sq(rwa.Cells("cno").Value).ToString.Trim
                Dim pen = sq(rwa.Cells("pen").Value).ToString.Trim
                Dim psn = sq(rwa.Cells("psn").Value).ToString.Trim

                With Form5
                    If .CheckBox7.Checked Then
                        If na = "" Then
                            rwa.Cells("name").Value = allna
                        End If
                        If no = "" Then
                            rwa.Cells("cno").Value = allcno
                        End If
                        If pen = "" Then
                            rwa.Cells("pen").Value = allpen
                        End If
                        If psn = "" Then
                            rwa.Cells("psn").Value = allpsn
                        End If
                    End If

                    If .CheckBox4.Checked Then
                        rwa.Cells("psn").Value = allpsn
                    End If

                    If .CheckBox3.Checked Then
                        rwa.Cells("pen").Value = allpen
                    End If

                    If .CheckBox2.Checked Then
                        rwa.Cells("cno").Value = allcno
                    End If

                    If .CheckBox1.Checked Then
                        rwa.Cells("name").Value = allna
                    End If


                    If .CheckBox5.Checked Then
                        Dim mytotal As Double = 0
                        For i = 0 To 7
                            Dim myy = yrs(i)
                            Dim v As Double = Val(totalhash(myy))
                            Dim pre As Double = Val(sq(rwa.Cells(myy).Value))
                            Dim taa As Double = Val(v + pre)
                            rwa.Cells(myy).Value = taa
                            mytotal += taa
                        Next

                        rwa.Cells("total").Value = mytotal
                    End If

                    If .CheckBox6.Checked Then
                        For Each rr As DataGridViewRow In deletelist
                            tt.Rows.Remove(rr)
                        Next
                    End If

                    'Form5.DataGridView1.DataSource = tt

                    If .CheckBox8.Checked Then
                        Form5.TopMost = False
                        MsgBox("success")
                        Form5.TopMost = True
                    End If

                End With
            End If
        Else

        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tt As DataTable = DataGridView1.DataSource
        Dim text = TextBox1.Text.ToLower.Trim()
        startr = 0
        If DataGridView1.SelectedRows.Count > 0 Then
            startr = DataGridView1.SelectedRows(0).Index + 1
        End If
        DataGridView1.ClearSelection()

restart:
        For i = startr To DataGridView1.Rows.Count - 1
            For c = 1 To 4
                Try
                    Dim x As String = DataGridView1.Rows(i).Cells.Item(c).Value.ToString.ToLower.Trim()
                    If x.IndexOf(text) > -1 Then
                        DataGridView1.FirstDisplayedScrollingRowIndex = i
                        DataGridView1.Rows(i).Selected = True
                        Return
                    End If
                Catch ex As Exception
                End Try
            Next
        Next

        If startr <> 0 Then
            startr = 0
            GoTo restart
        End If


    End Sub

    Dim change = False
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        change = True
    End Sub

    Dim startr = 0, startc = 0
    Private Sub reset()
        startr = 0
        startc = 0
    End Sub

    Private Sub pp()
        If DataGridView1.SelectedRows.Count > 0 Then
            startr = DataGridView1.SelectedRows(0).Index
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim tt As DataTable = DataGridView1.DataSource
        Dim text = TextBox1.Text.ToLower.Trim()

        DataGridView1.ClearSelection()
        Dim first = True
        For i = 0 To DataGridView1.Rows.Count - 1
            For c = 1 To 4
                Try
                    Dim x As String = DataGridView1.Rows(i).Cells.Item(c).Value.ToString.ToLower.Trim()
                    If x.IndexOf(text) > -1 Then
                        If first Then
                            DataGridView1.FirstDisplayedScrollingRowIndex = i
                            first = False
                        End If
                        DataGridView1.Rows(i).Selected = True
                    End If
                Catch ex As Exception
                End Try
            Next
        Next
    End Sub

    Private Sub AddNewRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewRecordToolStripMenuItem.Click
        mergenow(DataGridView1.Rows.Count + 10)
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Button1.PerformClick()
        End If
    End Sub
End Class
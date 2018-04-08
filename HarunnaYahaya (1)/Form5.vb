Public Class Form5

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        ' xlWorkSheet.
        Me.TopMost = True
        'DataGridView1.AutoSizeColumnsMode = c
    End Sub

    Private Sub PrepareToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub DataGridView1_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseClick
    End Sub

    Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripMenuItem.Click
        savedExcel(DataGridView1)
    End Sub

    Private Sub MergeWithConsolidatedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MergeWithConsolidatedToolStripMenuItem.Click

    End Sub

    Public startmerging = False
    Private Sub StartMergingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartMergingToolStripMenuItem.Click

    End Sub


    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex = -1 Then
            Return
        End If

    End Sub




    Private Sub StartMergingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartMergingToolStripMenuItem1.Click
        startmerging = True
        
    End Sub

    Private Sub StopMergingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopMergingToolStripMenuItem.Click
        startmerging = False
        DataGridView1.ClearSelection()
    End Sub

    Private Sub ClearSelectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearSelectionToolStripMenuItem.Click
        
    End Sub

    Private Sub Form5_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        startmerging = False
    End Sub

    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked Then
            Me.TopMost = True
            CheckBox8.Checked = False
        Else
            Me.TopMost = False
            CheckBox8.Checked = True
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Clipboard.SetText(text)
    End Sub

    Private Sub CopyToolStripMenuItem_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CopyToolStripMenuItem.MouseDown

    End Sub


    Dim textx As String = ""
    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        'Console.WriteLine(e.Button)

        'If e.Button = Windows.Forms.MouseButtons.Right Then
        '    DataGridView1.ContextMenuStrip = ContextMenuStrip1
        '    DataGridView1.ContextMenuStrip.Show()
        '    ProjectsDataGridView.CurrentRow.Selected = False
        '    ProjectsDataGridView.Rows(e.RowIndex).Selected = True
        '    Console.WriteLine(e.ColumnIndex & "=====" & e.RowIndex & textx.ToString)
        '    textx = DataGridView1(e.RowIndex, e.ColumnIndex).Value.ToString
        'End If

    End Sub

    Private Sub CopyAndSearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyAndSearchToolStripMenuItem.Click
        'Clipboard.SetText(textx)
        'Form4.TextBox1.Text = textx
        'Form4.Button1.PerformClick()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        For Each rw As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(rw)
        Next
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        DataGridView1.ClearSelection()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        searchMeNow("name")
    End Sub

    Dim startr = 0
    Private Sub searchForm(ByVal what As String)
        Dim tt As DataTable = Form4.DataGridView1.DataSource
        Dim text = what.ToLower.Trim
        startr = 0
        If Form4.DataGridView1.SelectedRows.Count > 0 Then
            startr = Form4.DataGridView1.SelectedRows(0).Index + 1
        End If
        Form4.DataGridView1.ClearSelection()

restart:
        For i = startr To Form4.DataGridView1.Rows.Count - 1
            For c = 1 To 4

                Try
                    Dim x As String = Form4.DataGridView1.Rows(i).Cells.Item(c).Value.ToString.ToLower.Trim()
                    '                    Console.WriteLine(x)
                    If x.IndexOf(text) > -1 Then
                        Form4.DataGridView1.FirstDisplayedScrollingRowIndex = i
                        Form4.DataGridView1.Rows(i).Selected = True
                        Label2.Text = "(" & what & ") was found at S/N " & (i + 1)
                        'MsgBox("ok")
                        Return
                    End If
                Catch ex As Exception
                    ' MsgBox(ex.ToString)
                End Try
            Next
        Next

        If startr <> 0 Then
            startr = 0
            GoTo restart
        End If
        Label2.Text = "Cannot find (" & what & ")"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        searchMeNow("cno")
    End Sub

    Private Sub searchMeNow(ByVal where As String)
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim text As String = DataGridView1.SelectedRows(0).Cells(where).Value.ToString
            Console.WriteLine(where & "yes" & text)
            If text.Trim = "" Then
                Return
            End If
            searchForm(text)
        Else
            MsgBox("You did not select any row")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        searchMeNow("pen")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        searchMeNow("psn")
    End Sub
End Class
Public Class frminportfiles

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
        Me.TopMost = 1
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        loadfile.ShowDialog()
        ' If loadfile.ShowDialog = DialogResult.OK Then
        Dim filename1 = loadfile.FileNames
        filelist.Items.Clear()
        Dim file As String
        For Each file In loadfile.FileNames
            filelist.Items.Add(file.First)
        Next
        'End If

    End Sub


    Private Sub btnupload_Click(sender As Object, e As EventArgs) Handles btnupload.Click

    End Sub
End Class
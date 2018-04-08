Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim loc = ""
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        loc = "c:\files"
        open(loc)
    End Sub

    Sub open(ByVal location As String)
        Dim di As New IO.DirectoryInfo(location)

        Dim dir As IO.DirectoryInfo() = di.GetDirectories()

        Dim diar1 As IO.FileInfo() = di.GetFiles()


        Dim dra As IO.FileInfo
        ListBox1.Items.Clear()
        'list the names of all files in the specified directory
        For Each dr In dir
            ListBox1.Items.Add(dr)
        Next

        For Each dra In diar1
            ListBox1.Items.Add(dra)
        Next
    End Sub
    Private Sub showNxt()
        Dim x = ListBox1.SelectedItem.ToString.Trim
        Dim di As New IO.DirectoryInfo(loc)

        Dim dir As IO.DirectoryInfo() = di.GetDirectories()

        For Each dr In dir
            If x = dr.ToString.Trim Then
                loc &= "\" & x
                open(loc)
                Return
            End If
        Next
        MsgBox("This is a file " & x)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        showNxt()
    End Sub
End Class
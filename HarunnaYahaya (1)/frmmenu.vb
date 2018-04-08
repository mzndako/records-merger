Imports HarunnaYahaya.dbcon
Imports HarunnaYahaya.Module1
Public Class frmmenu
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form4.Show()
    End Sub
    Private Sub TopMostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btntop.Click
        If Me.btntop.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub RecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordsToolStripMenuItem.Click


    End Sub

    Private Sub frmmenu_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub frmmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'checklogin()
    End Sub
    Sub checklogin()
        If userisok = False Then
            Me.TopMost = False
            frmlogin.ShowDialog()
            Me.lbluser.Text = "User LogedIn: " & "Administrator"
        Else
            Me.TopMost = True
        End If
    End Sub

    Private Sub Form4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form4ToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Form2.Show()
    End Sub

    Private Sub Form3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form3ToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub Form2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form2ToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub DbconnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DbconnToolStripMenuItem.Click
        startcon()
    End Sub

    Private Sub ImportFileToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ImportFileToolStripMenuItem.Click

        mergeme()
    End Sub

    Private Sub mergeme()
        Form9.Show()
    End Sub

    Private Sub frmmenu_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Process.Start("taskkill.exe", "/im HarunaYahaya.exe /f")
    End Sub

    Private Sub Method1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Method1ToolStripMenuItem.Click
        Form10.meth = 1
        Form10.Show()
    End Sub

    Private Sub Method2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Method2ToolStripMenuItem.Click
        Form10.meth = 2
        Form10.Show()
    End Sub
End Class
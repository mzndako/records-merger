Public Class Form8

    Private Sub Form8_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.TopMost = 1
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Form8_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
    Public start = 0
    Dim starty = 0
    Public tb = 0
    Sub updateBar()
        Dim x As Double = Val(starty)
        Dim y As Double = Val(tb)
        Dim t As Double = (x / y) * 100

        Dim yy As Integer = Val(t)
        If yy > 100 Then
            yy = 100
        End If
        'Console.WriteLine("ttt=" & x & "/" & y & "=" & t & " = " & yy & " --" & Form8.start)
        start = yy
        starty += 1
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = Val(start)
        'Console.WriteLine("s" & start)
    End Sub

    Public Sub quit()
        Me.TopMost = 0
        Timer1.Stop()
        Me.Hide()
    End Sub

End Class
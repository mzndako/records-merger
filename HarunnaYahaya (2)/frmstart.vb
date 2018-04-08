Public Class frmstart

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        incressgrs()
    End Sub
    Sub incressgrs()

        ProgressBar1.Visible = False
        With ProgressBar1
            .Value = .Value + 5
            Label1.Text = "Please wait... " & .Value & "% " & "Completed"
            If .Value = 100 Then
                Timer1.Stop()
                Me.TopMost = False
                Me.Hide()
                frmmenu.ShowDialog()
            End If

        End With
    End Sub
End Class
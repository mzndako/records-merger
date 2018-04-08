Imports HarunnaYahaya.dbcon
Public Class frmlogin

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changpasschar()
    End Sub
    Sub doclear()
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = ""
            End If
        Next
    End Sub
    Sub changpasschar()
        txtpass.UseSystemPasswordChar = False
        txtpass.PasswordChar = "*"
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        checklogin()
        ' Form4.ShowDialog()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        askexit()
    End Sub
    Sub checklogin()
        If txtuser.Text = "" Then
            MsgBox("Please Enter Username!", MsgBoxStyle.Exclamation, "Warning")
            txtuser.BackColor = Color.Red
            txtuser.SelectAll()
            txtuser.Focus()
        ElseIf txtpass.Text = "" Then
            MsgBox("Please Enter Password!", MsgBoxStyle.Exclamation, "Warning")
            txtpass.BackColor = Color.Red
            txtpass.SelectAll()
            txtpass.Focus()
        Else
            userisok = True
            Me.Hide()
            'frmmenu.Show()
        End If

    End Sub
    Sub dodeepcheck()
        Dim conn As New OleDb.OleDbConnection
    End Sub
    Sub askexit()
        Dim a
        a = MsgBox("Are you sure you want to cancel?", MsgBoxStyle.Question + vbYesNo, "Confirm  Exit")
        If a = vbYes Then
            End
        Else
        End If
    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged
        txtuser.BackColor = Color.White
    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged
        txtpass.BackColor = Color.White
    End Sub
End Class
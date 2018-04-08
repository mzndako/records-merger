Public Class Form10

    Dim form As Form4 = New Form4
    Public meth As Integer = 1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form4.pfa = ComboBox1.SelectedItem
        Form4.clearme()
        Form4.meth = meth
        Form4.Show()
        Form4.BringToFront()
        Form4.meth = meth
    End Sub

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub


End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmenu))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DbconnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btntop = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsByMDAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsByMonthsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintMasterListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDuplicatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintAllMergeRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbluser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Method1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Method2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Cornsilk
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(627, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecordsToolStripMenuItem, Me.ImportFileToolStripMenuItem, Me.Form4ToolStripMenuItem, Me.ToolStripMenuItem1, Me.Form3ToolStripMenuItem, Me.Form2ToolStripMenuItem, Me.ExitToolStripMenuItem, Me.DbconnToolStripMenuItem})
        Me.MenuToolStripMenuItem.Image = Global.HarunnaYahaya.My.Resources.Resources.menu_home
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.MenuToolStripMenuItem.Text = "&Menu"
        '
        'RecordsToolStripMenuItem
        '
        Me.RecordsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Method1ToolStripMenuItem, Me.Method2ToolStripMenuItem})
        Me.RecordsToolStripMenuItem.Image = Global.HarunnaYahaya.My.Resources.Resources.Database
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.RecordsToolStripMenuItem.Text = "Consolidate Records"
        '
        'ImportFileToolStripMenuItem
        '
        Me.ImportFileToolStripMenuItem.Image = Global.HarunnaYahaya.My.Resources.Resources.Box_Up
        Me.ImportFileToolStripMenuItem.Name = "ImportFileToolStripMenuItem"
        Me.ImportFileToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ImportFileToolStripMenuItem.Text = "Merge Records"
        '
        'Form4ToolStripMenuItem
        '
        Me.Form4ToolStripMenuItem.Name = "Form4ToolStripMenuItem"
        Me.Form4ToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.Form4ToolStripMenuItem.Text = "Form4"
        Me.Form4ToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.ToolStripMenuItem1.Text = "Form1"
        Me.ToolStripMenuItem1.Visible = False
        '
        'Form3ToolStripMenuItem
        '
        Me.Form3ToolStripMenuItem.Name = "Form3ToolStripMenuItem"
        Me.Form3ToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.Form3ToolStripMenuItem.Text = "form3"
        Me.Form3ToolStripMenuItem.Visible = False
        '
        'Form2ToolStripMenuItem
        '
        Me.Form2ToolStripMenuItem.Name = "Form2ToolStripMenuItem"
        Me.Form2ToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.Form2ToolStripMenuItem.Text = "form2"
        Me.Form2ToolStripMenuItem.Visible = False
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.HarunnaYahaya.My.Resources.Resources._001_29
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'DbconnToolStripMenuItem
        '
        Me.DbconnToolStripMenuItem.Name = "DbconnToolStripMenuItem"
        Me.DbconnToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.DbconnToolStripMenuItem.Text = "dbconn"
        Me.DbconnToolStripMenuItem.Visible = False
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btntop, Me.ReportsByMDAsToolStripMenuItem, Me.ReportsByMonthsToolStripMenuItem, Me.PrintMasterListToolStripMenuItem, Me.PrintDuplicatesToolStripMenuItem, Me.PrintAllMergeRecordsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Image = Global.HarunnaYahaya.My.Resources.Resources.search_media22
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.ViewToolStripMenuItem.Text = "&Reports"
        '
        'btntop
        '
        Me.btntop.Name = "btntop"
        Me.btntop.Size = New System.Drawing.Size(198, 22)
        Me.btntop.Text = "Repots By PFA"
        '
        'ReportsByMDAsToolStripMenuItem
        '
        Me.ReportsByMDAsToolStripMenuItem.Name = "ReportsByMDAsToolStripMenuItem"
        Me.ReportsByMDAsToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ReportsByMDAsToolStripMenuItem.Text = "Reports By MDAs"
        '
        'ReportsByMonthsToolStripMenuItem
        '
        Me.ReportsByMonthsToolStripMenuItem.Name = "ReportsByMonthsToolStripMenuItem"
        Me.ReportsByMonthsToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ReportsByMonthsToolStripMenuItem.Text = "Reports By Months"
        '
        'PrintMasterListToolStripMenuItem
        '
        Me.PrintMasterListToolStripMenuItem.Name = "PrintMasterListToolStripMenuItem"
        Me.PrintMasterListToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.PrintMasterListToolStripMenuItem.Text = "Print Master List"
        '
        'PrintDuplicatesToolStripMenuItem
        '
        Me.PrintDuplicatesToolStripMenuItem.Name = "PrintDuplicatesToolStripMenuItem"
        Me.PrintDuplicatesToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.PrintDuplicatesToolStripMenuItem.Text = "Print Duplicates"
        '
        'PrintAllMergeRecordsToolStripMenuItem
        '
        Me.PrintAllMergeRecordsToolStripMenuItem.Name = "PrintAllMergeRecordsToolStripMenuItem"
        Me.PrintAllMergeRecordsToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.PrintAllMergeRecordsToolStripMenuItem.Text = "Print All Merge Records"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbluser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 240)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(627, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbluser
        '
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(0, 17)
        '
        'Method1ToolStripMenuItem
        '
        Me.Method1ToolStripMenuItem.Name = "Method1ToolStripMenuItem"
        Me.Method1ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Method1ToolStripMenuItem.Text = "New"
        '
        'Method2ToolStripMenuItem
        '
        Me.Method2ToolStripMenuItem.Name = "Method2ToolStripMenuItem"
        Me.Method2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Method2ToolStripMenuItem.Text = "Continue"
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HarunnaYahaya.My.Resources.Resources.ser
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(627, 262)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btntop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsByMDAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsByMonthsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintMasterListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDuplicatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintAllMergeRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbluser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Form4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Form3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Form2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DbconnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Method1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Method2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

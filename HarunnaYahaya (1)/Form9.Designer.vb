<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MergeRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MergeDuplicatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PSNToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlNoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDuplicateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PSNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlNOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(723, 381)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(723, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MergeRecordsToolStripMenuItem, Me.MergeDuplicatesToolStripMenuItem, Me.ViewDuplicateToolStripMenuItem, Me.ExportToExcelToolStripMenuItem, Me.ExportAllToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'MergeRecordsToolStripMenuItem
        '
        Me.MergeRecordsToolStripMenuItem.Name = "MergeRecordsToolStripMenuItem"
        Me.MergeRecordsToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.MergeRecordsToolStripMenuItem.Text = "Merge Records"
        '
        'MergeDuplicatesToolStripMenuItem
        '
        Me.MergeDuplicatesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NamesToolStripMenuItem, Me.PENToolStripMenuItem, Me.PSNToolStripMenuItem1, Me.ControlNoToolStripMenuItem1})
        Me.MergeDuplicatesToolStripMenuItem.Name = "MergeDuplicatesToolStripMenuItem"
        Me.MergeDuplicatesToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.MergeDuplicatesToolStripMenuItem.Text = "Merged Duplicates"
        '
        'NamesToolStripMenuItem
        '
        Me.NamesToolStripMenuItem.Name = "NamesToolStripMenuItem"
        Me.NamesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NamesToolStripMenuItem.Text = "Names"
        '
        'PENToolStripMenuItem
        '
        Me.PENToolStripMenuItem.Name = "PENToolStripMenuItem"
        Me.PENToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PENToolStripMenuItem.Text = "PEN"
        '
        'PSNToolStripMenuItem1
        '
        Me.PSNToolStripMenuItem1.Name = "PSNToolStripMenuItem1"
        Me.PSNToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.PSNToolStripMenuItem1.Text = "PSN"
        '
        'ControlNoToolStripMenuItem1
        '
        Me.ControlNoToolStripMenuItem1.Name = "ControlNoToolStripMenuItem1"
        Me.ControlNoToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ControlNoToolStripMenuItem1.Text = "Control No"
        '
        'ViewDuplicateToolStripMenuItem
        '
        Me.ViewDuplicateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PINToolStripMenuItem, Me.PSNToolStripMenuItem, Me.ControlNOToolStripMenuItem})
        Me.ViewDuplicateToolStripMenuItem.Name = "ViewDuplicateToolStripMenuItem"
        Me.ViewDuplicateToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ViewDuplicateToolStripMenuItem.Text = "Duplicates Within Merged"
        '
        'PINToolStripMenuItem
        '
        Me.PINToolStripMenuItem.Name = "PINToolStripMenuItem"
        Me.PINToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PINToolStripMenuItem.Text = "PEN"
        '
        'PSNToolStripMenuItem
        '
        Me.PSNToolStripMenuItem.Name = "PSNToolStripMenuItem"
        Me.PSNToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PSNToolStripMenuItem.Text = "PSN"
        '
        'ControlNOToolStripMenuItem
        '
        Me.ControlNOToolStripMenuItem.Name = "ControlNOToolStripMenuItem"
        Me.ControlNOToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ControlNOToolStripMenuItem.Text = "Control NO"
        '
        'ExportToExcelToolStripMenuItem
        '
        Me.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem"
        Me.ExportToExcelToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ExportToExcelToolStripMenuItem.Text = "Export to Excel"
        '
        'ExportAllToolStripMenuItem
        '
        Me.ExportAllToolStripMenuItem.Name = "ExportAllToolStripMenuItem"
        Me.ExportAllToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ExportAllToolStripMenuItem.Text = "Export all Records"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"TRUST FUND PENSION", "LEADWAY ", "APT", "PREMIUM", "PAL", "ARM", "FIDELITY", "IEI", "AIICO", "GTB-AM", "STANBIC IBTC", "CRUSADER-STERLING", "NLPC", "FUG", "PENMAN", "SIGMA", "FIRST GUARANTEE", "LEGACY"})
        Me.ComboBox1.Location = New System.Drawing.Point(217, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(268, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Filter By PFA:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(509, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Filter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(590, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 405)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form9"
        Me.Text = "Merged Records"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MergeRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDuplicateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PSNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlNOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ExportAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MergeDuplicatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NamesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PSNToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlNoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PENToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

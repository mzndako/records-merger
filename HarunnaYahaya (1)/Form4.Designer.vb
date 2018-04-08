<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowDuplicateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PSNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlNoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowDistinctToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrepareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportAllRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AddNewRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(876, 379)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.AddNewRecordToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(876, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowDuplicateToolStripMenuItem, Me.ShowDistinctToolStripMenuItem, Me.PrepareToolStripMenuItem, Me.SavedToolStripMenuItem, Me.ExportAllRecordsToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ShowDuplicateToolStripMenuItem
        '
        Me.ShowDuplicateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NameToolStripMenuItem, Me.PINToolStripMenuItem, Me.PSNToolStripMenuItem, Me.ControlNoToolStripMenuItem})
        Me.ShowDuplicateToolStripMenuItem.Name = "ShowDuplicateToolStripMenuItem"
        Me.ShowDuplicateToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ShowDuplicateToolStripMenuItem.Text = "Show Duplicate"
        '
        'NameToolStripMenuItem
        '
        Me.NameToolStripMenuItem.Name = "NameToolStripMenuItem"
        Me.NameToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.NameToolStripMenuItem.Text = "Name"
        '
        'PINToolStripMenuItem
        '
        Me.PINToolStripMenuItem.Name = "PINToolStripMenuItem"
        Me.PINToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.PINToolStripMenuItem.Text = "PEN"
        '
        'PSNToolStripMenuItem
        '
        Me.PSNToolStripMenuItem.Name = "PSNToolStripMenuItem"
        Me.PSNToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.PSNToolStripMenuItem.Text = "PSN"
        '
        'ControlNoToolStripMenuItem
        '
        Me.ControlNoToolStripMenuItem.Name = "ControlNoToolStripMenuItem"
        Me.ControlNoToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ControlNoToolStripMenuItem.Text = "Control No"
        '
        'ShowDistinctToolStripMenuItem
        '
        Me.ShowDistinctToolStripMenuItem.Name = "ShowDistinctToolStripMenuItem"
        Me.ShowDistinctToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ShowDistinctToolStripMenuItem.Text = "Show Full Records"
        Me.ShowDistinctToolStripMenuItem.Visible = False
        '
        'PrepareToolStripMenuItem
        '
        Me.PrepareToolStripMenuItem.Name = "PrepareToolStripMenuItem"
        Me.PrepareToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PrepareToolStripMenuItem.Text = "Duplicate Arrears"
        '
        'SavedToolStripMenuItem
        '
        Me.SavedToolStripMenuItem.Name = "SavedToolStripMenuItem"
        Me.SavedToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SavedToolStripMenuItem.Text = "Export to Excel"
        '
        'ExportAllRecordsToolStripMenuItem
        '
        Me.ExportAllRecordsToolStripMenuItem.Name = "ExportAllRecordsToolStripMenuItem"
        Me.ExportAllRecordsToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ExportAllRecordsToolStripMenuItem.Text = "Export All Records"
        '
        'BackgroundWorker1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Search"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(507, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 24)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Find Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(275, 1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(215, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(613, -1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 24)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Find All"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AddNewRecordToolStripMenuItem
        '
        Me.AddNewRecordToolStripMenuItem.Name = "AddNewRecordToolStripMenuItem"
        Me.AddNewRecordToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.AddNewRecordToolStripMenuItem.Text = "Merge - New Record"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 403)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Consolidated Records"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowDuplicateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowDistinctToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PSNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PrepareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SavedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportAllRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlNoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents AddNewRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminportfiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frminportfiles))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdibtc = New System.Windows.Forms.RadioButton()
        Me.rdtrust = New System.Windows.Forms.RadioButton()
        Me.rdaiico = New System.Windows.Forms.RadioButton()
        Me.rdpal = New System.Windows.Forms.RadioButton()
        Me.rdfidelity = New System.Windows.Forms.RadioButton()
        Me.rdsigma = New System.Windows.Forms.RadioButton()
        Me.rdlegacy = New System.Windows.Forms.RadioButton()
        Me.rdcrusader = New System.Windows.Forms.RadioButton()
        Me.rdpremium = New System.Windows.Forms.RadioButton()
        Me.rdarm = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.filelist = New System.Windows.Forms.ListView()
        Me.btnupload = New System.Windows.Forms.Button()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.frmfolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.loadfile = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdibtc)
        Me.GroupBox1.Controls.Add(Me.rdtrust)
        Me.GroupBox1.Controls.Add(Me.rdaiico)
        Me.GroupBox1.Controls.Add(Me.rdpal)
        Me.GroupBox1.Controls.Add(Me.rdfidelity)
        Me.GroupBox1.Controls.Add(Me.rdsigma)
        Me.GroupBox1.Controls.Add(Me.rdlegacy)
        Me.GroupBox1.Controls.Add(Me.rdcrusader)
        Me.GroupBox1.Controls.Add(Me.rdpremium)
        Me.GroupBox1.Controls.Add(Me.rdarm)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 78)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PFA Specification"
        '
        'rdibtc
        '
        Me.rdibtc.AutoSize = True
        Me.rdibtc.Location = New System.Drawing.Point(354, 20)
        Me.rdibtc.Name = "rdibtc"
        Me.rdibtc.Size = New System.Drawing.Size(49, 17)
        Me.rdibtc.TabIndex = 0
        Me.rdibtc.TabStop = True
        Me.rdibtc.Text = "IBTC"
        Me.rdibtc.UseVisualStyleBackColor = True
        '
        'rdtrust
        '
        Me.rdtrust.AutoSize = True
        Me.rdtrust.Location = New System.Drawing.Point(236, 20)
        Me.rdtrust.Name = "rdtrust"
        Me.rdtrust.Size = New System.Drawing.Size(95, 17)
        Me.rdtrust.TabIndex = 0
        Me.rdtrust.TabStop = True
        Me.rdtrust.Text = "TRUST FUND"
        Me.rdtrust.UseVisualStyleBackColor = True
        '
        'rdaiico
        '
        Me.rdaiico.AutoSize = True
        Me.rdaiico.Location = New System.Drawing.Point(414, 20)
        Me.rdaiico.Name = "rdaiico"
        Me.rdaiico.Size = New System.Drawing.Size(53, 17)
        Me.rdaiico.TabIndex = 0
        Me.rdaiico.TabStop = True
        Me.rdaiico.Text = "AIICO"
        Me.rdaiico.UseVisualStyleBackColor = True
        '
        'rdpal
        '
        Me.rdpal.AutoSize = True
        Me.rdpal.Location = New System.Drawing.Point(253, 43)
        Me.rdpal.Name = "rdpal"
        Me.rdpal.Size = New System.Drawing.Size(70, 17)
        Me.rdpal.TabIndex = 0
        Me.rdpal.TabStop = True
        Me.rdpal.Text = "PAL PEN"
        Me.rdpal.UseVisualStyleBackColor = True
        '
        'rdfidelity
        '
        Me.rdfidelity.AutoSize = True
        Me.rdfidelity.Location = New System.Drawing.Point(171, 42)
        Me.rdfidelity.Name = "rdfidelity"
        Me.rdfidelity.Size = New System.Drawing.Size(76, 17)
        Me.rdfidelity.TabIndex = 0
        Me.rdfidelity.TabStop = True
        Me.rdfidelity.Text = "FEDELITY"
        Me.rdfidelity.UseVisualStyleBackColor = True
        '
        'rdsigma
        '
        Me.rdsigma.AutoSize = True
        Me.rdsigma.Location = New System.Drawing.Point(171, 19)
        Me.rdsigma.Name = "rdsigma"
        Me.rdsigma.Size = New System.Drawing.Size(59, 17)
        Me.rdsigma.TabIndex = 0
        Me.rdsigma.TabStop = True
        Me.rdsigma.Text = "SIGMA"
        Me.rdsigma.UseVisualStyleBackColor = True
        '
        'rdlegacy
        '
        Me.rdlegacy.AccessibleDescription = ""
        Me.rdlegacy.AutoSize = True
        Me.rdlegacy.Location = New System.Drawing.Point(98, 43)
        Me.rdlegacy.Name = "rdlegacy"
        Me.rdlegacy.Size = New System.Drawing.Size(67, 17)
        Me.rdlegacy.TabIndex = 0
        Me.rdlegacy.TabStop = True
        Me.rdlegacy.Text = "LEGACY"
        Me.rdlegacy.UseVisualStyleBackColor = True
        '
        'rdcrusader
        '
        Me.rdcrusader.AutoSize = True
        Me.rdcrusader.Location = New System.Drawing.Point(80, 20)
        Me.rdcrusader.Name = "rdcrusader"
        Me.rdcrusader.Size = New System.Drawing.Size(85, 17)
        Me.rdcrusader.TabIndex = 0
        Me.rdcrusader.TabStop = True
        Me.rdcrusader.Text = "CRUSADER"
        Me.rdcrusader.UseVisualStyleBackColor = True
        '
        'rdpremium
        '
        Me.rdpremium.AutoSize = True
        Me.rdpremium.Location = New System.Drawing.Point(16, 43)
        Me.rdpremium.Name = "rdpremium"
        Me.rdpremium.Size = New System.Drawing.Size(76, 17)
        Me.rdpremium.TabIndex = 0
        Me.rdpremium.TabStop = True
        Me.rdpremium.Text = "PREMIUM"
        Me.rdpremium.UseVisualStyleBackColor = True
        '
        'rdarm
        '
        Me.rdarm.AutoSize = True
        Me.rdarm.Location = New System.Drawing.Point(16, 20)
        Me.rdarm.Name = "rdarm"
        Me.rdarm.Size = New System.Drawing.Size(49, 17)
        Me.rdarm.TabIndex = 0
        Me.rdarm.TabStop = True
        Me.rdarm.Text = "ARM"
        Me.rdarm.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(Me.filelist)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(536, 172)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Files List "
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(236, 144)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(66, 13)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Browse Files"
        '
        'filelist
        '
        Me.filelist.Location = New System.Drawing.Point(11, 16)
        Me.filelist.Name = "filelist"
        Me.filelist.Size = New System.Drawing.Size(517, 121)
        Me.filelist.TabIndex = 0
        Me.filelist.UseCompatibleStateImageBehavior = False
        '
        'btnupload
        '
        Me.btnupload.Location = New System.Drawing.Point(99, 271)
        Me.btnupload.Name = "btnupload"
        Me.btnupload.Size = New System.Drawing.Size(109, 36)
        Me.btnupload.TabIndex = 2
        Me.btnupload.Text = "Upload Files"
        Me.btnupload.UseVisualStyleBackColor = True
        '
        'btnremove
        '
        Me.btnremove.Location = New System.Drawing.Point(217, 271)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(109, 36)
        Me.btnremove.TabIndex = 2
        Me.btnremove.Text = "Remove Files"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(336, 271)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(109, 36)
        Me.btncancel.TabIndex = 2
        Me.btncancel.Text = "Cancel "
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'frmfolder
        '
        Me.frmfolder.SelectedPath = "C:\"
        '
        'loadfile
        '
        Me.loadfile.Filter = "Excel Files|*.csv|Excel|*.xls|Excel 2007|*.xlsx"
        Me.loadfile.InitialDirectory = "c:\"
        Me.loadfile.Multiselect = True
        Me.loadfile.Title = "Import Files"
        '
        'frminportfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HarunnaYahaya.My.Resources.Resources.timerBG
        Me.ClientSize = New System.Drawing.Size(548, 319)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnremove)
        Me.Controls.Add(Me.btnupload)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frminportfiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Files"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdibtc As System.Windows.Forms.RadioButton
    Friend WithEvents rdtrust As System.Windows.Forms.RadioButton
    Friend WithEvents rdaiico As System.Windows.Forms.RadioButton
    Friend WithEvents rdpal As System.Windows.Forms.RadioButton
    Friend WithEvents rdfidelity As System.Windows.Forms.RadioButton
    Friend WithEvents rdsigma As System.Windows.Forms.RadioButton
    Friend WithEvents rdlegacy As System.Windows.Forms.RadioButton
    Friend WithEvents rdcrusader As System.Windows.Forms.RadioButton
    Friend WithEvents rdpremium As System.Windows.Forms.RadioButton
    Friend WithEvents rdarm As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents filelist As System.Windows.Forms.ListView
    Friend WithEvents btnupload As System.Windows.Forms.Button
    Friend WithEvents btnremove As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents frmfolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents loadfile As System.Windows.Forms.OpenFileDialog
End Class

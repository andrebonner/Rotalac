<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalPadForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalPadForm))
        Me.MainMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ViewStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandardViewStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScientificViewStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalText = New System.Windows.Forms.TextBox()
        Me.backspaceBtn = New System.Windows.Forms.Button()
        Me.ceBtn = New System.Windows.Forms.Button()
        Me.cBtn = New System.Windows.Forms.Button()
        Me.mcBtn = New System.Windows.Forms.Button()
        Me.mrBtn = New System.Windows.Forms.Button()
        Me.msBtn = New System.Windows.Forms.Button()
        Me.mpBtn = New System.Windows.Forms.Button()
        Me.sevenBtn = New System.Windows.Forms.Button()
        Me.fourBtn = New System.Windows.Forms.Button()
        Me.oneBtn = New System.Windows.Forms.Button()
        Me.zeroBtn = New System.Windows.Forms.Button()
        Me.eightBtn = New System.Windows.Forms.Button()
        Me.fiveBtn = New System.Windows.Forms.Button()
        Me.twoBtn = New System.Windows.Forms.Button()
        Me.pmBtn = New System.Windows.Forms.Button()
        Me.nineBtn = New System.Windows.Forms.Button()
        Me.sixBtn = New System.Windows.Forms.Button()
        Me.divideBtn = New System.Windows.Forms.Button()
        Me.timesBtn = New System.Windows.Forms.Button()
        Me.threeBtn = New System.Windows.Forms.Button()
        Me.minusBtn = New System.Windows.Forms.Button()
        Me.pointBtn = New System.Windows.Forms.Button()
        Me.plusBtn = New System.Windows.Forms.Button()
        Me.sqrtBtn = New System.Windows.Forms.Button()
        Me.percentBtn = New System.Windows.Forms.Button()
        Me.oneoverBtn = New System.Windows.Forms.Button()
        Me.equalBtn = New System.Windows.Forms.Button()
        Me.CalTest = New System.Windows.Forms.PictureBox()
        Me.MainMenuStrip.SuspendLayout()
        CType(Me.CalTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenuStrip
        '
        Me.MainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MainMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuStrip.Name = "MainMenuStrip"
        Me.MainMenuStrip.Size = New System.Drawing.Size(392, 24)
        Me.MainMenuStrip.TabIndex = 0
        Me.MainMenuStrip.Text = "MainMenuStrip"
        '
        'ViewStripMenuItem
        '
        Me.ViewStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StandardViewStripMenuItem, Me.ScientificViewStripMenuItem})
        Me.ViewStripMenuItem.Name = "ViewStripMenuItem"
        Me.ViewStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewStripMenuItem.Text = "&View"
        '
        'StandardViewStripMenuItem
        '
        Me.StandardViewStripMenuItem.Checked = True
        Me.StandardViewStripMenuItem.CheckOnClick = True
        Me.StandardViewStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StandardViewStripMenuItem.Name = "StandardViewStripMenuItem"
        Me.StandardViewStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.StandardViewStripMenuItem.Text = "Standard"
        '
        'ScientificViewStripMenuItem
        '
        Me.ScientificViewStripMenuItem.CheckOnClick = True
        Me.ScientificViewStripMenuItem.Enabled = False
        Me.ScientificViewStripMenuItem.Name = "ScientificViewStripMenuItem"
        Me.ScientificViewStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ScientificViewStripMenuItem.Text = "Scientific"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.toolStripSeparator4, Me.HistoryToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(141, 6)
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Enabled = False
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.HistoryToolStripMenuItem.Text = "&History"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(119, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'CalText
        '
        Me.CalText.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CalText.CausesValidation = False
        Me.CalText.Cursor = System.Windows.Forms.Cursors.Default
        Me.CalText.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalText.Location = New System.Drawing.Point(12, 28)
        Me.CalText.Multiline = True
        Me.CalText.Name = "CalText"
        Me.CalText.Size = New System.Drawing.Size(370, 31)
        Me.CalText.TabIndex = 1
        Me.CalText.TabStop = False
        Me.CalText.Text = "0."
        Me.CalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'backspaceBtn
        '
        Me.backspaceBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backspaceBtn.Location = New System.Drawing.Point(87, 80)
        Me.backspaceBtn.Name = "backspaceBtn"
        Me.backspaceBtn.Size = New System.Drawing.Size(91, 33)
        Me.backspaceBtn.TabIndex = 1
        Me.backspaceBtn.Text = "Backspace"
        Me.backspaceBtn.UseVisualStyleBackColor = True
        '
        'ceBtn
        '
        Me.ceBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ceBtn.Location = New System.Drawing.Point(189, 80)
        Me.ceBtn.Name = "ceBtn"
        Me.ceBtn.Size = New System.Drawing.Size(91, 33)
        Me.ceBtn.TabIndex = 2
        Me.ceBtn.Text = "CE"
        Me.ceBtn.UseVisualStyleBackColor = True
        '
        'cBtn
        '
        Me.cBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBtn.Location = New System.Drawing.Point(290, 80)
        Me.cBtn.Name = "cBtn"
        Me.cBtn.Size = New System.Drawing.Size(91, 33)
        Me.cBtn.TabIndex = 2
        Me.cBtn.Text = "C"
        Me.cBtn.UseVisualStyleBackColor = True
        '
        'mcBtn
        '
        Me.mcBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcBtn.Location = New System.Drawing.Point(12, 124)
        Me.mcBtn.Name = "mcBtn"
        Me.mcBtn.Size = New System.Drawing.Size(53, 33)
        Me.mcBtn.TabIndex = 3
        Me.mcBtn.Text = "MC"
        Me.mcBtn.UseVisualStyleBackColor = True
        '
        'mrBtn
        '
        Me.mrBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mrBtn.Location = New System.Drawing.Point(12, 163)
        Me.mrBtn.Name = "mrBtn"
        Me.mrBtn.Size = New System.Drawing.Size(53, 33)
        Me.mrBtn.TabIndex = 3
        Me.mrBtn.Text = "MR"
        Me.mrBtn.UseVisualStyleBackColor = True
        '
        'msBtn
        '
        Me.msBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msBtn.Location = New System.Drawing.Point(12, 202)
        Me.msBtn.Name = "msBtn"
        Me.msBtn.Size = New System.Drawing.Size(53, 33)
        Me.msBtn.TabIndex = 3
        Me.msBtn.Text = "MS"
        Me.msBtn.UseVisualStyleBackColor = True
        '
        'mpBtn
        '
        Me.mpBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mpBtn.Location = New System.Drawing.Point(12, 241)
        Me.mpBtn.Name = "mpBtn"
        Me.mpBtn.Size = New System.Drawing.Size(53, 33)
        Me.mpBtn.TabIndex = 3
        Me.mpBtn.Text = "M+"
        Me.mpBtn.UseVisualStyleBackColor = True
        '
        'sevenBtn
        '
        Me.sevenBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sevenBtn.Location = New System.Drawing.Point(87, 124)
        Me.sevenBtn.Name = "sevenBtn"
        Me.sevenBtn.Size = New System.Drawing.Size(53, 33)
        Me.sevenBtn.TabIndex = 3
        Me.sevenBtn.Text = "7"
        Me.sevenBtn.UseVisualStyleBackColor = True
        '
        'fourBtn
        '
        Me.fourBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fourBtn.Location = New System.Drawing.Point(87, 163)
        Me.fourBtn.Name = "fourBtn"
        Me.fourBtn.Size = New System.Drawing.Size(53, 33)
        Me.fourBtn.TabIndex = 3
        Me.fourBtn.Text = "4"
        Me.fourBtn.UseVisualStyleBackColor = True
        '
        'oneBtn
        '
        Me.oneBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oneBtn.Location = New System.Drawing.Point(87, 202)
        Me.oneBtn.Name = "oneBtn"
        Me.oneBtn.Size = New System.Drawing.Size(53, 33)
        Me.oneBtn.TabIndex = 3
        Me.oneBtn.Text = "1"
        Me.oneBtn.UseVisualStyleBackColor = True
        '
        'zeroBtn
        '
        Me.zeroBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zeroBtn.Location = New System.Drawing.Point(87, 241)
        Me.zeroBtn.Name = "zeroBtn"
        Me.zeroBtn.Size = New System.Drawing.Size(53, 33)
        Me.zeroBtn.TabIndex = 3
        Me.zeroBtn.Text = "0"
        Me.zeroBtn.UseVisualStyleBackColor = True
        '
        'eightBtn
        '
        Me.eightBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eightBtn.Location = New System.Drawing.Point(148, 124)
        Me.eightBtn.Name = "eightBtn"
        Me.eightBtn.Size = New System.Drawing.Size(53, 33)
        Me.eightBtn.TabIndex = 3
        Me.eightBtn.Text = "8"
        Me.eightBtn.UseVisualStyleBackColor = True
        '
        'fiveBtn
        '
        Me.fiveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fiveBtn.Location = New System.Drawing.Point(148, 163)
        Me.fiveBtn.Name = "fiveBtn"
        Me.fiveBtn.Size = New System.Drawing.Size(53, 33)
        Me.fiveBtn.TabIndex = 3
        Me.fiveBtn.Text = "5"
        Me.fiveBtn.UseVisualStyleBackColor = True
        '
        'twoBtn
        '
        Me.twoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.twoBtn.Location = New System.Drawing.Point(148, 202)
        Me.twoBtn.Name = "twoBtn"
        Me.twoBtn.Size = New System.Drawing.Size(53, 33)
        Me.twoBtn.TabIndex = 3
        Me.twoBtn.Text = "2"
        Me.twoBtn.UseVisualStyleBackColor = True
        '
        'pmBtn
        '
        Me.pmBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pmBtn.Location = New System.Drawing.Point(148, 241)
        Me.pmBtn.Name = "pmBtn"
        Me.pmBtn.Size = New System.Drawing.Size(53, 33)
        Me.pmBtn.TabIndex = 3
        Me.pmBtn.Text = "+/-"
        Me.pmBtn.UseVisualStyleBackColor = True
        '
        'nineBtn
        '
        Me.nineBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nineBtn.Location = New System.Drawing.Point(209, 124)
        Me.nineBtn.Name = "nineBtn"
        Me.nineBtn.Size = New System.Drawing.Size(53, 33)
        Me.nineBtn.TabIndex = 3
        Me.nineBtn.Text = "9"
        Me.nineBtn.UseVisualStyleBackColor = True
        '
        'sixBtn
        '
        Me.sixBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sixBtn.Location = New System.Drawing.Point(209, 163)
        Me.sixBtn.Name = "sixBtn"
        Me.sixBtn.Size = New System.Drawing.Size(53, 33)
        Me.sixBtn.TabIndex = 3
        Me.sixBtn.Text = "6"
        Me.sixBtn.UseVisualStyleBackColor = True
        '
        'divideBtn
        '
        Me.divideBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divideBtn.Location = New System.Drawing.Point(270, 124)
        Me.divideBtn.Name = "divideBtn"
        Me.divideBtn.Size = New System.Drawing.Size(53, 33)
        Me.divideBtn.TabIndex = 3
        Me.divideBtn.Text = "/"
        Me.divideBtn.UseVisualStyleBackColor = True
        '
        'timesBtn
        '
        Me.timesBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timesBtn.Location = New System.Drawing.Point(270, 163)
        Me.timesBtn.Name = "timesBtn"
        Me.timesBtn.Size = New System.Drawing.Size(53, 33)
        Me.timesBtn.TabIndex = 3
        Me.timesBtn.Text = "*"
        Me.timesBtn.UseVisualStyleBackColor = True
        '
        'threeBtn
        '
        Me.threeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.threeBtn.Location = New System.Drawing.Point(209, 202)
        Me.threeBtn.Name = "threeBtn"
        Me.threeBtn.Size = New System.Drawing.Size(53, 33)
        Me.threeBtn.TabIndex = 3
        Me.threeBtn.Text = "3"
        Me.threeBtn.UseVisualStyleBackColor = True
        '
        'minusBtn
        '
        Me.minusBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minusBtn.Location = New System.Drawing.Point(270, 202)
        Me.minusBtn.Name = "minusBtn"
        Me.minusBtn.Size = New System.Drawing.Size(53, 33)
        Me.minusBtn.TabIndex = 3
        Me.minusBtn.Text = "-"
        Me.minusBtn.UseVisualStyleBackColor = True
        '
        'pointBtn
        '
        Me.pointBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pointBtn.Location = New System.Drawing.Point(209, 241)
        Me.pointBtn.Name = "pointBtn"
        Me.pointBtn.Size = New System.Drawing.Size(53, 33)
        Me.pointBtn.TabIndex = 3
        Me.pointBtn.Text = "."
        Me.pointBtn.UseVisualStyleBackColor = True
        '
        'plusBtn
        '
        Me.plusBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plusBtn.Location = New System.Drawing.Point(270, 241)
        Me.plusBtn.Name = "plusBtn"
        Me.plusBtn.Size = New System.Drawing.Size(53, 33)
        Me.plusBtn.TabIndex = 3
        Me.plusBtn.Text = "+"
        Me.plusBtn.UseVisualStyleBackColor = True
        '
        'sqrtBtn
        '
        Me.sqrtBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sqrtBtn.Location = New System.Drawing.Point(329, 124)
        Me.sqrtBtn.Name = "sqrtBtn"
        Me.sqrtBtn.Size = New System.Drawing.Size(53, 33)
        Me.sqrtBtn.TabIndex = 3
        Me.sqrtBtn.Text = "sqrt"
        Me.sqrtBtn.UseVisualStyleBackColor = True
        '
        'percentBtn
        '
        Me.percentBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.percentBtn.Location = New System.Drawing.Point(329, 163)
        Me.percentBtn.Name = "percentBtn"
        Me.percentBtn.Size = New System.Drawing.Size(53, 33)
        Me.percentBtn.TabIndex = 3
        Me.percentBtn.Text = "%"
        Me.percentBtn.UseVisualStyleBackColor = True
        '
        'oneoverBtn
        '
        Me.oneoverBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oneoverBtn.Location = New System.Drawing.Point(329, 202)
        Me.oneoverBtn.Name = "oneoverBtn"
        Me.oneoverBtn.Size = New System.Drawing.Size(53, 33)
        Me.oneoverBtn.TabIndex = 3
        Me.oneoverBtn.Text = "1/x"
        Me.oneoverBtn.UseVisualStyleBackColor = True
        '
        'equalBtn
        '
        Me.equalBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equalBtn.Location = New System.Drawing.Point(329, 241)
        Me.equalBtn.Name = "equalBtn"
        Me.equalBtn.Size = New System.Drawing.Size(53, 33)
        Me.equalBtn.TabIndex = 3
        Me.equalBtn.Text = "="
        Me.equalBtn.UseVisualStyleBackColor = True
        '
        'CalTest
        '
        Me.CalTest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalTest.Location = New System.Drawing.Point(12, 80)
        Me.CalTest.Name = "CalTest"
        Me.CalTest.Size = New System.Drawing.Size(53, 33)
        Me.CalTest.TabIndex = 4
        Me.CalTest.TabStop = False
        '
        'CalPadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 290)
        Me.Controls.Add(Me.CalTest)
        Me.Controls.Add(Me.equalBtn)
        Me.Controls.Add(Me.plusBtn)
        Me.Controls.Add(Me.pmBtn)
        Me.Controls.Add(Me.pointBtn)
        Me.Controls.Add(Me.zeroBtn)
        Me.Controls.Add(Me.mpBtn)
        Me.Controls.Add(Me.oneoverBtn)
        Me.Controls.Add(Me.minusBtn)
        Me.Controls.Add(Me.threeBtn)
        Me.Controls.Add(Me.percentBtn)
        Me.Controls.Add(Me.twoBtn)
        Me.Controls.Add(Me.timesBtn)
        Me.Controls.Add(Me.oneBtn)
        Me.Controls.Add(Me.sqrtBtn)
        Me.Controls.Add(Me.fiveBtn)
        Me.Controls.Add(Me.divideBtn)
        Me.Controls.Add(Me.msBtn)
        Me.Controls.Add(Me.sixBtn)
        Me.Controls.Add(Me.eightBtn)
        Me.Controls.Add(Me.nineBtn)
        Me.Controls.Add(Me.fourBtn)
        Me.Controls.Add(Me.sevenBtn)
        Me.Controls.Add(Me.mrBtn)
        Me.Controls.Add(Me.mcBtn)
        Me.Controls.Add(Me.cBtn)
        Me.Controls.Add(Me.ceBtn)
        Me.Controls.Add(Me.backspaceBtn)
        Me.Controls.Add(Me.CalText)
        Me.Controls.Add(Me.MainMenuStrip)
        Me.MaximizeBox = False
        Me.Name = "CalPadForm"
        Me.Text = "CalPad"
        Me.MainMenuStrip.ResumeLayout(False)
        Me.MainMenuStrip.PerformLayout()
        CType(Me.CalTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalText As System.Windows.Forms.TextBox
    Friend WithEvents backspaceBtn As System.Windows.Forms.Button
    Friend WithEvents ceBtn As System.Windows.Forms.Button
    Friend WithEvents cBtn As System.Windows.Forms.Button
    Friend WithEvents mcBtn As System.Windows.Forms.Button
    Friend WithEvents mrBtn As System.Windows.Forms.Button
    Friend WithEvents msBtn As System.Windows.Forms.Button
    Friend WithEvents mpBtn As System.Windows.Forms.Button
    Friend WithEvents sevenBtn As System.Windows.Forms.Button
    Friend WithEvents fourBtn As System.Windows.Forms.Button
    Friend WithEvents oneBtn As System.Windows.Forms.Button
    Friend WithEvents zeroBtn As System.Windows.Forms.Button
    Friend WithEvents eightBtn As System.Windows.Forms.Button
    Friend WithEvents fiveBtn As System.Windows.Forms.Button
    Friend WithEvents twoBtn As System.Windows.Forms.Button
    Friend WithEvents pmBtn As System.Windows.Forms.Button
    Friend WithEvents nineBtn As System.Windows.Forms.Button
    Friend WithEvents sixBtn As System.Windows.Forms.Button
    Friend WithEvents divideBtn As System.Windows.Forms.Button
    Friend WithEvents timesBtn As System.Windows.Forms.Button
    Friend WithEvents threeBtn As System.Windows.Forms.Button
    Friend WithEvents minusBtn As System.Windows.Forms.Button
    Friend WithEvents pointBtn As System.Windows.Forms.Button
    Friend WithEvents plusBtn As System.Windows.Forms.Button
    Friend WithEvents sqrtBtn As System.Windows.Forms.Button
    Friend WithEvents percentBtn As System.Windows.Forms.Button
    Friend WithEvents oneoverBtn As System.Windows.Forms.Button
    Friend WithEvents equalBtn As System.Windows.Forms.Button
    Friend WithEvents CalTest As System.Windows.Forms.PictureBox
    Friend WithEvents StandardViewStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScientificViewStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

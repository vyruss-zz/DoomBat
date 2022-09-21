<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbHexen = New System.Windows.Forms.RadioButton()
        Me.rbHeretic = New System.Windows.Forms.RadioButton()
        Me.rbDoom2 = New System.Windows.Forms.RadioButton()
        Me.rbUltimateDoom = New System.Windows.Forms.RadioButton()
        Me.rbDoom = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWorkingDirectory = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbNightmare = New System.Windows.Forms.RadioButton()
        Me.rbHard = New System.Windows.Forms.RadioButton()
        Me.rbNormal = New System.Windows.Forms.RadioButton()
        Me.rbEasy = New System.Windows.Forms.RadioButton()
        Me.rbBaby = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbLevels = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbMap = New System.Windows.Forms.RadioButton()
        Me.rbTitle = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPWADs = New System.Windows.Forms.TextBox()
        Me.btnLaunchGameOnly = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbHexen)
        Me.GroupBox1.Controls.Add(Me.rbHeretic)
        Me.GroupBox1.Controls.Add(Me.rbDoom2)
        Me.GroupBox1.Controls.Add(Me.rbUltimateDoom)
        Me.GroupBox1.Controls.Add(Me.rbDoom)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select IWAD"
        '
        'rbHexen
        '
        Me.rbHexen.AutoSize = True
        Me.rbHexen.Location = New System.Drawing.Point(297, 19)
        Me.rbHexen.Name = "rbHexen"
        Me.rbHexen.Size = New System.Drawing.Size(56, 17)
        Me.rbHexen.TabIndex = 4
        Me.rbHexen.Text = "He&xen"
        Me.rbHexen.UseVisualStyleBackColor = True
        '
        'rbHeretic
        '
        Me.rbHeretic.AutoSize = True
        Me.rbHeretic.Location = New System.Drawing.Point(233, 19)
        Me.rbHeretic.Name = "rbHeretic"
        Me.rbHeretic.Size = New System.Drawing.Size(59, 17)
        Me.rbHeretic.TabIndex = 3
        Me.rbHeretic.Text = "&Heretic"
        Me.rbHeretic.UseVisualStyleBackColor = True
        '
        'rbDoom2
        '
        Me.rbDoom2.AutoSize = True
        Me.rbDoom2.Location = New System.Drawing.Point(165, 19)
        Me.rbDoom2.Name = "rbDoom2"
        Me.rbDoom2.Size = New System.Drawing.Size(62, 17)
        Me.rbDoom2.TabIndex = 2
        Me.rbDoom2.Text = "Doom &2"
        Me.rbDoom2.UseVisualStyleBackColor = True
        '
        'rbUltimateDoom
        '
        Me.rbUltimateDoom.AutoSize = True
        Me.rbUltimateDoom.Checked = True
        Me.rbUltimateDoom.Location = New System.Drawing.Point(65, 19)
        Me.rbUltimateDoom.Name = "rbUltimateDoom"
        Me.rbUltimateDoom.Size = New System.Drawing.Size(94, 17)
        Me.rbUltimateDoom.TabIndex = 1
        Me.rbUltimateDoom.TabStop = True
        Me.rbUltimateDoom.Text = "&Ultimate Doom"
        Me.rbUltimateDoom.UseVisualStyleBackColor = True
        '
        'rbDoom
        '
        Me.rbDoom.AutoSize = True
        Me.rbDoom.Location = New System.Drawing.Point(6, 19)
        Me.rbDoom.Name = "rbDoom"
        Me.rbDoom.Size = New System.Drawing.Size(53, 17)
        Me.rbDoom.TabIndex = 0
        Me.rbDoom.Text = "&Doom"
        Me.rbDoom.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Working Directory (ex c:\doom)"
        '
        'txtWorkingDirectory
        '
        Me.txtWorkingDirectory.Location = New System.Drawing.Point(12, 25)
        Me.txtWorkingDirectory.Name = "txtWorkingDirectory"
        Me.txtWorkingDirectory.Size = New System.Drawing.Size(353, 20)
        Me.txtWorkingDirectory.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbNightmare)
        Me.GroupBox2.Controls.Add(Me.rbHard)
        Me.GroupBox2.Controls.Add(Me.rbNormal)
        Me.GroupBox2.Controls.Add(Me.rbEasy)
        Me.GroupBox2.Controls.Add(Me.rbBaby)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(129, 140)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Skill"
        '
        'rbNightmare
        '
        Me.rbNightmare.AutoSize = True
        Me.rbNightmare.Location = New System.Drawing.Point(7, 115)
        Me.rbNightmare.Name = "rbNightmare"
        Me.rbNightmare.Size = New System.Drawing.Size(76, 17)
        Me.rbNightmare.TabIndex = 4
        Me.rbNightmare.Text = "Nightmare!"
        Me.rbNightmare.UseVisualStyleBackColor = True
        '
        'rbHard
        '
        Me.rbHard.AutoSize = True
        Me.rbHard.Checked = True
        Me.rbHard.Location = New System.Drawing.Point(7, 91)
        Me.rbHard.Name = "rbHard"
        Me.rbHard.Size = New System.Drawing.Size(90, 17)
        Me.rbHard.TabIndex = 3
        Me.rbHard.TabStop = True
        Me.rbHard.Text = "Ultra violence"
        Me.rbHard.UseVisualStyleBackColor = True
        '
        'rbNormal
        '
        Me.rbNormal.AutoSize = True
        Me.rbNormal.Location = New System.Drawing.Point(7, 67)
        Me.rbNormal.Name = "rbNormal"
        Me.rbNormal.Size = New System.Drawing.Size(93, 17)
        Me.rbNormal.TabIndex = 2
        Me.rbNormal.Text = "Hurt me plenty"
        Me.rbNormal.UseVisualStyleBackColor = True
        '
        'rbEasy
        '
        Me.rbEasy.AutoSize = True
        Me.rbEasy.Location = New System.Drawing.Point(7, 43)
        Me.rbEasy.Name = "rbEasy"
        Me.rbEasy.Size = New System.Drawing.Size(113, 17)
        Me.rbEasy.TabIndex = 1
        Me.rbEasy.Text = "Hey, not too rough"
        Me.rbEasy.UseVisualStyleBackColor = True
        '
        'rbBaby
        '
        Me.rbBaby.AutoSize = True
        Me.rbBaby.Location = New System.Drawing.Point(6, 19)
        Me.rbBaby.Name = "rbBaby"
        Me.rbBaby.Size = New System.Drawing.Size(117, 17)
        Me.rbBaby.TabIndex = 0
        Me.rbBaby.Text = "I'm too young to die"
        Me.rbBaby.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbLevels)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.rbMap)
        Me.GroupBox3.Controls.Add(Me.rbTitle)
        Me.GroupBox3.Location = New System.Drawing.Point(147, 107)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(218, 140)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Start Map"
        '
        'lbLevels
        '
        Me.lbLevels.FormattingEnabled = True
        Me.lbLevels.Location = New System.Drawing.Point(45, 65)
        Me.lbLevels.Name = "lbLevels"
        Me.lbLevels.Size = New System.Drawing.Size(120, 69)
        Me.lbLevels.Sorted = True
        Me.lbLevels.TabIndex = 8
        Me.lbLevels.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Level"
        Me.Label3.Visible = False
        '
        'rbMap
        '
        Me.rbMap.AutoSize = True
        Me.rbMap.Location = New System.Drawing.Point(6, 42)
        Me.rbMap.Name = "rbMap"
        Me.rbMap.Size = New System.Drawing.Size(74, 17)
        Me.rbMap.TabIndex = 2
        Me.rbMap.Text = "From map:"
        Me.rbMap.UseVisualStyleBackColor = True
        '
        'rbTitle
        '
        Me.rbTitle.AutoSize = True
        Me.rbTitle.Checked = True
        Me.rbTitle.Location = New System.Drawing.Point(6, 19)
        Me.rbTitle.Name = "rbTitle"
        Me.rbTitle.Size = New System.Drawing.Size(102, 17)
        Me.rbTitle.TabIndex = 1
        Me.rbTitle.TabStop = True
        Me.rbTitle.Text = "From title screen"
        Me.rbTitle.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(245, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Enter PWADs here (ex blah.wad foo.wad bar.wad)"
        '
        'txtPWADs
        '
        Me.txtPWADs.Location = New System.Drawing.Point(12, 266)
        Me.txtPWADs.Name = "txtPWADs"
        Me.txtPWADs.Size = New System.Drawing.Size(353, 20)
        Me.txtPWADs.TabIndex = 6
        '
        'btnLaunchGameOnly
        '
        Me.btnLaunchGameOnly.Location = New System.Drawing.Point(12, 292)
        Me.btnLaunchGameOnly.Name = "btnLaunchGameOnly"
        Me.btnLaunchGameOnly.Size = New System.Drawing.Size(83, 39)
        Me.btnLaunchGameOnly.TabIndex = 7
        Me.btnLaunchGameOnly.Text = "&Launch Game - no PWADs"
        Me.btnLaunchGameOnly.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(143, 292)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 39)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Launch Game with &PWADs"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(280, 292)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(85, 39)
        Me.btnQuit.TabIndex = 9
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 346)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLaunchGameOnly)
        Me.Controls.Add(Me.txtPWADs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtWorkingDirectory)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainForm"
        Me.Text = "Wad Launcher!"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbHexen As RadioButton
    Friend WithEvents rbHeretic As RadioButton
    Friend WithEvents rbDoom2 As RadioButton
    Friend WithEvents rbUltimateDoom As RadioButton
    Friend WithEvents rbDoom As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtWorkingDirectory As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbNightmare As RadioButton
    Friend WithEvents rbHard As RadioButton
    Friend WithEvents rbNormal As RadioButton
    Friend WithEvents rbEasy As RadioButton
    Friend WithEvents rbBaby As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rbMap As RadioButton
    Friend WithEvents rbTitle As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPWADs As TextBox
    Friend WithEvents btnLaunchGameOnly As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents lbLevels As ListBox
End Class

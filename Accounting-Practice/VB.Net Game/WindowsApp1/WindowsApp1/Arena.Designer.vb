<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Arena
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Character = New System.Windows.Forms.PictureBox()
        Me.lblLaser = New System.Windows.Forms.PictureBox()
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDown = New System.Windows.Forms.Timer(Me.components)
        Me.timLshoot = New System.Windows.Forms.Timer(Me.components)
        Me.timRshoot = New System.Windows.Forms.Timer(Me.components)
        Me.timUshoot = New System.Windows.Forms.Timer(Me.components)
        Me.timDshoot = New System.Windows.Forms.Timer(Me.components)
        Me.picEnemy1 = New System.Windows.Forms.PictureBox()
        Me.picEnemy4 = New System.Windows.Forms.PictureBox()
        Me.picEnemy3 = New System.Windows.Forms.PictureBox()
        Me.picEnemy2 = New System.Windows.Forms.PictureBox()
        Me.tmrOpp1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOpp2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOpp3 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOpp4 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOppLasers = New System.Windows.Forms.Timer(Me.components)
        Me.ArenaExit = New System.Windows.Forms.PictureBox()
        Me.tmrExitCol = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Character, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLaser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArenaExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Location = New System.Drawing.Point(-77, -172)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(2247, 222)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Location = New System.Drawing.Point(1730, -2)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(129, 1223)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox3.Location = New System.Drawing.Point(-120, 1134)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1954, 129)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox4.Location = New System.Drawing.Point(-94, -60)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(136, 1323)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'Character
        '
        Me.Character.BackColor = System.Drawing.Color.Transparent
        Me.Character.Location = New System.Drawing.Point(572, 362)
        Me.Character.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Character.Name = "Character"
        Me.Character.Size = New System.Drawing.Size(93, 155)
        Me.Character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Character.TabIndex = 4
        Me.Character.TabStop = False
        '
        'lblLaser
        '
        Me.lblLaser.BackColor = System.Drawing.Color.Red
        Me.lblLaser.Location = New System.Drawing.Point(614, 425)
        Me.lblLaser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblLaser.Name = "lblLaser"
        Me.lblLaser.Size = New System.Drawing.Size(15, 15)
        Me.lblLaser.TabIndex = 5
        Me.lblLaser.TabStop = False
        Me.lblLaser.Visible = False
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 1
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 1
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 1
        '
        'tmrDown
        '
        Me.tmrDown.Interval = 1
        '
        'timLshoot
        '
        Me.timLshoot.Interval = 1
        '
        'timRshoot
        '
        Me.timRshoot.Interval = 1
        '
        'timUshoot
        '
        Me.timUshoot.Interval = 1
        '
        'timDshoot
        '
        Me.timDshoot.Interval = 1
        '
        'picEnemy1
        '
        Me.picEnemy1.ImageLocation = "D:\Accounting-Practice\VB.Net Game\WindowsApp1\Resources\enemy.png"
        Me.picEnemy1.Location = New System.Drawing.Point(398, 58)
        Me.picEnemy1.Name = "picEnemy1"
        Me.picEnemy1.Size = New System.Drawing.Size(147, 162)
        Me.picEnemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEnemy1.TabIndex = 10
        Me.picEnemy1.TabStop = False
        '
        'picEnemy4
        '
        Me.picEnemy4.ImageLocation = "D:\Accounting-Practice\VB.Net Game\WindowsApp1\Resources\enemy.png"
        Me.picEnemy4.Location = New System.Drawing.Point(1270, 58)
        Me.picEnemy4.Name = "picEnemy4"
        Me.picEnemy4.Size = New System.Drawing.Size(147, 162)
        Me.picEnemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEnemy4.TabIndex = 11
        Me.picEnemy4.TabStop = False
        '
        'picEnemy3
        '
        Me.picEnemy3.ImageLocation = "D:\Accounting-Practice\VB.Net Game\WindowsApp1\Resources\enemy.png"
        Me.picEnemy3.Location = New System.Drawing.Point(968, 58)
        Me.picEnemy3.Name = "picEnemy3"
        Me.picEnemy3.Size = New System.Drawing.Size(147, 162)
        Me.picEnemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEnemy3.TabIndex = 12
        Me.picEnemy3.TabStop = False
        '
        'picEnemy2
        '
        Me.picEnemy2.ImageLocation = "D:\Accounting-Practice\VB.Net Game\WindowsApp1\Resources\enemy.png"
        Me.picEnemy2.Location = New System.Drawing.Point(666, 58)
        Me.picEnemy2.Name = "picEnemy2"
        Me.picEnemy2.Size = New System.Drawing.Size(147, 162)
        Me.picEnemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEnemy2.TabIndex = 13
        Me.picEnemy2.TabStop = False
        '
        'tmrOpp1
        '
        Me.tmrOpp1.Interval = 1
        '
        'tmrOpp2
        '
        Me.tmrOpp2.Interval = 1
        '
        'tmrOpp3
        '
        Me.tmrOpp3.Interval = 1
        '
        'tmrOpp4
        '
        Me.tmrOpp4.Interval = 1
        '
        'tmrOppLasers
        '
        Me.tmrOppLasers.Enabled = True
        Me.tmrOppLasers.Interval = 1
        '
        'ArenaExit
        '
        Me.ArenaExit.BackColor = System.Drawing.Color.Transparent
        Me.ArenaExit.ImageLocation = "D:\Accounting-Practice\VB.Net Game\WindowsApp1\Resources\arena_door.png"
        Me.ArenaExit.Location = New System.Drawing.Point(-3, 425)
        Me.ArenaExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ArenaExit.Name = "ArenaExit"
        Me.ArenaExit.Size = New System.Drawing.Size(122, 180)
        Me.ArenaExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ArenaExit.TabIndex = 14
        Me.ArenaExit.TabStop = False
        '
        'tmrExitCol
        '
        Me.tmrExitCol.Enabled = True
        Me.tmrExitCol.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'Arena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1473, 789)
        Me.Controls.Add(Me.ArenaExit)
        Me.Controls.Add(Me.picEnemy2)
        Me.Controls.Add(Me.picEnemy3)
        Me.Controls.Add(Me.picEnemy4)
        Me.Controls.Add(Me.picEnemy1)
        Me.Controls.Add(Me.lblLaser)
        Me.Controls.Add(Me.Character)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Arena"
        Me.Text = "Arena"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Character, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLaser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArenaExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Character As PictureBox
    Friend WithEvents lblLaser As PictureBox
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrDown As Timer
    Friend WithEvents timLshoot As Timer
    Friend WithEvents timRshoot As Timer
    Friend WithEvents timUshoot As Timer
    Friend WithEvents timDshoot As Timer
    Friend WithEvents picEnemy1 As PictureBox
    Friend WithEvents picEnemy4 As PictureBox
    Friend WithEvents picEnemy3 As PictureBox
    Friend WithEvents picEnemy2 As PictureBox
    Friend WithEvents tmrOpp1 As Timer
    Friend WithEvents tmrOpp2 As Timer
    Friend WithEvents tmrOpp3 As Timer
    Friend WithEvents tmrOpp4 As Timer
    Friend WithEvents tmrOppLasers As Timer
    Friend WithEvents ArenaExit As PictureBox
    Friend WithEvents tmrExitCol As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class

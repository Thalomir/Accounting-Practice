<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CharSelect
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
        Me.components = New System.ComponentModel.Container()
        Me.picMale = New System.Windows.Forms.PictureBox()
        Me.picFemale = New System.Windows.Forms.PictureBox()
        Me.picWarrior = New System.Windows.Forms.PictureBox()
        Me.picRobot = New System.Windows.Forms.PictureBox()
        Me.picTank = New System.Windows.Forms.PictureBox()
        Me.lblMale = New System.Windows.Forms.Label()
        Me.lblFemale = New System.Windows.Forms.Label()
        Me.lblWarrior = New System.Windows.Forms.Label()
        Me.lblRobot = New System.Windows.Forms.Label()
        Me.lblTank = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picAvatar = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.picMale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFemale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWarrior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRobot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMale
        '
        Me.picMale.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.picMale.ImageLocation = "D:\Accounting-Practice\VB.Net Game\WindowsApp1\Resources\male.png"
        Me.picMale.Location = New System.Drawing.Point(27, 35)
        Me.picMale.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picMale.Name = "picMale"
        Me.picMale.Size = New System.Drawing.Size(134, 132)
        Me.picMale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMale.TabIndex = 0
        Me.picMale.TabStop = False
        '
        'picFemale
        '
        Me.picFemale.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.picFemale.ImageLocation = "D:\Accounting-Practice\VB.Net Game\WindowsApp1\Resources\female.png"
        Me.picFemale.Location = New System.Drawing.Point(27, 223)
        Me.picFemale.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picFemale.Name = "picFemale"
        Me.picFemale.Size = New System.Drawing.Size(134, 132)
        Me.picFemale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFemale.TabIndex = 1
        Me.picFemale.TabStop = False
        '
        'picWarrior
        '
        Me.picWarrior.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.picWarrior.ImageLocation = "D:\Accounting-Practice\VB.Net Game\WindowsApp1\Resources\malewarrior.png"
        Me.picWarrior.Location = New System.Drawing.Point(248, 360)
        Me.picWarrior.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picWarrior.Name = "picWarrior"
        Me.picWarrior.Size = New System.Drawing.Size(148, 142)
        Me.picWarrior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWarrior.TabIndex = 2
        Me.picWarrior.TabStop = False
        '
        'picRobot
        '
        Me.picRobot.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.picRobot.ImageLocation = "D:\Accounting-Practice\VB.Net Game\WindowsApp1\Resources\malerobot.png"
        Me.picRobot.Location = New System.Drawing.Point(444, 360)
        Me.picRobot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picRobot.Name = "picRobot"
        Me.picRobot.Size = New System.Drawing.Size(148, 142)
        Me.picRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRobot.TabIndex = 3
        Me.picRobot.TabStop = False
        '
        'picTank
        '
        Me.picTank.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.picTank.ImageLocation = "D:\Accounting-Practice\VB.Net Game\WindowsApp1\Resources\maletank.png"
        Me.picTank.Location = New System.Drawing.Point(636, 360)
        Me.picTank.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picTank.Name = "picTank"
        Me.picTank.Size = New System.Drawing.Size(148, 142)
        Me.picTank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTank.TabIndex = 4
        Me.picTank.TabStop = False
        '
        'lblMale
        '
        Me.lblMale.AutoSize = True
        Me.lblMale.Location = New System.Drawing.Point(69, 172)
        Me.lblMale.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMale.Name = "lblMale"
        Me.lblMale.Size = New System.Drawing.Size(43, 20)
        Me.lblMale.TabIndex = 5
        Me.lblMale.Text = "Male"
        '
        'lblFemale
        '
        Me.lblFemale.AutoSize = True
        Me.lblFemale.Location = New System.Drawing.Point(52, 360)
        Me.lblFemale.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFemale.Name = "lblFemale"
        Me.lblFemale.Size = New System.Drawing.Size(62, 20)
        Me.lblFemale.TabIndex = 6
        Me.lblFemale.Text = "Female"
        '
        'lblWarrior
        '
        Me.lblWarrior.AutoSize = True
        Me.lblWarrior.Location = New System.Drawing.Point(290, 506)
        Me.lblWarrior.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWarrior.Name = "lblWarrior"
        Me.lblWarrior.Size = New System.Drawing.Size(60, 20)
        Me.lblWarrior.TabIndex = 7
        Me.lblWarrior.Text = "Warrior"
        '
        'lblRobot
        '
        Me.lblRobot.AutoSize = True
        Me.lblRobot.Location = New System.Drawing.Point(489, 506)
        Me.lblRobot.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRobot.Name = "lblRobot"
        Me.lblRobot.Size = New System.Drawing.Size(53, 20)
        Me.lblRobot.TabIndex = 8
        Me.lblRobot.Text = "Robot"
        '
        'lblTank
        '
        Me.lblTank.AutoSize = True
        Me.lblTank.Location = New System.Drawing.Point(681, 506)
        Me.lblTank.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTank.Name = "lblTank"
        Me.lblTank.Size = New System.Drawing.Size(44, 20)
        Me.lblTank.TabIndex = 9
        Me.lblTank.Text = "Tank"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.ImageLocation = "D:\Accounting-Practice\VB.Net Game\WindowsApp1\Resources\pic1.PNG"
        Me.PictureBox1.Location = New System.Drawing.Point(350, 223)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(334, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'picAvatar
        '
        Me.picAvatar.BackColor = System.Drawing.Color.Transparent
        Me.picAvatar.Location = New System.Drawing.Point(426, 55)
        Me.picAvatar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picAvatar.Name = "picAvatar"
        Me.picAvatar.Size = New System.Drawing.Size(166, 217)
        Me.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAvatar.TabIndex = 11
        Me.picAvatar.TabStop = False
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(768, 135)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 92)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CharSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 538)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.picAvatar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTank)
        Me.Controls.Add(Me.lblRobot)
        Me.Controls.Add(Me.lblWarrior)
        Me.Controls.Add(Me.lblFemale)
        Me.Controls.Add(Me.lblMale)
        Me.Controls.Add(Me.picTank)
        Me.Controls.Add(Me.picRobot)
        Me.Controls.Add(Me.picWarrior)
        Me.Controls.Add(Me.picFemale)
        Me.Controls.Add(Me.picMale)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CharSelect"
        Me.Text = "CharSelect"
        CType(Me.picMale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFemale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWarrior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRobot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picMale As PictureBox
    Friend WithEvents picFemale As PictureBox
    Friend WithEvents picWarrior As PictureBox
    Friend WithEvents picRobot As PictureBox
    Friend WithEvents picTank As PictureBox
    Friend WithEvents lblMale As Label
    Friend WithEvents lblFemale As Label
    Friend WithEvents lblWarrior As Label
    Friend WithEvents lblRobot As Label
    Friend WithEvents lblTank As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picAvatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
End Class

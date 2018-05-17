<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Ply = New System.Windows.Forms.PictureBox()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDown = New System.Windows.Forms.Timer(Me.components)
        Me.timLShoot = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblLaser = New System.Windows.Forms.PictureBox()
        Me.timRshoot = New System.Windows.Forms.Timer(Me.components)
        Me.timDshoot = New System.Windows.Forms.Timer(Me.components)
        Me.timUshoot = New System.Windows.Forms.Timer(Me.components)
        Me.timLaserCol = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Ply, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLaser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ply
        '
        Me.Ply.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Ply.Location = New System.Drawing.Point(508, 306)
        Me.Ply.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ply.Name = "Ply"
        Me.Ply.Size = New System.Drawing.Size(51, 49)
        Me.Ply.TabIndex = 0
        Me.Ply.TabStop = False
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 10
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 10
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 10
        '
        'tmrDown
        '
        Me.tmrDown.Interval = 10
        '
        'timLShoot
        '
        Me.timLShoot.Interval = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Location = New System.Drawing.Point(-476, -3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(520, 1729)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Location = New System.Drawing.Point(-22, 1583)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(2888, 946)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox3.Location = New System.Drawing.Point(2790, -148)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1317, 1772)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox4.Location = New System.Drawing.Point(-106, -669)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(2946, 725)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'lblLaser
        '
        Me.lblLaser.BackColor = System.Drawing.Color.Red
        Me.lblLaser.Location = New System.Drawing.Point(528, 306)
        Me.lblLaser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblLaser.Name = "lblLaser"
        Me.lblLaser.Size = New System.Drawing.Size(15, 15)
        Me.lblLaser.TabIndex = 5
        Me.lblLaser.TabStop = False
        Me.lblLaser.Visible = False
        '
        'timRshoot
        '
        Me.timRshoot.Interval = 1
        '
        'timDshoot
        '
        Me.timDshoot.Interval = 1
        '
        'timUshoot
        '
        Me.timUshoot.Interval = 1
        '
        'timLaserCol
        '
        Me.timLaserCol.Enabled = True
        Me.timLaserCol.Interval = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 648)
        Me.Controls.Add(Me.lblLaser)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Ply)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Ply, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLaser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ply As PictureBox
    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrDown As Timer
    Friend WithEvents timLShoot As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblLaser As PictureBox
    Friend WithEvents timRshoot As Timer
    Friend WithEvents timDshoot As Timer
    Friend WithEvents timUshoot As Timer
    Friend WithEvents timLaserCol As Timer
End Class

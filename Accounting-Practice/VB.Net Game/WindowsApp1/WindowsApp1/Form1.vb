Public Class Form1
    Public Avatar As player
    Public temp As player10
    Public NewHigh As player10
    Dim objects() As PictureBox = {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10, PictureBox11, ArenaEntrance, Chest}
    Public Collisions(55) As Sides
    Dim arrWeapons(3) As weapon
    Dim PlayerWeapon As weapon
    Public top10players(10) As String
    Public players(10) As player10
    Dim Rshoot As Boolean
    Dim Lshoot As Boolean
    Dim Ushoot As Boolean
    Dim Dshoot As Boolean
    Dim path1 As String
    Dim D As Integer
    Dim U As Integer
    Dim L As Integer
    Dim R As Integer
    Dim c As Integer
    Dim bullet As laser
    Dim i As Integer
    Dim col As Integer
    Structure player10

        Dim score As Integer
        Dim name As String

    End Structure

    Structure weapon

        Dim Color As String
        Dim path As String
        Dim Name As String

    End Structure


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Path As String
        Dim i As Integer
        Dim strout As String
        Me.AutoScroll = False
        objects(0) = Me.PictureBox1
        objects(1) = Me.PictureBox2
        objects(2) = Me.PictureBox3
        objects(3) = Me.PictureBox4
        i = 0
        col = 0

        Path = "D:\Accounting-Practice\VB.Net Game\WindowsApp1\Resources\leaderboard.txt"

        FileOpen()

    End Sub
    Structure laser

        Dim x1 As Integer
        Dim y1 As Integer
        Dim x2 As Integer
        Dim y2 As Integer
        Dim slopex As Integer
        Dim slopey As Integer
        Dim slopexint As Integer
        Dim slopeyint As Integer

    End Structure

    Structure Sides
        Dim Right As Boolean
        Dim Left As Boolean
        Dim Top As Boolean
        Dim Bottom As Boolean
    End Structure



    Structure player
        Dim Score As Integer
        Dim inv() As String
        Dim i As Integer
        Dim Left As Double
        Dim Right As Double
        Dim Top As Double
        Dim Bottom As Double
        Dim Gender As String
        Dim SubType As String
        Dim name As String

    End Structure



    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.D
                tmrLeft.Enabled = False
                tmrRight.Enabled = True
                Rshoot = True
                Lshoot = False
                Ushoot = False
                Dshoot = False
            Case Keys.A
                tmrRight.Enabled = False
                tmrLeft.Enabled = True
                Lshoot = True
                Rshoot = False
                Ushoot = False
                Dshoot = False
            Case Keys.W
                tmrDown.Enabled = False
                tmrUp.Enabled = True
                Ushoot = True
                Dshoot = False
                Lshoot = False
                Rshoot = False
            Case Keys.S
                tmrUp.Enabled = False
                tmrDown.Enabled = True
                Dshoot = True
                Ushoot = False
                Lshoot = False
                Rshoot = False
            Case Keys.Space
                My.Computer.Audio.Play("D:\Accounting-Practice\VB.Net Game\WindowsApp1\Resources\Laser.wav", AudioPlayMode.Background)
                If Lshoot = True Then
                    timLShoot.Enabled = True
                    lblLaser.Visible = True
                End If
                If Rshoot = True Then
                    timRshoot.Enabled = True
                    lblLaser.Visible = True
                End If
                If Ushoot = True Then
                    timUshoot.Enabled = True
                    lblLaser.Visible = True
                End If
                If Dshoot = True Then
                    timDshoot.Enabled = True
                    lblLaser.Visible = True
                End If

        End Select
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.D
                tmrRight.Enabled = False
            Case Keys.A
                tmrLeft.Enabled = False
            Case Keys.W
                tmrUp.Enabled = False
            Case Keys.S
                tmrDown.Enabled = False
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        Dim objects() As PictureBox = {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10, PictureBox11, ArenaEntrance, Chest}

        For x = 0 To objects.Length - 1
            objects(x).Left -= 3
        Next

        For x = 0 To objects.Length - 1
            If Ply.Bounds.IntersectsWith(objects(x).Bounds) And objects(x).Name <> ArenaEntrance.Name Then
                c += 1
            End If
        Next

        If c <> 0 Then
            For x = 0 To objects.Length - 1
                objects(x).Left += 6
            Next
        End If

        c = 0

    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        Dim objects() As PictureBox = {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10, PictureBox11, ArenaEntrance, Chest}


        For x = 0 To objects.Length - 1
            objects(x).Left += 3
        Next

        For x = 0 To objects.Length - 1
            If Ply.Bounds.IntersectsWith(objects(x).Bounds) And objects(x).Name <> ArenaEntrance.Name Then
                c += 1
            End If
        Next

        If c <> 0 Then
            For x = 0 To objects.Length - 1
                objects(x).Left -= 6
            Next
        End If

        c = 0

    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        Dim objects() As PictureBox = {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10, PictureBox11, ArenaEntrance, Chest}

        For x = 0 To objects.Length - 1
            objects(x).Top += 3
        Next

        For x = 0 To objects.Length - 1
            If Ply.Bounds.IntersectsWith(objects(x).Bounds) And objects(x).Name <> ArenaEntrance.Name Then
                c += 1
            End If
        Next

        If c <> 0 Then
            For X = 0 To objects.Length - 1
                objects(X).Top -= 6
            Next
        End If

        c = 0

    End Sub

    Private Sub tmrDown_Tick(sender As Object, e As EventArgs) Handles tmrDown.Tick
        Dim objects() As PictureBox = {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10, PictureBox11, ArenaEntrance, Chest}

        For x = 0 To objects.Length - 1
            objects(x).Top -= 3
        Next

        For x = 0 To objects.Length - 1
            If Ply.Bounds.IntersectsWith(objects(x).Bounds) And objects(x).Name <> ArenaEntrance.Name Then
                c += 1
            End If
        Next

        If c <> 0 Then
            For X = 0 To objects.Length - 1
                objects(X).Top += 6
            Next
        End If

        c = 0

    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

    End Sub


    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick

        If Dshoot = True Then
            timDshoot.Enabled = True
        ElseIf Ushoot = True Then
            timUshoot.Enabled = True
        ElseIf Lshoot = True Then
            timLShoot.Enabled = True
        ElseIf Rshoot = True Then
            timRshoot.Enabled = True
        End If
    End Sub

    Private Sub timLShoot_Tick(sender As Object, e As EventArgs) Handles timLShoot.Tick
        If i <= 30 Then
            lblLaser.Left -= 5
            i = i + 1
        End If
        If i = 31 Then
            lblLaser.Visible = False
            lblLaser.Top = Ply.Top + (Ply.Height / 2)
            lblLaser.Left = Ply.Left + (Ply.Width / 2)
            i = i + 1
        End If
        If i = 32 Then
            i = 0
            timLShoot.Enabled = False
        End If
    End Sub

    Private Sub timRshoot_Tick(sender As Object, e As EventArgs) Handles timRshoot.Tick
        If i <= 30 Then
            lblLaser.Left += 5
            i = i + 1
        End If
        If i = 31 Then
            lblLaser.Visible = False
            lblLaser.Top = Ply.Top + (Ply.Height / 2)
            lblLaser.Left = Ply.Left + (Ply.Width / 2)
            i = i + 1
        End If
        If i = 32 Then
            i = 0
            timRshoot.Enabled = False
        End If
    End Sub

    Private Sub timDshoot_Tick(sender As Object, e As EventArgs) Handles timDshoot.Tick
        If i <= 30 Then
            lblLaser.Top += 5
            i = i + 1
        End If
        If i = 31 Then
            lblLaser.Visible = False
            lblLaser.Top = Ply.Top + (Ply.Height / 2)
            lblLaser.Left = Ply.Left + (Ply.Width / 2)
            i = i + 1
        End If
        If i = 32 Then
            i = 0
            timDshoot.Enabled = False
        End If
    End Sub

    Private Sub timUshoot_Tick(sender As Object, e As EventArgs) Handles timUshoot.Tick
        If i <= 30 Then
            lblLaser.Top -= 5
            i = i + 1
        End If
        If i = 31 Then
            lblLaser.Visible = False
            lblLaser.Top = Ply.Top + (Ply.Height / 2)
            lblLaser.Left = Ply.Left + (Ply.Width / 2)
            i = i + 1
        End If
        If i = 32 Then
            i = 0
            timUshoot.Enabled = False
        End If
    End Sub

    Private Sub timLaserCol_Tick(sender As Object, e As EventArgs) Handles timLaserCol.Tick

        For x = 0 To objects.Length - 1
            If lblLaser.Bounds.IntersectsWith(objects(x).Bounds) Then
                col += 1
            End If
        Next

        If col > 0 Then
            lblLaser.Visible = False
            lblLaser.Top = Ply.Top
            lblLaser.Left = Ply.Left
            col = 0
            timDshoot.Enabled = False
            timUshoot.Enabled = False
            timLShoot.Enabled = False
            timRshoot.Enabled = False
        End If

    End Sub

    Private Sub timArenaCol_Tick(sender As Object, e As EventArgs) Handles timArenaCol.Tick

        Dim objects() As PictureBox = {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10, PictureBox11, ArenaEntrance, Chest}

        If Ply.Bounds.IntersectsWith(ArenaEntrance.Bounds) Then

            Arena.Show()
            Arena.Character.ImageLocation = Ply.ImageLocation
            For i = 0 To objects.Length - 1
                objects(i).Left += 12
            Next
            Me.Hide()
            Arena.tmrOpp1.Enabled = True
            Arena.tmrOpp2.Enabled = True
            Arena.tmrOpp3.Enabled = True
            Arena.tmrOpp4.Enabled = True
        End If

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub MenuStrip1_Click(sender As Object, e As EventArgs) Handles MenuStrip1.Click

        Form2.Show()

    End Sub

    Private Sub Chest_Click(sender As Object, e As EventArgs) Handles Chest.Click
        Dim number As Integer

        number = Int(Rnd() * 3) + 1

        Chest.ImageLocation = "D:\Accounting-Practice\VB.Net Game\WindowsApp1\Resources\Weapons\Longsword.png"
        lblLaser.BackColor = Color.Blue
        Arena.lblLaser.BackColor = Color.Blue


    End Sub
End Class

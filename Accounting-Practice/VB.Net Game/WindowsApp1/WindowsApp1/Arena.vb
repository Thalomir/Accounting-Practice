Public Class Arena
    Dim RShoot As Boolean
    Dim Lshoot As Boolean
    Dim Ushoot As Boolean
    Dim Dshoot As Boolean
    Dim i As Integer
    Dim c As Integer
    Dim O1 As Integer
    Dim O2 As Integer
    Dim O3 As Integer
    Dim O4 As Integer

    Private Sub Arena_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        O1 = 0
        O2 = 0
        O3 = 0
        O4 = 0
    End Sub

    Private Sub Arena_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick

        Dim objects() As PictureBox = {PictureBox1, PictureBox2, PictureBox3, PictureBox4, picEnemy1, picEnemy2, picEnemy3, picEnemy4, ArenaExit}

        For x = 0 To objects.Length - 1
            objects(x).Left += 3
        Next

        For x = 0 To objects.Length - 1
            If Character.Bounds.IntersectsWith(objects(x).Bounds) And objects(x).Name <> ArenaExit.Name Then
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

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick

        Dim objects() As PictureBox = {PictureBox1, PictureBox2, PictureBox3, PictureBox4, picEnemy1, picEnemy2, picEnemy3, picEnemy4, ArenaExit}

        For x = 0 To objects.Length - 1
            objects(x).Left -= 3
        Next

        For x = 0 To objects.Length - 1
            If Character.Bounds.IntersectsWith(objects(x).Bounds) And objects(x).Name <> ArenaExit.Name Then
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

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick

        Dim objects() As PictureBox = {PictureBox1, PictureBox2, PictureBox3, PictureBox4, picEnemy1, picEnemy2, picEnemy3, picEnemy4, ArenaExit}

        For x = 0 To objects.Length - 1
            objects(x).Top += 3
        Next

        For x = 0 To objects.Length - 1
            If Character.Bounds.IntersectsWith(objects(x).Bounds) And objects(x).Name <> ArenaExit.Name Then
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

        Dim objects() As PictureBox = {PictureBox1, PictureBox2, PictureBox3, PictureBox4, picEnemy1, picEnemy2, picEnemy3, picEnemy4, ArenaExit}

        For x = 0 To objects.Length - 1
            objects(x).Top -= 3
        Next

        For x = 0 To objects.Length - 1
            If Character.Bounds.IntersectsWith(objects(x).Bounds) And objects(x).Name <> ArenaExit.Name Then
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

    Private Sub timLshoot_Tick(sender As Object, e As EventArgs) Handles timLshoot.Tick

        If i <= 10 Then
            lblLaser.Left -= 5
            i += 1
        End If
        If i = 11 Then
            lblLaser.Visible = False
            lblLaser.Top = Character.Top + (Character.Height / 2)
            lblLaser.Left = Character.Left + (Character.Width / 2)
            i += 1
        End If
        If i = 12 Then
            i = 0
            timLshoot.Enabled = False
        End If

    End Sub

    Private Sub timRshoot_Tick(sender As Object, e As EventArgs) Handles timRshoot.Tick

        If i <= 10 Then
            lblLaser.Left += 5
            i += 1
        End If
        If i = 11 Then
            lblLaser.Visible = False
            lblLaser.Top = Character.Top + (Character.Height / 2)
            lblLaser.Left = Character.Left + (Character.Width / 2)
            i += 1
        End If
        If i = 12 Then
            i = 0
            timRshoot.Enabled = False
        End If

    End Sub

    Private Sub timUshoot_Tick(sender As Object, e As EventArgs) Handles timUshoot.Tick

        If i <= 10 Then
            lblLaser.Top -= 5
            i += 1
        End If
        If i = 11 Then
            lblLaser.Visible = False
            lblLaser.Top = Character.Top + (Character.Height / 2)
            lblLaser.Left = Character.Left + (Character.Width / 2)
            i += 1
        End If
        If i = 12 Then
            i = 0
            timUshoot.Enabled = False
        End If

    End Sub

    Private Sub timDshoot_Tick(sender As Object, e As EventArgs) Handles timDshoot.Tick

        If i <= 10 Then
            lblLaser.Top += 5
            i += 1
        End If
        If i = 11 Then
            lblLaser.Visible = False
            lblLaser.Top = Character.Top + (Character.Height / 2)
            lblLaser.Left = Character.Left + (Character.Width / 2)
            i += 1
        End If
        If i = 12 Then
            i = 0
            timDshoot.Enabled = False
        End If

    End Sub

    Private Sub Arena_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
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

    Private Sub tmrOppLasers_Tick(sender As Object, e As EventArgs) Handles tmrOppLasers.Tick

        Dim enemies() As PictureBox = {picEnemy1, picEnemy2, picEnemy3, picEnemy4}

        For i = 0 To enemies.Length - 1
            If lblLaser.Bounds.IntersectsWith(enemies(i).Bounds) Then
                c += 1
                enemies(i).Visible = False
                enemies(i).Top = 5000
                enemies(i).Left = 5000
                lblLaser.Visible = False
                lblLaser.Top = Character.Top + (Character.Height / 2)
                lblLaser.Left = Character.Left + (Character.Width / 2)
                timDshoot.Enabled = False
                timUshoot.Enabled = False
                timRshoot.Enabled = False
                timLshoot.Enabled = False
                Form1.Avatar.Score += 1
            End If
        Next

    End Sub

    Private Sub tmrOpp1_Tick(sender As Object, e As EventArgs) Handles tmrOpp1.Tick

        If O1 <= 20 Then
            picEnemy1.Top += 5
            O1 += 1
        ElseIf O1 > 20 And O1 <= 40 Then
            picEnemy1.Top -= 5
            O1 += 1
        ElseIf O1 = 41 Then
            O1 = 0
        End If

    End Sub

    Private Sub tmrOpp2_Tick(sender As Object, e As EventArgs) Handles tmrOpp2.Tick

        If O2 <= 20 Then
            picEnemy2.Top += 5
            O2 += 1
        ElseIf O2 > 20 And O2 <= 40 Then
            picEnemy2.Top -= 5
            O2 += 1
        ElseIf O2 = 41 Then
            O2 = 0
        End If

    End Sub

    Private Sub tmrOpp3_Tick(sender As Object, e As EventArgs) Handles tmrOpp3.Tick

        If O3 <= 20 Then
            picEnemy3.Top += 5
            O3 += 1
        ElseIf O3 > 20 And O3 <= 40 Then
            picEnemy3.Top -= 5
            O3 += 1
        ElseIf O3 = 41 Then
            O3 = 0
        End If

    End Sub

    Private Sub tmrOpp4_Tick(sender As Object, e As EventArgs) Handles tmrOpp4.Tick

        If O4 <= 20 Then
            picEnemy4.Top += 5
            O4 += 1
        ElseIf O4 > 20 And O4 <= 40 Then
            picEnemy4.Top -= 5
            O4 += 1
        ElseIf O4 = 41 Then
            O4 = 0
        End If

    End Sub

    Private Sub tmrExitCol_Tick(sender As Object, e As EventArgs) Handles tmrExitCol.Tick

        Dim objects() As PictureBox = {PictureBox1, PictureBox2, PictureBox3, PictureBox4, picEnemy1, picEnemy2, picEnemy3, picEnemy4, ArenaExit}

        If Character.Bounds.IntersectsWith(ArenaExit.Bounds) Then

            Form1.Show()
            Form1.Ply.ImageLocation = Character.ImageLocation
            For i = 0 To objects.Length - 1
                objects(i).Left -= 6
            Next
            Me.Hide()
            tmrOpp1.Enabled = False
            tmrOpp2.Enabled = False
            tmrOpp3.Enabled = False
            tmrOpp4.Enabled = False

            picEnemy1.Visible = True
            picEnemy2.Visible = True
            picEnemy3.Visible = True
            picEnemy4.Visible = True
            picEnemy1.Top = (PictureBox1.Top + PictureBox1.Height) + 20
            picEnemy1.Left = (PictureBox1.Left + 103)
            picEnemy2.Top = (PictureBox1.Top + PictureBox1.Height) + 2
            picEnemy2.Left = picEnemy1.Left + (picEnemy1.Width)
            picEnemy3.Top = (PictureBox1.Top + PictureBox1.Height) + 2
            picEnemy2.Left = picEnemy2.Left + (picEnemy1.Width)
            picEnemy4.Top = (PictureBox1.Top + PictureBox1.Height) + 2
            picEnemy2.Left = picEnemy3.Left + (picEnemy1.Width)

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

        Dim enemies() As PictureBox = {picEnemy1, picEnemy2, picEnemy3, picEnemy4}

        For i = 0 To enemies.Length - 1
            If Character.Bounds.IntersectsWith(enemies(i).Bounds) Then
                MsgBox("You have lost in the arena")
                Me.Hide()
                Form1.Show()
                Form1.Avatar.Score = 0
            End If
        Next

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Dim enemies() As PictureBox = {picEnemy1, picEnemy2, picEnemy3, picEnemy4}
        Dim z As Integer

        For i = 0 To enemies.length - 1
            If Character.Bounds.IntersectsWith(enemies(i).bounds) Then
                z += 1
            End If
        Next

        If z <> 0 Then
            MsgBox("You have lost in the arena!")
            Me.Hide()
            Form1.Show()
            Form1.Avatar.Score = 0
            tmrOpp1.Enabled = False
            tmrOpp2.Enabled = False
            tmrOpp3.Enabled = False
            tmrOpp4.Enabled = False
            tmrUp.Enabled = False
            tmrDown.Enabled = False
            tmrRight.Enabled = False
            tmrLeft.Enabled = False
            z = 0
        End If

    End Sub
End Class
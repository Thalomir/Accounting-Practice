Public Class Form1
    Dim Avatar As player
    Dim objects() As PictureBox = {PictureBox1, PictureBox2, PictureBox3, PictureBox4}
    Public Collisions(55) As Sides
    Dim RCol As Boolean
    Dim LCol As Boolean
    Dim UCol As Boolean
    Dim DCol As Boolean
    Dim c As Integer
    Dim bullet As laser
    Dim i As Integer




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = False
        objects(0) = Me.PictureBox1
        objects(1) = Me.PictureBox2
        objects(2) = Me.PictureBox3
        objects(3) = Me.PictureBox4
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

    End Structure



    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.D
                tmrLeft.Enabled = False
                tmrRight.Enabled = True
            Case Keys.A
                tmrRight.Enabled = False
                tmrLeft.Enabled = True
            Case Keys.W
                tmrDown.Enabled = False
                tmrUp.Enabled = True
            Case Keys.S
                tmrUp.Enabled = False
                tmrDown.Enabled = True
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
        Dim objects() As PictureBox = {PictureBox1, PictureBox2, PictureBox3, PictureBox4}

        For x = 0 To objects.Length - 1
            objects(x).Left -= 3
        Next

        For x = 0 To objects.Length - 1
            If Ply.Bounds.IntersectsWith(objects(x).Bounds) Then
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
        Dim objects() As PictureBox = {PictureBox1, PictureBox2, PictureBox3, PictureBox4}


        For x = 0 To objects.Length - 1
            objects(x).Left += 3
        Next

        For x = 0 To objects.Length - 1
            If Ply.Bounds.IntersectsWith(objects(x).Bounds) Then
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
        Dim objects() As PictureBox = {PictureBox1, PictureBox2, PictureBox3, PictureBox4}

        For x = 0 To objects.Length - 1
            objects(x).Top += 3
        Next

        For x = 0 To objects.Length - 1
            If Ply.Bounds.IntersectsWith(objects(x).Bounds) Then
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
        Dim objects() As PictureBox = {PictureBox1, PictureBox2, PictureBox3, PictureBox4}

        For x = 0 To objects.Length - 1
            objects(x).Top -= 3
        Next

        For x = 0 To objects.Length - 1
            If Ply.Bounds.IntersectsWith(objects(x).Bounds) Then
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

        lblLaser.Left = Ply.Left
        lblLaser.Top = Ply.Top
        bullet.x1 = Ply.Location.X
        bullet.y1 = Ply.Location.Y
        bullet.x2 = Cursor.Position.X
        bullet.y2 = Cursor.Position.Y
        bullet.slopex = bullet.x2 - bullet.x1
        bullet.slopey = bullet.y2 - bullet.y2
        i = 0
        timLazers.Enabled = True
        lblLaser.Visible = True

    End Sub

    Private Sub timLazers_Tick(sender As Object, e As EventArgs) Handles timLazers.Tick

        If lblLaser.Location.X <> bullet.x2 Then
            lblLaser.Left += bullet.slopex
            lblLaser.Top += bullet.slopey
        ElseIf lblLaser.Location.X = bullet.x2 Then
            lblLaser.Visible = False
            lblLaser.Top = Ply.Top
            lblLaser.Left = Ply.Left
            i = 0
            timLazers.Enabled = False
        End If

    End Sub
End Class

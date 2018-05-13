Public Class Form1
    Dim Avatar As player
    Dim objects() As PictureBox = {PictureBox2, PictureBox3, PictureBox4, PictureBox5}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = False


    End Sub
    Structure player
        Dim Score As Integer
        Dim inv() As String
        Dim i As Integer
        Dim Left As Double
        Dim Right As Double
        Dim Top As Double
        Dim Bottom As Double

        Function RCol() As Boolean
            Top = Form1.Ply.Top
            Bottom = Form1.Ply.Top + Form1.Ply.Height
            Left = Form1.Ply.Left
            Right = Form1.Ply.Left + Form1.Ply.Width
            Dim objects() As PictureBox = {Form1.PictureBox2, Form1.PictureBox3, Form1.PictureBox4, Form1.PictureBox5}

            ' For i = 1 To (objects.Length - 1)
            '   If Right >= objects(i).Left Then
            '  If Top < objects(i).Top And Top < objects(i).Top + objects(i).Height Then
            '     Return True
            ' End If
            ' If Bottom > objects(i).Top + objects(i).Height And Bottom < objects(i).Top Then
            '    Return True
            ' End If
            ' Else
            ' Return False

            ' End If
            'Next


        End Function

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
        Dim objects() As PictureBox = {PictureBox2, PictureBox3, PictureBox4, PictureBox5}

        For x = 0 To objects.Length - 1
            objects(x).Left -= 3
            If Ply.Bounds.IntersectsWith(objects(x).Bounds) Then
                objects(x).Left += 3
            Else

            End If
        Next
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        Dim objects() As PictureBox = {PictureBox2, PictureBox3, PictureBox4, PictureBox5}

        For x = 0 To objects.Length - 1
            objects(x).Left += 3
            If Ply.Bounds.IntersectsWith(objects(x).Bounds) Then
                objects(x).Left -= 3
            Else

            End If
        Next
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        Dim objects() As PictureBox = {PictureBox2, PictureBox3, PictureBox4, PictureBox5}

        For x = 0 To objects.Length - 1
            objects(x).Top += 3
            If Ply.Bounds.IntersectsWith(objects(x).Bounds) Then
                objects(x).Top -= 3
            Else

            End If
        Next
    End Sub

    Private Sub tmrDown_Tick(sender As Object, e As EventArgs) Handles tmrDown.Tick
        Dim objects() As PictureBox = {PictureBox2, PictureBox3, PictureBox4, PictureBox5}

        For x = 0 To objects.Length - 1
            objects(x).Top -= 3
            If Ply.Bounds.IntersectsWith(objects(x).Bounds) Then
                objects(x).Top += 3
            Else

            End If
        Next
    End Sub

End Class

Public Class Arena
    Public check As Integer
    Dim enemyarray(8) As PictureBox
    Dim RShoot As Boolean
    Dim Lshoot As Boolean
    Dim Ushoot As Boolean
    Dim Dshoot As Boolean
    Dim i As Integer
    Dim arrLasers() As PictureBox = {Laser1, Laser2, Laser3, Laser4, Laser5}

    Private Sub Arena_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enemyarray(1) = PictureBox5
        enemyarray(2) = PictureBox6
        enemyarray(3) = PictureBox7
        enemyarray(4) = PictureBox8
        enemyarray(5) = PictureBox9
        enemyarray(6) = PictureBox10
        enemyarray(7) = PictureBox11
        enemyarray(8) = PictureBox12
        Timer1.Enabled = True

    End Sub

    Private Sub Arena_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.D
                tmrLeft.Enabled = False
                tmrRight.Enabled = True
                RShoot = True
                Lshoot = False
                Ushoot = False
                Dshoot = False
            Case Keys.A
                tmrRight.Enabled = False
                tmrLeft.Enabled = True
                Lshoot = True
                RShoot = False
                Ushoot = False
                Dshoot = False
            Case Keys.W
                tmrDown.Enabled = False
                tmrUp.Enabled = True
                Ushoot = True
                Dshoot = False
                Lshoot = False
                RShoot = False
            Case Keys.S
                tmrUp.Enabled = False
                tmrDown.Enabled = True
                Dshoot = True
                Ushoot = False
                Lshoot = False
                RShoot = False
            Case Keys.Space
                If Lshoot = True Then
                    timLshoot.Enabled = True
                    arrLasers(i).Visible = True
                    If i <> 5 Then
                        i += 1
                    ElseIf i = 5 Then
                        i = 0
                    End If
                End If
                If RShoot = True Then
                    timRshoot.Enabled = True
                    arrLasers(i).Visible = True
                    If i <> 5 Then
                        i += 1
                    ElseIf i = 5 Then
                        i = 0
                    End If
                End If
                If Ushoot = True Then
                    timUshoot.Enabled = True
                    arrLasers(i).Visible = True
                    If i <> 5 Then
                        i += 1
                    ElseIf i = 5 Then
                        i = 0
                    End If
                End If
                If Dshoot = True Then
                    timDshoot.Enabled = True
                    arrLasers(i).Visible = True
                    If i <> 5 Then
                        i += 1
                    ElseIf i = 5 Then
                        i = 0
                    End If
                End If

        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim objects() As PictureBox = {PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10, PictureBox11, PictureBox12}

        For x = 0 To objects.Length - 1
            objects(x).Left += 3

            If objects(x).Left + objects(x).Width = PictureBox2.Left Then
                objects(x).Left += 3
            End If


        Next



    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick

    End Sub

    Private Sub timLshoot_Tick(sender As Object, e As EventArgs) Handles timLshoot.Tick

    End Sub

    Private Sub tmrDown_Tick(sender As Object, e As EventArgs)

    End Sub
End Class
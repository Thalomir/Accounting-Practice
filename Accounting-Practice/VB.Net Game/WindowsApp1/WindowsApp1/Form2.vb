Public Class Form2
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click

        Me.Hide()

    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        If Form1.Avatar.Score > Form1.players(10).score Then
            Dim Name As String
            Dim path As String
            Dim strout As String

            Name = Form1.Avatar.name
            Path = "D:\TopTen.dat"



            For I = 1 To 10
                If Form1.Avatar.Score > Form1.players(I).score Then
                    Form1.NewHigh.score = Form1.Avatar.Score
                    Form1.NewHigh.name = Name

                    For J = (I) To 10
                        Form1.temp = Form1.players(J)
                        Form1.players(J) = Form1.NewHigh
                        Form1.NewHigh = Form1.temp
                    Next J
                    Exit For
                End If
            Next I

            Kill(Path)
            ListBox1.Items.Clear()
            FileOpen(1, Path, OpenMode.Random, OpenAccess.Write)
            For I = 1 To 10
                FilePut(1, Form1.players(I))
                strout = Form1.players(I).name + " - " + Str(Form1.players(I).score)
                ListBox1.Items.Add(strout)
            Next I
            FileClose(1)
        Else
            MsgBox("Sorry, you have not yet beat anyone's score on the leaderboard")
        End If
    End Sub
End Class
Public Class CharSelect
    Private Sub picMale_Click(sender As Object, e As EventArgs) Handles picMale.Click

        Form1.Avatar.Gender = "Male"

        picWarrior.ImageLocation = "D:\Accounting-Practice\VB.Net Game\WindowsApp1\Resources\malewarrior.png"
        picRobot.ImageLocation = "D:\Accounting-Practice\VB.Net Game\WindowsApp1\Resources\malerobot.png"
        picTank.ImageLocation = "D:\Accounting-Practice\VB.Net Game\WindowsApp1\Resources\maletank.png"

    End Sub

    Private Sub picFemale_Click(sender As Object, e As EventArgs) Handles picFemale.Click

        Form1.Avatar.Gender = "Female"

        picWarrior.ImageLocation = "D:\Accounting-Practice\VB.Net Game\WindowsApp1\Resources\femalewarrior.png"
        picRobot.ImageLocation = "D:\Accounting-Practice\VB.Net Game\WindowsApp1\Resources\femalerobot.png"
        picTank.ImageLocation = "D:\Accounting-Practice\VB.Net Game\WindowsApp1\Resources\femaletank.png"

    End Sub

    Private Sub picWarrior_Click(sender As Object, e As EventArgs) Handles picWarrior.Click

        Form1.Avatar.SubType = "Warrior"

        picAvatar.ImageLocation = picWarrior.ImageLocation

    End Sub

    Private Sub picRobot_Click(sender As Object, e As EventArgs) Handles picRobot.Click

        Form1.Avatar.SubType = "Robot"

        picAvatar.ImageLocation = picRobot.ImageLocation

    End Sub

    Private Sub picTank_Click(sender As Object, e As EventArgs) Handles picTank.Click

        Form1.Avatar.SubType = "Tank"

        picAvatar.ImageLocation = picTank.ImageLocation

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form1.Avatar.name = InputBox("What is your initials?")
        Form1.Show()
        Form1.Ply.ImageLocation = picAvatar.ImageLocation
        Me.Hide()


    End Sub

    Private Sub CharSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
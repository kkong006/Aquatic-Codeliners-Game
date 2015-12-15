Public Class Form5

        Dim shapes(0 To 9) As Microsoft.VisualBasic.PowerPacks.OvalShape
        Dim speed(0 To 9) As Integer
        Dim score As Integer
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shapes(0) = ovl0
        shapes(1) = ovl1
        shapes(2) = ovl2
        shapes(3) = ovl3
        shapes(4) = ovl4
        shapes(5) = ovl5
        shapes(6) = ovl6
        shapes(7) = ovl7
        shapes(8) = ovl8
        shapes(9) = ovl9

        For i = 0 To 9
            shapes(i).Top = -(Me.Width * Rnd()) - 50
            speed(i) = (Rnd() * 3) + 2
        Next
    End Sub
        Private Sub tmrGo_Tick(sender As Object, e As EventArgs) Handles tmrGo.Tick

        For i = 0 To 9
            shapes(i).Top += speed(i)
            If shapes(i).Top > Me.Height Then
                shapes(i).Top = -50
                speed(i) = (Rnd() * 3) + 2
            End If
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        tmrGo.Enabled = True
        tmrTime.Enabled = True
        lblDrop.Visible = False
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        tmrGo.Enabled = False
        tmrTime.Enabled = False
    End Sub

    Private Sub reset()
        For i = 0 To 9
            shapes(i).Top = -(Me.Width * Rnd())
            speed(i) = (Rnd() * 3) + 2
        Next
        score = 0
        lblScore.Text = score.ToString
        pbrPlay.Value = 25
    End Sub

    Private Sub tmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        If pbrPlay.Value > 1 Then
            pbrPlay.Value -= 1
            chk()
        Else
            tmrGo.Enabled = False
            tmrTime.Enabled = False
        End If
    End Sub
    Private Sub hit(i As Integer)
        score += 1
        lblScore.Text = score.ToString
        shapes(i).Top = -(Me.Width * Rnd())
        speed(i) = (Rnd() * 3) + 2
    End Sub
    Private Sub chk()
        For i = 0 To 9
            If shapes(i).Bounds.IntersectsWith(lblStop.Bounds) Then
                lblDrop.Visible = True
                lblDrop.Text = "You Lose!"
                tmrGo.Enabled = False
                tmrTime.Enabled = False
                btnHome.Visible = True
            end if
        Next
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        reset()
    End Sub

    Private Sub BlackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackToolStripMenuItem.Click
        Me.BackColor = Color.Black
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.BackColor = Color.White
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        Me.BackColor = Color.Blue
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.BackColor = Color.Red
    End Sub
    Private Sub shp0_MouseEnter(sender As Object, e As EventArgs) Handles ovl0.MouseEnter
        hit(0)
    End Sub

    Private Sub shp1_MouseEnter(sender As Object, e As EventArgs) Handles ovl1.MouseEnter
        hit(1)
    End Sub

    Private Sub shp2_MouseEnter(sender As Object, e As EventArgs) Handles ovl2.MouseEnter
        hit(2)
    End Sub

    Private Sub shp3_MouseEnter(sender As Object, e As EventArgs) Handles ovl3.MouseEnter
        hit(3)
    End Sub

    Private Sub shp4_MouseEnter(sender As Object, e As EventArgs) Handles ovl4.MouseEnter
        hit(4)
    End Sub

    Private Sub shp5_MouseEnter(sender As Object, e As EventArgs) Handles ovl5.MouseEnter
        hit(5)
    End Sub

    Private Sub shp6_MouseEnter(sender As Object, e As EventArgs) Handles ovl6.MouseEnter
        hit(6)
    End Sub

    Private Sub shp7_MouseEnter(sender As Object, e As EventArgs) Handles ovl7.MouseEnter
        hit(7)
    End Sub

    Private Sub shp8_MouseEnter(sender As Object, e As EventArgs) Handles ovl8.MouseEnter
        hit(8)
    End Sub

    Private Sub shp9_MouseEnter(sender As Object, e As EventArgs) Handles ovl9.MouseEnter
        hit(9)
    End Sub

    Private Sub NavyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NavyToolStripMenuItem.Click
        Me.BackColor = Color.Navy
    End Sub

    Private Sub SkyBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SkyBlueToolStripMenuItem.Click
        Me.BackColor = Color.SkyBlue
    End Sub

    Private Sub AliceBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AliceBlueToolStripMenuItem.Click
        Me.BackColor = Color.AliceBlue
    End Sub


    Private Sub AquaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AquaToolStripMenuItem.Click
        Me.BackColor = Color.MidnightBlue
    End Sub

    Private Sub IndianRedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndianRedToolStripMenuItem.Click
        Me.BackColor = Color.IndianRed
    End Sub

    Private Sub MaroonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaroonToolStripMenuItem.Click
        Me.BackColor = Color.Maroon
    End Sub

    Private Sub MistyRoseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MistyRoseToolStripMenuItem.Click
        Me.BackColor = Color.MistyRose
    End Sub

    Private Sub FireBrickToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FireBrickToolStripMenuItem.Click
        Me.BackColor = Color.Firebrick
    End Sub

    Private Sub SpringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpringToolStripMenuItem.Click
        Me.BackColor = Color.SpringGreen
    End Sub

    Private Sub LimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimeToolStripMenuItem.Click
        Me.BackColor = Color.Lime
    End Sub

    Private Sub PaleGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaleGreenToolStripMenuItem.Click
        Me.BackColor = Color.PaleGreen
    End Sub

    Private Sub ForestGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForestGreenToolStripMenuItem.Click
        Me.BackColor = Color.ForestGreen
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        Me.BackColor = Color.Green
    End Sub

    Private Sub YellowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YellowToolStripMenuItem.Click
        Me.BackColor = Color.Yellow
    End Sub

    Private Sub GoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoldToolStripMenuItem.Click
        Me.BackColor = Color.Gold
    End Sub

    Private Sub GoldenRodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoldenRodToolStripMenuItem.Click
        Me.BackColor = Color.Goldenrod
    End Sub

    Private Sub WheatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WheatToolStripMenuItem.Click
        Me.BackColor = Color.Wheat
    End Sub

    Private Sub KhakiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KhakiToolStripMenuItem.Click
        Me.BackColor = Color.Khaki
    End Sub

    Private Sub NavajoWhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NavajoWhiteToolStripMenuItem.Click
        Me.BackColor = Color.NavajoWhite
    End Sub

    Private Sub AntiqueWhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AntiqueWhiteToolStripMenuItem.Click
        Me.BackColor = Color.AntiqueWhite
    End Sub

    Private Sub FloralWhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FloralWhiteToolStripMenuItem.Click
        Me.BackColor = Color.FloralWhite
    End Sub

    Private Sub BeigeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeigeToolStripMenuItem.Click
        Me.BackColor = Color.Beige
    End Sub


    Private Sub IvoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IvoryToolStripMenuItem.Click
        Me.BackColor = Color.Ivory
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.BackColor = Color.Gray
    End Sub

    Private Sub SlateGrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlateGrayToolStripMenuItem.Click
        Me.BackColor = Color.SlateGray
    End Sub
    Private Sub DimGrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DimGrayToolStripMenuItem.Click
        Me.BackColor = Color.DimGray
    End Sub

    Private Sub SilverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightSlateGrayToolStripMenuItem.Click
        Me.BackColor = Color.Silver
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Form1.show()

    End Sub
End Class
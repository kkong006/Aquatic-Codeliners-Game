Public Class Form1
    Dim play As Boolean
    Dim topWalls(0 To 11) As Label
    Dim bottomWalls(0 To 12) As Label
    Dim waterDrops As Integer
    Dim waters(0 To 4) As PictureBox
    Dim obstacles(0 To 14) As PictureBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        topWalls(0) = topWall0
        topWalls(1) = topWall1
        topWalls(2) = topWall2
        topWalls(3) = topWall3
        topWalls(4) = topWall4
        topWalls(5) = topWall5
        topWalls(6) = topWall6
        topWalls(7) = topWall7
        topWalls(8) = topWall8
        topWalls(9) = topWall9
        topWalls(10) = topWall10
        topWalls(11) = topWall11

        bottomWalls(0) = bottomWall0
        bottomWalls(1) = bottomWall1
        bottomWalls(2) = bottomWall2
        bottomWalls(3) = bottomWall3
        bottomWalls(4) = bottomWall4
        bottomWalls(5) = bottomWall5
        bottomWalls(6) = bottomWall6
        bottomWalls(7) = bottomWall7
        bottomWalls(8) = bottomWall8
        bottomWalls(9) = bottomWall9
        bottomWalls(10) = bottomWall10
        bottomWalls(11) = bottomWall11
        bottomWalls(12) = bottomWall12

        waters(0) = picWater1
        waters(1) = picWater2
        waters(2) = picWater3
        waters(3) = picWater4
        waters(4) = picWater5

        obstacles(0) = picPool
        obstacles(1) = picFlower
        obstacles(2) = picSink1
        obstacles(3) = picSink2
        obstacles(4) = picSink3
        obstacles(5) = picShower
        obstacles(6) = picShower2
        obstacles(7) = picToilet1
        obstacles(8) = picToilet2
        obstacles(9) = picSprinklers
        obstacles(10) = picSprinklers2
        obstacles(11) = picSprinklers3
        obstacles(12) = picSprinklers4
        obstacles(13) = picDishwasher
        obstacles(14) = picWasher

        lblDude.Left = 443
        lblDude.Top = 381
    End Sub
    Private Sub picWaterCalc_Click(sender As Object, e As EventArgs) Handles picWaterCalc.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub chk()
        If lblDude.Bounds.IntersectsWith(picPool.Bounds) Then
            lblInfo.Visible = True
            lblInfo.Text = "If you fill your pool for 30 minutes a week, you will use 273 gallons of water. THAT'S A LOT!"
            tmrWater.Enabled = True

        ElseIf lblDude.Bounds.IntersectsWith(picFlower.Bounds) Then
            lblInfo.Visible = True
            lblInfo.Text = "Switch out your window boxes with fake flowers to save a little water."
            tmrWater.Enabled = True

        ElseIf lblDude.Bounds.IntersectsWith(picSink1.Bounds) Then
            lblInfo.Visible = True
            lblInfo.Text = "Washing your dishes by hand uses 40 gallons of water!"
            tmrWater.Enabled = True
            Me.Hide()
            Form5.Show()

        ElseIf lblDude.Bounds.IntersectsWith(picSink2.Bounds) Or lblDude.Bounds.IntersectsWith(picSink3.Bounds) Then
            lblInfo.Visible = True
            lblInfo.Text = "Running your sink for 8 minutes uses 32 gallons of water!"
            tmrWater.Enabled = True

        ElseIf lblDude.Bounds.IntersectsWith(picShower.Bounds) Or lblDude.Bounds.IntersectsWith(picShower2.Bounds) Then
            lblInfo.Visible = True
            lblInfo.Text = "Did you know that taking a 15 minute shower every day uses 420 gallons of water a week! YIKES!!!"
            tmrWater.Enabled = True

        ElseIf lblDude.Bounds.IntersectsWith(picToilet1.Bounds) Or lblDude.Bounds.IntersectsWith(picToilet2.Bounds) Then
            lblInfo.Visible = True
            lblInfo.Text = "An older model toilet uses 7 gallons per flush while a newer model toilet uses 1.6 gallons per flush."
            tmrWater.Enabled = True

        ElseIf lblDude.Bounds.IntersectsWith(picSprinklers.Bounds) Or lblDude.Bounds.IntersectsWith(picSprinklers2.Bounds) Or lblDude.Bounds.IntersectsWith(picSprinklers3.Bounds) Or lblDude.Bounds.IntersectsWith(picSprinklers4.Bounds) Or lblDude.Bounds.IntersectsWith(picGarden.Bounds) Then
            lblInfo.Visible = True
            lblInfo.Text = "Watering a yard for a longer period of time makes plants more drought resistant. Watering 3 times per week for 15 minutes uses 100 gallons of water a week."
            tmrWater.Enabled = True

        ElseIf lblDude.Bounds.IntersectsWith(picDishwasher.Bounds) Then
            lblInfo.Visible = True
            lblInfo.Text = "A dishwasher uses 6 gallons of water per cycle and 4 gallons of water per cycle if it is an Energystar."
            tmrWater.Enabled = True

        ElseIf lblDude.Bounds.IntersectsWith(picWasher.Bounds) Then
            lblInfo.Visible = True
            lblInfo.Text = "An old washing machine uses 40 gallons of water per load; an Energy Star washer uses 27 gallons per load"
            tmrWater.Enabled = True

        Else
            lblInfo.Visible = False
            lblInfo.Text = ""
            tmrWater.Enabled = False
        End If
    End Sub

    Private Sub tmrPlay_Tick(sender As Object, e As EventArgs) Handles tmrPlay.Tick
        play = True
        pbrPlay.Value -= 1
        If pbrPlay.Value = 0 Then
            Me.Hide()
            Form2.Show()
            tmrPlay.Enabled = False
        End If

    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        If play = True Then
            lblDude.Image = lblRight.Image
            lblDude.Left += 5
            chkwall()
            chk()
            'chkFinish()

        End If
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        If play = True Then
            lblDude.Image = lblLeft.Image
            lblDude.Left -= 5
            chkwall()
            chk()
            'chkFinish()

        End If
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        If play = True Then
            lblDude.Top -= 5
            chkwall()
            chk()
            'chkFinish()

        End If
    End Sub

    Private Sub tmrDown_Tick(sender As Object, e As EventArgs) Handles tmrDown.Tick
        If play = True Then
            lblDude.Top += 5
            chkwall()
            chk()
            'chkFinish()

        End If
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = 37 Then 'left
            tmrLeft.Enabled = True

        ElseIf e.KeyValue = 38 Then 'up
            tmrUp.Enabled = True

        ElseIf e.KeyValue = 39 Then ' right
            tmrRight.Enabled = True

        ElseIf e.KeyValue = 40 Then ' down
            tmrDown.Enabled = True
        ElseIf e.KeyValue = 32 Then 'space bar
            play = True

        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = 37 Then 'left
            tmrLeft.Enabled = False

        ElseIf e.KeyValue = 38 Then 'up
            tmrUp.Enabled = False

        ElseIf e.KeyValue = 39 Then ' right
            tmrRight.Enabled = False

        ElseIf e.KeyValue = 40 Then ' down
            tmrDown.Enabled = False

        End If
    End Sub
    Private Sub chkwall()
        For i = 0 To 11
            If lblDude.Bounds.IntersectsWith(topWalls(i).Bounds) Then
                lblDude.Left = 431
                lblDude.Top = 318
            End If
        Next
        For x = 0 To 12
            If lblDude.Bounds.IntersectsWith(bottomWalls(x).Bounds) Then
                lblDude.Left = 735
                lblDude.Top = 598
            End If
        Next
    End Sub

    Private Sub tmrWater_Tick(sender As Object, e As EventArgs) Handles tmrWater.Tick
        If waterDrops < 5 Then
            waters(waterDrops).Visible = False
        ElseIf waterDrops = 5 And pbrPlay.Value > 0 Then
            Me.Hide()
            Form3.Show()
        End If
        waterDrops += 1
    End Sub


End Class

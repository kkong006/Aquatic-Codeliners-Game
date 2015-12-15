<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblDrop = New System.Windows.Forms.Label()
        Me.pbrPlay = New System.Windows.Forms.ProgressBar()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IvoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FloralWhiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeigeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AntiqueWhiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavajoWhiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightSlateGrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SlateGrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DimGrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AliceBlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SkyBlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AquaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MistyRoseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndianRedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FireBrickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaroonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaleGreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForestGreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YellowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KhakiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WheatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoldenRodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblStop = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.ovl9 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ovl7 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ovl6 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ovl3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ovl2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ovl0 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ovl1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ovl5 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ovl4 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ovl8 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGo = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(199, 573)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(127, 38)
        Me.btnHome.TabIndex = 9
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        Me.btnHome.Visible = False
        '
        'lblDrop
        '
        Me.lblDrop.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrop.ForeColor = System.Drawing.Color.Aqua
        Me.lblDrop.Location = New System.Drawing.Point(42, 277)
        Me.lblDrop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDrop.Name = "lblDrop"
        Me.lblDrop.Size = New System.Drawing.Size(457, 121)
        Me.lblDrop.TabIndex = 8
        Me.lblDrop.Text = "Use your mouse to catch all of the water droplets! Press File>Play to begin!"
        Me.lblDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbrPlay
        '
        Me.pbrPlay.Location = New System.Drawing.Point(17, 573)
        Me.pbrPlay.Margin = New System.Windows.Forms.Padding(4)
        Me.pbrPlay.Maximum = 25
        Me.pbrPlay.Name = "pbrPlay"
        Me.pbrPlay.Size = New System.Drawing.Size(500, 31)
        Me.pbrPlay.TabIndex = 7
        Me.pbrPlay.Value = 25
        '
        'lblScore
        '
        Me.lblScore.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.Aqua
        Me.lblScore.Location = New System.Drawing.Point(188, 36)
        Me.lblScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(168, 47)
        Me.lblScore.TabIndex = 10
        Me.lblScore.Text = "0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(530, 36)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayToolStripMenuItem, Me.PauseToolStripMenuItem, Me.ResetToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 32)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(134, 32)
        Me.PlayToolStripMenuItem.Text = "Play"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(134, 32)
        Me.PauseToolStripMenuItem.Text = "Pause"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(134, 32)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(134, 32)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WhiteToolStripMenuItem, Me.BlackToolStripMenuItem, Me.BlueToolStripMenuItem, Me.RedToolStripMenuItem, Me.GreenToolStripMenuItem, Me.YellowToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(192, 32)
        Me.SettingsToolStripMenuItem.Text = "BackGround Colors"
        '
        'WhiteToolStripMenuItem
        '
        Me.WhiteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IvoryToolStripMenuItem, Me.FloralWhiteToolStripMenuItem, Me.BeigeToolStripMenuItem, Me.AntiqueWhiteToolStripMenuItem, Me.NavajoWhiteToolStripMenuItem})
        Me.WhiteToolStripMenuItem.Name = "WhiteToolStripMenuItem"
        Me.WhiteToolStripMenuItem.Size = New System.Drawing.Size(141, 32)
        Me.WhiteToolStripMenuItem.Text = "White"
        '
        'IvoryToolStripMenuItem
        '
        Me.IvoryToolStripMenuItem.Name = "IvoryToolStripMenuItem"
        Me.IvoryToolStripMenuItem.Size = New System.Drawing.Size(210, 32)
        Me.IvoryToolStripMenuItem.Text = "Ivory"
        '
        'FloralWhiteToolStripMenuItem
        '
        Me.FloralWhiteToolStripMenuItem.Name = "FloralWhiteToolStripMenuItem"
        Me.FloralWhiteToolStripMenuItem.Size = New System.Drawing.Size(210, 32)
        Me.FloralWhiteToolStripMenuItem.Text = "Floral White"
        '
        'BeigeToolStripMenuItem
        '
        Me.BeigeToolStripMenuItem.Name = "BeigeToolStripMenuItem"
        Me.BeigeToolStripMenuItem.Size = New System.Drawing.Size(210, 32)
        Me.BeigeToolStripMenuItem.Text = "Beige"
        '
        'AntiqueWhiteToolStripMenuItem
        '
        Me.AntiqueWhiteToolStripMenuItem.Name = "AntiqueWhiteToolStripMenuItem"
        Me.AntiqueWhiteToolStripMenuItem.Size = New System.Drawing.Size(210, 32)
        Me.AntiqueWhiteToolStripMenuItem.Text = "Antique White"
        '
        'NavajoWhiteToolStripMenuItem
        '
        Me.NavajoWhiteToolStripMenuItem.Name = "NavajoWhiteToolStripMenuItem"
        Me.NavajoWhiteToolStripMenuItem.Size = New System.Drawing.Size(210, 32)
        Me.NavajoWhiteToolStripMenuItem.Text = "Navajo White"
        '
        'BlackToolStripMenuItem
        '
        Me.BlackToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LightSlateGrayToolStripMenuItem, Me.GreyToolStripMenuItem, Me.SlateGrayToolStripMenuItem, Me.DimGrayToolStripMenuItem})
        Me.BlackToolStripMenuItem.Name = "BlackToolStripMenuItem"
        Me.BlackToolStripMenuItem.Size = New System.Drawing.Size(141, 32)
        Me.BlackToolStripMenuItem.Text = "Black"
        '
        'LightSlateGrayToolStripMenuItem
        '
        Me.LightSlateGrayToolStripMenuItem.Name = "LightSlateGrayToolStripMenuItem"
        Me.LightSlateGrayToolStripMenuItem.Size = New System.Drawing.Size(173, 32)
        Me.LightSlateGrayToolStripMenuItem.Text = "Silver"
        '
        'GreyToolStripMenuItem
        '
        Me.GreyToolStripMenuItem.Name = "GreyToolStripMenuItem"
        Me.GreyToolStripMenuItem.Size = New System.Drawing.Size(173, 32)
        Me.GreyToolStripMenuItem.Text = "Gray"
        '
        'SlateGrayToolStripMenuItem
        '
        Me.SlateGrayToolStripMenuItem.Name = "SlateGrayToolStripMenuItem"
        Me.SlateGrayToolStripMenuItem.Size = New System.Drawing.Size(173, 32)
        Me.SlateGrayToolStripMenuItem.Text = "Slate Gray"
        '
        'DimGrayToolStripMenuItem
        '
        Me.DimGrayToolStripMenuItem.Name = "DimGrayToolStripMenuItem"
        Me.DimGrayToolStripMenuItem.Size = New System.Drawing.Size(173, 32)
        Me.DimGrayToolStripMenuItem.Text = "Dim Gray"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AliceBlueToolStripMenuItem, Me.SkyBlueToolStripMenuItem, Me.NavyToolStripMenuItem, Me.AquaToolStripMenuItem})
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(141, 32)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'AliceBlueToolStripMenuItem
        '
        Me.AliceBlueToolStripMenuItem.Name = "AliceBlueToolStripMenuItem"
        Me.AliceBlueToolStripMenuItem.Size = New System.Drawing.Size(207, 32)
        Me.AliceBlueToolStripMenuItem.Text = "Alice Blue"
        '
        'SkyBlueToolStripMenuItem
        '
        Me.SkyBlueToolStripMenuItem.Name = "SkyBlueToolStripMenuItem"
        Me.SkyBlueToolStripMenuItem.Size = New System.Drawing.Size(207, 32)
        Me.SkyBlueToolStripMenuItem.Text = "Sky Blue"
        '
        'NavyToolStripMenuItem
        '
        Me.NavyToolStripMenuItem.Name = "NavyToolStripMenuItem"
        Me.NavyToolStripMenuItem.Size = New System.Drawing.Size(207, 32)
        Me.NavyToolStripMenuItem.Text = "Navy"
        '
        'AquaToolStripMenuItem
        '
        Me.AquaToolStripMenuItem.Name = "AquaToolStripMenuItem"
        Me.AquaToolStripMenuItem.Size = New System.Drawing.Size(207, 32)
        Me.AquaToolStripMenuItem.Text = "Midnight Blue"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MistyRoseToolStripMenuItem, Me.IndianRedToolStripMenuItem, Me.FireBrickToolStripMenuItem, Me.MaroonToolStripMenuItem})
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(141, 32)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'MistyRoseToolStripMenuItem
        '
        Me.MistyRoseToolStripMenuItem.Name = "MistyRoseToolStripMenuItem"
        Me.MistyRoseToolStripMenuItem.Size = New System.Drawing.Size(179, 32)
        Me.MistyRoseToolStripMenuItem.Text = "Misty Rose"
        '
        'IndianRedToolStripMenuItem
        '
        Me.IndianRedToolStripMenuItem.Name = "IndianRedToolStripMenuItem"
        Me.IndianRedToolStripMenuItem.Size = New System.Drawing.Size(179, 32)
        Me.IndianRedToolStripMenuItem.Text = "Indian Red"
        '
        'FireBrickToolStripMenuItem
        '
        Me.FireBrickToolStripMenuItem.Name = "FireBrickToolStripMenuItem"
        Me.FireBrickToolStripMenuItem.Size = New System.Drawing.Size(179, 32)
        Me.FireBrickToolStripMenuItem.Text = "Fire Brick"
        '
        'MaroonToolStripMenuItem
        '
        Me.MaroonToolStripMenuItem.Name = "MaroonToolStripMenuItem"
        Me.MaroonToolStripMenuItem.Size = New System.Drawing.Size(179, 32)
        Me.MaroonToolStripMenuItem.Text = "Maroon"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaleGreenToolStripMenuItem, Me.SpringToolStripMenuItem, Me.LimeToolStripMenuItem, Me.ForestGreenToolStripMenuItem})
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(141, 32)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'PaleGreenToolStripMenuItem
        '
        Me.PaleGreenToolStripMenuItem.Name = "PaleGreenToolStripMenuItem"
        Me.PaleGreenToolStripMenuItem.Size = New System.Drawing.Size(195, 32)
        Me.PaleGreenToolStripMenuItem.Text = "Pale Green"
        '
        'SpringToolStripMenuItem
        '
        Me.SpringToolStripMenuItem.Name = "SpringToolStripMenuItem"
        Me.SpringToolStripMenuItem.Size = New System.Drawing.Size(195, 32)
        Me.SpringToolStripMenuItem.Text = "SpringGreen"
        '
        'LimeToolStripMenuItem
        '
        Me.LimeToolStripMenuItem.Name = "LimeToolStripMenuItem"
        Me.LimeToolStripMenuItem.Size = New System.Drawing.Size(195, 32)
        Me.LimeToolStripMenuItem.Text = "Lime"
        '
        'ForestGreenToolStripMenuItem
        '
        Me.ForestGreenToolStripMenuItem.Name = "ForestGreenToolStripMenuItem"
        Me.ForestGreenToolStripMenuItem.Size = New System.Drawing.Size(195, 32)
        Me.ForestGreenToolStripMenuItem.Text = "Forest Green"
        '
        'YellowToolStripMenuItem
        '
        Me.YellowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KhakiToolStripMenuItem, Me.WheatToolStripMenuItem, Me.GoldToolStripMenuItem, Me.GoldenRodToolStripMenuItem})
        Me.YellowToolStripMenuItem.Name = "YellowToolStripMenuItem"
        Me.YellowToolStripMenuItem.Size = New System.Drawing.Size(141, 32)
        Me.YellowToolStripMenuItem.Text = "Yellow"
        '
        'KhakiToolStripMenuItem
        '
        Me.KhakiToolStripMenuItem.Name = "KhakiToolStripMenuItem"
        Me.KhakiToolStripMenuItem.Size = New System.Drawing.Size(189, 32)
        Me.KhakiToolStripMenuItem.Text = "Khaki"
        '
        'WheatToolStripMenuItem
        '
        Me.WheatToolStripMenuItem.Name = "WheatToolStripMenuItem"
        Me.WheatToolStripMenuItem.Size = New System.Drawing.Size(189, 32)
        Me.WheatToolStripMenuItem.Text = "Wheat"
        '
        'GoldToolStripMenuItem
        '
        Me.GoldToolStripMenuItem.Name = "GoldToolStripMenuItem"
        Me.GoldToolStripMenuItem.Size = New System.Drawing.Size(189, 32)
        Me.GoldToolStripMenuItem.Text = "Gold"
        '
        'GoldenRodToolStripMenuItem
        '
        Me.GoldenRodToolStripMenuItem.Name = "GoldenRodToolStripMenuItem"
        Me.GoldenRodToolStripMenuItem.Size = New System.Drawing.Size(189, 32)
        Me.GoldenRodToolStripMenuItem.Text = "Golden Rod"
        '
        'lblStop
        '
        Me.lblStop.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStop.ForeColor = System.Drawing.Color.Aqua
        Me.lblStop.Location = New System.Drawing.Point(0, 608)
        Me.lblStop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStop.Name = "lblStop"
        Me.lblStop.Size = New System.Drawing.Size(530, 19)
        Me.lblStop.TabIndex = 12
        Me.lblStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.ovl9, Me.ovl7, Me.ovl6, Me.ovl3, Me.ovl2, Me.ovl0, Me.ovl1, Me.ovl5, Me.ovl4, Me.ovl8, Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(530, 623)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'ovl9
        '
        Me.ovl9.FillColor = System.Drawing.Color.Aqua
        Me.ovl9.FillGradientColor = System.Drawing.Color.AliceBlue
        Me.ovl9.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central
        Me.ovl9.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovl9.Location = New System.Drawing.Point(466, 91)
        Me.ovl9.Name = "ovl9"
        Me.ovl9.Size = New System.Drawing.Size(50, 50)
        '
        'ovl7
        '
        Me.ovl7.FillColor = System.Drawing.Color.Aqua
        Me.ovl7.FillGradientColor = System.Drawing.Color.AliceBlue
        Me.ovl7.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central
        Me.ovl7.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovl7.Location = New System.Drawing.Point(364, 91)
        Me.ovl7.Name = "ovl7"
        Me.ovl7.Size = New System.Drawing.Size(50, 50)
        '
        'ovl6
        '
        Me.ovl6.FillColor = System.Drawing.Color.Aqua
        Me.ovl6.FillGradientColor = System.Drawing.Color.AliceBlue
        Me.ovl6.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central
        Me.ovl6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovl6.Location = New System.Drawing.Point(313, 91)
        Me.ovl6.Name = "ovl6"
        Me.ovl6.Size = New System.Drawing.Size(50, 50)
        '
        'ovl3
        '
        Me.ovl3.FillColor = System.Drawing.Color.Aqua
        Me.ovl3.FillGradientColor = System.Drawing.Color.AliceBlue
        Me.ovl3.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central
        Me.ovl3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovl3.Location = New System.Drawing.Point(162, 91)
        Me.ovl3.Name = "ovl3"
        Me.ovl3.Size = New System.Drawing.Size(50, 50)
        '
        'ovl2
        '
        Me.ovl2.FillColor = System.Drawing.Color.Aqua
        Me.ovl2.FillGradientColor = System.Drawing.Color.AliceBlue
        Me.ovl2.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central
        Me.ovl2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovl2.Location = New System.Drawing.Point(112, 91)
        Me.ovl2.Name = "ovl2"
        Me.ovl2.Size = New System.Drawing.Size(50, 50)
        '
        'ovl0
        '
        Me.ovl0.FillColor = System.Drawing.Color.Aqua
        Me.ovl0.FillGradientColor = System.Drawing.Color.AliceBlue
        Me.ovl0.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central
        Me.ovl0.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovl0.Location = New System.Drawing.Point(11, 91)
        Me.ovl0.Name = "ovl0"
        Me.ovl0.Size = New System.Drawing.Size(50, 50)
        '
        'ovl1
        '
        Me.ovl1.FillColor = System.Drawing.Color.Aqua
        Me.ovl1.FillGradientColor = System.Drawing.Color.AliceBlue
        Me.ovl1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central
        Me.ovl1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovl1.Location = New System.Drawing.Point(62, 91)
        Me.ovl1.Name = "ovl1"
        Me.ovl1.Size = New System.Drawing.Size(50, 50)
        '
        'ovl5
        '
        Me.ovl5.FillColor = System.Drawing.Color.Aqua
        Me.ovl5.FillGradientColor = System.Drawing.Color.AliceBlue
        Me.ovl5.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central
        Me.ovl5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovl5.Location = New System.Drawing.Point(262, 91)
        Me.ovl5.Name = "ovl5"
        Me.ovl5.Size = New System.Drawing.Size(50, 50)
        '
        'ovl4
        '
        Me.ovl4.FillColor = System.Drawing.Color.Aqua
        Me.ovl4.FillGradientColor = System.Drawing.Color.AliceBlue
        Me.ovl4.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central
        Me.ovl4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovl4.Location = New System.Drawing.Point(212, 91)
        Me.ovl4.Name = "ovl4"
        Me.ovl4.Size = New System.Drawing.Size(50, 50)
        '
        'ovl8
        '
        Me.ovl8.FillColor = System.Drawing.Color.Aqua
        Me.ovl8.FillGradientColor = System.Drawing.Color.AliceBlue
        Me.ovl8.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central
        Me.ovl8.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovl8.Location = New System.Drawing.Point(415, 91)
        Me.ovl8.Name = "ovl8"
        Me.ovl8.Size = New System.Drawing.Size(50, 50)
        '
        'OvalShape1
        '
        Me.OvalShape1.Location = New System.Drawing.Point(0, 0)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(75, 23)
        '
        'tmrTime
        '
        Me.tmrTime.Interval = 500
        '
        'tmrGo
        '
        Me.tmrGo.Interval = 10
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(530, 623)
        Me.Controls.Add(Me.lblStop)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lblDrop)
        Me.Controls.Add(Me.pbrPlay)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents lblDrop As System.Windows.Forms.Label
    Friend WithEvents pbrPlay As System.Windows.Forms.ProgressBar
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WhiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IvoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FloralWhiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeigeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AntiqueWhiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NavajoWhiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LightSlateGrayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SlateGrayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DimGrayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AliceBlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SkyBlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NavyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AquaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MistyRoseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndianRedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FireBrickToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaroonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaleGreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForestGreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YellowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KhakiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WheatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoldToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoldenRodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblStop As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents ovl9 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ovl7 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ovl6 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ovl3 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ovl2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ovl0 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ovl1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ovl5 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ovl4 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ovl8 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents tmrTime As System.Windows.Forms.Timer
    Friend WithEvents tmrGo As System.Windows.Forms.Timer
End Class

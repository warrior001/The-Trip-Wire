<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class From1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(From1))
        Me.playerWalk = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.moneylbl = New System.Windows.Forms.Label
        Me.nightTimer = New System.Windows.Forms.Timer(Me.components)
        Me.dayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.enemyWalk = New System.Windows.Forms.Timer(Me.components)
        Me.shooting = New System.Windows.Forms.Timer(Me.components)
        Me.tmrChest = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Chest = New System.Windows.Forms.PictureBox
        Me.wall2 = New System.Windows.Forms.PictureBox
        Me.Wall = New System.Windows.Forms.PictureBox
        Me.Cloud3 = New System.Windows.Forms.PictureBox
        Me.Cloud2 = New System.Windows.Forms.PictureBox
        Me.Cloud1 = New System.Windows.Forms.PictureBox
        Me.live3 = New System.Windows.Forms.PictureBox
        Me.live2 = New System.Windows.Forms.PictureBox
        Me.Live1 = New System.Windows.Forms.PictureBox
        Me.Grassland = New System.Windows.Forms.PictureBox
        Me.Cloud = New System.Windows.Forms.PictureBox
        Me.Enemy = New System.Windows.Forms.PictureBox
        Me.player = New System.Windows.Forms.PictureBox
        Me.shoot = New System.Windows.Forms.PictureBox
        Me.wall1 = New System.Windows.Forms.PictureBox
        CType(Me.Chest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cloud3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cloud2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cloud1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.live3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.live2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Live1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grassland, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cloud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shoot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'playerWalk
        '
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Name = "Label1"
        '
        'moneylbl
        '
        resources.ApplyResources(Me.moneylbl, "moneylbl")
        Me.moneylbl.BackColor = System.Drawing.Color.Transparent
        Me.moneylbl.ForeColor = System.Drawing.Color.Gold
        Me.moneylbl.Name = "moneylbl"
        '
        'nightTimer
        '
        Me.nightTimer.Enabled = True
        Me.nightTimer.Interval = 10000
        '
        'dayTimer
        '
        Me.dayTimer.Interval = 10000
        '
        'ProgressBar1
        '
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.Maximum = 110
        Me.ProgressBar1.Name = "ProgressBar1"
        '
        'enemyWalk
        '
        '
        'shooting
        '
        '
        'tmrChest
        '
        Me.tmrChest.Enabled = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Chest
        '
        Me.Chest.BackColor = System.Drawing.Color.Transparent
        Me.Chest.Image = Global.The_Trip_Wire.My.Resources.Resources.Untitled123
        resources.ApplyResources(Me.Chest, "Chest")
        Me.Chest.Name = "Chest"
        Me.Chest.TabStop = False
        '
        'wall2
        '
        Me.wall2.BackgroundImage = Global.The_Trip_Wire.My.Resources.Resources.ענדה_מעחור
        resources.ApplyResources(Me.wall2, "wall2")
        Me.wall2.Name = "wall2"
        Me.wall2.TabStop = False
        '
        'Wall
        '
        Me.Wall.BackgroundImage = Global.The_Trip_Wire.My.Resources.Resources.ענדה_מעחור
        resources.ApplyResources(Me.Wall, "Wall")
        Me.Wall.Name = "Wall"
        Me.Wall.TabStop = False
        '
        'Cloud3
        '
        Me.Cloud3.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.Cloud3, "Cloud3")
        Me.Cloud3.Name = "Cloud3"
        Me.Cloud3.TabStop = False
        '
        'Cloud2
        '
        Me.Cloud2.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.Cloud2, "Cloud2")
        Me.Cloud2.Name = "Cloud2"
        Me.Cloud2.TabStop = False
        '
        'Cloud1
        '
        Me.Cloud1.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.Cloud1, "Cloud1")
        Me.Cloud1.Name = "Cloud1"
        Me.Cloud1.TabStop = False
        '
        'live3
        '
        Me.live3.Image = Global.The_Trip_Wire.My.Resources.Resources.images
        resources.ApplyResources(Me.live3, "live3")
        Me.live3.Name = "live3"
        Me.live3.TabStop = False
        '
        'live2
        '
        Me.live2.Image = Global.The_Trip_Wire.My.Resources.Resources.images
        resources.ApplyResources(Me.live2, "live2")
        Me.live2.Name = "live2"
        Me.live2.TabStop = False
        '
        'Live1
        '
        Me.Live1.Image = Global.The_Trip_Wire.My.Resources.Resources.images
        resources.ApplyResources(Me.Live1, "Live1")
        Me.Live1.Name = "Live1"
        Me.Live1.TabStop = False
        '
        'Grassland
        '
        Me.Grassland.BackgroundImage = Global.The_Trip_Wire.My.Resources.Resources.Untitled1
        resources.ApplyResources(Me.Grassland, "Grassland")
        Me.Grassland.Name = "Grassland"
        Me.Grassland.TabStop = False
        '
        'Cloud
        '
        Me.Cloud.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.Cloud, "Cloud")
        Me.Cloud.Name = "Cloud"
        Me.Cloud.TabStop = False
        '
        'Enemy
        '
        Me.Enemy.BackgroundImage = Global.The_Trip_Wire.My.Resources.Resources.player13
        resources.ApplyResources(Me.Enemy, "Enemy")
        Me.Enemy.Name = "Enemy"
        Me.Enemy.TabStop = False
        '
        'player
        '
        Me.player.BackColor = System.Drawing.Color.Transparent
        Me.player.BackgroundImage = Global.The_Trip_Wire.My.Resources.Resources.main_player
        resources.ApplyResources(Me.player, "player")
        Me.player.Name = "player"
        Me.player.TabStop = False
        '
        'shoot
        '
        Me.shoot.BackColor = System.Drawing.Color.Gold
        resources.ApplyResources(Me.shoot, "shoot")
        Me.shoot.Name = "shoot"
        Me.shoot.TabStop = False
        '
        'wall1
        '
        Me.wall1.BackgroundImage = Global.The_Trip_Wire.My.Resources.Resources.ענדה_מעחור
        resources.ApplyResources(Me.wall1, "wall1")
        Me.wall1.Name = "wall1"
        Me.wall1.TabStop = False
        '
        'From1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.Controls.Add(Me.wall1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Chest)
        Me.Controls.Add(Me.wall2)
        Me.Controls.Add(Me.Wall)
        Me.Controls.Add(Me.Cloud3)
        Me.Controls.Add(Me.Cloud2)
        Me.Controls.Add(Me.Cloud1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.live3)
        Me.Controls.Add(Me.live2)
        Me.Controls.Add(Me.Live1)
        Me.Controls.Add(Me.Grassland)
        Me.Controls.Add(Me.moneylbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cloud)
        Me.Controls.Add(Me.Enemy)
        Me.Controls.Add(Me.player)
        Me.Controls.Add(Me.shoot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "From1"
        CType(Me.Chest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cloud3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cloud2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cloud1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.live3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.live2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Live1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grassland, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cloud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shoot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents playerWalk As System.Windows.Forms.Timer
    Friend WithEvents player As System.Windows.Forms.PictureBox
    Friend WithEvents Chest As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents moneylbl As System.Windows.Forms.Label
    Friend WithEvents Grassland As System.Windows.Forms.PictureBox
    Friend WithEvents Live1 As System.Windows.Forms.PictureBox
    Friend WithEvents live2 As System.Windows.Forms.PictureBox
    Friend WithEvents live3 As System.Windows.Forms.PictureBox
    Friend WithEvents nightTimer As System.Windows.Forms.Timer
    Friend WithEvents dayTimer As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Cloud1 As System.Windows.Forms.PictureBox
    Friend WithEvents Cloud2 As System.Windows.Forms.PictureBox
    Friend WithEvents Cloud3 As System.Windows.Forms.PictureBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Cloud As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy As System.Windows.Forms.PictureBox
    Friend WithEvents enemyWalk As System.Windows.Forms.Timer
    Friend WithEvents shooting As System.Windows.Forms.Timer
    Friend WithEvents Wall As System.Windows.Forms.PictureBox
    Friend WithEvents wall2 As System.Windows.Forms.PictureBox
    Friend WithEvents shoot As System.Windows.Forms.PictureBox
    Friend WithEvents tmrChest As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents wall1 As System.Windows.Forms.PictureBox

End Class

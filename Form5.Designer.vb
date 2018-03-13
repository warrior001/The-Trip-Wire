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
        Me.components = New System.ComponentModel.Container
        Me.moneylbl = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Grassland = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.player = New System.Windows.Forms.PictureBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Cloud3 = New System.Windows.Forms.PictureBox
        Me.Cloud2 = New System.Windows.Forms.PictureBox
        Me.Cloud1 = New System.Windows.Forms.PictureBox
        Me.Cloud = New System.Windows.Forms.PictureBox
        CType(Me.Grassland, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cloud3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cloud2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cloud1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cloud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'moneylbl
        '
        Me.moneylbl.AutoSize = True
        Me.moneylbl.BackColor = System.Drawing.Color.Transparent
        Me.moneylbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.moneylbl.ForeColor = System.Drawing.Color.Gold
        Me.moneylbl.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.moneylbl.Location = New System.Drawing.Point(76, 9)
        Me.moneylbl.Name = "moneylbl"
        Me.moneylbl.Size = New System.Drawing.Size(20, 24)
        Me.moneylbl.TabIndex = 63
        Me.moneylbl.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 24)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Dash:"
        '
        'Grassland
        '
        Me.Grassland.BackgroundImage = Global.The_Trip_Wire.My.Resources.Resources.Untitled1
        Me.Grassland.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Grassland.Location = New System.Drawing.Point(2, 587)
        Me.Grassland.Name = "Grassland"
        Me.Grassland.Size = New System.Drawing.Size(1123, 68)
        Me.Grassland.TabIndex = 61
        Me.Grassland.TabStop = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'player
        '
        Me.player.BackColor = System.Drawing.Color.Transparent
        Me.player.BackgroundImage = Global.The_Trip_Wire.My.Resources.Resources.PlayerStand
        Me.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.player.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.player.Location = New System.Drawing.Point(2, 472)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(90, 120)
        Me.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.player.TabIndex = 64
        Me.player.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ProgressBar1.Location = New System.Drawing.Point(102, 12)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(210, 23)
        Me.ProgressBar1.TabIndex = 68
        Me.ProgressBar1.Visible = False
        '
        'Cloud3
        '
        Me.Cloud3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Cloud3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cloud3.Location = New System.Drawing.Point(986, 54)
        Me.Cloud3.Name = "Cloud3"
        Me.Cloud3.Size = New System.Drawing.Size(119, 51)
        Me.Cloud3.TabIndex = 74
        Me.Cloud3.TabStop = False
        '
        'Cloud2
        '
        Me.Cloud2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Cloud2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cloud2.Location = New System.Drawing.Point(158, 63)
        Me.Cloud2.Name = "Cloud2"
        Me.Cloud2.Size = New System.Drawing.Size(158, 28)
        Me.Cloud2.TabIndex = 73
        Me.Cloud2.TabStop = False
        '
        'Cloud1
        '
        Me.Cloud1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Cloud1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cloud1.Location = New System.Drawing.Point(378, 82)
        Me.Cloud1.Name = "Cloud1"
        Me.Cloud1.Size = New System.Drawing.Size(121, 23)
        Me.Cloud1.TabIndex = 72
        Me.Cloud1.TabStop = False
        '
        'Cloud
        '
        Me.Cloud.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Cloud.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cloud.Location = New System.Drawing.Point(567, 48)
        Me.Cloud.Name = "Cloud"
        Me.Cloud.Size = New System.Drawing.Size(149, 43)
        Me.Cloud.TabIndex = 75
        Me.Cloud.TabStop = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1120, 657)
        Me.Controls.Add(Me.Cloud3)
        Me.Controls.Add(Me.Cloud2)
        Me.Controls.Add(Me.Cloud1)
        Me.Controls.Add(Me.Cloud)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.moneylbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Grassland)
        Me.Controls.Add(Me.player)
        Me.Name = "Form5"
        Me.Text = "The Trip-Wire"
        CType(Me.Grassland, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cloud3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cloud2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cloud1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cloud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grassland As System.Windows.Forms.PictureBox
    Friend WithEvents moneylbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents player As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Cloud3 As System.Windows.Forms.PictureBox
    Friend WithEvents Cloud2 As System.Windows.Forms.PictureBox
    Friend WithEvents Cloud1 As System.Windows.Forms.PictureBox
    Friend WithEvents Cloud As System.Windows.Forms.PictureBox
End Class

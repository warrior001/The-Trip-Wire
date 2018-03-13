Public Class From1
    Dim animation As Boolean
    Dim hasGun As Boolean

    Dim isWalk As Integer
    Dim WallE As Boolean = False
    Dim money As Integer
    Dim currentLocation As Point
    Dim lives As Integer = 3
    Dim isJump As Boolean = False
    Dim Ewalk As Boolean = False
    Dim edir As Integer
    Dim dire As Integer
    Dim eedir As Integer
    Dim plocation As Point
    Dim elocation As Point
    Dim Day As Boolean = True
    Dim gravity As Single = 0
    Dim Eopen As Boolean
    Dim isshoot As Boolean
    Dim isleft As Boolean
    Dim Smoving As Boolean = True



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        playerWalk.Start()
        tmrChest.Start()
        nightTimer.Start()
        isshoot = False
        hasGun = False

        If isshoot = True Then
            shooting.Start()
        Else
            shooting.Stop()
        End If

    End Sub


    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Movements
        'isWalk = 1 Left
        'isWalk = 2 Right
        'isWalk = 3 Left with weapon
        'isWalk = 4 Right with weapon
        'isWalk = 0 Stand


        'Moving
        isshoot = False
        If e.KeyCode = Keys.D Then
            player.Left += 6

            isleft = False
            isshoot = False
            If hasGun = True Then
                isWalk = 4


            Else
                isWalk = 2
            End If


        End If

        If e.KeyCode = Keys.A Then
            player.Left -= 6
            isshoot = False
            isleft = True
            Smoving = True
            If hasGun = True Then
                isWalk = 3
            Else
                isWalk = 1
            End If

        End If

        If shoot.Left > player.Left Then
            shoot.Left -= 6
            isshoot = False
        Else
            shoot.Left += 6

        End If
        isshoot = False
        'Shoot
      
      
        

          

        If e.KeyCode = Keys.Z And hasGun = True Then
            isshoot = True
            Smoving = False
            shooting.Start()


        End If



     
        'Move to another form
        If e.KeyCode = Keys.E Then
            Form3.Show()
        End If
        'כאשר לוחצים על מקש רווח או על מקש יריה הדמות מסתובבת ימינה

    End Sub

    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        'Stop moving

        isWalk = 0

        If isleft = True Then
            player.BackgroundImage = My.Resources.PlayerStandLeft
        Else
            player.BackgroundImage = My.Resources.PlayerStand
        End If

        'Movements
        'isWalk = 1 Left
        'isWalk = 2 Right
        'isWalk = 3 Left with weapon
        'isWalk = 4 Right with weapon
        'isWalk = 0 Stand
        

        If e.KeyCode = Keys.A Then

            isWalk = -1



        End If
       
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playerWalk.Tick


        ' Player Walk 

        Label2.Text = isWalk
        Label3.Text = hasGun
        Label4.Text = isshoot

        

        If isWalk = 1 Or isWalk = 2 Then

            If animation = True Then
                player.BackgroundImage = My.Resources.main_player2
                animation = False
            Else
                player.BackgroundImage = My.Resources.main_player3
                animation = True
            End If

        End If


       

        If isWalk = 3 Or isWalk = 4 Then

            If animation = True Then
                player.BackgroundImage = My.Resources.player_with_weapon_3

                animation = False
            Else
                player.BackgroundImage = My.Resources.playerwithweapon21
                animation = True
            End If

        End If

        If isWalk = 1 Or isWalk = 3 Then
            player.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY)
       
        End If



        If isWalk = 0 Then
            If hasGun = True Then
                player.BackgroundImage = My.Resources.player_with_weapon_31
            Else
                player.BackgroundImage = My.Resources.main_player
            End If
        End If

        If isWalk = -1 Then

            If hasGun = True Then
                player.BackgroundImage = My.Resources.player_with_weapon_31
                player.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY)
            Else
                player.BackgroundImage = My.Resources.main_player
                player.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY)
            End If
        End If


        If Enemy.Bounds.IntersectsWith(player.Bounds) Then
            Enemy.Left = 0
            lives -= 1

            If lives = 2 Then
                Live1.Visible = False
            ElseIf lives = 1 Then
                live2.Visible = False
            ElseIf lives = 0 Then
                live3.Visible = False
                ' MsgBox("game over")
            End If

        End If




        ' Transport to another Form (From5) not active!!!!!!! read the rules!!

        For Each wall As Control In Me.Controls
            If wall.Name.Contains("wall") Then
                If wall.Bounds.IntersectsWith(player.Bounds) Then
                    player.Location = currentLocation

                End If
                If wall.Bounds.IntersectsWith(Enemy.Bounds) Then
                    Enemy.Location = elocation
                    eedir = Rnd() * 3

                End If

            End If
        Next
        currentLocation = player.Location
        elocation = Enemy.Location


        'Clouds, YAY!
        For Each Cloud As Control In Me.Controls
            If Cloud.Name.StartsWith("Cloud") Then
                Cloud.Left -= 10
                If Cloud.Left < 0 Then
                    Cloud.Left = Width

                End If

            End If

        Next
        'לעשות שכאשר אוייב מתנגש בשחקן יורדים לשחקן לב אחד-חיים והאוייב נעלם
        'לאחר שלדמות יש נשק,האנימציה מפסיקה לעבוד
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nightTimer.Tick
        ' Code for Night time
        Day = False

        If ProgressBar1.Value = 100 Then

            Enemy.Visible = True
            enemyWalk.Start()
            BackColor = Color.Black
            nightTimer.Stop()
            dayTimer.Start()
            ProgressBar1.Value = 0
            Ewalk = True

            For Each Cloud As Control In Me.Controls
                If Cloud.Name.StartsWith("Cloud") Then
                    Cloud.BackColor = Color.Gray
                End If
            Next

        End If

        ProgressBar1.Value += 10


    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dayTimer.Tick
        ' Code for Day Time
        Day = True
        If ProgressBar1.Value = 100 Then

            Enemy.Visible = False
            enemyWalk.Stop()
            BackColor = Color.SkyBlue
            dayTimer.Stop()
            nightTimer.Start()



            For Each Cloud As Control In Me.Controls
                If Cloud.Name.StartsWith("Cloud") Then
                    Cloud.BackColor = Color.White
                End If
            Next
        End If

        ProgressBar1.Value += 10

    End Sub


    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enemyWalk.Tick
        'Enemy Walk.

        If Ewalk = True Then
            If Eopen = True Then
                Enemy.BackgroundImage = My.Resources.player
                Eopen = False
            Else
                Enemy.BackgroundImage = My.Resources.player15
                Eopen = True
            End If
        Else
            Enemy.BackgroundImage = My.Resources.player13
        End If



        If Eopen = True Then
            Enemy.BackgroundImage = My.Resources.player14
            Eopen = False
        Else
            Enemy.BackgroundImage = My.Resources.player15
            Eopen = True
        End If




        If Ewalk = True Then
            If Eopen = True Then
                Enemy.BackgroundImage = My.Resources.player14
                Eopen = False
            Else
                Enemy.BackgroundImage = My.Resources.player15
                Eopen = True
            End If
        End If


        Enemy.Left += 3
        'לעשות שאוייבים עוצרים רנדומלית ויורים את הירייה
        'לעשות שהאוייבים נוצרית רנדומלית בצדדים של הטופס
        'לעשות שאוייבים נעלמים כשמיתנגשים בקיר שמולם
        'לעשות שאחרי שתים או שלוש פגיעות באוייב האוייב מת

    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shooting.Tick

        If isleft = True Then

            shoot.Left -= 5

        Else

            shoot.Left += 5

        End If

        isshoot = False


        For Each Wall As Control In Me.Controls
            If Wall.Name.StartsWith("Wall") Then
                If Wall.Bounds.IntersectsWith(shoot.Bounds) Then
                    isshoot = False
                    shoot.Left = player.Left
                    shooting.Stop()

                End If
            End If
        Next

        If shoot.Bounds.IntersectsWith(Enemy.Bounds) Then
            shoot.Left = player.Left
            isshoot = False
            shooting.Stop()

        End If
        'לא יורה לצד שמאל

    



    End Sub

 
    Private Sub tmrChest_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrChest.Tick
        If player.Bounds.IntersectsWith(Chest.Bounds) Then
            hasGun = True

            Chest.Visible = False
            Chest.Top -= 1000000
            player.BackgroundImage = My.Resources.player_with_weapon_31
            MsgBox("Great! you have a new toy! or sword if you want, but it still a weapon!")

            moneylbl.Text = money
            money += 100
            moneylbl.Text = money
            tmrChest.Stop()



        End If


    End Sub
End Class

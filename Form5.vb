Public Class Form5
    Dim dir As Integer
    Dim open As Boolean
    Dim isWalk As Boolean = False
    Dim WallE As Boolean = False
    Dim money As Integer
    Dim currentLocation As Point
    Dim lives As Integer
    Dim isJump As Boolean = False






    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        isWalk = False

        If e.KeyCode = Keys.D Then
            player.Left += 6
            dir = 1
            isWalk = True
        End If



        If e.KeyCode = Keys.A Then
            player.Left -= 6
            dir = 2
            isWalk = True
        End If




        If e.KeyCode = Keys.E Then
            Form3.Show()

        End If
        If e.KeyCode = Keys.Space Then
            dir = 3
        End If


        If e.KeyCode = Keys.Enter Then
            player.BackgroundImage = My.Resources.PlayerWalk

        End If

    End Sub

    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        isWalk = False



    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        dir = 0
       
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' Player Walk & Jump
        If isWalk = True Then
            If open = True Then
                player.BackgroundImage = My.Resources.PlayerWalk
                open = False
            Else
                player.BackgroundImage = My.Resources.PlayerWalk2
                open = True
            End If
        Else
            player.BackgroundImage = My.Resources.PlayerStand

        End If

        If dir = 3 Then
            Static count As Integer
            Static location As Integer
            If count = 0 Then
                location = player.Top
            End If
            count += 1
            Select Case count
                Case 0 To 10
                    player.Top -= 15
                Case 11 To 20
                    player.Top += 15
                Case Else
                    player.Top = location
                    count = 0
                    dir = 0

            End Select
        End If
        If player.Left < 0 Then
            From1.Visible = True
            Me.Visible = False
        End If




        If dir = 2 Then
            player.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY)
        End If





        For Each wall As Control In Me.Controls
            If wall.Name.Contains("wall") Then
                If wall.Bounds.IntersectsWith(player.Bounds) Then
                    player.Location = currentLocation



                End If

            End If
        Next
        currentLocation = player.Location

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        ' Code for Night time
        ProgressBar1.Value += 10
        If ProgressBar1.Value = 100 Then

            BackColor = Color.Black
            Timer3.Stop()
            Timer4.Start()
            ProgressBar1.Value = 0

            For Each Cloud As Control In Me.Controls
                If Cloud.Name.StartsWith("Cloud") Then
                    Cloud.BackColor = Color.Gray
                End If
            Next

        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        ' Code for Day Time
        ProgressBar1.Value += 10
        If ProgressBar1.Value = 100 Then

            BackColor = Color.SkyBlue
            Timer4.Stop()
            Timer3.Start()
            ProgressBar1.Value = 0

            For Each Cloud As Control In Me.Controls
                If Cloud.Name.StartsWith("Cloud") Then
                    Cloud.BackColor = Color.White
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class

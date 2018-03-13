Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim response = MsgBox("are you sure?", MsgBoxStyle.YesNo)
        If response = MsgBoxResult.Yes Then
            Me.Close()
            Form5.Close()
            Form2.Close()
            From1.Close()
            Form4.Close()


        End If
        If response = MsgBoxResult.No Then
            From1.Visible = True
            Me.Close()


        End If
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox("if you have any questions or problems send a massage to mclserv15@gmail.com")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form4.Show()

    End Sub
End Class
Public Class Form4
    
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Label3.Text = Val(Button2.Text) + Val(Label3.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Label3.Text = Val(Button3.Text) + Val(Label3.Text)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Buying proccess.
        Dim response = MsgBox("Are you sure you want to buy it?", MsgBoxStyle.YesNo)

        If response = MsgBoxResult.Yes Then
            MsgBox("You succesfully purchased your Items!")

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Shop exit.
        Me.Close()

    End Sub
End Class
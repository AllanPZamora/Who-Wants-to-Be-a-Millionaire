Public Class GameOver
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Game.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Main.Show()
        Me.Close()
    End Sub
End Class
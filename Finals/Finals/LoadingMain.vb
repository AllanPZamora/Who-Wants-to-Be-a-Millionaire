Public Class LoadingMain
    Private Sub LoadingMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.ProgressBar1.Value += 2
        If ProgressBar1.Value >= 100 Then
            Timer1.Stop()
            Main.Show()
            Me.Hide()
        End If
    End Sub
End Class
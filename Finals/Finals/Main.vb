Public Class Main

    Dim numSetting As Integer
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Game.Show()
        'Me.Hide()

        'MsgBox(My.Settings.categoryStr)
        My.Settings.categoryStr = "Random"
        My.Settings.Save()

        Game.Show()
        Me.Hide()
        'MsgBox(My.Settings.categoryStr)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    '' Private Sub Button5_Click(sender As Object, e As EventArgs)
    ''umSetting = 0 Then
    '        ShowMenu(setting, Panel1)
    '        numSetting += 1
    '    Else
    '        Panel1.Controls.Clear()
    '        numSetting = 0
    '    End If

    'End Sub



    Sub ShowMenu(targetForm As Form, origPanel As Panel)
        origPanel.Controls.Clear()
        targetForm.TopLevel = False
        origPanel.Controls.Add(targetForm)
        targetForm.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Category.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Dispose()
        Application.Exit()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("To be follow!")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("To be follow!")
    End Sub
End Class
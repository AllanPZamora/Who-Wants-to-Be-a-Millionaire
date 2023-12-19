Public Class Category

    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2Button10.Enabled = False
    End Sub

    Sub SetCategory(cat As String)
        My.Settings.categoryStr = cat
        My.Settings.Save()

        Guna2Button10.Enabled = True
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        SetCategory("Accountancy")
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        SetCategory("Crim")
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        SetCategory("Educ")
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        SetCategory("Engi")
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        SetCategory("Hm")
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        SetCategory("IT")
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        SetCategory("Marketing")
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        SetCategory("PolSci")
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        SetCategory("Tourism")
    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        Game.Show()
        Me.Close()
    End Sub

End Class
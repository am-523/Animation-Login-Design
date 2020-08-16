Imports Guna.UI2.AnimatorNS
Imports Guna.UI2.WinForms

Public Class Form1
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

        pn_regis.Visible = False
        Guna2Transition1.HideSync(pn_regis)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        pn_regis.Visible = True
        Guna2Transition1.ShowSync(pn_regis)

    End Sub
End Class

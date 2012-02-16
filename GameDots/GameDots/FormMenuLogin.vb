Public Class FormMenuLogin

   
    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Application.Exit()

    End Sub

    Private Sub btnLoginPemain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoginPemain.Click
        FormLoginPemain.Show()
        Me.Hide()
    End Sub

    Private Sub btnLoginAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoginAdmin.Click
        FormLoginAdmin.Show()
        Me.Hide()
    End Sub
End Class
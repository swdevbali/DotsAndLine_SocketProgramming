Public Class FormMenuAdmin

    Private Sub btnDataAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDataAdmin.Click
        FormDataAdmin.Show()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    Private Sub btnDataPemain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDataPemain.Click
        FormDataPemain.Show()
    End Sub
End Class
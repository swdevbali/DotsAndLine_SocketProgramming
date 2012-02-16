Public Class SplashScreen

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 2
        If ProgressBar1.Value = 100 Then
            Timer1.Dispose()
            Me.Visible = False
            FormLoginPemain.Show()
        End If
    End Sub

    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class
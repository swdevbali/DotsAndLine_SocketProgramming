Public Class SplashScreen
    Dim opacityRate As Double = 0.0
    Dim maximizeRate As Boolean = True
    Dim minimizeRate As Boolean = False
    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value = 100 Then
            Timer1.Dispose()
            Me.Visible = False
            FormMenuLogin.Show()
        End If

    End Sub

End Class
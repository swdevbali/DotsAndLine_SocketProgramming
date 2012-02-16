Public Class FormGameDots
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub FormGameDots_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub FormGameDots_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    Private Sub FormGameDots_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub btnPetunjuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPetunjuk.Click
        FormPetunjuk.Show()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        'Close()
        TombolClose()
    End Sub

    Private Sub btnInvite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvite.Click
        FormInvitePemain.Show()
    End Sub

    Private Sub PictureBoxClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxClose.Click
        TombolClose()
    End Sub

    Private Sub PictureBoxMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
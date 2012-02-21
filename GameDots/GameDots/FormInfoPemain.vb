Public Class FormInfoPemain
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub FormInfoPemain_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub FormInfoPemain_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    Private Sub FormInfoPemain_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub
    Private Sub btnKembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKembali.Click
        Hide()
        instanceFormLobiGame.Show()
    End Sub

    Private Sub PictureBoxClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxClose.Click
        Close()
    End Sub

    Private Sub PictureBoxMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FormInfoPemain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdidotsDataSet.statistik' table. You can move, or remove it, as needed.


    End Sub
End Class
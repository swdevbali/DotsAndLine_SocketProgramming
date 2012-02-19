Imports System.Data
Imports System.Data.SqlClient

Public Class FormBuatRoom
    Dim MyConnection As New DatabaseKoneksi

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Public Sub BuatRoom()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=" & compName & ";Initial Catalog=adidots;Integrated Security=True"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO room([nama_room],[jumlah_pemain],[ukuran_papan])VALUES('" & txtNamaRoom.Text & "','" & cbxJumPemain.Text & "', " & cbxPapan.Text & ")"
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub
    Private Sub FormBuatRoom_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub FormBuatRoom_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    Private Sub FormBuatRoom_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        ModuleClient.sendMessageToServer("CREATE_ROOM|" + txtNamaRoom.Text + ">" + cbxJumPemain.Text + ">" + cbxPapan.Text + ">" + loggedUserName)
        'BuatRoom()
        instanceFormLobiGame.Timer1.Enabled = True
        Close()
    End Sub

    Private Sub btnKembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKembali.Click
        Close()
        instanceFormLobiGame.Show()
    End Sub

    Private Sub PictureBoxClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxClose.Click
        Me.Close()
    End Sub

    Private Sub PictureBoxMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
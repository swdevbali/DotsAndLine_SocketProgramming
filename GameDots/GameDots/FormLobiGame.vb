Imports System.Net.Sockets
Imports System.Data.SqlClient

Public Class FormLobiGame

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub FormLobiGame_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'AdidotsDataSet.statistik' table. You can move, or remove it, as needed.
        'Me.StatistikTableAdapter.Fill(Me.AdidotsDataSet.statistik)

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim sql As String = "SELECT [user_pemain] FROM [adidots].[dbo].[statistik]"
        con.ConnectionString = "Data Source=" & compName & ";Network Library=DBMSSOCN;Initial Catalog=adidots;User Id=sa;Password=adminadmin"

        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        Dim rd As SqlDataReader = cmd.ExecuteReader
        lstInfoPemain.Items.Clear()
        While rd.Read
            lstInfoPemain.Items.Add(rd.GetValue(0))
        End While

        lblPemainLogin.Text = loggedUserName
    End Sub

    Private Sub FormLobiGame_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub FormLobiGame_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    Private Sub FormLobiGame_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub PictureBoxClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxClose.Click
        'Me.Close()
        'Application.Exit()
        'TombolClose()
        End
    End Sub

    Private Sub PictureBoxMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInfo.Click
        If lstInfoPemain.Text = "" Then
            MessageBox.Show("Pilih room terlebih dahulu")
            Return
        End If
        Dim username As String = lstInfoPemain.Text
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim sql As String = "SELECT [user_pemain],[jum_menang],[jum_imbang],[jum_kalah],[jum_point] FROM [adidots].[dbo].[statistik] where user_pemain='" & username & "'"
        con.ConnectionString = "Data Source=" & compName & ";Network Library=DBMSSOCN;Initial Catalog=adidots;Integrated Security=True"

        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        Dim rd As SqlDataReader = cmd.ExecuteReader
        rd.Read()

        FormInfoPemain.lblNama_pemain.Text = rd.GetValue(0)
        FormInfoPemain.lblJum_Menang.Text = rd.GetValue(1)
        FormInfoPemain.lblJum_Imbang.Text = rd.GetValue(2)
        FormInfoPemain.lblJum_Kalah.Text = rd.GetValue(3)
        FormInfoPemain.lbl_jumPoin.Text = rd.GetValue(4)


        FormInfoPemain.Show()
    End Sub

    Private Sub btnBuatRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuatRoom.Click
        FormBuatRoom.Show()
    End Sub

    Private Sub btnJoin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJoin.Click
        If lstRoom.Text = "" Then
            MessageBox.Show("Pilih room terlebih dahulu")
            Return
        End If
        instanceGameDot = New FormGameDots
        instanceGameDot.nama_room = lstRoom.Text
        instanceGameDot.init()
        Close()
        instanceGameDot.play()
    End Sub

    Private Sub btnKirimChat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKirimChat.Click
        ModuleClient.sendMessageToServer("CHAT|" + txtInputChat.Text + "$")
        txtInputChat.Text = ""
        txtInputChat.Focus()
    End Sub

    Public Sub logChat()
        If lstChat.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf logChat))
        Else
            Dim newText As String = " >> " + ModuleClient.readData
            'MsgBox(newText)
            Dim broadcast() As String = ModuleClient.readData.Split("|")
            If broadcast(0).Equals("ROOM_QUERY_RESULT") Then
                Dim data As String = broadcast(1)
                lstRoom.Items.Clear()
                Dim room() As String = data.Split(">")

                For i As Integer = 0 To room.Length - 1
                    lstRoom.Items.Add(room(i))
                Next
            ElseIf broadcast(0).Equals("GAME_QUERY_RESULT") Then
                Dim data As String = broadcast(1)
                Dim message() As String = data.Split(">")
                Dim master = message(0).Split("=")(1)
                If master = loggedUserName Then
                    loggedPlayer = Player.Red
                    CurrentPlayer = loggedPlayer
                Else
                    loggedPlayer = Player.Blue
                End If
            Else
                lstChat.Items.Add(newText)
            End If

        End If
    End Sub

    Private Sub txtInputChat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInputChat.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnKirimChat_Click(Nothing, Nothing)
        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        'query for room
        ModuleClient.sendMessageToServer("QUERY_ROOM|")
        ModuleClient.sendMessageToServer("QUERY_USER_LOGIN|")
    End Sub

   
End Class
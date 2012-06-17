Imports System.Net.Sockets
Imports System.Data.SqlClient

Public Class FormLobiGame

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub FormLobiGame_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim sql As String = "SELECT [user_pemain] FROM [adidots].[dbo].[statistik]"

        con.ConnectionString = "Data Source=" & compName & ",1433;Initial Catalog=adidots;User Id=sa;Password=adminadmin"


        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        Dim rd As SqlDataReader = cmd.ExecuteReader
        lstInfoPemain.Items.Clear()
        While rd.Read
            lstInfoPemain.Items.Add(rd.GetValue(0))
        End While

        Timer1.Enabled = True
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

        con.ConnectionString = "Data Source=" & compName & ",1433;Initial Catalog=adidots;User Id=sa;Password=adminadmin"

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
    End Sub

    Private Sub btnKirimChat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKirimChat.Click
        ModuleClient.sendMessageToServer("CHAT|" + txtInputChat.Text + "$")
        txtInputChat.Text = ""
        txtInputChat.Focus()
    End Sub

    Public Sub respondServer()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
     
        con.ConnectionString = "Data Source=" & compName & ",1433;Initial Catalog=adidots;User Id=sa;Password=adminadmin"
        con.Open()
        cmd.Connection = con
       

        If lstChat.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf respondServer))
        Else

            'MsgBox(newText)
            Dim broadcast() As String = ModuleClient.readData.Split("|")
            If broadcast(0).Equals("ROOM_QUERY_RESULT") Then
                Dim data As String = broadcast(1)
                lstRoom.Items.Clear()
                Dim room() As String = data.Split(">")
                'Dim server() As String

                'untuk menampilkan data room di lstRoom

                For i As Integer = 0 To room.Length - 1
                    lstRoom.Items.Add(room(i))
                Next
                'ElseIf broadcast(0).Equals("GAME_QUERY_RESULT") Then
                '    Dim data As String = broadcast(1)
                '    Dim message() As String = data.Split(">")
                '    Dim master = message(0).Split("=")(1)
                '    If master = loggedUserName Then
                '        loggedPlayer = Player.Red
                '        CurrentPlayer = loggedPlayer
                '    Else
                '        loggedPlayer = Player.Blue
                '    End If
            ElseIf broadcast(0).Equals("GAME_QUERY_RESULT") Then
                Dim data As String = broadcast(1)
                Dim message() As String = data.Split(">")

                instanceGameDot.playerSize = CInt(message(0).Split("=")(1))
                Dim namaRoom As String = message(1).Split("=")(1)
                Dim user As String = message(2).Split("=")(1)
                If Username = loggedUserName Then
                    If instanceGameDot.playerSize = 0 Then
                        cmd.CommandText = "update [adidots].[dbo].[room] set [adidots].[dbo].[room].[jumlah_pemain]=1 where [adidots].[dbo].[room].nama_room='" & namaRoom & "'"
                        cmd.ExecuteNonQuery()

                        MsgBox("Anda masuk sebagai palyer 1! Selamat bermain Biru!")
                        ModuleClient.sendMessageToServer("ENTER_GAME|room=" + namaRoom + ">username=" + user)
                        Hide()
                    Else
                        'TODO : masuk sbg player 2
                        cmd.CommandText = "update [adidots].[dbo].[room] set [adidots].[dbo].[room].[jumlah_pemain]=[adidots].[dbo].[room].[jumlah_pemain]+1 where [adidots].[dbo].[room].nama_room='" & namaRoom & "'"
                        cmd.ExecuteNonQuery()

                        MsgBox("Anda masuk sebagai player 2! Selamat bermain Merah!")
                        ModuleClient.sendMessageToServer("ENTER_GAME|room=" + namaRoom + ">username=" + user)
                        Hide()
                    End If
                End If
            ElseIf broadcast(0).Equals("ENTER_GAME_RESULT") Then
                If Username = loggedUserName Then
                    Dim data As String = broadcast(1)
                    Dim username As String = data
                    'If username = loggedUserName Then
                    Hide()
                    Dots = GridSizes(GridPlaySize)
                    instanceGameDot.RescaleGrid()
                    DefineGrid()
                    clearboard()
                    resetscores()
                    instanceGameDot.play()
                End If
            Else
                Dim newText As String = " >> " + ModuleClient.readData
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
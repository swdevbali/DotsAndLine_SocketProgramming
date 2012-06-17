Imports System.Net.Sockets
Imports System.Text
Imports System.Data.SqlClient

Module ModuleServer
    Dim clientsList As New Hashtable
    Dim compName As String = "127.0.0.1"
    Dim roomList As New Hashtable
    Private Sub broadcastToAllClient(ByVal msg As String, ByVal uName As String, ByVal flag As Boolean)
        Dim Item As DictionaryEntry
        For Each Item In clientsList
            Console.WriteLine(Item)
            Dim broadcastSocket As TcpClient
            broadcastSocket = CType(Item.Value, TcpClient)
            If Not broadcastSocket.Connected Then Continue For
            Dim broadcastStream As NetworkStream = broadcastSocket.GetStream()
            Dim broadcastBytes As [Byte]()

            'kirim message ke game client
            If flag = True Then
                broadcastBytes = Encoding.ASCII.GetBytes(uName + " says : " + msg)
            Else
                broadcastBytes = Encoding.ASCII.GetBytes(msg)
            End If

            broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length)
            broadcastStream.Flush()
        Next
    End Sub
    Sub Main()
        Dim serverSocket As New TcpListener(8888)
        Dim clientSocket As TcpClient = Nothing
        Dim counter As Integer

        serverSocket.Start()
        msg("Server Game Dots and Lines Sedang Berjalan ....")
        counter = 0

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=" & compName & ",1433;Initial Catalog=adidots;User Id=sa;Password=adminadmin"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "update [adidots].[dbo].[room] set [adidots].[dbo].[room].[jumlah_pemain]=0"
        cmd.ExecuteNonQuery()
        While (True)
            counter += 1
            clientSocket = serverSocket.AcceptTcpClient()
            If clientSocket IsNot Nothing Then
                Dim bytesFrom(10024) As Byte
                Dim dataFromClient As String

                Dim networkStream As NetworkStream = clientSocket.GetStream()
                networkStream.Read(bytesFrom, 0, CInt(clientSocket.ReceiveBufferSize))
                dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom)
                dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"))

                clientsList(dataFromClient) = clientSocket

                'send message ke client game
                broadcastToAllClient(dataFromClient + " Join ke Lobi Game ", dataFromClient, False)

                'send message ke server game
                msg(dataFromClient + " Join ke Lobi Game ")
                Dim client As New HandleClient
                client.startClient(clientSocket, dataFromClient, clientsList)
            End If
        End While

        clientSocket.Close()
        serverSocket.Stop()
        msg("exit")
        Console.ReadLine()

    End Sub

    Sub msg(ByVal mesg As String)
        mesg.Trim()
        Console.WriteLine(" >> " + mesg)
    End Sub

    Public Class HandleClient
        Dim clientSocket As TcpClient
        Dim clNo As String
        Dim clientsList As Hashtable

        Public Sub startClient(ByVal inClientSocket As TcpClient, ByVal clineNo As String, ByVal cList As Hashtable)
            Me.clientSocket = inClientSocket
            Me.clNo = clineNo
            Me.clientsList = cList
            Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf processServerCommand)
            ctThread.Start()
        End Sub

        Private Sub processServerCommand()
            'Dim infiniteCounter As Integer
            Dim requestCount As Integer
            Dim bytesFrom(10024) As Byte
            Dim dataFromClient As String
            'Dim sendBytes As [Byte]()
            'Dim serverResponse As String
            Dim rCount As String
            requestCount = 0

            'kirim message ke server game
            While (True)
                Try
                    requestCount = requestCount + 1
                    If (clientSocket.Connected) Then
                        Dim networkStream As NetworkStream = clientSocket.GetStream()
                        networkStream.Read(bytesFrom, 0, CInt(clientSocket.ReceiveBufferSize))
                        dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom)
                        Console.Write(dataFromClient.Length & " - indexof " & dataFromClient.IndexOf("$"))
                        If (dataFromClient.Length > 0) Then
                            If (dataFromClient.IndexOf("$") <> -1) Then
                                dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"))
                            End If

                            msg("From client - " + clNo + " : " + dataFromClient)
                            rCount = Convert.ToString(requestCount)
                            Dim message() As String = dataFromClient.Split("|")
                            Dim messageType = Nothing
                            Dim messageData = Nothing
                            If (message.Length = 1) Then
                                messageType = message(0)
                            Else
                                messageType = message(0)
                                messageData = message(1)
                            End If

                            If (messageType = "CHAT") Then
                                broadcastToAllClient(dataFromClient, clNo, True)
                            ElseIf messageType = "CREATE_ROOM" Then
                                createRoom(messageData)
                            ElseIf messageType = "QUERY_ROOM" Then
                                queryRoom()
                            ElseIf messageType = "QUERY_GAME" Then
                                queryGame(messageData)
                            ElseIf messageType = "ENTER_GAME" Then
                                enterGame(messageData)
                            ElseIf messageType = "MOVE" Then
                                move(messageData)
                            End If
                        End If
                    End If
                Catch ex As Exception
                    If clientSocket IsNot Nothing Then clientSocket.Close()
                    Console.WriteLine(ex.ToString)
                End Try
            End While
        End Sub

        Private Sub createRoom(ByVal messageData As String)
            Dim data() As String = messageData.Split(">")
            Dim nama_room As String = data(0)
            Dim ukuran_papan As String = data(1)
            Dim user_pemain As String = data(2)
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            con.ConnectionString = "Data Source=" & compName & ",1433;Initial Catalog=adidots;User Id=sa;Password=adminadmin"

            con.Open()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO room([nama_room],[ukuran_papan],[user_pemain])VALUES('" & nama_room & "', '" & ukuran_papan & "','" & user_pemain & "')"
            cmd.ExecuteNonQuery()
            con.Close()
        End Sub
        Private Sub queryRoom()
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim room As String = ""

            con.ConnectionString = "Data Source=" & compName & ",1433;Initial Catalog=adidots;User Id=sa;Password=adminadmin"

            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT [nama_room],[user_pemain] FROM [adidots].[dbo].[room] order by nama_room"
            Dim rd As SqlDataReader = cmd.ExecuteReader()
            Do While rd.Read
                room = rd.GetString(0) & ">" & room
            Loop
            room = room.Substring(0, room.Length - 1)
            con.Close()
            broadcastToAllClient("ROOM_QUERY_RESULT|" & room, clNo, False)
        End Sub

        Private Sub queryGame(ByVal messageData As String)
            Dim data() As String = messageData.Split(">")
            Dim nama_room As String = data(0)
            Dim username As String = data(1)


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim room As String = ""

            con.ConnectionString = "Data Source=" & compName & ",1433;Initial Catalog=adidots;User Id=sa;Password=adminadmin"

            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT [jumlah_pemain] FROM [adidots].[dbo].[room] where [adidots].[dbo].[room].[nama_room] = '" + nama_room + "'"
            Dim rd As SqlDataReader = cmd.ExecuteReader()
            rd.Read()

            Dim playerCount As Integer = IIf(IsDBNull(rd(0)), 0, rd(0))
            Dim msgToSend As String = "GAME_QUERY_RESULT|player_count=" & playerCount & ">room=" & nama_room & ">username=" & username

            broadcastToAllClient(msgToSend, username, False)
            rd.Close()
            cmd.Dispose()
        End Sub

        Private Sub enterGame(ByVal messageData As String)
            Dim data() As String = messageData.Split(">")
            Dim nama_room As String = data(0).Split("=")(0)
            Dim username As String = data(1).Split("=")(1)
            Dim msgToSend As String

            msgToSend = "ENTER_GAME_RESULT|" & username
            broadcastToAllClient(msgToSend, username, False)
        End Sub

        Private Sub move(ByVal messageData As Object)
            Dim msgToSend As String
            Dim data() As String = messageData.Split(">")
            Dim username As String = data(0)
            Dim Cell_No As String = data(1)
            Dim InCell_X As String = data(2)
            Dim InCell_Y As String = data(3)
            msgToSend = "MOVE_RESULT|" & username & ">" & Cell_No & ">" & InCell_X & ">" & InCell_Y
            broadcastToAllClient(msgToSend, username, False)
        End Sub

    End Class
End Module
Imports System.Net.Sockets
Imports System.Text
Imports System.Data.SqlClient

Module ModuleServer
    Dim clientsList As New Hashtable
    Dim compName As String = "localhost"
    Private Sub broadcastToAllClient(ByVal msg As String, ByVal uName As String, ByVal flag As Boolean)
        Dim Item As DictionaryEntry
        For Each Item In clientsList
            Dim broadcastSocket As TcpClient
            broadcastSocket = CType(Item.Value, TcpClient)
            If Not broadcastSocket.Connected Then Continue For
            Dim broadcastStream As NetworkStream = broadcastSocket.GetStream()
            Dim broadcastBytes As [Byte]()

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

                broadcastToAllClient(dataFromClient + " Joined ", dataFromClient, False)

                msg(dataFromClient + " Joined Games Lobby ")
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
            Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf doChat)
            ctThread.Start()
        End Sub

        Private Sub doChat()
            'Dim infiniteCounter As Integer
            Dim requestCount As Integer
            Dim bytesFrom(10024) As Byte
            Dim dataFromClient As String
            'Dim sendBytes As [Byte]()
            'Dim serverResponse As String
            Dim rCount As String
            requestCount = 0

            While (True)
                Try
                    requestCount = requestCount + 1
                    Dim networkStream As NetworkStream = clientSocket.GetStream()
                    networkStream.Read(bytesFrom, 0, CInt(clientSocket.ReceiveBufferSize))
                    dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom)
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"))
                    msg("From client - " + clNo + " : " + dataFromClient)
                    rCount = Convert.ToString(requestCount)
                    Dim message() As String = dataFromClient.Split("|")
                    Dim messageType = message(0)
                    Dim messageData = message(1)


                    If (messageType = "CHAT") Then
                        broadcastToAllClient(dataFromClient, clNo, True)
                    ElseIf messageType = "CREATE_ROOM" Then
                        createRoom(messageData)
                    ElseIf messageType = "QUERY_ROOM" Then
                        queryRoom()
                    End If
                Catch ex As Exception
                    If clientSocket IsNot Nothing Then clientSocket.Close()
                    'Console.WriteLine(ex.ToString)
                End Try
            End While
        End Sub

        Private Sub createRoom(ByVal messageData As String)
            Dim data() As String = messageData.Split(">")
            Dim nama_room As String = data(0)
            Dim jumlah_pemain As String = data(1)
            Dim ukuran_papan As String = data(2)

            Dim user_pemain As String = data(3)
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            con.ConnectionString = "Data Source=" & compName & ";Initial Catalog=adidots;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO room([nama_room],[jumlah_pemain],[ukuran_papan_col],[ukuran_papan_rows],[user_pemain])VALUES('" & nama_room & "','" & jumlah_pemain & "', '" & ukuran_papan & "','" & user_pemain & "')"
            cmd.ExecuteNonQuery()
            con.Close()

        End Sub

        Private Sub queryRoom()
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim room As String = ""
            con.ConnectionString = "Data Source=" & compName & ";Initial Catalog=adidots;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT [nama_room] ,[user_pemain] FROM [adidots].[dbo].[room]"
            Dim rd As SqlDataReader = cmd.ExecuteReader()
            Do While rd.Read
                room = rd.GetString(0) & ">" & room
            Loop
            room = room.Substring(0, room.Length - 1)
            con.Close()
            broadcastToAllClient("ROOM_QUERY_RESULT|" & room, clNo, False)
        End Sub

    End Class


End Module

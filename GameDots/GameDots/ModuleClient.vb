Imports System.Net.Sockets

Module ModuleClient

    Dim clientSocket As New System.Net.Sockets.TcpClient()
    Dim serverStream As NetworkStream
    Public readData As String
    Dim infiniteC As Integer

    Public Sub sendMessageToServer(ByVal s As String)
        Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes(s + "$")
        If serverStream Is Nothing Then Return
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()
    End Sub
    Private Sub msg()
        instanceFormLobiGame.logChat()
        instanceGameDot.logChat2()
    End Sub

    Public Sub connectToServer(ByVal username As String)
        readData = "Conected to Game Server Dots and Lines..."
        msg()

        clientSocket.Connect("127.0.0.1", 8888)

        'Label1.Text = "Client Socket Program - Server Connected ..."
        serverStream = clientSocket.GetStream()

        Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes(username + "$")
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()

        Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf getMessage)
        ctThread.Start()
    End Sub

    Private Sub getMessage()

        Try
            For infiniteCounter = 1 To 2
                infiniteCounter = 1
                serverStream = clientSocket.GetStream()
                Dim buffSize As Integer
                Dim inStream(10024) As Byte
                buffSize = clientSocket.ReceiveBufferSize
                serverStream.Read(inStream, 0, buffSize)
                Dim returndata As String = System.Text.Encoding.ASCII.GetString(inStream)
                readData = "" + returndata
                msg()
            Next
        Catch e As Exception
        End Try
    End Sub
End Module

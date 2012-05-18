Imports System.Data.SqlClient
Imports System.Net.Sockets
Module Main

    ' Public LobiGameForm As New FormLobiGame
    Public Msg As Integer
    Public intResponse As Integer
    Public Username, Password As String
    Public compName As String = "127.0.0.1"

    Public instanceFormLobiGame As New FormLobiGame
    Public instanceGameDot As New FormGameDots
    Public instanceGameServer As New FormGameServer
    Public loggedUserName As String
    Public loggedPlayer As Player


   

    Sub TombolClose()

        'method tombol close form
        If MessageBox.Show("Ente yakin mau keluar ??", "Dots & Lines", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

            instanceGameDot.Close()
        Else
            instanceGameDot.Show()
        End If
    End Sub
End Module

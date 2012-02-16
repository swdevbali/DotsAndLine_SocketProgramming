Imports System.Data.SqlClient
Imports System.Net.Sockets
Module Main

    ' Public LobiGameForm As New FormLobiGame
    Public Msg As Integer
    Public intResponse As Integer
    Public Username, Password As String

    Public compName As String
    Public instanceFormLobiGame As New FormLobiGame

    Public loggedUserName As String
    Sub TombolClose()

        'method tombol close form
        If MessageBox.Show("Ente yakin mau keluar ??", "Dots & Lines", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

            'Application.Exit()
            instanceFormLobiGame.Show()
            FormGameDots.Close()
        Else
            FormGameDots.Show()
        End If
    End Sub
End Module

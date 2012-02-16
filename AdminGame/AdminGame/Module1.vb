Imports System.Data.SqlClient
Module Module1
    Public Msg As Integer
    Public intResponse As Integer
    Public Username, Password As String
    Public compName As String
    Sub TombolClose()
        'method tombol close form
        If MessageBox.Show("Ente yakin mau keluar ??", "Dots & Lines", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Module

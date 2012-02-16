Imports System.Data.SqlClient

Public Class KoneksiDb

    Public Function open() As SqlClient.SqlConnection
        Dim conect As SqlConnection = Nothing
        Dim conectString As String = "Data Source=" & compName & ";Initial Catalog=adidots;Integrated Security=True"
        conect = New SqlConnection(conectString)
        conect.Open()
        Return conect
    End Function

    Public Function close() As SqlClient.SqlConnection
        Dim conect As SqlConnection = Nothing
        Dim conectString As String = "Data Source=" & compName & ";Initial Catalog=adidots;Integrated Security=True"
        conect = New SqlConnection(conectString)
        conect.Close()
        Return conect
    End Function

End Class

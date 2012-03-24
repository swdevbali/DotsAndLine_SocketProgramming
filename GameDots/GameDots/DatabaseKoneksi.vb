Imports System.Data.SqlClient


Public Class DatabaseKoneksi

    Public Function open() As SqlClient.SqlConnection

        Dim conect As SqlConnection = Nothing
        'Data Source=190.190.200.100,1433;Network Library=DBMSSOCN;Initial Catalog=myDataBase;User ID=myUsername;Password=myPassword;
        Dim conectString As String = "Data Source=" & compName & ",1433;Initial Catalog=adidots;User Id=sa;Password=adminadmin"
        conect = New SqlConnection(conectString)
        conect.Open()
        Return conect

    End Function
    Public Function close() As SqlClient.SqlConnection

        Dim conect As SqlConnection = Nothing
        Dim conectString As String = "Data Source=" & compName & ",1433;Initial Catalog=adidots;User Id=sa;Password=adminadmin"
        conect = New SqlConnection(conectString)
        conect.Close()
        Return conect

    End Function
End Class

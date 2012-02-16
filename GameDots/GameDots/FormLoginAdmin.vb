Imports System.Text
Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Public Class FormLoginAdmin
    Dim MyConnection As New DatabaseKoneksi
    Dim objConnection As SqlConnection
    Dim objCommand As SqlCommand
    Dim objDataAdapter As SqlDataAdapter
    Dim objdatareader As SqlDataReader
    Dim strSQL As String
    Dim objDataSet As New DataSet
    Dim objDataTable As New DataTable
    Dim mProcess As String

    Sub CheckUser()
        objDataTable.Clear()
        strSQL = ("SELECT * FROM [admin] WHERE [user_admin] " & " = '" & Trim(txtUsername.Text) & "' ")
        objCommand = New sqlCommand
        objCommand.Connection = MyConnection.open
        objCommand.CommandType = CommandType.Text
        objCommand.CommandText = strSQL
        objDataAdapter = New SqlDataAdapter(objCommand)
        objDataAdapter.Fill(objDataSet, "MDT_admin")
        objDataTable = objDataSet.Tables("MDT_admin")
        MyConnection.close()
    End Sub


    Sub Find_User()
        objCommand = MyConnection.open.CreateCommand
        objCommand.CommandText = ("Select [user_admin],[password] from [admin] where [user_admin]='" & Trim(txtUsername.Text) + "' ")
        objdatareader = objCommand.ExecuteReader
        objdatareader.Read()
        Username = objdatareader.Item("user_admin")
        Password = objdatareader.Item("password")
        MyConnection.close()

    End Sub
    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        FormMenuLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        'untuk mengaktifkan fungsi CheckUsers
        CheckUser()
        'mengharuskan user memasukkan username dan password
        If txtUsername.Text.Trim() = "" And txtPassword.Text.Trim() = "" Then
            Msg = MsgBox("Masukan Ip server, User Name dan Password", MsgBoxStyle.Critical, "Pesan")
            txtUsername.Focus()
        ElseIf txtUsername.Text = "" Then
            Msg = MsgBox("Masukan UserName ", MsgBoxStyle.Critical, "Pesan")
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            Msg = MsgBox("Masukan password ", MsgBoxStyle.Critical, "Pesan")
            txtPassword.Focus()
        Else
            Try
                'Menghitung jumlah baris yang ada pada ObjDataTable
                If objDataTable.Rows.Count <= 0 Then
                    'Jika jumlah baris = 0 / username tidak ada pada table
                    Msg = MsgBox("UserName tidak ada ", MsgBoxStyle.Critical, "Pesan")
                    txtUsername.Focus()
                Else
                    'Jika username ada pada table / jumlah baris ObjdataTable > 0
                    'Mengaktifkan fungsi mencari nilai value Username & Password
                    Find_User()
                    'Jika Password yang diketik pada TextBox tidak sama pada Database
                    If Password <> Trim(txtPassword.Text) Then
                        Msg = MsgBox("Password salah!", MsgBoxStyle.Critical, "Pesan")
                        txtPassword.Focus()
                        Exit Sub
                    Else
                        'Jika Sama
                        Me.Hide()
                        FormMenuAdmin.Show()
                        txtUsername.Text = ""
                        txtPassword.Text = ""
                    End If
                End If
            Catch When Err.Number <> 0
                MsgBox("Tidak dapat melakukan proses" & vbCrLf & Err.Description)
            End Try
        End If
    End Sub
End Class
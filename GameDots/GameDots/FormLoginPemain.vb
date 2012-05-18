Imports System.Net.Sockets
Imports System.Text
Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient


Public Class FormLoginPemain
   
    Dim MyConnection As New DatabaseKoneksi
    Dim objConnection As SqlConnection
    Dim objCommand As SqlCommand
    Dim objDataAdapter As SqlDataAdapter
    Dim objdatareader As SqlDataReader
    Dim strSQL As String
    Dim objDataSet As New DataSet
    Dim objDataTable As New DataTable
    Dim mProcess As String

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Sub CheckUser()
        objDataTable.Clear()
        strSQL = ("SELECT * FROM [pemain] WHERE [user_pemain] " & " = '" & Trim(txtNamapemain.Text) & "' ")
        objCommand = New SqlCommand
        objCommand.Connection = MyConnection.open
        objCommand.CommandType = CommandType.Text
        objCommand.CommandText = strSQL
        objDataAdapter = New SqlDataAdapter(objCommand)
        objDataAdapter.Fill(objDataSet, "MDT_pemain")
        objDataTable = objDataSet.Tables("MDT_pemain")
        MyConnection.close()
    End Sub

    Sub Find_User()
        objCommand = MyConnection.open.CreateCommand
        objCommand.CommandText = ("Select [user_pemain],[password] from [pemain] where [user_pemain]='" & Trim(txtNamapemain.Text) + "' ")
        objdatareader = objCommand.ExecuteReader
        objdatareader.Read()
        Username = objdatareader.Item("user_pemain")
        Password = objdatareader.Item("password")
        MyConnection.close()

    End Sub

    Private Sub FormLoginPemain_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub FormLoginPemain_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    Private Sub FormLoginPemain_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub PictureBoxClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxClose.Click
        Application.Exit()
    End Sub

    Private Sub PictureBoxMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click

        'untuk mengaktifkan fungsi CheckUsers
        CheckUser()
        'mengharuskan user memasukkan username dan password
        If txtNamapemain.Text.Trim() = "" And txtPassword.Text.Trim() = "" Then
            Msg = MsgBox("Masukan Ip server, Nama Pemain dan Password", MsgBoxStyle.Critical, "Pesan")
            txtNamapemain.Focus()
        ElseIf txtIpserver.Text = "" Then
            Msg = MsgBox("Masukkan IP Server", MsgBoxStyle.Critical, "Pesan")
            txtIpserver.Focus()
        ElseIf txtNamapemain.Text = "" Then
            Msg = MsgBox("Masukan Nama Pemain ", MsgBoxStyle.Critical, "Pesan")
            txtNamapemain.Focus()
        ElseIf txtPassword.Text = "" Then
            Msg = MsgBox("Masukan password ", MsgBoxStyle.Critical, "Pesan")
            txtPassword.Focus()
        Else
            Try
                'Menghitung jumlah baris yang ada pada ObjDataTable
                If objDataTable.Rows.Count <= 0 Then
                    'Jika jumlah baris = 0 / username tidak ada pada table
                    Msg = MsgBox("Nama Pemain tidak ada ", MsgBoxStyle.Critical, "Pesan")
                    txtNamapemain.Focus()
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
                        'konek ke server game
                        loggedUserName = txtNamapemain.Text

                        instanceFormLobiGame.Show()
                        ModuleClient.connectToServer(txtNamapemain.Text)
                        txtNamapemain.Text = ""
                        txtPassword.Text = ""

                        Me.Close()
                    End If
                End If
            Catch When Err.Number <> 0
                MsgBox("Tidak dapat melakukan proses" & vbCrLf & Err.Description)
            End Try
        End If

    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click

        FormMenuLogin.Show()
        Me.Hide()
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnLogin_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub FormLoginPemain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       


    End Sub
End Class
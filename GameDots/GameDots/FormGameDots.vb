Imports System.Data.SqlClient

Public Class FormGameDots
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
#Region "Paper Functions"
    Dim ColorOfBlueBox As Brush = Brushes.Blue
    Dim ColorOfRedBox As Brush = Brushes.Red
    Dim ColorOfHightlightedLineBlue As New Pen(Color.Blue, 4)
    Dim ColorOfHightlightedLineRed As New Pen(Color.Red, 4)

    Dim ColorOfLine As New Pen(Color.Black, 4)
    Dim ColorOfDot As New Pen(Color.Black, 2.6)
    Dim ScaleWidth As Single
    Dim ScaleHeight As Single
    Dim OffSet As Single = 6
    Public nama_room As String
    Dim ganti As Boolean = False

    Dim MouseLocation As Point
    Dim ok As Boolean = False

    Public Sub MakeMove(ByVal Cell_No As Single, ByVal InCell_X As Single, ByVal InCell_Y As Single)
        For i As Integer = 0 To LineMax
            HLines(i).LineHighlight = False : Vlines(i).LineHighlight = False
        Next
        Dim CountOfMadeBoxes As Integer = 0
        Dim MoveIsValid As Boolean = False

        Select Case True
            Case (InCell_X = 0) And (InCell_Y = 1)
                If (Cells(Cell_No).LineBehind <> Invalid) And (Vlines(Cells(Cell_No).LineBehind).LineUsed = False) Then
                    Vlines(Cells(Cell_No).LineBehind).LineUsed = True
                    MoveIsValid = True
                    DoesItMakeABox(CountOfMadeBoxes, Vlines(Cells(Cell_No).LineBehind).CellAhead)
                    DoesItMakeABox(CountOfMadeBoxes, Vlines(Cells(Cell_No).LineBehind).CellBehind)
                End If
            Case (InCell_X = 2) And (InCell_Y = 1)
                If (Cells(Cell_No).LineAhead <> Invalid) And (Vlines(Cells(Cell_No).LineAhead).LineUsed = False) Then
                    Vlines(Cells(Cell_No).LineAhead).LineUsed = True
                    MoveIsValid = True
                    DoesItMakeABox(CountOfMadeBoxes, Vlines(Cells(Cell_No).LineAhead).CellAhead)
                    DoesItMakeABox(CountOfMadeBoxes, Vlines(Cells(Cell_No).LineAhead).CellBehind)
                End If
            Case (InCell_Y = 0) And (InCell_X = 1)
                If (Cells(Cell_No).LineAbove <> Invalid) And (HLines(Cells(Cell_No).LineAbove).LineUsed = False) Then
                    HLines(Cells(Cell_No).LineAbove).LineUsed = True
                    MoveIsValid = True
                    DoesItMakeABox(CountOfMadeBoxes, HLines(Cells(Cell_No).LineAbove).CellAbove)
                    DoesItMakeABox(CountOfMadeBoxes, HLines(Cells(Cell_No).LineAbove).CellBelow)
                End If
            Case (InCell_Y = 2) And (InCell_X = 1)
                If (Cells(Cell_No).LineBelow <> Invalid) And (HLines(Cells(Cell_No).LineBelow).LineUsed = False) Then
                    HLines(Cells(Cell_No).LineBelow).LineUsed = True
                    MoveIsValid = True
                    DoesItMakeABox(CountOfMadeBoxes, HLines(Cells(Cell_No).LineBelow).CellAbove)
                    DoesItMakeABox(CountOfMadeBoxes, HLines(Cells(Cell_No).LineBelow).CellBelow)
                End If
        End Select

        If CountOfMadeBoxes = 0 And MoveIsValid = True Then
            Select Case CurrentPlayer
                Case Player.Red : CurrentPlayer = Player.Blue
                Case Player.Blue : CurrentPlayer = Player.Red
            End Select

        End If

        WorkOutScore()
    End Sub
   Private Sub ClickedOnPaper(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PB_Paper.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If CurrentPlayer = Player.Blue Then
                MouseLocation = New Point(e.Location)
                Dim Cell_X As Single = Math.Floor((MouseLocation.X - OffSet) / ScaleWidth)
                Dim Cell_Y As Single = Math.Floor((MouseLocation.Y - OffSet) / ScaleHeight)
                Dim Cell_No As Single = Math.Abs((Cell_Y * (Dots - 1)) + Cell_X)

                If Cell_X >= (Dots - 1) Or Cell_Y >= (Dots - 1) Then Exit Sub

                Dim InCell_X As Single = Math.Floor(((MouseLocation.X - OffSet) Mod ScaleWidth) / (ScaleWidth / 3))
                Dim InCell_Y As Single = Math.Floor(((MouseLocation.Y - OffSet) Mod ScaleHeight) / (ScaleHeight / 3))
                If ok = True Then
                    MakeMove(Cell_No, InCell_X, InCell_Y)
                    'server.SendMove(Cell_No, InCell_X, InCell_Y)
                    ganti = True
                End If
            Else
                lblStatus.Text = "Giliran Player Merah"
            End If

        End If

    End Sub


    Private Sub MouseOverPaper(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PB_Paper.MouseMove

        For i As Integer = 0 To LineMax
            HLines(i).LineHighlight = False : Vlines(i).LineHighlight = False
        Next
        MouseLocation = New Point(e.Location)
        Dim Cell_X As Single = Math.Floor((MouseLocation.X - OffSet) / ScaleWidth)
        Dim Cell_Y As Single = Math.Floor((MouseLocation.Y - OffSet) / ScaleHeight)
        Dim Cell_No As Single

        If Cell_X >= (Dots - 1) Or Cell_Y >= (Dots - 1) Then Exit Sub

        Dim InCell_X As Single = Math.Floor(((MouseLocation.X - OffSet) Mod ScaleWidth) / (ScaleWidth / 3))
        Dim InCell_Y As Single = Math.Floor(((MouseLocation.Y - OffSet) Mod ScaleHeight) / (ScaleHeight / 3))

        Cell_No = Math.Abs((Cell_Y * (Dots - 1)) + Cell_X)
        Select Case True
            Case (InCell_X = 0) And (InCell_Y = 1)
                If (Cells(Cell_No).LineBehind <> Invalid) And (Vlines(Cells(Cell_No).LineBehind).LineUsed = False) Then
                    Vlines(Cells(Cell_No).LineBehind).LineHighlight = True
                    ok = True
                End If

            Case (InCell_X = 2) And (InCell_Y = 1)
                If (Cells(Cell_No).LineAhead <> Invalid) And (Vlines(Cells(Cell_No).LineAhead).LineUsed = False) Then
                    Vlines(Cells(Cell_No).LineAhead).LineHighlight = True
                    ok = True
                End If

            Case (InCell_Y = 0) And (InCell_X = 1)
                If (Cells(Cell_No).LineAbove <> Invalid) And (HLines(Cells(Cell_No).LineAbove).LineUsed = False) Then
                    HLines(Cells(Cell_No).LineAbove).LineHighlight = True
                    ok = True
                End If

            Case (InCell_Y = 2) And (InCell_X = 1)
                If (Cells(Cell_No).LineBelow <> Invalid) And (HLines(Cells(Cell_No).LineBelow).LineUsed = False) Then
                    HLines(Cells(Cell_No).LineBelow).LineHighlight = True
                    ok = True
                End If
            Case Else
                ok = False
        End Select
        Me.Refresh()
        If DEBUG_ShowLine Then Console.WriteLine(e.Location.ToString & " " & CStr(Cell_No) & "->" & CStr(Cell_X) & " " & CStr(Cell_Y) & " <> " & CStr(InCell_X) & " " & CStr(InCell_Y))
    End Sub

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PB_Paper.Paint
        drawBoxes(e.Graphics)
        drawLines(e.Graphics)
        drawDots(e.Graphics)
        UpdateTheScores()
    End Sub

    Private Sub UpdateTheScores()
        scorePemain1.Text = RedScore.ToString
        scorePemain2.Text = BlueScore.ToString
    End Sub


    Private Sub drawBoxes(ByRef g As Graphics)
        Dim x As Integer
        Dim y As Integer
        For i As Integer = 0 To CellMax
            x = i Mod (Dots - 1) : y = i \ (Dots - 1)
            Select Case Cells(y * (Dots - 1) + x).CellOwner
                Case Player.Red : g.FillRectangle(ColorOfRedBox, OffSet + (ScaleWidth * x), OffSet + (ScaleHeight * y), ScaleWidth, ScaleHeight)
                Case Player.Blue : g.FillRectangle(ColorOfBlueBox, OffSet + (ScaleWidth * x), OffSet + (ScaleHeight * y), ScaleWidth, ScaleHeight)
            End Select
        Next
    End Sub

    Private Sub drawLines(ByRef g As Graphics)
        Dim x As Integer
        Dim y As Integer
        ' draw garis vertikal
        For i As Integer = 0 To LineMax
            x = i Mod Dots
            y = i \ Dots
            If Vlines(i).LineUsed Then
                g.DrawEllipse(ColorOfLine, OffSet + (ScaleWidth * x), OffSet + (ScaleHeight * y), 0, ScaleHeight)
            ElseIf Vlines(i).LineHighlight Then
                Select Case CurrentPlayer
                    Case Player.Red : g.DrawEllipse(ColorOfHightlightedLineRed, OffSet + (ScaleWidth * x), OffSet + (ScaleHeight * y), 0, ScaleHeight)
                    Case Player.Blue : g.DrawEllipse(ColorOfHightlightedLineBlue, OffSet + (ScaleWidth * x), OffSet + (ScaleHeight * y), 0, ScaleHeight)
                End Select

            End If
        Next
        ' Draw garis horizontal
        For i As Integer = 0 To LineMax
            x = i Mod (Dots - 1)
            y = i \ (Dots - 1)
            If HLines(i).LineUsed Then
                g.DrawEllipse(ColorOfLine, OffSet + (ScaleWidth * x), OffSet + (ScaleHeight * y), ScaleWidth, 0)
            ElseIf HLines(i).LineHighlight Then
                Select Case CurrentPlayer
                    Case Player.Red : g.DrawEllipse(ColorOfHightlightedLineRed, OffSet + (ScaleWidth * x), OffSet + (ScaleHeight * y), ScaleHeight, 0)
                    Case Player.Blue : g.DrawEllipse(ColorOfHightlightedLineBlue, OffSet + (ScaleWidth * x), OffSet + (ScaleHeight * y), ScaleHeight, 0)
                End Select
            End If
        Next

    End Sub
    Private Sub drawDots(ByRef g As Graphics)
        For y As Integer = 0 To (Dots - 1)
            For x As Integer = 0 To (Dots - 1)
                g.DrawEllipse(ColorOfDot, OffSet + ((ScaleWidth * x) - ColorOfDot.Width), OffSet + ((ScaleHeight * y) - ColorOfDot.Width), (2 * ColorOfDot.Width), (2 * ColorOfDot.Width))
            Next
        Next
    End Sub
    Public Sub RescaleGrid()
        ScaleWidth = (Me.PB_Paper.Width - (OffSet * 2)) / (Dots - 1)
        ScaleHeight = (Me.PB_Paper.Height - (OffSet * 2)) / (Dots - 1)
    End Sub
#End Region

    Private Sub PictureBox2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox2.Paint
        Select Case CurrentPlayer
            Case Player.Red : Me.PictureBox2.BackColor = Color.Red
                If Player.Red Then
                    lblStatus.ForeColor = Color.Red
                    lblStatus.Text = "Merah"
                End If

            Case Player.Blue : Me.PictureBox2.BackColor = Color.Blue
                If Player.Blue Then
                    lblStatus.ForeColor = Color.Blue
                    lblStatus.Text = "Biru"
                End If

        End Select
    End Sub

    Private Sub FormGameDots_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        instanceFormLobiGame = New FormLobiGame
        instanceFormLobiGame.Show()
    End Sub

    Private Sub FormGameDots_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'GridPlaySize = 0 ' GridCombo.SelectedIndex

        lblPemain1.Text = loggedUserName

    End Sub
    Private Sub FormGameDots_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub FormGameDots_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    Private Sub FormGameDots_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub btnPetunjuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPetunjuk.Click
        FormPetunjuk.Show()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        'Close()
        TombolClose()
    End Sub

    Private Sub PictureBoxClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TombolClose()
    End Sub

    Private Sub PictureBoxMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FormGameDots_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Me.PB_Paper.Refresh()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' menambahkan initialization sebelum memanggil InitializeComponent()
        RescaleGrid()


    End Sub

    Public Sub init()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim room As String = ""
        Dim sql As String = "SELECT [nama_room] ,[user_pemain],[ukuran_papan] FROM [adidots].[dbo].[room] where nama_room='PARAM1'"
        sql = sql.Replace("PARAM1", Trim(nama_room))

        con.ConnectionString = "Data Source=" & compName & ",1433;Initial Catalog=adidots;User Id=sa;Password=adminadmin"

        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.CommandText.Trim()
        Dim rd As SqlDataReader = cmd.ExecuteReader()

        rd.Read()
        If rd.HasRows Then
            GridPlaySize = CInt(rd.GetValue(2)) - 4
            ModuleClient.sendMessageToServer("QUERY_GAME|" & nama_room & ">" & loggedUserName)

        End If

       

    End Sub


    Sub play()
        Show()
        While StillRunning
            If CountEmptyCells() = 0 Then
                GameRunning = False
                Dim messageText As String = ""
                Select Case True
                    Case RedScore = BlueScore : messageText = "Game Imbang!!!"
                    Case RedScore < BlueScore : messageText = "Pemain Biru Menang!!!"
                    Case RedScore > BlueScore : messageText = "Pemain Merah Menang!!!"
                End Select
                Dim result As DialogResult = MessageBox.Show(messageText & vbNewLine & "Mau Main Lagi??", "Dots & Lines", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If result = DialogResult.No Then
                    StillRunning = False
                    Close()
                Else
                    resetscores()
                    clearboard()
                End If
            End If
            System.Windows.Forms.Application.DoEvents()
        End While
    End Sub

    Public Sub logChat2()
        If lstChat2.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf logChat2))
        Else
            Dim newText As String = " >> " + ModuleClient.readData
            'MsgBox(newText)
            Dim broadcast() As String = ModuleClient.readData.Split("|")

            lstChat2.Items.Add(newText)
        End If


    End Sub

    Private Sub btnKirimChat2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKirimChat2.Click
        ModuleClient.sendMessageToServer("CHAT|" + txtInputChat2.Text + "$")
        txtInputChat2.Text = ""
        txtInputChat2.Focus()
    End Sub


    Private Sub txtInputChat2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInputChat2.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnKirimChat2_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub PictureBoxClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub PictureBoxMinimize_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub




End Class
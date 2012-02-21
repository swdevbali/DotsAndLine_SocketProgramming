Imports System.Data.SqlClient

Public Class FormGameDots
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
#Region "Paper Functions"
    Dim ColorOfBlueBox As Brush = Brushes.Blue
    Dim ColorOfRedBox As Brush = Brushes.Red
    Dim ColorOfHightlightedLine As New Pen(Color.LimeGreen, 4)
    Dim ColorOfLine As New Pen(Color.Black, 4)
    Dim ColorOfDot As New Pen(Color.Black, 2.6)
    Dim ScaleWidth As Single
    Dim ScaleHeight As Single
    Dim OffSet As Single = 6
    Public nama_room As String

    Private Sub ClickedOnPaper(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PB_Paper.MouseClick
        ' Was the Left button click?
        If e.Button = Windows.Forms.MouseButtons.Left Then
            For i As Integer = 0 To LineMax
                HLines(i).LineHighlight = False : Vlines(i).LineHighlight = False
            Next
            Dim MouseLocation As New Point(e.Location)
            Dim Cell_X As Single = Math.Floor((MouseLocation.X - OffSet) / ScaleWidth)
            Dim Cell_Y As Single = Math.Floor((MouseLocation.Y - OffSet) / ScaleHeight)
            ' is out of bounds?
            If Cell_X >= (Dots - 1) Or Cell_Y >= (Dots - 1) Then Exit Sub
            ' Where in cell in pointer?
            Dim InCell_X As Single = Math.Floor(((MouseLocation.X - OffSet) Mod ScaleWidth) / (ScaleWidth / 3))
            Dim InCell_Y As Single = Math.Floor(((MouseLocation.Y - OffSet) Mod ScaleHeight) / (ScaleHeight / 3))
            ' Which cell is it?
            Dim Cell_No As Integer = Math.Abs((Cell_Y * (Dots - 1)) + Cell_X)
            Dim CountOfMadeBoxes As Integer = 0
            Dim MoveIsValid As Boolean = False
            Select Case True
                Case (InCell_X = 0) And (InCell_Y = 1) ' Middle Left
                    If (Cells(Cell_No).LineBehind <> Invalid) And (Vlines(Cells(Cell_No).LineBehind).LineUsed = False) Then
                        Vlines(Cells(Cell_No).LineBehind).LineUsed = True
                        MoveIsValid = True
                        DoesItMakeABox(CountOfMadeBoxes, Vlines(Cells(Cell_No).LineBehind).CellAhead)
                        DoesItMakeABox(CountOfMadeBoxes, Vlines(Cells(Cell_No).LineBehind).CellBehind)
                    End If
                Case (InCell_X = 2) And (InCell_Y = 1) ' Middle Right
                    If (Cells(Cell_No).LineAhead <> Invalid) And (Vlines(Cells(Cell_No).LineAhead).LineUsed = False) Then
                        Vlines(Cells(Cell_No).LineAhead).LineUsed = True
                        MoveIsValid = True
                        DoesItMakeABox(CountOfMadeBoxes, Vlines(Cells(Cell_No).LineAhead).CellAhead)
                        DoesItMakeABox(CountOfMadeBoxes, Vlines(Cells(Cell_No).LineAhead).CellBehind)
                    End If
                Case (InCell_Y = 0) And (InCell_X = 1) ' Top Middle
                    If (Cells(Cell_No).LineAbove <> Invalid) And (HLines(Cells(Cell_No).LineAbove).LineUsed = False) Then
                        HLines(Cells(Cell_No).LineAbove).LineUsed = True
                        MoveIsValid = True
                        DoesItMakeABox(CountOfMadeBoxes, HLines(Cells(Cell_No).LineAbove).CellAbove)
                        DoesItMakeABox(CountOfMadeBoxes, HLines(Cells(Cell_No).LineAbove).CellBelow)
                    End If
                Case (InCell_Y = 2) And (InCell_X = 1) ' Bottom Middle
                    If (Cells(Cell_No).LineBelow <> Invalid) And (HLines(Cells(Cell_No).LineBelow).LineUsed = False) Then
                        HLines(Cells(Cell_No).LineBelow).LineUsed = True
                        MoveIsValid = True
                        DoesItMakeABox(CountOfMadeBoxes, HLines(Cells(Cell_No).LineBelow).CellAbove)
                        DoesItMakeABox(CountOfMadeBoxes, HLines(Cells(Cell_No).LineBelow).CellBelow)
                    End If
            End Select
            ' If Move is valid and the current player hasn't made any boxes
            If CountOfMadeBoxes = 0 And MoveIsValid = True Then
                ' Swap Players
                Select Case CurrentPlayer
                    Case Player.Red : CurrentPlayer = Player.Blue
                    Case Player.Blue : CurrentPlayer = Player.Red
                End Select
            End If
            WorkOutScore()
            UpdateTheScores()
        End If

    End Sub


    Private Sub MouseOverPaper(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PB_Paper.MouseMove
        For i As Integer = 0 To LineMax
            HLines(i).LineHighlight = False : Vlines(i).LineHighlight = False
        Next
        Dim MouseLocation As New Point(e.Location)
        Dim Cell_X As Single = Math.Floor((MouseLocation.X - OffSet) / ScaleWidth)
        Dim Cell_Y As Single = Math.Floor((MouseLocation.Y - OffSet) / ScaleHeight)
        ' Out of bounds?
        If Cell_X >= (Dots - 1) Or Cell_Y >= (Dots - 1) Then Exit Sub
        ' Where in cell is pointer?
        Dim InCell_X As Single = Math.Floor(((MouseLocation.X - OffSet) Mod ScaleWidth) / (ScaleWidth / 3))
        Dim InCell_Y As Single = Math.Floor(((MouseLocation.Y - OffSet) Mod ScaleHeight) / (ScaleHeight / 3))
        ' Which cell is it?
        Dim Cell_No As Integer = Math.Abs((Cell_Y * (Dots - 1)) + Cell_X)
        Select Case True
            Case (InCell_X = 0) And (InCell_Y = 1) ' Left Middle
                If (Cells(Cell_No).LineBehind <> Invalid) And (Vlines(Cells(Cell_No).LineBehind).LineUsed = False) Then Vlines(Cells(Cell_No).LineBehind).LineHighlight = True
            Case (InCell_X = 2) And (InCell_Y = 1) ' Right Middle
                If (Cells(Cell_No).LineAhead <> Invalid) And (Vlines(Cells(Cell_No).LineAhead).LineUsed = False) Then Vlines(Cells(Cell_No).LineAhead).LineHighlight = True
            Case (InCell_Y = 0) And (InCell_X = 1) ' Top Middle
                If (Cells(Cell_No).LineAbove <> Invalid) And (HLines(Cells(Cell_No).LineAbove).LineUsed = False) Then HLines(Cells(Cell_No).LineAbove).LineHighlight = True
            Case (InCell_Y = 2) And (InCell_X = 1) ' Bottom Middle
                If (Cells(Cell_No).LineBelow <> Invalid) And (HLines(Cells(Cell_No).LineBelow).LineUsed = False) Then HLines(Cells(Cell_No).LineBelow).LineHighlight = True
        End Select
        '  System.Windows.Forms.Application.DoEvents()

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
        ' Draw Vertical lines
        For i As Integer = 0 To LineMax
            x = i Mod Dots
            y = i \ Dots
            If Vlines(i).LineUsed Then
                g.DrawEllipse(ColorOfLine, OffSet + (ScaleWidth * x), OffSet + (ScaleHeight * y), 0, ScaleHeight)
            ElseIf Vlines(i).LineHighlight Then
                g.DrawEllipse(ColorOfHightlightedLine, OffSet + (ScaleWidth * x), OffSet + (ScaleHeight * y), 0, ScaleHeight)
            End If
        Next
        ' Draw Horizontal Lines
        For i As Integer = 0 To LineMax
            x = i Mod (Dots - 1)
            y = i \ (Dots - 1)
            If HLines(i).LineUsed Then
                g.DrawEllipse(ColorOfLine, OffSet + (ScaleWidth * x), OffSet + (ScaleHeight * y), ScaleWidth, 0)
            ElseIf HLines(i).LineHighlight Then
                g.DrawEllipse(ColorOfHightlightedLine, OffSet + (ScaleWidth * x), OffSet + (ScaleHeight * y), ScaleWidth, 0)
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


    Private Sub RescaleGrid()
        ScaleWidth = (Me.PB_Paper.Width - (OffSet * 2)) / (Dots - 1)
        ScaleHeight = (Me.PB_Paper.Height - (OffSet * 2)) / (Dots - 1)

    End Sub
#End Region

    Private Sub PictureBox2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox2.Paint
        Select Case CurrentPlayer
            Case Player.Red : Me.PictureBox2.BackColor = Color.Red
            Case Player.Blue : Me.PictureBox2.BackColor = Color.Blue
        End Select
    End Sub

    Private Sub FormGameDots_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        instanceFormLobiGame = New FormLobiGame
        instanceFormLobiGame.Show()
    End Sub

    Private Sub FormGameDots_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'GridPlaySize = 0 ' GridCombo.SelectedIndex
        
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

    Private Sub btnInvite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvite.Click
        FormInvitePemain.Show()
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

        ' Add any initialization after the InitializeComponent() call.
        RescaleGrid()

       
    End Sub

    Public Sub init()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim room As String = ""
        Dim sql As String = "SELECT [nama_room] ,[user_pemain],ukuran_papan,jumlah_pemain FROM [adidots].[dbo].[room] where nama_room='PARAM1'"
        sql = sql.Replace("PARAM1", Trim(nama_room))
        con.ConnectionString = "Data Source=" & compName & ";Initial Catalog=adidots;Integrated Security=True"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.CommandText.Trim()
        Dim rd As SqlDataReader = cmd.ExecuteReader()

        rd.Read()
        If rd.HasRows Then
            GridPlaySize = CInt(rd.GetValue(2)) - 4 'karena dari combo box, 0=>4
            lblPemain3.Visible = False
            pbxPemain3.Visible = False
            scorePemain3.Visible = False

            lblPemain4.Visible = False
            pbxPemain4.Visible = False
            scorePemain4.Visible = False


            If rd.GetInt32(3) = 3 Then
                lblPemain3.Visible = True
                pbxPemain3.Visible = True
                scorePemain3.Visible = True
            End If

            If rd.GetInt32(3) = 4 Then
                lblPemain3.Visible = True
                pbxPemain3.Visible = True
                scorePemain3.Visible = True

                lblPemain4.Visible = True
                pbxPemain4.Visible = True
                scorePemain4.Visible = True
            End If

            'NEXT : QUERY DETAIL PAPAN GAME INI
            ModuleClient.sendMessageToServer("QUERY_GAME|" & nama_room)

        End If



        Dots = GridSizes(GridPlaySize)
        RescaleGrid()
        DefineGrid()
        clearboard()
        resetscores()
        Me.Refresh()
        con.Close()

    End Sub

    Private Sub FormGameDots_PaddingChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PaddingChanged

    End Sub
End Class
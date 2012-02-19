Module Gameplay
    Public Const Invalid As Integer = -1
    Public Const DEBUG_ShowLine As Boolean = False
    'Public mMain As FormGameDots
    Public StillRunning As Boolean = True
    Public GameRunning As Boolean = True
    Public Dots As Integer = 25
    Public Cells() As DotsCell
    Public CellMax As Integer
    Public LineMax As Integer
    Public Vlines() As DotVLine
    Public HLines() As DotHLine

    Public GridPlaySize As Integer = 4
    Public GridSizes() As Integer = {4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}
    Public CurrentPlayer As Player = Player.Blue

    Public BlueScore As Integer = 0
    Public RedScore As Integer = 0

    Public Enum Player
        Nobody = 0
        Red = 1
        Blue = 2
    End Enum

    Sub init()
        Dots = GridSizes(GridPlaySize)
        DefineGrid()
        resetscores()
        'mMain = New MainForm

        ' mMain.Show()
        While StillRunning
            If CountEmptyCells() = 0 Then
                GameRunning = False
                Dim messageText As String = ""
                Select Case True
                    Case RedScore = BlueScore : messageText = "Drawn Game"
                    Case RedScore < BlueScore : messageText = "Blue Wins"
                    Case RedScore > BlueScore : messageText = "Red Wins"
                End Select
                Dim result As DialogResult = MessageBox.Show(messageText & vbNewLine & "Play Again?", "Dots & Boxes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If result = DialogResult.No Then
                    StillRunning = False
                Else
                    resetscores()
                    clearboard()
                End If
            End If
            System.Windows.Forms.Application.DoEvents()
        End While

    End Sub
    Public Sub clearboard()
        Dim i As Integer
        For i = 0 To LineMax
            Vlines(i).LineUsed = False : HLines(i).LineUsed = False
        Next
        For i = 0 To CellMax
            Cells(i).CellOwner = Player.Nobody : Cells(i).CellUsed = False
        Next
        CurrentPlayer = Player.Blue
        FormGameDots.Refresh()
    End Sub

    Public Sub resetscores()
        BlueScore = 0
        RedScore = 0
    End Sub

    Public Function HLineUsed(ByRef l As Integer) As Boolean
        If l = Invalid Or l > LineMax Then Return False
        Return HLines(l).LineUsed
    End Function
    Public Function VLineUsed(ByRef l As Integer) As Boolean
        If l = Invalid Or l > LineMax Then Return False
        Return Vlines(l).LineUsed
    End Function

    Public Function CountEmptyCells() As Integer
        CountEmptyCells = 0
        For i As Integer = 0 To CellMax
            If Cells(i).CellUsed = False Then
                CountEmptyCells += 1
            End If
        Next
    End Function
    Public Sub WorkOutScore()
        RedScore = 0
        BlueScore = 0
        For i As Integer = 0 To CellMax
            If Cells(i).CellUsed = True Then
                Select Case Cells(i).CellOwner
                    Case Player.Red : RedScore += 1
                    Case Player.Blue : BlueScore += 1
                End Select
            End If
        Next
    End Sub

    Public Sub DoesItMakeABox(ByRef counter As Integer, ByRef c As Integer)
        If c = Invalid Then Exit Sub
        If Cells(c).CellUsed = True Then Exit Sub
        If Surrounded(c) = True Then
            Cells(c).CellUsed = True
            Cells(c).CellOwner = CurrentPlayer
            counter += 1
        End If
    End Sub

    Public Function Surrounded(ByRef c As Integer) As Boolean
        ' Checks to see if a cell is surround by lines
        ' If it is Return True else Return False
        If c = Invalid Or c > CellMax Then Return False
        If HLineUsed(Cells(c).LineAbove) And HLineUsed(Cells(c).LineBelow) And VLineUsed(Cells(c).LineBehind) And VLineUsed(Cells(c).LineAhead) Then
            If Cells(c).CellUsed = False Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function

    Public Function ThreeSided(ByRef c As Integer) As Boolean
        If c = Invalid Or c > CellMax Then Return False
        Select Case True
            Case HLineUsed(Cells(c).LineAbove) And HLineUsed(Cells(c).LineBelow) And VLineUsed(Cells(c).LineBehind) And VLineUsed(Cells(c).LineAhead) : Return False
            Case HLineUsed(Cells(c).LineAbove) And HLineUsed(Cells(c).LineBelow) And VLineUsed(Cells(c).LineBehind) : Return True
            Case HLineUsed(Cells(c).LineBelow) And VLineUsed(Cells(c).LineBehind) And VLineUsed(Cells(c).LineAhead) : Return True
            Case HLineUsed(Cells(c).LineAbove) And VLineUsed(Cells(c).LineBehind) And VLineUsed(Cells(c).LineAhead) : Return True
            Case HLineUsed(Cells(c).LineAbove) And HLineUsed(Cells(c).LineBelow) And VLineUsed(Cells(c).LineAhead) : Return True
            Case Else : Return False
        End Select
    End Function

    Sub DefineGrid()
        CellMax = (Dots - 1) ^ 2 - 1
        ReDim Cells(CellMax)
        Dim cx As Integer
        Dim cy As Integer
        For i As Integer = 0 To CellMax
            cy = i \ (Dots - 1)
            cx = i Mod (Dots - 1)
            Cells(i) = New DotsCell
            Select Case True
                Case cy = (Dots - 1)
                    Cells(i).LineAbove = i
                    Cells(i).LineBelow = Invalid
                Case Else
                    Cells(i).LineAbove = i
                    Cells(i).LineBelow = i + (Dots - 1)
            End Select
            Select Case True
                Case cx = (Dots - 1)
                    Cells(i).LineAhead = Invalid
                    Cells(i).LineBehind = (cy * (Dots - 0)) + cx
                Case Else
                    Cells(i).LineAhead = (cy * (Dots - 0)) + cx + 1
                    Cells(i).LineBehind = (cy * (Dots - 0)) + cx
            End Select
        Next
        LineMax = (Dots * (Dots - 1)) - 1
        ReDim Vlines(LineMax)
        ReDim HLines(LineMax)
        Dim dx As Integer
        Dim dy As Integer
        For i As Integer = 0 To LineMax
            Vlines(i) = New DotVLine
            cy = i \ (Dots - 1)
            cx = i Mod (Dots - 1)
            dy = i \ (Dots - 0)
            dx = i Mod (Dots - 0)
            With Vlines(i)
                .LineUsed = False
                .LineHighlight = False
                Select Case True
                    Case dx = 0
                        .CellBehind = Invalid
                        .CellAhead = (((Dots - 0) * dy) - dy) + dx
                    Case dx = (Dots - 1)
                        .CellBehind = (((Dots - 0) * dy) - dy) + dx - 1
                        .CellAhead = Invalid
                    Case Else
                        .CellBehind = (((Dots - 0) * dy) - dy) + dx - 1
                        .CellAhead = (((Dots - 0) * dy) - dy) + dx
                End Select
            End With
            HLines(i) = New DotHLine
            With HLines(i)
                .LineUsed = False
                .LineHighlight = False
                Select Case True
                    Case cy = 0
                        .CellAbove = Invalid
                        .CellBelow = cy * (Dots - 1) + cx
                    Case cy = Dots - 1
                        .CellAbove = (cy - 1) * (Dots - 1) + cx
                        .CellBelow = Invalid
                    Case Else
                        .CellAbove = (cy - 1) * (Dots - 1) + cx
                        .CellBelow = cy * (Dots - 1) + cx
                End Select
            End With
            If DEBUG_ShowLine Then Console.WriteLine("i=" & i & " cx=" & cx & " cy=" & cy & " dx=" & dx & " dy=" & dy & " <-" & HLines(i).CellAbove & " ->" & HLines(i).CellBelow)

        Next
    End Sub

End Module

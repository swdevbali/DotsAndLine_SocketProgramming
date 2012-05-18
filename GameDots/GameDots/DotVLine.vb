Public Class DotVLine

    Protected mCellBehind As Integer
    Public Property CellBehind() As Integer
        Get
            Return mCellBehind
        End Get
        Set(ByVal value As Integer)
            mCellBehind = value
        End Set
    End Property
    Protected mCellAhead As Integer
    Public Property CellAhead() As Integer
        Get
            Return mCellAhead
        End Get
        Set(ByVal value As Integer)
            mCellAhead = value
        End Set
    End Property
    Protected mLineUsed As Boolean
    Public Property LineUsed() As Boolean
        Get
            Return mLineUsed
        End Get
        Set(ByVal value As Boolean)
            mLineUsed = value
        End Set
    End Property
    Protected mLineHighlight As Boolean
    Public Property LineHighlight() As Boolean
        Get
            Return mLineHighlight
        End Get
        Set(ByVal value As Boolean)
            mLineHighlight = value
        End Set
    End Property
End Class

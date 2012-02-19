Public Class DotHLine

    Protected mCellBelow As Integer
    Public Property CellBelow() As Integer
        Get
            Return mCellBelow
        End Get
        Set(ByVal value As Integer)
            mCellBelow = value
        End Set
    End Property
    Protected mCellAbove As Integer
    Public Property CellAbove() As Integer
        Get
            Return mCellAbove
        End Get
        Set(ByVal value As Integer)
            mCellAbove = value
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

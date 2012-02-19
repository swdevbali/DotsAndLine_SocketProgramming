Public Class DotsCell

    Protected mCellUsed As Boolean
    Public Property CellUsed() As Boolean
        Get
            Return mCellUsed
        End Get
        Set(ByVal value As Boolean)
            mCellUsed = value
        End Set
    End Property
    Protected mLineAbove As Integer
    Public Property LineAbove() As Integer
        Get
            Return mLineAbove
        End Get
        Set(ByVal value As Integer)
            mLineAbove = value
        End Set
    End Property
    Protected mLineBelow As Integer
    Public Property LineBelow() As Integer
        Get
            Return mLineBelow
        End Get
        Set(ByVal value As Integer)
            mLineBelow = value
        End Set
    End Property
    Protected mLineAhead As Integer
    Public Property LineAhead() As Integer
        Get
            Return mLineAhead
        End Get
        Set(ByVal value As Integer)
            mLineAhead = value
        End Set
    End Property
    Protected mLineBehind As Integer
    Public Property LineBehind() As Integer
        Get
            Return mLineBehind
        End Get
        Set(ByVal value As Integer)
            mLineBehind = value
        End Set
    End Property
    Protected mCellOwner As Integer
    Public Property CellOwner() As Integer
        Get
            Return mCellOwner
        End Get
        Set(ByVal value As Integer)
            mCellOwner = value
        End Set
    End Property

    Public Sub DefineCell(ByVal Above As Integer, ByVal Ahead As Integer, ByVal Below As Integer, ByVal Behind As Integer)
        mCellOwner = -1
        mCellUsed = False
        mLineAbove = Above
        mLineAhead = Ahead
        mLineBelow = Below
        mLineBehind = Behind
    End Sub


End Class

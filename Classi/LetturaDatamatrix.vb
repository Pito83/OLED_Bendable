Public Enum PalletSide
    Sinistro
    Destro
End Enum

<Serializable()>
Public Class LetturaDatamatrix
    Public ReadOnly Property Side As PalletSide
    Public ReadOnly Property Value As String
    Public ReadOnly Property Timestamp As DateTime

    Public Sub New(side As PalletSide, value As String, timestamp As DateTime)
        Me.Side = side
        Me.Value = value
        Me.Timestamp = timestamp
    End Sub
End Class

Public Class DatamatrixRequest
    Public ReadOnly Property Side As PalletSide
    Public ReadOnly Property RequestedAt As DateTime

    Public Sub New(side As PalletSide, requestedAt As DateTime)
        Me.Side = side
        Me.RequestedAt = requestedAt
    End Sub
End Class

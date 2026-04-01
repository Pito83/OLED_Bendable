Imports System.Collections.Generic

Public Class LetturaDatamatrixManager

    Public Event ReadingRequested(ByVal side As PalletSide)
    Public Event ReadingCompleted(ByVal reading As LetturaDatamatrix)

    Private ReadOnly _queue As New Queue(Of DatamatrixRequest)()
    Private _isReading As Boolean = False
    Public ReadOnly Property IsReading As Boolean
        Get
            Return _isReading
        End Get
    End Property
    ' opzionale: ultimo letto per lato
    Public Property LastLeft As LetturaDatamatrix
    Public Property LastRight As LetturaDatamatrix

    Public Sub EnqueueRequest(ByVal side As PalletSide)
        _queue.Enqueue(New DatamatrixRequest(side, DateTime.UtcNow))
        TryStartNext()
    End Sub

    Private Sub TryStartNext()
        If _isReading Then Return
        If _queue.Count = 0 Then Return

        _isReading = True
        Dim req = _queue.Peek()
        RaiseEvent ReadingRequested(req.Side)
    End Sub

    ' Chiamata dal form di lettura quando arriva la stringa dalla pistola
    Public Sub SubmitScan(ByVal scannedText As String)
        If Not _isReading Then
            ' scan arrivato “fuori contesto”: scegli tu se ignorare o gestire diversamente
            Return
        End If

        Dim req = _queue.Dequeue()
        Dim value = If(scannedText, String.Empty).Trim()

        Dim reading = New LetturaDatamatrix(req.Side, value, DateTime.UtcNow)

        If req.Side = PalletSide.Sinistro Then
            LastLeft = reading
        Else
            LastRight = reading
        End If

        _isReading = False
        RaiseEvent ReadingCompleted(reading)

        ' se ci sono altre richieste in coda, parte subito la prossima
        TryStartNext()
    End Sub

    Public Sub CancelCurrent(Optional reason As String = Nothing)
        ' opzionale: svuoti/annulli la richiesta corrente
        If _isReading AndAlso _queue.Count > 0 Then
            _queue.Dequeue()
        End If
        _isReading = False
        TryStartNext()
    End Sub

End Class

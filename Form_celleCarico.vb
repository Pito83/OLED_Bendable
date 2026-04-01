Imports Newtonsoft.Json
Imports ScottPlot

Public Class Form_celleCarico
    Private _refreshOn As Boolean = False

    ' Appoggio (snapshot) aggiornato dal timer UI
    'Private _infosSnap() As InfoPlc
    'Private _lastIndexSnap As UShort
    'Private _lastUpdateDatetime As DateTime
    ' Finestra visibile: mostra punti da ultimoTempo fino a ultimoTempo + X secondi
    'Private _windowSeconds As Double = 10


    'Qui uso SyncLock per evitare che mentre copi
    'Private Sub AggiornaSnapshot()
    '    SyncLock PlcLock
    '        Dim last As Integer = CInt(IndiceUltimoDato)
    '        If last < 0 Then last = 0
    '        If last > INFO_COUNT - 1 Then last = INFO_COUNT - 1

    '        If _infosSnap Is Nothing OrElse _infosSnap.Length <> (last + 1) Then
    '            ReDim _infosSnap(last) ' dimensione = last+1
    '        End If

    '        Array.Copy(Infos, _infosSnap, last + 1)
    '        _lastIndexSnap = CUShort(last)
    '        _lastUpdateDatetime = DateTime.Now
    '    End SyncLock
    'End Sub

    Private Sub Form_celleCarico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Loc_mdi
        N_MDI_from = 83

        PaginaAperta = "CELLE CARICO"
        F_main.Lab_titolo.BackColor = System.Drawing.Color.Pink

        AggiornaSnapshot()
        PopolaGrafico_LastSeconds()
    End Sub

    Private Sub TimerPlot_Tick(sender As Object, e As EventArgs) Handles TimerPlot.Tick
        If Not _refreshOn Then Exit Sub
        AggiornaSnapshot()
        PopolaGrafico_LastSeconds()
    End Sub

    Private Sub PopolaGrafico_LastSeconds()
        If InfosSnap Is Nothing OrElse InfosSnap.Length = 0 Then Return

        Dim lastIdx As Integer = Math.Min(CInt(LastIndexSnap), InfosSnap.Length - 1)
        If lastIdx < 0 Then Return

        Dim xs As New List(Of Double)(lastIdx + 1)
        Dim ys As New List(Of Double)(lastIdx + 1)

        For i As Integer = 0 To lastIdx
            xs.Add(CDbl(InfosSnap(i).Tempo / 1000.0))  ' secondi
            ys.Add(CDbl(InfosSnap(i).Valore / 1000.0)) ' => Kg
        Next

        Dim plt = FormsPlot_CelleCarico.Plot
        plt.Clear()
        plt.Title("DATI CELLA DI CARICO INCOLLAGGIO")

        ' Labels assi con unità
        plt.Axes.Bottom.Label.Text = "Tempo (s)"
        plt.Axes.Left.Label.Text = "Peso (Kg)"

        ' Tick formatter: 2 decimali su Y
        plt.Axes.Left.TickGenerator = New ScottPlot.TickGenerators.NumericAutomatic() With {
        .LabelFormatter = Function(v) v.ToString("0.00")
    }

        ' (opzionale) anche X con 2 decimali, se ti serve
        'plt.Axes.Bottom.TickGenerator = New ScottPlot.TickGenerators.NumericAutomatic() With {
        '    .LabelFormatter = Function(v) v.ToString("0.00")
        '}

        If xs.Count > 0 Then
            Dim sc = plt.Add.Scatter(xs.ToArray(), ys.ToArray())
            sc.LineWidth = 1

            plt.Grid.MajorLineColor = Colors.Green.WithOpacity(0.3)
            plt.Grid.MajorLineWidth = 2
            plt.Grid.MinorLineColor = Colors.Gray.WithOpacity(0.1)
            plt.Grid.MinorLineWidth = 1

            plt.Axes.SetLimitsX(0, WindowSeconds)
            plt.Axes.AutoScaleY()
        End If

        FormsPlot_CelleCarico.Refresh()
    End Sub


    Private Sub TimerUI_Tick(sender As Object, e As EventArgs) Handles TimerUI.Tick
        If _refreshOn Then
            btnRefreshOnOff.Text = "ARRESTA REFRESH"
        Else
            btnRefreshOnOff.Text = "AVVIA REFRESH"
        End If
        lblLastUpdate.Text = LastUpdateDatetime.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub btnRefreshOnOff_Click(sender As Object, e As EventArgs) Handles btnRefreshOnOff.Click
        _refreshOn = Not _refreshOn
        If _refreshOn Then
            ' Aggiorna subito
            AggiornaSnapshot()
            PopolaGrafico_LastSeconds()
        End If
    End Sub

    Private Sub btnSalvaGrafico_Click(sender As Object, e As EventArgs) Handles btnSalvaGrafico.Click
        Try
            _refreshOn = False
            Using sfd As New SaveFileDialog()
                sfd.Title = "Salva dati Cella di Carico"
                sfd.Filter = "JSON (*.json)|*.json|Tutti i file (*.*)|*.*"
                sfd.FileName = $"CelleCarico_{DateTime.Now:yyyyMMdd_HHmmss}.json"
                sfd.OverwritePrompt = True

                If sfd.ShowDialog(Me) <> DialogResult.OK Then Return

                ' Congela un attimo per avere coerenza: aggiorno snapshot e poi salvo quello
                'AggiornaSnapshot()

                Dim dto = BuildSnapshotDto()
                Dim json = JsonConvert.SerializeObject(dto, Formatting.Indented)

                IO.File.WriteAllText(sfd.FileName, json, System.Text.Encoding.UTF8)
            End Using
            _refreshOn = False
        Catch ex As Exception
            MessageBox.Show(Me, "Errore nel salvataggio: " & ex.Message, "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub brnCaricaGrafico_Click(sender As Object, e As EventArgs) Handles brnCaricaGrafico.Click
        Try
            Using ofd As New OpenFileDialog()
                ofd.Title = "Carica dati Cella di Carico"
                ofd.Filter = "JSON (*.json)|*.json|Tutti i file (*.*)|*.*"
                ofd.Multiselect = False

                If ofd.ShowDialog(Me) <> DialogResult.OK Then Return

                Dim json = IO.File.ReadAllText(ofd.FileName, System.Text.Encoding.UTF8)
                Dim dto = JsonConvert.DeserializeObject(Of CelleCaricoSnapshot)(json)

                If dto Is Nothing OrElse dto.Infos Is Nothing OrElse dto.Infos.Length = 0 Then
                    MessageBox.Show(Me, "File non valido o senza dati.", "Caricamento", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Stop refresh e carico in appoggio
                _refreshOn = False
                WindowSeconds = dto.WindowSeconds
                InfosSnap = dto.Infos
                LastIndexSnap = CUShort(Math.Min(CInt(dto.LastIndex), InfosSnap.Length - 1))
                LastUpdateDatetime = dto.SavedAt

                PopolaGrafico_LastSeconds()
            End Using
        Catch ex As Exception
            MessageBox.Show(Me, "Errore nel caricamento: " & ex.Message, "Caricamento", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub btManualTrigger_Click(sender As Object, e As EventArgs) Handles btManualTrigger.Click
        ManualTriggerCella = True
    End Sub
End Class
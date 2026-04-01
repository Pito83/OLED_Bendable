Imports LBSoft.IndustrialCtrls.Leds
Imports System.IO
Imports System.Data

Public Class Form_visione
    Private _sq As Integer = 0
    Private Costruito, _vsx As Boolean
    Private Step_PLC As Integer
    Private _pv As C_TestVis

    Private _simulaPLC As Boolean = False
#Region "form"
    Private Sub Form_visione_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(F_main.Location.X + 30, F_main.Location.Y + 30)
        Me.SuspendLayout()

        '  Combo_vis.Enabled = Not Automatico
        '  If Automatico = False Then

        '  End If
        popola_visione()
        Combo_vis.SelectedIndex = 0 : Step_vis = 1 : PLC_Id_Vis = 1
        'Group_tlc.Location = New Point(2, 35)
        'Group_tlc.Size = New System.Drawing.Size(1264, 805)
        If Log_5 Then
            Tool_test.Enabled = False : ToolStripButton1.Enabled = True : ToolStripButton2.Enabled = True
            L_Sim.Visible = True
        Else
            Tool_test.Enabled = True : ToolStripButton1.Enabled = False : ToolStripButton2.Enabled = False
            L_Sim.Visible = False
        End If
        Me.ResumeLayout()
        Timer1.Enabled = True
        _agg_visione = True
    End Sub
    Private Sub Form_visione_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        If ok_visione = True Then
            Display_visione(Group_tlc)
            Costruito = True
            ' If Automatico = False Then
            Step_vis = Visioni_Attuali(0).VisionStep
            PLC_Id_Vis = 1
            ' file_vis = Work_dir & "\Visione\V" & Format(_indice_vis + 1, "00")
            If ok_visione = True Then
                tlc_set_file(Step_vis, Not Automatico, 1)
            End If
            '  End If
        End If
    End Sub
    Private Sub Form_visione_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            Hide_visione(Group_tlc)
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub

    Private Sub Form_visione_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
#End Region

#Region "Bottoni"
    Private Sub Tool_exit_Click(sender As System.Object, e As System.EventArgs) Handles Tool_exit.Click
        Me.Close()
    End Sub

    Private Sub Tool_test_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_test.Click
        ' If tlc_set_file(file_vis, True, False, _vsx) = True Then
        If Not _simulaPLC Then
            Start_visione()
        Else
            LbLed1.State = LBLed.LedState.Off
            LbLed2.State = LBLed.LedState.Off
            LbLed3.State = LBLed.LedState.Off
            LbLed4.State = LBLed.LedState.Off
            SimulaStep1 = False
            SimulaStep2 = False
            SimulaStep3 = False
            SimulaStep4 = False
            For i = 0 To 3
                Buono_Vis(PLC_Id_Vis - 1, i) = True
            Next
            If ok_visione = True Then
                If (Step_PLC = 1) Then
                    SimulaStep1 = True
                ElseIf (Step_PLC = 2) Then
                    SimulaStep2 = True
                ElseIf (Step_PLC = 3) Then
                    SimulaStep3 = True
                ElseIf (Step_PLC = 4) Then
                    SimulaStep4 = True
                End If

            End If
        End If
    End Sub
    Private Sub Tool_tast_num_Click(sender As System.Object, e As System.EventArgs) Handles Tool_tast_num.Click
        tasti_on()
    End Sub
#End Region




    Private Sub Combo_vis_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Combo_vis.SelectionChangeCommitted
        Dim N As Integer = Combo_vis.SelectedIndex
        Try
            PLC_Id_Vis = N + 1
            Step_vis = Visioni_Attuali(N).VisionStep
            Step_PLC = Visioni_Attuali(N).VisionOrderId
            If ok_visione = True Then
                tlc_set_file(Step_vis, Not Automatico, 1)
            End If
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
    Private Sub Start_visione()
        Dim i As Integer
        Try
            LbLed1.State = LBLed.LedState.Off
            LbLed2.State = LBLed.LedState.Off
            LbLed3.State = LBLed.LedState.Off
            LbLed4.State = LBLed.LedState.Off
            For i = 0 To 3
                Buono_Vis(PLC_Id_Vis - 1, i) = True
            Next
            If ok_visione = True Then
                Exe_Plc_Vis_Step(Step_PLC, DM_Oled)
                '  Ciclo_tlc(PLC_Id_Vis, Step_vis)
            End If
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
    Private Sub Agg_status_vis()
        Try
            '12/1/2026 => usiamo i led per i cumulativi di ognuno dei 4 steps
            'LO SCHIFO: per questioni di bhoooo gli indici delle visioni partono da 1
            Dim buonoStep1 = Buono_Vis(1, 0) And Buono_Vis(1, 1) _
                And Buono_Vis(1, 2) And Buono_Vis(1, 3)

            Dim buonoStep2 = Buono_Vis(2, 0) And Buono_Vis(2, 1) _
                And Buono_Vis(2, 2) And Buono_Vis(2, 3)

            Dim buonoStep3 = Buono_Vis(3, 0) And Buono_Vis(3, 1) _
                And Buono_Vis(3, 2) And Buono_Vis(3, 3)

            Dim buonoStep4 = Buono_Vis(4, 0) And Buono_Vis(4, 1) _
                And Buono_Vis(4, 2) And Buono_Vis(4, 3)

            If buonoStep1 Then 'Buono_Vis(Step_vis, 0) = True Then
                LbLed1.State = LBLed.LedState.On : LbLed1.LedColor = Color.Lime
            Else
                LbLed1.State = LBLed.LedState.Blink : LbLed1.LedColor = Color.Red
            End If
            If buonoStep2 Then 'Buono_Vis(Step_vis, 1) = True Then
                LbLed2.State = LBLed.LedState.On : LbLed2.LedColor = Color.Lime
            Else
                LbLed2.State = LBLed.LedState.Blink : LbLed2.LedColor = Color.Red
            End If
            If buonoStep3 Then 'Buono_Vis(Step_vis, 2) = True Then
                LbLed3.State = LBLed.LedState.On : LbLed3.LedColor = Color.Lime
            Else
                LbLed3.State = LBLed.LedState.Blink : LbLed3.LedColor = Color.Red
            End If
            If buonoStep4 Then 'Buono_Vis(Step_vis, 3) = True Then
                LbLed4.State = LBLed.LedState.On : LbLed4.LedColor = Color.Lime
            Else
                LbLed4.State = LBLed.LedState.Blink : LbLed4.LedColor = Color.Red
            End If
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ' Combo_vis.Enabled = Not Automatico
        Tool_test.Enabled = Not Automatico
        Ck_tlc1.Checked = Run_vis(1) : Ck_tlc2.Checked = Run_vis(2) : Ck_tlc3.Checked = Run_vis(3) : Ck_tlc4.Checked = Run_vis(4)

        If _agg_visione = True Then
            _agg_visione = False
            Agg_status_vis()
        Else
            If _Sim_Vis Then
                L_Sim.Text = _n_Sim.ToString
            End If
        End If
    End Sub





    Private Sub popola_visione()
        Dim i As Integer
        Try
            Combo_vis.Items.Clear()
            For i = 0 To Visioni_Attuali.Count - 1
                Combo_vis.Items.Add(Visioni_Attuali(i).VisionOrderId.ToString("00") & " : " & Visioni_Attuali(i).Name.PadRight(30, " "c) & "     -     " & Visioni_Attuali(i).Description & "  Step-> " & Visioni_Attuali(i).VisionStep.ToString("00"))
            Next
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If Not _pv Is Nothing Then
            _pv.Disponi()
            _pv = Nothing
        End If
    End Sub

    Private Sub chbSimulaPLC_CheckedChanged(sender As Object, e As EventArgs) Handles chbSimulaPLC.CheckedChanged
        _simulaPLC = chbSimulaPLC.Checked
    End Sub

    Private Sub LbLed4_Load(sender As Object, e As EventArgs) Handles LbLed4.Load

    End Sub

    Private Sub Group_tlc_Enter(sender As Object, e As EventArgs) Handles Group_tlc.Enter

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        _pv = New C_TestVis

    End Sub
End Class
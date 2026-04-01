Imports System.IO
Imports System.Threading
Public Class Form_Robot
    Private _ok, _ct1 As Boolean
    Private STW As New BitArray(8)
    Private CTW As New BitArray(8)
    Private C_Tim1 As Integer
#Region "Form"
    Private Sub Form_allarmi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = Loc_mdi
        N_MDI_from = 50
        req_dati = False : req_dati_ready = False
        req_dati2 = False : req_dati_ready2 = False

        PaginaAperta = "ROBOT"
        F_main.Lab_titolo.BackColor = Color.Lime

        L_req_Mano.Text = Modello_Attuale.RobotCode.ToString

        Timer1.Enabled = True : _ok = True
        req_dati = True
    End Sub
    Private Sub Form_Robot_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        req_dati2 = True : req_dati_ready2 = False
    End Sub
    Private Sub Form_allarmi_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        req_dati = False : req_dati_ready = False
        req_dati2 = False : req_dati_ready2 = False
        Timer1.Enabled = False : Timer1.Stop()
    End Sub
    Private Sub Form_allarmi_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

#End Region


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        _ct1 = Not _ct1
        Gr_Repos.Visible = Not Automatico
        Gr_Vuoti.Enabled = Not Automatico And Log_1
        Gr_Punti.Enabled = Log_1
        GR_PA.Enabled = Log_1 : GR_PB.Enabled = Log_1

        B_Depos.Visible = Automatico And Not Ciclo_Run And (Act_M_Robot = 0) 'And 'TODO COMPLETARE Not stati(91)
        B_Prel.Visible = Automatico And Not Ciclo_Run And (Act_M_Robot = 0) 'And 'TODO COMPLETARE Not stati(91)


        If req_dati_ready = True Then
            req_dati_ready = False
            Read_Robot()
        Else
            If Not req_dati Then
                req_dati = True 'req nuova lettura
                Read_Valori()
            End If
        End If
        If req_dati_ready2 Then
            req_dati_ready2 = False
            read_punti()
        End If

        LabelMano.Text = StatiMacchina.ManoDiPresaAttuale
        Try
            Label58.Text = StatiMacchina.RobotDescrizionePosizioneAttuale
            Label59.Text = StatiMacchina.RobotCodicePosizioneAttuale.ToString()
        Catch ex As Exception

        End Try
        If Act_M_Robot > 0 Then
            Lab_Act_M.Text = StatiMacchina.RobotDescrizioneMissioneInCorso
            Lab_Miss.Text = Act_M_Robot.ToString("00")
            Lab_Missione.Visible = Not _ct1
        Else
            Lab_Act_M.Text = StatiMacchina.RobotDescrizioneMissioneInCorso
            Lab_Miss.Text = Act_M_Robot.ToString("00")
            Lab_Missione.Visible = True
        End If

        If StatiMacchina.RobotMissioneHomeInCorso Then
            btnHome.BackColor = Color.Yellow
        Else
            btnHome.BackColor = SystemColors.Control
        End If

        If StatiMacchina.RobotMissionePrelevaSupportoNastroSxInCorso Then
            Sts0.ImageIndex = 0
        Else
            Sts0.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissioneIncollaBiadesivoSuSupportoNastroSxInCorso Then
            Sts1.ImageIndex = 0
        Else
            Sts1.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissioneDepositaPezzoFinitoSuNastroSxInCorso Then
            Sts2.ImageIndex = 0
        Else
            Sts2.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissionePrelevaSupportoNastroDxInCorso Then
            Ctr0.ImageIndex = 0
        Else
            Ctr0.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissioneIncollaBiadesivoSuSupportoNastroDxInCorso Then
            Ctr1.ImageIndex = 0
        Else
            Ctr1.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissioneDepositaPezzoFinitoSuNastroDxInCorso Then
            Ctr2.ImageIndex = 0
        Else
            Ctr2.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissioneDepositaOledInIncollaggioInCorso Then
            Sts3.ImageIndex = 0
        Else
            Sts3.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissioneIncollaSupportoConOledInIncollaggioInCorso Then
            Ctr3.ImageIndex = 0
        Else
            Ctr3.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissionePrelevaOledSxMagazzinoSxInCorso Then
            Sts4.ImageIndex = 0
        Else
            Sts4.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissionePrelevaOledDxMagazzinoSxInCorso Then
            Sts5.ImageIndex = 0
        Else
            Sts5.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissionePrelevaVassoioMagazzinoSxInCorso Then
            Sts6.ImageIndex = 0
        Else
            Sts6.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissionePrelevaOledSxMagazzinoDxInCorso Then
            Ctr4.ImageIndex = 0
        Else
            Ctr4.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissionePrelevaOledDxMagazzinoDxInCorso Then
            Ctr5.ImageIndex = 0
        Else
            Ctr5.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissionePrelevaVassoioMagazzinoDxInCorso Then
            Ctr6.ImageIndex = 0
        Else
            Ctr6.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissioneDepositaVassoioVuotoInCorso Then
            Sts7.ImageIndex = 0
        Else
            Sts7.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissioneDepositaOledScartoPosizione1InCorso Then
            Label2.ImageIndex = 0
        Else
            Label2.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissioneDepositaOledScartoPosizione2InCorso Then
            Label55.ImageIndex = 0
        Else
            Label55.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissioneDepositaOledScartoPosizione3InCorso Then
            Label9.ImageIndex = 0
        Else
            Label9.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissioneDepositaOledScartoPosizione4InCorso Then
            Label56.ImageIndex = 0
        Else
            Label56.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissioneFaiCicloPlasmaturaInCorso Then
            Ctr7.ImageIndex = 0
        Else
            Ctr7.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissioneStrappaLinerInCorso Then
            Label54.ImageIndex = 0
        Else
            Label54.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissioneRaccogliOledScartoDaIncollaggioInCorso Then
            Label57.ImageIndex = 0
        Else
            Label57.ImageIndex = 1
        End If

        If StatiMacchina.RobotMissionVaiZonaCameraInCorso Then
            btnVaiZonaCamera.BackColor = Color.Yellow
        Else
            btnVaiZonaCamera.BackColor = SystemColors.Control
        End If

        If StatiMacchina.RobotMissioneIonizzatoreInCorso Then
            Label51.ImageIndex = 0
        Else
            Label51.ImageIndex = 1
        End If

    End Sub

    Private Function Read_Valori() As Boolean
        Try
            Lab_All.Text = All_Robot.ToString("00")
            If (All_Robot > 0) And (All_Robot < 9) Then
                Lab_Act_aLL.Text = List_Allarmi(All_Robot + 120)
            Else
                Lab_Act_aLL.Text = " *** "
            End If

            If Not T_Overr.OnEdit Then
                T_Overr.Value = CDbl(Override)
            End If

            If BAll_Robot Then
                'Gr_Abort.Visible = True
                If _ct1 Then
                    Lab_Allarmi.BackColor = Color.Yellow
                Else
                    Lab_Allarmi.BackColor = Color.Black
                End If
            Else
                Lab_Allarmi.BackColor = Color.Black
                'Gr_Abort.Visible = False
            End If
            'TODO COMPLETARE
            If StatiMacchina.ManoDiPresaVuotoOn Then
                Lab_Vuoto1.BackColor = Color.Lime
            Else
                Lab_Vuoto1.BackColor = Color.Navy
            End If
            'If stati(30) Then
            '    Lab_Vuoto2.BackColor = Color.Lime
            'Else
            '    Lab_Vuoto2.BackColor = Color.Navy
            'End If

            If StatiMacchina.ManoDiPresaPinzaAperta Then
                Lab_Pinza.BackColor = Color.Lime
            End If
            If StatiMacchina.ManoDiPresaPinzaChiusa Then
                Lab_Pinza.BackColor = Color.Navy
            End If
            If StatiMacchina.ManoDiPresaPinzaAperta And StatiMacchina.ManoDiPresaPinzaChiusa Then
                Lab_Pinza.BackColor = Color.Red
            End If

            If StatiMacchina.IlluminazioneManoDiPresaCalibrazioneAccesa Then
                Lab_Ill1.BackColor = Color.Lime
            Else
                Lab_Ill1.BackColor = Color.Navy
            End If

            If StatiMacchina.IlluminazioneOledAccesa Then
                Lab_Ill2.BackColor = Color.Lime
            Else
                Lab_Ill2.BackColor = Color.Navy
            End If

            If StatiMacchina.ManoDiPresaIndexAvanti Then
                Lab_pl.BackColor = Color.Lime
            End If
            If StatiMacchina.ManoDiPresaIndexIndietro Then
                Lab_pl.BackColor = Color.Navy
            End If
            If StatiMacchina.ManoDiPresaIndexAvanti And StatiMacchina.ManoDiPresaIndexIndietro Then
                Lab_pl.BackColor = Color.Red
            End If



            'StatiMacchina.RobotMissioneIncollaBiadesivoSuSupportoNastroSxInCorso As Boolean
            'StatiMacchina.RobotMissioneDepositaPezzoFinitoSuNastroSxInCorso As Boolean

            'StatiMacchina.RobotMissioneIncollaBiadesivoSuSupportoNastroDxInCorso As Boolean
            'StatiMacchina.RobotMissioneDepositaPezzoFinitoSuNastroDxInCorso As Boolean
            'StatiMacchina.RobotMissioneDepositaOledInIncollaggioInCorso As Boolean
            'StatiMacchina.RobotMissioneIncollaSupportoConOledInIncollaggioInCorso As Boolean



            'StatiMacchina.RobotMissioneIonizzatoreInCorso As Boolean
            'StatiMacchina.RobotMissioneDepositaOledScartoPosizione1InCorso
            'StatiMacchina.RobotMissioneDepositaOledScartoPosizione2InCorso
            'StatiMacchina.RobotMissioneDepositaOledScartoPosizione3InCorso
            'StatiMacchina.RobotMissioneDepositaOledScartoPosizione4InCorso
            'StatiMacchina.RobotMissioneFaiCicloPlasmaturaInCorso As Boolean
            'StatiMacchina.RobotMissioneStrappaLinerInCorso As Boolean
            'StatiMacchina.RobotMissioneRaccogliOledScartoDaIncollaggioInCorso As Boolean


            Dim magA_OLED As Boolean = StatiMacchina.RobotMissionePrelevaOledSxMagazzinoDxInCorso Or StatiMacchina.RobotMissionePrelevaOledDxMagazzinoDxInCorso
            M1a.ImageIndex = CInt(magA_OLED) + 1

            Dim magB_OLED As Boolean = StatiMacchina.RobotMissionePrelevaOledSxMagazzinoSxInCorso Or StatiMacchina.RobotMissionePrelevaOledDxMagazzinoSxInCorso
            M1b.ImageIndex = CInt(magB_OLED) + 1

            M1a_Vass.ImageIndex = CInt(StatiMacchina.RobotMissionePrelevaVassoioMagazzinoSxInCorso) + 1

            M1b_Vass.ImageIndex = CInt(StatiMacchina.RobotMissionePrelevaVassoioMagazzinoDxInCorso) + 1

            M2a_SX.ImageIndex = CInt(StatiMacchina.RobotMissionePrelevaSupportoNastroSxInCorso) + 1
            M2a_DX.ImageIndex = CInt(StatiMacchina.RobotMissionePrelevaSupportoNastroDxInCorso) + 1

            M1_Vass.ImageIndex = (CInt(StatiMacchina.RobotMissioneDepositaVassoioVuotoInCorso) + 1)

            If (Scarto_Visione(1)) Then
                M1s.ImageIndex = 2
            Else
                M1s.ImageIndex = 0
            End If
            If (Scarto_Visione(2)) Then
                M2s.ImageIndex = 2
            Else
                M2s.ImageIndex = 0
            End If
            If (Scarto_Visione(3)) Then
                M3s.ImageIndex = 2
            Else
                M3s.ImageIndex = 0
            End If
            If (Scarto_Visione(4)) Then
                M4s.ImageIndex = 2
            Else
                M4s.ImageIndex = 0
            End If

            If StatiMacchina.RimozioneLinerAbilitata Then
                Label62.ImageIndex = 0
            Else
                Label62.ImageIndex = 1
            End If


            Lt_x.Text = _dx.ToString("0.0")
            Lt_y.Text = _dy.ToString("0.0")
            Lt_a.Text = _da.ToString("0.0")

            Label60.Text = StatiMacchina.RobotDescrizionePresenzaPezzi

        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Function Read_Robot() As Boolean
        Dim _byte(0), _2bytes(1) As Byte

        Try
            'Generate a fake Robot array
            Dim Robot(79) As Byte
            _byte(0) = Robot(32)
            STW = New BitArray(_byte)
            Sts0.ImageIndex = CInt(STW(0)) + 1
            Sts1.ImageIndex = CInt(STW(1)) + 1
            Sts2.ImageIndex = CInt(STW(2)) + 1
            Sts3.ImageIndex = CInt(STW(3)) + 1
            Sts4.ImageIndex = CInt(STW(4)) + 1
            If STW(5) Then
                Sts5.ImageIndex = 2
            Else
                Sts5.ImageIndex = 0
            End If
            Sts6.ImageIndex = CInt(STW(6)) + 1
            Sts7.ImageIndex = CInt(STW(7)) + 1

            _byte(0) = Robot(0)
            CTW = New BitArray(_byte)
            Ctr0.ImageIndex = CInt(CTW(0)) + 1
            Ctr1.ImageIndex = CInt(CTW(1)) + 1
            Ctr2.ImageIndex = CInt(CTW(2)) + 1
            Ctr3.ImageIndex = CInt(CTW(3)) + 1
            Ctr4.ImageIndex = CInt(CTW(4)) + 1
            Ctr5.ImageIndex = CInt(CTW(5)) + 1
            Ctr6.ImageIndex = CInt(CTW(6)) + 1
            Ctr7.ImageIndex = CInt(CTW(7)) + 1

            If Not T_Overr.OnEdit Then
                T_Overr.Value = CDbl(Override)
            End If

        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Function read_punti() As Boolean
        Dim _byte(0), _2bytes(1) As Byte
        Try
            ' PRELIEVO OLED SX MAGAZZINO DX
            PP_ax.Value = CDbl(StatiMacchina.MagazzinoDxOledSx.X) / 1000.0!
            PP_ay.Value = CDbl(StatiMacchina.MagazzinoDxOledSx.Y) / 1000.0!
            PP_az.Value = CDbl(StatiMacchina.MagazzinoDxOledSx.Z) / 1000.0!
            PP_aa.Value = CDbl(StatiMacchina.MagazzinoDxOledSx.RotazioneZ) / 1000.0!

            ' PRELIEVO OLED DX MAGAZZINO DX
            PD_ax.Value = CDbl(StatiMacchina.MagazzinoDxOledDx.X) / 1000.0!
            PD_ay.Value = CDbl(StatiMacchina.MagazzinoDxOledDx.Y) / 1000.0!
            PD_az.Value = CDbl(StatiMacchina.MagazzinoDxOledDx.Z) / 10.0!
            PD_aa.Value = CDbl(StatiMacchina.MagazzinoDxOledDx.RotazioneZ) / 1000.0!

            ' PRELIEVO OLED SX MAGAZZINO SX
            PP_bx.Value = CDbl(StatiMacchina.MagazzinoSxOledSx.X) / 1000.0!
            PP_by.Value = CDbl(StatiMacchina.MagazzinoSxOledSx.Y) / 1000.0!
            PP_bz.Value = CDbl(StatiMacchina.MagazzinoSxOledSx.Z) / 1000.0!
            PP_ba.Value = CDbl(StatiMacchina.MagazzinoSxOledSx.RotazioneZ) / 1000.0!



            'INCOLLAGGIO
            T_xo.Value = CDbl(StatiMacchina.Incollaggio.X) / 1000.0!
            T_yo.Value = CDbl(StatiMacchina.Incollaggio.Y) / 1000.0!
            T_zo.Value = CDbl(StatiMacchina.Incollaggio.Z) / 1000.0!
            T_ao.Value = CDbl(StatiMacchina.Incollaggio.RotazioneZ) / 1000.0!


        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function

    Private Sub T_Overr_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object) Handles T_Overr.Txt_Enter
        If _ok Then
            Num_Dato = CInt(_tag) : WR_Dato_Short = CShort(_val) 'TAG => 1
        End If
    End Sub

    Private Sub T_MgA_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object)
        If _ok Then
            Num_Dato = CInt(_tag) : WR_Dato_32 = CInt(_val)
        End If
    End Sub

    Private Sub T_xo_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object) Handles T_xo.Txt_Enter, T_yo.Txt_Enter, T_zo.Txt_Enter, T_ao.Txt_Enter, T_xs.Txt_Enter, T_ys.Txt_Enter, T_zs.Txt_Enter, T_as.Txt_Enter, T_xa.Txt_Enter, T_ya.Txt_Enter, T_za.Txt_Enter, T_aa.Txt_Enter
        If _ok Then
            Num_Dato = CInt(_tag) : WR_Dato_32 = CInt(_val * 1000.0!) 'tag 320/322/324/326 input mm ma PLC vuole micrometri
        End If
    End Sub

    Private Sub PP_ax_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object) Handles PP_ax.Txt_Enter, PP_ay.Txt_Enter, PP_az.Txt_Enter, PP_aa.Txt_Enter, PD_ax.Txt_Enter, PD_ay.Txt_Enter, PD_az.Txt_Enter, PD_aa.Txt_Enter
        If _ok Then
            Num_Dato = CInt(_tag) : WR_Dato_32 = CInt(_val * 1000.0!) 'tag 272/274/276/278 input mm ma PLC vuole micrometri
            '280/282/284/286
        End If
    End Sub


    Private Sub PP_bx_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object) Handles PP_bx.Txt_Enter, PP_by.Txt_Enter, PP_bz.Txt_Enter, PP_ba.Txt_Enter, PD_bx.Txt_Enter, PD_by.Txt_Enter, PD_bz.Txt_Enter, PD_ba.Txt_Enter
        If _ok Then
            Num_Dato = CInt(_tag) : WR_Dato_32 = CInt(_val * 1000.0!) '288/290/292/294 'PRELIEVO OLED SX MAGAZZINO SX
        End If
    End Sub

    Private Sub LbButton1_Load(sender As Object, e As EventArgs)

    End Sub

#Region "Comandi"

    Private Sub B_v1_On_Click(sender As Object, e As EventArgs) Handles B_v1_On.Click
        Num_Dato = 200
    End Sub
    Private Sub B_v1_Off_Click(sender As Object, e As EventArgs) Handles B_v1_Off.Click
        Num_Dato = 201
    End Sub
    Private Sub B_S1_On_Click(sender As Object, e As EventArgs) Handles B_S1_On.Click
        Num_Dato = 202
    End Sub

    Private Sub B_S1_Off_Click(sender As Object, e As EventArgs) Handles B_S1_Off.Click
        Num_Dato = 203
    End Sub

    Private Sub B_I1on_Click(sender As Object, e As EventArgs) Handles B_I1on.Click
        Num_Dato = 204
    End Sub

    Private Sub B_I1off_Click(sender As Object, e As EventArgs) Handles B_I1off.Click
        Num_Dato = 205
    End Sub

    Private Sub B_I2on_Click(sender As Object, e As EventArgs) Handles B_I2on.Click
        Num_Dato = 206
    End Sub

    Private Sub B_I2off_Click(sender As Object, e As EventArgs) Handles B_I2off.Click, B_Depos.Click
        Num_Dato = 207
    End Sub

    Private Sub B_PL_ch_Click(sender As Object, e As EventArgs) Handles B_PL_ch.Click
        Num_Dato = 208
    End Sub

    Private Sub B_PL_ap_Click(sender As Object, e As EventArgs) Handles B_PL_ap.Click
        Num_Dato = 209
    End Sub

    Private Sub B_Depos_Click(sender As Object, e As EventArgs)
        Num_Dato = 210
    End Sub

    Private Sub B_Prel_Click(sender As Object, e As EventArgs) Handles B_Prel.Click
        Num_Dato = 211
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Num_Dato = 212
    End Sub

    Private Sub Sts0_Click(sender As Object, e As EventArgs) Handles Sts0.Click
        'RobotPrelevaSupportoNastroSx'
        Num_Dato = 220
    End Sub

    Private Sub Sts1_Click(sender As Object, e As EventArgs) Handles Sts1.Click
        'RobotIncollaBiadesivoSuSupportoNastroSx
        Num_Dato = 221
    End Sub

    Private Sub Sts2_Click(sender As Object, e As EventArgs) Handles Sts2.Click
        'RobotDepositaPezzoFinitoSuNastroSx
        Num_Dato = 222
    End Sub

    Private Sub Ctr0_Click(sender As Object, e As EventArgs) Handles Ctr0.Click
        'RobotPrelevaSupportoNastroDx
        Num_Dato = 223
    End Sub

    Private Sub Ctr1_Click(sender As Object, e As EventArgs) Handles Ctr1.Click
        'RobotIncollaBiadesivoSuSupportoNastroDx
        Num_Dato = 224
    End Sub

    Private Sub Ctr2_Click(sender As Object, e As EventArgs) Handles Ctr2.Click
        'RobotDepositaPezzoFinitoSuNastroDx
        Num_Dato = 225
    End Sub

    Private Sub Sts3_Click(sender As Object, e As EventArgs) Handles Sts3.Click
        'RobotDepositaOledInIncollaggio
        Num_Dato = 226
    End Sub

    Private Sub Ctr3_Click(sender As Object, e As EventArgs) Handles Ctr3.Click
        'RobotIncollaSupportoConOledInIncollaggio
        Num_Dato = 227
    End Sub

    Private Sub Sts4_Click(sender As Object, e As EventArgs) Handles Sts4.Click
        'RobotPrelevaOledSxMagazzinoSx
        Num_Dato = 228
    End Sub

    Private Sub Sts5_Click(sender As Object, e As EventArgs) Handles Sts5.Click
        'RobotPrelevaOledDxMagazzinoSx
        Num_Dato = 229
    End Sub

    Private Sub Sts6_Click(sender As Object, e As EventArgs) Handles Sts6.Click
        'RobotPrelevaVassoioMagazzinoSx
        Num_Dato = 230
    End Sub

    Private Sub Ctr4_Click(sender As Object, e As EventArgs) Handles Ctr4.Click
        'RobotPrelevaOledSxMagazzinoDx
        Num_Dato = 231
    End Sub

    Private Sub Ctr5_Click(sender As Object, e As EventArgs) Handles Ctr5.Click
        'RobotPrelevaOledDxMagazzinoDx
        Num_Dato = 232
    End Sub

    Private Sub Ctr6_Click(sender As Object, e As EventArgs) Handles Ctr6.Click
        'RobotPrelevaVassoioMagazzinoDx
        Num_Dato = 233
    End Sub

    Private Sub Sts7_Click(sender As Object, e As EventArgs) Handles Sts7.Click
        'RobotDepositaVassoioVuoto
        Num_Dato = 234
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        'RobotDepositaOledScartoPosizione1
        Num_Dato = 235
    End Sub

    Private Sub Label55_Click(sender As Object, e As EventArgs) Handles Label55.Click
        'RobotDepositaOledScartoPosizione2
        Num_Dato = 236
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        'RobotDepositaOledScartoPosizione3
        Num_Dato = 237
    End Sub

    Private Sub Label56_Click(sender As Object, e As EventArgs) Handles Label56.Click
        'RobotDepositaOledScartoPosizione4
        Num_Dato = 238
    End Sub

    Private Sub Ctr7_Click(sender As Object, e As EventArgs) Handles Ctr7.Click
        'RobotFaiCicloPlasmatura
        Num_Dato = 239
    End Sub

    Private Sub Label54_Click(sender As Object, e As EventArgs) Handles Label54.Click
        'RobotStrappaLiner
        Num_Dato = 240
    End Sub

    Private Sub Label57_Click(sender As Object, e As EventArgs) Handles Label57.Click
        'RobotRaccogliOledScartoDaIncollaggio
        Num_Dato = 241
    End Sub

    Private Sub btnVaiZonaCamera_Click(sender As Object, e As EventArgs) Handles btnVaiZonaCamera.Click
        'RobotVaiZonaCamera
        Num_Dato = 242
    End Sub

    Private Sub Label51_Click(sender As Object, e As EventArgs) Handles Label51.Click
        'RobotVaiInIonizzatura
        Num_Dato = 243
    End Sub

    Private Sub Label62_Click(sender As Object, e As EventArgs) Handles Label62.Click
        'RimozioneLinerAbilitata
        Wr_Bool = Not StatiMacchina.RimozioneLinerAbilitata
        Num_Dato = 244
    End Sub

    Private Sub Butt_Test_P_Click(sender As Object, e As EventArgs)
        Num_Dato = 100
    End Sub
#End Region

End Class
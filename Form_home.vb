Public Class Form_home
    Private _clkt As Integer
    Private _clk As Boolean

#Region "Form"
    Private Sub Form_home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = Loc_mdi
        req_dati = False : req_dati_ready = False
        N_sinitt = 0
        N_MDI_from = 1
        req_dati_ready = False
        PaginaAperta = "HOME"
        F_main.Lab_titolo.BackColor = Color.Green

        If Modello_Attuale IsNot Nothing Then
            L_Modello.Text = Modello_Attuale.Name
            L_Versione.Text = Modello_Attuale.Version
        End If
        If Prodotto_Act IsNot Nothing Then
            L_Prodotto.Text = Prodotto_Act.Name
            L_Descriz.Text = Prodotto_Act.Description
        End If
    End Sub
    Private Sub Form_home_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TimerClk.Enabled = True
        TimerGUI.Enabled = True
        req_dati_ready = False : req_dati = True
    End Sub
    Private Sub Form_home_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        TimerClk.Enabled = False
        TimerGUI.Enabled = False
    End Sub

    Private Sub Form_home_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub Form_home_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

    End Sub
    Private Sub Form_home_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub
#End Region


#Region "Timers"
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerClk.Tick
        _clk = Not _clk

        Act_Valori()

        bResetBuoni.Visible = Log_1 : bResetScarti.Visible = Log_1

    End Sub
    Private Sub Act_Valori()
        Try
            If BAll_Robot Then
                L_All_Rob.Visible = _clk
            Else
                L_All_Rob.Visible = False
            End If
            If StatiMacchina.PlasmaturaAlarm Then
                L_All_Plasmatura.Visible = _clk
            Else
                L_All_Plasmatura.Visible = False
            End If
            If StatiMacchina.MagazzinoAlarm Then
                L_All_Mag.Visible = _clk
            Else
                L_All_Mag.Visible = False
            End If
            If StatiMacchina.AvvitaturaAlarm Then
                L_All_StAvvitatura.Visible = _clk
            Else
                L_All_StAvvitatura.Visible = False
            End If
            If StatiMacchina.PresenzaScarti Then
                Lab_Scarti.Visible = _clk
            Else
                Lab_Scarti.Visible = False
            End If

            L_MA_Fuori.Visible = StatiMacchina.MagazzinoSxFuori
            L_MB_Fuori.Visible = StatiMacchina.MagazzinoDxFuori
            L_MA_Dentro.Visible = StatiMacchina.MagazzinoSxDentro
            L_MB_Dentro.Visible = StatiMacchina.MagazzinoDxDentro

            lblPlasmaturaOn.Visible = StatiMacchina.InternoPlasmaAcceso

            L_Barr.Visible = StatiMacchina.InterventoBarrieraMagazzini

            M1a.ImageIndex = If(DecodificaMissioneRobot() = MissioneRobot.PresaMagazzinoA, 0, 1) 'Se sono in presa magazzino A => VERDE altrimenti GRIGIO
            M1b.ImageIndex = If(DecodificaMissioneRobot() = MissioneRobot.PresaMagazzinoB, 0, 1) 'Se sono in presa magazzino A => VERDE altrimenti GRIGIO
            M2a.ImageIndex = 0
            M2b.ImageIndex = 0
            M1_Vass.ImageIndex = 0

            Pr_StFuoriSx.ImageIndex = (CInt(StatiMacchina.NastroSxPalletAssePosizioneOperatore) + 1)
            Pr_StFuoriDx.ImageIndex = (CInt(StatiMacchina.NastroDxPalletAssePosizioneOperatore) + 1)


            P_PsDx_Oled.ImageIndex = CInt(StatiMacchina.PresenzaOledPosaggioDx) + 1
            P_PsDx_Supp.ImageIndex = CInt(StatiMacchina.PresenzaSupportoPosaggioDx) + 1

            P_PsSx_Oled.ImageIndex = CInt(StatiMacchina.PresenzaOledPosaggioSx) + 1
            P_PsSx_Supp.ImageIndex = CInt(StatiMacchina.PresenzaSupportoPosaggioSx) + 1

            If StatiMacchina.PosaggioDxInCiclo Then
                L_PosaggioDx.Visible = _clk
            Else
                L_PosaggioDx.Visible = True
            End If

            If StatiMacchina.PosaggioSxInCiclo Then
                L_PosaggioSx.Visible = _clk
            Else
                L_PosaggioSx.Visible = True
            End If

            If StatiMacchina.NastroDxInMovimento Then
                LabNDx.Visible = _clk
            Else
                LabNDx.Visible = False
            End If

            If StatiMacchina.AllarmeNastri Then
                lblAllNastri.Visible = _clk
            Else
                lblAllNastri.Visible = False
            End If

            If StatiMacchina.NastroSxInMovimento Then
                LabNSx.Visible = _clk
            Else
                LabNSx.Visible = False
            End If

            If StatiMacchina.PosaggioDxInCiclo Then
                L_PosaggioDx.ImageIndex = 4
            Else
                L_PosaggioDx.ImageIndex = 5
            End If

            Lab_Miss.Text = Act_M_Robot.ToString("00")
            Lab_All.Text = All_Robot.ToString("00")
            If StatiMacchina.PosaggioDxInCiclo Then
                If _clk Then
                    Cyc_Ps_Dx.ImageIndex = 4
                Else
                    Cyc_Ps_Dx.ImageIndex = 1
                End If
            Else
                Cyc_Ps_Dx.ImageIndex = 1
            End If

            If StatiMacchina.PosaggioSxInCiclo Then
                If _clk Then
                    Cyc_Ps_Sx.ImageIndex = 4
                Else
                    Cyc_Ps_Sx.ImageIndex = 1
                End If
            Else
                Cyc_Ps_Sx.ImageIndex = 1
            End If

            If DecodificaMissioneRobot() = MissioneRobot.PresaMagazzinoA Then
                M1s.ImageIndex = 2
            Else
                M1s.ImageIndex = 1
            End If
            If False Then
                M2s.ImageIndex = 2
            Else
                M2s.ImageIndex = 1
            End If
            If False Then
                M1a.ImageIndex = 2
            Else
                M1a.ImageIndex = 1
            End If

            Read_Values()

        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
    Private Function CodificaColoreScarto(tipo As TipoScarto) As Color
        'TODO COMPLETARE
        Select Case (tipo)
            Case TipoScarto.Nessuno
                Return Color.DimGray
            Case TipoScarto.Datamatrix
                Return Color.Red
            Case TipoScarto.Orientamento
                Return Color.Purple
            Case TipoScarto.PreOrientamento
                Return Color.Pink
        End Select
    End Function
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerGUI.Tick
        If req_dati_ready = True Then
            req_dati_ready = False
        End If

        If (StatiMacchina.ScartoInPosizione1Tavolino) Then
            LedScarto1.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.On
            LedScarto1.LedColor = CodificaColoreScarto(StatiMacchina.TipologiaScartoInPosizione1Tavolino)
            Dim magChar As String = CType(IIf(StatiMacchina.MagazzinoDiProvenienzaScartoInPosizione1Tavolino = 1, "A", "B"), String)
            LabScarto1.Text = "Origine Mag: " + magChar
            LabScarto1.Visible = True
            LedScarto1.Visible = True
        Else
            LedScarto1.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off
            LabScarto1.Visible = False
            LedScarto1.Visible = False
        End If

        If (StatiMacchina.ScartoInPosizione2Tavolino) Then
            LedScarto2.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.On
            LedScarto2.LedColor = CodificaColoreScarto(StatiMacchina.TipologiaScartoInPosizione2Tavolino)
            Dim magChar As String = CType(IIf(StatiMacchina.MagazzinoDiProvenienzaScartoInPosizione2Tavolino = 1, "A", "B"), String)
            LabScarto2.Text = "Origine Mag: " + magChar
            LabScarto2.Visible = True
            LedScarto2.Visible = True
        Else
            LedScarto2.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off
            LabScarto2.Visible = False
            LedScarto2.Visible = False
        End If

        If (StatiMacchina.ScartoInPosizione3Tavolino) Then
            LedScarto3.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.On
            LedScarto3.LedColor = CodificaColoreScarto(StatiMacchina.TipologiaScartoInPosizione3Tavolino)
            Dim magChar As String = CType(IIf(StatiMacchina.MagazzinoDiProvenienzaScartoInPosizione3Tavolino = 1, "A", "B"), String)
            LabScarto3.Text = "Origine Mag: " + magChar
            LabScarto3.Visible = True
            LedScarto3.Visible = True
        Else
            LedScarto3.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off
            LabScarto3.Visible = False
            LedScarto3.Visible = False
        End If

        If (StatiMacchina.ScartoInPosizione4Tavolino) Then
            LedScarto4.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.On
            LedScarto4.LedColor = CodificaColoreScarto(StatiMacchina.TipologiaScartoInPosizione4Tavolino)
            Dim magChar As String = CType(IIf(StatiMacchina.MagazzinoDiProvenienzaScartoInPosizione4Tavolino = 1, "A", "B"), String)
            LabScarto4.Text = "Origine Mag: " + magChar
            LabScarto4.Visible = True
            LedScarto4.Visible = True
        Else
            LedScarto4.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off
            LabScarto4.Visible = False
            LedScarto4.Visible = False
        End If

        'ANALOGICI DESTRA
        Lab_Vuo_Frame_Dx.Text = (CDbl(StatiMacchina.VuotoFrameDx) / 1000).ToString("0.000")
        Lab_Vuo_Biade_Dx.Text = (CDbl(StatiMacchina.VuotoBiadesivoDx) / 1000).ToString("0.000")
        Lab_Vuo_Supp_Dx.Text = (CDbl(StatiMacchina.VuotoSupportoDx) / 1000).ToString("0.000")
        Lab_Vuo_Oled_Dx.Text = (CDbl(StatiMacchina.VuotoOledDx) / 1000).ToString("0.000")

        Lab_Vuo_Frame_Sx.Text = (CDbl(StatiMacchina.VuotoFrameSx) / 1000).ToString("0.000")
        Lab_Vuo_Biade_Sx.Text = (CDbl(StatiMacchina.VuotoBiadesivoSx) / 1000).ToString("0.000")
        Lab_Vuo_Supp_Sx.Text = (CDbl(StatiMacchina.VuotoSupportoSx) / 1000).ToString("0.000")
        Lab_Vuo_Oled_Sx.Text = (CDbl(StatiMacchina.VuotoOledSx) / 1000).ToString("0.000")


        'SINISTRO
        If StatiMacchina.NastroSxPalletPompaVuotoFrameVuotoFatto Then
            L_V_Frame_Sx.BackColor = Color.Lime
        Else
            L_V_Frame_Sx.BackColor = Color.Gainsboro
        End If

        If StatiMacchina.NastroSxPalletPompaVuotoSupportoVuotoFatto Then
            L_V_Supp_Sx.BackColor = Color.Lime
        Else
            L_V_Supp_Sx.BackColor = Color.Gainsboro
        End If

        If StatiMacchina.NastroSxPalletPompaVuotoBiadesivoVuotoFatto Then
            L_V_Biade_Sx.BackColor = Color.Lime
        Else
            L_V_Biade_Sx.BackColor = Color.Gainsboro
        End If

        If StatiMacchina.NastroSxPalletPompaVuotoOledVuotoFatto Then
            L_V_Oled_Sx.BackColor = Color.Lime
        Else
            L_V_Oled_Sx.BackColor = Color.Gainsboro
        End If

        'DESTRO
        If StatiMacchina.NastroDxPalletPompaVuotoFrameVuotoFatto Then
            L_V_Frame_Dx.BackColor = Color.Lime
        Else
            L_V_Frame_Dx.BackColor = Color.Gainsboro
        End If

        If StatiMacchina.NastroDxPalletPompaVuotoSupportoVuotoFatto Then
            L_V_Supp_Dx.BackColor = Color.Lime
        Else
            L_V_Supp_Dx.BackColor = Color.Gainsboro
        End If

        If StatiMacchina.NastroDxPalletPompaVuotoBiadesivoVuotoFatto Then
            L_V_Biade_Dx.BackColor = Color.Lime
        Else
            L_V_Biade_Dx.BackColor = Color.Gainsboro
        End If

        If StatiMacchina.NastroDxPalletPompaVuotoOledVuotoFatto Then
            L_V_Oled_Dx.BackColor = Color.Lime
        Else
            L_V_Oled_Dx.BackColor = Color.Gainsboro
        End If

        LabelPresenzaA.Text = StatiMacchina.MagazzinoAPresenzaPezziDescrizione
        LabelPresenzaB.Text = StatiMacchina.MagazzinoBPresenzaPezziDescrizione

        If (StatiMacchina.PresenzaPezzoIncollaggio = 0) Then
            LbLed_OledIncollaggio.LedColor = Color.Gray
        ElseIf (StatiMacchina.PresenzaPezzoIncollaggio = 1) Then
            LbLed_OledIncollaggio.LedColor = Color.Olive
        ElseIf (StatiMacchina.PresenzaPezzoIncollaggio = 2) Then
            LbLed_OledIncollaggio.LedColor = Color.Lime
        ElseIf (StatiMacchina.PresenzaPezzoIncollaggio = 3) Then
            LbLed_OledIncollaggio.LedColor = Color.Red
        End If

        If StatiMacchina.IncollaggioPompaVuotoOledDxFatto Then
            lblVuotoIncollaggioDx.Visible = True
        Else
            lblVuotoIncollaggioDx.Visible = False
        End If

        If StatiMacchina.IncollaggioPompaVuotoOledSxFatto Then
            lblVuotoIncollaggioSx.Visible = True
        Else
            lblVuotoIncollaggioSx.Visible = False
        End If
        lblIncollaggioCodicePosaggio.Text = StatiMacchina.CodicePosaggioIncollaggio.ToString()

        'INCOLLAGGIO E MANO ROBOT VUOTO
        lblIncollaggioPres.Text = (CDbl(StatiMacchina.VuotoIncollaggio) / 1000).ToString("0.000")
        lblManoRobotPress.Text = (CDbl(StatiMacchina.VuotoManoDiPresa) / 1000).ToString("0.000")


        lblLetturaDatamatrixPCB.Enabled = Log_1
        If (StatiMacchina.LetturaDatamatrixPcbAbilitato) Then
            lblLetturaDatamatrixPCB.ImageIndex = 0
        Else
            lblLetturaDatamatrixPCB.ImageIndex = 1
        End If


    End Sub
#End Region

    Private Function Read_Values() As Boolean
        Try
            ContaPezziBuoni.Value = StatiMacchina.ConteggioPezziBuoni
            ContaPezziScarti.Value = StatiMacchina.ConteggioPezziScarti

            L_Cod_Dx.Text = StatiMacchina.MagazzinoDxCodificaAttuale.ToString("00")
            L_Cod_Sx.Text = StatiMacchina.MagazzinoSxCodificaAttuale.ToString("00")
            L_Cod_Sx.Visible = False
            L_Cod_Dx.Visible = False
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function

    Private Sub bResetBuoni_Click(sender As Object, e As EventArgs) Handles bResetBuoni.Click
        Num_Dato = 1
    End Sub

    Private Sub bResetScarti_Click(sender As Object, e As EventArgs) Handles bResetScarti.Click
        Num_Dato = 2
    End Sub

    Private Sub T_Vuoto_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object)
        If _ok Then
            Num_Dato = 10
            Soglia_Vuoto = CSng(_val)
        End If
    End Sub

    Private Sub B_SingleOperator_Click(sender As Object, e As EventArgs) 
        Num_Dato = 3
    End Sub

    Private Sub LabelPresenzaA_Click(sender As Object, e As EventArgs) Handles LabelPresenzaA.Click

    End Sub

    Private Sub btnSXReadReq_Click(sender As Object, e As EventArgs) Handles btnSXReadReq.Click
        ManualSXReadReq = True
    End Sub

    Private Sub btnDXReadReq_Click(sender As Object, e As EventArgs) Handles btnDXReadReq.Click
        ManualDXReadReq = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub LbLed_OledIncollaggio_Load(sender As Object, e As EventArgs) Handles LbLed_OledIncollaggio.Load

    End Sub

    Private Sub L_PosaggioSx_Click(sender As Object, e As EventArgs) Handles L_PosaggioSx.Click

    End Sub

    Private Sub lblLetturaDatamatrixPCB_Click(sender As Object, e As EventArgs) Handles lblLetturaDatamatrixPCB.Click
        Num_Dato = 3
        Wr_Bool = Not StatiMacchina.LetturaDatamatrixPcbAbilitato
    End Sub
End Class
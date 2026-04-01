Imports System.ComponentModel.Design
Imports System.Threading
Public Class Form_manuali
    Private _selecet As Boolean = True
    Private _Clok, _ck1, _mck, Ref_one_time As Boolean
    Private Act_Cod_MA, Act_Cod_MB As Integer
    Private Pr_Cod_MA, Pr_Cod_MB As Integer

#Region "Form"
    Private Sub Form_manuali_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = Loc_mdi
        N_MDI_from = 6
        req_dati = False : req_dati_ready = False
        popola_manuali()

        PaginaAperta = "MANUALI"
        F_main.Lab_titolo.BackColor = Color.Lime
        req_dati = True
    End Sub
    Private Sub Form_manuali_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Timer1.Enabled = True
        Ref_one_time = True
    End Sub
    Private Sub Form_manuali_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Enabled = False
    End Sub
    Private Sub Form_manuali_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
#End Region


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        _ck1 = Not _ck1

        If _ck1 Then
            diplay_val()
        Else
            If Ref_one_time Then
                Ref_one_time = False
                One_Tim_Display()
            Else
                If Not req_dati_ready Then
                    req_dati = True
                End If
            End If
            LI_Cod_A.Text = Sett.CodMag1
            LI_Cod_B.Text = Sett.CodMag2
        End If
        If Automatico Then
            N_MDI_from = 0
            Me.Close()
        Else
            stato_tasti()
            If req_dati_ready = True Then
                req_dati_ready = False
                Agg_valori()
            Else

            End If
        End If

    End Sub
    Private Function stato_tasti() As Boolean
        Dim _en As Boolean
        Try

#Region "GESTIONE BI-BOTTONI"

            btnLuceMagazzinoOff.Visible = StatiMacchina.IlluminazioneMagazzinoAccesa
            btnLuceMagazzinoOn.Visible = Not StatiMacchina.IlluminazioneMagazzinoAccesa

            btnLuceNastriOff.Visible = StatiMacchina.IlluminazioneNastriAccesa
            btnLuceNastriOn.Visible = Not StatiMacchina.IlluminazioneNastriAccesa

            B_MB_F.BackColor = If(StatiMacchina.MagazzinoDxTraslazioneOperatoreRaggiunta, Color.Lime, Color.Gainsboro)
            B_MB_D.BackColor = If(StatiMacchina.MagazzinoDxTraslazioneInternoRaggiunta, Color.Lime, Color.Gainsboro)

            B_Mb_Su.BackColor = If(StatiMacchina.MagazzinoDxAsseVassoiAlzato, Color.Lime, Color.Gainsboro)
            B_Mb_Giu.BackColor = If(StatiMacchina.MagazzinoDxAsseVassoiAbbassato, Color.Lime, Color.Gainsboro)

            B_MA_F.BackColor = If(StatiMacchina.MagazzinoSxTraslazioneOperatoreRaggiunta, Color.Lime, Color.Gainsboro)
            B_MA_D.BackColor = If(StatiMacchina.MagazzinoSxTraslazioneInternoRaggiunta, Color.Lime, Color.Gainsboro)

            B_Ma_Su.BackColor = If(StatiMacchina.MagazzinoSxAsseVassoiAlzato, Color.Lime, Color.Gainsboro)
            B_Ma_Giu.BackColor = If(StatiMacchina.MagazzinoSxAsseVassoiAbbassato, Color.Lime, Color.Gainsboro)

            btnLuceIncollaggio1On.Visible = Not StatiMacchina.IlluminazioneIncollaggio1Accesa
            btnLuceIncollaggio1Off.Visible = StatiMacchina.IlluminazioneIncollaggio1Accesa

            btnLuceIncollaggio2On.Visible = Not StatiMacchina.IlluminazioneIncollaggio2Accesa
            btnLuceIncollaggio2Off.Visible = StatiMacchina.IlluminazioneIncollaggio2Accesa


            btnSxSingolarizzatoreExtAbbassa.BackColor = If(statiMacchina.NastroSxSingolarizzatoreEsternoAbbassato, Color.Lime, Color.Gainsboro)
            btnSxSingolarizzatoreExtRitorna.BackColor = If(statiMacchina.NastroSxSingolarizzatoreEsternoRitornato, Color.Lime, Color.Gainsboro)
            btnSxSingolarizzatoreIntAbbassa.BackColor = If(statiMacchina.NastroSxSingolarizzatoreInternoAbbassato, Color.Lime, Color.Gainsboro)
            btnSxSingolarizzatoreIntRitorna.BackColor = If(statiMacchina.NastroSxSingolarizzatoreInternoRitornato, Color.Lime, Color.Gainsboro)
            btnSxSollevatoreLatoRobotAlza.BackColor = If(statiMacchina.NastroSxSollevatoreLatoRobotAlzato, Color.Lime, Color.Gainsboro)
            btnSxSollevatoreLatoRobotAbbassa.BackColor = If(statiMacchina.NastroSxSollevatoreLatoRobotAbbassato, Color.Lime, Color.Gainsboro)
            btnSxPalletSvincoloOLEDSvincola.BackColor = If(statiMacchina.NastroSxPalletSvincoloOledSvincolato, Color.Lime, Color.Gainsboro)
            btnSxPalletSvincoloOLEDRilascia.BackColor = If(statiMacchina.NastroSxPalletSvincoloOledRilasciato, Color.Lime, Color.Gainsboro)
            btnSxPompaVuotoFrameOn.BackColor = If(statiMacchina.NastroSxPalletPompaVuotoFrameVuotoFatto, Color.Lime, Color.Gainsboro)
            btnSxPompaVuotoFrameOff.BackColor = If(statiMacchina.NastroSxPalletPompaVuotoFrameRilasciato, Color.Lime, Color.Gainsboro)
            btnSxPompaVuotoOledOn.BackColor = If(statiMacchina.NastroSxPalletPompaVuotoOledSupportoVuotoFatto, Color.Lime, Color.Gainsboro)
            btnSxPompaVuotoOledOff.BackColor = If(statiMacchina.NastroSxPalletPompaVuotoOledSupportoRilasciato, Color.Lime, Color.Gainsboro)
            btnSxPompaVuotoSupportoOn.BackColor = If(statiMacchina.NastroSxPalletPompaVuotoSupportoVuotoFatto, Color.Lime, Color.Gainsboro)
            btnSxPompaVuotoSupportoOff.BackColor = If(statiMacchina.NastroSxPalletPompaVuotoSupportoRilasciato, Color.Lime, Color.Gainsboro)
            btnSxPompaVuotoBiadesivoOn.BackColor = If(statiMacchina.NastroSxPalletPompaVuotoBiadesivoVuotoFatto, Color.Lime, Color.Gainsboro)
            btnSxPompaVuotoBiadesivoOff.BackColor = If(statiMacchina.NastroSxPalletPompaVuotoBiadesivoRilasciato, Color.Lime, Color.Gainsboro)
            btnSxPalletAvanzaVersoInterno.BackColor = If(statiMacchina.NastroSxPalletAssePosizioneInterno, Color.Lime, Color.Gainsboro)
            btnSxPalletAvanzaVersoOperatore.BackColor = If(statiMacchina.NastroSxPalletAssePosizioneOperatore, Color.Lime, Color.Gainsboro)

            btnDxSingolarizzatoreExtAbbassa.BackColor = If(statiMacchina.NastroDxSingolarizzatoreEsternoAbbassato, Color.Lime, Color.Gainsboro)
            btnDxSingolarizzatoreExtRitorna.BackColor = If(statiMacchina.NastroDxSingolarizzatoreEsternoRitornato, Color.Lime, Color.Gainsboro)
            btnDxSingolarizzatoreIntAbbassa.BackColor = If(statiMacchina.NastroDxSingolarizzatoreInternoAbbassato, Color.Lime, Color.Gainsboro)
            btnDxSingolarizzatoreIntRitorna.BackColor = If(statiMacchina.NastroDxSingolarizzatoreInternoRitornato, Color.Lime, Color.Gainsboro)
            btnDxSollevatoreLatoRobotAlza.BackColor = If(statiMacchina.NastroDxSollevatoreLatoRobotAlzato, Color.Lime, Color.Gainsboro)
            btnDxSollevatoreLatoRobotAbbassa.BackColor = If(statiMacchina.NastroDxSollevatoreLatoRobotAbbassato, Color.Lime, Color.Gainsboro)
            btnDxPalletSvincoloOLEDSvincola.BackColor = If(statiMacchina.NastroDxPalletSvincoloOledSvincolato, Color.Lime, Color.Gainsboro)
            btnDxPalletSvincoloOLEDRilascia.BackColor = If(statiMacchina.NastroDxPalletSvincoloOledRilasciato, Color.Lime, Color.Gainsboro)
            btnDxPompaVuotoFrameOn.BackColor = If(statiMacchina.NastroDxPalletPompaVuotoFrameVuotoFatto, Color.Lime, Color.Gainsboro)
            btnDxPompaVuotoFrameOff.BackColor = If(statiMacchina.NastroDxPalletPompaVuotoFrameRilasciato, Color.Lime, Color.Gainsboro)
            btnDxPompaVuotoOledOn.BackColor = If(statiMacchina.NastroDxPalletPompaVuotoOledSupportoVuotoFatto, Color.Lime, Color.Gainsboro)
            btnDxPompaVuotoOledOff.BackColor = If(statiMacchina.NastroDxPalletPompaVuotoOledSupportoRilasciato, Color.Lime, Color.Gainsboro)
            btnDxPompaVuotoSupportoOn.BackColor = If(statiMacchina.NastroDxPalletPompaVuotoSupportoVuotoFatto, Color.Lime, Color.Gainsboro)
            btnDxPompaVuotoSupportoOff.BackColor = If(statiMacchina.NastroDxPalletPompaVuotoSupportoRilasciato, Color.Lime, Color.Gainsboro)
            btnDxPompaVuotoBiadesivoOn.BackColor = If(statiMacchina.NastroDxPalletPompaVuotoBiadesivoVuotoFatto, Color.Lime, Color.Gainsboro)
            btnDxPompaVuotoBiadesivoOff.BackColor = If(statiMacchina.NastroDxPalletPompaVuotoBiadesivoRilasciato, Color.Lime, Color.Gainsboro)
            btnDxPalletAvanzaVersoInterno.BackColor = If(statiMacchina.NastroDxPalletAssePosizioneInterno, Color.Lime, Color.Gainsboro)
            btnDxPalletAvanzaVersoOperatore.BackColor = If(statiMacchina.NastroDxPalletAssePosizioneOperatore, Color.Lime, Color.Gainsboro)

            btnPurificatoreAriaOn.BackColor = If(statiMacchina.InternoPurificatoreAriaAcceso, Color.Lime, Color.Gainsboro)
            btnPurificatoreAriaOff.BackColor = If(statiMacchina.InternoPurificatoreAriaSpento, Color.Lime, Color.Gainsboro)
            btnAspiratoreLinerOn.BackColor = If(statiMacchina.InternoAspiratoreLinerAcceso, Color.Lime, Color.Gainsboro)
            btnAspiratoreLinerOff.BackColor = If(statiMacchina.InternoAspiratoreLinerSpento, Color.Lime, Color.Gainsboro)

            btnInternoPlasmaOn.BackColor = If(statiMacchina.InternoPlasmaAcceso, Color.Lime, Color.Gainsboro)
            btnInternoPlasmaOff.BackColor = If(statiMacchina.InternoPlasmaSpento, Color.Lime, Color.Gainsboro)

            btnIncollaggioSxVuotoOn.BackColor = If(StatiMacchina.IncollaggioPompaVuotoOledSxFatto, Color.Lime, Color.Gainsboro)
            btnIncollaggioSxVuotoOff.BackColor = If(StatiMacchina.IncollaggioPompaVuotoOledSxRilasciato, Color.Lime, Color.Gainsboro)
            btnIncollaggioDxVuotoOn.BackColor = If(StatiMacchina.IncollaggioPompaVuotoOledDxFatto, Color.Lime, Color.Gainsboro)
            btnIncollaggioDxVuotoOff.BackColor = If(StatiMacchina.IncollaggioPompaVuotoOledDxRilasciato, Color.Lime, Color.Gainsboro)
#End Region

        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function


    Private Sub diplay_val()
        Try
            Act_Cod_MA = StatiMacchina.MagazzinoDxCodificaAttuale : Act_Cod_MB = StatiMacchina.MagazzinoSxCodificaAttuale

            L_Cod_A.Text = Act_Cod_MA.ToString("00") : L_Cod_B.Text = Act_Cod_MB.ToString("00")

        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
    Private Sub One_Tim_Display()


    End Sub
#Region "Comandi"


    Private Sub B_Simul_Click(sender As Object, e As EventArgs)
        Simula = Not Simula
        Wr_Bool = True
    End Sub


    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub B_Esc_Avvita_Click(sender As Object, e As EventArgs)
        Escl_Avvita = Not Escl_Avvita
        If Escl_Avvita Then
            Simula = True
        End If
        Wr_Bool = True
    End Sub

    Private Sub btnLuceMagazzinoOn_Click(sender As Object, e As EventArgs) Handles btnLuceMagazzinoOn.Click
        Num_Dato = 58
    End Sub
    Private Sub btnLuceMagazzinoOff_Click(sender As Object, e As EventArgs) Handles btnLuceMagazzinoOff.Click
        Num_Dato = 1
    End Sub

    Private Sub btnLuceNastriOn_Click(sender As Object, e As EventArgs) Handles btnLuceNastriOn.Click
        Num_Dato = 2
    End Sub

    Private Sub btnLuceNastriOff_Click(sender As Object, e As EventArgs) Handles btnLuceNastriOff.Click
        Num_Dato = 3
    End Sub

    Private Sub B_MB_F_Click(sender As Object, e As EventArgs) Handles B_MB_F.Click
        Num_Dato = 4
    End Sub

    Private Sub B_MB_D_Click(sender As Object, e As EventArgs) Handles B_MB_D.Click
        Num_Dato = 5
    End Sub

    Private Sub B_Mb_Su_Click(sender As Object, e As EventArgs) Handles B_Mb_Su.Click
        Num_Dato = 6
    End Sub

    Private Sub B_Mb_Giu_Click(sender As Object, e As EventArgs) Handles B_Mb_Giu.Click
        Num_Dato = 7
    End Sub

    Private Sub B_MA_F_Click(sender As Object, e As EventArgs) Handles B_MA_F.Click
        Num_Dato = 8
    End Sub

    Private Sub B_MA_D_Click(sender As Object, e As EventArgs) Handles B_MA_D.Click
        Num_Dato = 9
    End Sub

    Private Sub B_Ma_Su_Click(sender As Object, e As EventArgs) Handles B_Ma_Su.Click
        Num_Dato = 10
    End Sub

    Private Sub B_Ma_Giu_Click(sender As Object, e As EventArgs) Handles B_Ma_Giu.Click
        Num_Dato = 11
    End Sub

    Private Sub btnLuceIncollaggio1On_Click(sender As Object, e As EventArgs) Handles btnLuceIncollaggio1On.Click
        Num_Dato = 12
    End Sub

    Private Sub btnLuceIncollaggio1Off_Click(sender As Object, e As EventArgs) Handles btnLuceIncollaggio1Off.Click
        Num_Dato = 13
    End Sub

    Private Sub btnLuceIncollaggio2On_Click(sender As Object, e As EventArgs) Handles btnLuceIncollaggio2On.Click
        Num_Dato = 14
    End Sub

    Private Sub btnLuceIncollaggio2Off_Click(sender As Object, e As EventArgs) Handles btnLuceIncollaggio2Off.Click
        Num_Dato = 15
    End Sub

    Private Sub btnSxPompaVuotoFrameOn_Click(sender As Object, e As EventArgs) Handles btnSxPompaVuotoFrameOn.Click
        Num_Dato = 16
    End Sub

    Private Sub btnSxPompaVuotoFrameOff_Click(sender As Object, e As EventArgs) Handles btnSxPompaVuotoFrameOff.Click
        Num_Dato = 17
    End Sub

    Private Sub btnSxPompaVuotoSupportoOn_Click(sender As Object, e As EventArgs) Handles btnSxPompaVuotoSupportoOn.Click
        Num_Dato = 18
    End Sub

    Private Sub btnSxPompaVuotoSupportoOff_Click(sender As Object, e As EventArgs) Handles btnSxPompaVuotoSupportoOff.Click
        Num_Dato = 19
    End Sub
    Private Sub btnSxPompaVuotoBiadesivoOn_Click(sender As Object, e As EventArgs) Handles btnSxPompaVuotoBiadesivoOn.Click
        Num_Dato = 20
    End Sub

    Private Sub btnSxPompaVuotoBiadesivoOff_Click(sender As Object, e As EventArgs) Handles btnSxPompaVuotoBiadesivoOff.Click
        Num_Dato = 21
    End Sub

    Private Sub btnSxSollevatoreLatoRobotAlza_Click(sender As Object, e As EventArgs) Handles btnSxSollevatoreLatoRobotAlza.Click
        Num_Dato = 22
    End Sub

    Private Sub btnSxSollevatoreLatoRobotAbbassa_Click(sender As Object, e As EventArgs) Handles btnSxSollevatoreLatoRobotAbbassa.Click
        Num_Dato = 23
    End Sub

    Private Sub btnSxSingolarizzatoreExtAbbassa_Click(sender As Object, e As EventArgs) Handles btnSxSingolarizzatoreExtAbbassa.Click
        Num_Dato = 24
    End Sub

    Private Sub btnSxSingolarizzatoreExtRitorna_Click(sender As Object, e As EventArgs) Handles btnSxSingolarizzatoreExtRitorna.Click
        Num_Dato = 25
    End Sub

    Private Sub btnSxSingolarizzatoreIntAbbassa_Click(sender As Object, e As EventArgs) Handles btnSxSingolarizzatoreIntAbbassa.Click
        Num_Dato = 26
    End Sub

    Private Sub btnSxSingolarizzatoreIntRitorna_Click(sender As Object, e As EventArgs) Handles btnSxSingolarizzatoreIntRitorna.Click
        Num_Dato = 27
    End Sub

    Private Sub btnSxPalletSvincoloOLEDSvincola_Click(sender As Object, e As EventArgs) Handles btnSxPalletSvincoloOLEDSvincola.Click
        Num_Dato = 28
    End Sub

    Private Sub btnSxPalletSvincoloOLEDRilascia_Click(sender As Object, e As EventArgs) Handles btnSxPalletSvincoloOLEDRilascia.Click
        Num_Dato = 29
    End Sub

    Private Sub btnSxPompaVuotoOledOn_Click(sender As Object, e As EventArgs) Handles btnSxPompaVuotoOledOn.Click
        Num_Dato = 30
    End Sub

    Private Sub btnSxPompaVuotoOledOff_Click(sender As Object, e As EventArgs) Handles btnSxPompaVuotoOledOff.Click
        Num_Dato = 31
    End Sub

    Private Sub btnSxPalletAvanzaVersoInterno_Click(sender As Object, e As EventArgs) Handles btnSxPalletAvanzaVersoInterno.Click
        Num_Dato = 32
    End Sub

    Private Sub btnSxPalletAvanzaVersoOperatore_Click(sender As Object, e As EventArgs) Handles btnSxPalletAvanzaVersoOperatore.Click
        Num_Dato = 33
    End Sub

    Private Sub btnDxSollevatoreLatoRobotAbbassa_Click(sender As Object, e As EventArgs) Handles btnDxSollevatoreLatoRobotAbbassa.Click
        Num_Dato = 34
    End Sub

    Private Sub btnDxSollevatoreLatoRobotAlza_Click(sender As Object, e As EventArgs) Handles btnDxSollevatoreLatoRobotAlza.Click
        Num_Dato = 35
    End Sub

    Private Sub btnDxPompaVuotoFrameOn_Click(sender As Object, e As EventArgs) Handles btnDxPompaVuotoFrameOn.Click
        Num_Dato = 36
    End Sub

    Private Sub btnDxPompaVuotoFrameOff_Click(sender As Object, e As EventArgs) Handles btnDxPompaVuotoFrameOff.Click
        Num_Dato = 37
    End Sub

    Private Sub btnDxPompaVuotoSupportoOn_Click(sender As Object, e As EventArgs) Handles btnDxPompaVuotoSupportoOn.Click
        Num_Dato = 38
    End Sub

    Private Sub btnDxPompaVuotoSupportoOff_Click(sender As Object, e As EventArgs) Handles btnDxPompaVuotoSupportoOff.Click
        Num_Dato = 39
    End Sub

    Private Sub btnDxPompaVuotoBiadesivoOn_Click(sender As Object, e As EventArgs) Handles btnDxPompaVuotoBiadesivoOn.Click
        Num_Dato = 40
    End Sub

    Private Sub btnDxPompaVuotoBiadesivoOff_Click(sender As Object, e As EventArgs) Handles btnDxPompaVuotoBiadesivoOff.Click
        Num_Dato = 41
    End Sub

    Private Sub btnDxPompaVuotoOledOn_Click(sender As Object, e As EventArgs) Handles btnDxPompaVuotoOledOn.Click
        Num_Dato = 42
    End Sub

    Private Sub btnDxPompaVuotoOledOff_Click(sender As Object, e As EventArgs) Handles btnDxPompaVuotoOledOff.Click
        Num_Dato = 43
    End Sub

    Private Sub btnDxSingolarizzatoreIntAbbassa_Click(sender As Object, e As EventArgs) Handles btnDxSingolarizzatoreIntAbbassa.Click
        Num_Dato = 44
    End Sub

    Private Sub btnDxSingolarizzatoreIntRitorna_Click(sender As Object, e As EventArgs) Handles btnDxSingolarizzatoreIntRitorna.Click
        Num_Dato = 45
    End Sub

    Private Sub btnDxSingolarizzatoreExtAbbassa_Click(sender As Object, e As EventArgs) Handles btnDxSingolarizzatoreExtAbbassa.Click
        Num_Dato = 46
    End Sub

    Private Sub btnDxSingolarizzatoreExtRitorna_Click(sender As Object, e As EventArgs) Handles btnDxSingolarizzatoreExtRitorna.Click
        Num_Dato = 47
    End Sub

    Private Sub btnDxPalletSvincoloOLEDSvincola_Click(sender As Object, e As EventArgs) Handles btnDxPalletSvincoloOLEDSvincola.Click
        Num_Dato = 48
    End Sub

    Private Sub btnDxPalletSvincoloOLEDRilascia_Click(sender As Object, e As EventArgs) Handles btnDxPalletSvincoloOLEDRilascia.Click
        Num_Dato = 49
    End Sub

    Private Sub btnDxPalletAvanzaVersoInterno_Click(sender As Object, e As EventArgs) Handles btnDxPalletAvanzaVersoInterno.Click
        Num_Dato = 50
    End Sub

    Private Sub btnDxPalletAvanzaVersoOperatore_Click(sender As Object, e As EventArgs) Handles btnDxPalletAvanzaVersoOperatore.Click
        Num_Dato = 51
    End Sub

    Private Sub btnPurificatoreAriaOn_Click(sender As Object, e As EventArgs) Handles btnPurificatoreAriaOn.Click
        Num_Dato = 52
    End Sub

    Private Sub btnPurificatoreAraOff_Click(sender As Object, e As EventArgs) Handles btnPurificatoreAriaOff.Click, btnPurificatoreAriaOff.Click
        Num_Dato = 53
    End Sub

    Private Sub btnAspiratoreLinerOn_Click(sender As Object, e As EventArgs) Handles btnAspiratoreLinerOn.Click
        Num_Dato = 54
    End Sub

    Private Sub btnIncollaggioSxVuotoOn_Click(sender As Object, e As EventArgs) Handles btnIncollaggioSxVuotoOn.Click
        Num_Dato = 83
    End Sub

    Private Sub btnIncollaggioSxVuotoOff_Click(sender As Object, e As EventArgs) Handles btnIncollaggioSxVuotoOff.Click
        Num_Dato = 84
    End Sub

    Private Sub btnIncollaggioDxVuotoOn_Click(sender As Object, e As EventArgs) Handles btnIncollaggioDxVuotoOn.Click
        Num_Dato = 85
    End Sub

    Private Sub btnIncollaggioDxVuotoOff_Click(sender As Object, e As EventArgs) Handles btnIncollaggioDxVuotoOff.Click
        Num_Dato = 86
    End Sub

    Private Sub btnInternoSoffioOn_Click(sender As Object, e As EventArgs) Handles btnInternoSoffioOn.Click
        Num_Dato = 93
    End Sub

    Private Sub btnInternoSoffioOff_Click(sender As Object, e As EventArgs) Handles btnInternoSoffioOff.Click
        Num_Dato = 94
    End Sub

    Private Sub brnStrappoLinerApri_Click(sender As Object, e As EventArgs) Handles brnStrappoLinerApri.Click
        Num_Dato = 95
    End Sub

    Private Sub btnStrappoLinerChiudi_Click(sender As Object, e As EventArgs) Handles btnStrappoLinerChiudi.Click
        Num_Dato = 96
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub btnAspiratoreLinerOff_Click(sender As Object, e As EventArgs) Handles btnAspiratoreLinerOff.Click
        Num_Dato = 55
    End Sub

    Private Sub btnInternoPlasmaOn_Click(sender As Object, e As EventArgs) Handles btnInternoPlasmaOn.Click
        Num_Dato = 56
    End Sub

    Private Sub btnInternoPlasmaOff_Click(sender As Object, e As EventArgs) Handles btnInternoPlasmaOff.Click
        Num_Dato = 57
    End Sub
#End Region

    Private Sub Agg_valori()

        Try
            Pr_Cod_MA = 666 : Pr_Cod_MB = 667
            If Act_Cod_MA = Pr_Cod_MA Then
                L_Cod_A.BackColor = Color.LightGray
            Else
                L_Cod_A.BackColor = Color.Red
            End If
            If Act_Cod_MB = Pr_Cod_MB Then
                L_Cod_B.BackColor = Color.LightGray
            Else
                L_Cod_B.BackColor = Color.Red
            End If
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
    Private Sub popola_manuali()
        Try



        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub




End Class
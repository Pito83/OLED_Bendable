Imports System.Data
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Security
Imports System.Text
Imports System.Threading
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.IdentityModel.Protocols
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Oled.DataLayer
Imports ScottPlot.Colormaps


Public Class F_main
    Private F_visione, _mdi_form As Form
    Private Plc1, Plc2 As C_IBH
    Private _clk, _spare, _err1, _err2, Spegni As Boolean
    Private _tread1, _tread2 As Thread
    Friend _thini As Thread
    Private _tt, _ttt, _ttt2 As Long
    Private status_change, Mem_status As ULong
    'Private Buono As New BitArray(16, False)
    Private C_Timer1 As Integer
    Private _fatto_mc, _fare_mc, _Togg_30_sec As Boolean
    Private banner As New Process()
    Private Max_Gap, Max_Gap_m, _m_Autom, _m_init As Boolean
    Private Esiti_Verrou(109) As Boolean
    Private Fine_cyc_sx, Fine_Cyc_Dx, Fine_Cyc_Totale, CycOn_Dato, Repos, _M_Trace_Oled As Boolean

    Private processoEsterno As Process = Nothing
    Private _DB100_Length As Integer = 657
    Private _DB110_Length As Integer = 801
    Private _memRichiestaLetturaDatamatrixPalletSx As Boolean = False
    Private _memRichiestaLetturaDatamatrixPalletDx As Boolean = False

    Private _inviaDMAlPLCPalletSx As Boolean = False
    Private _inviaDMAlPLCPalletDx As Boolean = False

    Private _datiCellaDiCaricoPronti_Mem As Boolean = False
    Private _mostramelo As Boolean = False

    Private _mostramiSinottico As Boolean = False
    Private _ultimaDirezioneDelSinottico As PalletSide

    Friend Pulsantoso As Boolean

    Private Sub OnReadingRequested(ByVal side As PalletSide)

        _mostramiSinottico = True
        _ultimaDirezioneDelSinottico = side
    End Sub
    Private Sub OnReadingCompleted(ByVal reading As LetturaDatamatrix)
        ' chiudi o lascia aperto il form (io lascerei aperto e solo aggiorno label)
        ' se vuoi chiuderlo quando non ci sono più richieste:
        ' If DatamatrixMgr.HasPendingRequests = False Then _formCiccio.Hide()

        ' Qui notifichi PLC / log / DB / ecc.
        ' reading.Side -> sai se DX o SX
        ' reading.Value -> datamatrix
        ' reading.Timestamp -> timestamp UTC
        AggiornaPlcConDatamatrix(reading)

    End Sub
    Private Sub AggiornaPlcConDatamatrix(reading As LetturaDatamatrix)
        If reading.Side = PalletSide.Destro Then
            DatamatrixPCBPalletDx = reading.Value
            _inviaDMAlPLCPalletDx = True
            LastPCBDatamatrixScanOnSx = False
        Else
            DatamatrixPCBPalletSx = reading.Value
            _inviaDMAlPLCPalletSx = True
            LastPCBDatamatrixScanOnSx = True
        End If
        'MessageBox.Show($"Datamatrix letto: {reading.Value} sul lato {reading.Side}")
    End Sub
    Private Sub OnScanCompleted(ByVal scannedText As String)
        'DatamatrixMgr.SubmitScan(scannedText)
    End Sub

#Region "Form"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _sett As Object = Nothing

        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf OnAssemblyResolve

        AddHandler DatamatrixMgr.ReadingRequested, AddressOf OnReadingRequested
        AddHandler DatamatrixMgr.ReadingCompleted, AddressOf OnReadingCompleted

        ' Percorso completo dell'eseguibile
        'Dim percorsoExe As String = "D:\SAIEE\Registratore\Saiee.AutomationSuite.VisionCore.Remote.ReadRabbitQueues.exe"
        '
        'Dim nomeProcesso As String = IO.Path.GetFileNameWithoutExtension(percorsoExe)
        '' Chiudi eventuali processi già attivi con lo stesso nome
        'Try
        '    For Each p As Process In Process.GetProcessesByName(nomeProcesso)
        '        Try
        '            p.Kill()
        '            p.WaitForExit()
        '        Catch ex As Exception
        '            ' Gestione eccezioni per ogni processo che non si riesce a terminare
        '            show_eccezione(ex)
        '        End Try
        '    Next
        'Catch ex As Exception
        '    ' Gestione eccezioni generali
        '    show_eccezione(ex)
        'End Try
        '
        'processoEsterno = New Process()
        'processoEsterno.StartInfo.FileName = percorsoExe
        'processoEsterno.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
        'Try
        '    processoEsterno.Start()
        'Catch ex As Exception
        '    show_eccezione(ex)
        'End Try

        'Try
        '    CaricaOffsetVisioneDaJson()
        'Catch ex As Exception
        '    show_eccezione(ex)
        'End Try

        Try
            _ERR = False : Err_txt = "" : Messaggio = ""
            _m_init = False : Init_opzio = False
            '  Me.Location = New Point(1, 5)
        Catch ex As Exception
            show_eccezione(ex)
        End Try
        '-----cultura----
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-GB")
        nfi.NumberDecimalSeparator = "."

        Plc1 = New C_IBH("IBH1", 0)
        Plc2 = New C_IBH("IBH1", 0)

        Connesso1 = Plc1.Connetti()
        Connesso2 = Plc2.Connetti()

        Timer1.Enabled = True
        '===============================================================================
        Work_dir = Articoli_dir & "Piastra" & Format(Sett.n_piastra, "00")
        N_posaggi = Sett.n_posaggi
        '======================Impostazioni per lingua selezionata=======
        Machine_Status = "Manual mode"

        Popola_main()

        Load_pw()
        '  F1_handle = CInt(Me.Handle)
        Timer4.Enabled = True

        Dim _Scope = Bootstrapper.Current.Services.CreateScope
        Dim Context = _Scope.ServiceProvider.GetRequiredService(Of ProcessDataContext)()
        Try
            Dim visionConfig As List(Of VisionConfiguration) = Context.VisionConfigurations.Where(Function(x) x.ProductionConfigurationId = Sett.Id_Tool).ToList()
            Try
                Dim cameraBassaVisionConfig = visionConfig.Where(Function(x) x.VisionStep = 2).First
                Dim cameraBassaOffset As VisionOffset = Context.VisionOffsets.Where(Function(x) x.VisionConfigurationId = cameraBassaVisionConfig.Id).First
                StatiMacchina.OffsetVisioneCameraBassa.X = cameraBassaOffset.X
                StatiMacchina.OffsetVisioneCameraBassa.Y = cameraBassaOffset.Y
                StatiMacchina.OffsetVisioneCameraBassa.Rotazione = cameraBassaOffset.Angle

                StatiMacchina.OffsetUtenteVisioneCameraBassa.X = cameraBassaOffset.SecondX
                StatiMacchina.OffsetUtenteVisioneCameraBassa.Y = cameraBassaOffset.SecondY
                StatiMacchina.OffsetUtenteVisioneCameraBassa.Rotazione = cameraBassaOffset.SecondAngle
            Catch ex As Exception
                StatiMacchina.OffsetVisioneCameraBassa.X = 0
                StatiMacchina.OffsetVisioneCameraBassa.Y = 0
                StatiMacchina.OffsetVisioneCameraBassa.Rotazione = 0

                StatiMacchina.OffsetUtenteVisioneCameraBassa.X = 0
                StatiMacchina.OffsetUtenteVisioneCameraBassa.Y = 0
                StatiMacchina.OffsetUtenteVisioneCameraBassa.Rotazione = 0
            End Try

            Try
                Dim cameraAltaVisionConfig = visionConfig.Where(Function(x) x.VisionStep = 4).First
                Dim cameraAltaOffset As VisionOffset = Context.VisionOffsets.Where(Function(x) x.VisionConfigurationId = cameraAltaVisionConfig.Id).First
                StatiMacchina.OffsetVisioneCameraAlta.X = cameraAltaOffset.X
                StatiMacchina.OffsetVisioneCameraAlta.Y = cameraAltaOffset.Y
                StatiMacchina.OffsetVisioneCameraAlta.Rotazione = cameraAltaOffset.Angle

                StatiMacchina.OffsetUtenteVisioneCameraAlta.X = cameraAltaOffset.SecondX
                StatiMacchina.OffsetUtenteVisioneCameraAlta.Y = cameraAltaOffset.SecondY
                StatiMacchina.OffsetUtenteVisioneCameraAlta.Rotazione = cameraAltaOffset.SecondAngle
            Catch ex As Exception
                StatiMacchina.OffsetVisioneCameraAlta.X = 0
                StatiMacchina.OffsetVisioneCameraAlta.Y = 0
                StatiMacchina.OffsetVisioneCameraAlta.Rotazione = 0

                StatiMacchina.OffsetUtenteVisioneCameraAlta.X = 0
                StatiMacchina.OffsetUtenteVisioneCameraAlta.Y = 0
                StatiMacchina.OffsetUtenteVisioneCameraAlta.Rotazione = 0
            End Try

        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub



    Sub ChiudiProcessoEsterno()
        If processoEsterno IsNot Nothing AndAlso Not processoEsterno.HasExited Then
            Try
                processoEsterno.Kill()
                processoEsterno.WaitForExit()
                Console.WriteLine("Processo esterno terminato.")
            Catch ex As Exception
                Console.WriteLine("Errore durante la chiusura del processo esterno: " & ex.Message)
            End Try
        Else
            Console.WriteLine("Il processo esterno è già terminato.")
        End If
    End Sub
    Private Sub F_main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me._tread1 = New Thread(AddressOf Ciclo_thread)
        _tread1.Priority = ThreadPriority.Highest
        _tread1.Start()
        Me._tread2 = New Thread(AddressOf Thread_Aux)
        _tread2.Start()
        Me._thini = New Thread(AddressOf TH_init)
        _thini.Start()

        Init_opzio = True

    End Sub
    Private Sub F_main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        chiudo = True
        ChiudiProcessoEsterno()
        kill_mdi_forms()

        If F_Staz_1_2 IsNot Nothing Then
            If Not F_Staz_1_2.IsDisposed Then
                F_Staz_1_2.Close()
            End If
        End If

        If Salva_Sett Then
            Salva_Sett = False
            write_xml(Articoli_dir & "sett.txt", Sett)
        End If

        Thread.Sleep(300)
        SafeJoinThread(_tread1, 1500)
        SafeJoinThread(_tread2, 1500)
        SafeJoinThread(_thini, 1500)

        If Plc1 IsNot Nothing Then
            Plc1.Disconnetti()
        End If
        If Plc2 IsNot Nothing Then
            Plc2.Disconnetti()
        End If

        release_visione()

        'SupV = Nothing
        'chiudo il bannner

        If Spegni Then
            Process.Start("C:\Windows\System32\shutdown.exe", "/s /f")
        End If
    End Sub

    Private Sub F_main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub F_main_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        ' Evita una kill forzata del processo: la chiusura pulita rilascia meglio le risorse COM di IBH.
    End Sub
    Private Sub SafeJoinThread(ByVal th As Thread, ByVal timeoutMs As Integer)
        If th Is Nothing Then Exit Sub
        Try
            If th.IsAlive Then
                th.Join(timeoutMs)
            End If
        Catch
        End Try
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Lab_titolo.BackColor = Color.Lime ': Lab_titolo.Text = ""
        Lab_banco.Text = Sett.modello : Lab_versione.Text = Sett.Prodotto
        MyBase.OnPaint(e)
    End Sub

    Private Sub Popola_main()
        Try


        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
#End Region
#Region "Bottoni"
    Private Sub Tool_sinottico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_sinottico.Click

    End Sub
    Private Sub Tool_Param_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Parametri.Click
        If N_MDI_from = 10 Then Exit Sub
        kill_mdi_forms()
        If F_param Is Nothing Then
            F_param = New Form_PARAMETRI
        Else
            If F_param.IsDisposed Then
                F_param = New Form_PARAMETRI
            End If
        End If
        F_param.MdiParent = Me
        F_param.Show()
    End Sub
    Private Sub Tool_Log_in_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Log_in.Click
        Dim f_login As New Form_Login
        f_login.ShowDialog()
    End Sub
    Private Sub Tool_versione_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_versione.Click
        kill_mdi_forms()
        Dim F_versioni As New Form_versioni
        F_versioni.ShowDialog()
    End Sub
    Private Sub Tool_tast_num_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_tast_num.Click
        tasti_on()
    End Sub
    Private Sub Tool_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Exit.Click
        Dim _rtv As DialogResult
        Dim _FP As New Form_PopUp99_Exit

        _rtv = _FP.ShowDialog
        If _rtv = DialogResult.Cancel Then
            Spegni = True
            Me.Close()
        End If
        If _rtv = DialogResult.Yes Then
            Me.Close()
        End If
        If _rtv = DialogResult.OK Then
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub
#End Region


#Region "MDI-FORMS"
    Private Sub Tool_home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_home.Click
        If N_MDI_from = 1 Then Exit Sub
        kill_mdi_forms()
        Show_home()
    End Sub

    Private Sub Tool_lavoro2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Visioni.Click
        Try
            F_visione = New Form_visione
            F_visione.ShowDialog()
            'F_visione.Show()
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub

    Private Sub Tool_esiti_Click(sender As Object, e As EventArgs) Handles Tool_esiti.Click
        'Show_Viti()
        If N_MDI_from = 123456 Then Exit Sub
        kill_mdi_forms()
        If F_Staz_1_2 Is Nothing Then
            F_Staz_1_2 = New Form_sinottico
        Else
            If F_Staz_1_2.IsDisposed Then
                F_Staz_1_2 = New Form_sinottico
            End If
        End If
        F_Staz_1_2.MdiParent = Me
        F_Staz_1_2.Show()
    End Sub

    'Private Sub Show_Viti()
    '    Dim screen As Screen
    '    Try
    '        If F_Staz_1_2 Is Nothing Then
    '            F_Staz_1_2 = New Form_sinottico
    '        Else
    '            If F_Staz_1_2.IsDisposed Then
    '                F_Staz_1_2 = New Form_sinottico
    '            End If
    '        End If
    '        If (Screen.AllScreens.Length > 1) Then
    '            screen = Screen.AllScreens(0)
    '            F_Staz_1_2.StartPosition = FormStartPosition.Manual
    '            F_Staz_1_2.Location = screen.Bounds.Location + New Point(1, 1)
    '            ' F_Staz_1_2.ShowDialog(Me)
    '            F_Staz_1_2.Show()
    '        Else
    '            F_Staz_1_2.Show()
    '        End If
    '    Catch ex As Exception
    '        show_eccezione(ex)
    '    End Try
    'End Sub

    Private Sub Tool_magazz_Click(sender As Object, e As EventArgs) Handles Tool_magazz.Click
        Vis_Log_Level(1)
    End Sub

    Private Sub Msg_text_TextChanged(sender As Object, e As EventArgs) Handles Msg_text.TextChanged

    End Sub

    Private Sub Tool_manuali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_manuali.Click
        If N_MDI_from = 6 Then Exit Sub
        kill_mdi_forms()
        If F_manuali Is Nothing Then
            F_manuali = New Form_manuali
        Else
            If F_manuali.IsDisposed Then
                F_manuali = New Form_manuali
            End If
        End If
        F_manuali.MdiParent = Me
        F_manuali.Show()
    End Sub
    Private Sub ToolEsiti_Click(sender As Object, e As EventArgs) Handles ToolEsiti.Click
        If N_MDI_from = 96 Then Exit Sub
        kill_mdi_forms()
        If _mdi_form Is Nothing Then
            _mdi_form = New Form_Esiti
        Else
            If _mdi_form.IsDisposed Then
                _mdi_form = New Form_Esiti
            End If
        End If
        _mdi_form.MdiParent = Me
        _mdi_form.Show()
    End Sub
    Private Sub Tool_Storico_Click(sender As Object, e As EventArgs) Handles Tool_Storico.Click
        If N_MDI_from = 98 Then Exit Sub
        kill_mdi_forms()
        If _mdi_form Is Nothing Then
            _mdi_form = New Form_storico
        Else
            If _mdi_form.IsDisposed Then
                _mdi_form = New Form_storico
            End If
        End If
        _mdi_form.MdiParent = Me
        _mdi_form.Show()
    End Sub
    Private Sub Tool_alarm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_alarm.Click
        If N_MDI_from = 99 Then Exit Sub
        kill_mdi_forms()
        show_allarmi()
    End Sub

    Private Sub Tool_Robot_Click(sender As Object, e As EventArgs) Handles Tool_Robot.Click
        If N_MDI_from = 50 Then Exit Sub
        kill_mdi_forms()
        If _mdi_form Is Nothing Then
            _mdi_form = New Form_Robot
        Else
            If _mdi_form.IsDisposed Then
                _mdi_form = New Form_Robot ' _stampa
            End If
        End If
        _mdi_form.MdiParent = Me
        _mdi_form.Show()
    End Sub

    Friend Sub kill_mdi_forms()
        Dim Chil() As Form
        Dim i As Integer
        'Cmd_Jog = 0 : Cmd_Jog2 = 0 : Cmd_Jog3 = 0
        Chil = Me.MdiChildren
        If Chil.Length < 1 Then Exit Sub
        For i = 0 To Chil.Length - 1
            If Not Chil(i).IsDisposed Then
                Chil(i).Close()
            End If
        Next i
        N_MDI_from = 0 : _aggiorna = False
        _ERR = False    '--rikieste dai forms
    End Sub

    Private Sub show_allarmi()
        If F_allarmi Is Nothing Then
            F_allarmi = New Form_allarmi
        Else
            If F_allarmi.IsDisposed Then
                F_allarmi = New Form_allarmi
            End If
        End If
        F_allarmi.MdiParent = Me
        F_allarmi.Show()
    End Sub

    Private Sub Show_home()
        If F_home Is Nothing Then
            F_home = New Form_home
        Else
            If F_home.IsDisposed Then
                F_home = New Form_home ' _stampa
            End If
        End If
        F_home.MdiParent = Me
        F_home.Show()
    End Sub


#End Region
#Region "GESTIONE STATI"
    Private Sub MappaStati(_rcv As Byte())
        Dim temp(_rcv.Length - 1) As Byte
        Array.Copy(_rcv, temp, _rcv.Length)
        'statiMacchina.RobotOverride = ReadUShort(temp, 39)

        StatiMacchina.ConsensoPLCACaricamentoRicetta = ReadBool(temp, 8, 0)

        StatiMacchina.NastroSxSingolarizzatoreEsternoAbbassato = ReadBool(temp, 8, 1)
        StatiMacchina.NastroSxSingolarizzatoreEsternoRitornato = ReadBool(temp, 8, 2)
        StatiMacchina.NastroSxSingolarizzatoreInternoAbbassato = ReadBool(temp, 8, 3)
        StatiMacchina.NastroSxSingolarizzatoreInternoRitornato = ReadBool(temp, 8, 4)
        StatiMacchina.NastroSxSollevatoreLatoRobotAlzato = ReadBool(temp, 8, 5)
        StatiMacchina.NastroSxSollevatoreLatoRobotAbbassato = ReadBool(temp, 8, 6)
        StatiMacchina.NastroSxPalletSvincoloOledSvincolato = ReadBool(temp, 8, 7)
        StatiMacchina.NastroSxPalletSvincoloOledRilasciato = ReadBool(temp, 9, 0)
        StatiMacchina.NastroSxPalletPompaVuotoFrameVuotoFatto = ReadBool(temp, 9, 1)
        StatiMacchina.NastroSxPalletPompaVuotoFrameRilasciato = ReadBool(temp, 9, 2)
        StatiMacchina.NastroSxPalletPompaVuotoOledSupportoVuotoFatto = ReadBool(temp, 9, 3)
        StatiMacchina.NastroSxPalletPompaVuotoOledSupportoRilasciato = ReadBool(temp, 9, 4)
        StatiMacchina.NastroSxPalletPompaVuotoSupportoVuotoFatto = ReadBool(temp, 9, 5)
        StatiMacchina.NastroSxPalletPompaVuotoSupportoRilasciato = ReadBool(temp, 9, 6)
        StatiMacchina.NastroSxPalletPompaVuotoBiadesivoVuotoFatto = ReadBool(temp, 9, 7)
        StatiMacchina.NastroSxPalletPompaVuotoBiadesivoRilasciato = ReadBool(temp, 10, 0)
        StatiMacchina.NastroSxPalletAssePosizioneInterno = ReadBool(temp, 10, 1)
        StatiMacchina.NastroSxPalletAssePosizioneOperatore = ReadBool(temp, 10, 2) 'ex PresenzaPalletStazioneFuori

        StatiMacchina.NastroDxSingolarizzatoreEsternoAbbassato = ReadBool(temp, 10, 3)
        StatiMacchina.NastroDxSingolarizzatoreEsternoRitornato = ReadBool(temp, 10, 4)
        StatiMacchina.NastroDxSingolarizzatoreInternoAbbassato = ReadBool(temp, 10, 5)
        StatiMacchina.NastroDxSingolarizzatoreInternoRitornato = ReadBool(temp, 10, 6)
        StatiMacchina.NastroDxSollevatoreLatoRobotAlzato = ReadBool(temp, 10, 7)
        StatiMacchina.NastroDxSollevatoreLatoRobotAbbassato = ReadBool(temp, 11, 0)
        StatiMacchina.NastroDxPalletSvincoloOledSvincolato = ReadBool(temp, 11, 1)
        StatiMacchina.NastroDxPalletSvincoloOledRilasciato = ReadBool(temp, 11, 2)
        StatiMacchina.NastroDxPalletPompaVuotoFrameVuotoFatto = ReadBool(temp, 11, 3)
        StatiMacchina.NastroDxPalletPompaVuotoFrameRilasciato = ReadBool(temp, 11, 4)
        StatiMacchina.NastroDxPalletPompaVuotoOledSupportoVuotoFatto = ReadBool(temp, 11, 5)
        StatiMacchina.NastroDxPalletPompaVuotoOledSupportoRilasciato = ReadBool(temp, 11, 6)
        StatiMacchina.NastroDxPalletPompaVuotoSupportoVuotoFatto = ReadBool(temp, 11, 7)
        StatiMacchina.NastroDxPalletPompaVuotoSupportoRilasciato = ReadBool(temp, 12, 0)
        StatiMacchina.NastroDxPalletPompaVuotoBiadesivoVuotoFatto = ReadBool(temp, 12, 1)
        StatiMacchina.NastroDxPalletPompaVuotoBiadesivoRilasciato = ReadBool(temp, 12, 2)
        StatiMacchina.NastroDxPalletAssePosizioneInterno = ReadBool(temp, 12, 3)
        StatiMacchina.NastroDxPalletAssePosizioneOperatore = ReadBool(temp, 12, 4) 'ex PresenzaPalletStazioneFuori'

        StatiMacchina.NastroSxPalletPompaVuotoOledVuotoFatto = False
        StatiMacchina.NastroSxPalletPompaVuotoOledVuotoRilasciato = False

        StatiMacchina.NastroDxPalletPompaVuotoOledVuotoFatto = False
        StatiMacchina.NastroDxPalletPompaVuotoOledVuotoRilasciato = False

        StatiMacchina.MagazzinoDxCodificaAttuale = 69
        StatiMacchina.MagazzinoSxCodificaAttuale = 70


        StatiMacchina.InternoPurificatoreAriaAcceso = ReadBool(temp, 12, 7)
        StatiMacchina.InternoPurificatoreAriaSpento = ReadBool(temp, 13, 0)
        StatiMacchina.InternoAspiratoreLinerAcceso = ReadBool(temp, 13, 1)
        StatiMacchina.InternoAspiratoreLinerSpento = ReadBool(temp, 13, 2)
        StatiMacchina.InternoPlasmaAcceso = ReadBool(temp, 13, 3)
        StatiMacchina.InternoPlasmaSpento = ReadBool(temp, 13, 4)

        StatiMacchina.IlluminazioneMagazzinoAccesa = ReadBool(temp, 13, 5)
        StatiMacchina.IlluminazioneNastriAccesa = ReadBool(temp, 13, 6)
        StatiMacchina.IlluminazioneOledAccesa = ReadBool(temp, 13, 7)
        StatiMacchina.IlluminazioneManoDiPresaCalibrazioneAccesa = ReadBool(temp, 14, 0)
        StatiMacchina.IlluminazioneIncollaggio1Accesa = ReadBool(temp, 14, 1)
        StatiMacchina.IlluminazioneIncollaggio2Accesa = ReadBool(temp, 14, 2)

        StatiMacchina.DatiCellaDiCaricoPronti = ReadBool(temp, 20, 4)

        StatiMacchina.MagazzinoSxTraslazioneInternoRaggiunta = ReadBool(temp, 14, 3)
        StatiMacchina.MagazzinoSxTraslazioneOperatoreRaggiunta = ReadBool(temp, 14, 4)
        StatiMacchina.MagazzinoSxAsseVassoiAlzato = ReadBool(temp, 14, 5)
        StatiMacchina.MagazzinoSxAsseVassoiAbbassato = ReadBool(temp, 14, 6)

        StatiMacchina.MagazzinoDxTraslazioneInternoRaggiunta = ReadBool(temp, 14, 7)
        StatiMacchina.MagazzinoDxTraslazioneOperatoreRaggiunta = ReadBool(temp, 15, 0)
        StatiMacchina.MagazzinoDxAsseVassoiAlzato = ReadBool(temp, 15, 1)
        StatiMacchina.MagazzinoDxAsseVassoiAbbassato = ReadBool(temp, 15, 2)

        StatiMacchina.MagazzinoSxFuori = ReadBool(temp, 15, 3)
        StatiMacchina.MagazzinoDxFuori = ReadBool(temp, 15, 5)
        StatiMacchina.MagazzinoSxDentro = ReadBool(temp, 15, 4)
        StatiMacchina.MagazzinoDxDentro = ReadBool(temp, 15, 6)

        StatiMacchina.ComandiOn = ReadBool(temp, 18, 2)
        StatiMacchina.AutomaticoOn = ReadBool(temp, 18, 3)
        StatiMacchina.CicloOn = ReadBool(temp, 18, 4)
        StatiMacchina.CicloRun = ReadBool(temp, 18, 5)
        StatiMacchina.PLCAlarm = ReadBool(temp, 18, 6) 'cumulativo
        StatiMacchina.RobotAlarm = ReadBool(temp, 18, 7) 'cumulativo
        StatiMacchina.PlasmaturaAlarm = ReadBool(temp, 19, 0) 'cumulativo
        StatiMacchina.MagazzinoAlarm = ReadBool(temp, 19, 1) 'cumulativo
        StatiMacchina.AvvitaturaAlarm = ReadBool(temp, 19, 2) 'cumulativo
        StatiMacchina.PresenzaScarti = ReadBool(temp, 19, 5)

        StatiMacchina.MissioneRobotInCorso = -1

        StatiMacchina.CameraBassaValutaDataMatrix = ReadBool(temp, 40, 0)
        StatiMacchina.CameraBassaValutaOrientamento = ReadBool(temp, 40, 1)
        StatiMacchina.CameraBassaValutaPezzoOk = ReadBool(temp, 40, 2)
        StatiMacchina.CameraAltaValutaPezzoOk = ReadBool(temp, 40, 3) 'IN realtà è ORIENTAMENTO camera alta
        StatiMacchina.TracciaDSM = ReadBool(temp, 15, 7)
        StatiMacchina.TracciaDB = ReadBool(temp, 16, 0)

        StatiMacchina.InterventoBarrieraMagazzini = ReadBool(temp, 16, 1)

        StatiMacchina.PresenzaOledPosaggioSx = False
        StatiMacchina.PresenzaSupportoPosaggioSx = ReadBool(temp, 16, 2)

        StatiMacchina.PresenzaBiadesivoPosaggioSx = ReadBool(temp, 16, 3)
        StatiMacchina.PresenzaCornicePosaggioSx = ReadBool(temp, 16, 4)
        StatiMacchina.PresenzaBracketPosaggioSx = ReadBool(temp, 16, 5)
        StatiMacchina.PresenzaPezzoFinitoPosaggioSx = ReadBool(temp, 16, 6)

        StatiMacchina.PosaggioSxInCiclo = ReadBool(temp, 17, 4)

        StatiMacchina.AllarmeNastri = ReadBool(temp, 19, 4)

        StatiMacchina.PresenzaOledPosaggioDx = False
        StatiMacchina.PresenzaSupportoPosaggioDx = ReadBool(temp, 16, 7)

        StatiMacchina.PresenzaBiadesivoPosaggioDx = ReadBool(temp, 17, 0)
        StatiMacchina.PresenzaCornicePosaggioDx = ReadBool(temp, 17, 1)
        StatiMacchina.PresenzaBracketPosaggioDx = ReadBool(temp, 17, 2)
        StatiMacchina.PresenzaPezzoFinitoPosaggioDx = ReadBool(temp, 17, 3)

        StatiMacchina.PosaggioDxInCiclo = ReadBool(temp, 17, 5)

        StatiMacchina.NastroDxInMovimento = ReadBool(temp, 12, 5)
        StatiMacchina.NastroSxInMovimento = ReadBool(temp, 12, 6)

        StatiMacchina.DataMatrixSuNastroSx = ReadS7String(temp, 462, 40)
        StatiMacchina.DataMatrixSuNastroDx = ReadS7String(temp, 504, 40)


        StatiMacchina.IncollaggioPompaVuotoOledSxFatto = ReadBool(temp, 17, 6)
        StatiMacchina.IncollaggioPompaVuotoOledSxRilasciato = ReadBool(temp, 17, 7)
        StatiMacchina.IncollaggioPompaVuotoOledDxFatto = ReadBool(temp, 18, 0)
        StatiMacchina.IncollaggioPompaVuotoOledDxRilasciato = ReadBool(temp, 18, 1)






        ' Punti robot
        StatiMacchina.ManoDiPresa1 = ReadPunto(temp, 44)
        StatiMacchina.ManoDiPresa2 = ReadPunto(temp, 56)
        StatiMacchina.CameraBassa = ReadPuntoArray(temp, 116, 2)
        StatiMacchina.PalletSuNastroSxBiadesivo = ReadPunto(temp, 140)
        StatiMacchina.PalletSuNastroSxSupporto = ReadPunto(temp, 152)
        StatiMacchina.PalletSuNastroSxPezzoFinito = ReadPunto(temp, 164)

        StatiMacchina.PalletSuNastroDxBiadesivo = ReadPunto(temp, 176)
        StatiMacchina.PalletSuNastroDxSupporto = ReadPunto(temp, 188)
        StatiMacchina.PalletSuNastroDxPezzoFinito = ReadPunto(temp, 200)

        StatiMacchina.Incollaggio = ReadPunto(temp, 212)

        StatiMacchina.MagazzinoSxOledSx = ReadPunto(temp, 224)
        StatiMacchina.MagazzinoSxOledDx = ReadPunto(temp, 236)
        StatiMacchina.MagazzinoSxVassoio = ReadPunto(temp, 248)

        StatiMacchina.MagazzinoDxOledSx = ReadPunto(temp, 260)
        StatiMacchina.MagazzinoDxOledDx = ReadPunto(temp, 272)
        StatiMacchina.MagazzinoDxVassoio = ReadPunto(temp, 284)

        StatiMacchina.PosizioneScarto1 = ReadPunto(temp, 296)
        StatiMacchina.PosizioneScarto2 = ReadPunto(temp, 308)
        StatiMacchina.PosizioneScarto3 = ReadPunto(temp, 320)
        StatiMacchina.PosizioneScarto4 = ReadPunto(temp, 332)

        StatiMacchina.Plasma = ReadPunto(temp, 344)
        StatiMacchina.StrappoLiner = ReadPunto(temp, 356)
        StatiMacchina.VassoiVuoti = ReadPunto(temp, 368)
        StatiMacchina.PosizioneCameraBassa1 = ReadPunto(temp, 116)
        StatiMacchina.PosizioneCameraBassa2 = ReadPunto(temp, 128)
        StatiMacchina.PosizioneCameraAlta = ReadPunto(temp, 392)

        'StatiMacchina.ProgrammaVisionedaPLC = 3 'ReadUShort(temp, 392)
        StatiMacchina.RobotOverrideValue = CUShort(ReadUSInt(temp, 39))

        StatiMacchina.ConteggioPezziBuoni = ReadIntFrom_8Bytes(temp, 590)
        StatiMacchina.ConteggioPezziScarti = ReadIntFrom_8Bytes(temp, 598)

        StatiMacchina.ScartoInPosizione1Tavolino = ReadBool(temp, 404, 0)
        StatiMacchina.ScartoInPosizione2Tavolino = ReadBool(temp, 404, 1)
        StatiMacchina.ScartoInPosizione3Tavolino = ReadBool(temp, 404, 2)
        StatiMacchina.ScartoInPosizione4Tavolino = ReadBool(temp, 404, 3)
        StatiMacchina.ScartoInPosizione5Spare = ReadBool(temp, 404, 4)
        StatiMacchina.ScartoInPosizione6Spare = ReadBool(temp, 404, 5)
        StatiMacchina.ScartoInPosizione7Spare = ReadBool(temp, 404, 6)
        StatiMacchina.ScartoInPosizione8Spare = ReadBool(temp, 404, 7)

        Dim tipoScarto1 As Integer = ReadUSInt(temp, 650)
        StatiMacchina.TipologiaScartoInPosizione1Tavolino = DecodeTipoScarto(tipoScarto1)
        Dim tipoScarto2 As Integer = ReadUSInt(temp, 651)
        StatiMacchina.TipologiaScartoInPosizione2Tavolino = DecodeTipoScarto(tipoScarto2)
        Dim tipoScarto3 As Integer = ReadUSInt(temp, 652)
        StatiMacchina.TipologiaScartoInPosizione3Tavolino = DecodeTipoScarto(tipoScarto3)
        Dim tipoScarto4 As Integer = ReadUSInt(temp, 653)
        StatiMacchina.TipologiaScartoInPosizione4Tavolino = DecodeTipoScarto(tipoScarto4)

        StatiMacchina.CodificaPalletSx = ReadUSInt(temp, 408)
        StatiMacchina.CodificaPalletDx = ReadUSInt(temp, 409)

        StatiMacchina.OrientamentoCameraSX = ReadPunto(temp, 626)
        StatiMacchina.OrientamentoCameraDX = ReadPunto(temp, 638)

        StatiMacchina.RimozioneLinerAbilitata = ReadBool(temp, 588, 2)

#Region "DATI PER ROBOT"

        StatiMacchina.ManoDiPresaVuotoOn = False
        StatiMacchina.ManoDiPresaPinzaAperta = False
        StatiMacchina.ManoDiPresaPinzaChiusa = False
        StatiMacchina.ManoDiPresaIndexAvanti = False
        StatiMacchina.ManoDiPresaIndexIndietro = False

        StatiMacchina.RobotCodiceMissioneInCorso = ReadUSInt(temp, 410)
        AggiornaMissioneRobot(StatiMacchina.RobotCodiceMissioneInCorso)

        StatiMacchina.RobotCodicePosizioneAttuale = ReadUSInt(temp, 411)
        AggiornaCodicePosizioneRobot(StatiMacchina.RobotCodicePosizioneAttuale)

        StatiMacchina.ManoDiPresaConnessa = ReadUSInt(temp, 413)
        AggiornaManoDiPresa(StatiMacchina.ManoDiPresaConnessa)

        StatiMacchina.MagazzinoAPresenzaPezzi = ReadUSInt(temp, 406)
        AggiornaMagazzinoAPresenzaPezzi(StatiMacchina.MagazzinoAPresenzaPezzi)

        StatiMacchina.MagazzinoBPresenzaPezzi = ReadUSInt(temp, 407)
        AggiornaMagazzinoBPresenzaPezzi(StatiMacchina.MagazzinoBPresenzaPezzi)

        StatiMacchina.PresenzaPezzoIncollaggio = ReadUSInt(temp, 415)
        StatiMacchina.CodicePosaggioIncollaggio = ReadUSInt(temp, 414)

        StatiMacchina.RobotCodicePresenzaPezzi = ReadUSInt(temp, 412)
        AggiornaRobotPresenzaPezzi(StatiMacchina.RobotCodicePresenzaPezzi)

        'FACCIO TUTTO IN AggiornaMissioneRobot!!!!!!!!!!!!
        'StatiMacchina.RobotMissionVaiZonaCameraInCorso = False
        'StatiMacchina.RobotMissioneHomeInCorso = False
        'StatiMacchina.RobotMissionePrelevaSupportoNastroSxInCorso = False
        'StatiMacchina.RobotMissioneIncollaBiadesivoSuSupportoNastroSxInCorso = False
        'StatiMacchina.RobotMissioneDepositaPezzoFinitoSuNastroSxInCorso = False
        'StatiMacchina.RobotMissionePrelevaSupportoNastroDxInCorso = False
        'StatiMacchina.RobotMissioneIncollaBiadesivoSuSupportoNastroDxInCorso = False
        'StatiMacchina.RobotMissioneDepositaPezzoFinitoSuNastroDxInCorso = False
        'StatiMacchina.RobotMissioneDepositaOledInIncollaggioInCorso = False
        'StatiMacchina.RobotMissioneIncollaSupportoConOledInIncollaggioInCorso = False
        'StatiMacchina.RobotMissionePrelevaOledSxMagazzinoSxInCorso = False
        'StatiMacchina.RobotMissionePrelevaOledDxMagazzinoSxInCorso = False
        'StatiMacchina.RobotMissionePrelevaVassoioMagazzinoSxInCorso = False
        'StatiMacchina.RobotMissionePrelevaOledSxMagazzinoDxInCorso = False
        'StatiMacchina.RobotMissionePrelevaOledDxMagazzinoDxInCorso = False
        'StatiMacchina.RobotMissionePrelevaVassoioMagazzinoDxInCorso = False
        'StatiMacchina.RobotMissioneDepositaVassoioVuotoInCorso = False
        'StatiMacchina.RobotMissioneDepositaOledScartoPosizione1InCorso = False
        'StatiMacchina.RobotMissioneDepositaOledScartoPosizione2InCorso = False
        'StatiMacchina.RobotMissioneDepositaOledScartoPosizione3InCorso = False
        'StatiMacchina.RobotMissioneDepositaOledScartoPosizione4InCorso = False
        'StatiMacchina.RobotMissioneFaiCicloPlasmaturaInCorso = False
        'StatiMacchina.RobotMissioneStrappaLinerInCorso = False
        'StatiMacchina.RobotMissioneRaccogliOledScartoDaIncollaggioInCorso = False

        StatiMacchina.InternoSoffioOn = False
#End Region
#Region "VITI"
        StatiMacchina.Vite1PalletSx.R1 = ReadIntFrom_2Bytes(temp, 416)
        StatiMacchina.Vite1PalletSx.R2 = ReadIntFrom_2Bytes(temp, 418)
        StatiMacchina.Vite1PalletSx.H = ReadIntFrom_2Bytes(temp, 420)

        StatiMacchina.Vite2PalletSx.R1 = ReadIntFrom_2Bytes(temp, 422)
        StatiMacchina.Vite2PalletSx.R2 = ReadIntFrom_2Bytes(temp, 424)
        StatiMacchina.Vite2PalletSx.H = ReadIntFrom_2Bytes(temp, 426)

        StatiMacchina.Vite3PalletSx.R1 = ReadIntFrom_2Bytes(temp, 428)
        StatiMacchina.Vite3PalletSx.R2 = ReadIntFrom_2Bytes(temp, 430)
        StatiMacchina.Vite3PalletSx.H = ReadIntFrom_2Bytes(temp, 432)

        StatiMacchina.Vite1PalletDx.R1 = ReadIntFrom_2Bytes(temp, 434)
        StatiMacchina.Vite1PalletDx.R2 = ReadIntFrom_2Bytes(temp, 436)
        StatiMacchina.Vite1PalletDx.H = ReadIntFrom_2Bytes(temp, 438)

        StatiMacchina.Vite2PalletDx.R1 = ReadIntFrom_2Bytes(temp, 440)
        StatiMacchina.Vite2PalletDx.R2 = ReadIntFrom_2Bytes(temp, 442)
        StatiMacchina.Vite2PalletDx.H = ReadIntFrom_2Bytes(temp, 444)

        StatiMacchina.Vite3PalletDx.R1 = ReadIntFrom_2Bytes(temp, 446)
        StatiMacchina.Vite3PalletDx.R2 = ReadIntFrom_2Bytes(temp, 448)
        StatiMacchina.Vite3PalletDx.H = ReadIntFrom_2Bytes(temp, 450)

        StatiMacchina.PosizioneCorrenteAvvitatore.R1 = ReadIntFrom_2Bytes(temp, 452)
        StatiMacchina.PosizioneCorrenteAvvitatore.R2 = ReadIntFrom_2Bytes(temp, 454)
        StatiMacchina.PosizioneCorrenteAvvitatore.H = ReadIntFrom_2Bytes(temp, 456)

        StatiMacchina.Pos1VicinanzaBit1 = ReadBool(temp, 458, 0)
        StatiMacchina.Pos1VicinanzaBit2 = ReadBool(temp, 458, 1)
        StatiMacchina.Pos1VicinanzaOverall = DecodificaVicinanzaViti(StatiMacchina.Pos1VicinanzaBit1, StatiMacchina.Pos1VicinanzaBit2)
        StatiMacchina.Pos1ViteDaAvvitareAdesso = ReadBool(temp, 458, 2)
        StatiMacchina.Pos1ViteAvvitata = ReadBool(temp, 458, 3)
        StatiMacchina.Pos1ViteOk = ReadBool(temp, 458, 4)

        StatiMacchina.Pos2VicinanzaBit1 = ReadBool(temp, 458, 5)
        StatiMacchina.Pos2VicinanzaBit2 = ReadBool(temp, 458, 6)
        StatiMacchina.Pos2VicinanzaOverall = DecodificaVicinanzaViti(StatiMacchina.Pos2VicinanzaBit1, StatiMacchina.Pos2VicinanzaBit2)
        StatiMacchina.Pos2ViteDaAvvitareAdesso = ReadBool(temp, 458, 7)
        StatiMacchina.Pos2ViteAvvitata = ReadBool(temp, 459, 0)
        StatiMacchina.Pos2ViteOk = ReadBool(temp, 459, 1)

        StatiMacchina.Pos3VicinanzaBit1 = ReadBool(temp, 459, 2)
        StatiMacchina.Pos3VicinanzaBit2 = ReadBool(temp, 459, 3)
        StatiMacchina.Pos3VicinanzaOverall = DecodificaVicinanzaViti(StatiMacchina.Pos3VicinanzaBit1, StatiMacchina.Pos3VicinanzaBit2)
        StatiMacchina.Pos3ViteDaAvvitareAdesso = ReadBool(temp, 459, 4)
        StatiMacchina.Pos3ViteAvvitata = ReadBool(temp, 459, 5)
        StatiMacchina.Pos3ViteOk = ReadBool(temp, 459, 6)

        StatiMacchina.Pos4VicinanzaBit1 = ReadBool(temp, 459, 7)
        StatiMacchina.Pos4VicinanzaBit2 = ReadBool(temp, 460, 0)
        StatiMacchina.Pos4VicinanzaOverall = DecodificaVicinanzaViti(StatiMacchina.Pos4VicinanzaBit1, StatiMacchina.Pos4VicinanzaBit2)
        StatiMacchina.Pos4ViteDaAvvitareAdesso = ReadBool(temp, 460, 1)
        StatiMacchina.Pos4ViteAvvitata = ReadBool(temp, 460, 2)
        StatiMacchina.Pos4ViteOk = ReadBool(temp, 460, 3)

        StatiMacchina.Pos5VicinanzaBit1 = ReadBool(temp, 460, 4)
        StatiMacchina.Pos5VicinanzaBit2 = ReadBool(temp, 460, 5)
        StatiMacchina.Pos5VicinanzaOverall = DecodificaVicinanzaViti(StatiMacchina.Pos5VicinanzaBit1, StatiMacchina.Pos5VicinanzaBit2)
        StatiMacchina.Pos5ViteDaAvvitareAdesso = ReadBool(temp, 460, 6)
        StatiMacchina.Pos5ViteAvvitata = ReadBool(temp, 460, 7)
        StatiMacchina.Pos5ViteOk = ReadBool(temp, 461, 0)

        StatiMacchina.Pos6VicinanzaBit1 = ReadBool(temp, 461, 1)
        StatiMacchina.Pos6VicinanzaBit2 = ReadBool(temp, 461, 2)
        StatiMacchina.Pos6VicinanzaOverall = DecodificaVicinanzaViti(StatiMacchina.Pos6VicinanzaBit1, StatiMacchina.Pos6VicinanzaBit2)
        StatiMacchina.Pos6ViteDaAvvitareAdesso = ReadBool(temp, 461, 3)
        StatiMacchina.Pos6ViteAvvitata = ReadBool(temp, 461, 4)
        StatiMacchina.Pos6ViteOk = ReadBool(temp, 461, 5)

        StatiMacchina.PresenzaPezzoDaAvvitareSx = ReadBool(temp, 20, 5)
        StatiMacchina.PresenzaPezzoDaAvvitareDx = ReadBool(temp, 20, 6)



#End Region

        StatiMacchina.RichiestaLetturaDatamatrixPalletSx = ReadBool(temp, 40, 4)
        StatiMacchina.RichiestaLetturaDatamatrixPalletDx = ReadBool(temp, 40, 5)

        StatiMacchina.PreorientamentoDaFare = ReadBool(temp, 588, 0)

        StatiMacchina.LetturaDatamatrixPcbAbilitato = ReadBool(temp, 588, 1)

#Region "ANALOGICHE"
        StatiMacchina.VuotoFrameSx = ReadIntFrom_2Bytes(temp, 618)  'VALORI IN MILLIBAR
        StatiMacchina.VuotoSupportoSx = ReadIntFrom_2Bytes(temp, 610)
        StatiMacchina.VuotoBiadesivoSx = ReadIntFrom_2Bytes(temp, 606)
        StatiMacchina.VuotoOledSx = ReadIntFrom_2Bytes(temp, 614)
        StatiMacchina.VuotoFrameDx = ReadIntFrom_2Bytes(temp, 620)
        StatiMacchina.VuotoSupportoDx = ReadIntFrom_2Bytes(temp, 612)
        StatiMacchina.VuotoBiadesivoDx = ReadIntFrom_2Bytes(temp, 608)
        StatiMacchina.VuotoOledDx = ReadIntFrom_2Bytes(temp, 616)
        StatiMacchina.VuotoIncollaggio = ReadIntFrom_2Bytes(temp, 622)
        StatiMacchina.VuotoManoDiPresa = ReadIntFrom_2Bytes(temp, 624)
#End Region

    End Sub
    Private Function ReadBool(bytes As Byte(), byteOffset As Integer, bit As Integer) As Boolean
        Return ((bytes(byteOffset) >> bit) And 1) = 1
    End Function
    Private Function ReadIntFrom_2Bytes(bytes As Byte(), offset As Integer) As Integer
        Dim _2bytes As Byte()
        _2bytes = New Byte(1) {0, 0}
        _2bytes(1) = bytes(offset) : _2bytes(0) = bytes(offset + 1)
        Return CInt(BitConverter.ToInt16(_2bytes, 0))
    End Function

    Private Function ReadIntFrom_4Bytes(bytes As Byte(), offset As Integer) As Integer
        Dim _4bytes(3) As Byte
        _4bytes(3) = bytes(offset) : _4bytes(2) = bytes(offset + 1) : _4bytes(1) = bytes(offset + 2) : _4bytes(0) = bytes(offset + 3)
        Return CInt(BitConverter.ToInt32(_4bytes, 0))
    End Function

    Private Function ReadIntFrom_8Bytes(bytes As Byte(), offset As Integer) As Long
        Dim _8bytes(7) As Byte
        _8bytes(7) = bytes(offset) : _8bytes(6) = bytes(offset + 1) : _8bytes(5) = bytes(offset + 2) : _8bytes(4) = bytes(offset + 3)
        _8bytes(3) = bytes(offset + 4) : _8bytes(2) = bytes(offset + 5) : _8bytes(1) = bytes(offset + 6) : _8bytes(0) = bytes(offset + 7)
        Return BitConverter.ToInt64(_8bytes, 0)
    End Function

    Private Function ReadPunto(bytes As Byte(), offset As Integer) As PuntoRobotUDT
        Dim p As New PuntoRobotUDT
        p.X = ReadIntFrom_2Bytes(bytes, offset)
        p.Y = ReadIntFrom_2Bytes(bytes, offset + 2)
        p.Z = ReadIntFrom_2Bytes(bytes, offset + 4)
        p.RotazioneZ = ReadIntFrom_2Bytes(bytes, offset + 6)
        p.RotazioneY = ReadIntFrom_2Bytes(bytes, offset + 8)
        p.RotazioneX = ReadIntFrom_2Bytes(bytes, offset + 10)
        Return p
    End Function

    Private Function ReadPuntoArray(bytes As Byte(), offset As Integer, count As Integer) As PuntoRobotUDT()
        Dim arr(count - 1) As PuntoRobotUDT
        For i = 0 To count - 1
            arr(i) = ReadPunto(bytes, offset + i * 24)
        Next
        Return arr
    End Function

    Private Sub Tool_10_Click(sender As Object, e As EventArgs) Handles Tool_10.Click
        If N_MDI_from = 51 Then Exit Sub
        kill_mdi_forms()
        If _mdi_form Is Nothing Then
            _mdi_form = New Form_Robot_Punti
        Else
            If _mdi_form.IsDisposed Then
                _mdi_form = New Form_Robot_Punti ' _stampa
            End If
        End If
        _mdi_form.MdiParent = Me
        _mdi_form.Show()
    End Sub

    Private Function ReadS7String(bytes As Byte(), offset As Integer, len As Integer) As String
        Return System.Text.Encoding.ASCII.GetString(bytes, offset, len)
    End Function

    'USInt => 1byte
    Private Function ReadUSInt(ByVal bytes As Byte(), ByVal offset As Integer) As Integer
        Return CInt(bytes(offset)) ' 0..255
    End Function
    Private Function DecodeTipoScarto(tipo As Integer) As TipoScarto
        Select Case tipo
            Case 0
                Return TipoScarto.Nessuno
            Case 1
                Return TipoScarto.Datamatrix
            Case 2
                Return TipoScarto.PreOrientamento
            Case 3
                Return TipoScarto.Orientamento
            Case Else
                Return TipoScarto.Nessuno
        End Select
    End Function


    ''' <summary>
    ''' Decodificas the vicinanza viti.
    ''' </summary>
    ''' 0 - Lontano 
    ''' 1 - Vicino
    ''' 2 - In posizione
    ''' -1 - Errore
    ''' <returns></returns>
    Private Function DecodificaVicinanzaViti(bit1 As Boolean, bit2 As Boolean) As Integer
        '00: lontano - 01: vicino - 10: in posizione (0: lontano / 1: vicino)
        If bit1 Then
            If bit2 Then
                '11
                Return -1
            Else
                '10
                Return 2
            End If
        Else
            If bit2 Then
                '01
                Return 1
            Else
                Return 0
            End If
        End If
    End Function

#End Region
    Private Sub Ciclo_thread()
        Dim _rcv() As Byte = Nothing
        Dim _vint(15) As Byte
        'Dim report As New BitArray(16, False)
_ini:   If chiudo Then Exit Sub
        _tt = Now.Ticks
        Try
            If Connesso1 Then
                '========================================================================
                Thread.Sleep(30)    '######
                '===========================================================================
                If Plc1.Read_Vals(C_IBH.nArea.DB, 0, 100, _DB100_Length, _rcv) Then
                    MappaStati(_rcv)
                    Comandi_On = StatiMacchina.ComandiOn
                    Automatico = StatiMacchina.AutomaticoOn
                    Ciclo_on = StatiMacchina.CicloOn
                    Ciclo_Run = StatiMacchina.CicloRun
                    PLC_alarm = StatiMacchina.PLCAlarm
                    BAll_Robot = StatiMacchina.RobotAlarm
                    P3_Presente = False
                    plc_SingleOperator = False
                    Read_Values()
                Else
                    show_eccezione(Plc1.Eccezione)
                    _err1 = True
                    GoTo _ini
                End If
                If Plc1.Read_Vals(C_IBH.nArea.DB, 0, 100, _DB110_Length, _rcv) Then
                    Dim a = 0
                End If
                Tutto_Buono_dx = True : Tutto_Buono_sx = True
                If Plc1.Read_Vals(C_IBH.nArea.DB, 0, 100, 8, _rcv) Then
                    BytesMessaggiPLC = _rcv
                End If
                '-------------------------------------
                If Automatico Xor _m_Autom Then
                    ' TMSRFV_Set_Modes(Automatico, Ciclo_on, PLC_alarm)
                    If Automatico Then
                        Machine_Status = "Cycle RUN"
                    Else
                        Machine_Status = "Manual mode"
                    End If
                End If
                _m_Autom = Automatico
                If Not P3_Presente Then
                    _NS_MatrixA = 0 : _NS_MatrixB = 0 : _NS_AllinA = 0 : _NS_AllinB = 0 : NS_MountA = 0 : NS_MountB = 0
                    If Device > 2 Then
                        DMX_A = Sett.Prodotto & "_" & Format(Now, "ddMMyyHHmmss")
                        DMX_B = Sett.Prodotto & "_" & Format(Now, "ddMMyyHHmmss")
                    Else
                        DMX_A = Sett.Prodotto & "_A_" & Format(Now, "ddMMyyHHmmss")
                        DMX_B = Sett.Prodotto & "_B_" & Format(Now, "ddMMyyHHmmss")
                    End If
                End If
                '----------------------------------------------------------------------                

#Region "LETTURA CELLE CARICO"
                'DATI CELLA CARICO
                If StatiMacchina.DatiCellaDiCaricoPronti And Not _datiCellaDiCaricoPronti_Mem Or ManualTriggerCella Then

                    ManualTriggerCella = False
                    Plc1.Read_Vals(C_IBH.nArea.DB, 0, 110, 802, _rcv)
                    Dim temp(_rcv.Length - 1) As Byte
                    Array.Copy(_rcv, temp, _rcv.Length)
                    SyncLock PlcLock
                        IndiceUltimoDato = ReadUShortFrom_2Bytes(temp, 0)
                        ParseInfoBlock(temp, 2)
                    End SyncLock
                    AggiornaSnapshot()
                    RefreshFormPlotCelleDiCarico = True
                    'TODO: salva su file dati cella di carico 
                    Dim dto = BuildSnapshotDto()
                    Dim json = JsonConvert.SerializeObject(dto, Formatting.Indented)
                    Dim art As String = ""
                    If (Prodotto_Act.Name.Contains("SX")) Then
                        art = "SX"
                    Else
                        art = "DX"
                    End If
                    Dim sanitizedDM As String = DM_Oled.Replace(" ", "_").Replace("\", "_").Replace("/", "_") ' Sostituisci i caratteri non validi")
                    If sanitizedDM = String.Empty Then
                        sanitizedDM = "Unknown_DM_" & Format(Now, "yyyyMMdd_HHmmss")
                    End If
                    Dim today As String = Format(Now, "yyMMdd")
                    Dim dirPath As String = "D:\TRACEABILITY\BENDABLE\" & art & "\" & today & "\"
                    Dim fileName As String = dirPath & sanitizedDM & ".json"

                    ' Crea la directory se non esiste
                    If Not IO.Directory.Exists(dirPath) Then
                        IO.Directory.CreateDirectory(dirPath)
                    End If

                    IO.File.WriteAllText(fileName, json, System.Text.Encoding.UTF8)


                End If
                _datiCellaDiCaricoPronti_Mem = StatiMacchina.DatiCellaDiCaricoPronti
#End Region
                '&&&&&&&&&&&&&&&&&&&&&&&&&&&&&  visioni &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
                If (StatiMacchina.CameraBassaValutaDataMatrix And Not m_vis(1)) Or SimulaStep1 Then
                    SimulaStep1 = False
                    DM_Oled = ""
                    Exe_Plc_Vis_Step(1, "")  'run lettura data MAtrix OLED
                End If
                m_vis(1) = StatiMacchina.CameraBassaValutaDataMatrix
                If Fine_Vis(1) Then      'fine visione 
                    Fine_Vis(1) = False

                    Plc1.Write_Val(C_IBH.PlcVar.D, 42, 100, 1, CInt(True))
                    If Not (Scarto_Visione(1)) Then
                        If Memo_Oled() Then
                            Plc1.Write_Vals(C_IBH.nArea.DB, 546, 100, MatrixOled.Length, MatrixOled)  'Memo D-Matrix OLED --> Staz Robot DB100 DBD546 -->ARRAY 40
                            'Plc1.Write_Vals(C_IBH.nArea.DB, 88, 20, 6, Date_Oled)
                        End If
                    End If
                    Plc1.Write_Val(C_IBH.PlcVar.D, 42, 100, 0, CInt(True)) 'CameraBassaValutaDataMatrixDone	Bool	DB 100 42.0	Procedura terminata
                End If

                '------ visione 2 OLED PRE ORIENTAMENTO ----
                If (StatiMacchina.CameraBassaValutaOrientamento And Not m_vis(2)) Or SimulaStep2 Then
                    SimulaStep2 = False
                    Exe_Plc_Vis_Step(2, "")  'run
                End If
                m_vis(2) = StatiMacchina.CameraBassaValutaOrientamento
                If Fine_Vis(2) Then
                    Fine_Vis(2) = False
                    OrientamentoVisioneBassaFuoriLimiti = Correz_Orientam(2)
                    Dim realBuonoVisione = OrientamentoVisioneBassaFuoriLimiti And Not Scarto_Visione(2) 'ESEMPIO, VISIONE OK MA FUORI TOLLERANZA
                    Plc1.Write_Val(C_IBH.PlcVar.D, 42, 100, 3, CInt(realBuonoVisione)) 'CameraBassaValutaOrientamentoOk	Bool DB100	42.3	True: pezzo processabile; False: pezzo scarto
                    If realBuonoVisione Then
                        CorrezioneVisioneBassa.X = _dx + StatiMacchina.OffsetVisioneCameraBassa.X
                        CorrezioneVisioneBassa.Y = _dy + StatiMacchina.OffsetVisioneCameraBassa.Y
                        CorrezioneVisioneBassa.Z = _dz
                        CorrezioneVisioneBassa.RotazioneZ = _da + StatiMacchina.OffsetVisioneCameraBassa.Rotazione

                        If OrientamentoVisioneBassaFuoriLimiti Then
                            Plc1.Write_Vals(C_IBH.nArea.DB, 380, 100, 12, CorrTlc) 'CorrezioneCameraBassa
                        Else
                            Plc1.Write_Val(C_IBH.PlcVar.D, 42, 100, 3, CInt(False)) 'CameraBassaValutaOrientamentoOk => SCARTO                           
                        End If
                    Else
                        CorrezioneVisioneBassa.X = 0.0
                        CorrezioneVisioneBassa.Y = 0.0
                        CorrezioneVisioneBassa.Z = 0.0
                        CorrezioneVisioneBassa.RotazioneZ = 0.0
                    End If
                    Plc1.Write_Val(C_IBH.PlcVar.D, 42, 100, 2, CInt(True)) 'CameraBassaValutaOrientamentoDone	Bool	DB 100 42.2	Procedura terminata
                End If

                '------ visione 3 OLED SAVE FRAME ----
                If (StatiMacchina.CameraBassaValutaPezzoOk And Not m_vis(3)) Or SimulaStep3 Then
                    SimulaStep3 = False
                    Exe_Plc_Vis_Step(3, DM_Oled)  'run
                End If
                m_vis(3) = StatiMacchina.CameraBassaValutaPezzoOk
                If Fine_Vis(3) Then
                    Fine_Vis(3) = False
                    Plc1.Write_Val(C_IBH.PlcVar.D, 42, 100, 5, True)
                    'TODO PORCO DIO FORZATURA 
                    'Plc1.Write_Val(C_IBH.PlcVar.D, 42, 100, 5, CInt(Not Scarto_Visione(3))) 'CameraBassaValutaPezzoOkOk	Bool DB100	42.5	True: pezzo processabile; False: pezzo scarto


                    Plc1.Write_Val(C_IBH.PlcVar.D, 42, 100, 4, CInt(True)) 'CameraBassaValutaPezzoOkDone	Bool DB 100	42.4	Procedura terminata
                End If
                '############################ ORIENTAMENTO OLED (A) SU POSAGGIO PRIMA DI NASTRI ----------
                If (StatiMacchina.CameraAltaValutaPezzoOk And Not m_vis(4)) Or SimulaStep4 Then
                    SimulaStep4 = False
                    Exe_Plc_Vis_Step(4, "") 'run Pressa OLED A
                End If
                m_vis(4) = StatiMacchina.CameraAltaValutaPezzoOk
                If Fine_Vis(4) Then      '///////////// fine visioni 
                    Fine_Vis(4) = False
                    OrientamentoVisioneAltaFuoriLimiti = Correz_Orientam(4)
                    Dim realBuonoVisione = OrientamentoVisioneAltaFuoriLimiti And Not Scarto_Visione(4) 'ESEMPIO, VISIONE OK MA FUORI TOLLERANZA
                    Plc1.Write_Val(C_IBH.PlcVar.D, 42, 100, 7, CInt(realBuonoVisione)) 'CameraAltaValutaPezzoOkOk	Bool	42.7	True: pezzo processabile; False: pezzo scarto
                    If realBuonoVisione Then
                        CorrezioneVisioneAlta.X = _dx
                        CorrezioneVisioneAlta.Y = _dy
                        CorrezioneVisioneAlta.Z = _dz
                        CorrezioneVisioneAlta.RotazioneZ = _da
                        If OrientamentoVisioneAltaFuoriLimiti Then
                            Plc1.Write_Vals(C_IBH.nArea.DB, 392, 100, 12, CorrTlc) 'CorrezioneCameraAlta
                        Else
                            Plc1.Write_Val(C_IBH.PlcVar.M, 42, 100, 7, CInt(False)) ''CameraAltaValutaPezzoOkOk => scarto                           
                        End If
                    Else
                        CorrezioneVisioneAlta.X = 0.0
                        CorrezioneVisioneAlta.Y = 0.0
                        CorrezioneVisioneAlta.Z = 0.0
                        CorrezioneVisioneAlta.RotazioneZ = 0.0
                    End If
                    Plc1.Write_Val(C_IBH.PlcVar.D, 42, 100, 6, CInt(True)) 'CameraAltaValutaPezzoOkDone	Bool	42.4	Procedura terminata
                End If

                '-&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
                If (Ciclo_on = True) And (Mem_ciclo_on = False) Then
                    CycOn_Dato = True : Repos_Dato = False
                    data_inizioa = Now.ToUniversalTime : data_inizio = Now.ToLocalTime

                    ' Preset_visione()        'visione
                    If Sett.Trace_Sql Then

                    End If
                    'TMS_Reset()     'DSM
                    Fine_Cyc_Dx = False : Fine_cyc_sx = False : Ciclo_Off = False : Agg_Ultimi_Act_Sin = True
                    Msg_Tms_Dx = "" : Msg_Tms_Sx = ""
                End If

                If Ciclo_on Xor Mem_ciclo_on Then
                    If Ciclo_on Then
                        Machine_Status = "Cycle RUN"
                    Else
                        If Repos Then
                            Machine_Status = "Repos mode"
                        Else
                            Machine_Status = "Cycle STOP"
                        End If
                        'FINE a visione (Solo se opzione=True 
                    End If
                End If
                Mem_ciclo_on = Ciclo_on
                '--------- traccia DSM OLED -------
                If StatiMacchina.TracciaDSM And Not _memTraceDSM Then  'DB100.dbx23.6
                    If Sett.TMServer Then
                        'If Plc1.Read_Vals(C_IBH.nArea.DB, 800, 20, 100, _rcv) Then  'Dati stazione pressa A
                        '    _Pressa = _rcv

                        '    If Plc1.Read_Vals(C_IBH.nArea.DB, 0, 120, 10, _rcv) Then
                        '        plc_dataPressa = _rcv
                        '        plc_PressaMagazinoOLED = Convert.ToInt16(plc_dataPressa(0))
                        '        plc_PressaPosizioneOLED = Convert.ToInt16(plc_dataPressa(1))
                        '    Else
                        '        show_eccezione(Plc1.Eccezione)
                        '        _err1 = True
                        '        GoTo _ini
                        '    End If

                        '    DSM_Read_OLED(True)
                        'Else
                        '    _err1 = True
                        'End If
                    End If
                    'Plc1.Write_Val(C_IBH.PlcVar.D, 23, 100, 6, CInt(False))   ' 'DB100.dbx23.6
                    'MessageBox.Show("Traccia DSM da IMPLEMENTARE")
                End If
                _memTraceDSM = StatiMacchina.TracciaDSM
                '-------test trasmissione dati a PLC------
                If _tx_dati = True Then
                    _tx_dati = False
                    If Tx_Ricetta() Then
                        Dim arrayContaPezzi(15) As Byte
                        For i As Integer = 0 To arrayContaPezzi.Count() - 1
                            arrayContaPezzi(i) = 0
                        Next
                        Plc1.Write_Vals(C_IBH.nArea.DB, 590, 100, arrayContaPezzi.Count(), arrayContaPezzi) 'Reset Pezzi Buoni e Scarti
                        _Rx_Dati_Gen = True
                        Plc1.Write_Val(C_IBH.PlcVar.DB, 38, 100, 0, Device) 'Nuovi dati caricati
                    End If
                Else
                    If _Rx_Dati_Gen Then
                        If True Then 'Plc1.Read_Vals(C_IBH.nArea.DB, 0, 7, 102, _rcv) Then
                            'GenData = _rcv
                            'N_Viti = CInt(GenData(100))
                            N_Viti_Sx = 3
                            N_Viti_Dx = 3
                            _Rx_Dati_Gen = False : _Agg_Lay_Viti = True
                        Else
                            show_eccezione(Plc1.Eccezione)
                            _err1 = True
                            GoTo _ini
                        End If
                    End If
                End If



                If (StatiMacchina.RichiestaLetturaDatamatrixPalletDx And Not _memRichiestaLetturaDatamatrixPalletDx) Or ManualDXReadReq Then
                    ManualDXReadReq = False
                    DatamatrixMgr.EnqueueRequest(PalletSide.Destro)
                End If

                If (StatiMacchina.RichiestaLetturaDatamatrixPalletSx And Not _memRichiestaLetturaDatamatrixPalletSx) Or ManualSXReadReq Then
                    ManualSXReadReq = False
                    DatamatrixMgr.EnqueueRequest(PalletSide.Sinistro)
                End If

                _memRichiestaLetturaDatamatrixPalletDx = StatiMacchina.RichiestaLetturaDatamatrixPalletDx
                _memRichiestaLetturaDatamatrixPalletSx = StatiMacchina.RichiestaLetturaDatamatrixPalletSx

                '--------- traccia RISULTATI LETTURE DATAMATRIX SU PALLET!!!! -------
                If _inviaDMAlPLCPalletDx Then
                    _inviaDMAlPLCPalletDx = False
                    'Dim oledBytes = BuildOledBuffer(_dmPalletDx)
                    'If oledBytes IsNot Nothing Then
                    '    Plc1.Write_Vals(C_IBH.nArea.DB, 504, 100, oledBytes.Length, oledBytes)
                    'End If
                    Plc1.Write_Val(C_IBH.PlcVar.D, 43, 100, 1, CInt(True)) 'LetturaDataMatrixPalletDxEffettuata	
                End If

                If _inviaDMAlPLCPalletSx Then
                    _inviaDMAlPLCPalletSx = False
                    'Dim oledBytes = BuildOledBuffer(_dmPalletSx)
                    'If oledBytes IsNot Nothing Then
                    '    Plc1.Write_Vals(C_IBH.nArea.DB, 462, 100, oledBytes.Length, oledBytes)
                    'End If
                    Plc1.Write_Val(C_IBH.PlcVar.D, 43, 100, 0, CInt(True)) 'LetturaDataMatrixPalletSxEffettuata	
                End If

            Else
                Plc1.Disconnetti()
                Thread.Sleep(1000)
                Connesso1 = Plc1.Connetti()
                Thread.Sleep(500)
            End If
        Catch ex As Exception
            If chiudo = False Then
                Connesso1 = False : _tx_dati = False = False
                show_eccezione(ex)
                Thread.Sleep(3000)
            End If
        End Try
        _ttt = Now.Ticks - _tt
        GoTo _ini
    End Sub
    Private Sub Thread_Aux()
        Dim _inv As Boolean
        Dim _tt2 As Long
        Dim _rcv() As Byte = Nothing
        Dim n As Integer

_bb:    If chiudo Then Exit Sub
        _tt2 = Now.Ticks
        _inv = Not _inv
        Thread.Sleep(30)
        Try
            If Connesso2 Then
                If StatiMacchina.TracciaDB And Not _M_Trace_Oled Or Pulsantoso Then  'M21.6
                    Trace_Oled()
                    Plc2.Write_Val(C_IBH.PlcVar.DD, 43, 100, 2, CInt(True))   'Ordine Traccia DB
                End If
                _M_Trace_Oled = StatiMacchina.TracciaDB

                If _inv Then
                    If Plc2.Read_Vals(C_IBH.nArea.DB, 0, 90, n_bytes_all, _rcv) Then
                        Allarmi = _rcv   'DB90
                        all_nr = New BitArray(Allarmi)
                        For n = 0 To all_nr.Count - 1
                            If all_nr(n) Xor Mall_nr(n) Then    'la prima differenza
                                Registra_All(n)
                                _All_Income = True
                            End If
                        Next
                        Mall_nr = New BitArray(all_nr)
                        If _All_Income Then
                            Num_Act_All += 1
                            If Num_Act_All > 50 Then        'ogni 5 secondi
                                Num_Act_All = 0 : _All_Income = False
                                Trace_DB_All()
                            End If
                        End If

                        If N_MDI_from = 99 Then
                            If req_dati Then
                                req_dati = False : req_dati_ready = True
                            End If
                        End If
                    Else
                        show_eccezione(Plc2.Eccezione)
                        _err2 = True
                    End If

                Else
                    Select Case N_MDI_from
                        Case 0
#Region "HOME"
                        Case 1      'Home
                            If req_dati = True Then
                                req_dati = False
                                Dim _vuo As Integer
                                If Plc2.Read_Val(C_IBH.PlcVar.DW, 106, 7, 0, _vuo) Then
                                    req_dati_ready = True
                                    Soglia_Vuoto = CSng(_vuo / 1000.0!)
                                End If

                            Else
                                If (_Ord_tasti_off > 0) Or (_Ord_tasti_on > 0) Then 'test ordini
                                    _Ord_tasti_on = 0 : _Ord_tasti_off = 0
                                End If
                                If Num_Dato > 0 Then
                                    Write_01()
                                    Num_Dato = 0
                                End If
                            End If
#End Region
#Region "PAGINA MANUALI"
                        Case 6  'Manuali
                            If Automatico = False Then
                                If req_dati = True Then
                                    req_dati = False
                                    If True Then 'Plc2.Read_Vals(C_IBH.nArea.DB, 0, 100, 33, _rcv) Then
                                        'Act_Valori = _rcv
                                        req_dati_ready = True
                                    End If
                                Else
                                    If Num_Dato > 0 Then
                                        Select Case Num_Dato
                                            Case 1
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 24, 100, 1, CInt(True))   ' 'DB100.dbx24.1 IlluminazioneMagazzinoSpegni
                                            Case 2
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 24, 100, 2, CInt(True))   ' 'DB100.dbx24.2 IlluminazioneNastriAccendi
                                            Case 3
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 24, 100, 3, CInt(True))   ' 'DB100.dbx24.3 IlluminazioneNastriSpegni
                                            Case 8
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 30, 100, 1, CInt(True))   ' 'DB100.dbx30.1 MagazzinoSxTraslazioneRitornaDaOperatore
                                            Case 9
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 30, 100, 0, CInt(True))   ' 'DB100.dbx30.0 MagazzinoSxTraslazioneAvanzaVersoInterno
                                            Case 10
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 30, 100, 2, CInt(True))   ' 'DB100.dbx30.2 MagazzinoSxAsseVassoiAlza
                                            Case 11
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 30, 100, 3, CInt(True))   ' 'DB100.dbx30.3 MagazzinoSxAsseVassoiAbbassa
                                            Case 4
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 30, 100, 5, CInt(True))   ' 'DB100.dbx30.5 MagazzinoDxTraslazioneRitornaDaOperatore
                                            Case 5
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 30, 100, 4, CInt(True))   ' 'DB100.dbx30.4 MagazzinoDxTraslazioneAvanzaVersoInterno
                                            Case 6
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 30, 100, 6, CInt(True))   ' 'DB100.dbx30.6 MagazzinoDxAsseVassoiAlza
                                            Case 7
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 30, 100, 7, CInt(True))   ' 'DB100.dbx30.7 MagazzinoDxAsseVassoiAbbassa
                                            Case 12
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 25, 100, 0, CInt(True))   ' 'DB100.dbx25.0 IlluminazioneIncollaggio1Accendi
                                            Case 13
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 25, 100, 1, CInt(True))   ' 'DB100.dbx25.1 IlluminazioneIncollaggio1Spegni
                                            Case 14
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 25, 100, 2, CInt(True))   ' 'DB100.dbx25.2 IlluminazioneIncollaggio2Accendi
                                            Case 15
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 25, 100, 3, CInt(True))   ' 'DB100.dbx25.3 IlluminazioneIncollaggio2Spegni
                                            Case 16
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 26, 100, 4, CInt(True))   ' 'DB100.dbx26.4 NastroSxPalletPompaVuotoFrameFaiVuoto
                                            Case 17
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 26, 100, 5, CInt(True))   ' 'DB100.dbx26.5 NastroSxPalletPompaVuotoFrameRilascia
                                            Case 18
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 27, 100, 0, CInt(True))   ' 'DB100.dbx27.0 NastroSxPalletPompaVuotoSupportoFaiVuoto
                                            Case 19
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 27, 100, 1, CInt(True))   ' 'DB100.dbx27.1 NastroSxPalletPompaVuotoSupportoRilascia
                                            Case 20
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 27, 100, 2, CInt(True))   ' 'DB100.dbx27.2 NastroSxPalletPompaVuotoBiadesivoFaiVuoto
                                            Case 21
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 27, 100, 3, CInt(True))   ' 'DB100.dbx27.3 NastroSxPalletPompaVuotoBiadesivoRilascia
                                            Case 22
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 26, 100, 0, CInt(True))   ' 'DB100.dbx26.0 NastroSxSollevatoreLatoRobotAlza
                                            Case 23
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 26, 100, 1, CInt(True))   ' 'DB100.dbx26.1 NastroSxSollevatoreLatoRobotAbbassa
                                            Case 24
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 25, 100, 4, CInt(True))   ' 'DB100.dbx25.4 NastroSxSingolarizzatoreEsternoAbbassa
                                            Case 25
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 25, 100, 5, CInt(True))   ' 'DB100.dbx25.5 NastroSxSingolarizzatoreEsternoRitorna
                                            Case 26
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 25, 100, 6, CInt(True))   ' 'DB100.dbx25.6 NastroSxSingolarizzatoreInternoAbbassa
                                            Case 27
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 25, 100, 7, CInt(True))   ' 'DB100.dbx25.7 NastroSxSingolarizzatoreInternoRitorna
                                            Case 28
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 26, 100, 2, CInt(True))   ' 'DB100.dbx26.2 NastroSxPalletSvincoloOledSvincola
                                            Case 29
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 26, 100, 3, CInt(True))   ' 'DB100.dbx26.3 NastroSxPalletSvincoloOledRilascia
                                            Case 30
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 26, 100, 6, CInt(True))   ' 'DB100.dbx26.6 NastroSxPalletPompaVuotoOledSupportoFaiVuoto
                                            Case 31
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 26, 100, 7, CInt(True))   ' 'DB100.dbx26.7 NastroSxPalletPompaVuotoOledSupportoRilascia
                                            Case 32
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 27, 100, 4, CInt(True))   ' 'DB100.dbx27.4 NastroSxPalletAsseAvanzaVersoInterno
                                            Case 33
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 27, 100, 5, CInt(True))   ' 'DB100.dbx27.5 NastroSxPalletAsseRitornaDaOperatore
                                            Case 34
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 28, 100, 3, CInt(True))   ' 'DB100.dbx28.3 NastroDxSollevatoreLatoRobotAbbassa
                                            Case 35
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 28, 100, 2, CInt(True))   ' 'DB100.dbx28.2 NastroDxSollevatoreLatoRobotAlza
                                            Case 36
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 28, 100, 6, CInt(True))   ' 'DB100.dbx28.6 NastroDxPalletPompaVuotoFrameFaiVuoto
                                            Case 37
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 28, 100, 7, CInt(True))   ' 'DB100.dbx28.7 NastroDxPalletPompaVuotoFrameRilascia
                                            Case 38
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 29, 100, 2, CInt(True))   ' 'DB100.dbx29.2 NastroDxPalletPompaVuotoSupportoFaiVuoto
                                            Case 39
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 29, 100, 3, CInt(True))   ' 'DB100.dbx29.3 NastroDxPalletPompaVuotoSupportoRilascia
                                            Case 40
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 29, 100, 4, CInt(True))   ' 'DB100.dbx29.4 NastroDxPalletPompaVuotoBiadesivoFaiVuoto
                                            Case 41
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 29, 100, 5, CInt(True))   ' 'DB100.dbx29.5 NastroDxPalletPompaVuotoBiadesivoRilascia
                                            Case 42
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 29, 100, 0, CInt(True))   ' 'DB100.dbx29.0 NastroDxPalletPompaVuotoOledSupportoFaiVuoto
                                            Case 43
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 29, 100, 1, CInt(True))   ' 'DB100.dbx29.1 NastroDxPalletPompaVuotoOledSupportoRilascia
                                            Case 44
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 28, 100, 0, CInt(True))   ' 'DB100.dbx28.0 NastroDxSingolarizzatoreInternoAbbassa
                                            Case 45
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 28, 100, 1, CInt(True))   ' 'DB100.dbx28.1 NastroDxSingolarizzatoreInternoRitorna
                                            Case 46
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 27, 100, 6, CInt(True))   ' 'DB100.dbx27.6 NastroDxSingolarizzatoreEsternoAbbassa
                                            Case 47
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 27, 100, 7, CInt(True))   ' 'DB100.dbx27.7 NastroDxSingolarizzatoreEsternoRitorna
                                            Case 48
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 28, 100, 4, CInt(True))   ' 'DB100.dbx28.4 NastroDxPalletSvincoloOledSvincola
                                            Case 49
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 28, 100, 5, CInt(True))   ' 'DB100.dbx28.5 NastroDxPalletSvincoloOledRilascia
                                            Case 50
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 29, 100, 6, CInt(True))   ' 'DB100.dbx29.6 NastroDxPalletAsseAvanzaVersoInterno
                                            Case 51
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 29, 100, 7, CInt(True))   ' 'DB100.dbx29.7 NastroDxPalletAsseRitornaDaOperatore
                                            Case 52
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 31, 100, 6, CInt(True))   ' 'DB100.dbx31.6 InternoPurificatoreAriaAccendi
                                            Case 53
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 31, 100, 7, CInt(True))   ' 'DB100.dbx31.7 InternoPurificatoreAriaSpegni
                                            Case 54
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 32, 100, 0, CInt(True))   ' 'DB100.dbx32.0 InternoAspiratoreLinerAccendi
                                            Case 55
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 32, 100, 1, CInt(True))   ' 'DB100.dbx32.1 InternoAspiratoreLinerSpegni
                                            Case 56
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 32, 100, 2, CInt(True))   ' 'DB100.dbx32.2 InternoPlasmaAccendi
                                            Case 57
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 32, 100, 3, CInt(True))   ' 'DB100.dbx32.3 InternoPlasmaSpegni
                                            Case 58
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 24, 100, 0, CInt(True))   ' 'DB100.dbx24.0 IlluminazioneMagazzinoAccendi
                                            Case 83
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 33, 100, 0, CInt(True))   ' 'DB100.dbx33.0 InternoPompaVuotoIncollaggioOledSxFaiVuoto
                                            Case 84
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 33, 100, 1, CInt(True))   ' 'DB100.dbx33.1 InternoPompaVuotoIncollaggioOledSxRilascia
                                            Case 85
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 33, 100, 2, CInt(True))   ' 'DB100.dbx33.2 InternoPompaVuotoIncollaggioOledDxFaiVuoto
                                            Case 86
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 33, 100, 3, CInt(True))   ' 'DB100.dbx33.3 InternoPompaVuotoIncollaggioOledDxRilascia
                                            Case 93
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 32, 100, 4, CInt(True))   ' 'DB100.dbx32.4 InternoSoffioAccendi
                                            Case 94
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 32, 100, 5, CInt(True))   ' 'DB100.dbx32.5 InternoSoffioSpegni
                                            Case 95
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 32, 100, 6, CInt(True))   ' 'DB100.dbx32.6 InternoPinzaStrappoLinerChiudi
                                            Case 96
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 32, 100, 7, CInt(True))   ' 'DB100.dbx32.7 InternoPinzaStrappoLinerApri
                                        End Select
                                        Num_Dato = 0
                                    End If
                                End If
                            End If
#End Region
#Region "PARAMETRI"
                        Case 10  'Parametri
                            If req_dati = True Then
                                req_dati = False
                                If True Then 'Plc2.Read_Vals(C_IBH.nArea.DB, 0, 100, 304, _rcv) Then
                                    'Punti = _rcv
                                    Dim aro As Integer = 0
                                Else
                                    _err2 = True
                                End If
                                If True Then 'Plc2.Read_Vals(C_IBH.nArea.DB, 0, 100, 102, _rcv) Then 'Dati config generali DB7
                                    'Viti = _rcv
                                    Dim aro As Integer = 0
                                Else
                                    _err2 = True
                                End If
                                req_dati_ready = Not _err2
                            End If
#End Region
#Region "ROBOT"
                        Case 50 'Robot
                            If req_dati Then
                                req_dati = False
                                If True Then 'Plc2.Read_Vals(C_IBH.nArea.DB, 0, 115, 80, _rcv) Then
                                    'Robot = _rcv
                                    req_dati_ready = True
                                Else
                                    _err2 = True
                                End If
                            Else
                                If req_dati2 Then
                                    req_dati2 = False     'lettura one shot
                                    If True Then 'Plc2.Read_Vals(C_IBH.nArea.DB, 240, 115, 170, _rcv) Then
                                        'Punti = _rcv
                                        req_dati_ready2 = True
                                    Else
                                        _err2 = True
                                    End If
                                    req_dati_ready2 = True
                                Else
                                    If Num_Dato > 0 Then
                                        Select Case Num_Dato
                                            Case 1
                                                ' WR_Dato_32 è un Integer .NET (32 bit)
                                                ' Lo limito al range 0–255 per sicurezza
                                                Dim usintValue As Integer = WR_Dato_Short
                                                If usintValue < 0 Then usintValue = 0
                                                If usintValue > 100 Then usintValue = 100 'valore max 100%

                                                ' Scrivo un BYTE nel DB100.DBB39
                                                ' PlcVar.DB corrisponde al Case 14 del tuo Write_Val (byte in DB)
                                                Plc2.Write_Val(C_IBH.PlcVar.DB, 39, 100, 0UI, usintValue)
                                            ' -> DB100.DBB39 = usintValue (0..255)
                                            'DB100.dbw39 RobotOverride
                                            Case 200
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 31, 100, 0, CInt(True))   ' 'DB100.dbx31.0 ManoDiPresaPompaVuotoFaiVuoto
                                            Case 201
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 31, 100, 1, CInt(True))   ' 'DB100.dbx31.1 ManoDiPresaPompaVuotoRilascia
                                            Case 202
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 31, 100, 2, CInt(True))   ' 'DB100.dbx31.2 ManoDiPresaPinzaChiudi
                                            Case 203
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 31, 100, 3, CInt(True))   ' 'DB100.dbx31.3 ManoDiPresaPinzaApri
                                            Case 204
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 24, 100, 6, CInt(True))   ' 'DB100.dbx24.6 IlluminazioneManoDiPresaCalibrazioneAccendi
                                            Case 205
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 24, 100, 7, CInt(True))   ' 'DB100.dbx24.7 IlluminazioneManoDiPresaCalibrazioneSpegni
                                            Case 206
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 24, 100, 4, CInt(True))   ' 'DB100.dbx24.4 IlluminazioneOledAccendi
                                            Case 207
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 24, 100, 5, CInt(True))   ' 'DB100.dbx24.5 IlluminazioneOledSpegni
                                            Case 208
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 31, 100, 4, CInt(True))   ' 'DB100.dbx31.4 ManoDiPresaIndexAvanza
                                            Case 209
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 31, 100, 5, CInt(True))   ' 'DB100.dbx31.5 ManoDiPresaIndexRitorna
                                            Case 210
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 33, 100, 4, CInt(True))   ' 'DB100.dbx33.4 RobotDepositaManoDiPresa
                                            Case 211
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 33, 100, 5, CInt(True))   ' 'DB100.dbx33.5 RobotRaccogliManoDiPresa
                                            Case 212
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 33, 100, 7, CInt(True))   ' 'DB100.dbx33.7 RobotVaiHome
                                            Case 220
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 34, 100, 0, CInt(True))   ' 'DB100.dbx34.0 RobotPrelevaSupportoNastroSx
                                            Case 221
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 34, 100, 1, CInt(True))   ' 'DB100.dbx34.1 RobotIncollaBiadesivoSuSupportoNastroSx
                                            Case 222
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 34, 100, 2, CInt(True))   ' 'DB100.dbx34.2 RobotDepositaPezzoFinitoSuNastroSx
                                            Case 223
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 34, 100, 3, CInt(True))   ' 'DB100.dbx34.3 RobotPrelevaSupportoNastroDx
                                            Case 224
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 34, 100, 4, CInt(True))   ' 'DB100.dbx34.4 RobotIncollaBiadesivoSuSupportoNastroDx
                                            Case 225
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 34, 100, 5, CInt(True))   ' 'DB100.dbx34.5 RobotDepositaPezzoFinitoSuNastroDx
                                            Case 226
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 34, 100, 6, CInt(True))   ' 'DB100.dbx34.6 RobotDepositaOledInIncollaggio
                                            Case 227
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 34, 100, 7, CInt(True))   ' 'DB100.dbx34.7 RobotIncollaSupportoConOledInIncollaggio
                                            Case 228
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 35, 100, 0, CInt(True))   ' 'DB100.dbx35.0 RobotPrelevaOledSxMagazzinoSx
                                            Case 229
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 35, 100, 1, CInt(True))   ' 'DB100.dbx35.1 RobotPrelevaOledDxMagazzinoSx
                                            Case 230
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 35, 100, 2, CInt(True))   ' 'DB100.dbx35.2 RobotPrelevaVassoioMagazzinoSx
                                            Case 231
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 35, 100, 3, CInt(True))   ' 'DB100.dbx35.3 RobotPrelevaOledSxMagazzinoDx
                                            Case 232
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 35, 100, 4, CInt(True))   ' 'DB100.dbx35.4 RobotPrelevaOledDxMagazzinoDx
                                            Case 233
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 35, 100, 5, CInt(True))   ' 'DB100.dbx35.5 RobotPrelevaVassoioMagazzinoDx
                                            Case 234
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 35, 100, 6, CInt(True))   ' 'DB100.dbx35.6 RobotDepositaVassoioVuoto
                                            Case 235
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 35, 100, 7, CInt(True))   ' 'DB100.dbx35.7 RobotDepositaOledScartoPosizione1
                                            Case 236
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 36, 100, 0, CInt(True))   ' 'DB100.dbx36.0 RobotDepositaOledScartoPosizione2
                                            Case 237
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 36, 100, 1, CInt(True))   ' 'DB100.dbx36.1 RobotDepositaOledScartoPosizione3
                                            Case 238
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 36, 100, 2, CInt(True))   ' 'DB100.dbx36.2 RobotDepositaOledScartoPosizione4
                                            Case 239
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 36, 100, 3, CInt(True))   ' 'DB100.dbx36.3 RobotFaiCicloPlasmatura
                                            Case 240
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 36, 100, 4, CInt(True))   ' 'DB100.dbx36.4 RobotStrappaLiner
                                            Case 241
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 36, 100, 5, CInt(True))   ' 'DB100.dbx36.5 RobotRaccogliOledScartoDaIncollaggio
                                            Case 242
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 36, 100, 6, CInt(True))   ' 'DB100.dbx33.6 RobotVaiZonaCamera
                                            Case 243
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 36, 100, 7, CInt(True))   ' 'DB100.dbx36.6 RobotVaiInIonizzatura
                                            Case 244
                                                Plc2.Write_Val(C_IBH.PlcVar.D, 588, 100, 2, CInt(Wr_Bool))   ' 'DB100.dbx588.2 RimozioneLinerAbilitata
                                        End Select
                                        Num_Dato = 0
                                    End If
                                End If
                            End If
#End Region
#Region "ROBOT PUNTI"
                        Case 51 'Robot PUNTI
                            If req_dati Then
                                req_dati = False
                                If True Then 'Plc2.Read_Vals(C_IBH.nArea.DB, 0, 115, 80, _rcv) Then
                                    'Robot = _rcv
                                    req_dati_ready = True
                                Else
                                    _err2 = True
                                End If
                            Else
                                If req_dati2 Then
                                    req_dati2 = False     'lettura one shot
                                    If True Then 'Plc2.Read_Vals(C_IBH.nArea.DB, 240, 115, 170, _rcv) Then
                                        'Punti = _rcv
                                        req_dati_ready2 = True
                                    Else
                                        _err2 = True
                                    End If
                                    req_dati_ready2 = True
                                Else
                                    If Num_Dato > 0 Then
                                        Dim _2byte As Byte()
                                        _2byte = BitConverter.GetBytes(WR_Dato_Short)
                                        Dim val As Byte()
                                        val = New Byte(1) {0, 0}
                                        val(0) = _2byte(1)
                                        val(1) = _2byte(0)
                                        Select Case Num_Dato

                                        'punto robot MAGAZZINO SX VASSOIO
                                            Case 18
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 248, 100, val.Length, val)   ' DB100.DBW248 MagazzinoSxVassoio.X micrometri
                                            Case 20
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 250, 100, val.Length, val)   ' DB100.DBW250 MagazzinoSxVassoio.Y micrometri
                                            Case 22
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 252, 100, val.Length, val)   ' DB100.DBW252 MagazzinoSxVassoio.Z micrometri
                                            Case 24
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 254, 100, val.Length, val)   ' DB100.DBW254 MagazzinoSxVassoio.RotazioneZ millesimi di grado

                                        'punto robot MAGAZZINO DX VASSOIO
                                            Case 10
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 284, 100, val.Length, val)   ' DB100.DBW284 MagazzinoDxVassoio.X micrometri
                                            Case 12
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 286, 100, val.Length, val)   ' DB100.DBW286 MagazzinoDxVassoio.Y micrometri
                                            Case 14
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 288, 100, val.Length, val)   ' DB100.DBW288 MagazzinoDxVassoio.Z micrometri
                                            Case 16
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 290, 100, val.Length, val)   ' DB100.DBW290 MagazzinoDxVassoio.RotazioneZ millesimi di grado

                                        'punto robot INCOLLAGGIO
                                            Case 320
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 212, 100, val.Length, val)   ' DB100.DBW212 Incollaggio.X micrometri
                                            Case 322
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 214, 100, val.Length, val)   ' DB100.DBW214 Incollaggio.Y micrometri
                                            Case 324
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 216, 100, val.Length, val)   ' DB100.DBW216 Incollaggio.Z micrometri
                                            Case 326
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 218, 100, val.Length, val)   ' DB100.DBW218 Incollaggio.RotazioneZ millesimi di grado

                                        'punto robot OLED SX MAGAZZINO SX
                                            Case 288
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 224, 100, val.Length, val)   ' DB100.DBW224 MagazzinoSxOledSx.X micrometri
                                            Case 290
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 226, 100, val.Length, val)   ' DB100.DBW226 MagazzinoSxOledSx.Y micrometri
                                            Case 292
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 228, 100, val.Length, val)   ' DB100.DBW228 MagazzinoSxOledSx.Z micrometri
                                            Case 294
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 230, 100, val.Length, val)   ' DB100.DBW230 MagazzinoSxOledSx.RotazioneZ millesimi di grado

                                        'punto robot OLED DX MAGAZZINO SX
                                            Case 296
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 236, 100, val.Length, val)   ' DB100.DBW236 MagazzinoSxOledDx.X micrometri
                                            Case 298
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 238, 100, val.Length, val)   ' DB100.DBW238 MagazzinoSxOledDx.Y micrometri
                                            Case 300
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 240, 100, val.Length, val)   ' DB100.DBW240 MagazzinoSxOledDx.Z micrometri
                                            Case 302
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 242, 100, val.Length, val)   ' DB100.DBW242 MagazzinoSxOledDx.RotazioneZ millesimi di grado

                                        'punto robot OLED SX MAGAZZINO DX
                                            Case 272
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 260, 100, val.Length, val)   ' DB100.DBW260 MagazzinoDxOledSx.X micrometri
                                            Case 274
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 262, 100, val.Length, val)   ' DB100.DBW262 MagazzinoDxOledSx.Y micrometri
                                            Case 276
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 264, 100, val.Length, val)   ' DB100.DBW264 MagazzinoDxOledSx.Z micrometri
                                            Case 278
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 266, 100, val.Length, val)   ' DB100.DBW266 MagazzinoDxOledSx.RotazioneZ millesimi di grado


                                        'punto robot OLED DX MAGAZZINO DX
                                            Case 280
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 272, 100, val.Length, val)   ' DB100.DBW272 MagazzinoDxOledDx.X micrometri
                                            Case 282
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 274, 100, val.Length, val)   ' DB100.DBW274 MagazzinoDxOledDx.Y micrometri
                                            Case 284
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 276, 100, val.Length, val)   ' DB100.DBW276 MagazzinoDxOledDx.Z micrometri
                                            Case 286
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 278, 100, val.Length, val)   ' DB100.DBW278 MagazzinoDxOledDx.RotazioneZ millesimi di grado

                                        'punto robot PLASMA
                                            Case 328
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 344, 100, val.Length, val)   ' DB100.DBW344 Plasma.X micrometri
                                            Case 330
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 346, 100, val.Length, val)   ' DB100.DBW346 Plasma.Y micrometri
                                            Case 332
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 348, 100, val.Length, val)   ' DB100.DBW348 Plasma.Z micrometri
                                            Case 334
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 350, 100, val.Length, val)   ' DB100.DBW350 Plasma.RotazioneZ millesimi di grado

                                       'punto robot STRAPPO LINER
                                            Case 336
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 356, 100, val.Length, val)   ' DB100.DBW356 StrappoLiner.X micrometri
                                            Case 338
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 358, 100, val.Length, val)   ' DB100.DBW358 StrappoLiner.Y micrometri
                                            Case 340
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 360, 100, val.Length, val)   ' DB100.DBW360 StrappoLiner.Z micrometri
                                            Case 342
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 362, 100, val.Length, val)   ' DB100.DBW362 StrappoLiner.RotazioneZ millesimi di grado

                                        'punto robot VASSOI VUOTI
                                            Case 344
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 368, 100, val.Length, val)   ' DB100.DBW368 VassoiVuoti.X micrometri
                                            Case 346
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 370, 100, val.Length, val)   ' DB100.DBW370 VassoiVuoti.Y micrometri
                                            Case 348
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 372, 100, val.Length, val)   ' DB100.DBW372 VassoiVuoti.Z micrometri
                                            Case 350
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 374, 100, val.Length, val)   ' DB100.DBW374 VassoiVuoti.RotazioneZ millesimi di grado

                                        'punto robot POSIZIONE SCARTO 1
                                            Case 100
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 296, 100, val.Length, val)   ' DB100.DBW296 PosizioneScarto1.X micrometri
                                            Case 102
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 298, 100, val.Length, val)   ' DB100.DBW298 PosizioneScarto1.Y micrometri
                                            Case 104
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 300, 100, val.Length, val)   ' DB100.DBW300 PosizioneScarto1.Z micrometri
                                            Case 106
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 302, 100, val.Length, val)   ' DB100.DBW302 PosizioneScarto1.RotazioneZ millesimi di grado

                                        'punto robot POSIZIONE SCARTO 2
                                            Case 120
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 308, 100, val.Length, val)   ' DB100.DBW308 PosizioneScarto2.X micrometri
                                            Case 122
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 310, 100, val.Length, val)   ' DB100.DBW310 PosizioneScarto2.Y micrometri
                                            Case 124
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 312, 100, val.Length, val)   ' DB100.DBW312 PosizioneScarto2.Z micrometri
                                            Case 126
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 314, 100, val.Length, val)   ' DB100.DBW314 PosizioneScarto2.RotazioneZ millesimi di grado

                                        'punto robot POSIZIONE SCARTO 3
                                            Case 140
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 320, 100, val.Length, val)   ' DB100.DBW320 PosizioneScarto3.X micrometri
                                            Case 142
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 322, 100, val.Length, val)   ' DB100.DBW322 PosizioneScarto3.Y micrometri
                                            Case 144
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 324, 100, val.Length, val)   ' DB100.DBW324 PosizioneScarto3.Z micrometri
                                            Case 146
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 326, 100, val.Length, val)   ' DB100.DBW326 PosizioneScarto3.RotazioneZ millesimi di grado

                                        'punto robot POSIZIONE SCARTO 4
                                            Case 160
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 332, 100, val.Length, val)   ' DB100.DBW332 PosizioneScarto4.X micrometri
                                            Case 162
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 334, 100, val.Length, val)   ' DB100.DBW334 PosizioneScarto4.Y micrometri
                                            Case 164
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 336, 100, val.Length, val)   ' DB100.DBW336 PosizioneScarto4.Z micrometri
                                            Case 166
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 338, 100, val.Length, val)   ' DB100.DBW338 PosizioneScarto4.RotazioneZ millesimi di grado

                                        'punto robot MANO DI PRESA 1
                                            Case 500
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 44, 100, val.Length, val)   ' DB100.DBW44 ManoDiPresa1.X micrometri
                                            Case 502
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 46, 100, val.Length, val)   ' DB100.DBW46 ManoDiPresa1.Y micrometri
                                            Case 504
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 48, 100, val.Length, val)   ' DB100.DBW48 ManoDiPresa1.Z micrometri
                                            Case 506
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 50, 100, val.Length, val)   ' DB100.DBW50 ManoDiPresa1.RotazioneZ millesimi di grado

                                        'punto robot MANO DI PRESA 2
                                            Case 520
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 56, 100, val.Length, val)   ' DB100.DBW56 ManoDiPresa2.X micrometri
                                            Case 522
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 58, 100, val.Length, val)   ' DB100.DBW58 ManoDiPresa2.Y micrometri
                                            Case 524
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 60, 100, val.Length, val)   ' DB100.DBW60 ManoDiPresa2.Z micrometri
                                            Case 526
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 62, 100, val.Length, val)   ' DB100.DBW62 ManoDiPresa2.RotazioneZ millesimi di grado


                                        'punto robot POSIZIONE CAMERA ALTA
                                            Case 540
                                            'Plc2.Write_Val(C_IBH.nArea.DB, 56, 100, val.Length, val)   ' DB100.DBW56 PosizioneCameraAlta.X micrometri
                                            Case 542
                                            'Plc2.Write_Val(C_IBH.nArea.DB, 58, 100, val.Length, val)   ' DB100.DBW58 PosizioneCameraAlta.Y micrometri
                                            Case 544
                                            'Plc2.Write_Val(C_IBH.nArea.DB, 60, 100, val.Length, val)   ' DB100.DBW60 PosizioneCameraAlta.Z micrometri
                                            Case 546
                                            'Plc2.Write_Val(C_IBH.nArea.DB, 62, 100, val.Length, val)   ' DB100.DBW62 PosizioneCameraAlta.RotazioneZ millesimi di grado

                                        'punto robot POSIZIONE CAMERA BASSA 1
                                            Case 560
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 116, 100, val.Length, val)   ' DB100.DBW116 PosizionaCameraBassa1.X micrometri
                                            Case 562
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 118, 100, val.Length, val)   ' DB100.DBW118 PosizionaCameraBassa1.Y micrometri
                                            Case 564
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 120, 100, val.Length, val)   ' DB100.DBW120 PosizionaCameraBassa1.Z micrometri
                                            Case 566
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 122, 100, val.Length, val)   ' DB100.DBW122 PosizionaCameraBassa1.RotazioneZ millesimi di grado

                                        'punto robot POSIZIONE CAMERA BASSA 2
                                            Case 580
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 128, 100, val.Length, val)   ' DB100.DBW128 PosizionaCameraBassa2.X micrometri
                                            Case 582
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 130, 100, val.Length, val)   ' DB100.DBW130 PosizionaCameraBassa2.Y micrometri
                                            Case 584
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 132, 100, val.Length, val)   ' DB100.DBW132 PosizionaCameraBassa2.Z micrometri
                                            Case 586
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 134, 100, val.Length, val)   ' DB100.DBW134 PosizionaCameraBassa2.RotazioneZ millesimi di grado


                                        'NASTRO SX BIADESIVO
                                            Case 600
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 140, 100, val.Length, val)   ' DB100.DBW140 PalletSuNastroSxBiadesivo.X micrometri
                                            Case 602
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 142, 100, val.Length, val)   ' DB100.DBW142 PalletSuNastroSxBiadesivo.Y micrometri
                                            Case 604
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 144, 100, val.Length, val)   ' DB100.DBW144 PalletSuNastroSxBiadesivo.Z micrometri
                                            Case 606
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 146, 100, val.Length, val)   ' DB100.DBW146 PalletSuNastroSxBiadesivo.RotazioneZ millesimi di grado

                                        'NASTRO SX SUPPORTO
                                            Case 620
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 152, 100, val.Length, val)   ' DB100.DBW152 PalletSuNastroSxSupporto.X micrometri
                                            Case 622
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 154, 100, val.Length, val)   ' DB100.DBW154 PalletSuNastroSxSupporto.Y micrometri
                                            Case 624
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 156, 100, val.Length, val)   ' DB100.DBW156 PalletSuNastroSxSupporto.Z micrometri
                                            Case 626
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 158, 100, val.Length, val)   ' DB100.DBW158 PalletSuNastroSxSupporto.RotazioneZ millesimi di grado

                                         'NASTRO SX PEZZO FINITO
                                            Case 640
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 164, 100, val.Length, val)   ' DB100.DBW164 PalletSuNastroSxPezzoFinito.X micrometri
                                            Case 644
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 166, 100, val.Length, val)   ' DB100.DBW166 PalletSuNastroSxPezzoFinito.Y micrometri
                                            Case 646
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 168, 100, val.Length, val)   ' DB100.DBW168 PalletSuNastroSxPezzoFinito.Z micrometri
                                            Case 648
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 170, 100, val.Length, val)   ' DB100.DBW170 PalletSuNastroSxPezzoFinito.RotazioneZ millesimi di grado



                                        'NASTRO DX BIADESIVO
                                            Case 660
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 176, 100, val.Length, val)   ' DB100.DBW176 PalletSuNastroDxBiadesivo.X micrometri
                                            Case 662
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 178, 100, val.Length, val)   ' DB100.DBW178 PalletSuNastroDxBiadesivo.Y micrometri
                                            Case 664
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 180, 100, val.Length, val)   ' DB100.DBW180 PalletSuNastroDxBiadesivo.Z micrometri
                                            Case 666
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 182, 100, val.Length, val)   ' DB100.DBW182 PalletSuNastroDxBiadesivo.RotazioneZ millesimi di grado

                                        'NASTRO DX SUPPORTO
                                            Case 680
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 188, 100, val.Length, val)   ' DB100.DBW188 PalletSuNastroDxSupporto.X micrometri
                                            Case 682
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 190, 100, val.Length, val)   ' DB100.DBW190 PalletSuNastroDxSupporto.Y micrometri
                                            Case 684
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 192, 100, val.Length, val)   ' DB100.DBW192 PalletSuNastroDxSupporto.Z micrometri
                                            Case 686
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 194, 100, val.Length, val)   ' DB100.DBW194 PalletSuNastroDxSupporto.RotazioneZ millesimi di grado

                                         'NASTRO DX PEZZO FINITO
                                            Case 700
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 200, 100, val.Length, val)   ' DB100.DBW200 PalletSuNastroDxPezzoFinito.X micrometri
                                            Case 702
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 202, 100, val.Length, val)   ' DB100.DBW202 PalletSuNastroDxPezzoFinito.Y micrometri
                                            Case 704
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 204, 100, val.Length, val)   ' DB100.DBW204 PalletSuNastroDxPezzoFinito.Z micrometri
                                            Case 706
                                                Plc2.Write_Vals(C_IBH.nArea.DB, 206, 100, val.Length, val)   ' DB100.DBW206 PalletSuNastroDxPezzoFinito.RotazioneZ millesimi di grado

                                        End Select
                                        Num_Dato = 0
                                    End If
                                End If
                            End If
#End Region
                        Case 99 'Allarmi
                            If req_dati = True Then
                                req_dati = False

                                req_dati_ready = True
                            End If
                        Case Else

                    End Select
                End If
            Else
                Plc2.Disconnetti()
                Thread.Sleep(1000)
                Connesso2 = Plc2.Connetti()
                Thread.Sleep(500)
            End If
        Catch ex As Exception
            If chiudo = False Then
                Connesso2 = False
                show_eccezione(ex)
                Thread.Sleep(3000)
            End If
        End Try
        _ttt2 = Now.Ticks - _tt2
        GoTo _bb
    End Sub
    Private Sub TH_init()
        Thread.Sleep(500)
_aa:    If chiudo Then Exit Sub
        Thread.Sleep(200)
        If Init_opzio = False Then GoTo _aa
        Try
            Stop_TMS()
            'MessageBox.Show("PRONTO")
            If Carica_Active(Sett.Id_Modello, Sett.Id_Tool) Then
                _Rx_Dati_Gen = True
                _mostramelo = True
            End If
            Run_TMS()
            '--------------VISIONE------------
            Sett.Contr_visione = True : Visione_si = True
            Step_vis = 1
            If Visione_si = True Then
                ok_visione = Init_visione()  'ok_visione= true
            Else
                release_visione()
                ok_visione = False
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Init_opzio = False
            Thread.Sleep(6000)
        End Try
        Init_opzio = False : New_Init_Option = True
        If chiudo = False Then GoTo _aa
    End Sub

    Private Sub Toll_CelleCarico_Click(sender As Object, e As EventArgs) Handles Toll_CelleCarico.Click
        If N_MDI_from = 83 Then Exit Sub
        kill_mdi_forms()
        If F_celleCarico Is Nothing Then
            F_celleCarico = New Form_celleCarico
        Else
            If F_celleCarico.IsDisposed Then
                F_celleCarico = New Form_celleCarico
            End If
        End If
        F_celleCarico.MdiParent = Me
        F_celleCarico.Show()
    End Sub

    Private Function Tx_Ricetta() As Boolean
        Try
            'Return True
            Dim _rcv() As Byte = Nothing
            Dim scalaturaXYZ As Double = 1000
            Dim scalatoraRotazione As Double = 1000
            'Mi rileggo tutto il DB
            Plc1.Read_Vals(C_IBH.nArea.DB, 0, 100, _DB100_Length, _rcv)

            Dim temp(_rcv.Length - 1) As Byte
            Array.Copy(_rcv, temp, _rcv.Length)

            ' Patch chirurgico (startByte = offset del punto)
            'NOTA: mano di presa 1 e 2 ME NE FOTTO
            Dim manoDiPresa1 As New RobotPoint
            Dim manoDiPresa2 As New RobotPoint
            Dim plasma As New RobotPoint
            WriteRobotPointIntoBlock(temp, 44, manoDiPresa1, xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)
            WriteRobotPointIntoBlock(temp, 56, manoDiPresa2, xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)
            WriteRobotPointIntoBlock(temp, 344, plasma, xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)

            Dim oledScarto1 As New RobotPoint
            Dim oledScarto2 As New RobotPoint
            Dim oledScarto3 As New RobotPoint
            Dim oledScarto4 As New RobotPoint
            WriteRobotPointIntoBlock(temp, 296, oledScarto1, xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)
            WriteRobotPointIntoBlock(temp, 308, oledScarto2, xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)
            WriteRobotPointIntoBlock(temp, 320, oledScarto3, xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)
            WriteRobotPointIntoBlock(temp, 332, oledScarto4, xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)

            Dim strappoLiner As New RobotPoint
            Dim vassoiVuoti As New RobotPoint
            WriteRobotPointIntoBlock(temp, 356, strappoLiner, xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)
            WriteRobotPointIntoBlock(temp, 368, vassoiVuoti, xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)

            Dim cameraBassa1 As RobotPoint = Visioni_Attuali.Where(Function(x) x.VisionOrderId = 2).Select(Function(x) x.RobotPoint).FirstOrDefault() 'PREORIENTAMENTO
            Dim cameraBassa2 As RobotPoint = Visioni_Attuali.Where(Function(x) x.VisionOrderId = 3).Select(Function(x) x.RobotPoint).FirstOrDefault() 'QUALITA'
            If (cameraBassa1 Is Nothing) Or (cameraBassa2 Is Nothing) Then
                show_eccezione(New Exception("Errore nei punti di posizionamento camere basse. Controllare le configurazioni delle visioni."))
                Return False
            End If
            WriteRobotPointIntoBlock(temp, 116, cameraBassa1, xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)
            WriteRobotPointIntoBlock(temp, 128, cameraBassa2, xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)

            WriteRobotPointIntoBlock(temp, 140, Prodotto_Act.PalletNastroSxConfiguration.PuntoPrelievoAdesivo, xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)

            WriteRobotPointIntoBlock(temp, 152, Prodotto_Act.PalletNastroSxConfiguration.PuntoPrelievoSupporto, xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)

            WriteRobotPointIntoBlock(temp, 164, Prodotto_Act.PalletNastroSxConfiguration.PuntoDepositoOled, xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)

            WriteRobotPointIntoBlock(temp, 176, Prodotto_Act.PalletNastroDxConfiguration.PuntoPrelievoAdesivo, xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)

            WriteRobotPointIntoBlock(temp, 188, Prodotto_Act.PalletNastroDxConfiguration.PuntoPrelievoSupporto, xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)

            WriteRobotPointIntoBlock(temp, 200, Prodotto_Act.PalletNastroDxConfiguration.PuntoDepositoOled, xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)

            WriteRobotPointIntoBlock(temp, 212, Prodotto_Act.PuntoIncollaggio, xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)

            'Magazzino A => SX
            'MagazzinoSxOledSx
            WriteRobotPointIntoBlock(temp, 224, Prodotto_Act.MagazinA.RobotPoints(0), xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)
            'MagazzinoSxOledDx
            WriteRobotPointIntoBlock(temp, 236, Prodotto_Act.MagazinA.RobotPoints(1), xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)
            'MagazzinoSxVassoio
            WriteRobotPointIntoBlock(temp, 248, Prodotto_Act.MagazinA.RobotPoints(2), xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)

            'Magazzino B >= DX
            'MagazzinoDxOledSx
            WriteRobotPointIntoBlock(temp, 260, Prodotto_Act.MagazinB.RobotPoints(0), xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)
            'MagazzinoDxOledDx
            WriteRobotPointIntoBlock(temp, 272, Prodotto_Act.MagazinB.RobotPoints(1), xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)
            'MagazzinoDxVassoio
            WriteRobotPointIntoBlock(temp, 284, Prodotto_Act.MagazinB.RobotPoints(2), xyzScale:=scalaturaXYZ, rotScale:=scalatoraRotazione)


            WriteScrewPointIntoBlock(temp, 416, Prodotto_Act.ScrewingStationConfiguration.PalletNastroSxScrewPoints.Where(Function(x) x.Order = 1).First())
            WriteScrewPointIntoBlock(temp, 422, Prodotto_Act.ScrewingStationConfiguration.PalletNastroSxScrewPoints.Where(Function(x) x.Order = 2).First())
            WriteScrewPointIntoBlock(temp, 428, Prodotto_Act.ScrewingStationConfiguration.PalletNastroSxScrewPoints.Where(Function(x) x.Order = 3).First())

            WriteScrewPointIntoBlock(temp, 434, Prodotto_Act.ScrewingStationConfiguration.PalletNastroDxScrewPoints.Where(Function(x) x.Order = 1).First())
            WriteScrewPointIntoBlock(temp, 440, Prodotto_Act.ScrewingStationConfiguration.PalletNastroDxScrewPoints.Where(Function(x) x.Order = 2).First())
            WriteScrewPointIntoBlock(temp, 446, Prodotto_Act.ScrewingStationConfiguration.PalletNastroDxScrewPoints.Where(Function(x) x.Order = 3).First())

            WriteUSIntS7(temp, 408, Prodotto_Act.PalletNastroSxConfiguration.DeviceCode)
            WriteUSIntS7(temp, 409, Prodotto_Act.PalletNastroDxConfiguration.DeviceCode)

            ' Riscrivo tutto il DB
            Plc1.Write_Vals(C_IBH.nArea.DB, 0, 100, temp.Length, temp)

            Plc1.Write_Val(C_IBH.PlcVar.D, 588, 100, 0, CInt(PreorientamentoAbilitato))
            Plc1.Write_Val(C_IBH.PlcVar.D, 588, 100, 1, CInt(Prodotto_Act.LetturaDatamatrixPcbAbilitato))

        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Pict_run2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Pulsantosissimo.Click

        Pulsantoso = True

    End Sub

    Private Sub Msg_text_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Msg_text.DoubleClick

    End Sub

#Region "Timers"
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        _clk = Not _clk

        If Spegni Or Spegni Then
            Timer1.Enabled = False : Timer1.Stop()
            Me.Close()
        End If
        C_Timer1 += 1
        If C_Timer1 > 7 Then
            C_Timer1 = 0
            If Lab_Logo.ImageIndex = 0 Then
                Lab_Logo.ImageIndex = 1
            Else
                If Lab_Logo.ImageIndex = 1 Then
                    Lab_Logo.ImageIndex = 2
                Else
                    Lab_Logo.ImageIndex = 0
                End If
            End If
        End If
        '-------------report files ----------------------
        If Fine_Cyc_Dx And Fine_cyc_sx Then
            Fine_Cyc_Dx = False : Fine_cyc_sx = False : Fine_Cyc_Totale = True : Ciclo_Off = True
            Timer5.Start()
            Timer5.Enabled = True       'Scrivi Files Report
        End If
        '--------messaggio di stato---
        If Automatico Then
            If Ciclo_Run Then
                Lab_stato.Text = "CICLO RUN" : Lab_stato.BackColor = Color.Red ' "CICLO ON"
            Else
                Lab_stato.Text = "CICLO STOP" : Lab_stato.BackColor = Color.Red ' "AUTOMATICO"
            End If
        Else
            Lab_stato.Text = "MANUALE" : Lab_stato.BackColor = Color.Lime '"MANUALE"
        End If
        '---
        If Log_1 = True Then
            If Log_4 Then
                Lab_log.Text = "4"
            Else
                If Log_3 Then
                    Lab_log.Text = "3"
                Else
                    If Log_2 Then
                        Lab_log.Text = "2"
                    Else
                        Lab_log.Text = "1"
                    End If
                End If
            End If
            Lab_log.Visible = _clk
        Else
            Lab_log.Visible = False
        End If

        If Connesso1 = True Then
            Pict_run1.Visible = _clk
        Else
            Pict_run1.Visible = False
        End If

        If Connesso2 = True Then
            Pict_run2.Visible = _clk
        Else
            Pict_run2.Visible = False
        End If

        If PLC_alarm = True Then
            If _clk = True Then
                Tool_alarm.BackColor = Color.Yellow
            Else
                Tool_alarm.BackColor = Color.Gainsboro
            End If
        Else
            Tool_alarm.BackColor = Color.AliceBlue
        End If

        '----------attualizza dati reali---------------

        '-----------scroll display status------
        status_change = CULng(BitConverter.ToUInt64(BytesMessaggiPLC, 0))
        If status_change <> Mem_status Then
            Scroll_text()
        End If
        Mem_status = status_change
        If (Msg_text.TextLength > 2) Or (_ERR = True) Then
            If _clk = True Then
                Msg_text.BackColor = Color.Pink
            Else
                Msg_text.BackColor = Color.Beige
            End If
        Else
            Msg_text.BackColor = Color.Beige
        End If
        '------------------------------------------------------------------------------------------
        Pict_cam.Visible = ok_visione
        '----------
        If Max_Gap_m And Not _clk Then
            Max_Gap = False
        End If
        Max_Gap_m = Max_Gap And _clk

        P_TMSRV.Visible = Sett.TMServer
        If Not (TMSRV Is Nothing) And TMSRV_Live Then
            P_TMSRV.BackColor = Color.WhiteSmoke
        Else
            P_TMSRV.BackColor = Color.Red
        End If

        P_DB.Visible = Sett.Trace_Sql
        '  If SQL_Live Then
        '      P_DB.BackColor = Color.White
        '  Else
        '      P_DB.BackColor = Color.Red
        '  End If

        If _mostramelo Then
            _mostramelo = False
            Show_home()
        End If


        If _mostramiSinottico Then
            _mostramiSinottico = False

            If F_Staz_1_2 Is Nothing OrElse F_Staz_1_2.IsDisposed Then
                F_Staz_1_2 = New Form_sinottico()
                'AddHandler F_Staz_1_2.ScanCompleted, AddressOf OnScanCompleted
            End If

            F_Staz_1_2.SetSide(_ultimaDirezioneDelSinottico)
            'F_Staz_1_2.MdiParent = Me
            'F_Staz_1_2.Show(Me)
            'F_Staz_1_2.BringToFront()
        End If

    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Not Max_Gap Then
            If (_ttt / 10000) > 120 Then
                Lab_th.BackColor = Color.Red : Max_Gap = True
            Else
                If (_ttt / 10000) > 100 Then
                    Lab_th.BackColor = Color.Yellow
                Else
                    Lab_th.BackColor = Color.WhiteSmoke
                End If
            End If
            Lab_th.Text = (_ttt / 10000L).ToString("000")
        End If
        Lab_th2.Text = (_ttt2 / 10000L).ToString("000")       'Secondo thread

        Tool_manuali.Enabled = Log_1 And (Not Automatico)
        Tool_magazz.Enabled = (Not Automatico)
        Tool_versione.Enabled = Log_1
        Tool_Parametri.Enabled = Log_2
        ToolStrip1.Enabled = Not Init_opzio ' And Hide_tool = False

        Lab_titolo.Text = PaginaAperta

        If HoLettoDM_DX Then
            HoLettoDM_DX = False
            DatamatrixMgr.SubmitScan(ScannedDM_Text)
        End If

        If HoLettoDM_SX Then
            HoLettoDM_SX = False
            DatamatrixMgr.SubmitScan(ScannedDM_Text)
        End If
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Log_4 Then Exit Sub
        Timer3.Enabled = False
        Log_1 = False : Log_2 = False : Log_3 = False
        Vis_Log_Level(0)
        If Sett.TMServer Then
            If Not TMSRV Is Nothing Then
                TMSRV.EnableLogFile = False
            End If
        End If
        Dim _RTV As DialogResult
        Dim _FF As New Form_PopUp_YN
        _FF._Canc = False : _FF._Ok = True : _FF._Label = "Password scaduta"
        _RTV = _FF.ShowDialog
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        '--------- ogni 4 secondi -----
        Timer5.Stop() : Timer5.Enabled = False

        If Not PZ_dx_no Then     ' 'manca pezzo o err lettura RFID
            ' Report_h_dx()
            ' Report_c_dx()
            ' Report_t_dx()
            ' Report_Corr_dx()
            ' Report_Pico_dx()
            ' Report_Lin_Dx()
            ' Report_Visioni_dx()
            ' Report_OffB_Dx()
            If Sett.Trace_Sql Then
                ' Popola_DB_Product(False)
                'Popola_DB_Altezze(False)
                'Popola_DB_Componenti(False)
                'Popola_DB_Tenute(False)
                'Popola_DB_Corr(False)
                'Popola_DB_Matrix(False)
            End If
        End If

        If Sett.Trace_Sql Then
            If CycOn_Dato Then
                'ScriviDatiSQL()
            End If
            'Clear_DB_Tab()
        End If
        CycOn_Dato = False

        If TMS_Dx_Ok Then
            TMS_Dx_Ok = False
            'TMS_Report(Cod_matr_dx, False, Tutto_Buono_dx)
        End If
        If TMS_sx_Ok Then
            TMS_sx_Ok = False
            'TMS_Report(Cod_matr_sx, True, Tutto_Buono_sx)
        End If
        '----------------------------------------
    End Sub
#End Region


#Region "Cicli Master Test"
    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Try
            _Togg_30_sec = Not _Togg_30_sec
            If Now.Hour <> Sett.Ore_macchina Then
                Sett.Ore_macchina = Now.Hour
                Salva_Sett = True
            Else

            End If
            '/----------master test
            Act_Giorno = Now.Day
            If (Act_Giorno <> Sett.Giorno) Then
                Sett.Giorno = Act_Giorno
                Sett.N_test = 0
                Salva_Sett = True
            End If

            If _Togg_30_sec Then
                Select Case Now.Hour


                End Select
            Else
                If Ord_Piastra_Save Then
                    Ord_Piastra_Save = False

                Else
                    If Salva_Sett Then
                        Salva_Sett = False
                        write_xml(Articoli_dir & "sett.txt", Sett)
                    End If
                End If
            End If
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub


#End Region
    Private Sub Load_pw()
        Dim _bann As String = Microsoft.VisualBasic.FileIO.SpecialDirectories.Temp & "\PP"
        Try
            If File.Exists(_bann) Then
                Dim _righe() As String
                _righe = File.ReadAllLines(Microsoft.VisualBasic.FileIO.SpecialDirectories.Temp & "\PP")
                _PW1 = _righe(0)
            Else
                _PW1 = "1111"
            End If
        Catch ex As Exception
            _PW1 = "1111"
            '  show_eccezione(ex)
        End Try
    End Sub
    Private Sub Write_Mag()
        Dim _by() As Byte
        Try
            Select Case Num_Dato
                Case 8, 16, 24, 34, 38, 66, 74, 84, 88
                    _by = BitConverter.GetBytes(WR_Dato_R)
                    Array.Reverse(_by)
                  '  Serv_net2.DotNetWriteVals(DB, Num_Dato, 120, 4, _by) 'scrivi DB120 da byte 16 per 26 bytes

                Case 30, 32, 80, 82
                    _by = BitConverter.GetBytes(CShort(WR_Dato_32)) '16 bit
                    Array.Reverse(_by)
                    '  Serv_net2.DotNetWriteVals(DB, Num_Dato, 120, 2, _by)
                Case Else
                    WR_Dato_R = 0.0 : WR_Dato_32 = 0

            End Select
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
    Private Shared Function OnAssemblyResolve(sender As Object, e As ResolveEventArgs) As Assembly
        Dim name = New AssemblyName(e.Name)
        'Debug.WriteLine(name.Name)
        Dim path As String = System.IO.Path.Combine(Environment.CurrentDirectory, "Visione", name.Name & ".dll")
        Try
            If System.IO.File.Exists(path) Then
                Return Assembly.LoadFile(path)
            End If
        Catch ex As Exception
            show_eccezione(ex)
        End Try
        Return Nothing
    End Function

    Private Sub Scroll_text()
        Dim i As Integer
        Try
            Msg_text.Clear()
            Dim _MS() As Byte = BitConverter.GetBytes(status_change)
            Dim Msg As BitArray = New BitArray(_MS)
            For i = 0 To Msg.Count - 1
                If Msg(i) = True Then
                    Msg_text.AppendText(testi(i + 1) & vbCrLf)
                End If
            Next i
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub

    Private Function Read_Values() As Boolean
        Dim _4bytes(3), _2bytes(1) As Byte
        Try
            Override = StatiMacchina.RobotOverrideValue
            All_Robot = 0
            Act_M_Robot = StatiMacchina.RobotCodiceMissioneInCorso

            'TODO COMPLETARE
            '_2bytes(1) = Rd_stati(62) : _2bytes(0) = Rd_stati(63)
            'Act_Vuoto_A = BitConverter.ToInt16(_2bytes, 0) / 1000.0!
            '_2bytes(1) = Rd_stati(64) : _2bytes(0) = Rd_stati(65)
            'Act_Vuoto_B = BitConverter.ToInt16(_2bytes, 0) / 1000.0!

            '' ParMiss = CInt(Rd_stati(36))
            '_4bytes(3) = Rd_stati(70) : _4bytes(2) = Rd_stati(71) : _4bytes(1) = Rd_stati(72) : _4bytes(0) = Rd_stati(73)
            'Act_X = BitConverter.ToSingle(_4bytes, 0)
            '_4bytes(3) = Rd_stati(74) : _4bytes(2) = Rd_stati(75) : _4bytes(1) = Rd_stati(76) : _4bytes(0) = Rd_stati(77)
            'Act_y = BitConverter.ToSingle(_4bytes, 0)
            '_4bytes(3) = Rd_stati(78) : _4bytes(2) = Rd_stati(79) : _4bytes(1) = Rd_stati(80) : _4bytes(0) = Rd_stati(81)
            'Act_z = BitConverter.ToSingle(_4bytes, 0)
            'Act_Vite = CInt(Rd_stati(37))

        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function

#Region "Write"
    Private Sub Write_01()
        Try
            Select Case Num_Dato
                Case 1
                    Dim arrayContaPezzi(7) As Byte
                    For i As Integer = 0 To arrayContaPezzi.Count() - 1
                        arrayContaPezzi(i) = 0
                    Next
                    Plc2.Write_Vals(C_IBH.nArea.DB, 590, 100, arrayContaPezzi.Count(), arrayContaPezzi) 'Reset Pezzi Buoni
                Case 2
                    Dim arrayContaPezzi(7) As Byte
                    For i As Integer = 0 To arrayContaPezzi.Count() - 1
                        arrayContaPezzi(i) = 0
                    Next
                    Plc2.Write_Vals(C_IBH.nArea.DB, 598, 100, arrayContaPezzi.Count(), arrayContaPezzi) 'Reset Pezzi Scarti
                Case 3
                    Plc2.Write_Val(C_IBH.PlcVar.D, 588, 100, 1, CInt(Wr_Bool))   ' 'DB100.dbx588.1 LetturaDatamatrixPcbAbilitato
                Case Else

            End Select
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
    Private Sub Write_50()
        Try
            Select Case Num_Dato
                Case 1
                    Plc2.Write_Val(C_IBH.PlcVar.DB, 25, 100, 0, WR_Dato_32)
                Case 2
                    Plc2.Write_Val(C_IBH.PlcVar.DW, 74, 115, 0, WR_Dato_32)
                Case 3
                    Plc2.Write_Val(C_IBH.PlcVar.DW, 76, 115, 0, WR_Dato_32)
                Case 4
                    Plc2.Write_Val(C_IBH.PlcVar.DW, 78, 115, 0, WR_Dato_32)
                Case 100
                    Plc2.Write_Val(C_IBH.PlcVar.M, 82, 0, 0, CInt(True))    'Lancio Missione TEST PINZA
                Case 270 To 342
                    Plc2.Write_Val(C_IBH.PlcVar.DW, Num_Dato, 115, 0, WR_Dato_32)


            End Select
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub

    Private Sub F_main_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub
#End Region
#Region "SCRITTURA PUNTI"
    Private Sub WriteIntS7(ByVal buffer As Byte(), ByVal offset As Integer, ByVal value As Short)
        Dim b = BitConverter.GetBytes(value) ' little-endian su Windows
        'If BitConverter.IsLittleEndian Then Array.Reverse(b) ' -> big-endian Siemens

        buffer(offset) = b(1)
        buffer(offset + 1) = b(0)
    End Sub

    'Se fai scaling (×1000 ecc.) rischi di sforare ±32767.
    Private Function ToInt16Clamped(ByVal v As Double) As Short
        If v > Short.MaxValue Then Return Short.MaxValue
        If v < Short.MinValue Then Return Short.MinValue
        Return CShort(Math.Round(v))
    End Function

    Private Function ScaleToInt16(ByVal value As Single, ByVal scale As Double) As Short
        Return ToInt16Clamped(CDbl(value) * scale)
    End Function

    'Private Sub WritePuntoIntoBlock(
    'ByVal blockBytes As Byte(),
    'ByVal startByte As Integer,
    'ByVal p As PuntoRobotUDT,
    'Optional ByVal scaleXYZ As Double = 1.0,
    'Optional ByVal scaleRot As Double = 1.0
    ')
    '    Const PuntoSize As Integer = 12
    '    If blockBytes Is Nothing Then Throw New ArgumentNullException(NameOf(blockBytes))
    '    If startByte < 0 OrElse startByte + PuntoSize > blockBytes.Length Then
    '        Throw New ArgumentOutOfRangeException(NameOf(startByte), "Il punto sfora i limiti del buffer.")
    '    End If

    '    ' Layout PLC:
    '    ' X @ +0, Y @ +2, Z @ +4, RotZ @ +6, RotY @ +8, RotX @ +10
    '    WriteIntS7(blockBytes, startByte + 0, ToInt16Clamped(p.X * scaleXYZ))
    '    WriteIntS7(blockBytes, startByte + 2, ToInt16Clamped(p.Y * scaleXYZ))
    '    WriteIntS7(blockBytes, startByte + 4, ToInt16Clamped(p.Z * scaleXYZ))
    '    WriteIntS7(blockBytes, startByte + 6, ToInt16Clamped(p.RotazioneZ * scaleRot))
    '    WriteIntS7(blockBytes, startByte + 8, ToInt16Clamped(p.RotazioneY * scaleRot))
    '    WriteIntS7(blockBytes, startByte + 10, ToInt16Clamped(p.RotazioneX * scaleRot))
    'End Sub

    Private Sub WriteRobotPointIntoBlock(
    ByVal blockBytes As Byte(),
    ByVal startByte As Integer,
    ByVal rp As RobotPoint,
    Optional ByVal xyzScale As Double = 1000.0,   ' mm -> microm
    Optional ByVal rotScale As Double = 10000.0   ' gradi -> 0.0001°
)
        Const PuntoSize As Integer = 12
        If blockBytes Is Nothing Then Throw New ArgumentNullException(NameOf(blockBytes))
        If rp Is Nothing Then Throw New ArgumentNullException(NameOf(rp))
        If startByte < 0 OrElse startByte + PuntoSize > blockBytes.Length Then
            Throw New ArgumentOutOfRangeException(NameOf(startByte), "Il punto sfora i limiti del buffer.")
        End If

        ' XYZ
        WriteIntS7(blockBytes, startByte + 0, ScaleToInt16(rp.X, xyzScale))
        WriteIntS7(blockBytes, startByte + 2, ScaleToInt16(rp.Y, xyzScale))
        WriteIntS7(blockBytes, startByte + 4, ScaleToInt16(rp.Z, xyzScale))

        ' Rotazioni: PLC salva Z, Y, X
        WriteIntS7(blockBytes, startByte + 6, ScaleToInt16(rp.RotazioneZ, rotScale))
        WriteIntS7(blockBytes, startByte + 8, ScaleToInt16(rp.RotazioneY, rotScale))
        WriteIntS7(blockBytes, startByte + 10, ScaleToInt16(rp.RotazioneX, rotScale))
    End Sub


#End Region

#Region "SCRITTURA VITI"
    Private Sub WriteScrewPointIntoBlock(
    ByVal blockBytes As Byte(),
    ByVal startByte As Integer,
    ByVal sp As ScrewPoint,
    Optional ByVal scale As Double = 1.0 ' default: mm -> microm (modifica se serve)
)
        Const SizeBytes As Integer = 6 ' 3 INT
        If blockBytes Is Nothing Then Throw New ArgumentNullException(NameOf(blockBytes))
        If sp Is Nothing Then Throw New ArgumentNullException(NameOf(sp))
        If startByte < 0 OrElse startByte + SizeBytes > blockBytes.Length Then
            Throw New ArgumentOutOfRangeException(NameOf(startByte), "La struttura sfora i limiti del buffer.")
        End If

        ' Mapping richiesto:
        ' X -> R1, Y -> R2, Z -> H
        WriteIntS7(blockBytes, startByte + 0, ScaleToInt16(sp.X, scale)) ' R1
        WriteIntS7(blockBytes, startByte + 2, ScaleToInt16(sp.Y, scale)) ' R2
        WriteIntS7(blockBytes, startByte + 4, ScaleToInt16(sp.Z, scale)) ' H
    End Sub

#End Region

    Private Sub WriteUSIntS7(ByVal buffer As Byte(), ByVal offset As Integer, ByVal value As Integer)
        If value < 0 OrElse value > 255 Then
            Throw New ArgumentOutOfRangeException(NameOf(value), "USInt deve essere compreso tra 0 e 255.")
        End If

        buffer(offset) = CByte(value)
    End Sub



End Class




Imports System.Data
Imports Saiee.AutomationSuite.VisionCore.Graphics
Imports System.Threading.Tasks
Imports Saiee.AutomationSuite.VisionCore.Graphics.Events
Imports System.Linq

Friend Module Mod_visione
    Private _Not_ErVis As Boolean
    Friend WithEvents Vision_GM As GraphicsManagerInterface

    Friend SimulaStep1 As Boolean
    Friend SimulaStep2 As Boolean
    Friend SimulaStep3 As Boolean
    Friend SimulaStep4 As Boolean

    ' Friend WithEvents Visione As FProgVision
    Friend _n_visioni As Integer = 4
    Friend ok_visione, _err_TLC, _agg_visione, Track_visione, Ord_Illum_dx, Ord_Illum_sx As Boolean
    Friend Visione_si As Boolean = False
    Friend VisErrTxt As String
    Friend Modello_Vis, Tool_Vis As String
    Friend Step_vis, PLC_Id_Vis, Mask_Illum_dx, Mask_Illum_sx, _n_Sim As Integer
    Friend _test_vis_SX, Tst_Tlc_Anim, _Sim_Vis As Boolean
    Friend _ind_vis_dx, _ind_vis_sx As Integer                       '24 visioniAs Integer
    Friend Tot_T_Vis_Dx, Tot_T_Vis_Sx As Long
    'Friend    Fine_vis_dx, Clear_Wip_dx,   Clr_Busy_Dx, Tracing_DX As Boolean
    Friend Fine_visione, Tracing_DX, Tracing_SX As Boolean
    Friend m_vis(_n_visioni), Run_vis(_n_visioni), Hold_foto(_n_visioni), Fine_Vis(_n_visioni), Buono_Vis(_n_visioni, 4), Scarto_Visione(_n_visioni), OrientamentoVisioneAltaFuoriLimiti, OrientamentoVisioneBassaFuoriLimiti As Boolean
    Friend _memTraceDSM As Boolean
    Friend Answ_Dati(_n_visioni) As List(Of Dictionary(Of String, KeyValuePair(Of Type, Object)))
    Friend _dx, _dy, _dz, _da As Double
    Friend DMX_A, DMX_B, DM_Oled As String
    Friend OLED_Date As DateTime

    Friend PreorientamentoAbilitato As Boolean = True

    Friend Visione_x_Limit_Lower As Double = -30.0
    Friend Visione_x_Limit_Upper As Double = 30.0
    Friend Visione_y_Limit_Lower As Double = -30.0
    Friend Visione_y_Limit_Upper As Double = 30.0
    Friend Visione_angle_Limit_Lower As Double = -3.0
    Friend Visione_angle_Limit_Upper As Double = 3.0

    <Serializable()> Public Structure CorrezioneVisione
        Public Z As Double                 '[mm]
        Public Y As Double                 '[mm]
        Public X As Double                 '[mm]
        Public RotazioneZ As Double        '[gradi]
    End Structure
    Friend CorrezioneVisioneAlta As CorrezioneVisione
    Friend CorrezioneVisioneBassa As CorrezioneVisione

    Friend Function Init_visione() As Boolean
        _Not_ErVis = True
        Step_vis = 0 : DM_Oled = ""
        Try
            Modello_Vis = "Model" & Sett.Id_Modello.ToString("00")
            Tool_Vis = "Tool" & Sett.Id_Tool.ToString("00")
            If Vision_GM Is Nothing Then
                'LAPTOP-TUOE5K4Q\SQLEXPRESS
                'Vision_GM = New GraphicsManagerInterface("LAPTOP-TUOE5K4Q\SQLEXPRESS", "sa", "saiee35227")  'n. step [0..]
                Vision_GM = New GraphicsManagerInterface(Trace_Db_Server, Trace_Db_User, Trace_Db_Pw, Trace_Db_Name)  'n. step [0..]
                If Not Vision_GM.Init(Sett.Language) Then
                    _Not_ErVis = False
                Else
                    If Sett.n_posaggi < -1 Then
                        Sett.n_posaggi = 2
                        Vision_GM.CreateTestDBData()
                        Vision_GM.CreateConfigDBData()
                        Salva_Sett = True
                    End If
                End If
            End If
            If _Not_ErVis Then
                If Not Vision_GM.LoadModelAndTool(Modello_Vis, Tool_Vis) Then 'If Not Vision_GM.LoadModelAndTool(Sett.modello, Sett.n_piastra.ToString) Then
                    _Not_ErVis = False
                End If
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return _Not_ErVis
    End Function

    Friend Sub Vis_Log_Level(ByVal _log As Integer)
        Try
            If Vision_GM IsNot Nothing Then
                Vision_GM.VUC_Login(_log)
            End If
        Catch ex As Exception
            show_eccezione("[ ERRORE VISIONE: VUC_Login ]" & ex.ToString)
        End Try
    End Sub
    Friend Function Display_visione(ByVal _GB As GroupBox) As Boolean
        Try
            _GB.Controls.Add(Control.FromHandle(CType(Vision_GM.VUC_GetHandle, IntPtr)))
            Vision_GM.VUC_Visible(True, _GB.Size.Width, _GB.Size.Height)
        Catch ex As Exception
            show_eccezione("[ ERRORE VISIONE: VUC_GetHandle ]" & ex.ToString)
            Return False
        End Try
        Return True
    End Function
    Friend Function Hide_visione(ByVal _GB As GroupBox) As Boolean
        Try
            Vision_GM.VUC_Visible(False, _GB.Size.Width, _GB.Size.Height)
            _GB.Controls.Remove(Control.FromHandle(CType(Vision_GM.VUC_GetHandle, IntPtr)))
        Catch ex As Exception
            show_eccezione("[ ERRORE VISIONE: VUC_GetHandle ]" & ex.ToString)
        End Try
        Return True
    End Function
    Friend Function tlc_set_file(ByVal _Step As Integer, ByVal _mod As Boolean, _Sub As Integer) As Boolean
        Try
            If Vision_GM Is Nothing Then
                show_eccezione("[ ERRORE VISIONE: ShowStep ]" & vbCrLf & "!! Oggetto Graphig Manager non instanziato!!" & vbCrLf)
                Return False
            Else
                Vision_GM.ShowStep(_Step, _Sub, _mod)
            End If
        Catch ex As Exception
            ok_visione = False
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Friend Function Exe_Plc_Vis_Step(ByVal _id As Integer, _Str As String) As Boolean
        Dim _Nome As String
        Try
            If Vision_GM Is Nothing Then
                show_eccezione("[ ERRORE VISIONE: ProcessStep ]" & vbCrLf & "!! Oggetto Graphig Manager non instanziato!!" & vbCrLf)
            Else
                Run_vis(_id) = True : Hold_foto(_id) = True
                _Nome = _id.ToString
                Step_vis = Visioni_Attuali.Where(Function(x) x.VisionOrderId = _id).Select(Function(y) y.VisionStep).FirstOrDefault
                If Step_vis > 0 Then
                    Preset_visione(_id)
                    Vision_GM.ProcessStep(_id, _Str, False, Step_vis, _Nome)
                Else
                    show_eccezione("[ ERRORE VISIONE: ProcessStep ]  Passo visione non trovato: " & _id.ToString)
                End If
            End If
        Catch ex As Exception
            show_eccezione("[ ERRORE VISIONE: ProcessStep ]" & ex.ToString)
            Return False
        End Try
        Return True
    End Function
    Friend Sub Ciclo_tlc(ByVal _id As Integer, ByVal _Passo As Integer)
        Dim _Matrix, _Nome As String
        Try
            If Vision_GM Is Nothing Then
                show_eccezione("[ ERRORE VISIONE: ProcessStep ]" & vbCrLf & "!! Oggetto Graphic Manager non instanziato!!" & vbCrLf)
            Else
                _Matrix = ""
                Run_vis(_id) = True : Hold_foto(_id) = True
                _Nome = _id.ToString
                Vision_GM.ProcessStep(_id, _Matrix, False, _Passo, _Nome)
            End If
            '    Task.Run(Sub() GF.ExecuteStepAsync(_indice_vis))
        Catch ex As Exception
            show_eccezione("[ ERRORE VISIONE: ProcessStep ]" & ex.ToString)
        End Try
    End Sub

    Friend Sub Preset_visione(idVisione As Integer)
        Dim i, n As Integer
        Dim _DB_ID_Sx, _DB_ID_Dx As Date
        Try

            For n = 0 To 4
                Buono_Vis(idVisione, n) = True
            Next n

            If Visione_si Then
                _DB_ID_Sx = data_inizioa.AddSeconds(1)
                _DB_ID_Dx = data_inizioa
                'Vision_GM.SetStartCycle(_DB_ID_Sx, _DB_ID_Dx, data_inizioa)
            End If
        Catch ex As Exception
            show_eccezione("[ ERRORE VISIONE: SetStartCycle ]" & ex.ToString)
        End Try
    End Sub
    Friend Sub release_visione()
        Try
            If Not (Vision_GM Is Nothing) Then
                Vision_GM.Dispose()
                Vision_GM = Nothing
            End If
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
    Friend Sub Fine_Cyc_Visione(ByVal _Rep As Boolean)
        If Visione_si Then  'Passa FINE CICLO a visione (FALSE) solo con OPZIONE bit .1
            Try
                'Vision_GM.SetStopCycle(_Rep)
            Catch ex As Exception
                show_eccezione("[ ERRORE VISIONE: SetStopCycle ]" & ex.ToString)
            End Try
        End If
    End Sub


#Region "EVENTI"
    Private Sub Vision_GM_OnExceptionReachedEvent(sender As Object, ExEventArgs As ExceptionEventArgs) Handles Vision_GM.OnExceptionReachedEvent
        If Not _Sim_Vis Then
            show_eccezione("[ ERRORE VISIONE:  OnExceptionReachedEvent ]" & vbCrLf & ExEventArgs.ExceptionMsg & vbCrLf)
        End If
    End Sub

    Private Sub Vision_GM_OnLastPhotoDoneEvent(sender As Object, AnswerEventArgs As LastPhotoDoneEventArgs) Handles Vision_GM.OnLastPhotoDoneEvent
        Dim _id As Integer = AnswerEventArgs.AnswerId
        If _id > 4 Then
            show_eccezione("[ ERRORE VISIONE: OnLastPhotoDoneEvent ]" & vbCrLf & "ID non valdio: " & _id.ToString & vbCrLf)
        Else
            Hold_foto(_id) = False
        End If
    End Sub

    Private Sub Vision_GM_OnLightRequestEvent(sender As Object, AnswerEventArgs As LightRequestEventArgs) Handles Vision_GM.OnLightRequestEvent
        Select Case AnswerEventArgs.AnswerId
            Case 1
                Mask_Illum_dx = CInt(AnswerEventArgs.LightingMask)
                Ord_Illum_dx = True
            Case 11
                Mask_Illum_sx = CInt(AnswerEventArgs.LightingMask)
                Ord_Illum_sx = True
            Case Else
                show_eccezione("[ ERRORE VISIONE: OnLightRequestEvent ]" & vbCrLf & "ID non valdio: " & AnswerEventArgs.AnswerId.ToString & vbCrLf)
        End Select
    End Sub

    Private Sub Vision_GM_OnPreparationDoneEvent(sender As Object, AnswerEventArgs As PreparationDoneEventArgs) Handles Vision_GM.OnPreparationDoneEvent
        Dim _id As Integer = AnswerEventArgs.AnswerId
        'If _id > 4 Then
        '    show_eccezione("[ ERRORE VISIONE: OnPreparationDoneEvent ]" & vbCrLf & "ID non valdio: " & AnswerEventArgs.AnswerId.ToString & vbCrLf)
        'Else
        '    'Clear_Wip(_id) = True
        'End If
    End Sub

    Private Sub Vision_GM_OnResultsEvent(sender As Object, AnswerEventArgs As ResultsEventArgs) Handles Vision_GM.OnResultsEvent
        Dim _esiti As List(Of Boolean)
        Dim _id As Integer = AnswerEventArgs.ResultId
        _esiti = AnswerEventArgs.ResultSubSteps
        If (_id < 1) Or (_id > _n_visioni) Then
            show_eccezione("[ ERRORE VISIONE: OnResultsEvent ]" & vbCrLf & "ID non valdio: " & AnswerEventArgs.ResultId.ToString & vbCrLf)
        Else
            If (_esiti Is Nothing) Then
                show_eccezione("[ ERRORE VISIONE: OnResultsEvent ]" & vbCrLf & "ResultSubSteps not valid: " & _id.ToString & vbCrLf)
            Else
                Run_vis(_id) = False : Hold_foto(_id) = False : Fine_Vis(_id) = True : _agg_visione = True
                Buono_Vis(_id, 0) = _esiti(0) : Buono_Vis(_id, 1) = _esiti(1) : Buono_Vis(_id, 2) = _esiti(2) : Buono_Vis(_id, 3) = _esiti(3)
                Scarto_Visione(_id) = Not (Buono_Vis(_id, 0) And Buono_Vis(_id, 1) And Buono_Vis(_id, 2) And Buono_Vis(_id, 3))

                If AnswerEventArgs.ResultData Is Nothing Then
                    If Not _Sim_Vis Then
                        show_eccezione("[ ERRORE VISIONE: OnResultsEvent ]" & vbCrLf & "AnswerEventArgs.ResultData not valid: " & _id.ToString & vbCrLf)
                    End If
                Else
                    If AnswerEventArgs.ResultData.Count > 0 Then
                        Answ_Dati(_id) = AnswerEventArgs.ResultData
                        Try
                            Select Case _id
                                Case 1
                                    DM_Oled = (DirectCast(Answ_Dati(_id)(0)("Matrix_1").Value, String)).Replace(" ", "_").Replace("\", "_").Replace("/", "_")
                                    OLED_Date = DirectCast(Answ_Dati(_id)(0)("Time").Value, DateTime)
                            End Select
                        Catch ex As Exception
                            show_eccezione(ex)
                        End Try
                    Else
                        If (_id <> 3) Then
                            show_eccezione("[ ERRORE VISIONE: OnResultsEvent ]" & vbCrLf & "AnswerEventArgs.ResultData.Count VUOTO: " & _id.ToString & vbCrLf)
                        End If
                    End If
                End If
            End If
        End If
        Fine_Cyc_Visione(False)
    End Sub
#End Region

    Friend Function Correz_Orientam(ByVal _ID As Integer) As Boolean
        Dim _qX As Integer
        Dim _qY As Integer
        Dim _qRz As Integer
        Dim _bi() As Byte
        If _Sim_Vis Then Return False
        Try


            'Answ_Dati(3)(0)("X").Key Answ_Dati(3)(0)("X").Value
            Dim ttt As Type = Answ_Dati(_ID)(0)("X").Key
            _dx = DirectCast(Answ_Dati(_ID)(0)("X".ToUpper).Value, Double)
            _dy = DirectCast(Answ_Dati(_ID)(0)("Y".ToUpper).Value, Double)
            _da = DirectCast(Answ_Dati(_ID)(0)("Angle").Value, Double)

            'Test data
            If (_ID = 2) Then
                If (_dx + StatiMacchina.OffsetVisioneCameraBassa.X + StatiMacchina.OffsetUtenteVisioneCameraBassa.X > Visione_x_Limit_Upper Or _dx + StatiMacchina.OffsetVisioneCameraBassa.X + StatiMacchina.OffsetUtenteVisioneCameraBassa.X < Visione_x_Limit_Lower) Or
                   (_dy + StatiMacchina.OffsetVisioneCameraBassa.Y + StatiMacchina.OffsetUtenteVisioneCameraBassa.Y > Visione_y_Limit_Upper Or _dy + StatiMacchina.OffsetVisioneCameraBassa.Y + StatiMacchina.OffsetUtenteVisioneCameraBassa.Y < Visione_y_Limit_Lower) Or
                   (_da + StatiMacchina.OffsetVisioneCameraBassa.Rotazione + StatiMacchina.OffsetUtenteVisioneCameraBassa.Rotazione > Visione_angle_Limit_Upper Or _da + StatiMacchina.OffsetVisioneCameraBassa.Rotazione + StatiMacchina.OffsetUtenteVisioneCameraBassa.Rotazione < Visione_angle_Limit_Lower) Then
                    Return False
                End If
            ElseIf (_ID = 4) Then
                If (_dx + StatiMacchina.OffsetVisioneCameraAlta.X + StatiMacchina.OffsetUtenteVisioneCameraAlta.X > Visione_x_Limit_Upper Or _dx + StatiMacchina.OffsetVisioneCameraAlta.X + StatiMacchina.OffsetUtenteVisioneCameraAlta.X < Visione_x_Limit_Lower) Or
                   (_dy + StatiMacchina.OffsetVisioneCameraAlta.Y + StatiMacchina.OffsetUtenteVisioneCameraAlta.Y > Visione_y_Limit_Upper Or _dy + StatiMacchina.OffsetVisioneCameraAlta.Y + StatiMacchina.OffsetUtenteVisioneCameraAlta.Y < Visione_y_Limit_Lower) Or
                   (_da + StatiMacchina.OffsetVisioneCameraAlta.Rotazione + StatiMacchina.OffsetUtenteVisioneCameraAlta.Rotazione > Visione_angle_Limit_Upper Or _da + StatiMacchina.OffsetVisioneCameraAlta.Rotazione + StatiMacchina.OffsetUtenteVisioneCameraAlta.Rotazione < Visione_angle_Limit_Lower) Then
                    Return False
                End If
            Else
                Return False
            End If

            'ID = 2 => Bassa
            'ID = 4 => Alta
            If (_ID = 2) Then
                _qX = CInt((_dx + StatiMacchina.OffsetVisioneCameraBassa.X + StatiMacchina.OffsetUtenteVisioneCameraBassa.X) * 1000)
                _qY = CInt((_dy + StatiMacchina.OffsetVisioneCameraBassa.Y + StatiMacchina.OffsetUtenteVisioneCameraBassa.Y) * 1000)
                _qRz = CInt((_da + StatiMacchina.OffsetVisioneCameraBassa.Rotazione + StatiMacchina.OffsetUtenteVisioneCameraBassa.Rotazione) * 10000)
            ElseIf (_ID = 4) Then
                _qX = CInt((_dx + StatiMacchina.OffsetVisioneCameraAlta.X + StatiMacchina.OffsetUtenteVisioneCameraAlta.X) * 1000)
                _qY = CInt((_dy + StatiMacchina.OffsetVisioneCameraAlta.Y + StatiMacchina.OffsetUtenteVisioneCameraAlta.Y) * 1000)
                _qRz = CInt((_da + StatiMacchina.OffsetVisioneCameraAlta.Rotazione + StatiMacchina.OffsetUtenteVisioneCameraAlta.Rotazione) * 10000)
            Else
                _qX = CInt(_dx * 1000)
                _qY = CInt(_dy * 1000)
                _qRz = CInt(_da * 10000)
            End If


            _bi = BitConverter.GetBytes(CShort(_qX))
            CorrTlc(0) = _bi(1) : CorrTlc(1) = _bi(0) 'X

            _bi = BitConverter.GetBytes(CShort(_qY))
            CorrTlc(2) = _bi(1) : CorrTlc(3) = _bi(0) 'Y

            CorrTlc(4) = CByte(0) : CorrTlc(5) = CByte(0) 'Z


            _bi = BitConverter.GetBytes(CShort(_qRz))
            CorrTlc(6) = _bi(1) : CorrTlc(7) = _bi(0) 'Rotazione Z

            CorrTlc(8) = CByte(0) : CorrTlc(9) = CByte(0) 'Rotazione X
            CorrTlc(10) = CByte(0) : CorrTlc(11) = CByte(0) 'Rotazione Y
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Friend Function Memo_Oled() As Boolean
        Dim i, l As Integer
        Dim _c(37) As Char
        Dim _s(7) As Char
        Try
            l = DM_Oled.Length
            If l > 36 Then
                show_eccezione("ERROR: Oled Data Matrix lenght: -> " & l.ToString)
                Return False
            End If
            _c = DM_Oled.ToCharArray
            For i = 0 To MatrixOled.Length - 1
                MatrixOled(i) = CByte(Asc(" "c))    'pulisci stringa
            Next
            For i = 0 To _c.Length - 1
                MatrixOled(i) = CByte(Asc(_c(i)))   'riempi solo per la lunghezza letta
            Next
            _s = OLED_Date.ToString("yyMMdd").ToCharArray
            For i = 0 To 5
                Date_Oled(i) = CByte(Asc(_s(i)))
            Next
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function


    Friend Function BuildOledBuffer(dmOled As String) As Byte()
        Const FIXED_LEN As Integer = 42
        Dim buffer(FIXED_LEN - 1) As Byte

        Try
            If dmOled Is Nothing Then dmOled = String.Empty

            If dmOled.Length > FIXED_LEN Then
                'Throw New Exception("ERROR: Oled Data Matrix length -> " & dmOled.Length.ToString())
                'Truncate the string if it's longer than FIXED_LEN
                dmOled = dmOled.Substring(0, FIXED_LEN)
            End If

            ' Riempie tutto a spazi (ASCII 32)
            For i = 0 To FIXED_LEN - 1
                buffer(i) = AscW(" "c)
            Next

            ' Copia solo i caratteri presenti
            Dim dmBytes() As Byte = System.Text.Encoding.ASCII.GetBytes(dmOled)
            Array.Copy(dmBytes, 0, buffer, 0, dmBytes.Length)

            Return buffer

        Catch ex As Exception
            show_eccezione(ex)
            Return Nothing
        End Try
    End Function

End Module

Imports DSM_WebApi
Imports System.IO
Imports System.Data
Imports System.Text


Friend Module Mod_DSM_XML

    Friend WithEvents TMSRV As DSMWebAPI
    Friend TMSRV_Live, TMS_Dx_Busy, TMS_Sx_Busy, TMS_Dx_Ok, TMS_sx_Ok, TMS_Rep_D, TMS_Rep_S, Repos_Dato As Boolean
    Friend TMS_Resp_Dx, TMS_Resp_Sx, Msg_Tms_Dx, Msg_Tms_Sx As String
    Friend Tab_Lista_Fasi As DataTable
    Friend Dsm_List_Id1, Dsm_List_Id4, Dsm_List_Id3, Dsm_List_Id5, Dsm_List_Id2, Dsm_List_Id7, Dsm_List_Id6, Dsm_List_Id8 As Integer
    Friend DSM_Model_ID As Integer

#Region "Traceability struct"
    Friend DSM_Alarm_List As New List(Of DSMWebAPI.Alarm)

    Public DSM_Compon As New List(Of DSMWebAPI.Component)

    Public DSM_Fase_List As New List(Of DSMWebAPI.stepSection)          'Elenco FASI Raccoglitore dati
    Public DSM_Fase_List_Int As New List(Of DSMWebAPI.stepSection)          'Elenco FASI solo OLED interni
#End Region
#Region "Consistency struct"
    Public DSM_Param_L, DSM_Param_R As New List(Of DSMWebAPI.Parameter)
    Public DSM_Step_L, DSM_Step_R As New List(Of DSMWebAPI.Step)
#End Region

#Region "Dati e impostazioni generali"
    <Serializable()> Public Structure DSM_GenData
        Public Line_Id_1 As Integer
        Public Line_Descr_1 As String
        Public Line_Id_2 As Integer
        Public Line_Descr_2 As String
        Public Oper_Id_1 As Integer
        Public Oper_Descr_1 As String
        Public Oper_Id_2 As Integer
        Public Oper_Descr_2 As String
        Public Oper_Id_3 As Integer
        Public Oper_Descr_3 As String
        Public Oper_Id_4 As Integer
        Public Oper_Descr_4 As String
        Public Base_Addr As String
        Public Consist_Thread As String
        Public Trace_Thread As String
        Public Alarms_Thread As String
        Public Spare_Thread As String
        Public Cons_Token As String
        Public Trace_Token As String
        Public Alarm_Token As String
        Public Consist_ThreadD As String
        Public Trace_ThreadD As String
        Public Cons_TokenD As String
        Public Trace_TokenD As String
        Public Base_Addr2 As String
    End Structure
    <Serializable()> Public Structure DSMPhaseStruct
        Public leftPhaseName As String
        Public leftPhaseID As Integer
        Public rightPhaseName As String
        Public rightPhaseID As Integer
        Public Scrap_Code As Integer
        Public Index As Short
    End Structure
    <Serializable()> Public Structure DSM_Struct
        Public Gen As DSM_GenData
        Public DSM_Fasi_List As List(Of DSMPhaseStruct)
    End Structure
    Public DSM_Fase_Struct As New DSMPhaseStruct
    Public DSM_Gen_Data As New DSM_Struct

    Friend Function Carica_DSM_Liste() As Boolean
        Dim _file As String = Main_dir & "DSM_List.xml"
        Try
            If File.Exists(_file) Then

                Dim _format As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
                Dim fs As New FileStream(_file, FileMode.Open)
                DSM_Gen_Data = DirectCast(_format.Deserialize(fs), DSM_Struct)
                fs.Dispose()
            Else
                DSM_Gen_Data = New DSM_Struct
                DSM_Gen_Data.DSM_Fasi_List = New List(Of DSMPhaseStruct)
                DSM_Gen_Data.Gen = New DSM_GenData

                DSM_Gen_Data.DSM_Fasi_List.Clear()

                With DSM_Gen_Data.Gen
                    .Line_Id_1 = 111
                    .Line_Id_2 = 112
                    .Oper_Id_1 = 11
                    .Oper_Id_2 = 12
                    .Oper_Id_3 = 13
                    .Oper_Id_4 = 14

                    .Line_Descr_1 = "Line "
                    .Line_Descr_2 = "Line "
                    .Oper_Descr_1 = "Operation "
                    .Oper_Descr_2 = "Operation "
                    .Oper_Descr_3 = "Operation "
                    .Oper_Descr_4 = "Operation "

                    .Base_Addr = "Base Address1"
                    .Base_Addr2 = "Base Address2"
                    .Consist_Thread = "Consistency thea"
                    .Trace_Thread = "Traceability thea"
                    .Alarms_Thread = "Alarms thera"
                    .Spare_Thread = "SPAR"
                End With


                With DSM_Fase_Struct
                    .leftPhaseName = "ELECTRICAL TEST L" : .leftPhaseID = 17
                    .rightPhaseName = "ELECTRICAL TEST R" : .rightPhaseID = 28
                    .Scrap_Code = 10 : .Index = 1
                End With
                DSM_Gen_Data.DSM_Fasi_List.Add(DSM_Fase_Struct)

                With DSM_Fase_Struct
                    .leftPhaseName = "LEAKAGE TEST L" : .leftPhaseID = 18
                    .rightPhaseName = "LEAKAGE TEST R" : .rightPhaseID = 29
                    .Scrap_Code = 11 : .Index = 2
                End With
                DSM_Gen_Data.DSM_Fasi_List.Add(DSM_Fase_Struct)

                With DSM_Fase_Struct
                    .leftPhaseName = "VISION TEST L" : .leftPhaseID = 19
                    .rightPhaseName = "VISION TEST R" : .rightPhaseID = 30
                    .Scrap_Code = 12 : .Index = 3
                End With
                DSM_Gen_Data.DSM_Fasi_List.Add(DSM_Fase_Struct)

                With DSM_Fase_Struct
                    .leftPhaseName = "HEIGHTS L" : .leftPhaseID = 33
                    .rightPhaseName = "HEIGHTS R" : .rightPhaseID = 34
                    .Scrap_Code = 13 : .Index = 4
                End With
                DSM_Gen_Data.DSM_Fasi_List.Add(DSM_Fase_Struct)

                With DSM_Fase_Struct
                    .leftPhaseName = "COMPONENTS L" : .leftPhaseID = 31
                    .rightPhaseName = "COMPONENTS R" : .rightPhaseID = 32
                    .Scrap_Code = 14 : .Index = 5
                End With
                DSM_Gen_Data.DSM_Fasi_List.Add(DSM_Fase_Struct)

                With DSM_Fase_Struct
                    .leftPhaseName = "PRINT L" : .leftPhaseID = 29
                    .rightPhaseName = "PRINT R" : .rightPhaseID = 37
                    .Scrap_Code = 15 : .Index = 6
                End With
                DSM_Gen_Data.DSM_Fasi_List.Add(DSM_Fase_Struct)
                '---------  salva file --------------
                Salva_DSM_Liste()
            End If

            If Read_Step_Id() Then

            Else
                Return False
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Friend Function Salva_DSM_Liste() As Boolean
        Dim _file As String = Main_dir & "DSM_List.xml"
        Try
            Dim _format As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
            Dim fs As New FileStream(_file, FileMode.Create)
            _format.Serialize(fs, DSM_Gen_Data)
            fs.Dispose()
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Function Read_Step_Id() As Boolean
        Dim i As Integer    'recupera indice nella lista FASI
        Try
            DSM_Fase_List.Clear() : DSM_Compon.Clear()
            DSM_Fase_List_Int.Clear()

            Dsm_List_Id1 = -1 : Dsm_List_Id4 = -1 : Dsm_List_Id3 = -1 : Dsm_List_Id5 = -1 : Dsm_List_Id2 = -1 : Dsm_List_Id6 = -1 : Dsm_List_Id7 = -1 : Dsm_List_Id8 = -1
            '------------  solo per traccia OLED zona interna ----

            Dim _StpOpAtt0 = New DSMWebAPI.stepOperationAttempt With {.attemptId = 1, .attemptValue = 1, .measurements = New List(Of DSMWebAPI.Measurement)}
            Dim DSM_StOperAtt_0 As New List(Of DSMWebAPI.stepOperationAttempt)
            DSM_StOperAtt_0.Add(_StpOpAtt0)
            Dim DSM_Fase_S0 As New DSMWebAPI.stepSection With {.stepResult = "", .stepName = "OLED_support", .stepCode = "1", .stepOperationAttempts = DSM_StOperAtt_0, .scrapCode = "1", .scrapDescription = "Scarto OLED"}
            DSM_Fase_List_Int.Add(DSM_Fase_S0)

            '---------------------------------------------------------------
            For i = 0 To DSM_Gen_Data.DSM_Fasi_List.Count - 1
                Select Case DSM_Gen_Data.DSM_Fasi_List(i).Index
                    Case 1  'Elettrico
                        Dim _StpOpAtt1 = New DSMWebAPI.stepOperationAttempt With {.attemptId = 1, .attemptValue = 1, .measurements = New List(Of DSMWebAPI.Measurement)}
                        Dim DSM_StOperAtt_S As New List(Of DSMWebAPI.stepOperationAttempt)
                        DSM_StOperAtt_S.Add(_StpOpAtt1)
                        Dim DSM_Fase_S1 As New DSMWebAPI.stepSection With {.stepResult = "", .stepName = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseName, .stepCode = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseID.ToString, .stepOperationAttempts = DSM_StOperAtt_S, .scrapCode = DSM_Gen_Data.DSM_Fasi_List(i).Scrap_Code.ToString, .scrapDescription = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseName}
                        ' If DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseID > 0 Then
                        DSM_Fase_List.Add(DSM_Fase_S1)
                        '    Dsm_List_Id1 = DSM_Fase_List_S.Count - 1
                        'End If

                    Case 2  'Tenuta
                        Dim _StpOpAtt1 = New DSMWebAPI.stepOperationAttempt With {.attemptId = 2, .attemptValue = 1, .measurements = New List(Of DSMWebAPI.Measurement)}
                        Dim DSM_StOperAtt_S As New List(Of DSMWebAPI.stepOperationAttempt)
                        DSM_StOperAtt_S.Add(_StpOpAtt1)
                        Dim DSM_Fase_S2 = New DSMWebAPI.stepSection With {.stepResult = "", .stepName = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseName, .stepCode = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseID.ToString, .stepOperationAttempts = DSM_StOperAtt_S, .scrapCode = DSM_Gen_Data.DSM_Fasi_List(i).Scrap_Code.ToString, .scrapDescription = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseName}
                        'If DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseID > 0 Then
                        DSM_Fase_List.Add(DSM_Fase_S2)

                        Dsm_List_Id2 = DSM_Fase_List.Count - 1
                    Case 3  'Visione
                        Dim _StpOpAtt1 = New DSMWebAPI.stepOperationAttempt With {.attemptId = 3, .attemptValue = 1, .measurements = New List(Of DSMWebAPI.Measurement)}
                        Dim DSM_StOperAtt_S As New List(Of DSMWebAPI.stepOperationAttempt)
                        DSM_StOperAtt_S.Add(_StpOpAtt1)
                        Dim DSM_Fase_S3 = New DSMWebAPI.stepSection With {.stepResult = "", .stepName = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseName, .stepCode = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseID.ToString, .stepOperationAttempts = DSM_StOperAtt_S, .scrapCode = DSM_Gen_Data.DSM_Fasi_List(i).Scrap_Code.ToString, .scrapDescription = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseName}
                        DSM_Fase_List.Add(DSM_Fase_S3)


                        Dsm_List_Id3 = DSM_Fase_List.Count - 1

                    Case 4  'Altezze
                        Dim _StpOpAtt1 = New DSMWebAPI.stepOperationAttempt With {.attemptId = 4, .attemptValue = 1, .measurements = New List(Of DSMWebAPI.Measurement)}
                        Dim DSM_StOperAtt_S As New List(Of DSMWebAPI.stepOperationAttempt)
                        DSM_StOperAtt_S.Add(_StpOpAtt1)
                        Dim DSM_Fase_S4 = New DSMWebAPI.stepSection With {.stepResult = "", .stepName = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseName, .stepCode = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseID.ToString, .stepOperationAttempts = DSM_StOperAtt_S, .scrapCode = DSM_Gen_Data.DSM_Fasi_List(i).Scrap_Code.ToString, .scrapDescription = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseName}
                        DSM_Fase_List.Add(DSM_Fase_S4)

                        Dsm_List_Id4 = DSM_Fase_List.Count - 1

                    Case 5  'Componenti
                        Dim _StpOpAtt1 = New DSMWebAPI.stepOperationAttempt With {.attemptId = 5, .attemptValue = 1, .measurements = New List(Of DSMWebAPI.Measurement)}
                        Dim DSM_StOperAtt_S As New List(Of DSMWebAPI.stepOperationAttempt)
                        DSM_StOperAtt_S.Add(_StpOpAtt1)
                        Dim DSM_Fase_S5 = New DSMWebAPI.stepSection With {.stepResult = "", .stepName = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseName, .stepCode = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseID.ToString, .stepOperationAttempts = DSM_StOperAtt_S, .scrapCode = DSM_Gen_Data.DSM_Fasi_List(i).Scrap_Code.ToString, .scrapDescription = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseName}
                        'If DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseID > 0 Then
                        DSM_Fase_List.Add(DSM_Fase_S5)
                        'End If


                        Dsm_List_Id5 = DSM_Fase_List.Count - 1
                    Case 6  'Custom
                        Dim _StpOpAtt1 = New DSMWebAPI.stepOperationAttempt With {.attemptId = 6, .attemptValue = 1, .measurements = New List(Of DSMWebAPI.Measurement)}
                        Dim DSM_StOperAtt_S As New List(Of DSMWebAPI.stepOperationAttempt)
                        DSM_StOperAtt_S.Add(_StpOpAtt1)
                        Dim DSM_Fase_S6 = New DSMWebAPI.stepSection With {.stepResult = "", .stepName = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseName, .stepCode = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseID.ToString, .stepOperationAttempts = DSM_StOperAtt_S, .scrapCode = DSM_Gen_Data.DSM_Fasi_List(i).Scrap_Code.ToString, .scrapDescription = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseName}
                        'If DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseID > 0 Then
                        DSM_Fase_List.Add(DSM_Fase_S6)
                        'End If


                        Dsm_List_Id6 = DSM_Fase_List.Count - 1
                    Case 7  'Avvitatura
                        Dim _StpOpAtt1 = New DSMWebAPI.stepOperationAttempt With {.attemptId = 7, .attemptValue = 1, .measurements = New List(Of DSMWebAPI.Measurement)}
                        Dim DSM_StOperAtt_S As New List(Of DSMWebAPI.stepOperationAttempt)
                        DSM_StOperAtt_S.Add(_StpOpAtt1)
                        Dim DSM_Fase_S7 = New DSMWebAPI.stepSection With {.stepResult = "", .stepName = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseName, .stepCode = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseID.ToString, .stepOperationAttempts = DSM_StOperAtt_S, .scrapCode = DSM_Gen_Data.DSM_Fasi_List(i).Scrap_Code.ToString, .scrapDescription = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseName}
                        'If DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseID > 0 Then
                        DSM_Fase_List.Add(DSM_Fase_S7)

                        Dsm_List_Id7 = DSM_Fase_List.Count - 1
                    Case 8  'OLED Orientamento
                        Dim _StpOpAtt1 = New DSMWebAPI.stepOperationAttempt With {.attemptId = 8, .attemptValue = 1, .measurements = New List(Of DSMWebAPI.Measurement)}
                        Dim DSM_StOperAtt_S As New List(Of DSMWebAPI.stepOperationAttempt)
                        DSM_StOperAtt_S.Add(_StpOpAtt1)
                        Dim DSM_Fase_S8 = New DSMWebAPI.stepSection With {.stepResult = "", .stepName = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseName, .stepCode = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseID.ToString, .stepOperationAttempts = DSM_StOperAtt_S, .scrapCode = DSM_Gen_Data.DSM_Fasi_List(i).Scrap_Code.ToString, .scrapDescription = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseName}
                        'If DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseID > 0 Then
                        DSM_Fase_List.Add(DSM_Fase_S8)
                        'End If


                        Dsm_List_Id8 = DSM_Fase_List.Count - 1

                End Select
            Next
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function

#End Region


    Friend Function Run_TMS() As Boolean
        Dim i As Integer
        Try
            TMS_Resp_Dx = "" : TMS_Resp_Sx = "" : Msg_Tms_Dx = "" : Msg_Tms_Sx = ""

            If Sett.TMServer Then
                If Carica_DSM_Liste() Then
                    '----prepara dati Consistency '''''
                    DSM_Step_L.Clear() : DSM_Step_R.Clear()
                    DSM_Param_L.Clear() : DSM_Param_R.Clear()
                    For i = 0 To DSM_Gen_Data.DSM_Fasi_List.Count - 1
                        If (DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseID > 0) And (DSM_Gen_Data.DSM_Fasi_List(i).Index > 0) Then
                            Dim _newStep As New DSMWebAPI.Step With {.stepName = DSM_Gen_Data.DSM_Fasi_List(i).leftPhaseName, .result = 0}
                            DSM_Step_L.Add(_newStep)
                        End If
                        If (DSM_Gen_Data.DSM_Fasi_List(i).rightPhaseID > 0) And (DSM_Gen_Data.DSM_Fasi_List(i).Index > 0) Then
                            Dim _newStep As New DSMWebAPI.Step With {.stepName = DSM_Gen_Data.DSM_Fasi_List(i).rightPhaseName, .result = 0}
                            DSM_Step_R.Add(_newStep)
                        End If
                    Next
                    '----------------------------------------
                    TMSRV = New DSMWebAPI
                    TMSRV_Live = True
                    TMS_Clean()
                Else
                    TMSRV = Nothing
                    TMSRV_Live = False
                End If
            Else
                TMSRV_Live = False
            End If
        Catch ex As Exception
            ' TMSRV_Live = False
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Friend Function Stop_TMS() As Boolean
        Try
            If Not (TMSRV Is Nothing) Then
                TMSRV_Live = False
                TMSRV = Nothing
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Friend Sub TMS_Start(ByVal _s As String, ByVal _sx As Boolean)      'Richiesta consistenza
        Dim _id, _Model As Integer
        Dim DMtx As String
        Dim _oper As DSMWebAPI.Operation
        Dim DSM_C_Req As DSMWebAPI.CRequest
        If TMSRV Is Nothing Then Exit Sub
        Try
            If Sett.DSM_Remove_Hash Then
                DMtx = _s.Replace("#"c, "")
            Else
                DMtx = _s
            End If
            If TMSRV_Live Then
                If _sx Then
                    '  _Model = CInt(_tab_sel_piastre.Rows(0).Item(7))  'Tm Model sx
                    _Model = DSM_Model_ID
                    TMS_Sx_Busy = True : _id = 11
                    _oper = New DSMWebAPI.Operation With {.eventTime = data_inizio, .operationId = DSM_Gen_Data.Gen.Oper_Id_1.ToString}
                    DSM_C_Req = New DSMWebAPI.CRequest With {.operation = _oper, .productCode = DMtx, .modelCode = _Model.ToString, .steps = DSM_Step_L, .parameters = DSM_Param_L}
                    TMSRV.SendConsinstency(_id, DSM_Gen_Data.Gen.Oper_Descr_1, DSM_Gen_Data.Gen.Base_Addr, DSM_Gen_Data.Gen.Consist_Thread, DSM_Gen_Data.Gen.Cons_Token, DSM_C_Req)
                Else
                    '  _Model = CInt(_tab_sel_piastre.Rows(0).Item(11))  'Tm Model dx
                    _Model = DSM_Model_ID
                    TMS_Dx_Busy = True : _id = 10
                    _oper = New DSMWebAPI.Operation With {.eventTime = data_inizio, .operationId = DSM_Gen_Data.Gen.Oper_Id_2.ToString}
                    DSM_C_Req = New DSMWebAPI.CRequest With {.operation = _oper, .productCode = DMtx, .modelCode = _Model.ToString, .steps = DSM_Step_R, .parameters = DSM_Param_R}
                    TMSRV.SendConsinstency(_id, DSM_Gen_Data.Gen.Oper_Descr_2, DSM_Gen_Data.Gen.Base_Addr2, DSM_Gen_Data.Gen.Consist_ThreadD, DSM_Gen_Data.Gen.Cons_TokenD, DSM_C_Req)
                End If
                ' Dim DSM_C_Req As New DSMWebAPI.CRequest(_oper, DMtx, _Model.ToString, DSM_Step_L, DSM_Param_L)
                ' TMSRV.SendConsinstency(_id, DSM_Gen_Data.Gen.Oper_Descr_1, DSM_Gen_Data.Gen.Base_Addr, DSM_Gen_Data.Gen.Consist_ThreadD, DSM_Gen_Data.Gen.Cons_TokenD, DSM_C_Req)
            Else
                show_eccezione("Traceability Manager Server Is Not ALIVE")
                If _sx Then
                    TMS_Sx_Busy = True
                Else
                    TMS_Dx_Busy = True
                End If
            End If
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub

    Friend Sub TMS_Send_Alarms()
        If TMSRV Is Nothing Then Exit Sub
        If Not TMSRV_Live Then Exit Sub
        Try
            If DSM_Alarm_List.Count > 0 Then
                ''''''''''''''''  TMSRV.SendAlarm(CUInt(Sett.MTS_ID), DSM_Alarm_List)
            End If
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
    Friend Sub TMS_Clean()
        Dim i As Integer
        TMS_Dx_Busy = False : TMS_Sx_Busy = False : TMS_Dx_Ok = False : TMS_sx_Ok = False
        'MTX_Dx_Letto = False : MTX_Sx_Letto = False
        Msg_Tms_Dx = "" : Msg_Tms_Sx = "" : TMS_Resp_Dx = "" : TMS_Resp_Sx = ""
        Try
            If Sett.TMServer Then
                If TMSRV Is Nothing Then Exit Sub
                If TMSRV_Live Then
                    DSM_Compon.Clear()
                    For i = 0 To DSM_Fase_List.Count - 1
                        DSM_Fase_List(i).stepOperationAttempts(0).measurements.Clear()
                    Next

                Else
                    show_eccezione("Traceability Manager Server Is Not ALIVE")
                End If
            End If
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub


#Region "Event"
    Private Sub TMSRV_OnAnswerDoneEvent(sender As Object, AnswerEventArgs As DSMWebAPI.AnswerEventArgs) Handles TMSRV.OnAnswerDoneEvent
        Select Case AnswerEventArgs.AnswerId
            Case 10     'Matrix DX
                If AnswerEventArgs.AnswerResult Then
                    TMS_Resp_Dx = ""
                    TMS_Dx_Busy = False : TMS_Dx_Ok = True  'Conf PLC
                Else
                    TMS_Resp_Dx = AnswerEventArgs.AnswerErrorMsg
                    If Not Automatico Then
                        TMS_Dx_Busy = False
                    End If
                End If
                Msg_Tms_Dx = Msg_Tms_Dx & AnswerEventArgs.AnswerErrorMsg & vbCrLf
            Case 11     'Matrix SX
                If AnswerEventArgs.AnswerResult Then
                    TMS_Resp_Sx = ""
                    TMS_Sx_Busy = False : TMS_sx_Ok = True  'Conf PLC
                Else
                    TMS_Resp_Sx = AnswerEventArgs.AnswerErrorMsg
                    If Not Automatico Then
                        TMS_Sx_Busy = False
                    End If
                End If
                Msg_Tms_Sx = Msg_Tms_Sx & AnswerEventArgs.AnswerErrorMsg & vbCrLf
            Case 20, 30, 31   'Report DX
                TMS_Dx_Busy = False : TMS_Rep_D = False
                If Not AnswerEventArgs.AnswerResult Then
                    If AnswerEventArgs.AnswerErrorCode <> 0 Then
                        show_eccezione("Traceability OnAnswerDoneEvent: DX Repor" & vbCrLf & "Error:  " & AnswerEventArgs.AnswerErrorMsg)
                    End If
                End If
            Case 21     'Report SX
                TMS_Sx_Busy = False : TMS_Rep_S = False
                If Not AnswerEventArgs.AnswerResult Then
                    If AnswerEventArgs.AnswerErrorCode <> 0 Then
                        show_eccezione("Traceability OnAnswerDoneEvent: SX report" & vbCrLf & "Error:  " & AnswerEventArgs.AnswerErrorMsg)
                    End If
                End If
            Case Else
                If AnswerEventArgs.AnswerErrorCode <> 0 Then
                    show_eccezione("Traceability OnAnswerDoneEvent: ID = " & AnswerEventArgs.AnswerId.ToString & vbCrLf & "Error:  " & AnswerEventArgs.AnswerErrorMsg)
                End If

        End Select
    End Sub

    Private Sub TMSRV_OnExceptionReachedEvent(sender As Object, e As DSMWebAPI.ExceptionEventArgs) Handles TMSRV.OnExceptionReachedEvent
        show_eccezione("TMSRV_OnExceptionReachedEvent:  -> " & e.ErrCode & vbCrLf & "Description: ->" & e.ErrDescription & vbCrLf & "Source: ->" & e.ErrSource)
    End Sub



#End Region


    Friend Function DSM_Read_OLED(ByVal _sx As Boolean) As Boolean      'Orientation OLED
        Dim _value, _str_Mtx, PhotoFileName As String
        Dim cc() As Char
        Dim _by(1) As Byte
        Dim i As Integer
        '----- pezzo interno = SX ----
        Try 'cancella dati precedenti
            Dim MagazzinoChar As String = CType(IIf(plc_PressaMagazinoOLED > 1, "B", "A"), String)
            DSM_Compon.Clear()
            For i = 0 To DSM_Fase_List_Int.Count - 1
                DSM_Fase_List_Int(i).stepOperationAttempts(0).measurements.Clear()
            Next
            '------------------------------------------------
            _str_Mtx = Trim(Text.Encoding.ASCII.GetString(_Pressa, 2, 36))

            '_str_Mtx = ""       'Data Matrix OLED
            'cc = Text.Encoding.ASCII.GetString(_Pressa, 2, 36).ToCharArray
            'For i = 0 To cc.Length - 1
            '    If Char.IsLetterOrDigit(cc(i)) Then
            '        _str_Mtx &= cc(i)
            '    End If
            'Next
            Dim _Oled As New DSMWebAPI.Component
            With _Oled
                .componentCode = _str_Mtx
                .componentId = "1"
                .componentName = "OLED"
            End With
            DSM_Compon.Add(_Oled)

            'TODO: PORTARE QUESTI IN DSM STANDARD => CON DATI CHE ARRIVANO DA PLC
            ' If (Dsm_List_Id8 > -1) Then
            Dim Dsm_Tr_Misura1 = New DSMWebAPI.Measurement
            _by(1) = _Pressa(82) : _by(0) = _Pressa(83)
            With Dsm_Tr_Misura1
                .eventDateTime = Now
                .measureUnit = "mm"
                .variableId = "1"
                .variableName = "Orientation_X" + plc_PressaPosizioneOLED.ToString() + MagazzinoChar
                .valueMax = ""
                .valueMin = ""
                .value = (CSng(BitConverter.ToInt16(_by, 0)) / 10.0!).ToString("0.0")
            End With
            _value = "1"
            DSM_Fase_List_Int(0).stepOperationAttempts(0).measurements.Add(Dsm_Tr_Misura1)

            Dim Dsm_Tr_Misura2 = New DSMWebAPI.Measurement
            _by(1) = _Pressa(84) : _by(0) = _Pressa(85)
            With Dsm_Tr_Misura2
                .eventDateTime = Now
                .measureUnit = "mm"
                .variableId = "2"
                .variableName = "Orientation_Y" + plc_PressaPosizioneOLED.ToString() + MagazzinoChar
                .valueMax = ""
                .valueMin = ""
                .value = (CSng(BitConverter.ToInt16(_by, 0)) / 10.0!).ToString("0.0")
            End With
            _value = "1"
            DSM_Fase_List_Int(0).stepOperationAttempts(0).measurements.Add(Dsm_Tr_Misura2)

            Dim Dsm_Tr_Misura3 = New DSMWebAPI.Measurement
            _by(1) = _Pressa(86) : _by(0) = _Pressa(87)
            With Dsm_Tr_Misura3
                .eventDateTime = Now
                .measureUnit = "deg"
                .variableId = "3"
                .variableName = "Orientation_RZ" + plc_PressaPosizioneOLED.ToString() + MagazzinoChar
                .valueMax = ""
                .valueMin = ""
                .value = (CSng(BitConverter.ToInt16(_by, 0)) / 10.0!).ToString("0.0")
            End With
            _value = "1"
            DSM_Fase_List_Int(0).stepOperationAttempts(0).measurements.Add(Dsm_Tr_Misura3)


            Dim _str_Mtx_X_FileName As String = ""       'Data Matrix OLED

            Dim cc1 As String = Trim(Text.Encoding.ASCII.GetString(_Pressa, 2, 36))
            _str_Mtx_X_FileName = String.Join("_", cc1.Split(Path.GetInvalidFileNameChars()))

            'cc = Text.Encoding.ASCII.GetString(_Pressa, 2, 36).ToCharArray
            'For i = 0 To cc.Length - 1
            '    If Char.IsLetterOrDigit(cc(i)) Then
            '        _str_Mtx_X_FileName &= cc(i)
            '    End If
            'Next

            Dim Dsm_Tr_Misura4 = New DSMWebAPI.Measurement
            PhotoFileName = Text.Encoding.ASCII.GetString(_Pressa, 88, 6) & "\" & _str_Mtx_X_FileName & ".jpg"
            With Dsm_Tr_Misura4
                .eventDateTime = Now
                .measureUnit = ""
                .variableId = "4"
                .variableName = "PhotoFileName" + plc_PressaPosizioneOLED.ToString() + MagazzinoChar
                .valueMax = ""
                .valueMin = ""
                .value = PhotoFileName
            End With
            _value = "1"
            DSM_Fase_List_Int(0).stepOperationAttempts(0).measurements.Add(Dsm_Tr_Misura4)


            DSM_Fase_List_Int(0).stepResult = _value
            DSM_Fase_List_Int(0).stepOperationAttempts(0).attemptValue = 1
            '**********************************************************************************************
            '----- pulizia steps non necessari ---
            ''For i = 0 To DSM_Fase_List_Int.Count - 1
            ''    If DSM_Fase_List_Int(i).stepCode = "0" Then
            ''        Dim pp As DSMWebAPI.stepSection = DSM_Fase_List_Int(i)
            ''        DSM_Fase_List_Int.Remove(pp)
            ''    End If
            ''Next
            '**************************************************************************************************
            ''   TMS_Report(_str_Mtx, True, True)    'Traccia DSM SX (OLED)
            '**************************************************************************************************
            '---------  traccia direttamente OLED interni -----------
            Dim _id, _Op_Id, _Model As Integer
            Dim _date As DateTime = Now
            Dim _Op_Desc As String
            Dim DMtx As String
            Dim DSM_T_Req As DSMWebAPI.TRequest 'Una TRequest per side

            If Sett.DSM_Remove_Hash Then
                DMtx = _str_Mtx.Replace("#"c, "")
            Else
                DMtx = _str_Mtx
            End If

            Dim _CompSect = New DSMWebAPI.componentSection With {.components = New List(Of DSMWebAPI.Component)}
            Dim DSM_CompSect As New List(Of DSMWebAPI.componentSection)
            DSM_CompSect.Add(_CompSect)
            For i = 0 To DSM_Compon.Count - 1
                '  DSM_CompSect(0).components.Add(DSM_Compon_S(i))
            Next
            TMS_Sx_Busy = True : TMS_Rep_S = True : _id = 21
            _Op_Desc = DSM_Gen_Data.Gen.Oper_Descr_1 : _Op_Id = DSM_Gen_Data.Gen.Oper_Id_1
            _Model = DSM_Model_ID
            DSM_T_Req = New DSMWebAPI.TRequest With {.lineDescription = DSM_Gen_Data.Gen.Line_Descr_1, .lineId = DSM_Gen_Data.Gen.Line_Id_1, .productCode = DMtx, .operationId = _Op_Id, .operationDescription = _Op_Desc, .eventDate = _date, .inEventDate = _date, .modelCode = _Model.ToString, .componentSection = DSM_CompSect, .stepSection = DSM_Fase_List_Int, .worker = "", .boxCode = "", .groupCode = "", .messageId = ""}
            TMSRV.SendTraceability(_id, _Op_Desc, DSM_Gen_Data.Gen.Base_Addr, DSM_Gen_Data.Gen.Trace_Thread, DSM_Gen_Data.Gen.Trace_Token, DSM_T_Req)
            '**************************************************************************************************
            '  End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function


End Module

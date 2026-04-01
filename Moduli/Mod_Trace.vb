Imports Oled.TraceDataLayer
Imports Oled.DataLayer
Imports Microsoft.Extensions.DependencyInjection
Imports System.Threading
Imports System.Text
Imports System.Linq
Imports DSM_WebApi
Imports System.Web

Friend Module Mod_Trace

    Friend data_inizioa, data_inizio As DateTime
    Friend _NS_MatrixA, _NS_MatrixB, _NS_AllinA, _NS_AllinB, NS_MountA, NS_MountB As Integer
    ' Friend OrientamentoSX As r

    Friend InfosSnap() As InfoPlc
    Friend LastIndexSnap As UShort
    Friend LastUpdateDatetime As DateTime
    Friend WindowSeconds As Double

#Region "Traccia allarmi"
    Friend Num_Act_All As Integer
    Friend _All_Income As Boolean
    Friend T_Alarms As New List(Of Alarm)

    Friend Function Registra_All(ByVal _nr As Integer) As Boolean
        Dim _All As New Alarm
        Try
            With _All
                .EventTime = Now.ToLocalTime
                .Description = List_Allarmi(_nr)
                .CodNumber = _nr + 1
                If all_nr(_nr) Then 'Allarme presente
                    .Event_Incoming = 1
                Else
                    .Event_Incoming = 0
                End If 'Numero allarme
                '.Event_Incoming = all_nr(_nr) 'Allarme presente
            End With
            T_Alarms.Add(_All)
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Friend Function Trace_DB_All() As Boolean
        Dim Loc_Scope = Bootstrapper.Current.Services.CreateScope
        Dim Loc_Context = Loc_Scope.ServiceProvider.GetRequiredService(Of TraceDataContext)()
        Try
            Loc_Context.AlarmHistory.AddRange(T_Alarms)
            Loc_Context.SaveChanges()
            T_Alarms.Clear()
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
#End Region


#Region "Traccia OLED"
    Friend Function Trace_Oled() As Boolean
        Dim Loc_Scope = Bootstrapper.Current.Services.CreateScope
        Dim Loc_Context = Loc_Scope.ServiceProvider.GetRequiredService(Of TraceDataContext)()
        Dim Loc_DL_Context = Loc_Scope.ServiceProvider.GetRequiredService(Of ProcessDataContext)()
        Dim oled As InfoOled
        Dim prod As Product
        Dim ora As DateTime = Now
        Dim buono_Viti As Boolean
        Dim _dsmModelIDA As Integer = -1
        Dim _dsmModelIDB As Integer = -1
        Dim datamatrixPCB As String
        Dim datamatrixOLED As String
        Dim imageFilePath As String

        Dim buonoVite1DSM, buonoVite2DSM, buonoVite3DSM As Boolean

        Try
            Dim isSx As Boolean = LastPCBDatamatrixScanOnSx
            Dim orientamentoX As Integer
            Dim orientamentoY As Integer
            Dim orientamentoRotazione As Integer

            If isSx Then
                buono_Viti = StatiMacchina.Pos1ViteAvvitata And StatiMacchina.Pos2ViteAvvitata And StatiMacchina.Pos3ViteAvvitata
                If Prodotto_Act.LetturaDatamatrixPcbAbilitato Then
                    datamatrixPCB = DatamatrixPCBPalletSx
                Else
                    datamatrixPCB = StatiMacchina.DataMatrixSuNastroSx
                End If
                datamatrixOLED = StatiMacchina.DataMatrixSuNastroSx
                imageFilePath = "D:\TRACEABILITY\BENDABLE\SX"
                buonoVite1DSM = StatiMacchina.Pos1ViteAvvitata
                buonoVite2DSM = StatiMacchina.Pos2ViteAvvitata
                buonoVite3DSM = StatiMacchina.Pos3ViteAvvitata
                orientamentoX = StatiMacchina.OrientamentoCameraSX.X
                orientamentoY = StatiMacchina.OrientamentoCameraSX.Y
                orientamentoRotazione = StatiMacchina.OrientamentoCameraSX.RotazioneZ
            Else
                buono_Viti = StatiMacchina.Pos4ViteAvvitata And StatiMacchina.Pos5ViteAvvitata And StatiMacchina.Pos6ViteAvvitata
                If Prodotto_Act.LetturaDatamatrixPcbAbilitato Then
                    datamatrixPCB = DatamatrixPCBPalletDx
                Else
                    datamatrixPCB = StatiMacchina.DataMatrixSuNastroDx
                End If
                datamatrixOLED = StatiMacchina.DataMatrixSuNastroDx
                imageFilePath = "D:\TRACEABILITY\BENDABLE\DX"
                buonoVite1DSM = StatiMacchina.Pos4ViteAvvitata
                buonoVite2DSM = StatiMacchina.Pos5ViteAvvitata
                buonoVite3DSM = StatiMacchina.Pos6ViteAvvitata
                orientamentoX = StatiMacchina.OrientamentoCameraDX.X
                orientamentoY = StatiMacchina.OrientamentoCameraDX.Y
                orientamentoRotazione = StatiMacchina.OrientamentoCameraDX.RotazioneZ
            End If

            prod = New Product


            With prod
                .DateTime = ora
                .ModelID = Sett.Id_Modello
                .ModelName = Sett.modello
                .VersionID = Sett.Id_Tool
                .VersionName = Sett.Prodotto
                .DatamatrixPCB = datamatrixPCB
                .ScrewGlobalResult = buono_Viti
                .GlobalResult = .ScrewGlobalResult
                .LetturaDatamatrixPcbAbilitato = Prodotto_Act.LetturaDatamatrixPcbAbilitato
            End With
            Loc_Context.Products.Add(prod)

            Dim NIPCodeDMX_A As String = DMX_A.Substring(DMX_A.Length - 4, 4)
            _dsmModelIDA = DM_DSM_M_ID.Where(Function(x) String.Equals(x.NIPCode, NIPCodeDMX_A)).Select(Function(y) y.DSM_ModelID).FirstOrDefault()
            If _dsmModelIDA < 0 Then
                _dsmModelIDA = 0
            End If


            ''---------  SOLO OLED ------
            oled = New InfoOled
            With oled
                .DateTime = ora
                .Side = False
                .ScrewResult = buono_Viti '80.1                
                .Datamatrix = datamatrixOLED
                .Orientation_X = orientamentoX
                .Orientation_Y = orientamentoY
                .Orientation_RZ = orientamentoRotazione
                .PhotoFileName = imageFilePath & "\" & .Datamatrix & ".jpg"
                .Product = prod
            End With
            Loc_Context.InfoOleds.Add(oled)

            Loc_Context.SaveChanges()


            'ZONA DSM
            If Not Sett.TMServer Then Return True
            Dim i As Integer

            Dim _Op_Desc As String = DSM_Gen_Data.Gen.Oper_Descr_2

            DSM_Compon.Clear()        '
            For i = 0 To DSM_Fase_List.Count - 1
                DSM_Fase_List(i).stepOperationAttempts(0).measurements.Clear()
            Next

            '-----2  Componenti 
            Dim OledDSM As New DSMWebAPI.Component
            With OledDSM
                .componentCode = oled.Datamatrix
                .componentId = "1"
                .componentName = "Datamatrix_OLED_1"
            End With
            DSM_Compon.Add(OledDSM)



            '----- VITI 
            If (Dsm_List_Id7 > -1) Then 'SCREW List_ID7
                Dim Dsm_Tr_Misura2 = New DSMWebAPI.Measurement
                With Dsm_Tr_Misura2
                    .eventDateTime = Now
                    .measureUnit = ""
                    .variableId = "1"
                    .variableName = "ScrewResult"
                    .valueMax = ""
                    .valueMin = ""
                    If buonoVite1DSM Then
                        .value = "1"
                    Else
                        .value = "3"
                    End If
                End With
                DSM_Fase_List(Dsm_List_Id7).stepOperationAttempts(0).measurements.Add(Dsm_Tr_Misura2)
                DSM_Fase_List(Dsm_List_Id7).stepResult = Dsm_Tr_Misura2.value
                DSM_Fase_List(Dsm_List_Id7).stepOperationAttempts(0).attemptValue = CInt(Val(Dsm_Tr_Misura2.value))

                Dim Dsm_Tr_Misura3 = New DSMWebAPI.Measurement
                With Dsm_Tr_Misura3
                    .eventDateTime = Now
                    .measureUnit = ""
                    .variableId = "2"
                    .variableName = "ScrewResult"
                    .valueMax = ""
                    .valueMin = ""
                    If buonoVite2DSM Then
                        .value = "1"
                    Else
                        .value = "3"
                    End If
                End With
                DSM_Fase_List(Dsm_List_Id7).stepOperationAttempts(0).measurements.Add(Dsm_Tr_Misura3)
                DSM_Fase_List(Dsm_List_Id7).stepResult = Dsm_Tr_Misura3.value
                DSM_Fase_List(Dsm_List_Id7).stepOperationAttempts(0).attemptValue = CInt(Val(Dsm_Tr_Misura3.value))

                Dim Dsm_Tr_Misura4 = New DSMWebAPI.Measurement
                With Dsm_Tr_Misura4
                    .eventDateTime = Now
                    .measureUnit = ""
                    .variableId = "3"
                    .variableName = "ScrewResult"
                    .valueMax = ""
                    .valueMin = ""
                    If buonoVite3DSM Then
                        .value = "1"
                    Else
                        .value = "3"
                    End If
                End With
                DSM_Fase_List(Dsm_List_Id7).stepOperationAttempts(0).measurements.Add(Dsm_Tr_Misura4)
                DSM_Fase_List(Dsm_List_Id7).stepResult = Dsm_Tr_Misura4.value
                DSM_Fase_List(Dsm_List_Id7).stepOperationAttempts(0).attemptValue = CInt(Val(Dsm_Tr_Misura4.value))
            End If



            '****************************
            Dim DSM_T_Req As DSMWebAPI.TRequest

            Dim DSM_CompSect As New List(Of DSMWebAPI.componentSection)
            Dim _CompSect = New DSMWebAPI.componentSection With {.components = New List(Of DSMWebAPI.Component)}
            DSM_CompSect.Add(_CompSect)
            For i = 0 To DSM_Compon.Count - 1
                DSM_CompSect(0).components.Add(DSM_Compon(i))
            Next

            Dim DSM_Fase_List_Ext As New List(Of DSMWebAPI.stepSection)
            For i = 0 To DSM_Fase_List.Count - 1
                DSM_Fase_List_Ext.Add(DSM_Fase_List(i))
            Next

            TMS_Dx_Busy = True : TMS_Rep_S = True
            DSM_T_Req = New DSMWebAPI.TRequest With {.lineDescription = DSM_Gen_Data.Gen.Line_Descr_2, .lineId = DSM_Gen_Data.Gen.Line_Id_2, .productCode = prod.DatamatrixPCB, .operationId = DSM_Gen_Data.Gen.Oper_Id_2, .operationDescription = _Op_Desc, .eventDate = Now, .inEventDate = Now, .modelCode = _dsmModelIDA.ToString(), .componentSection = DSM_CompSect, .stepSection = DSM_Fase_List_Ext, .worker = "", .boxCode = "", .groupCode = "", .messageId = ""}  'DSM_Model_ID.ToString
            TMSRV.SendTraceability(20, _Op_Desc, DSM_Gen_Data.Gen.Base_Addr2, DSM_Gen_Data.Gen.Trace_ThreadD, DSM_Gen_Data.Gen.Trace_TokenD, DSM_T_Req)

        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function



#End Region


    Public Sub AggiornaSnapshot()
        SyncLock PlcLock
            Dim last As Integer = CInt(IndiceUltimoDato)
            If last < 0 Then last = 0
            If last > INFO_COUNT - 1 Then last = INFO_COUNT - 1

            If InfosSnap Is Nothing OrElse InfosSnap.Length <> (last + 1) Then
                ReDim InfosSnap(last) ' dimensione = last+1
            End If

            Array.Copy(Infos, InfosSnap, last + 1)
            LastIndexSnap = CUShort(last)
            LastUpdateDatetime = DateTime.Now
            WindowSeconds = CDbl(InfosSnap(last).Tempo) / 1000.0
        End SyncLock
    End Sub


    Public Function BuildSnapshotDto() As CelleCaricoSnapshot
        ' Qui salvo i dati che sto effettivamente usando in plot (quindi _infosSnap)
        Dim infosCopy As InfoPlc() = Array.Empty(Of InfoPlc)()

        If InfosSnap IsNot Nothing AndAlso InfosSnap.Length > 0 Then
            infosCopy = CType(InfosSnap.Clone(), InfoPlc())
        End If

        Return New CelleCaricoSnapshot With {
        .SavedAt = LastUpdateDatetime,
        .WindowSeconds = WindowSeconds,
        .LastIndex = LastIndexSnap,
        .Infos = infosCopy
    }
    End Function
End Module

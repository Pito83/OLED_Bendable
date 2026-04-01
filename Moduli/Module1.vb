
Imports System.Data
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Threading
Imports Oled.DataLayer
Imports System.ServiceProcess


Module Module1

    Friend Class CelleCaricoSnapshot
        Public Property SavedAt As DateTime
        Public Property WindowSeconds As Double
        Public Property LastIndex As UShort
        Public Property Infos As InfoPlc()
    End Class



    Private _mainForm As F_main
    Friend PaginaAperta As String = ""
    Friend Main_dir As String = "D:\AL\"
    Friend Loc_mdi As New Point(5, 100)
    Friend SQLRunningTimeoutSecondsCounter As Integer = 0
    Friend SQLStatusText As String = ""
    Friend _thrSQL As Thread
    Friend SQLStarted As Boolean = False
    'Friend cc As CultureInfo = Threading.Thread.CurrentThread.CurrentCulture

    Friend ManualTriggerCella As Boolean
    Friend ManualSXReadReq, ManualDXReadReq As Boolean


    Friend Trace_Db_Server As String = "192.168.0.85"
    'Friend Trace_Db_Server As String = "DESKTOP-A7JRGUJ\SQLEXPRESS"
    Friend Trace_Db_User As String = "SAIEE"
    Friend Trace_Db_Pw As String = "saiee35227"
    Friend Trace_Db_Name As String = "ST20XDB"

    Friend nfi As NumberFormatInfo = New CultureInfo("it-IT", False).NumberFormat
    'Friend dtf As DateTimeFormatInfo = New CultureInfo("it-IT", False).DateTimeFormat
    'Friend nfi As NumberFormatInfo = New NumberFormatInfo
    'Friend nfi As NumberFormatInfo = New cc.NumberFormat
    Friend Err_txt, File_Err_txt As String
    Friend chiudo, Err_sys, Init_opzio, New_Init_Option As Boolean
    Friend ByPassTrueInit As Boolean
    Friend Articoli_dir As String = Main_dir '& "Articoli\"
    Friend Work_dir As String
    Friend N_bits As Integer = 32

    Friend F_param As Form
    Friend F_manuali As Form
    Friend F_celleCarico As Form_celleCarico
    Friend F_Staz_1_2 As Form_sinottico
    Friend F_pezzi As Form
    Friend F_allarmi As Form

    Friend F_home As Form

    Friend _rtv As String = Nothing
    Friend _rtv2 As String = Nothing

    Friend Log_1, Log_2, Log_3, Log_4, Log_5 As Boolean
    Friend Modifica, _Agg_St3 As Boolean

    Friend N_posaggi As Integer
    'Mulitilingua
    Friend lingua As String    'lingua selezionata
    Friend n_bytes_all As Integer = 16
    Friend all_nr As New BitArray(n_bytes_all * 8)
    Friend Mall_nr As New BitArray(n_bytes_all * 8)
    Friend testi(599), List_Allarmi(n_bytes_all * 8) As String 'testi 

    Friend _edit As Boolean = False

    Friend RefreshFormPlotCelleDiCarico As Boolean = False

    Friend GestioneDataMatrixPalletSx As LetturaDatamatrix
    Friend GestioneDataMatrixPalletDx As LetturaDatamatrix
    '----------------IBH-----------

    '------------PLC--------------------
    'Friend stati As New BitArray(127)
    <Serializable()> Public Structure PuntoRobotUDT
        Public Z As Integer                 '[microm]
        Public Y As Integer                 '[microm]
        Public X As Integer                 '[microm]
        Public RotazioneZ As Integer        '[*0.0001 gradi]
        Public RotazioneY As Integer        '[*0.0001 gradi]
        Public RotazioneX As Integer        '[*0.0001 gradi]
    End Structure
    <Serializable()> Public Structure PosizioneAvvitatoreUDT
        Public R1 As Integer
        Public R2 As Integer
        Public H As Integer
    End Structure
    <Serializable()> Public Structure OffsetVisione
        Public X As Double
        Public Y As Double
        Public Rotazione As Double
    End Structure
    <Serializable()> Public Structure StatiPLC

        Public ConsensoPLCACaricamentoRicetta As Boolean

        Public NastroSxSingolarizzatoreEsternoAbbassato As Boolean
        Public NastroSxSingolarizzatoreEsternoRitornato As Boolean
        Public NastroSxSingolarizzatoreInternoAbbassato As Boolean
        Public NastroSxSingolarizzatoreInternoRitornato As Boolean
        Public NastroSxSollevatoreLatoRobotAlzato As Boolean
        Public NastroSxSollevatoreLatoRobotAbbassato As Boolean
        Public NastroSxPalletSvincoloOledSvincolato As Boolean
        Public NastroSxPalletSvincoloOledRilasciato As Boolean
        Public NastroSxPalletPompaVuotoFrameVuotoFatto As Boolean
        Public NastroSxPalletPompaVuotoFrameRilasciato As Boolean
        Public NastroSxPalletPompaVuotoOledSupportoVuotoFatto As Boolean
        Public NastroSxPalletPompaVuotoOledSupportoRilasciato As Boolean
        Public NastroSxPalletPompaVuotoSupportoVuotoFatto As Boolean
        Public NastroSxPalletPompaVuotoSupportoRilasciato As Boolean
        Public NastroSxPalletPompaVuotoBiadesivoVuotoFatto As Boolean
        Public NastroSxPalletPompaVuotoBiadesivoRilasciato As Boolean
        Public NastroSxPalletAssePosizioneInterno As Boolean
        Public NastroSxPalletAssePosizioneOperatore As Boolean


        Public NastroDxSingolarizzatoreEsternoAbbassato As Boolean
        Public NastroDxSingolarizzatoreEsternoRitornato As Boolean
        Public NastroDxSingolarizzatoreInternoAbbassato As Boolean
        Public NastroDxSingolarizzatoreInternoRitornato As Boolean
        Public NastroDxSollevatoreLatoRobotAlzato As Boolean
        Public NastroDxSollevatoreLatoRobotAbbassato As Boolean
        Public NastroDxPalletSvincoloOledSvincolato As Boolean
        Public NastroDxPalletSvincoloOledRilasciato As Boolean
        Public NastroDxPalletPompaVuotoFrameVuotoFatto As Boolean
        Public NastroDxPalletPompaVuotoFrameRilasciato As Boolean
        Public NastroDxPalletPompaVuotoOledSupportoVuotoFatto As Boolean
        Public NastroDxPalletPompaVuotoOledSupportoRilasciato As Boolean
        Public NastroDxPalletPompaVuotoSupportoVuotoFatto As Boolean
        Public NastroDxPalletPompaVuotoSupportoRilasciato As Boolean
        Public NastroDxPalletPompaVuotoBiadesivoVuotoFatto As Boolean
        Public NastroDxPalletPompaVuotoBiadesivoRilasciato As Boolean
        Public NastroDxPalletAssePosizioneInterno As Boolean
        Public NastroDxPalletAssePosizioneOperatore As Boolean

        Public NastroSxPalletPompaVuotoOledVuotoFatto As Boolean
        Public NastroSxPalletPompaVuotoOledVuotoRilasciato As Boolean

        Public NastroDxPalletPompaVuotoOledVuotoFatto As Boolean
        Public NastroDxPalletPompaVuotoOledVuotoRilasciato As Boolean


        Public NastroDxInMovimento As Boolean
        Public NastroSxInMovimento As Boolean

        Public AllarmeNastri As Boolean

        Public InternoPurificatoreAriaAcceso As Boolean
        Public InternoPurificatoreAriaSpento As Boolean
        Public InternoAspiratoreLinerAcceso As Boolean
        Public InternoAspiratoreLinerSpento As Boolean
        Public InternoPlasmaAcceso As Boolean
        Public InternoPlasmaSpento As Boolean


        Public IlluminazioneMagazzinoAccesa As Boolean
        Public IlluminazioneNastriAccesa As Boolean
        Public IlluminazioneOledAccesa As Boolean
        Public IlluminazioneManoDiPresaCalibrazioneAccesa As Boolean
        Public IlluminazioneIncollaggio1Accesa As Boolean
        Public IlluminazioneIncollaggio2Accesa As Boolean

        Public MagazzinoSxTraslazioneInternoRaggiunta As Boolean
        Public MagazzinoSxTraslazioneOperatoreRaggiunta As Boolean
        Public MagazzinoSxAsseVassoiAlzato As Boolean
        Public MagazzinoSxAsseVassoiAbbassato As Boolean

        Public MagazzinoDxTraslazioneInternoRaggiunta As Boolean
        Public MagazzinoDxTraslazioneOperatoreRaggiunta As Boolean
        Public MagazzinoDxAsseVassoiAlzato As Boolean
        Public MagazzinoDxAsseVassoiAbbassato As Boolean

        Public MagazzinoSxFuori As Boolean
        Public MagazzinoSxDentro As Boolean
        Public MagazzinoDxFuori As Boolean
        Public MagazzinoDxDentro As Boolean
        Public MagazzinoDxCodificaAttuale As UShort 'Magazzino Dx AKA B --> novità del 27/11
        Public MagazzinoSxCodificaAttuale As UShort 'Magazzino Sx AKA A --> novità del 27/11

        Public CameraBassaValutaDataMatrix As Boolean            'Usato quando sono con il robot con l'OLED in zona camera (prima parte)
        Public CameraBassaValutaOrientamento As Boolean
        Public CameraBassaValutaPezzoOk As Boolean                              'Usato quando sono con il robot con l'OLED in zona camera (seconda parte)
        Public CameraAltaValutaPezzoOk As Boolean                               'Usato quando l'OLED è posizionato in zona incollaggio e il robot è fuori ingombro
        Public TracciaDSM As Boolean
        Public TracciaDB As Boolean
        Public InterventoBarrieraMagazzini As Boolean

        Public PresenzaOledPosaggioSx As Boolean
        Public PresenzaSupportoPosaggioSx As Boolean
        Public PresenzaBiadesivoPosaggioSx As Boolean
        Public PresenzaCornicePosaggioSx As Boolean
        Public PresenzaBracketPosaggioSx As Boolean
        Public PresenzaPezzoFinitoPosaggioSx As Boolean

        Public PosaggioSxInCiclo As Boolean

        Public PresenzaOledPosaggioDx As Boolean
        Public PresenzaSupportoPosaggioDx As Boolean

        Public PresenzaBiadesivoPosaggioDx As Boolean
        Public PresenzaCornicePosaggioDx As Boolean
        Public PresenzaBracketPosaggioDx As Boolean
        Public PresenzaPezzoFinitoPosaggioDx As Boolean

        Public PosaggioDxInCiclo As Boolean


        Public IncollaggioPompaVuotoOledSxFatto As Boolean
        Public IncollaggioPompaVuotoOledSxRilasciato As Boolean
        Public IncollaggioPompaVuotoOledDxFatto As Boolean
        Public IncollaggioPompaVuotoOledDxRilasciato As Boolean

        Public RimozioneLinerAbilitata As Boolean

        'Public CameraBassaValutaDataMatrixConOrientamentoDone As Boolean        'Procedura terminata
        'Public CameraBassaValutaDataMatrixConOrientamentoOk As Boolean          'True: pezzo processabile; False: pezzo scarto
        'Public CameraBassaValutaPezzoOkDone As Boolean                          'Procedura terminata
        'Public CameraBassaValutaPezzoOkOk As Boolean                            'True: pezzo processabile; False: pezzo scarto
        'Public CameraAltaValutaPezzoOkDone As Boolean                           'Procedura terminata
        'Public CameraAltaValutaPezzoOkOk As Boolean                             'True: pezzo processabile; False: pezzo scarto

        Public MissioneRobotInCorso As Integer

        Public ComandiOn As Boolean
        Public AutomaticoOn As Boolean
        Public CicloOn As Boolean
        Public CicloRun As Boolean
        Public PLCAlarm As Boolean 'cumulativo
        Public RobotAlarm As Boolean 'cumulativo
        Public PlasmaturaAlarm As Boolean 'cumulativo
        Public MagazzinoAlarm As Boolean 'cumulativo
        Public AvvitaturaAlarm As Boolean 'cumulativo
        Public PresenzaScarti As Boolean

        Public DataMatrixSuNastroSx As String
        Public DataMatrixSuNastroDx As String

        Public ManoDiPresa1 As PuntoRobotUDT
        Public ManoDiPresa2 As PuntoRobotUDT
        Public CameraBassa As PuntoRobotUDT()
        Public PalletSuNastroSxBiadesivo As PuntoRobotUDT
        Public PalletSuNastroSxSupporto As PuntoRobotUDT
        Public PalletSuNastroSxPezzoFinito As PuntoRobotUDT
        Public PalletSuNastroDxBiadesivo As PuntoRobotUDT
        Public PalletSuNastroDxSupporto As PuntoRobotUDT
        Public PalletSuNastroDxPezzoFinito As PuntoRobotUDT
        Public Incollaggio As PuntoRobotUDT
        Public MagazzinoSxOledSx As PuntoRobotUDT
        Public MagazzinoSxOledDx As PuntoRobotUDT
        Public MagazzinoSxVassoio As PuntoRobotUDT
        Public MagazzinoDxOledSx As PuntoRobotUDT
        Public MagazzinoDxOledDx As PuntoRobotUDT
        Public MagazzinoDxVassoio As PuntoRobotUDT
        Public PosizioneScarto1 As PuntoRobotUDT
        Public PosizioneScarto2 As PuntoRobotUDT
        Public PosizioneScarto3 As PuntoRobotUDT
        Public PosizioneScarto4 As PuntoRobotUDT
        Public Plasma As PuntoRobotUDT
        Public StrappoLiner As PuntoRobotUDT
        Public VassoiVuoti As PuntoRobotUDT
        Public PosizioneCameraBassa1 As PuntoRobotUDT
        Public PosizioneCameraBassa2 As PuntoRobotUDT
        Public PosizioneCameraAlta As PuntoRobotUDT

        'Public ProgrammaVisionedaPLC As UShort
        Public RobotOverrideValue As UShort

        Public ConteggioPezziBuoni As Long
        Public ConteggioPezziScarti As Long

        Public ScartoInPosizione1Tavolino As Boolean
        Public ScartoInPosizione2Tavolino As Boolean
        Public ScartoInPosizione3Tavolino As Boolean
        Public ScartoInPosizione4Tavolino As Boolean
        Public ScartoInPosizione5Spare As Boolean
        Public ScartoInPosizione6Spare As Boolean
        Public ScartoInPosizione7Spare As Boolean
        Public ScartoInPosizione8Spare As Boolean

        Public TipologiaScartoInPosizione1Tavolino As TipoScarto
        Public TipologiaScartoInPosizione2Tavolino As TipoScarto
        Public TipologiaScartoInPosizione3Tavolino As TipoScarto
        Public TipologiaScartoInPosizione4Tavolino As TipoScarto

        Public MagazzinoDiProvenienzaScartoInPosizione1Tavolino As Integer '0-> Magazzino A, 1-> MagazzinoB
        Public MagazzinoDiProvenienzaScartoInPosizione2Tavolino As Integer '0-> Magazzino A, 1-> MagazzinoB
        Public MagazzinoDiProvenienzaScartoInPosizione3Tavolino As Integer '0-> Magazzino A, 1-> MagazzinoB
        Public MagazzinoDiProvenienzaScartoInPosizione4Tavolino As Integer '0-> Magazzino A, 1-> MagazzinoB

#Region "ROBOTTO"

        Public ManoDiPresaVuotoOn As Boolean
        Public ManoDiPresaPinzaAperta As Boolean
        Public ManoDiPresaPinzaChiusa As Boolean
        Public ManoDiPresaIndexAvanti As Boolean
        Public ManoDiPresaIndexIndietro As Boolean

        Public RobotMissionVaiZonaCameraInCorso As Boolean
        Public RobotMissioneHomeInCorso As Boolean
        Public RobotMissionePrelevaSupportoNastroSxInCorso As Boolean
        Public RobotMissioneIncollaBiadesivoSuSupportoNastroSxInCorso As Boolean
        Public RobotMissioneDepositaPezzoFinitoSuNastroSxInCorso As Boolean
        Public RobotMissionePrelevaSupportoNastroDxInCorso As Boolean
        Public RobotMissioneIncollaBiadesivoSuSupportoNastroDxInCorso As Boolean
        Public RobotMissioneDepositaPezzoFinitoSuNastroDxInCorso As Boolean
        Public RobotMissioneDepositaOledInIncollaggioInCorso As Boolean
        Public RobotMissioneIncollaSupportoConOledInIncollaggioInCorso As Boolean
        Public RobotMissionePrelevaOledSxMagazzinoSxInCorso As Boolean
        Public RobotMissionePrelevaOledDxMagazzinoSxInCorso As Boolean
        Public RobotMissionePrelevaVassoioMagazzinoSxInCorso As Boolean
        Public RobotMissionePrelevaOledSxMagazzinoDxInCorso As Boolean
        Public RobotMissionePrelevaOledDxMagazzinoDxInCorso As Boolean
        Public RobotMissionePrelevaVassoioMagazzinoDxInCorso As Boolean
        Public RobotMissioneDepositaVassoioVuotoInCorso As Boolean
        Public RobotMissioneIonizzatoreInCorso As Boolean
        Public RobotMissioneDepositaOledScartoPosizione1InCorso As Boolean
        Public RobotMissioneDepositaOledScartoPosizione2InCorso As Boolean
        Public RobotMissioneDepositaOledScartoPosizione3InCorso As Boolean
        Public RobotMissioneDepositaOledScartoPosizione4InCorso As Boolean
        Public RobotMissioneFaiCicloPlasmaturaInCorso As Boolean
        Public RobotMissioneStrappaLinerInCorso As Boolean
        Public RobotMissioneRaccogliOledScartoDaIncollaggioInCorso As Boolean
        'FORGOTTEN FROM GOD...
        Public RobotMissioneVassoiVuotiInCorso As Boolean
        Public RobotMissioneDepositaManoSxPos_1InCorso As Boolean
        Public RobotMissioneAcquisizioneManoSxPos_1InCorso As Boolean
        Public RobotMissioneDepositaManoSxPos_2InCorso As Boolean
        Public RobotMissioneAcquisizioneManoSxPos_2InCorso As Boolean
        Public RobotMissioneDepositaManoSxPos_3InCorso As Boolean
        Public RobotMissioneAcquisizioneManoSxPos_3InCorso As Boolean
        Public RobotMissioneDepositaManoDxPos_4InCorso As Boolean
        Public RobotMissioneAcquisizioneManoDxPos_4InCorso As Boolean
        Public RobotMissioneDepositaManoDxPos_5InCorso As Boolean
        Public RobotMissioneAcquisizioneManoDxPos_5InCorso As Boolean
        Public RobotMissioneDepositaManoDxPos_6InCorso As Boolean
        Public RobotMissioneAcquisizioneManoDxPos_6InCorso As Boolean


        Public RobotCodiceMissioneInCorso As Integer
        Public RobotDescrizioneMissioneInCorso As String
        Public RobotCodicePosizioneAttuale As Integer
        Public RobotDescrizionePosizioneAttuale As String

        Public RobotCodicePresenzaPezzi As Integer
        Public RobotDescrizionePresenzaPezzi As String
#End Region

#Region "VITI"
        Public Vite1PalletSx As PosizioneAvvitatoreUDT
        Public Vite2PalletSx As PosizioneAvvitatoreUDT
        Public Vite3PalletSx As PosizioneAvvitatoreUDT

        Public Vite1PalletDx As PosizioneAvvitatoreUDT
        Public Vite2PalletDx As PosizioneAvvitatoreUDT
        Public Vite3PalletDx As PosizioneAvvitatoreUDT

        Public PosizioneCorrenteAvvitatore As PosizioneAvvitatoreUDT

        Public Pos1VicinanzaBit1 As Boolean
        Public Pos1VicinanzaBit2 As Boolean
        Public Pos1VicinanzaOverall As Integer
        Public Pos1ViteDaAvvitareAdesso As Boolean
        Public Pos1ViteAvvitata As Boolean
        Public Pos1ViteOk As Boolean

        Public Pos2VicinanzaBit1 As Boolean
        Public Pos2VicinanzaBit2 As Boolean
        Public Pos2VicinanzaOverall As Integer
        Public Pos2ViteDaAvvitareAdesso As Boolean
        Public Pos2ViteAvvitata As Boolean
        Public Pos2ViteOk As Boolean

        Public Pos3VicinanzaBit1 As Boolean
        Public Pos3VicinanzaBit2 As Boolean
        Public Pos3VicinanzaOverall As Integer
        Public Pos3ViteDaAvvitareAdesso As Boolean
        Public Pos3ViteAvvitata As Boolean
        Public Pos3ViteOk As Boolean

        Public Pos4VicinanzaBit1 As Boolean
        Public Pos4VicinanzaBit2 As Boolean
        Public Pos4VicinanzaOverall As Integer
        Public Pos4ViteDaAvvitareAdesso As Boolean
        Public Pos4ViteAvvitata As Boolean
        Public Pos4ViteOk As Boolean

        Public Pos5VicinanzaBit1 As Boolean
        Public Pos5VicinanzaBit2 As Boolean
        Public Pos5VicinanzaOverall As Integer
        Public Pos5ViteDaAvvitareAdesso As Boolean
        Public Pos5ViteAvvitata As Boolean
        Public Pos5ViteOk As Boolean

        Public Pos6VicinanzaBit1 As Boolean
        Public Pos6VicinanzaBit2 As Boolean
        Public Pos6VicinanzaOverall As Integer
        Public Pos6ViteDaAvvitareAdesso As Boolean
        Public Pos6ViteAvvitata As Boolean
        Public Pos6ViteOk As Boolean

        Public PresenzaPezzoDaAvvitareSx As Boolean
        Public PresenzaPezzoDaAvvitareDx As Boolean
#End Region
        Public OffsetVisioneCameraBassa As OffsetVisione
        Public OffsetVisioneCameraAlta As OffsetVisione

        Public OffsetUtenteVisioneCameraBassa As OffsetVisione
        Public OffsetUtenteVisioneCameraAlta As OffsetVisione

        Public OrientamentoCameraSX As PuntoRobotUDT
        Public OrientamentoCameraDX As PuntoRobotUDT

        Public InternoSoffioOn As Boolean

        Public ManoDiPresaAttuale As String
        Public ManoDiPresaConnessa As Integer
        Public MagazzinoAPresenzaPezzi As Integer
        Public MagazzinoAPresenzaPezziDescrizione As String
        Public MagazzinoBPresenzaPezzi As Integer
        Public MagazzinoBPresenzaPezziDescrizione As String

        Public CodificaPalletSx As Integer
        Public CodificaPalletDx As Integer

        Public DatiCellaDiCaricoPronti As Boolean

        ''' <summary>
        ''' INCOLLAGGIO_PRESENZA_PEZZI_NONE	    USInt	0
        ''' INCOLLAGGIO_PRESENZA_PEZZI_OLED	    USInt	1
        ''' INCOLLAGGIO_PRESENZA_PEZZI_OLED_OK	USInt	2
        ''' INCOLLAGGIO_PRESENZA_PEZZI_OLED_NOK	USInt	3
        ''' </summary>
        Public PresenzaPezzoIncollaggio As Integer
        Public CodicePosaggioIncollaggio As Integer

        Public PreorientamentoDaFare As Boolean

        Public Sub New(dummy As Integer)
            CameraBassa = New PuntoRobotUDT(1) {}
        End Sub

        Public RichiestaLetturaDatamatrixPalletSx As Boolean
        Public RichiestaLetturaDatamatrixPalletDx As Boolean


        'ANALOGICHE
        Public VuotoFrameSx As Integer  'VALORI IN MILLIBAR
        Public VuotoSupportoSx As Integer
        Public VuotoBiadesivoSx As Integer
        Public VuotoOledSx As Integer
        Public VuotoFrameDx As Integer
        Public VuotoSupportoDx As Integer
        Public VuotoBiadesivoDx As Integer
        Public VuotoOledDx As Integer
        Public VuotoIncollaggio As Integer
        Public VuotoManoDiPresa As Integer

    End Structure

    Public Enum TipoScarto
        Nessuno
        Datamatrix
        PreOrientamento
        Orientamento
    End Enum
    Public Enum MagazzinoPresenzaPezzi
        MAGAZZINO_PRESENZA_PEZZI_NONE = 0
        MAGAZZINO_PRESENZA_PEZZI_SOLO_VASSOIO = 1
        MAGAZZINO_PRESENZA_PEZZI_SOLO_OLED_DX = 2
        MAGAZZINO_PRESENZA_PEZZI_OLED_SX_OLED_DX = 3
    End Enum
    Public Enum ManoDiPresa
        ROBOT_MANO_DI_PRESA_UNKNOWN = 0
        ROBOT_MANO_DI_PRESA_SX_POSTO_1 = 1
        ROBOT_MANO_DI_PRESA_DX_POSTO_2 = 2
        ROBOT_MANO_DI_PRESA_SX_POSTO_3 = 3
        ROBOT_MANO_DI_PRESA_DX_POSTO_4 = 4
        ROBOT_MANO_DI_PRESA_SX_POSTO_5 = 5
        ROBOT_MANO_DI_PRESA_DX_POSTO_6 = 6
        ROBOT_MANO_DI_PRESA_ASSENTE = 255
    End Enum

    Public Enum PosizioneRobot
        ROBOT_POSIZIONE_UNKNOWN = 0
        ROBOT_POSIZIONE_HOME = 1
        ROBOT_POSIZIONE_MAGAZZINO_SX_OLED_SX = 11
        ROBOT_POSIZIONE_MAGAZZINO_SX_OLED_DX = 12
        ROBOT_POSIZIONE_MAGAZZINO_DX_OLED_SX = 13
        ROBOT_POSIZIONE_MAGAZZINO_DX_OLED_DX = 14
        ROBOT_POSIZIONE_MAGAZZINO_SX_VASSOIO = 15
        ROBOT_POSIZIONE_MAGAZZINO_DX_VASSOIO = 16
        ROBOT_POSIZIONE_VASSOI_VUOTI = 17
        ROBOT_POSIZIONE_CAMERA = 21
        ROBOT_POSIZIONE_IN_NASTRO_SX_SUPPORTO = 31
        ROBOT_POSIZIONE_IN_NASTRO_SX_BIADESIVO = 32
        ROBOT_POSIZIONE_IN_NASTRO_SX_OLED_SUPPORTO = 33
        ROBOT_POSIZIONE_IN_NASTRO_DX_SUPPORTO = 34
        ROBOT_POSIZIONE_IN_NASTRO_DX_BIADESIVO = 35
        ROBOT_POSIZIONE_IN_NASTRO_DX_OLED_SUPPORTO = 36
        ROBOT_POSIZIONE_INCOLLAGGIO_DEPOSITO_SX = 41
        ROBOT_POSIZIONE_INCOLLAGGIO_DEPOSITO_DX = 42
        ROBOT_POSIZIONE_INCOLLAGGIO_INCOLLA_SX = 43
        ROBOT_POSIZIONE_INCOLLAGGIO_INCOLLA_DX = 44
        ROBOT_POSIZIONE_PLASMA_SX = 45
        ROBOT_POSIZIONE_PLASMA_DX = 46
        ROBOT_POSIZIONE_STRAPPO_LINER_SX = 47
        ROBOT_POSIZIONE_STRAPPO_LINER_DX = 48
        ROBOT_POSIZIONE_INCOLLAGGIO_RACCOLTA_SCARTO_SX = 50
        ROBOT_POSIZIONE_INCOLLAGGIO_RACCOLTA_SCARTO_DX = 51
        ROBOT_POSIZIONE_IONIZZATURA = 91
        ROBOT_POSIZIONE_OLED_SCARTO_1 = 101
        ROBOT_POSIZIONE_OLED_SCARTO_2 = 102
        ROBOT_POSIZIONE_OLED_SCARTO_3 = 103
        ROBOT_POSIZIONE_OLED_SCARTO_4 = 104
        ROBOT_POSIZIONE_DEPOSITO_MANO_DI_PRESA_SX_POSTO_1 = 121 'Posto: centrale esterno
        ROBOT_POSIZIONE_ACQUISIZIONE_MANO_DI_PRESA_SX_POSTO_1 = 122 'Posto: centrale esterno
        ROBOT_POSIZIONE_DEPOSITO_MANO_DI_PRESA_DX_POSTO_2 = 123 'Posto: laterale sinistro esterno
        ROBOT_POSIZIONE_ACQUISIZIONE_MANO_DI_PRESA_DX_POSTO_2 = 124 'Posto: laterale sinistro esterno
        ROBOT_POSIZIONE_DEPOSITO_MANO_DI_PRESA_SX_POSTO_3 = 125
        ROBOT_POSIZIONE_ACQUISIZIONE_MANO_DI_PRESA_SX_POSTO_3 = 126
        ROBOT_POSIZIONE_DEPOSITO_MANO_DI_PRESA_DX_POSTO_4 = 127
        ROBOT_POSIZIONE_ACQUISIZIONE_MANO_DI_PRESA_DX_POSTO_4 = 128
        ROBOT_POSIZIONE_DEPOSITO_MANO_DI_PRESA_SX_POSTO_5 = 129
        ROBOT_POSIZIONE_ACQUISIZIONE_MANO_DI_PRESA_SX_POSTO_5 = 130
        ROBOT_POSIZIONE_DEPOSITO_MANO_DI_PRESA_DX_POSTO_6 = 131
        ROBOT_POSIZIONE_ACQUISIZIONE_MANO_DI_PRESA_DX_POSTO_6 = 132
    End Enum

    Public Enum CodicePresenzaPezziRobot
        ROBOT_PRESENZA_PEZZI_NONE = 0
        ROBOT_PRESENZA_PEZZI_OLED = 1
        ROBOT_PRESENZA_PEZZI_OLED_OK = 2
        ROBOT_PRESENZA_PEZZI_OLED_NOK = 3
        ROBOT_PRESENZA_PEZZI_SUPPORTO = 4
        ROBOT_PRESENZA_PEZZI_SUPPORTO_PLASMATO = 5
        ROBOT_PRESENZA_PEZZI_SUPPORTO_PLASMATO_CON_BIADESIVO = 6
        ROBOT_PRESENZA_PEZZI_SUPPORTO_PLASMATO_CON_BIADESIVO_IONIZZATO = 7
        ROBOT_PRESENZA_PEZZI_SUPPORTO_PLASMATO_CON_BIADESIVO_IONIZZATO_CON_OLED = 8
        ROBOT_PRESENZA_PEZZI_SUPPORTO_PLASMATO_CON_BIADESIVO_IONIZZATO_CON_OLED_SENZA_LINER = 9
        ROBOT_PRESENZA_PEZZI_VASSOIO = 10
    End Enum

    Friend Structure InfoPlc
        Public Tempo As UShort   ' UINT Siemens (16 bit unsigned)
        Public Valore As UShort  ' UINT Siemens (16 bit unsigned)
    End Structure

    Public Const INFO_COUNT As Integer = 200
    Friend IndiceUltimoDato As UShort
    Friend Infos(INFO_COUNT - 1) As InfoPlc

    Friend PlcLock As New Object()

    Friend StatiMacchina As New StatiPLC
    Private RobotMissionMap As Dictionary(Of PosizioneRobot, Action)
    Private RobotPosizioneMap As Dictionary(Of PosizioneRobot, Action)
    Private ManoDiPresaMap As Dictionary(Of ManoDiPresa, Action)
    Private MagazzinoAPresenzaPezziMap As Dictionary(Of MagazzinoPresenzaPezzi, Action)
    Private MagazzinoBPresenzaPezziMap As Dictionary(Of MagazzinoPresenzaPezzi, Action)
    Private CodiceRobotPresenzaPezziMap As Dictionary(Of CodicePresenzaPezziRobot, Action)

    Friend DatamatrixPCBPalletSx As String
    Friend DatamatrixPCBPalletDx As String
    Friend LastPCBDatamatrixScanOnSx As Boolean

    Friend CorrTlc(11) As Byte
    Friend PLC_alarm, Tutto_Buono_dx, Tutto_Buono_sx, PZ_dx_no, PZ_sx_no, Posagg_Unico, P3_Presente, plc_SingleOperator As Boolean
    Friend Comandi_On, Automatico, mem_automatico, Barriera_ok, req_dati2, req_dati_ready2 As Boolean
    Friend Ciclo_on, Ciclo_Run, Ciclo_Off, Mem_ciclo_on, Cambio_piastra, Mem_cambio_piastra, req_dati, req_dati_ready, _exe_tasti_rt, Primo_Ciclo, Agg_Ultimi_Act_Sin As Boolean
    Friend Piastra_att As Integer
    ''' <summary>
    ''' The device => 1 SINISTRI / 2 DESTRI
    ''' </summary>
    Friend Device As Integer
    Friend T_Ciclo As Integer
    Friend Messaggio As String = ""
    Friend _ERR As Boolean
    'Friend Rd_stati(100) As Byte
    'Friend plc_MappaScarti(50) As Byte
    'Friend MappaScartiPosizione(9) As Integer
    'Friend MappaScartiMagazzino(9) As Integer
    'Friend MappaScartiDaCamera1o3(9) As Integer
    Friend N_sinitt As Integer = 0
    Friend Machine_Status As String = ""

    Friend plc_dataPressa(2) As Byte
    Friend plc_PressaMagazinoOLED As Integer
    Friend plc_PressaPosizioneOLED As Integer

    Friend BytesMessaggiPLC(7) As Byte

    '--------variabili in lettura sui forms----
    Friend N_MDI_from, Auto_Mode As Integer
    Friend _Ord_tasti_on, _Ord_tasti_off, _tasti_rt As Integer 'manuali
    Friend _ord_acc_dx, _ord_acc_sx, _ord_spegni_dx, _ord_spegni_sx As Boolean 'Pagina manuali
    Friend Ultimi_valori(49) As Byte    'attuali
    Friend _Ord_pz As Integer = 0          'pezzi
    Friend Act_val(8), Allarmi(), Contatori() As Byte           'sinottico
    ' Friend Valori_magazz(41), Act_Magazz(3), Dati_Mag(25) As Byte    'attuali
    Friend Valori_magazz(99), Act_Tavola(3), Act_Rotaz(3), Dati_Mag(3) As Byte    'attuali magazzino
    '  Friend Dati_Mag(5) As Integer
    Friend WR_Dato_Short As Short
    Friend Num_Dato, WR_Dato_32, Wr_Cod_P2 As Integer
    Friend WR_Dato_R As Single

    Friend Wd_Magazz As UShort
    Friend _aggiorna, _agg_led_sx, _agg_led_dx, Ord_salva_mag, Start_mag, Opzio_mag_rd, Opzio_mag_wr, Luce_on As Boolean
    Friend _tx_dati, Ord_Piastra_Save, Salva_Sett, _Rx_Dati_Gen, _Agg_Lay_Viti As Boolean
    '------------------------messaggi al supervisore---
    'Friend SupV As RADProcessResults.ProcessDataAcquisition
    '--------------Francia-----------
    Friend Act_Giorno, Cyc_test As Integer
    Friend Show_form_test, F_test_on As Boolean
    Friend _Dataset_file, _visio, _utente As String
    Friend Lett_Hold, Wr_Hold_lett, Plc_Cyc_Test, form_lett_off, Tologoff, Wr_Plc_Ok_Verrou, Refresh_Led_Verrou, OK_Verrou, Abort_Verrou As Boolean

    Friend _usb_scan As New Class_usb.Class_usb
    Friend _PW1 As String = "1111"
    Friend N_Viti_Sx As Integer = 0
    Friend N_Viti_Dx As Integer = 0


    Friend ReadOnly DatamatrixMgr As New LetturaDatamatrixManager()
#Region "Robot"
    Friend Robot_Alarm, BAll_Robot, Simula, Escl_Avvita, Wr_Bool As Boolean
    'Friend Cmd_Jog, Cmd_Jog2, Cmd_Jog3 As UShort

    Friend Act_M_Robot, Cmd_M_Robot, All_Robot, ParMiss, Override As Integer
    Friend Soglia_Vuoto As Single
    'Friend Punti(303), Viti(20), 
    'Friend GenData(101), 
    Friend _Pressa(99), MatrixOled(39), Date_Oled(5) As Byte
#End Region

    Public Function DecodificaMissioneRobot() As MissioneRobot
        If StatiMacchina.MissioneRobotInCorso = 1 Then
            Return MissioneRobot.PresaMagazzinoA
        ElseIf StatiMacchina.MissioneRobotInCorso = 2 Then
            Return MissioneRobot.PresaMagazzinoB
        Else
            Return MissioneRobot.Sconosciuta
        End If
    End Function

    Friend Enum MissioneRobot
        Sconosciuta = 0
        PresaMagazzinoA = 1
        PresaMagazzinoB = 2

    End Enum

    <STAThread()> Public Sub Main(ByVal args() As String)
        If Not TestSingleInstance() Then
            Exit Sub
        End If

        Application.EnableVisualStyles()
        ' Application.SetCompatibleTextRenderingDefault(True)
        First_Time = True

        ExcClass.Trace_FileName = "D:\AL\Trace_all.txt"
        ExcClass.Eable_FileTrace = True

        _thrSQL = New Thread(AddressOf ThreadSQLTest)
        _thrSQL.Start()

_aa:    Threading.Thread.Sleep(200)
        '  If First_Time Then GoTo _aa
        Dim _SplF = New F_Splash
        Application.Run(_SplF)
        _SplF.Dispose()
        '_SplF = Nothing
        '  StartBootloader("a")

        If Not SQLStarted Then
            Exit Sub
        End If

        StartBootloader("a")

        _mainForm = New F_main
        Application.Run(_mainForm)
        _mainForm.Dispose()
        _mainForm = Nothing
        Dim pp As Process = Process.GetCurrentProcess
        pp.Kill()
    End Sub

    Private Sub ThreadSQLTest()
        Try
            'verifica servizio SQL           
            Dim tempCounter = 0
            While (Not SQLStarted And tempCounter < 1000)
                Dim svcStatus As String = TestSQLService()
                Thread.Sleep(100)
                tempCounter += 1
                SQLRunningTimeoutSecondsCounter = CInt(tempCounter / 10)
                SQLStatusText = svcStatus
            End While

            If Not SQLStarted Then
                show_eccezione("SQL SERVICE NOT STARTED")
            End If

            SQLRunningTimeoutSecondsCounter = -1
        Catch ex As Exception

        End Try
    End Sub

    Private Function TestSingleInstance() As Boolean
        Try
            Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("ST_OLED_BENDABLE")
            If pProcess.Count > 1 Then
                MessageBox.Show("APPLICATION ALREADY RUNNING!!!", "ERROR", MessageBoxButtons.OK)
                Return False
            End If
            Return True
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
    End Function

    Private Function TestSQLService() As String
        Try
            Dim sc As ServiceController = New ServiceController("MSSQLSERVER")

            If (sc.Status = ServiceControllerStatus.Running) Then
                SQLStarted = True
            Else
                SQLStarted = False
            End If

            Return (sc.Status.ToString())
        Catch ex As Exception
            SQLStarted = False
            Return "ND"
        End Try
    End Function

    Friend Function open_file(ByVal ms As Boolean, ByVal titolo As String, ByVal init_dir As String) As String()
        Dim OPFIL As New OpenFileDialog()
        Try
            OPFIL.Filter = "Tutti (*.*)|*.*"
            OPFIL.FilterIndex = 1
            OPFIL.Multiselect = ms
            OPFIL.Title = titolo
            OPFIL.InitialDirectory = init_dir
            OPFIL.RestoreDirectory = True
            OPFIL.ShowDialog()
            If OPFIL.FileName() = "" Then
                OPFIL.Dispose()
                Return Nothing 'lista vuota
            Else
                OPFIL.Dispose()
                Return OPFIL.FileNames
            End If
        Catch myException As Exception
            show_eccezione(myException)
            OPFIL.Dispose()
            Return Nothing   'lista vuota
        End Try
    End Function
    Friend Function save_file(ByVal titolo As String) As String
        Dim OPFIL As New SaveFileDialog()
        Dim _tmp As String
        Try
            OPFIL.Filter = "Tutti (*.*)|*.*"
            OPFIL.FilterIndex = 1
            OPFIL.Title = titolo
            'OPFIL.InitialDirectory = "c:\tmp\"
            OPFIL.RestoreDirectory = True
            OPFIL.ShowDialog()
            If OPFIL.FileName() = "" Then
                OPFIL.Dispose()
                Return Nothing
            Else
                _tmp = OPFIL.FileName
                OPFIL.Dispose()
                Return _tmp
            End If
        Catch myException As Exception
            show_eccezione(myException)
            OPFIL.Dispose()
            Return Nothing
        End Try
    End Function
    Friend Function salva_DS_xml(ByVal _file As String, _ds As DataSet) As Boolean
        Dim retval As MsgBoxResult
        Try
            If File.Exists(_file) Then
                'retval = MsgBox("Vuoi sovrascriverlo ? ", MsgBoxStyle.YesNo, "FILE ESISTENTE")
                retval = MsgBox(testi(389), MsgBoxStyle.YesNo, testi(390))
                If retval = MsgBoxResult.No Then Return False
            End If
            _ds.AcceptChanges()
            _ds.WriteXml(_file, XmlWriteMode.WriteSchema)
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Friend Function carica_dataset_xml(ByVal _file As String) As Boolean
        Try


        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function


#Region "Tastiera su schermo"
    Friend Function tasti_on() As Boolean
        Dim _file As String = "c:\windows\system32\osk.exe"
        Try
            If _edit = True Then
                tasti_off()
            Else
                Try
                    _edit = True
                    Dim TTouch As Process = Process.Start(_file)
                Catch ex As Exception
                    show_eccezione(ex)
                    _edit = False
                End Try
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Friend Function tasti_off() As Boolean
        Dim processi() As Process   'collection processi
        Dim _Name As String = ""
        Try
            _edit = False
            _Name = "osk"
            processi = Process.GetProcessesByName(_Name)
            For i As Integer = 0 To processi.Length - 1
                If processi(i).ProcessName = _Name Then
                    processi(i).Kill()
                    Exit For
                End If
            Next i
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
#End Region
#Region "IBH"
    Friend Connesso1 As Boolean = False
    Friend Connesso2 As Boolean = False
#End Region

    Friend Function write_timer(ByVal valore As Single, ByRef _tmp As Short) As Boolean
        Dim buff, i, tempo As Short
        Dim tem(3) As Short
        If valore > 9990.0 Then
            'MsgBox("valore massimo > 9990 superato", MsgBoxStyle.OkOnly, "ERRORE IMPOSTAZIONE TEMPI")
            MsgBox(testi(399), MsgBoxStyle.OkOnly, testi(398))
            Return False
        End If
        If valore < 0.0 Then
            'MsgBox("valore minimo < 0.0 superato", MsgBoxStyle.OkOnly, "ERRORE IMPOSTAZIONE TEMPI")
            MsgBox(testi(400), MsgBoxStyle.OkOnly, testi(398))
            Return False
        End If
        Try
            If valore > 9990.0 Then GoTo _9999
            If valore > 999.0 Then GoTo _999
            If valore > 99.9 Then GoTo _99
            If valore > 9.99 Then GoTo _9
            If valore >= 0.0 Then GoTo _0
            Return False
_9999:      buff = CShort(999)
            i = &H3000
            GoTo _ok
_999:       buff = CShort(Fix(valore / 10))
            i = &H3000
            GoTo _ok
_99:        buff = CShort(Fix(valore))
            i = &H2000
            GoTo _ok
_9:         buff = CShort(Fix(valore * 10))
            i = &H1000
            GoTo _ok
_0:         buff = CShort(Fix(valore * 100))
            i = &H0
            GoTo _ok
_ok:        tem(0) = CShort((buff \ 10)) : tempo = CShort(buff Mod 10)
            tem(1) = CShort(tem(0) \ 10) : tempo = CShort(tempo + (tem(0) Mod 10) * 16)
            tem(2) = CShort(tem(1) \ 10) : tempo = CShort(tempo + (tem(1) Mod 10) * 256)
            tempo = tempo Or i
            _tmp = tempo
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function

    Friend Sub LeggeFileLingue()   ''''''''''''''''''''''''DAVID
        Try
            Dim File_lig As String = Main_dir & "Testi\testi.txt"
            If File.Exists(File_lig) Then
                testi = File.ReadAllLines(File_lig, System.Text.Encoding.GetEncoding(Sett.Code_page))
            Else
                show_eccezione("!!ERROR!!" & vbCrLf & "Language file does not exist!" & File_lig)
                'MessageBox.Show("Language file does not exist!" & File_lig, "!!ERROR!!", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
    Friend Function Carica_Allarmi(ByVal filename As String) As String()
        Try
            If File.Exists(filename) Then
                Return System.IO.File.ReadAllLines(filename, System.Text.Encoding.GetEncoding(Sett.Code_page))
            Else
                show_eccezione("File allarmi non trovato > " & filename & vbCrLf)
                Return Nothing
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return Nothing
        End Try
    End Function
    Friend Sub AggiornaMagazzinoAPresenzaPezzi(idPresenza As Integer)
        Dim pos As MagazzinoPresenzaPezzi = CType(idPresenza, MagazzinoPresenzaPezzi)

        If MagazzinoAPresenzaPezziMap Is Nothing Then
            InitMagazzinoAPresenzaPezziMap()
        End If

        Dim setter As Action = Nothing
        If MagazzinoAPresenzaPezziMap.TryGetValue(pos, setter) Then
            setter()
        End If
    End Sub
    Private Sub InitMagazzinoAPresenzaPezziMap()
        MagazzinoAPresenzaPezziMap = New Dictionary(Of MagazzinoPresenzaPezzi, Action)()

        MagazzinoAPresenzaPezziMap.Add(MagazzinoPresenzaPezzi.MAGAZZINO_PRESENZA_PEZZI_NONE,
        Sub()
            StatiMacchina.MagazzinoAPresenzaPezziDescrizione = "SCONOSCIUTA"
        End Sub)

        MagazzinoAPresenzaPezziMap.Add(MagazzinoPresenzaPezzi.MAGAZZINO_PRESENZA_PEZZI_OLED_SX_OLED_DX,
        Sub()
            StatiMacchina.MagazzinoAPresenzaPezziDescrizione = "OLED SX E DX"
        End Sub)

        MagazzinoAPresenzaPezziMap.Add(MagazzinoPresenzaPezzi.MAGAZZINO_PRESENZA_PEZZI_SOLO_OLED_DX,
        Sub()
            StatiMacchina.MagazzinoAPresenzaPezziDescrizione = "OLED DX"
        End Sub)

        MagazzinoAPresenzaPezziMap.Add(MagazzinoPresenzaPezzi.MAGAZZINO_PRESENZA_PEZZI_SOLO_VASSOIO,
        Sub()
            StatiMacchina.MagazzinoAPresenzaPezziDescrizione = "SOLO VASSOIO"
        End Sub)
    End Sub
    Friend Sub AggiornaRobotPresenzaPezzi(idPresenza As Integer)
        Dim pos As CodicePresenzaPezziRobot = CType(idPresenza, CodicePresenzaPezziRobot)

        If CodiceRobotPresenzaPezziMap Is Nothing Then
            InitCodiceRobotPresenzaPezziMap()
        End If

        Dim setter As Action = Nothing
        If CodiceRobotPresenzaPezziMap.TryGetValue(pos, setter) Then
            setter()
        End If
    End Sub
    Private Sub InitCodiceRobotPresenzaPezziMap()
        CodiceRobotPresenzaPezziMap = New Dictionary(Of CodicePresenzaPezziRobot, Action)()

        CodiceRobotPresenzaPezziMap.Add(CodicePresenzaPezziRobot.ROBOT_PRESENZA_PEZZI_NONE,
        Sub()
            StatiMacchina.RobotDescrizionePresenzaPezzi = "NESSUN PEZZO"
        End Sub)

        CodiceRobotPresenzaPezziMap.Add(CodicePresenzaPezziRobot.ROBOT_PRESENZA_PEZZI_OLED,
        Sub()
            StatiMacchina.RobotDescrizionePresenzaPezzi = "OLED NON TESTATO"
        End Sub)

        CodiceRobotPresenzaPezziMap.Add(CodicePresenzaPezziRobot.ROBOT_PRESENZA_PEZZI_OLED_NOK,
        Sub()
            StatiMacchina.RobotDescrizionePresenzaPezzi = "OLED NON OK"
        End Sub)

        CodiceRobotPresenzaPezziMap.Add(CodicePresenzaPezziRobot.ROBOT_PRESENZA_PEZZI_OLED_OK,
        Sub()
            StatiMacchina.RobotDescrizionePresenzaPezzi = "OLED OK"
        End Sub)

        CodiceRobotPresenzaPezziMap.Add(CodicePresenzaPezziRobot.ROBOT_PRESENZA_PEZZI_SUPPORTO,
            Sub()
                StatiMacchina.RobotDescrizionePresenzaPezzi = "SUPPORTO NON PLASMATO"
            End Sub)

        CodiceRobotPresenzaPezziMap.Add(CodicePresenzaPezziRobot.ROBOT_PRESENZA_PEZZI_SUPPORTO_PLASMATO,
        Sub()
            StatiMacchina.RobotDescrizionePresenzaPezzi = "SUPPORTO PLASMATO"
        End Sub)

        CodiceRobotPresenzaPezziMap.Add(CodicePresenzaPezziRobot.ROBOT_PRESENZA_PEZZI_SUPPORTO_PLASMATO_CON_BIADESIVO,
        Sub()
            StatiMacchina.RobotDescrizionePresenzaPezzi = "SUPPORTO PLASMATO CON BIADESIVO"
        End Sub)

        CodiceRobotPresenzaPezziMap.Add(CodicePresenzaPezziRobot.ROBOT_PRESENZA_PEZZI_SUPPORTO_PLASMATO_CON_BIADESIVO_IONIZZATO,
        Sub()
            StatiMacchina.RobotDescrizionePresenzaPezzi = "SUPPORTO PLASMATO CON BIADESIVO IONIZZATO"
        End Sub)

        CodiceRobotPresenzaPezziMap.Add(CodicePresenzaPezziRobot.ROBOT_PRESENZA_PEZZI_SUPPORTO_PLASMATO_CON_BIADESIVO_IONIZZATO_CON_OLED,
        Sub()
            StatiMacchina.RobotDescrizionePresenzaPezzi = "SUPPORTO PLASMATO CON BIADESIVO IONIZZATO CON OLED"
        End Sub)

    End Sub
    Friend Sub AggiornaMagazzinoBPresenzaPezzi(idPresenza As Integer)
        Dim pos As MagazzinoPresenzaPezzi = CType(idPresenza, MagazzinoPresenzaPezzi)

        If MagazzinoBPresenzaPezziMap Is Nothing Then
            InitMagazzinoBPresenzaPezziMap()
        End If

        Dim setter As Action = Nothing
        If MagazzinoBPresenzaPezziMap.TryGetValue(pos, setter) Then
            setter()
        End If
    End Sub
    Private Sub InitMagazzinoBPresenzaPezziMap()
        MagazzinoBPresenzaPezziMap = New Dictionary(Of MagazzinoPresenzaPezzi, Action)()

        MagazzinoBPresenzaPezziMap.Add(MagazzinoPresenzaPezzi.MAGAZZINO_PRESENZA_PEZZI_NONE,
        Sub()
            StatiMacchina.MagazzinoBPresenzaPezziDescrizione = "SCONOSCIUTA"
        End Sub)

        MagazzinoBPresenzaPezziMap.Add(MagazzinoPresenzaPezzi.MAGAZZINO_PRESENZA_PEZZI_OLED_SX_OLED_DX,
        Sub()
            StatiMacchina.MagazzinoBPresenzaPezziDescrizione = "OLED SX E DX"
        End Sub)

        MagazzinoBPresenzaPezziMap.Add(MagazzinoPresenzaPezzi.MAGAZZINO_PRESENZA_PEZZI_SOLO_OLED_DX,
        Sub()
            StatiMacchina.MagazzinoBPresenzaPezziDescrizione = "OLED DX"
        End Sub)

        MagazzinoBPresenzaPezziMap.Add(MagazzinoPresenzaPezzi.MAGAZZINO_PRESENZA_PEZZI_SOLO_VASSOIO,
        Sub()
            StatiMacchina.MagazzinoBPresenzaPezziDescrizione = "SOLO VASSOIO"
        End Sub)
    End Sub
    Friend Sub AggiornaManoDiPresa(idMano As Integer)

        Dim pos As ManoDiPresa = CType(idMano, ManoDiPresa)

        If ManoDiPresaMap Is Nothing Then
            InitManoDiPresaMap()
        End If

        Dim setter As Action = Nothing
        If ManoDiPresaMap.TryGetValue(pos, setter) Then
            setter()
        End If

    End Sub
    Private Sub InitManoDiPresaMap()
        ManoDiPresaMap = New Dictionary(Of ManoDiPresa, Action)()

        ManoDiPresaMap.Add(ManoDiPresa.ROBOT_MANO_DI_PRESA_UNKNOWN,
        Sub()
            StatiMacchina.ManoDiPresaAttuale = "SCONOSCIUTA"
        End Sub)

        ManoDiPresaMap.Add(ManoDiPresa.ROBOT_MANO_DI_PRESA_SX_POSTO_1,
        Sub()
            StatiMacchina.ManoDiPresaAttuale = "SINISTRA POSTO 1"
        End Sub)

        ManoDiPresaMap.Add(ManoDiPresa.ROBOT_MANO_DI_PRESA_DX_POSTO_2,
        Sub()
            StatiMacchina.ManoDiPresaAttuale = "DESTRA POSTO 2"
        End Sub)

        ManoDiPresaMap.Add(ManoDiPresa.ROBOT_MANO_DI_PRESA_SX_POSTO_3,
        Sub()
            StatiMacchina.ManoDiPresaAttuale = "SINISTRA POSTO 3"
        End Sub)

        ManoDiPresaMap.Add(ManoDiPresa.ROBOT_MANO_DI_PRESA_DX_POSTO_4,
        Sub()
            StatiMacchina.ManoDiPresaAttuale = "DESTRA POSTO 4"
        End Sub)

        ManoDiPresaMap.Add(ManoDiPresa.ROBOT_MANO_DI_PRESA_SX_POSTO_5,
        Sub()
            StatiMacchina.ManoDiPresaAttuale = "SINISTRA POSTO 5"
        End Sub)

        ManoDiPresaMap.Add(ManoDiPresa.ROBOT_MANO_DI_PRESA_DX_POSTO_6,
        Sub()
            StatiMacchina.ManoDiPresaAttuale = "DESTRA POSTO 6"
        End Sub)

        ManoDiPresaMap.Add(ManoDiPresa.ROBOT_MANO_DI_PRESA_ASSENTE,
        Sub()
            StatiMacchina.ManoDiPresaAttuale = "MANO ASSENTE"
        End Sub)
    End Sub

    Friend Sub AggiornaCodicePosizioneRobot(idPosizione As Integer)

        Dim pos As PosizioneRobot = CType(idPosizione, PosizioneRobot)

        If RobotPosizioneMap Is Nothing Then
            InitRobotPosizioniMap()
        End If

        Dim setter As Action = Nothing
        If RobotPosizioneMap.TryGetValue(pos, setter) Then
            setter()
        End If

    End Sub

    Private Sub InitRobotPosizioniMap()
        RobotPosizioneMap = New Dictionary(Of PosizioneRobot, Action)()
        StatiMacchina.RobotDescrizioneMissioneInCorso = ""

        ' SCONOSCIUTO
        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_UNKNOWN,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "NA"
        End Sub)

        ' HOME
        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_HOME,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "IN HOME"
        End Sub)

        ' CAMERA
        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_CAMERA,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "IN POSIZIONE CAMERA"
        End Sub)

        '============================
        '    NASTRO SX
        '============================
        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_IN_NASTRO_SX_SUPPORTO,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "SUPPORTO NASTRO SX"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_IN_NASTRO_SX_BIADESIVO,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "BIADESIVO NASTRO SX"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_IN_NASTRO_SX_OLED_SUPPORTO,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "OLED SUPPORTO NASTRO SX"
        End Sub)

        '============================
        '    NASTRO DX
        '============================
        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_IN_NASTRO_DX_SUPPORTO,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "SUPPORTO NASTRO DX"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_IN_NASTRO_DX_BIADESIVO,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "BIADESIVO NASTRO DX"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_IN_NASTRO_DX_OLED_SUPPORTO,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "OLED SUPPORTO NASTRO DX"
        End Sub)

        '============================
        '    MAGAZZINO SX
        '============================
        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_MAGAZZINO_SX_OLED_SX,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "MAGAZZINO B OLED SX"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_MAGAZZINO_SX_OLED_DX,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "MAGAZZINO B OLED DX"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_MAGAZZINO_SX_VASSOIO,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "MAGAZZINO B VASSOIO"
        End Sub)

        '============================
        '    MAGAZZINO DX
        '============================
        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_MAGAZZINO_DX_OLED_SX,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "MAGAZZINO A OLED SX"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_MAGAZZINO_DX_OLED_DX,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "MAGAZZINO A OLED DX"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_MAGAZZINO_DX_VASSOIO,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "MAGAZZINO A VASSOIO"
        End Sub)

        '============================
        '    IONIZZATORE
        '============================
        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_IONIZZATURA,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. IONIZZATURA"
        End Sub)

        '============================
        '    SCARTO OLED
        '============================
        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_OLED_SCARTO_1,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. OLED SCARTO 1"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_OLED_SCARTO_2,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. OLED SCARTO 2"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_OLED_SCARTO_3,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. OLED SCARTO 3"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_OLED_SCARTO_4,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. OLED SCARTO 4"
        End Sub)

        '============================
        '    INCOLLAGGIO
        '============================
        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_INCOLLAGGIO_DEPOSITO_SX,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "INCOLLAGGIO DEP. SX"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_INCOLLAGGIO_DEPOSITO_DX,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "INCOLLAGGIO DEP DX"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_INCOLLAGGIO_INCOLLA_SX,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "INCOLLAGGIO INCOLLA SX"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_INCOLLAGGIO_INCOLLA_DX,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "INCOLLAGGIO INCOLLA DX"
        End Sub)

        '============================
        '    PLASMA
        '============================
        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_PLASMA_SX,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. PLASMA SX"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_PLASMA_DX,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. PLASMA DX"
        End Sub)

        '============================
        '    STRAPPO LINER
        '============================
        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_STRAPPO_LINER_SX,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. STRAPPO LINER SX"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_STRAPPO_LINER_DX,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. STRAPPO LINER DX"
        End Sub)

        '============================
        '    RACCOLTA SCARTO INCOLLAGGIO
        '============================
        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_INCOLLAGGIO_RACCOLTA_SCARTO_SX,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "INCOL. RACCOLTA SCARTO SX"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_INCOLLAGGIO_RACCOLTA_SCARTO_DX,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "INCOL. RACCOLTA SCARTO DX"
        End Sub)

        '============================
        '    I DIMENTICATI DA DIO
        '============================
        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_VASSOI_VUOTI,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. VASSOI VUOTI"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_DEPOSITO_MANO_DI_PRESA_SX_POSTO_1,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. DEPOSITO MANO SX POSTO 1"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_ACQUISIZIONE_MANO_DI_PRESA_SX_POSTO_1,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. ACQUISIZIONE MANO SX POSTO 1"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_DEPOSITO_MANO_DI_PRESA_DX_POSTO_2,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. DEPOSITO MANO SX POSTO 2"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_ACQUISIZIONE_MANO_DI_PRESA_DX_POSTO_2,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. ACQUISIZIONE MANO SX POSTO 2"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_DEPOSITO_MANO_DI_PRESA_SX_POSTO_3,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. DEPOSITO MANO SX POSTO 3"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_ACQUISIZIONE_MANO_DI_PRESA_SX_POSTO_3,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. ACQUISIZIONE MANO SX POSTO 3"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_DEPOSITO_MANO_DI_PRESA_DX_POSTO_4,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. DEPOSITO MANO DX POSTO 4"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_ACQUISIZIONE_MANO_DI_PRESA_DX_POSTO_4,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. ACQUISIZIONE MANO DX POSTO 4"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_DEPOSITO_MANO_DI_PRESA_SX_POSTO_5,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. DEPOSITO MANO DX POSTO 5"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_ACQUISIZIONE_MANO_DI_PRESA_SX_POSTO_5,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. ACQUISIZIONE MANO DX POSTO 5"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_DEPOSITO_MANO_DI_PRESA_DX_POSTO_6,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. DEPOSITO MANO DX POSTO 6"
        End Sub)

        RobotPosizioneMap.Add(PosizioneRobot.ROBOT_POSIZIONE_ACQUISIZIONE_MANO_DI_PRESA_DX_POSTO_6,
        Sub()
            StatiMacchina.RobotDescrizionePosizioneAttuale = "POS. ACQUISIZIONE MANO DX POSTO 6"
        End Sub)
    End Sub
    Friend Sub AggiornaMissioneRobot(movimento As Integer)

        ResetRobotMissions()

        If movimento = 0 Then
            ' ROBOT_POSIZIONE_UNKNOWN
            Exit Sub
        End If

        Dim pos As PosizioneRobot = CType(movimento, PosizioneRobot)

        If RobotMissionMap Is Nothing Then
            InitRobotMissionMap()
        End If

        Dim setter As Action = Nothing
        If RobotMissionMap.TryGetValue(pos, setter) Then
            setter()
        End If

    End Sub

    Private Sub InitRobotMissionMap()
        RobotMissionMap = New Dictionary(Of PosizioneRobot, Action)()
        StatiMacchina.RobotDescrizioneMissioneInCorso = ""

        ' HOME
        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_HOME,
        Sub()
            StatiMacchina.RobotMissioneHomeInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "VERSO HOME"
        End Sub)

        ' CAMERA
        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_CAMERA,
        Sub()
            StatiMacchina.RobotMissionVaiZonaCameraInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "VERSO POSIZIONE CAMERA"
        End Sub)

        '============================
        '    NASTRO SX
        '============================
        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_IN_NASTRO_SX_SUPPORTO,
        Sub()
            StatiMacchina.RobotMissionePrelevaSupportoNastroSxInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "SUPPORTO NASTRO SX"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_IN_NASTRO_SX_BIADESIVO,
        Sub()
            StatiMacchina.RobotMissioneIncollaBiadesivoSuSupportoNastroSxInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "BIADESIVO NASTRO SX"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_IN_NASTRO_SX_OLED_SUPPORTO,
        Sub()
            StatiMacchina.RobotMissioneDepositaPezzoFinitoSuNastroSxInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "OLED SUPPORTO NASTRO SX"
        End Sub)

        '============================
        '    NASTRO DX
        '============================
        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_IN_NASTRO_DX_SUPPORTO,
        Sub()
            StatiMacchina.RobotMissionePrelevaSupportoNastroDxInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "SUPPORTO NASTRO DX"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_IN_NASTRO_DX_BIADESIVO,
        Sub()
            StatiMacchina.RobotMissioneIncollaBiadesivoSuSupportoNastroDxInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "BIADESIVO NASTRO DX"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_IN_NASTRO_DX_OLED_SUPPORTO,
        Sub()
            StatiMacchina.RobotMissioneDepositaPezzoFinitoSuNastroDxInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "OLED SUPPORTO NASTRO DX"
        End Sub)

        '============================
        '    MAGAZZINO SX
        '============================
        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_MAGAZZINO_SX_OLED_SX,
        Sub()
            StatiMacchina.RobotMissionePrelevaOledSxMagazzinoSxInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "MAGAZZINO B OLED SX"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_MAGAZZINO_SX_OLED_DX,
        Sub()
            StatiMacchina.RobotMissionePrelevaOledDxMagazzinoSxInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "MAGAZZINO B OLED DX"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_MAGAZZINO_SX_VASSOIO,
        Sub()
            StatiMacchina.RobotMissionePrelevaVassoioMagazzinoSxInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "MAGAZZINO B VASSOIO"
        End Sub)

        '============================
        '    MAGAZZINO DX
        '============================
        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_MAGAZZINO_DX_OLED_SX,
        Sub()
            StatiMacchina.RobotMissionePrelevaOledSxMagazzinoDxInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "MAGAZZINO A OLED SX"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_MAGAZZINO_DX_OLED_DX,
        Sub()
            StatiMacchina.RobotMissionePrelevaOledDxMagazzinoDxInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "MAGAZZINO A OLED DX"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_MAGAZZINO_DX_VASSOIO,
        Sub()
            StatiMacchina.RobotMissionePrelevaVassoioMagazzinoDxInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "MAGAZZINO A VASSOIO"
        End Sub)

        '============================
        '    IONIZZATORE
        '============================
        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_IONIZZATURA,
        Sub()
            StatiMacchina.RobotMissioneIonizzatoreInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "POS. IONIZZATURA"
        End Sub)

        '============================
        '    SCARTO OLED
        '============================
        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_OLED_SCARTO_1,
        Sub()
            StatiMacchina.RobotMissioneDepositaOledScartoPosizione1InCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "POS. OLED SCARTO 1"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_OLED_SCARTO_2,
        Sub()
            StatiMacchina.RobotMissioneDepositaOledScartoPosizione2InCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "POS. OLED SCARTO 2"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_OLED_SCARTO_3,
        Sub()
            StatiMacchina.RobotMissioneDepositaOledScartoPosizione3InCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "POS. OLED SCARTO 3"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_OLED_SCARTO_4,
        Sub()
            StatiMacchina.RobotMissioneDepositaOledScartoPosizione4InCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "POS. OLED SCARTO 4"
        End Sub)

        '============================
        '    INCOLLAGGIO
        '============================
        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_INCOLLAGGIO_DEPOSITO_SX,
        Sub()
            StatiMacchina.RobotMissioneDepositaOledInIncollaggioInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "INCOLLAGGIO DEP. SX"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_INCOLLAGGIO_DEPOSITO_DX,
        Sub()
            StatiMacchina.RobotMissioneDepositaOledInIncollaggioInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "INCOLLAGGIO DEP DX"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_INCOLLAGGIO_INCOLLA_SX,
        Sub()
            StatiMacchina.RobotMissioneIncollaSupportoConOledInIncollaggioInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "INCOLLAGGIO INCOLLA SX"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_INCOLLAGGIO_INCOLLA_DX,
        Sub()
            StatiMacchina.RobotMissioneIncollaSupportoConOledInIncollaggioInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "INCOLLAGGIO INCOLLA DX"
        End Sub)

        '============================
        '    PLASMA
        '============================
        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_PLASMA_SX,
        Sub()
            StatiMacchina.RobotMissioneFaiCicloPlasmaturaInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "POS. PLASMA SX"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_PLASMA_DX,
        Sub()
            StatiMacchina.RobotMissioneFaiCicloPlasmaturaInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "POS. PLASMA DX"
        End Sub)

        '============================
        '    STRAPPO LINER
        '============================
        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_STRAPPO_LINER_SX,
        Sub()
            StatiMacchina.RobotMissioneStrappaLinerInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "POS. STRAPPO LINER SX"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_STRAPPO_LINER_DX,
        Sub()
            StatiMacchina.RobotMissioneStrappaLinerInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "POS. STRAPPO LINER DX"
        End Sub)

        '============================
        '    RACCOLTA SCARTO INCOLLAGGIO
        '============================
        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_INCOLLAGGIO_RACCOLTA_SCARTO_SX,
        Sub()
            StatiMacchina.RobotMissioneRaccogliOledScartoDaIncollaggioInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "INCOL. RACCOLTA SCARTO SX"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_INCOLLAGGIO_RACCOLTA_SCARTO_DX,
        Sub()
            StatiMacchina.RobotMissioneRaccogliOledScartoDaIncollaggioInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "INCOL. RACCOLTA SCARTO DX"
        End Sub)


        '============================
        '    I DIMENTICATI DA DIO
        '============================
        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_VASSOI_VUOTI,
        Sub()
            StatiMacchina.RobotMissioneVassoiVuotiInCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "VERSO POS. VASSOI VUOTI"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_DEPOSITO_MANO_DI_PRESA_SX_POSTO_1,
        Sub()
            StatiMacchina.RobotMissioneDepositaManoSxPos_1InCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "VERSO POS. DEPOSITO MANO SX POSTO 1"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_ACQUISIZIONE_MANO_DI_PRESA_SX_POSTO_1,
        Sub()
            StatiMacchina.RobotMissioneAcquisizioneManoSxPos_1InCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "VERSO POS. ACQUISIZIONE MANO SX POSTO 1"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_DEPOSITO_MANO_DI_PRESA_DX_POSTO_2,
        Sub()
            StatiMacchina.RobotMissioneDepositaManoSxPos_2InCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "VERSO POS. DEPOSITO MANO SX POSTO 2"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_ACQUISIZIONE_MANO_DI_PRESA_DX_POSTO_2,
        Sub()
            StatiMacchina.RobotMissioneAcquisizioneManoSxPos_2InCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "VERSO POS. ACQUISIZIONE MANO SX POSTO 2"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_DEPOSITO_MANO_DI_PRESA_SX_POSTO_3,
        Sub()
            StatiMacchina.RobotMissioneDepositaManoSxPos_3InCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "VERSO POS. DEPOSITO MANO SX POSTO 3"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_ACQUISIZIONE_MANO_DI_PRESA_SX_POSTO_3,
        Sub()
            StatiMacchina.RobotMissioneAcquisizioneManoSxPos_3InCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "VERSO POS. ACQUISIZIONE MANO SX POSTO 3"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_DEPOSITO_MANO_DI_PRESA_DX_POSTO_4,
        Sub()
            StatiMacchina.RobotMissioneDepositaManoDxPos_4InCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "VERSO POS. DEPOSITO MANO DX POSTO 4"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_ACQUISIZIONE_MANO_DI_PRESA_DX_POSTO_4,
        Sub()
            StatiMacchina.RobotMissioneAcquisizioneManoDxPos_4InCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "VERSO POS. ACQUISIZIONE MANO DX POSTO 4"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_DEPOSITO_MANO_DI_PRESA_SX_POSTO_5,
        Sub()
            StatiMacchina.RobotMissioneDepositaManoDxPos_5InCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "VERSO POS. DEPOSITO MANO DX POSTO 5"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_ACQUISIZIONE_MANO_DI_PRESA_SX_POSTO_5,
        Sub()
            StatiMacchina.RobotMissioneAcquisizioneManoDxPos_5InCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "VERSO POS. ACQUISIZIONE MANO DX POSTO 5"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_DEPOSITO_MANO_DI_PRESA_DX_POSTO_6,
        Sub()
            StatiMacchina.RobotMissioneDepositaManoDxPos_6InCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "VERSO POS. DEPOSITO MANO DX POSTO 6"
        End Sub)

        RobotMissionMap.Add(PosizioneRobot.ROBOT_POSIZIONE_ACQUISIZIONE_MANO_DI_PRESA_DX_POSTO_6,
        Sub()
            StatiMacchina.RobotMissioneAcquisizioneManoDxPos_6InCorso = True
            StatiMacchina.RobotDescrizioneMissioneInCorso = "VERSO POS. ACQUISIZIONE MANO DX POSTO 6"
        End Sub)


    End Sub


    Private Sub ResetRobotMissions()

        StatiMacchina.RobotMissionVaiZonaCameraInCorso = False
        StatiMacchina.RobotMissioneHomeInCorso = False
        StatiMacchina.RobotMissionePrelevaSupportoNastroSxInCorso = False
        StatiMacchina.RobotMissioneIncollaBiadesivoSuSupportoNastroSxInCorso = False
        StatiMacchina.RobotMissioneDepositaPezzoFinitoSuNastroSxInCorso = False
        StatiMacchina.RobotMissionePrelevaSupportoNastroDxInCorso = False
        StatiMacchina.RobotMissioneIncollaBiadesivoSuSupportoNastroDxInCorso = False
        StatiMacchina.RobotMissioneDepositaPezzoFinitoSuNastroDxInCorso = False
        StatiMacchina.RobotMissioneDepositaOledInIncollaggioInCorso = False
        StatiMacchina.RobotMissioneIncollaSupportoConOledInIncollaggioInCorso = False
        StatiMacchina.RobotMissionePrelevaOledSxMagazzinoSxInCorso = False
        StatiMacchina.RobotMissionePrelevaOledDxMagazzinoSxInCorso = False
        StatiMacchina.RobotMissionePrelevaVassoioMagazzinoSxInCorso = False
        StatiMacchina.RobotMissionePrelevaOledSxMagazzinoDxInCorso = False
        StatiMacchina.RobotMissionePrelevaOledDxMagazzinoDxInCorso = False
        StatiMacchina.RobotMissionePrelevaVassoioMagazzinoDxInCorso = False
        StatiMacchina.RobotMissioneDepositaVassoioVuotoInCorso = False
        StatiMacchina.RobotMissioneDepositaOledScartoPosizione1InCorso = False
        StatiMacchina.RobotMissioneDepositaOledScartoPosizione2InCorso = False
        StatiMacchina.RobotMissioneDepositaOledScartoPosizione3InCorso = False
        StatiMacchina.RobotMissioneDepositaOledScartoPosizione4InCorso = False
        StatiMacchina.RobotMissioneFaiCicloPlasmaturaInCorso = False
        StatiMacchina.RobotMissioneStrappaLinerInCorso = False
        StatiMacchina.RobotMissioneRaccogliOledScartoDaIncollaggioInCorso = False

        StatiMacchina.RobotMissioneVassoiVuotiInCorso = False
        StatiMacchina.RobotMissioneDepositaManoSxPos_1InCorso = False
        StatiMacchina.RobotMissioneAcquisizioneManoSxPos_1InCorso = False
        StatiMacchina.RobotMissioneDepositaManoSxPos_2InCorso = False
        StatiMacchina.RobotMissioneAcquisizioneManoSxPos_2InCorso = False
        StatiMacchina.RobotMissioneDepositaManoSxPos_3InCorso = False
        StatiMacchina.RobotMissioneAcquisizioneManoSxPos_3InCorso = False
        StatiMacchina.RobotMissioneDepositaManoDxPos_4InCorso = False
        StatiMacchina.RobotMissioneAcquisizioneManoDxPos_4InCorso = False
        StatiMacchina.RobotMissioneDepositaManoDxPos_5InCorso = False
        StatiMacchina.RobotMissioneAcquisizioneManoDxPos_5InCorso = False
        StatiMacchina.RobotMissioneDepositaManoDxPos_6InCorso = False
        StatiMacchina.RobotMissioneAcquisizioneManoDxPos_6InCorso = False



    End Sub

    Friend Sub ParseInfoBlock(bytes As Byte(), baseOffset As Integer)
        For i As Integer = 0 To INFO_COUNT - 1
            Dim offset As Integer = baseOffset + (i * 4)
            Infos(i).Tempo = ReadUShortFrom_2Bytes(bytes, offset)
            Infos(i).Valore = ReadUShortFrom_2Bytes(bytes, offset + 2)
        Next
    End Sub

    ' Versione 2 (opzionale): riempie un array passato dal chiamante
    Friend Sub ParseInfoBlock(bytes As Byte(), baseOffset As Integer, ByRef infos() As InfoPlc)
        For i As Integer = 0 To INFO_COUNT - 1
            Dim offset As Integer = baseOffset + (i * 4)
            infos(i).Tempo = ReadUShortFrom_2Bytes(bytes, offset)
            infos(i).Valore = ReadUShortFrom_2Bytes(bytes, offset + 2)
        Next
    End Sub

    Friend Function ReadUShortFrom_2Bytes(bytes As Byte(), offset As Integer) As UShort
        Dim _2bytes As Byte()
        _2bytes = New Byte(1) {0, 0}
        _2bytes(1) = bytes(offset) : _2bytes(0) = bytes(offset + 1)
        Return CUShort(BitConverter.ToInt16(_2bytes, 0))
    End Function


End Module

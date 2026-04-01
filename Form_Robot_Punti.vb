Imports System.IO
Imports System.Linq
Imports System.Runtime.Remoting
Imports System.Threading
Imports Microsoft.Data.SqlClient
Imports Microsoft.Extensions.DependencyInjection
Imports Oled.DataLayer
Imports SkiaSharp
Public Class Form_Robot_Punti
    Private _ok, _ct1 As Boolean
    Private STW As New BitArray(8)
    Private CTW As New BitArray(8)
    Private C_Tim1 As Integer
    Private _presetDictionary As New Dictionary(Of String, Double)

#Region "Form"
    Private Sub Form_allarmi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = Loc_mdi
        N_MDI_from = 51
        req_dati = False : req_dati_ready = False
        req_dati2 = False : req_dati_ready2 = False

        PaginaAperta = "ROBOT PUNTI"
        F_main.Lab_titolo.BackColor = Color.Lime
        SaveOrUpdatePreset()
        Timer1.Enabled = True : _ok = True
        req_dati = True
        ReadCompensazioni()
    End Sub
    Private Sub SaveOrUpdatePreset()
        If _presetDictionary.ContainsKey("xALTA") Then
            _presetDictionary("xALTA") = StatiMacchina.OffsetVisioneCameraAlta.X
        Else
            _presetDictionary.Add("xALTA", StatiMacchina.OffsetVisioneCameraAlta.X)
        End If

        If _presetDictionary.ContainsKey("yALTA") Then
            _presetDictionary("yALTA") = StatiMacchina.OffsetVisioneCameraAlta.Y
        Else
            _presetDictionary.Add("yALTA", StatiMacchina.OffsetVisioneCameraAlta.Y)
        End If

        If _presetDictionary.ContainsKey("aALTA") Then
            _presetDictionary("aALTA") = StatiMacchina.OffsetVisioneCameraAlta.Rotazione
        Else
            _presetDictionary.Add("aALTA", StatiMacchina.OffsetVisioneCameraAlta.Rotazione)
        End If

        If _presetDictionary.ContainsKey("xBASSA") Then
            _presetDictionary("xBASSA") = StatiMacchina.OffsetVisioneCameraBassa.X
        Else
            _presetDictionary.Add("xBASSA", StatiMacchina.OffsetVisioneCameraBassa.X)
        End If

        If _presetDictionary.ContainsKey("yBASSA") Then
            _presetDictionary("yBASSA") = StatiMacchina.OffsetVisioneCameraBassa.Y
        Else
            _presetDictionary.Add("yBASSA", StatiMacchina.OffsetVisioneCameraBassa.Y)
        End If

        If _presetDictionary.ContainsKey("aBASSA") Then
            _presetDictionary("aBASSA") = StatiMacchina.OffsetVisioneCameraBassa.Rotazione
        Else
            _presetDictionary.Add("aBASSA", StatiMacchina.OffsetVisioneCameraBassa.Rotazione)
        End If


        If _presetDictionary.ContainsKey("xUSERALTA") Then
            _presetDictionary("xUSERALTA") = StatiMacchina.OffsetUtenteVisioneCameraAlta.X
        Else
            _presetDictionary.Add("xUSERALTA", StatiMacchina.OffsetUtenteVisioneCameraAlta.X)
        End If

        If _presetDictionary.ContainsKey("yUSERALTA") Then
            _presetDictionary("yUSERALTA") = StatiMacchina.OffsetUtenteVisioneCameraAlta.Y
        Else
            _presetDictionary.Add("yUSERALTA", StatiMacchina.OffsetUtenteVisioneCameraAlta.Y)
        End If

        If _presetDictionary.ContainsKey("aUSERALTA") Then
            _presetDictionary("aUSERALTA") = StatiMacchina.OffsetUtenteVisioneCameraAlta.Rotazione
        Else
            _presetDictionary.Add("aUSERALTA", StatiMacchina.OffsetUtenteVisioneCameraAlta.Rotazione)
        End If

        If _presetDictionary.ContainsKey("xUSERBASSA") Then
            _presetDictionary("xUSERBASSA") = StatiMacchina.OffsetUtenteVisioneCameraBassa.X
        Else
            _presetDictionary.Add("xUSERBASSA", StatiMacchina.OffsetUtenteVisioneCameraBassa.X)
        End If

        If _presetDictionary.ContainsKey("yUSERBASSA") Then
            _presetDictionary("yUSERBASSA") = StatiMacchina.OffsetUtenteVisioneCameraBassa.Y
        Else
            _presetDictionary.Add("yUSERBASSA", StatiMacchina.OffsetUtenteVisioneCameraBassa.Y)
        End If

        If _presetDictionary.ContainsKey("aUSERBASSA") Then
            _presetDictionary("aUSERBASSA") = StatiMacchina.OffsetUtenteVisioneCameraBassa.Rotazione
        Else
            _presetDictionary.Add("aUSERBASSA", StatiMacchina.OffsetUtenteVisioneCameraBassa.Rotazione)
        End If
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

        Gr_Punti.Enabled = Log_1
        GR_PA.Enabled = Log_1 : GR_PB.Enabled = Log_1
        GroupBox4.Enabled = Log_1
        Gr_Punti.Enabled = Log_1
        GroupBox3.Enabled = Log_1


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

        txtCompXALTA.ReadOnly = Not Log_4
        txtCompYALTA.ReadOnly = Not Log_4
        txtCompAngleALTA.ReadOnly = Not Log_4
        txtCompXBASSA.ReadOnly = Not Log_4
        txtCompYBASSA.ReadOnly = Not Log_4
        txtCompAngleBASSA.ReadOnly = Not Log_4

        txtOffsetCameraAltaX.ReadOnly = Not Log_4
        txtOffsetCameraAltaY.ReadOnly = Not Log_4
        txtOffsetCameraAltaA.ReadOnly = Not Log_4

        txtOffsetCameraBassaX.ReadOnly = Not Log_4
        txtOffsetCameraBassaY.ReadOnly = Not Log_4
        txtOffsetCameraBassaA.ReadOnly = Not Log_4


        btnSalvaComp.Visible = SomethingChanged() And Log_1
        btnSalvaComp.BackColor = CType(IIf(_ct1, Color.Yellow, Color.White), Color)
        If (StatiMacchina.PreorientamentoDaFare) Then
            lblBypassPreOrientamento.Text = "PREORIENTAMENTO ABILITATO"
            lblBypassPreOrientamento.BackColor = Color.Lime
        Else
            lblBypassPreOrientamento.Text = "PREORIENTAMENTO DISABILITATO"
            lblBypassPreOrientamento.BackColor = Color.Red
        End If

    End Sub

    Private Function SomethingChanged() As Boolean
        If txtCompXALTA.Ok Then
            If _presetDictionary("xALTA") <> txtCompXALTA.Value Then
                Return True
            End If
        End If
        If txtCompYALTA.Ok Then
            If _presetDictionary("yALTA") <> txtCompYALTA.Value Then
                Return True
            End If
        End If
        If txtCompAngleALTA.Ok Then
            If _presetDictionary("aALTA") <> txtCompAngleALTA.Value Then
                Return True
            End If
        End If

        If txtCompXBASSA.Ok Then
            If _presetDictionary("xBASSA") <> txtCompXBASSA.Value Then
                Return True
            End If
        End If
        If txtCompYBASSA.Ok Then
            If _presetDictionary("yBASSA") <> txtCompYBASSA.Value Then
                Return True
            End If
        End If
        If txtCompAngleBASSA.Ok Then
            If _presetDictionary("aBASSA") <> txtCompAngleBASSA.Value Then
                Return True
            End If
        End If

        If txtOffsetCameraAltaX.Ok Then
            If _presetDictionary("xUSERALTA") <> txtOffsetCameraAltaX.Value Then
                Return True
            End If
        End If
        If txtOffsetCameraAltaY.Ok Then
            If _presetDictionary("yUSERALTA") <> txtOffsetCameraAltaY.Value Then
                Return True
            End If
        End If
        If txtOffsetCameraAltaA.Ok Then
            If _presetDictionary("aUSERALTA") <> txtOffsetCameraAltaA.Value Then
                Return True
            End If
        End If

        If txtOffsetCameraBassaX.Ok Then
            If _presetDictionary("xUSERBASSA") <> txtOffsetCameraBassaX.Value Then
                Return True
            End If
        End If
        If txtOffsetCameraBassaY.Ok Then
            If _presetDictionary("yUSERBASSA") <> txtOffsetCameraBassaY.Value Then
                Return True
            End If
        End If
        If txtOffsetCameraBassaA.Ok Then
            If _presetDictionary("aUSERBASSA") <> txtOffsetCameraBassaA.Value Then
                Return True
            End If
        End If

        Return False
    End Function
    Private Sub ReadCompensazioni()
        txtCompXALTA.Value = StatiMacchina.OffsetVisioneCameraAlta.X
        txtCompYALTA.Value = StatiMacchina.OffsetVisioneCameraAlta.Y
        txtCompAngleALTA.Value = StatiMacchina.OffsetVisioneCameraAlta.Rotazione

        txtCompXBASSA.Value = StatiMacchina.OffsetVisioneCameraBassa.X
        txtCompYBASSA.Value = StatiMacchina.OffsetVisioneCameraBassa.Y
        txtCompAngleBASSA.Value = StatiMacchina.OffsetVisioneCameraBassa.Rotazione

        txtOffsetCameraAltaX.Value = StatiMacchina.OffsetUtenteVisioneCameraAlta.X
        txtOffsetCameraAltaY.Value = StatiMacchina.OffsetUtenteVisioneCameraAlta.Y
        txtOffsetCameraAltaA.Value = StatiMacchina.OffsetUtenteVisioneCameraAlta.Rotazione

        txtOffsetCameraBassaX.Value = StatiMacchina.OffsetUtenteVisioneCameraBassa.X
        txtOffsetCameraBassaY.Value = StatiMacchina.OffsetUtenteVisioneCameraBassa.Y
        txtOffsetCameraBassaA.Value = StatiMacchina.OffsetUtenteVisioneCameraBassa.Rotazione
    End Sub
    Private Function Read_Valori() As Boolean
        Try

            Lt_x.Text = CorrezioneVisioneAlta.X.ToString("0.00")
            Lt_x.BackColor = If(CorrezioneVisioneAlta.X > Visione_x_Limit_Upper, Color.Red, Color.Silver)


            Lt_y.Text = CorrezioneVisioneAlta.Y.ToString("0.00")
            Lt_y.BackColor = If(CorrezioneVisioneAlta.Y > Visione_y_Limit_Upper, Color.Red, Color.Silver)


            Lt_a.Text = CorrezioneVisioneAlta.RotazioneZ.ToString("0.00")
            Lt_a.BackColor = If(CorrezioneVisioneAlta.RotazioneZ > Visione_angle_Limit_Upper, Color.Red, Color.Silver)


            Label54.Text = CorrezioneVisioneBassa.X.ToString("0.00")
            Label54.BackColor = If(CorrezioneVisioneBassa.X < Visione_x_Limit_Lower, Color.Red, Color.Silver)


            Label56.Text = CorrezioneVisioneBassa.Y.ToString("0.00")
            Label56.BackColor = If(CorrezioneVisioneBassa.Y < Visione_y_Limit_Lower, Color.Red, Color.Silver)


            Label58.Text = CorrezioneVisioneBassa.RotazioneZ.ToString("0.00")
            Label58.BackColor = If(CorrezioneVisioneBassa.RotazioneZ < Visione_angle_Limit_Lower, Color.Red, Color.Silver)

            Label100.Text = (CorrezioneVisioneAlta.X + StatiMacchina.OffsetVisioneCameraAlta.X + StatiMacchina.OffsetUtenteVisioneCameraAlta.X).ToString("0.00")
            Label100.BackColor = If(OrientamentoVisioneAltaFuoriLimiti Or Scarto_Visione(4), Color.Red, Color.Silver)


            Label101.Text = (CorrezioneVisioneAlta.Y + StatiMacchina.OffsetVisioneCameraAlta.Y + StatiMacchina.OffsetUtenteVisioneCameraAlta.Y).ToString("0.00")
            Label101.BackColor = If(OrientamentoVisioneAltaFuoriLimiti Or Scarto_Visione(4), Color.Red, Color.Silver)


            Label102.Text = (CorrezioneVisioneAlta.RotazioneZ + StatiMacchina.OffsetVisioneCameraAlta.Rotazione + StatiMacchina.OffsetUtenteVisioneCameraAlta.Rotazione).ToString("0.00")
            Label102.BackColor = If(OrientamentoVisioneAltaFuoriLimiti Or Scarto_Visione(4), Color.Red, Color.Silver)


            Label105.Text = (CorrezioneVisioneBassa.X + StatiMacchina.OffsetVisioneCameraBassa.X).ToString("0.00")
            Label105.BackColor = If(OrientamentoVisioneBassaFuoriLimiti Or Scarto_Visione(2), Color.Red, Color.Silver)


            Label104.Text = (CorrezioneVisioneBassa.Y + StatiMacchina.OffsetVisioneCameraBassa.Y).ToString("0.00")
            Label104.BackColor = If(OrientamentoVisioneBassaFuoriLimiti Or Scarto_Visione(2), Color.Red, Color.Silver)


            Label103.Text = (CorrezioneVisioneBassa.RotazioneZ + StatiMacchina.OffsetVisioneCameraBassa.Rotazione).ToString("0.00")
            Label103.BackColor = If(OrientamentoVisioneBassaFuoriLimiti Or Scarto_Visione(2), Color.Red, Color.Silver)

        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Function Read_Robot() As Boolean
        Dim _byte(0), _2bytes(1) As Byte

        Try


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

            ' PRELIEVO OLED DX MAGAZZINO SX
            PD_bx.Value = CDbl(StatiMacchina.MagazzinoSxOledDx.X) / 1000.0!
            PD_by.Value = CDbl(StatiMacchina.MagazzinoSxOledDx.Y) / 1000.0!
            PD_bz.Value = CDbl(StatiMacchina.MagazzinoSxOledDx.Z) / 1000.0!
            PD_ba.Value = CDbl(StatiMacchina.MagazzinoSxOledDx.RotazioneZ) / 1000.0!

            'MAGAZZINO SX VASSOIO
            T_box4.Value = CDbl(StatiMacchina.MagazzinoSxVassoio.X) / 1000.0!
            T_box3.Value = CDbl(StatiMacchina.MagazzinoSxVassoio.Y) / 1000.0!
            T_box2.Value = CDbl(StatiMacchina.MagazzinoSxVassoio.Z) / 1000.0!
            T_box1.Value = CDbl(StatiMacchina.MagazzinoSxVassoio.RotazioneZ) / 1000.0!

            'MAGAZZINO DX VASSOIO
            T_box8.Value = CDbl(StatiMacchina.MagazzinoDxVassoio.X) / 1000.0!
            T_box7.Value = CDbl(StatiMacchina.MagazzinoDxVassoio.Y) / 1000.0!
            T_box6.Value = CDbl(StatiMacchina.MagazzinoDxVassoio.Z) / 1000.0!
            T_box5.Value = CDbl(StatiMacchina.MagazzinoDxVassoio.RotazioneZ) / 1000.0!

            'INCOLLAGGIO
            T_xo.Value = CDbl(StatiMacchina.Incollaggio.X) / 1000.0!
            T_yo.Value = CDbl(StatiMacchina.Incollaggio.Y) / 1000.0!
            T_zo.Value = CDbl(StatiMacchina.Incollaggio.Z) / 1000.0!
            T_ao.Value = CDbl(StatiMacchina.Incollaggio.RotazioneZ) / 1000.0!

            T_xs.Value = CDbl(StatiMacchina.Plasma.X) / 1000.0!
            T_ys.Value = CDbl(StatiMacchina.Plasma.Y) / 1000.0!
            T_zs.Value = CDbl(StatiMacchina.Plasma.Z) / 1000.0!
            T_as.Value = CDbl(StatiMacchina.Plasma.RotazioneZ) / 1000.0!

            T_xa.Value = CDbl(StatiMacchina.StrappoLiner.X) / 1000.0!
            T_ya.Value = CDbl(StatiMacchina.StrappoLiner.Y) / 1000.0!
            T_za.Value = CDbl(StatiMacchina.StrappoLiner.Z) / 1000.0!
            T_aa.Value = CDbl(StatiMacchina.StrappoLiner.RotazioneZ) / 1000.0!

            T_box12.Value = CDbl(StatiMacchina.VassoiVuoti.X) / 1000.0!
            T_box11.Value = CDbl(StatiMacchina.VassoiVuoti.Y) / 1000.0!
            T_box10.Value = CDbl(StatiMacchina.VassoiVuoti.Z) / 1000.0!
            T_box9.Value = CDbl(StatiMacchina.VassoiVuoti.RotazioneZ) / 1000.0!

            'POSIZIONE SCARTO 1
            T_box24.Value = CDbl(StatiMacchina.PosizioneScarto1.X) / 1000.0!
            T_box23.Value = CDbl(StatiMacchina.PosizioneScarto1.Y) / 1000.0!
            T_box22.Value = CDbl(StatiMacchina.PosizioneScarto1.Z) / 1000.0!
            T_box21.Value = CDbl(StatiMacchina.PosizioneScarto1.RotazioneZ) / 1000.0!

            'POSIZIONE SCARTO 2
            T_box20.Value = CDbl(StatiMacchina.PosizioneScarto2.X) / 1000.0!
            T_box19.Value = CDbl(StatiMacchina.PosizioneScarto2.Y) / 1000.0!
            T_box18.Value = CDbl(StatiMacchina.PosizioneScarto2.Z) / 1000.0!
            T_box17.Value = CDbl(StatiMacchina.PosizioneScarto2.RotazioneZ) / 1000.0!

            'POSIZIONE SCARTO 3
            T_box28.Value = CDbl(StatiMacchina.PosizioneScarto3.X) / 1000.0!
            T_box27.Value = CDbl(StatiMacchina.PosizioneScarto3.Y) / 1000.0!
            T_box26.Value = CDbl(StatiMacchina.PosizioneScarto3.Z) / 1000.0!
            T_box25.Value = CDbl(StatiMacchina.PosizioneScarto3.RotazioneZ) / 1000.0!

            'POSIZIONE SCARTO 4 
            T_box16.Value = CDbl(StatiMacchina.PosizioneScarto4.X) / 1000.0!
            T_box15.Value = CDbl(StatiMacchina.PosizioneScarto4.Y) / 1000.0!
            T_box14.Value = CDbl(StatiMacchina.PosizioneScarto4.Z) / 1000.0!
            T_box13.Value = CDbl(StatiMacchina.PosizioneScarto4.RotazioneZ) / 1000.0!

            'POSIZIONE MANO DI PRESA 1
            T_box40.Value = CDbl(StatiMacchina.ManoDiPresa1.X) / 1000.0!
            T_box39.Value = CDbl(StatiMacchina.ManoDiPresa1.Y) / 1000.0!
            T_box38.Value = CDbl(StatiMacchina.ManoDiPresa1.Z) / 1000.0!
            T_box37.Value = CDbl(StatiMacchina.ManoDiPresa1.RotazioneZ) / 1000.0!

            'POSIZIONE MANO DI PRESA 2
            T_box36.Value = CDbl(StatiMacchina.ManoDiPresa2.X) / 1000.0!
            T_box35.Value = CDbl(StatiMacchina.ManoDiPresa2.Y) / 1000.0!
            T_box34.Value = CDbl(StatiMacchina.ManoDiPresa2.Z) / 1000.0!
            T_box33.Value = CDbl(StatiMacchina.ManoDiPresa2.RotazioneZ) / 1000.0!

            'POSIZIONE CAMERA ALTA
            T_box32.Value = CDbl(StatiMacchina.PosizioneCameraAlta.X) / 1000.0!
            T_box31.Value = CDbl(StatiMacchina.PosizioneCameraAlta.Y) / 1000.0!
            T_box30.Value = CDbl(StatiMacchina.PosizioneCameraAlta.Z) / 1000.0!
            T_box29.Value = CDbl(StatiMacchina.PosizioneCameraAlta.RotazioneZ) / 1000.0!

            'POSIZIONE CAMERA BASSA 1
            T_box44.Value = CDbl(StatiMacchina.PosizioneCameraBassa1.X) / 1000.0!
            T_box43.Value = CDbl(StatiMacchina.PosizioneCameraBassa1.Y) / 1000.0!
            T_box42.Value = CDbl(StatiMacchina.PosizioneCameraBassa1.Z) / 1000.0!
            T_box41.Value = CDbl(StatiMacchina.PosizioneCameraBassa1.RotazioneZ) / 1000.0!

            'POSIZIONE CAEMRA BASSA 2
            T_box72.Value = CDbl(StatiMacchina.PosizioneCameraBassa2.X) / 1000.0!
            T_box71.Value = CDbl(StatiMacchina.PosizioneCameraBassa2.Y) / 1000.0!
            T_box70.Value = CDbl(StatiMacchina.PosizioneCameraBassa2.Z) / 1000.0!
            T_box69.Value = CDbl(StatiMacchina.PosizioneCameraBassa2.RotazioneZ) / 1000.0!

            'NASTRO SX BIADESIVO
            T_box48.Value = CDbl(StatiMacchina.PalletSuNastroSxBiadesivo.X) / 1000.0!
            T_box47.Value = CDbl(StatiMacchina.PalletSuNastroSxBiadesivo.Y) / 1000.0!
            T_box46.Value = CDbl(StatiMacchina.PalletSuNastroSxBiadesivo.Z) / 1000.0!
            T_box45.Value = CDbl(StatiMacchina.PalletSuNastroSxBiadesivo.RotazioneZ) / 1000.0!

            'NASTRO SX SUPPORTO
            T_box52.Value = CDbl(StatiMacchina.PalletSuNastroSxSupporto.X) / 1000.0!
            T_box51.Value = CDbl(StatiMacchina.PalletSuNastroSxSupporto.Y) / 1000.0!
            T_box50.Value = CDbl(StatiMacchina.PalletSuNastroSxSupporto.Z) / 1000.0!
            T_box49.Value = CDbl(StatiMacchina.PalletSuNastroSxSupporto.RotazioneZ) / 1000.0!

            'NASTRO SX OLED
            T_box56.Value = CDbl(StatiMacchina.PalletSuNastroSxPezzoFinito.X) / 1000.0!
            T_box55.Value = CDbl(StatiMacchina.PalletSuNastroSxPezzoFinito.Y) / 1000.0!
            T_box54.Value = CDbl(StatiMacchina.PalletSuNastroSxPezzoFinito.Z) / 1000.0!
            T_box53.Value = CDbl(StatiMacchina.PalletSuNastroSxPezzoFinito.RotazioneZ) / 1000.0!

            'NASTRO DX BIADESIVO
            T_box60.Value = CDbl(StatiMacchina.PalletSuNastroDxBiadesivo.X) / 1000.0!
            T_box59.Value = CDbl(StatiMacchina.PalletSuNastroDxBiadesivo.Y) / 1000.0!
            T_box58.Value = CDbl(StatiMacchina.PalletSuNastroDxBiadesivo.Z) / 1000.0!
            T_box57.Value = CDbl(StatiMacchina.PalletSuNastroDxBiadesivo.RotazioneZ) / 1000.0!

            'NASTRO DX SUPPORTO
            T_box64.Value = CDbl(StatiMacchina.PalletSuNastroDxSupporto.X) / 1000.0!
            T_box63.Value = CDbl(StatiMacchina.PalletSuNastroDxSupporto.Y) / 1000.0!
            T_box62.Value = CDbl(StatiMacchina.PalletSuNastroDxSupporto.Z) / 1000.0!
            T_box61.Value = CDbl(StatiMacchina.PalletSuNastroDxSupporto.RotazioneZ) / 1000.0!

            'NASTRO DX OLED
            T_box68.Value = CDbl(StatiMacchina.PalletSuNastroDxPezzoFinito.X) / 1000.0!
            T_box67.Value = CDbl(StatiMacchina.PalletSuNastroDxPezzoFinito.Y) / 1000.0!
            T_box66.Value = CDbl(StatiMacchina.PalletSuNastroDxPezzoFinito.Z) / 1000.0!
            T_box65.Value = CDbl(StatiMacchina.PalletSuNastroDxPezzoFinito.RotazioneZ) / 1000.0!

        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function

    Private Sub T_Overr_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object)
        If _ok Then
            Num_Dato = CInt(_tag) : WR_Dato_Short = CShort(_val) 'TAG => 1
        End If
    End Sub

    Private Sub T_MgA_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object)
        If _ok Then
            Num_Dato = CInt(_tag) : WR_Dato_Short = CShort(_val)
        End If
    End Sub

    Private Sub T_xo_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object) Handles T_xo.Txt_Enter, T_yo.Txt_Enter, T_zo.Txt_Enter, T_ao.Txt_Enter, T_xs.Txt_Enter, T_ys.Txt_Enter, T_zs.Txt_Enter, T_as.Txt_Enter, T_xa.Txt_Enter, T_ya.Txt_Enter, T_za.Txt_Enter, T_aa.Txt_Enter, T_box9.Txt_Enter, T_box12.Txt_Enter, T_box11.Txt_Enter, T_box10.Txt_Enter
        If _ok Then
            Num_Dato = CInt(_tag) : WR_Dato_Short = CShort(_val * 1000.0!) 'tag 320/322/324/326 input mm ma PLC vuole micrometri
            '328/330/332/334
            '336/338/340/342
        End If
    End Sub

    Private Sub PP_ax_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object) Handles PP_ax.Txt_Enter, PP_ay.Txt_Enter, PP_az.Txt_Enter, PP_aa.Txt_Enter, PD_ax.Txt_Enter, PD_ay.Txt_Enter, PD_az.Txt_Enter, PD_aa.Txt_Enter, T_box4.Txt_Enter, T_box3.Txt_Enter, T_box2.Txt_Enter, T_box1.Txt_Enter
        If _ok Then
            Num_Dato = CInt(_tag) : WR_Dato_Short = CShort(_val * 1000.0!) 'tag 272/274/276/278 input mm ma PLC vuole micrometri
            '280/282/284/286
            '10/12/14/16
        End If
    End Sub


    Private Sub PP_bx_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object) Handles PP_bx.Txt_Enter, PP_by.Txt_Enter, PP_bz.Txt_Enter, PP_ba.Txt_Enter, PD_bx.Txt_Enter, PD_by.Txt_Enter, PD_bz.Txt_Enter, PD_ba.Txt_Enter, T_box8.Txt_Enter, T_box7.Txt_Enter, T_box6.Txt_Enter, T_box5.Txt_Enter
        If _ok Then
            Num_Dato = CInt(_tag) : WR_Dato_Short = CShort(_val * 1000.0!) '288/290/292/294 'PRELIEVO OLED SX MAGAZZINO SX
        End If
    End Sub

    Private Sub LbButton1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub PP_Mano_angle_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object) Handles T_box37.Txt_Enter, T_box33.Txt_Enter
        If _ok Then
            Num_Dato = CInt(_tag) : WR_Dato_Short = CShort(_val * 1000.0!)

        End If
    End Sub


    Private Sub PP_Mano_Coord_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object) Handles T_box40.Txt_Enter, T_box39.Txt_Enter, T_box38.Txt_Enter, T_box36.Txt_Enter, T_box35.Txt_Enter, T_box34.Txt_Enter
        If _ok Then
            Num_Dato = CInt(_tag) : WR_Dato_Short = CShort(_val * 1000.0!)
        End If
    End Sub

    Private Sub PP_Scarti_angle_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object) Handles T_box25.Txt_Enter, T_box21.Txt_Enter, T_box17.Txt_Enter, T_box13.Txt_Enter
        If _ok Then
            Num_Dato = CInt(_tag) : WR_Dato_Short = CShort(_val * 1000.0!)

        End If
    End Sub


    Private Sub PP_Scarti_Coord_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object) Handles T_box28.Txt_Enter, T_box27.Txt_Enter, T_box26.Txt_Enter, T_box24.Txt_Enter, T_box23.Txt_Enter, T_box22.Txt_Enter, T_box20.Txt_Enter, T_box19.Txt_Enter, T_box18.Txt_Enter, T_box16.Txt_Enter, T_box15.Txt_Enter, T_box14.Txt_Enter
        If _ok Then
            Num_Dato = CInt(_tag) : WR_Dato_Short = CShort(_val * 1000.0!)
        End If
    End Sub

    Private Sub PuntiCamera_angle_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object) Handles T_box69.Txt_Enter, T_box41.Txt_Enter, T_box29.Txt_Enter
        If _ok Then
            Num_Dato = CInt(_tag) : WR_Dato_Short = CShort(_val * 1000.0!)

        End If
    End Sub

    Private Sub T_box52_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object) Handles T_box52.Txt_Enter, T_box56.Txt_Enter, T_box55.Txt_Enter, T_box54.Txt_Enter, T_box51.Txt_Enter, T_box50.Txt_Enter, T_box48.Txt_Enter, T_box47.Txt_Enter, T_box46.Txt_Enter
        'NASTRO SX PUNTI (X,Y,Z)
        If _ok Then
            Num_Dato = CInt(_tag) : WR_Dato_Short = CShort(_val * 1000.0!)
            '600. 602, 604 BIADESIVO
            '620, 622, 624 SUPPORTO
            '640, 644, 646 PRODOTTO FINITO
        End If
    End Sub

    Private Sub T_box49_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object) Handles T_box49.Txt_Enter, T_box53.Txt_Enter, T_box45.Txt_Enter
        'NASTRO SX ANGOLI
        If _ok Then
            Num_Dato = CInt(_tag) : WR_Dato_Short = CShort(_val * 1000.0!)

        End If
        '606 BIADESIVO
        '626 SUPPORTO
        '648 PRODOTTO FINITO
    End Sub

    Private Sub T_box64_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object) Handles T_box64.Txt_Enter, T_box60.Txt_Enter, T_box59.Txt_Enter, T_box58.Txt_Enter
        'NASTRO DX PUNTI (X,Y,Z)
        If _ok Then
            Num_Dato = CInt(_tag) : WR_Dato_Short = CShort(_val * 1000.0!)

        End If
        '660, 662' 664 BIADESIVO
        '680, 682, 684 SUPPORTO
        '700, 702, 704 PRODOTTO FINITO
    End Sub

    Private Sub T_box61_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object) Handles T_box61.Txt_Enter, T_box57.Txt_Enter
        'NASTRO DX ANGOLI
        If _ok Then
            Num_Dato = CInt(_tag) : WR_Dato_Short = CShort(_val * 1000.0!)

        End If
        '666 BIADESIVO
        '686 SUPPORTO
        '706 PRODOTTO FINITO
    End Sub
    Private Function AllDataOk() As Boolean
        If Not txtCompXALTA.Ok Then
            MessageBox.Show("VALORE DI COMPENSAZIONE X CAMERA ALTA NON VALIDO", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If Not txtCompYALTA.Ok Then
            MessageBox.Show("VALORE DI COMPENSAZIONE Y CAMERA ALTA NON VALIDO", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If Not txtCompAngleALTA.Ok Then
            MessageBox.Show("VALORE DI COMPENSAZIONE ANGOLO CAMERA ALTA NON VALIDO", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If Not txtCompXBASSA.Ok Then
            MessageBox.Show("VALORE DI COMPENSAZIONE X CAMERA BASSA NON VALIDO", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If Not txtCompYBASSA.Ok Then
            MessageBox.Show("VALORE DI COMPENSAZIONE Y CAMERA BASSA NON VALIDO", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If Not txtCompAngleBASSA.Ok Then
            MessageBox.Show("VALORE DI COMPENSAZIONE ANGOLO CAMERA BASSA NON VALIDO", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not txtOffsetCameraAltaX.Ok Then
            MessageBox.Show("VALORE DI OFFSET X CAMERA ALTA NON VALIDO", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If Not txtOffsetCameraAltaY.Ok Then
            MessageBox.Show("VALORE DI OFFSET Y CAMERA ALTA NON VALIDO", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If Not txtOffsetCameraAltaA.Ok Then
            MessageBox.Show("VALORE DI OFFSET ANGOLO CAMERA ALTA NON VALIDO", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If Not txtOffsetCameraBassaX.Ok Then
            MessageBox.Show("VALORE DI OFFSET X CAMERA BASSA NON VALIDO", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If Not txtOffsetCameraBassaY.Ok Then
            MessageBox.Show("VALORE DI OFFSET Y CAMERA BASSA NON VALIDO", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If Not txtOffsetCameraBassaA.Ok Then
            MessageBox.Show("VALORE DI OFFSET ANGOLO CAMERA BASSA NON VALIDO", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
    Private Sub btnSalvaComp_Click(sender As Object, e As EventArgs) Handles btnSalvaComp.Click
        If Not AllDataOk() Then
            Return
        End If

        'Dim scope = Bootstrapper.Current.Services.CreateScope()
        Using scope = Bootstrapper.Current.Services.CreateScope()
            Dim context = scope.ServiceProvider.GetRequiredService(Of ProcessDataContext)()
            Try
                Dim visionConfig As List(Of VisionConfiguration) = context.VisionConfigurations.Where(Function(x) x.ProductionConfigurationId = Sett.Id_Tool).ToList()
                Try
                    Dim cameraBassaVisionConfig = visionConfig.Where(Function(x) x.VisionStep = 2).First
                    Dim cameraBassaOffset As VisionOffset = context.VisionOffsets.Where(Function(x) x.VisionConfigurationId = cameraBassaVisionConfig.Id).First
                    cameraBassaOffset.X = CSng(txtCompXBASSA.Value)
                    cameraBassaOffset.Y = CSng(txtCompYBASSA.Value)
                    cameraBassaOffset.Angle = CSng(txtCompAngleBASSA.Value)

                    cameraBassaOffset.SecondX = CSng(txtOffsetCameraBassaX.Value)
                    cameraBassaOffset.SecondY = CSng(txtOffsetCameraBassaY.Value)
                    cameraBassaOffset.SecondAngle = CSng(txtOffsetCameraBassaA.Value)
                Catch ex As Exception
                    show_eccezione(ex)
                End Try

                Try
                    Dim cameraAltaVisionConfig = visionConfig.Where(Function(x) x.VisionStep = 4).First
                    Dim cameraAltaOffset As VisionOffset = context.VisionOffsets.Where(Function(x) x.VisionConfigurationId = cameraAltaVisionConfig.Id).First
                    cameraAltaOffset.X = CSng(txtCompXALTA.Value)
                    cameraAltaOffset.Y = CSng(txtCompYALTA.Value)
                    cameraAltaOffset.Angle = CSng(txtCompAngleALTA.Value)

                    cameraAltaOffset.SecondX = CSng(txtOffsetCameraAltaX.Value)
                    cameraAltaOffset.SecondY = CSng(txtOffsetCameraAltaY.Value)
                    cameraAltaOffset.SecondAngle = CSng(txtOffsetCameraAltaA.Value)
                Catch ex As Exception
                    show_eccezione(ex)
                End Try
                context.SaveChanges()
                AggiornaMondo()
                ReadCompensazioni()
                SaveOrUpdatePreset()
            Catch ex As Exception
                show_eccezione(ex)
            End Try
        End Using
    End Sub
    Private Sub AggiornaMondo()
        StatiMacchina.OffsetVisioneCameraBassa.X = txtCompXBASSA.Value
        StatiMacchina.OffsetVisioneCameraBassa.Y = txtCompYBASSA.Value
        StatiMacchina.OffsetVisioneCameraBassa.Rotazione = txtCompAngleBASSA.Value

        StatiMacchina.OffsetVisioneCameraAlta.X = txtCompXALTA.Value
        StatiMacchina.OffsetVisioneCameraAlta.Y = txtCompYALTA.Value
        StatiMacchina.OffsetVisioneCameraAlta.Rotazione = txtCompAngleALTA.Value

        StatiMacchina.OffsetUtenteVisioneCameraBassa.X = txtOffsetCameraBassaX.Value
        StatiMacchina.OffsetUtenteVisioneCameraBassa.Y = txtOffsetCameraBassaY.Value
        StatiMacchina.OffsetUtenteVisioneCameraBassa.Rotazione = txtOffsetCameraBassaA.Value

        StatiMacchina.OffsetUtenteVisioneCameraAlta.X = txtOffsetCameraAltaX.Value
        StatiMacchina.OffsetUtenteVisioneCameraAlta.Y = txtOffsetCameraAltaY.Value
        StatiMacchina.OffsetUtenteVisioneCameraAlta.Rotazione = txtOffsetCameraAltaA.Value
    End Sub

    Private Sub Lt_x_Click(sender As Object, e As EventArgs) Handles Lt_x.Click

    End Sub

    Private Sub Lt_y_Click(sender As Object, e As EventArgs) Handles Lt_y.Click

    End Sub

    Private Sub Label100_Click(sender As Object, e As EventArgs) Handles Label100.Click

    End Sub

    Private Sub txtCompXALTA_TextChanged(sender As Object, e As EventArgs) Handles txtCompXALTA.TextChanged

    End Sub

    Private Sub Label54_Click(sender As Object, e As EventArgs) Handles Label54.Click

    End Sub

    Private Sub PuntiCamera_coord_Txt_Enter(_ok As Boolean, _val As Double, _tag As Object) Handles T_box72.Txt_Enter, T_box71.Txt_Enter, T_box70.Txt_Enter, T_box44.Txt_Enter, T_box43.Txt_Enter, T_box42.Txt_Enter, T_box32.Txt_Enter, T_box31.Txt_Enter, T_box30.Txt_Enter
        If _ok Then
            Num_Dato = CInt(_tag) : WR_Dato_Short = CShort(_val * 1000.0!)
        End If
    End Sub



End Class
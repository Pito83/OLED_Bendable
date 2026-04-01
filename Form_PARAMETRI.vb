Imports System.ComponentModel
Imports System.Data
Imports System.IO
Imports Oled.DataLayer
Imports Microsoft.Extensions.DependencyInjection
Imports System.Linq
Imports Microsoft.EntityFrameworkCore

Public Class Form_PARAMETRI

    Private n_butt As Integer
    Private _Mod_ID, _Act_Model, _Tool_n, Tool_id As Integer
    Private _riga_selz As Integer
    Private _BS As New BindingSource
    Private _r_m, _c_m, k As Integer


    Private Loc_Context As ProcessDataContext
    Private Loc_Scope As IServiceScope

    Private Loc_Modello As Model
    Private Loc_Modelli As New List(Of Model)
    Private Loc_Tools() As ProductionConfiguration
    Private Loc_Viti As New List(Of ScrewingStationConfiguration)
    Private Loc_NipCode As New List(Of DMDSMMID)
    Private Loc_PuntiViteSX As New List(Of ScrewPoint)
    Private Loc_PuntiViteDX As New List(Of ScrewPoint)
    Private Loc_PalletNastroSx As New List(Of PalletConfiguration)
    Private Loc_PalletNastroDx As New List(Of PalletConfiguration)
    Private Loc_Pall_A As New List(Of RobotPoint)
    Private Loc_Pall_B As New List(Of RobotPoint)
    Private Loc_Incollaggio As New List(Of RobotPoint)
    ''' <summary>
    ''' Lista punti magazzino A
    ''' </summary>
    Private L_P_MA As New List(Of RobotPoint)
    ''' <summary>
    ''' Lista punti magazzino B
    ''' </summary>
    Private L_P_MB As New List(Of RobotPoint)
    Private Loc_Vision As New List(Of VisionConfiguration)
    Private Loc_PuVis As New List(Of RobotPoint)
    Private _clk, Choice, Salva, Modifica As Boolean


#Region "Form"
    Private Sub Form_PARAMETRI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = Loc_mdi
        N_MDI_from = 10
        Choice = False
        req_dati = False : req_dati_ready = False
        PaginaAperta = "PARAMETRI" '  F_main.Lab_titolo.Text = "PARAMETRI"
        F_main.Lab_titolo.BackColor = Color.Blue
        _Tool_n = -1
        popola_parametri()

        Me.ResumeLayout()
    End Sub
    Private Sub Form_PARAMETRI_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Loc_Scope = Bootstrapper.Current.Services.CreateScope
        Loc_Context = Loc_Scope.ServiceProvider.GetRequiredService(Of ProcessDataContext)()
        Timer1.Enabled = True
        _Act_Model = Sett.Id_Modello : Tool_id = Sett.Id_Tool
    End Sub
    Private Sub Form_PARAMETRI_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Stop() : Timer1.Enabled = True
        If Loc_Context IsNot Nothing Then
            Loc_Context.Dispose()
        End If
        If Loc_Scope IsNot Nothing Then
            Loc_Scope.Dispose()
        End If
    End Sub
    Private Sub Form_PARAMETRI_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub popola_parametri()

    End Sub
#End Region

#Region "Bottoni"
    Private Sub Tool_DWDX_Click(sender As Object, e As EventArgs) Handles Tool_DWDX.Click
        Choice = False
        Pulisci_Tabelle()
        DGrid1.DataSource = Nothing
        DGrid1.Refresh()
        _Act_Model = Sett.Id_Modello : Tool_id = Sett.Id_Tool : _Tool_n = -1
    End Sub
    Private Sub Tool_UPDX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_UPDX.Click
        Choice = True
        Pulisci_Tabelle()
        DGrid1.DataSource = Nothing
        DGrid1.Refresh()
        If Load_Modelli() Then
            Popola_Modelli()
        End If
    End Sub

    Private Sub Tool_Attiva_Click(sender As Object, e As EventArgs) Handles Tool_Attiva.Click
        If Init_opzio = True Then Exit Sub
        If Choice Then Exit Sub
        Try
            If Prep_Tx(Loc_Modello.RobotCode, Loc_Tools(0)) Then
                _tx_dati = True
                Init_opzio = True
                ByPassTrueInit = True
                Modifica = False
            End If
        Catch ex As Exception
            show_eccezione(ex)
        End Try

    End Sub

    Private Sub Tool_gen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_gen.Click
        'Crea_mod()
    End Sub
    Private Sub Tool_SALVA_Click(sender As Object, e As EventArgs) Handles Tool_SALVA.Click
        Loc_Context.SaveChanges()
        Salva = False
        Modifica = Not Choice
    End Sub
    Private Sub Lab_Info_Click(sender As Object, e As EventArgs) Handles Lab_Info.Click
        ' Salva = False : Modifica = False
    End Sub
#End Region


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim _edit As Boolean = Log_1 And Not Automatico
        _clk = Not _clk

        Tool_SALVA.Enabled = Salva And Not Automatico
        Tool_gen.Visible = Log_4 And Not Automatico
        Tool_Attiva.Enabled = Modifica And Not Choice And Not Automatico

        DG_Modelli.ReadOnly = Not _edit : DGrid1.ReadOnly = Not _edit : DG_Magazz.ReadOnly = Not _edit : DG_PMA.ReadOnly = Not _edit : DG_PMB.ReadOnly = Not _edit
        DG_Avvita.ReadOnly = Not _edit : DG_Viti_NastroSX.ReadOnly = Not _edit : DG_Viti_NastroDX.ReadOnly = Not _edit
        DG_PalletNastroSX.ReadOnly = Not _edit : DG_PalletNastroDX.ReadOnly = Not _edit : DG_Pall4_A.ReadOnly = Not _edit : DG_Pall4_B.ReadOnly = Not _edit : DG_Visioni.ReadOnly = Not _edit : DG_PuVis.ReadOnly = Not _edit
        DGIncollaggio.ReadOnly = Not _edit
        DG_NipCode.ReadOnly = Not _edit

        If Salva Or Modifica Then
            If Salva Then
                Lab_Info.BackColor = Color.Lime
                Lab_Info.Text = "SALVARE MODIFICHE"
            Else
                Lab_Info.BackColor = Color.Yellow
                Lab_Info.Text = "ATTIVARE MODIFICHE ??"
            End If
            Lab_Info.Visible = _clk
        Else
            Lab_Info.Visible = False
        End If


        If New_Init_Option Then
            New_Init_Option = False
            Tool_DWDX.PerformClick()
            Exit Sub
        End If

        If req_dati_ready = True Then
            req_dati_ready = False
            read_punti()
            read_Viti()
        End If

        If _Act_Model > 0 Then
            Pulisci_Tabelle()
            If Load_ModellO(_Act_Model) Then
                Loc_Modelli.Clear()
                Loc_Modelli.Add(Loc_Modello)
                Popola_Modelli()
                If Get_Tool_From_Id(Tool_id) Then
                    If Popo_DG_Tools() Then
                        _Tool_n = 0 'prima riga
                    End If
                End If
            End If
            _Act_Model = -1
        End If

        If _Mod_ID > 0 Then
            Pulisci_Tabelle()
            If Get_Tool_F_Moldel(_Mod_ID) Then
                Popo_DG_Tools()
            Else
                DGrid1.DataSource = Nothing
                DGrid1.Refresh()
            End If
        End If
        _Mod_ID = 0
        If _Tool_n > -1 Then
            Pulisci_Tabelle()

            If Get_Incollaggio(_Tool_n) Then
                Popo_DG_Incollaggio()
            End If

            If Get_Mag_Maps(_Tool_n) Then
                If Pop_DG_Mag() Then
                    Pop_DG_P_Mag()
                End If
                If Get_NipCodes(_Tool_n) Then
                    Pop_DG_NipCode()
                End If
                If Get_Screw_Stations(_Tool_n) Then
                    Pop_DG_Avita()
                    If Get_Screw_Points(_Tool_n) Then
                        Pop_DG_Viti()
                    End If
                End If
                If Get_Pall4_Station(_Tool_n) Then
                    If Pop_DG_PalletNastriSXDX() Then
                        If Get_Pall4_Points(_Tool_n) Then
                            Pop_DG_Pu_Pall4()
                        End If
                    End If
                End If
                If Get_Vision_Station(_Tool_n) Then
                    If Pop_DG_Vision() Then
                        If Get_Vis_Points(_Tool_n) Then
                            Pop_DG_Pu_Vis()
                        End If
                    End If
                End If
            End If
            _Tool_n = -1
        End If
        '  _Tool_n = -1
    End Sub
#Region "Popola tabelle"
    Private Sub Pulisci_Tabelle()
        Try
            DG_Magazz.DataSource = Nothing
            DG_Magazz.Refresh()
            DG_PMA.DataSource = Nothing
            DG_PMA.Refresh()
            DG_PMB.DataSource = Nothing
            DG_PMB.Refresh()
            DG_Avvita.DataSource = Nothing
            DG_Avvita.Refresh()
            DG_NipCode.DataSource = Nothing
            DG_NipCode.Refresh()
            DG_Viti_NastroSX.DataSource = Nothing
            DG_Viti_NastroSX.Refresh()
            DG_Viti_NastroDX.DataSource = Nothing
            DG_Viti_NastroDX.Refresh()
            DG_PalletNastroSX.DataSource = Nothing
            DG_PalletNastroSX.Refresh()
            DG_PalletNastroDX.DataSource = Nothing
            DG_PalletNastroDX.Refresh()
            DG_Pall4_A.DataSource = Nothing
            DG_Pall4_A.Refresh()
            DG_Pall4_B.DataSource = Nothing
            DG_Pall4_B.Refresh()
            DGIncollaggio.DataSource = Nothing
            DGIncollaggio.Refresh()
            DG_Visioni.DataSource = Nothing
            DG_Visioni.Refresh()
            DG_PuVis.DataSource = Nothing
            DG_PuVis.Refresh()
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
    Private Function Popo_DG_Tools() As Boolean
        Try
            With DGrid1
                .DataSource = Loc_Tools
                .Columns(0).ReadOnly = True : .Columns(0).Width = 40 'ID
                .Columns("Order").Visible = False 'ORDER

                .Columns("Name").Width = 120
                .Columns("Description").Width = 140
                .Columns("DSM_ModelID").Width = 140
                .Columns("DSM_ModelID").Visible = False

                .Columns("Model").Visible = False
                .Columns("ModelId").Visible = False
                .Columns("MagazinA").Visible = False
                .Columns("MagazinB").Visible = False
                .Columns("PalletNastroSxConfiguration").Visible = False
                .Columns("PalletNastroDxConfiguration").Visible = False
                .Columns("ScrewingStationConfiguration").Visible = False
                .Columns("VisionConfigurations").Visible = False
                .Columns("PuntoIncollaggio").Visible = False
                .Refresh()
            End With
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function

    Private Function Popo_DG_Incollaggio() As Boolean
        Try
            With DGIncollaggio
                .DataSource = Nothing
                .Refresh()
                .DataSource = Loc_Incollaggio
                .Columns(0).ReadOnly = True : .Columns(0).Width = 40    'ID
                .Columns(1).Visible = True : .Columns(1).Width = 110 : .Columns(1).DefaultCellStyle.BackColor = Color.Silver 'Nome
                .Columns(2).Visible = False         'Order
                .Columns(3).Width = 55
                .Columns(4).Width = 55
                .Columns(5).Width = 55
                .Columns(6).Width = 55 : .Columns(6).DefaultCellStyle.Format = "0.0"
                .Columns(6).HeaderText = "rX"
                .Columns(6).Visible = False
                .Columns(7).Width = 55 : .Columns(7).DefaultCellStyle.Format = "0.0"
                .Columns(7).HeaderText = "rY"
                .Columns(7).Visible = False
                .Columns(8).Width = 55 : .Columns(8).DefaultCellStyle.Format = "0.0"
                .Columns(8).HeaderText = "rZ"
                .AllowUserToAddRows = False
                .Refresh()
            End With
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function

    Private Function Popola_Modelli() As Boolean
        Try
            With DG_Modelli
                .DataSource = Loc_Modelli
                .Columns(0).Visible = False : .Columns(0).ReadOnly = True : .Columns(0).Width = 50    'ID
                .Columns(1).Visible = True : .Columns(1).Width = 50     'Name
                .Columns(2).Visible = True : .Columns(2).Width = 140    'Descrip
                .Columns(3).Visible = True : .Columns(3).Width = 100    'Version
                .Columns(4).Visible = True : .Columns(4).Width = 40 'Robot code
                .Columns(5).Visible = False
                .Refresh()
            End With
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Function Pop_DG_Mag() As Boolean
        Try
            With DG_Magazz
                .DataSource = Nothing
                .Refresh()
                .DataSource = _MappeMagazz
                .Columns(0).ReadOnly = True : .Columns(0).Width = 40
                .Columns(1).Width = 130    'Name
                .Columns(2).Visible = False
                .Columns(3).Visible = False

                .Columns(4).Width = 100  'code
                .Columns(5).Width = 60 'rows
                .Columns(6).Width = 60  'colum
                .Columns("Order").Visible = False
                .Columns(7).Visible = False
                .Refresh()
            End With
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Function Pop_DG_P_Mag() As Boolean
        Try
            If L_P_MA.Count > 0 Then
                With DG_PMA
                    .DataSource = Nothing
                    .Refresh()
                    .DataSource = L_P_MA
                    .Columns(0).Width = 40
                    .Columns(1).Visible = False
                    .Columns(2).ReadOnly = True : .Columns(2).Width = 50    'Ord
                    .Columns(3).Width = 60 : .Columns(3).DefaultCellStyle.Format = "0.0"
                    .Columns(4).Width = 60 : .Columns(4).DefaultCellStyle.Format = "0.0"
                    .Columns(5).Width = 60 : .Columns(5).DefaultCellStyle.Format = "0.0"
                    .Columns(6).Width = 60 : .Columns(6).DefaultCellStyle.Format = "0.0"
                    .Columns(6).HeaderText = "rX"
                    .Columns(6).Visible = False
                    .Columns(7).Width = 60 : .Columns(7).DefaultCellStyle.Format = "0.0"
                    .Columns(7).HeaderText = "rY"
                    .Columns(7).Visible = False
                    .Columns(8).Width = 60 : .Columns(8).DefaultCellStyle.Format = "0.0"
                    .Columns(8).HeaderText = "rZ"
                    .Refresh()
                End With
            Else
                DG_PMA.DataSource = Nothing
                DG_PMA.Refresh()
            End If
            If L_P_MB.Count > 0 Then
                With DG_PMB
                    .DataSource = Nothing
                    .Refresh()
                    .DataSource = L_P_MB
                    .Columns(0).Width = 40
                    .Columns(1).Visible = False
                    .Columns(2).ReadOnly = True : .Columns(2).Width = 50    'Ord
                    .Columns(3).Width = 60 : .Columns(3).DefaultCellStyle.Format = "0.0"
                    .Columns(4).Width = 60 : .Columns(4).DefaultCellStyle.Format = "0.0"
                    .Columns(5).Width = 60 : .Columns(5).DefaultCellStyle.Format = "0.0"
                    .Columns(6).Width = 60 : .Columns(6).DefaultCellStyle.Format = "0.0"
                    .Columns(6).HeaderText = "rX"
                    .Columns(6).Visible = False
                    .Columns(7).Width = 60 : .Columns(7).DefaultCellStyle.Format = "0.0"
                    .Columns(7).HeaderText = "rY"
                    .Columns(7).Visible = False
                    .Columns(8).Width = 60 : .Columns(8).DefaultCellStyle.Format = "0.0"
                    .Columns(8).HeaderText = "rZ"
                    .Refresh()
                End With
            Else
                DG_PMB.DataSource = Nothing
                DG_PMB.Refresh()
            End If

        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Function Pop_DG_NipCode() As Boolean
        Try
            With DG_NipCode
                .DataSource = Nothing
                .Refresh()
                .DataSource = Loc_NipCode
                .Columns(0).ReadOnly = True : .Columns(0).Width = 40
                .Columns(1).Visible = True : .Columns(1).ReadOnly = True : .Columns(1).Width = 200
                .Columns(2).Visible = False
                .Columns(3).Visible = True : .Columns(3).Width = 100
                .Columns(4).Visible = True : .Columns(4).Width = 100
                .Refresh()
            End With
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function

    Private Function Pop_DG_Avita() As Boolean
        Try
            With DG_Avvita
                .DataSource = Nothing
                .Refresh()
                .DataSource = Loc_Viti
                .Columns(0).ReadOnly = True : .Columns(0).Width = 40
                .Columns(1).Visible = True : .Columns(1).Width = 100
                .Columns(2).Visible = True : .Columns(2).Width = 200  'Order
                .Columns("PalletNastroSxScrewPoints").Visible = False
                .Columns("PalletNastroDxScrewPoints").Visible = False
                .Refresh()
            End With
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Function Pop_DG_Viti() As Boolean
        Dim i As Integer
        Try
            With DG_Viti_NastroSX
                .DataSource = Nothing
                .Refresh()
                .DataSource = Loc_PuntiViteSX
                .Columns(0).ReadOnly = True : .Columns(0).Width = 40
                .Columns(1).Visible = True : .Columns(1).Width = 110 ': .Columns(1).DefaultCellStyle.BackColor = Color.Silver 'Nome
                .Columns(2).Visible = True : .Columns(2).ReadOnly = True : .Columns(2).Width = 50
                For i = 3 To .Columns.Count - 1
                    .Columns(i).Width = 50
                Next
                .Refresh()
            End With

            With DG_Viti_NastroDX
                .DataSource = Nothing
                .Refresh()
                .DataSource = Loc_PuntiViteDX
                .Columns(0).ReadOnly = True : .Columns(0).Width = 40
                .Columns(1).Visible = True : .Columns(1).Width = 110 ': .Columns(1).DefaultCellStyle.BackColor = Color.Silver 'Nome
                .Columns(2).Visible = True : .Columns(2).ReadOnly = True : .Columns(2).Width = 50
                For i = 3 To .Columns.Count - 1
                    .Columns(i).Width = 50
                Next
                .Refresh()
            End With
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function

    Private Function Pop_DG_PalletNastriSXDX() As Boolean
        Dim i As Integer
        Try
            With DG_PalletNastroSX
                .DataSource = Nothing
                .Refresh()
                .DataSource = Loc_PalletNastroSx
                .Columns(0).ReadOnly = True : .Columns(0).Width = 40
                .Columns(1).Visible = True : .Columns(1).Width = 150 ': .Columns(1).DefaultCellStyle.BackColor = Color.Silver 'Nome
                .Columns(2).Visible = False   'Descriz
                .Columns(3).Visible = False 'Ordine
                .Columns(4).Width = 90
                For i = 5 To .Columns.Count - 1
                    .Columns(i).Visible = False : .Columns(i).DefaultCellStyle.Format = "0.0"
                Next
                .Refresh()
            End With

            With DG_PalletNastroDX
                .DataSource = Nothing
                .Refresh()
                .DataSource = Loc_PalletNastroDx
                .Columns(0).ReadOnly = True : .Columns(0).Width = 40
                .Columns(1).Visible = True : .Columns(1).Width = 150 ': .Columns(1).DefaultCellStyle.BackColor = Color.Silver 'Nome
                .Columns(2).Visible = False   'Descriz
                .Columns(3).Visible = False 'Ordine
                .Columns(4).Width = 90
                For i = 5 To .Columns.Count - 1
                    .Columns(i).Visible = False : .Columns(i).DefaultCellStyle.Format = "0.0"
                Next
                .Refresh()
            End With
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Function Pop_DG_Pu_Pall4() As Boolean
        Try
            With DG_Pall4_A
                .DataSource = Nothing
                .Refresh()
                .DataSource = Loc_Pall_A

                .Columns(0).ReadOnly = True : .Columns(0).Width = 40    'ID
                .Columns(1).Visible = True : .Columns(1).Width = 250 : .Columns(1).DefaultCellStyle.BackColor = Color.Silver 'Nome
                .Columns(2).Visible = False         'Order
                .Columns(3).Width = 40 : .Columns(3).DefaultCellStyle.Format = "0.0"
                .Columns(4).Width = 40 : .Columns(4).DefaultCellStyle.Format = "0.0"
                .Columns(5).Width = 40 : .Columns(5).DefaultCellStyle.Format = "0.0"
                .Columns(6).Width = 40 : .Columns(6).DefaultCellStyle.Format = "0.0"
                .Columns(6).HeaderText = "rX"
                .Columns(6).Visible = False
                .Columns(7).Width = 40 : .Columns(7).DefaultCellStyle.Format = "0.0"
                .Columns(7).HeaderText = "rY"
                .Columns(7).Visible = False
                .Columns(8).Width = 40 : .Columns(8).DefaultCellStyle.Format = "0.0"
                .Columns(8).HeaderText = "rZ"
                .AllowUserToAddRows = False
                .Refresh()
            End With

            With DG_Pall4_B
                .DataSource = Nothing
                .Refresh()
                .DataSource = Loc_Pall_B
                .Columns(0).ReadOnly = True : .Columns(0).Width = 40    'ID
                .Columns(1).Visible = True : .Columns(1).Width = 250 : .Columns(1).DefaultCellStyle.BackColor = Color.Silver 'Nome
                .Columns(2).Visible = False         'Order
                .Columns(3).Width = 40 : .Columns(3).DefaultCellStyle.Format = "0.0"
                .Columns(4).Width = 40 : .Columns(4).DefaultCellStyle.Format = "0.0"
                .Columns(5).Width = 40 : .Columns(5).DefaultCellStyle.Format = "0.0"
                .Columns(6).Width = 40 : .Columns(6).DefaultCellStyle.Format = "0.0"
                .Columns(6).HeaderText = "rX"
                .Columns(6).Visible = False
                .Columns(7).Width = 40 : .Columns(7).DefaultCellStyle.Format = "0.0"
                .Columns(7).HeaderText = "rY"
                .Columns(7).Visible = False
                .Columns(8).Width = 40 : .Columns(8).DefaultCellStyle.Format = "0.0"
                .Columns(8).HeaderText = "rZ"
                .AllowUserToAddRows = False
                .Refresh()
            End With
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Function Pop_DG_Vision() As Boolean
        Dim i As Integer
        Try
            With DG_Visioni
                .DataSource = Nothing
                .Refresh()
                .DataSource = Loc_Vision
                .Columns(0).Visible = False ': .Columns(0).ReadOnly = True : .Columns(0).Width = 40
                .Columns(1).Visible = True : .Columns(1).Width = 230 ': 'Nome
                .Columns(2).Visible = True : .Columns(2).Width = 130  'Descriz
                .Columns(3).Visible = False : .Columns(3).Width = 20 : .Columns(3).ReadOnly = True : .Columns(3).HeaderText = "Plc Cycle" 'Ordine
                .Columns(4).Width = 70 : .Columns(4).HeaderText = "Step"
                For i = 5 To .Columns.Count - 1
                    .Columns(i).Visible = False
                Next
                .Refresh()
            End With
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Function Pop_DG_Pu_Vis() As Boolean
        Try
            With DG_PuVis
                .DataSource = Nothing
                .Refresh()
                .DataSource = Loc_PuVis
                .Columns(0).ReadOnly = True : .Columns(0).Width = 40    'ID
                .Columns(1).Visible = True : .Columns(1).Width = 150 : .Columns(1).DefaultCellStyle.BackColor = Color.Silver 'Nome
                .Columns(2).Visible = False         'Order
                .Columns(3).Width = 55
                .Columns(4).Width = 55
                .Columns(5).Width = 55
                .Columns(6).Width = 55 : .Columns(6).DefaultCellStyle.Format = "0.0"
                .Columns(6).HeaderText = "rX"
                .Columns(6).Visible = False
                .Columns(7).Width = 55 : .Columns(7).DefaultCellStyle.Format = "0.0"
                .Columns(7).HeaderText = "rY"
                .Columns(7).Visible = False
                .Columns(8).Width = 55 : .Columns(8).DefaultCellStyle.Format = "0.0"
                .Columns(8).HeaderText = "rZ"
                .AllowUserToAddRows = False
                .Refresh()
            End With
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
#End Region

#Region "EVENTI DATAGRID"
    Private Sub DG_Modelli_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Modelli.CellClick
        If Not Choice Then Exit Sub
        _r_m = e.RowIndex
        If _r_m > -1 Then
            _Mod_ID = CInt(DG_Modelli.Rows(_r_m).Cells(0).Value)
        Else
            _Mod_ID = 0
        End If
    End Sub '

    Private Sub DGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGrid1.CellClick
        If Not Choice Then Exit Sub
        _r_m = e.RowIndex
        If Loc_Tools Is Nothing Then
            _Tool_n = -1
        Else
            _Tool_n = _r_m
        End If
    End Sub
    Private Sub DGrid1_CellParsing(sender As Object, e As DataGridViewCellParsingEventArgs) Handles DGrid1.CellParsing, DG_Modelli.CellParsing, DG_Magazz.CellParsing, DG_PMA.CellParsing, DG_PMB.CellParsing, DG_Avvita.CellParsing, DG_Viti_NastroSX.CellParsing, DG_Viti_NastroDX.CellParsing, DG_Viti_NastroSX.CellParsing, DG_NipCode.CellParsing
        Salva = True
    End Sub
    Private Sub DG_Pressa_CellParsing(sender As Object, e As DataGridViewCellParsingEventArgs) Handles DG_Pall4_A.CellParsing, DG_Pall4_B.CellParsing, DG_Visioni.CellParsing, DG_PuVis.CellParsing, DG_PalletNastroSX.CellParsing, DG_PalletNastroDX.CellParsing, DGIncollaggio.CellParsing
        Salva = True
    End Sub


    Private Sub DGrid1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DGrid1.DataError
        show_eccezione("PRPDOTTI" & vbCrLf & e.Exception.ToString)
    End Sub

    Private Sub DG_Modelli_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DG_Modelli.DataError
        '' show_eccezione("MODELLI" & VisErrTxt & e.Exception.ToString)
    End Sub

    Private Sub DG_Magazz_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Magazz.CellContentClick

    End Sub

    Private Sub DG_Magazz_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DG_Magazz.DataError
        show_eccezione("MAGAZZINI" & VisErrTxt & e.Exception.ToString)
    End Sub

    Private Sub DG_PMA_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DG_PMA.DataError
        show_eccezione("PUNTI ROBOT A" & VisErrTxt & e.Exception.ToString)
    End Sub

    Private Sub DG_PMB_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DG_PMB.DataError
        ' show_eccezione("PUNTI ROBOT B" & VisErrTxt & e.Exception.ToString)
    End Sub
#End Region

#Region "DATABASE"
    Friend Function Load_ModellO(ByVal _ID As Integer) As Boolean
        Try
            Loc_Modello = Loc_Context.Models.Where(Function(x) x.Id = _ID).FirstOrDefault
            If Loc_Modello Is Nothing Then
                show_eccezione("!!! Tabella modelli non trovata. Controllare DB !!!")
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Friend Function Load_Modelli() As Boolean
        Try
            Loc_Modelli = Loc_Context.Models.ToList
            If Loc_Modelli Is Nothing Then
                show_eccezione("!!! Tabella modelli non trovata. Controllare DB !!!")
                Return False
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Function Get_Tool_From_Id(ByVal _id As Integer) As Boolean
        Try
            Loc_Tools = Loc_Context.Tools.Where(Function(x) x.Id = _id).ToArray
            If Loc_Tools Is Nothing Then
                Return False
            Else
                Loc_Context.MagazinMaps.Load()
                Loc_Context.PalletConfigurations.Load
                Loc_Context.RobotPoints.Load
                Loc_Context.ScrewingStationConfigurations.Load
                Loc_Context.ScrewPoints.Load
                Loc_Context.VisionConfigurations.Load
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        Finally
            ' _Scope.Dispose()
        End Try
        Return True
    End Function
    Private Function Get_Tool_F_Moldel(ByVal _M As Integer) As Boolean
        Try
            Loc_Tools = Loc_Context.Tools.Where(Function(x) x.ModelId = _M).ToArray
            If Loc_Tools Is Nothing Then
                Return False
            Else
                Loc_Context.MagazinMaps.Load()
                Loc_Context.PalletConfigurations.Load
                Loc_Context.RobotPoints.Load
                Loc_Context.ScrewingStationConfigurations.Load
                Loc_Context.ScrewPoints.Load
                Loc_Context.VisionConfigurations.Load
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        Finally
            ' _Scope.Dispose()
        End Try
        Return True
    End Function
    Private Function Get_Mag_Maps(ByVal _n As Integer) As Boolean
        Try
            '     _Magazzini = Context.MagazinMaps.Where(Function(x) x.Id = Loc_Tools(_n).MagazinA.Id).ToList
            _MappeMagazz.Clear() : L_P_MA.Clear() : L_P_MB.Clear()

            If True Then
                _MappeMagazz.Add(Loc_Tools(_n).MagazinA)
                L_P_MA = Loc_Tools(_n).MagazinA.RobotPoints.OrderBy(Function(y) y.Order).ToList 'QUALE ORDINE??????
            End If
            If True Then
                'If Loc_Tools(_n).MagazinB.Id <> Loc_Tools(_n).MagazinA.Id Then
                _MappeMagazz.Add(Loc_Tools(_n).MagazinB)
                L_P_MB = Loc_Tools(_n).MagazinB.RobotPoints.OrderBy(Function(y) y.Order).ToList
                'End If
            End If
            If _MappeMagazz Is Nothing Then Return False
            If _MappeMagazz.Count < 1 Then Return False
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        Finally
            ' _Scope.Dispose()
        End Try
        Return True
    End Function
    Private Function Get_Screw_Stations(ByVal _id As Integer) As Boolean
        Try
            Loc_Viti.Clear()
            Loc_Viti.Add(Loc_Tools(_id).ScrewingStationConfiguration)
            If Loc_Viti Is Nothing Then Return False
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function

    Private Function Get_NipCodes(ByVal _id As Integer) As Boolean
        Try
            Loc_NipCode.Clear()
            Loc_NipCode = Loc_Context.DMDSMMIDs.Where(Function(x) x.Name.Contains(Loc_Tools(_id).Name)).ToList()
            If Loc_NipCode Is Nothing Then Return False
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Function Get_Screw_Points(ByVal _id As Integer) As Boolean
        Try
            Loc_PuntiViteSX.Clear()
            Loc_PuntiViteSX = Loc_Tools(_id).ScrewingStationConfiguration.PalletNastroSxScrewPoints.OrderBy(Function(y) y.Order).ToList
            If Loc_PuntiViteSX Is Nothing Then Return False
            If Loc_PuntiViteSX.Count < 1 Then Return False

            Loc_PuntiViteDX.Clear()
            Loc_PuntiViteDX = Loc_Tools(_id).ScrewingStationConfiguration.PalletNastroDxScrewPoints.OrderBy(Function(y) y.Order).ToList
            If Loc_PuntiViteDX Is Nothing Then Return False
            If Loc_PuntiViteDX.Count < 1 Then Return False
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function

    Private Sub DG_Modelli_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Modelli.CellContentClick

    End Sub

    Private Sub DG_PMB_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_PMB.CellContentClick

    End Sub

    Private Sub DG_Viti_NastroDX_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Viti_NastroDX.CellContentClick

    End Sub

    Private Sub ToolDsm_Click(sender As Object, e As EventArgs) Handles ToolDsm.Click
        Dim _f As Form
        _f = New Form_MTS
        _f.ShowDialog()
    End Sub

    Private Function Get_Pall4_Station(ByVal _id As Integer) As Boolean
        Try
            Loc_PalletNastroSx.Clear()
            Loc_PalletNastroSx.Add(Loc_Tools(_id).PalletNastroSxConfiguration)
            If Loc_PalletNastroSx Is Nothing Then Return False

            Loc_PalletNastroDx.Clear()
            Loc_PalletNastroDx.Add(Loc_Tools(_id).PalletNastroDxConfiguration)
            If Loc_PalletNastroDx Is Nothing Then Return False
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Function Get_Pall4_Points(ByVal _id As Integer) As Boolean
        Try
            With Loc_Pall_A
                .Clear()
                .Add(Loc_Tools(_id).PalletNastroSxConfiguration.PuntoDepositoOled)
                .Add(Loc_Tools(_id).PalletNastroSxConfiguration.PuntoPrelievoAdesivo)
                .Add(Loc_Tools(_id).PalletNastroSxConfiguration.PuntoPrelievoSupporto)
                .Add(Loc_Tools(_id).PalletNastroSxConfiguration.PuntoSfoglioLinerOled)
            End With
            With Loc_Pall_B
                .Clear()
                .Add(Loc_Tools(_id).PalletNastroDxConfiguration.PuntoDepositoOled)
                .Add(Loc_Tools(_id).PalletNastroDxConfiguration.PuntoPrelievoAdesivo)
                .Add(Loc_Tools(_id).PalletNastroDxConfiguration.PuntoPrelievoSupporto)
                .Add(Loc_Tools(_id).PalletNastroDxConfiguration.PuntoSfoglioLinerOled)
            End With
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function

    Private Function Get_Incollaggio(ByVal _id As Integer) As Boolean
        Try
            With Loc_Incollaggio
                .Clear()
                .Add(Loc_Tools(_id).PuntoIncollaggio)
            End With
            If Loc_Incollaggio Is Nothing Then Return False
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function

    Private Function Get_Vision_Station(ByVal _id As Integer) As Boolean
        Try
            Loc_Vision.Clear()
            Loc_Vision = Loc_Tools(_id).VisionConfigurations.OrderBy(Function(y) y.VisionOrderId).ToList
            If Loc_Vision Is Nothing Then Return False
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Function Get_Vis_Points(ByVal _id As Integer) As Boolean
        Dim i As Integer
        Try
            Loc_PuVis.Clear()
            For i = 0 To Loc_Vision.Count - 1
                If (Loc_Vision(i).VisionOrderId = 1) Or (Loc_Vision(i).VisionOrderId = 2) Then
                    Loc_PuVis.Add(Loc_Tools(_id).VisionConfigurations(i).RobotPoint)
                End If
            Next
            If Loc_PuVis Is Nothing Then Return False
            If Loc_PuVis.Count < 1 Then Return False
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
#End Region


    Private Function read_punti() As Boolean
        Dim _byte(0), _2b(1) As Byte
        Dim i As Integer

        Try
            'ORDINE DEI PUNTI SU MAGAZZINI:
            '  - OLED SX
            '  - OLED DX
            '  - VASSOIO

            'IN PIU': => MAGAZZINO A == SX
            '         => MAGAZZINO B == DX

            If (L_P_MA.Count > 0) Then
                L_P_MA(0).X = CSng(StatiMacchina.MagazzinoSxOledSx.X) / 1000.0!
                L_P_MA(0).Y = CSng(StatiMacchina.MagazzinoSxOledSx.Y) / 1000.0!
                L_P_MA(0).Z = CSng(StatiMacchina.MagazzinoSxOledSx.Z) / 1000.0!
                L_P_MA(0).RotazioneZ = CSng(StatiMacchina.MagazzinoSxOledSx.RotazioneZ) / 1000.0!

                L_P_MA(1).X = CSng(StatiMacchina.MagazzinoSxOledDx.X) / 1000.0!
                L_P_MA(1).Y = CSng(StatiMacchina.MagazzinoSxOledDx.Y) / 1000.0!
                L_P_MA(1).Z = CSng(StatiMacchina.MagazzinoSxOledDx.Z) / 1000.0!
                L_P_MA(1).RotazioneZ = CSng(StatiMacchina.MagazzinoSxOledDx.RotazioneZ) / 1000.0!

                L_P_MA(2).X = CSng(StatiMacchina.MagazzinoSxVassoio.X) / 1000.0!
                L_P_MA(2).Y = CSng(StatiMacchina.MagazzinoSxVassoio.Y) / 1000.0!
                L_P_MA(2).Z = CSng(StatiMacchina.MagazzinoSxVassoio.Z) / 1000.0!
                L_P_MA(2).RotazioneZ = CSng(StatiMacchina.MagazzinoSxVassoio.RotazioneZ) / 1000.0!
            End If
            DG_PMA.Refresh()
            If (L_P_MB.Count > 0) Then
                L_P_MB(0).X = CSng(StatiMacchina.MagazzinoDxOledSx.X) / 1000.0!
                L_P_MB(0).Y = CSng(StatiMacchina.MagazzinoDxOledSx.Y) / 1000.0!
                L_P_MB(0).Z = CSng(StatiMacchina.MagazzinoDxOledSx.Z) / 1000.0!
                L_P_MB(0).RotazioneZ = CSng(StatiMacchina.MagazzinoDxOledSx.RotazioneZ) / 1000.0!

                L_P_MB(1).X = CSng(StatiMacchina.MagazzinoDxOledDx.X) / 1000.0!
                L_P_MB(1).Y = CSng(StatiMacchina.MagazzinoDxOledDx.Y) / 1000.0!
                L_P_MB(1).Z = CSng(StatiMacchina.MagazzinoDxOledDx.Z) / 1000.0!
                L_P_MB(1).RotazioneZ = CSng(StatiMacchina.MagazzinoDxOledDx.RotazioneZ) / 1000.0!

                L_P_MB(2).X = CSng(StatiMacchina.MagazzinoDxVassoio.X) / 1000.0!
                L_P_MB(2).Y = CSng(StatiMacchina.MagazzinoDxVassoio.Y) / 1000.0!
                L_P_MB(2).Z = CSng(StatiMacchina.MagazzinoDxVassoio.Z) / 1000.0!
                L_P_MB(2).RotazioneZ = CSng(StatiMacchina.MagazzinoDxVassoio.RotazioneZ) / 1000.0!
            End If
            DG_PMB.Refresh()
            '---------  PALLET A (Nastro SX) -----------
            ' ORDINE DI POPOLAMENTO:
            '   - Deposito OLED
            '   - Prelievo Adesivo
            '   - Prelievo Supporto
            '   - Sfoglio Liner (LINER A)
            Loc_Pall_A(0).X = CSng(StatiMacchina.PalletSuNastroSxPezzoFinito.X) / 1000.0!
            Loc_Pall_A(0).Y = CSng(StatiMacchina.PalletSuNastroSxPezzoFinito.Y) / 1000.0!
            Loc_Pall_A(0).Z = CSng(StatiMacchina.PalletSuNastroSxPezzoFinito.Z) / 1000.0!
            Loc_Pall_A(0).RotazioneZ = CSng(StatiMacchina.PalletSuNastroSxPezzoFinito.RotazioneZ) / 1000.0!

            Loc_Pall_A(1).X = CSng(StatiMacchina.PalletSuNastroSxBiadesivo.X) / 1000.0!
            Loc_Pall_A(1).Y = CSng(StatiMacchina.PalletSuNastroSxBiadesivo.Y) / 1000.0!
            Loc_Pall_A(1).Z = CSng(StatiMacchina.PalletSuNastroSxBiadesivo.Z) / 1000.0!
            Loc_Pall_A(1).RotazioneZ = CSng(StatiMacchina.PalletSuNastroSxBiadesivo.RotazioneZ) / 1000.0!

            Loc_Pall_A(2).X = CSng(StatiMacchina.PalletSuNastroSxSupporto.X) / 1000.0!
            Loc_Pall_A(2).Y = CSng(StatiMacchina.PalletSuNastroSxSupporto.Y) / 1000.0!
            Loc_Pall_A(2).Z = CSng(StatiMacchina.PalletSuNastroSxSupporto.Z) / 1000.0!
            Loc_Pall_A(2).RotazioneZ = CSng(StatiMacchina.PalletSuNastroSxSupporto.RotazioneZ) / 1000.0!

            'ATTENZIONE!!! HO UNA SOLA POSIZIONE PER IL LINER....LA BUTTO SU ENTRAMBI I MAGAZZINI E PREGO DIO
            Loc_Pall_A(3).X = CSng(StatiMacchina.StrappoLiner.X) / 1000.0!
            Loc_Pall_A(3).Y = CSng(StatiMacchina.StrappoLiner.Y) / 1000.0!
            Loc_Pall_A(3).Z = CSng(StatiMacchina.StrappoLiner.Z) / 1000.0!
            Loc_Pall_A(3).RotazioneZ = CSng(StatiMacchina.StrappoLiner.RotazioneZ) / 1000.0!

            DG_Pall4_A.Refresh()

            '---------  PALLET B (Nastro DX) -----------
            ' ORDINE DI POPOLAMENTO:
            '   - Deposito OLED
            '   - Prelievo Adesivo
            '   - Prelievo Supporto
            '   - Sfoglio Liner (LINER B)
            Loc_Pall_B(0).X = CSng(StatiMacchina.PalletSuNastroDxPezzoFinito.X) / 1000.0!
            Loc_Pall_B(0).Y = CSng(StatiMacchina.PalletSuNastroDxPezzoFinito.Y) / 1000.0!
            Loc_Pall_B(0).Z = CSng(StatiMacchina.PalletSuNastroDxPezzoFinito.Z) / 1000.0!
            Loc_Pall_B(0).RotazioneZ = CSng(StatiMacchina.PalletSuNastroDxPezzoFinito.RotazioneZ) / 1000.0!

            Loc_Pall_B(1).X = CSng(StatiMacchina.PalletSuNastroDxBiadesivo.X) / 1000.0!
            Loc_Pall_B(1).Y = CSng(StatiMacchina.PalletSuNastroDxBiadesivo.Y) / 1000.0!
            Loc_Pall_B(1).Z = CSng(StatiMacchina.PalletSuNastroDxBiadesivo.Z) / 1000.0!
            Loc_Pall_B(1).RotazioneZ = CSng(StatiMacchina.PalletSuNastroDxBiadesivo.RotazioneZ) / 1000.0!

            Loc_Pall_B(2).X = CSng(StatiMacchina.PalletSuNastroDxSupporto.X) / 1000.0!
            Loc_Pall_B(2).Y = CSng(StatiMacchina.PalletSuNastroDxSupporto.Y) / 1000.0!
            Loc_Pall_B(2).Z = CSng(StatiMacchina.PalletSuNastroDxSupporto.Z) / 1000.0!
            Loc_Pall_B(2).RotazioneZ = CSng(StatiMacchina.PalletSuNastroDxSupporto.RotazioneZ) / 1000.0!

            'ATTENZIONE!!! HO UNA SOLA POSIZIONE PER IL LINER....LA BUTTO SU ENTRAMBI I MAGAZZINI E PREGO DIO
            Loc_Pall_B(3).X = CSng(StatiMacchina.StrappoLiner.X) / 1000.0!
            Loc_Pall_B(3).Y = CSng(StatiMacchina.StrappoLiner.Y) / 1000.0!
            Loc_Pall_B(3).Z = CSng(StatiMacchina.StrappoLiner.Z) / 1000.0!
            Loc_Pall_B(3).RotazioneZ = CSng(StatiMacchina.StrappoLiner.RotazioneZ) / 1000.0!

            DG_Pall4_B.Refresh()


            Loc_Incollaggio(0).X = CSng(StatiMacchina.Incollaggio.X) / 1000.0!
            Loc_Incollaggio(0).Y = CSng(StatiMacchina.Incollaggio.Y) / 1000.0!
            Loc_Incollaggio(0).Z = CSng(StatiMacchina.Incollaggio.Z) / 1000.0!
            Loc_Incollaggio(0).RotazioneZ = CSng(StatiMacchina.Incollaggio.RotazioneZ) / 1000.0!
            DGIncollaggio.Refresh()

        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function


    Private Function read_Viti() As Boolean
        Dim _byte(0), _2b(1) As Byte
        Dim i As Integer
        Try
            'ANCHE QUI L'ORDINE E' IMPORTANTE MA CRISTODIO NON NE HO UNO PRECISO.
            ' VADO IN ORDINE CHE COMANDA IL PLC

            Loc_PuntiViteSX(0).X = CSng(StatiMacchina.Vite1PalletSx.R1) / 10.0!
            Loc_PuntiViteSX(0).Y = CSng(StatiMacchina.Vite1PalletSx.R2) / 10.0!
            Loc_PuntiViteSX(0).Z = CSng(StatiMacchina.Vite1PalletSx.H) / 10.0!

            Loc_PuntiViteSX(1).X = CSng(StatiMacchina.Vite2PalletSx.R1) / 10.0!
            Loc_PuntiViteSX(1).Y = CSng(StatiMacchina.Vite2PalletSx.R2) / 10.0!
            Loc_PuntiViteSX(1).Z = CSng(StatiMacchina.Vite2PalletSx.H) / 10.0!

            Loc_PuntiViteSX(2).X = CSng(StatiMacchina.Vite3PalletSx.R1) / 10.0!
            Loc_PuntiViteSX(2).Y = CSng(StatiMacchina.Vite3PalletSx.R2) / 10.0!
            Loc_PuntiViteSX(2).Z = CSng(StatiMacchina.Vite3PalletSx.H) / 10.0!

            DG_Viti_NastroSX.Refresh()

            Loc_PuntiViteDX(0).X = CSng(StatiMacchina.Vite1PalletDx.R1) / 10.0!
            Loc_PuntiViteDX(0).Y = CSng(StatiMacchina.Vite1PalletDx.R2) / 10.0!
            Loc_PuntiViteDX(0).Z = CSng(StatiMacchina.Vite1PalletDx.H) / 10.0!

            Loc_PuntiViteDX(1).X = CSng(StatiMacchina.Vite2PalletDx.R1) / 10.0!
            Loc_PuntiViteDX(1).Y = CSng(StatiMacchina.Vite2PalletDx.R2) / 10.0!
            Loc_PuntiViteDX(1).Z = CSng(StatiMacchina.Vite2PalletDx.H) / 10.0!

            Loc_PuntiViteDX(2).X = CSng(StatiMacchina.Vite3PalletDx.R1) / 10.0!
            Loc_PuntiViteDX(2).Y = CSng(StatiMacchina.Vite3PalletDx.R2) / 10.0!
            Loc_PuntiViteDX(2).Z = CSng(StatiMacchina.Vite3PalletDx.H) / 10.0!

            DG_Viti_NastroDX.Refresh()

        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function



End Class
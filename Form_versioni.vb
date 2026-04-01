Imports System.IO
Imports System.Data
Imports Oled.DataLayer
Imports Microsoft.Extensions.DependencyInjection
Imports System.Linq
Imports Microsoft.EntityFrameworkCore

Public Class Form_versioni

    Private ID_M, ID_V, Cod_Robot As Integer
    Private _clk As Boolean
    Private Loc_Modelli As New List(Of Model)
    Private Loc_Tools As New List(Of ProductionConfiguration)
    Private Sel_Modello As Model
    Private Sel_Tool As ProductionConfiguration

    Private _originalPCBEnable As Boolean
#Region "Form"
    Private Sub Form_banco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ID_M = 0 : ID_V = 0
        If Load_Modelli() Then
            Popola_Modelli()
            ID_M = Loc_Modelli(Comb_Mod.SelectedIndex).Id
            Cod_Robot = Loc_Modelli(Comb_Mod.SelectedIndex).RobotCode
            If Load_Versioni(ID_M) Then
                Popola_Versioni()
                Display_Sel_Mod()
                ID_V = Loc_Tools(Comb_Vers.SelectedIndex).Id
                Display_Tool()
            End If

            '_originalPCBEnable = Sel_Tool.LetturaDatamatrixPcbAbilitato
        End If
        Timer1.Enabled = True
    End Sub

    Private Sub Form_banco_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Stop() : Timer1.Enabled = False
    End Sub
    Private Sub Form_banco_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        L_Act_Mod.Text = Modello_Attuale.Name : Lab_Act_vers.Text = Prodotto_Act.Name
        Lab_Act_vers.Text = Sett.versione
    End Sub

#End Region
    Private Sub Butt_select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butt_select.Click
        If Init_opzio = True Then Exit Sub
        If Prep_Tx(Cod_Robot, Sel_Tool) Then
            _tx_dati = True
            Sett.Id_Modello = ID_M
            Sett.Id_Tool = ID_V
            Salva_Sett = True
            Init_opzio = True
        End If
        Me.Close()
    End Sub

    Private Sub Butt_Abort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butt_Abort.Click
        Me.Close()
    End Sub

    Private Function Load_Modelli() As Boolean
        Dim _Scope = Bootstrapper.Current.Services.CreateScope
        Dim Context = _Scope.ServiceProvider.GetRequiredService(Of ProcessDataContext)()
        Try
            Loc_Modelli = Context.Models.ToList
            If Loc_Modelli Is Nothing Then
                show_eccezione("!!! Tabella modelli non trovata. Controllare DB !!!")
                Return False
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        Finally
            _Scope.Dispose()
            Context.Dispose()
        End Try
        Return True
    End Function
    Private Sub Popola_Modelli()
        Dim i As Integer
        Try
            Comb_Mod.Items.Clear()
            For i = 0 To Loc_Modelli.Count - 1
                Comb_Mod.Items.Add(Loc_Modelli(i).Name)
            Next
            Comb_Mod.SelectedIndex = 0
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
    Private Function Load_Versioni(ByVal _M As Integer) As Boolean
        Dim _Scope = Bootstrapper.Current.Services.CreateScope
        Dim Context = _Scope.ServiceProvider.GetRequiredService(Of ProcessDataContext)()
        Try
            Loc_Tools = Context.Tools.Where(Function(x) x.ModelId = _M).ToList
            If Loc_Tools Is Nothing Then
                Return False
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        Finally
            _Scope.Dispose()
            Context.Dispose()
        End Try
        Return True
    End Function
    Private Sub Popola_Versioni()
        Dim i As Integer
        Try
            Comb_Vers.Items.Clear()
            For i = 0 To Loc_Tools.Count - 1
                Comb_Vers.Items.Add(Loc_Tools(i).Name)
            Next
            Comb_Vers.SelectedIndex = 0
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _clk = Not _clk
        L_id_m.Text = ID_M.ToString
        L_id_m.Visible = CBool(ID_M > 0)
        L_Id_v.Text = ID_V.ToString
        L_Id_v.Visible = CBool(ID_V > 0)
        Butt_select.Visible = CBool(ID_M > 0) And CBool(ID_V > 0) And (statiMacchina.ConsensoPLCACaricamentoRicetta Or Log_4)
        If statiMacchina.ConsensoPLCACaricamentoRicetta Then
            L_Consenso.Visible = False
        Else
            L_Consenso.Visible = _clk
        End If

        If Sel_Tool IsNot Nothing Then
            If _originalPCBEnable <> Sel_Tool.LetturaDatamatrixPcbAbilitato Then
                btnSave.Visible = True
            Else
                btnSave.Visible = False
            End If
        End If

    End Sub

    Private Sub Comb_Mod_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Comb_Mod.SelectionChangeCommitted
        ID_V = 0
        ID_M = Loc_Modelli(Comb_Mod.SelectedIndex).Id
        Cod_Robot = Loc_Modelli(Comb_Mod.SelectedIndex).RobotCode
        Display_Sel_Mod()
        If Load_Versioni(ID_M) Then
            Popola_Versioni()
        End If
    End Sub
    Private Sub Comb_Vers_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Comb_Vers.SelectionChangeCommitted
        ID_V = Loc_Tools(Comb_Vers.SelectedIndex).Id
        Display_Tool()


    End Sub

    Private Sub Comb_Vers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Comb_Vers.SelectedIndexChanged

    End Sub

    Private Sub Lm2_Click(sender As Object, e As EventArgs) Handles Lm2.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Sel_Tool.LetturaDatamatrixPcbAbilitato = Not Sel_Tool.LetturaDatamatrixPcbAbilitato
        If Sel_Tool.LetturaDatamatrixPcbAbilitato Then
            Label7.Text = "ABILITATA"
            Label7.BackColor = Color.Green
        Else
            Label7.Text = "DISABILITATA"
            Label7.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If Sel_Tool Is Nothing Then Return

            ' 1) Aggiorna la lista locale (Loc_Tools)
            Dim idx As Integer = Loc_Tools.FindIndex(Function(t) t.Id = Sel_Tool.Id)
            If idx >= 0 Then
                Loc_Tools(idx).LetturaDatamatrixPcbAbilitato = Sel_Tool.LetturaDatamatrixPcbAbilitato
            End If

            ' 2) Salva su DB (nuovo scope/context)
            Using scope = Bootstrapper.Current.Services.CreateScope()
                Using ctx = scope.ServiceProvider.GetRequiredService(Of ProcessDataContext)()

                    Dim tool = ctx.Tools.FirstOrDefault(Function(x) x.Id = Sel_Tool.Id)
                    If tool Is Nothing Then
                        show_eccezione("Tool non trovato nel DB.")
                        Return
                    End If

                    tool.LetturaDatamatrixPcbAbilitato = Sel_Tool.LetturaDatamatrixPcbAbilitato
                    ctx.SaveChanges()
                End Using
            End Using

            ' 3) Stato “originale” aggiornato (così sparisce il bottone Save)
            _originalPCBEnable = Sel_Tool.LetturaDatamatrixPcbAbilitato
            btnSave.Visible = False

        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub

    Private Sub Display_Sel_Mod()
        Dim _Scope = Bootstrapper.Current.Services.CreateScope
        Dim Context = _Scope.ServiceProvider.GetRequiredService(Of ProcessDataContext)()
        Try
            Sel_Modello = Context.Models.Where(Function(x) x.Id = ID_M).FirstOrDefault
            If Sel_Modello IsNot Nothing Then
                Lm1.Text = Sel_Modello.Name : Lm2.Text = Sel_Modello.Description
            Else
                Lm1.Text = "--------" : Lm2.Text = "--------"
            End If



        Catch ex As Exception
            show_eccezione(ex)
        Finally
            _Scope.Dispose()
            Context.Dispose()
        End Try
    End Sub
    Private Function Display_Tool() As Boolean
        Dim _Scope = Bootstrapper.Current.Services.CreateScope
        Dim Context = _Scope.ServiceProvider.GetRequiredService(Of ProcessDataContext)()
        Try
            Sel_Tool = Context.Tools.Where(Function(x) x.Id = ID_V).FirstOrDefault
            If Sel_Tool IsNot Nothing Then
                lv1.Text = Sel_Tool.Name : lv2.Text = Sel_Tool.Description

                Context.MagazinMaps.Load()
                Context.PalletConfigurations.Load
                Context.RobotPoints.Load
                Context.ScrewingStationConfigurations.Load
                Context.ScrewPoints.Load
                Context.VisionConfigurations.Load

                If Sel_Tool.LetturaDatamatrixPcbAbilitato Then
                    Label7.Text = "ABILITATA"
                    Label7.BackColor = Color.Green
                Else
                    Label7.Text = "DISABILITATA"
                    Label7.BackColor = Color.Red
                End If
                _originalPCBEnable = Sel_Tool.LetturaDatamatrixPcbAbilitato
            Else
                lv1.Text = "--------" : lv2.Text = "--------"
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        Finally
            _Scope.Dispose()
            Context.Dispose()
        End Try
        Return True
    End Function




End Class
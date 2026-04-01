Imports System.IO
Imports System.Text
Imports Oled.TraceDataLayer
Imports Microsoft.Extensions.DependencyInjection
Imports System.Linq

Public Class Form_storico

    Private T_Alarms As New List(Of Alarm)
    Private _BindingS As New BindingSource
    Private A_Context As TraceDataContext
    Private _ggg, _ST As Boolean
    Private New_Data As DateTime

#Region "Form"
    Private Sub Form_storico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        req_dati_ready = False : req_dati = False

        Me.Location = Loc_mdi
        N_MDI_from = 98

        If Carica_Dati(Now.AddDays(-1), Now, _ST) Then
            popola_griglia(_ST)
        End If
        Label1.Text = Now.ToShortDateString
    End Sub
    Private Sub Form_storico_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub
    Private Sub Form_storico_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
#End Region


#Region "DATA-BASE"

    Private Function Carica_Dati(ByVal _Date1 As Date, ByVal _Date2 As Date, ByVal _Stati As Boolean) As Boolean
        Try
            Dim Scopo = Bootstrapper.Current.Services.CreateScope
            A_Context = Scopo.ServiceProvider.GetRequiredService(Of TraceDataContext)()
            'T_Alarms = A_Context.Alarms.Where(Function(X) (_Date1.CompareTo(X.EventTime) <= 0 And _Date2.CompareTo(X.EventTime) > 0)).ToList
            T_Alarms = A_Context.AlarmHistory.Where(Function(X) (_Date2.Day.CompareTo(X.EventTime.Day) = 0) And (_Date2.Month.CompareTo(X.EventTime.Month) = 0) And (_Date2.Year.CompareTo(X.EventTime.Year) = 0)).OrderByDescending(Function(y) y.EventTime.TimeOfDay).ToList
            If T_Alarms Is Nothing Then
                Dim _RTV As DialogResult
                Dim _FP As New Form_PopUp_YN With {._Canc = False, ._Ok = True, ._Label = "!!! LISTA ALLARMI VUOTA !!!"}
                _RTV = _FP.ShowDialog
                Return False
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Sub popola_griglia(ByVal _Stati As Boolean)
        Try
            _BindingS.DataSource = T_Alarms
            DGrid1.DataSource = _BindingS
            DGrid1.Name = "Lista articoli"
            Format_dg_All()
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
    Private Sub Format_dg_All()
        Try
            With DGrid1
                .Columns(0).HeaderText = "ID"
                .Columns(0).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(0).Width = 50
                .Columns(0).ReadOnly = True
                .Columns(0).Visible = False

                .Columns(1).HeaderText = "Evento entrante"
                .Columns(1).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(1).Width = 150
                .Columns(1).ReadOnly = True
                .Columns(1).Visible = True

                .Columns(2).HeaderText = "Data/Ora"
                .Columns(2).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(2).Width = 120
                .Columns(2).ReadOnly = True
                .Columns(2).Visible = True


                .Columns(3).HeaderText = "Codice"
                .Columns(3).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(3).Width = 100
                .Columns(3).ReadOnly = True
                .Columns(3).Visible = True

                .Columns(4).HeaderText = "Descrizione"
                .Columns(4).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(4).Width = 900
                .Columns(4).ReadOnly = True
                .Columns(4).Visible = True

                .Refresh()
            End With
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        New_Data = DateTimePicker1.Value
        If Carica_Dati(New_Data.AddDays(-1), New_Data, _ST) Then
            popola_griglia(_ST)
        End If
        Label1.Text = New_Data.ToLongDateString
    End Sub


#End Region
End Class
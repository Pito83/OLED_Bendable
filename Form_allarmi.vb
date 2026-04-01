Imports System.IO
Imports System.Threading
Public Class Form_allarmi
    Private _bmp As String = Work_dir & "testi\BMP\"
    Private _num As Integer
    Private _ok, _primo_scan As Boolean
    Private _riga, _file_b As String
    Private all_nr As BitArray

#Region "Form"
    Private Sub Form_allarmi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = Loc_mdi
        N_MDI_from = 99
        req_dati_ready = False : req_dati = False
        If List_Allarmi Is Nothing Then
            _ok = False
        Else
            _ok = True
        End If
        Timer1.Enabled = True
        req_dati = True : _primo_scan = True
    End Sub
    Private Sub Form_allarmi_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub
    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnClosing(e)
    End Sub

    Private Sub Form_allarmi_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Enabled = False
    End Sub
    Private Sub Form_allarmi_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
#End Region

    Private Function vis_all() As Boolean
        Dim n As Integer
        Try 'per ogni item incrementa puntatore di 16 + 1 per la riga dei testi
            ListBox1.Items.Clear()
            all_nr = New BitArray(Allarmi)
            For n = 0 To all_nr.Count - 1       '---per 16 bits in una word 
                If all_nr(n) = True Then
                    ListBox1.Items.Add(List_Allarmi(n))
                End If
            Next n
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If req_dati_ready = True Then
            req_dati_ready = False
            _ok = vis_all()
            If _primo_scan = True Then
                _primo_scan = False
                If ListBox1.Items.Count > 0 Then
                    _riga = ListBox1.Items(0).ToString
                    _num = CInt(Val(_riga.Substring(0, 4)))
                    _file_b = _bmp & "F" & Format(_num, "000") & ".jpg"
                    Carica_imm(_file_b)
                End If
            End If
        Else
            If req_dati = False Then
                req_dati = True 'req nuova lettura
            End If
        End If
        If _ok = False Then Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        If ListBox1.SelectedIndex < 0 Then Exit Sub
        _riga = ListBox1.SelectedItem.ToString
        _num = CInt(Val(_riga.Substring(0, 4)))
        _file_b = _bmp & "F" & Format(_num, "000") & ".jpg"
        Carica_imm(_file_b)
    End Sub

    Private Sub Carica_imm(ByVal _f As String)
        Try
            If File.Exists(_f) Then
                PictureBox1.BackgroundImage = Image.FromFile(_f)
            Else
                Dim _RTV As DialogResult
                Dim _FP As New Form_PopUp_YN
                _FP._Canc = False
                _FP._Ok = True
                _FP._Label = "File immagini allarme non esiste"
                _RTV = _FP.ShowDialog
            End If
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
End Class
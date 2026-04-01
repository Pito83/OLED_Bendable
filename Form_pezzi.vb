Imports System.Threading
Imports System.Data
Public Class Form_pezzi
    Private Tb_Sx, Tb_Dx As DataTable
#Region "Form"

   
    Private Sub Form_pezzi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 100)    '3,80
        N_MDI_from = 8
        '    Me.SuspendLayout()
        req_dati_ready = False : req_dati = False

        popola_pezzi()


        If N_posaggi > 0 Then
            Group_sx.Visible = True : Group_dx.Visible = True
        Else
            Group_sx.Visible = True : Group_dx.Visible = False
        End If

        '      Me.ResumeLayout()
        Timer1.Enabled = True : req_dati = True
    End Sub
    Private Sub Form_pezzi_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'F_main.Lab_titolo.Text = "CONTEGGIO PEZZI"
        F_main.Lab_titolo.Text = testi(337)
    End Sub
    Private Sub Form_pezzi_Shown(sender As Object, e As EventArgs) Handles Me.Shown
     
    End Sub
    Private Sub Form_pezzi_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not (Tb_Sx Is Nothing) Then
            Tb_Sx.Dispose()
        End If
        If Not (Tb_Dx Is Nothing) Then
            Tb_Dx.Dispose()
        End If
        Timer1.Enabled = False
    End Sub
    Private Sub Form_pezzi_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
#End Region

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If req_dati_ready = True Then
            req_dati_ready = False
            Aggiorna_valori()
        Else
            If req_dati = False Then
                req_dati = True
            End If
        End If

        Try
            Tot_Count_dx.Value = 3
            Tot_Count_sx.Value = 3
        Catch ex As Exception
            Timer1.Stop()
            show_eccezione(ex)
            Thread.Sleep(3000)
        End Try
    End Sub
    Private Sub Aggiorna_valori()
        Dim _by(3) As Byte
        Try

        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
#Region "Comandi"
    Private Sub B_rst_b_sx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_rst_b_sx.Click
        _Ord_pz = 1 : L_b_sx.Text = "0"
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        _Ord_pz = 2 : L_b_dx.Text = "0"
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        _Ord_pz = 3 : L_s_sx.Text = "0"
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        _Ord_pz = 4 : L_s_dx.Text = "0"
    End Sub
#End Region
    Private Sub popola_pezzi()


    End Sub





End Class
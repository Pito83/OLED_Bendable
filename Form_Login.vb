'Imports System.Management
Imports System.IO
Imports System.Globalization


Public Class Form_Login
    Private _nn, _n_utente As Integer
    Private _scad As Date
    Private Nome_ut As String
    Private Scadenza_ut As Date
    Private Ok_Utente As Boolean


    Private Sub Butt_Abort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butt_Abort.Click
        Me.Close()
    End Sub
    Private Sub Form_Login_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Text_pass.Focus()
    End Sub
    Private Sub Form_Login_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        tasti_off()
        F_main.Timer3.Enabled = Log_1
        If Log_4 Then
            Vis_Log_Level(4)
            Exit Sub
        End If
        If Log_3 Then
            Vis_Log_Level(3)
            Exit Sub
        End If
        If Log_2 Then
            Vis_Log_Level(2)
            Exit Sub
        End If
        If Log_1 Then
            Vis_Log_Level(1)
            Exit Sub
        End If
        Vis_Log_Level(0)
    End Sub
    Private Sub Form_Login_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub Form_Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(100, 10)
        popola_login()
        '  F_main.Lab_titolo.Text = "LOG-IN UTENTE" : F_main.Lab_titolo.BackColor = Color.Lime
        tasti_on()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
      Test_Password
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Log_1 = False : Log_2 = False : Log_3 = False : Log_4 = False : Log_5 = False
        F_main.kill_mdi_forms()
        If Sett.TMServer Then
            If Not TMSRV Is Nothing Then
                TMSRV.EnableLogFile = False
            End If
        End If
        Me.Close()
    End Sub

    Private Sub Text_pass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Text_pass.KeyDown
        If e.KeyCode = Keys.Enter Then
            Test_Password()
        End If
    End Sub
    Private Sub popola_login()

    End Sub

    Private Sub Test_Password()
        Lab_msg.Text = ""
        Log_3 = False
        If Text_pass.Text = "352271111" Then
            Log_1 = True : Log_2 = True : Log_3 = True : Log_4 = True : Log_5 = True

            If Sett.TMServer Then
                If Not TMSRV Is Nothing Then
                    TMSRV.EnableLogFile = Log_5
                End If
            End If

            Me.Close()
            Exit Sub
        End If
        If Text_pass.Text = "352270208" Then
            Log_1 = True : Log_2 = True : Log_3 = True : Log_4 = True
            _utente = "ADMIN"
            File.AppendAllText(Microsoft.VisualBasic.FileIO.SpecialDirectories.CurrentUserApplicationData & "\Log-in.txt", _utente & "*" & Now.ToString & vbCrLf)
            Me.Close()
            Exit Sub
        End If
        If Text_pass.Text = "2222" Then
            Log_1 = True : Log_2 = True : Log_3 = False : Log_4 = False
            _utente = "TECNICHAL"
            File.AppendAllText(Microsoft.VisualBasic.FileIO.SpecialDirectories.CurrentUserApplicationData & "\Log-in.txt", _utente & "*" & Now.ToString & vbCrLf)
            Me.Close()
            Exit Sub
        End If
        If Text_pass.Text = _PW1 Then
            Log_1 = True : Log_2 = False : Log_3 = False : Log_4 = False
            _utente = "PASSWORD"
            ' File.AppendAllText(Application.StartupPath & "\Log-in.txt", _utente & "*" & Now.ToString & vbCrLf) 'Vecchia Path
            File.AppendAllText(Microsoft.VisualBasic.FileIO.SpecialDirectories.CurrentUserApplicationData & "\Log-in.txt", _utente & "*" & Now.ToString & vbCrLf)
            Me.Close()
            Exit Sub
        Else
            If Ok_Utente Then
                If _usb_scan.Test_Code(CInt(Val(Text_pass.Text)), Messaggio, Log_3) = True Then
                    If Log_3 = False Then
                        Log_1 = False : Log_2 = False
                        Lab_msg.Text = Messaggio
                    Else
                        Application.DoEvents()
                        _utente = Nome_ut
                        File.AppendAllText(Microsoft.VisualBasic.FileIO.SpecialDirectories.CurrentUserApplicationData & "\Log-in.txt", _utente & "*" & Now.ToString & vbCrLf)
                        Threading.Thread.Sleep(1500)
                        Me.Close()
                    End If
                Else
                    If _usb_scan.errore = True Then             'Eccezione in chiamata dll
                        show_eccezione(_usb_scan.eccezione & vbCrLf)
                    End If
                End If
            Else
                Dim _RTV As DialogResult
                Dim _FP As New Form_PopUp_YN
                _FP._Canc = False
                _FP._Ok = True
                _FP._Label = "< !!! Password errata !!! >"
                _RTV = _FP.ShowDialog
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Butt_usb_Click(sender As System.Object, e As System.EventArgs) Handles Butt_usb.Click
        Lab_Utente.Text = "" : Lab_data.Text = "" : Log_1 = False : Log_2 = False : Log_3 = False
        If _usb_scan.Scan_Usb(Nome_ut, Scadenza_ut, Messaggio, Log_3, Ok_Utente) = True Then     'Riconoscimento con successo
            Lab_Utente.Text = Nome_ut
            Lab_data.Text = Scadenza_ut.ToString
            Lab_msg.Text = Messaggio
        Else
            If _usb_scan.errore = True Then             'Eccezione in chiamata dll
                show_eccezione(_usb_scan.eccezione & vbCrLf)
            End If
        End If
        If Log_3 Then
            _utente = Nome_ut : Log_1 = True : Log_2 = True
            Application.DoEvents()
            File.AppendAllText(Microsoft.VisualBasic.FileIO.SpecialDirectories.CurrentUserApplicationData & "\Log-in.txt", _utente & "*" & Now.ToString & vbCrLf)
            Threading.Thread.Sleep(1500)
            Me.Close()
        End If
    End Sub

    Private Sub Text_pass_TextChanged(sender As Object, e As EventArgs) Handles Text_pass.TextChanged

    End Sub

    Private Sub Lab_data_Click(sender As Object, e As EventArgs) Handles Lab_data.Click

    End Sub
End Class
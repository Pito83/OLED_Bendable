Imports LBSoft.IndustrialCtrls.Leds
Imports System.IO
Imports System.Linq

Public Class Form_sinottico

    Private File_imm1, File_imm2 As String


    Private L_Viti_SX() As Label
    Private L_Viti_DX() As Label

    Private dim_butt As New System.Drawing.Size(30, 30)

    'Private led_font As New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    'Private lin_font As New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '--
    Private n_butt As Integer
    Private _clkk As Boolean
    Private sin_clk, Cic_Run As Boolean
    'Private Mem_stat_1, Mem_Stat_2 As UShort
    Private _side As PalletSide

    Public Event ScanCompleted(ByVal scannedText As String)

    Private _isReadingMem As Boolean

    Private _quadratoVerde As Integer = 0
    Private _quadratoBlu As Integer = 3
    Private _quadratoGrigio As Integer = 1

    Public Sub SetSide(ByVal side As PalletSide, Optional internal As Boolean = False)
        lblSide.Text = If(side = PalletSide.Destro, "LEGGI PALLET DESTRO", "LEGGI PALLET SINISTRO")
        _side = side
        If side = PalletSide.Sinistro Then
            Pan_ST2_SX.Controls.Add(lblSide)
            Pan_ST2_SX.Controls.Add(txtScan)
            Pan_ST2_SX.Controls.Add(btnConfirm)
            lblSide.Location = New Point(185, 210)
            txtScan.Location = New Point(112, 324)
            btnConfirm.Location = New Point(254, 392)
        Else
            Pan_ST2_DX.Controls.Add(lblSide)
            Pan_ST2_DX.Controls.Add(txtScan)
            Pan_ST2_DX.Controls.Add(btnConfirm)
            lblSide.Location = New Point(185, 210)
            txtScan.Location = New Point(112, 324)
            btnConfirm.Location = New Point(254, 392)
        End If
        lblSide.Visible = True
        txtScan.Visible = True
        If (Not internal) Then
            txtScan.Text = ""
            txtScan.Focus()
        End If
    End Sub

#Region "fORMS"
    Private Sub Form_sinottico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Location = Loc_mdi
        N_MDI_from = 123456
        PaginaAperta = "SINOTTICO"

        req_dati = False : req_dati_ready = False
        Me.SuspendLayout()

        Carica_dati()
        Timer1.Enabled = True
        Me.ResumeLayout(True)
        req_dati = True
    End Sub
    Private Sub Form_sinottico_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Timer1.Enabled = True : Timer2.Enabled = True
        txtScan.Focus()
    End Sub

    Private Sub txtScan_KeyDown(sender As Object, e As KeyEventArgs) Handles txtScan.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            e.SuppressKeyPress = True

            Dim s = txtScan.Text
            txtScan.Text = ""
            lblSide.Visible = False
            txtScan.Visible = False
            btnConfirm.Visible = False
            If (_side = PalletSide.Sinistro) Then
                Pan_ST2_SX.Controls.Remove(lblSide)
                Pan_ST2_SX.Controls.Remove(txtScan)
            Else
                Pan_ST2_DX.Controls.Remove(lblSide)
                Pan_ST2_DX.Controls.Remove(txtScan)
            End If
            RaiseEvent ScanCompleted(s)
        End If
    End Sub
    Private Sub Form_sinottico_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Enabled = False : Timer1.Stop()
        Timer2.Enabled = False : Timer2.Stop()
    End Sub
    Private Sub Form_sinottico_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Function Load_Images() As Boolean
        Try
            File_imm1 = Main_dir & "Modello\" & Sett.Id_Modello.ToString & "\" & Sett.Id_Tool.ToString & "\1.jpg"
            File_imm2 = Main_dir & "Modello\" & Sett.Id_Modello.ToString & "\" & Sett.Id_Tool.ToString & "\2.jpg"
            If File.Exists(File_imm1) Then
                Pan_ST2_DX.BackgroundImage = Image.FromFile(File_imm1)
            Else
                show_eccezione("Immagine stazione 1 non esiste: " & File_imm1)
            End If
            If File.Exists(File_imm2) Then
                Pan_ST2_SX.BackgroundImage = Image.FromFile(File_imm2)
            Else
                show_eccezione("Immagine stazione 1 non esiste: " & File_imm2)
            End If

        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function

#End Region

    Private Function Carica_dati() As Boolean
        Dim _og As Control
        Dim i, n As Integer
        Load_Images()
        crea_VitiSX()
        crea_VitiDX()
        Dim val As Integer
        Try
            If Prodotto_Act.LetturaDatamatrixPcbAbilitato Then
                Label4.Text = "LETTURA PCB ABILITATA"
            Else
                Label4.Text = "LETTURA PCB DISABILITATA"
            End If

            '  While Pan_ST2.Controls
            n = Pan_ST2_SX.Controls.Count
            If n > 0 Then
                For i = n - 1 To 0 Step -1
                    _og = Pan_ST2_SX.Controls(i)
                    If _og IsNot Nothing And _og.Tag IsNot Nothing Then
                        If Integer.TryParse(_og.Tag.ToString(), val) And val > 90 Then
                            Pan_ST2_SX.Controls.Remove(_og)
                        End If
                    End If

                Next
            End If
            Init_VitiSX()

            '  While Pan_ST2.Controls
            n = Pan_ST2_DX.Controls.Count
            If n > 0 Then
                For i = n - 1 To 0 Step -1
                    _og = Pan_ST2_DX.Controls(i)
                    If _og IsNot Nothing And _og.Tag IsNot Nothing Then
                        If _og.Tag IsNot Nothing And Integer.TryParse(_og.Tag.ToString(), val) And val > 90 Then
                            Pan_ST2_DX.Controls.Remove(_og)
                        End If
                    End If
                Next
            End If
            Init_VitiDX()
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function

    Private Sub Init_VitiSX()
        Dim i, px, py As Integer
        Try
            For i = 0 To N_Viti_Sx - 1
                With Me.L_Viti_SX(i)

                    .BackColor = System.Drawing.Color.Silver
                    .BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                    .Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    .ImageIndex = 7
                    .ImageList = Me.ImageList1


                    px = CInt(Prodotto_Act.ScrewingStationConfiguration.PalletNastroSxScrewPoints(i).pX)
                    py = CInt(Prodotto_Act.ScrewingStationConfiguration.PalletNastroSxScrewPoints(i).pY)
                    .Location = New System.Drawing.Point(px, py)

                    ' Select Case i
                    '     Case 
                    '         .Location = New System.Drawing.Point(700, 594)
                    '     Case 1
                    '         .Location = New System.Drawing.Point(200, 594)
                    ' End Select
                    .Name = "Vite" & (i + 1).ToString
                    .Size = New System.Drawing.Size(30, 30)
                    .TabIndex = 273
                    .Tag = i + 100
                    .TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                    .Visible = True

                    Me.Pan_ST2_SX.Controls.Add(Me.L_Viti_SX(i))
                    ' AddHandler B_compon(i).MouseClick, AddressOf B_compon_Mouse_down
                End With
            Next i
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
    Private Sub Init_VitiDX()
        Dim i, px, py As Integer
        Try
            For i = 0 To N_Viti_Dx - 1
                With Me.L_Viti_DX(i)

                    .BackColor = System.Drawing.Color.Silver
                    .BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                    .Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    .ImageIndex = 7
                    .ImageList = Me.ImageList1


                    px = CInt(Prodotto_Act.ScrewingStationConfiguration.PalletNastroDxScrewPoints(i).pX)
                    py = CInt(Prodotto_Act.ScrewingStationConfiguration.PalletNastroDxScrewPoints(i).pY)
                    .Location = New System.Drawing.Point(px, py)

                    ' Select Case i
                    '     Case 
                    '         .Location = New System.Drawing.Point(700, 594)
                    '     Case 1
                    '         .Location = New System.Drawing.Point(200, 594)
                    ' End Select
                    .Name = "Vite" & (i + 1).ToString
                    .Size = New System.Drawing.Size(30, 30)
                    .TabIndex = 273
                    .Tag = i + 100
                    .TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                    .Visible = True

                    Me.Pan_ST2_DX.Controls.Add(Me.L_Viti_DX(i))
                    ' AddHandler B_compon(i).MouseClick, AddressOf B_compon_Mouse_down
                End With
            Next i
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
    Private Sub crea_VitiSX()
        Dim i As Integer
        Try
            ReDim L_Viti_SX(N_Viti_Sx)
            For i = 0 To N_Viti_Sx - 1
                Me.L_Viti_SX(i) = New Label
            Next i
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
    Private Sub crea_VitiDX()
        Dim i As Integer
        Try
            ReDim L_Viti_DX(N_Viti_Dx)
            For i = 0 To N_Viti_Dx - 1
                Me.L_Viti_DX(i) = New Label
            Next i
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        sin_clk = Not sin_clk
        'TODO COMPLETARE
        Dim avvitareASX As Boolean = StatiMacchina.Pos1ViteDaAvvitareAdesso _
        Or StatiMacchina.Pos2ViteDaAvvitareAdesso _
        Or StatiMacchina.Pos3ViteDaAvvitareAdesso

        If avvitareASX Then
            If sin_clk Then
                Lab_Avvita_SX.BackColor = Color.Yellow
            Else
                Lab_Avvita_SX.BackColor = Color.Gainsboro
            End If
        Else
            Lab_Avvita_SX.BackColor = Color.Gainsboro
        End If

        Dim avvitareADX As Boolean = StatiMacchina.Pos4ViteDaAvvitareAdesso _
        Or StatiMacchina.Pos5ViteDaAvvitareAdesso _
        Or StatiMacchina.Pos6ViteDaAvvitareAdesso

        If avvitareADX Then
            If sin_clk Then
                Lab_Avvita_DX.BackColor = Color.Yellow
            Else
                Lab_Avvita_DX.BackColor = Color.Gainsboro
            End If
        Else
            Lab_Avvita_DX.BackColor = Color.Gainsboro
        End If

        If _Agg_Lay_Viti Then
            _Agg_Lay_Viti = False
            Carica_dati()
        Else
            If Not Vis_VitiSX() And Not Vis_VitiDX() Then
                Timer1.Stop()
                Threading.Thread.Sleep(4000)
                Timer1.Start()
            End If
        End If

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Not Vis_Attuali() Then
            Timer2.Stop()
            Threading.Thread.Sleep(4000)
            Timer2.Start()
        End If

        If DatamatrixMgr.IsReading And Not _isReadingMem Then
            SetSide(_side, True)
            If (txtScan.Text <> String.Empty) Then
                btnConfirm.Visible = True
            End If
        End If

        _isReadingMem = DatamatrixMgr.IsReading

        'If StatiMacchina.PresenzaPezzoDaAvvitareSx Then
        '    If StatiMacchina.Pos1ViteAvvitata Then
        '        btnVite1.Visible = True
        '    Else
        '        btnVite1.Visible = False
        '    End If
        'Else
        '        btnVite1.Visible = False
        'End If



    End Sub

    Private Function Vis_VitiSX() As Boolean
        'TODO COMPLETARE
        Dim _toll As Boolean = False 'stati(65) 'TODO COMPLETARE
        Try
            '''*****************************************
            ''' 0 - Lontano 
            ''' 1 - Vicino
            ''' 2 - In posizione
            ''' -1 - Errore
            ''' ****************************************


            If StatiMacchina.Pos1ViteDaAvvitareAdesso Then
                If StatiMacchina.Pos1VicinanzaOverall = 0 Then
                    If sin_clk Then
                        L_Viti_SX(0).BackColor = Color.Yellow
                    Else
                        L_Viti_SX(0).BackColor = Color.Silver
                    End If
                ElseIf StatiMacchina.Pos1VicinanzaOverall = 1 Then
                    L_Viti_SX(0).BackColor = Color.Yellow
                ElseIf StatiMacchina.Pos1VicinanzaOverall = 2 Then
                    If sin_clk Then
                        L_Viti_SX(0).BackColor = Color.Lime
                    Else
                        L_Viti_SX(0).BackColor = Color.Silver
                    End If
                Else
                    If sin_clk Then
                        L_Viti_SX(0).BackColor = Color.Red
                    Else
                        L_Viti_SX(0).BackColor = Color.Silver
                    End If
                End If
            Else
                If StatiMacchina.Pos1ViteAvvitata Then
                    If (StatiMacchina.Pos1ViteOk) Then
                        L_Viti_SX(0).BackColor = Color.Lime
                    Else
                        L_Viti_SX(0).BackColor = Color.Brown
                    End If
                Else
                    L_Viti_SX(0).BackColor = Color.Red
                End If
            End If


            If StatiMacchina.Pos2ViteDaAvvitareAdesso Then
                If StatiMacchina.Pos2VicinanzaOverall = 0 Then
                    If sin_clk Then
                        L_Viti_SX(1).BackColor = Color.Yellow
                    Else
                        L_Viti_SX(1).BackColor = Color.Silver
                    End If
                ElseIf StatiMacchina.Pos2VicinanzaOverall = 1 Then
                    L_Viti_SX(1).BackColor = Color.Yellow
                ElseIf StatiMacchina.Pos2VicinanzaOverall = 2 Then
                    If sin_clk Then
                        L_Viti_SX(1).BackColor = Color.Lime
                    Else
                        L_Viti_SX(1).BackColor = Color.Silver
                    End If
                Else
                    If sin_clk Then
                        L_Viti_SX(1).BackColor = Color.Red
                    Else
                        L_Viti_SX(1).BackColor = Color.Silver
                    End If
                End If
            Else
                If StatiMacchina.Pos2ViteAvvitata Then
                    If (StatiMacchina.Pos2ViteOk) Then
                        L_Viti_SX(1).BackColor = Color.Lime
                    Else
                        L_Viti_SX(1).BackColor = Color.Brown
                    End If
                Else
                    L_Viti_SX(1).BackColor = Color.Red
                End If
            End If

            If StatiMacchina.Pos3ViteDaAvvitareAdesso Then
                If StatiMacchina.Pos3VicinanzaOverall = 0 Then
                    If sin_clk Then
                        L_Viti_SX(2).BackColor = Color.Yellow
                    Else
                        L_Viti_SX(2).BackColor = Color.Silver
                    End If
                ElseIf StatiMacchina.Pos3VicinanzaOverall = 1 Then
                    L_Viti_SX(2).BackColor = Color.Yellow
                ElseIf StatiMacchina.Pos3VicinanzaOverall = 2 Then
                    If sin_clk Then
                        L_Viti_SX(2).BackColor = Color.Lime
                    Else
                        L_Viti_SX(2).BackColor = Color.Silver
                    End If
                Else
                    If sin_clk Then
                        L_Viti_SX(2).BackColor = Color.Red
                    Else
                        L_Viti_SX(2).BackColor = Color.Silver
                    End If
                End If
            Else
                If StatiMacchina.Pos3ViteAvvitata Then
                    If (StatiMacchina.Pos3ViteOk) Then
                        L_Viti_SX(2).BackColor = Color.Lime
                    Else
                        L_Viti_SX(2).BackColor = Color.Brown
                    End If
                Else
                    L_Viti_SX(2).BackColor = Color.Red
                End If
            End If

            lblPresenzaPalletSx.ImageIndex = CInt(StatiMacchina.NastroSxPalletAssePosizioneOperatore) + 1


            Pr_St2_SX.ImageIndex = CInt(StatiMacchina.PresenzaPezzoDaAvvitareSx) + 1
            Pr_St2_SX.Visible = StatiMacchina.PresenzaPezzoDaAvvitareSx

            MakeItClockOrNot(lblPresSupportoSx, StatiMacchina.NastroSxPalletPompaVuotoSupportoVuotoFatto, StatiMacchina.PresenzaSupportoPosaggioSx)
            MakeItClockOrNot(lblPresBiadesivoSx, StatiMacchina.NastroSxPalletPompaVuotoBiadesivoVuotoFatto, StatiMacchina.PresenzaBiadesivoPosaggioSx)
            MakeItClockOrNot(lblPresCorniceSx, StatiMacchina.NastroSxPalletPompaVuotoFrameVuotoFatto, StatiMacchina.PresenzaCornicePosaggioSx)
            lblPresBracketSx.ImageIndex = CInt(StatiMacchina.PresenzaBracketPosaggioSx) + 1
            MakeItClockOrNot(lblPresProdottoFinitoSx, StatiMacchina.NastroSxPalletPompaVuotoOledSupportoVuotoFatto, StatiMacchina.PresenzaPezzoFinitoPosaggioSx)


            'Maschero le label di presenza se il pallet non è esterno
            If (StatiMacchina.NastroSxPalletAssePosizioneOperatore) Then
                lblPresSupportoSx.Visible = True
                lblPresBiadesivoSx.Visible = True
                lblPresCorniceSx.Visible = True
                lblPresProdottoFinitoSx.Visible = True
                lblPresBracketSx.Visible = True
            Else
                lblPresSupportoSx.Visible = False
                lblPresBiadesivoSx.Visible = False
                lblPresCorniceSx.Visible = False
                lblPresProdottoFinitoSx.Visible = False
                lblPresBracketSx.Visible = False
            End If

        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    ''' <summary>
    ''' 'Image indexes => quadrato verde 0 / quadrato blu 3 / grigio 1
    '''        'Logica => se ho presenza => blu lampeggiante, se ho vuoto (dominante) => verde
    ''' </summary>
    ''' <param name="myLabel">My label.</param>
    ''' <param name="dominantBool">if set to <c>true</c> [dominant bool].</param>
    ''' <param name="slaveBool">if set to <c>true</c> [slave bool].</param>
    ''' <returns></returns>
    Private Sub MakeItClockOrNot(myLabel As Label, dominantBool As Boolean, slaveBool As Boolean)
        If dominantBool Then
            myLabel.ImageIndex = _quadratoVerde
        Else
            If slaveBool Then
                If sin_clk Then
                    myLabel.ImageIndex = _quadratoBlu
                Else
                    myLabel.ImageIndex = _quadratoGrigio
                End If
            Else
                myLabel.ImageIndex = _quadratoGrigio
            End If
        End If
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim s = txtScan.Text
        txtScan.Text = ""
        lblSide.Visible = False
        txtScan.Visible = False
        btnConfirm.Visible = False
        If (_side = PalletSide.Sinistro) Then
            Pan_ST2_SX.Controls.Remove(lblSide)
            Pan_ST2_SX.Controls.Remove(txtScan)
            HoLettoDM_SX = True
            ScannedDM_Text = s
        Else
            Pan_ST2_DX.Controls.Remove(lblSide)
            Pan_ST2_DX.Controls.Remove(txtScan)
            HoLettoDM_DX = True
            ScannedDM_Text = s
        End If
        RaiseEvent ScanCompleted(s)
    End Sub

    Private Sub txtScan_TextChanged(sender As Object, e As EventArgs) Handles txtScan.TextChanged
        btnConfirm.Visible = True
    End Sub

    Private Sub Lab_Vite_SX_Click(sender As Object, e As EventArgs) Handles Lab_Vite_SX.Click

    End Sub

    Private Sub Pan_ST2_SX_Paint(sender As Object, e As PaintEventArgs) Handles Pan_ST2_SX.Paint

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Function Vis_VitiDX() As Boolean

        Try
            '''*****************************************
            ''' 0 - Lontano 
            ''' 1 - Vicino
            ''' 2 - In posizione
            ''' -1 - Errore
            ''' ****************************************

            If StatiMacchina.Pos4ViteDaAvvitareAdesso Then
                If StatiMacchina.Pos4VicinanzaOverall = 0 Then
                    If sin_clk Then
                        L_Viti_DX(0).BackColor = Color.Yellow
                    Else
                        L_Viti_DX(0).BackColor = Color.Silver
                    End If
                ElseIf StatiMacchina.Pos4VicinanzaOverall = 1 Then
                    L_Viti_DX(0).BackColor = Color.Yellow
                ElseIf StatiMacchina.Pos4VicinanzaOverall = 2 Then
                    If sin_clk Then
                        L_Viti_DX(0).BackColor = Color.Lime
                    Else
                        L_Viti_DX(0).BackColor = Color.Silver
                    End If
                Else
                    If sin_clk Then
                        L_Viti_DX(0).BackColor = Color.Red
                    Else
                        L_Viti_DX(0).BackColor = Color.Silver
                    End If
                End If
            Else
                If StatiMacchina.Pos4ViteAvvitata Then
                    If (StatiMacchina.Pos4ViteOk) Then
                        L_Viti_DX(0).BackColor = Color.Lime
                    Else
                        L_Viti_DX(0).BackColor = Color.Brown
                    End If
                Else
                    L_Viti_DX(0).BackColor = Color.Red
                End If
            End If


            If StatiMacchina.Pos5ViteDaAvvitareAdesso Then
                If StatiMacchina.Pos5VicinanzaOverall = 0 Then
                    If sin_clk Then
                        L_Viti_DX(1).BackColor = Color.Yellow
                    Else
                        L_Viti_DX(1).BackColor = Color.Silver
                    End If
                ElseIf StatiMacchina.Pos5VicinanzaOverall = 1 Then
                    L_Viti_DX(1).BackColor = Color.Yellow
                ElseIf StatiMacchina.Pos5VicinanzaOverall = 2 Then
                    If sin_clk Then
                        L_Viti_DX(1).BackColor = Color.Lime
                    Else
                        L_Viti_DX(1).BackColor = Color.Silver
                    End If
                Else
                    If sin_clk Then
                        L_Viti_DX(1).BackColor = Color.Red
                    Else
                        L_Viti_DX(1).BackColor = Color.Silver
                    End If
                End If
            Else
                If StatiMacchina.Pos5ViteAvvitata Then
                    If (StatiMacchina.Pos5ViteOk) Then
                        L_Viti_DX(1).BackColor = Color.Lime
                    Else
                        L_Viti_DX(1).BackColor = Color.Brown
                    End If
                Else
                    L_Viti_DX(1).BackColor = Color.Red
                End If
            End If

            If StatiMacchina.Pos6ViteDaAvvitareAdesso Then
                If StatiMacchina.Pos6VicinanzaOverall = 0 Then
                    If sin_clk Then
                        L_Viti_DX(2).BackColor = Color.Yellow
                    Else
                        L_Viti_DX(2).BackColor = Color.Silver
                    End If
                ElseIf StatiMacchina.Pos6VicinanzaOverall = 1 Then
                    L_Viti_DX(2).BackColor = Color.Yellow
                ElseIf StatiMacchina.Pos6VicinanzaOverall = 2 Then
                    If sin_clk Then
                        L_Viti_DX(2).BackColor = Color.Lime
                    Else
                        L_Viti_DX(2).BackColor = Color.Silver
                    End If
                Else
                    If sin_clk Then
                        L_Viti_DX(2).BackColor = Color.Red
                    Else
                        L_Viti_DX(2).BackColor = Color.Silver
                    End If
                End If
            Else
                If StatiMacchina.Pos6ViteAvvitata Then
                    If (StatiMacchina.Pos6ViteOk) Then
                        L_Viti_DX(2).BackColor = Color.Lime
                    Else
                        L_Viti_DX(2).BackColor = Color.Brown
                    End If
                Else
                    L_Viti_DX(2).BackColor = Color.Red
                End If
            End If

            lblPresenzaPalletDx.ImageIndex = CInt(StatiMacchina.NastroDxPalletAssePosizioneOperatore) + 1

            Pr_St2_DX.ImageIndex = CInt(StatiMacchina.PresenzaPezzoDaAvvitareDx) + 1
            Pr_St2_DX.Visible = StatiMacchina.PresenzaPezzoDaAvvitareDx

            MakeItClockOrNot(lblPresSupportoDx, StatiMacchina.NastroDxPalletPompaVuotoSupportoVuotoFatto, StatiMacchina.PresenzaSupportoPosaggioDx)
            MakeItClockOrNot(lblPresBiadesivoDx, StatiMacchina.NastroDxPalletPompaVuotoBiadesivoVuotoFatto, StatiMacchina.PresenzaBiadesivoPosaggioDx)
            MakeItClockOrNot(lblPresCorniceDx, StatiMacchina.NastroDxPalletPompaVuotoFrameVuotoFatto, StatiMacchina.PresenzaCornicePosaggioDx)
            lblPresBracketDx.ImageIndex = CInt(StatiMacchina.PresenzaBracketPosaggioDx) + 1
            MakeItClockOrNot(lblPresProdottoFinitoDx, StatiMacchina.NastroDxPalletPompaVuotoOledSupportoVuotoFatto, StatiMacchina.PresenzaPezzoFinitoPosaggioDx)

            'Maschero le label di presenza se il pallet non è esterno
            If (StatiMacchina.NastroDxPalletAssePosizioneOperatore) Then
                lblPresSupportoDx.Visible = True
                lblPresBiadesivoDx.Visible = True
                lblPresCorniceDx.Visible = True
                lblPresProdottoFinitoDx.Visible = True
                lblPresBracketDx.Visible = True
            Else
                lblPresSupportoDx.Visible = False
                lblPresBiadesivoDx.Visible = False
                lblPresCorniceDx.Visible = False
                lblPresProdottoFinitoDx.Visible = False
                lblPresBracketDx.Visible = False
            End If

        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Function Vis_Attuali() As Boolean
        Try

            Lab_AttualiA.Text = StatiMacchina.PosizioneCorrenteAvvitatore.R1.ToString()
            Lab_AttualiB.Text = StatiMacchina.PosizioneCorrenteAvvitatore.R2.ToString()
            Lab_AttualiC.Text = StatiMacchina.PosizioneCorrenteAvvitatore.H.ToString()

            If StatiMacchina.Pos1ViteDaAvvitareAdesso Then
                Lab_TargetA.Text = StatiMacchina.Vite1PalletSx.R1.ToString()
                Lab_TargetB.Text = StatiMacchina.Vite1PalletSx.R2.ToString()
                Lab_TargetC.Text = StatiMacchina.Vite1PalletSx.H.ToString()
            ElseIf StatiMacchina.Pos2ViteDaAvvitareAdesso Then
                Lab_TargetA.Text = StatiMacchina.Vite2PalletSx.R1.ToString()
                Lab_TargetB.Text = StatiMacchina.Vite2PalletSx.R2.ToString()
                Lab_TargetC.Text = StatiMacchina.Vite2PalletSx.H.ToString()
            ElseIf StatiMacchina.Pos3ViteDaAvvitareAdesso Then
                Lab_TargetA.Text = StatiMacchina.Vite3PalletSx.R1.ToString()
                Lab_TargetB.Text = StatiMacchina.Vite3PalletSx.R2.ToString()
                Lab_TargetC.Text = StatiMacchina.Vite3PalletSx.H.ToString()
            ElseIf StatiMacchina.Pos4ViteDaAvvitareAdesso Then
                Lab_TargetA.Text = StatiMacchina.Vite1PalletDx.R1.ToString()
                Lab_TargetB.Text = StatiMacchina.Vite1PalletDx.R2.ToString()
                Lab_TargetC.Text = StatiMacchina.Vite1PalletDx.H.ToString()
            ElseIf StatiMacchina.Pos5ViteDaAvvitareAdesso Then
                Lab_TargetA.Text = StatiMacchina.Vite2PalletDx.R1.ToString()
                Lab_TargetB.Text = StatiMacchina.Vite2PalletDx.R2.ToString()
                Lab_TargetC.Text = StatiMacchina.Vite2PalletDx.H.ToString()
            ElseIf StatiMacchina.Pos6ViteDaAvvitareAdesso Then
                Lab_TargetA.Text = StatiMacchina.Vite3PalletDx.R1.ToString()
                Lab_TargetB.Text = StatiMacchina.Vite3PalletDx.R2.ToString()
                Lab_TargetC.Text = StatiMacchina.Vite3PalletDx.H.ToString()
            Else
                Lab_TargetA.Text = "NO TARGET"
                Lab_TargetB.Text = "NO TARGET"
                Lab_TargetC.Text = "NO TARGET"
            End If

        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
End Class
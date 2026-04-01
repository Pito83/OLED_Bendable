<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Robot
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Robot))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lab_Act_aLL = New System.Windows.Forms.Label()
        Me.Lab_Allarmi = New System.Windows.Forms.Label()
        Me.Lab_Missione = New System.Windows.Forms.Label()
        Me.Lab_Act_M = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Lab_All = New System.Windows.Forms.Label()
        Me.Lab_Miss = New System.Windows.Forms.Label()
        Me.Gr_Vuoti = New System.Windows.Forms.GroupBox()
        Me.B_PL_ch = New System.Windows.Forms.Button()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.B_PL_ap = New System.Windows.Forms.Button()
        Me.Lab_pl = New System.Windows.Forms.Label()
        Me.B_I2on = New System.Windows.Forms.Button()
        Me.B_I2off = New System.Windows.Forms.Button()
        Me.B_I1on = New System.Windows.Forms.Button()
        Me.B_I1off = New System.Windows.Forms.Button()
        Me.Lab_Ill2 = New System.Windows.Forms.Label()
        Me.Lab_Ill1 = New System.Windows.Forms.Label()
        Me.Lab_Pinza = New System.Windows.Forms.Label()
        Me.B_S1_On = New System.Windows.Forms.Button()
        Me.B_S1_Off = New System.Windows.Forms.Button()
        Me.Lab_Vuoto1 = New System.Windows.Forms.Label()
        Me.B_v1_On = New System.Windows.Forms.Button()
        Me.B_v1_Off = New System.Windows.Forms.Button()
        Me.Gr_Repos = New System.Windows.Forms.GroupBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Lab_MagA = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.T_Overr = New Txt_box.T_box()
        Me.Gr_Punti = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.T_aa = New Txt_box.T_box()
        Me.T_za = New Txt_box.T_box()
        Me.T_ya = New Txt_box.T_box()
        Me.T_xa = New Txt_box.T_box()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.T_ao = New Txt_box.T_box()
        Me.T_zo = New Txt_box.T_box()
        Me.T_yo = New Txt_box.T_box()
        Me.T_xo = New Txt_box.T_box()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.T_as = New Txt_box.T_box()
        Me.T_zs = New Txt_box.T_box()
        Me.T_ys = New Txt_box.T_box()
        Me.T_xs = New Txt_box.T_box()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Lt_a = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Lt_y = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Lt_x = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GR_PA = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.PP_aa = New Txt_box.T_box()
        Me.PP_az = New Txt_box.T_box()
        Me.PP_ay = New Txt_box.T_box()
        Me.PP_ax = New Txt_box.T_box()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.PD_aa = New Txt_box.T_box()
        Me.PD_az = New Txt_box.T_box()
        Me.PD_ay = New Txt_box.T_box()
        Me.PD_ax = New Txt_box.T_box()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.GR_PB = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.PP_ba = New Txt_box.T_box()
        Me.PP_bz = New Txt_box.T_box()
        Me.PP_by = New Txt_box.T_box()
        Me.PP_bx = New Txt_box.T_box()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.PD_ba = New Txt_box.T_box()
        Me.PD_bz = New Txt_box.T_box()
        Me.PD_by = New Txt_box.T_box()
        Me.PD_bx = New Txt_box.T_box()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Gr_Miss_Mano = New System.Windows.Forms.GroupBox()
        Me.L_Act_Mano = New System.Windows.Forms.Label()
        Me.L_req_Mano = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.B_Prel = New System.Windows.Forms.Button()
        Me.B_Depos = New System.Windows.Forms.Button()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Sts0 = New System.Windows.Forms.Label()
        Me.Sts1 = New System.Windows.Forms.Label()
        Me.Sts2 = New System.Windows.Forms.Label()
        Me.Sts4 = New System.Windows.Forms.Label()
        Me.Sts5 = New System.Windows.Forms.Label()
        Me.Sts6 = New System.Windows.Forms.Label()
        Me.Ctr0 = New System.Windows.Forms.Label()
        Me.Ctr1 = New System.Windows.Forms.Label()
        Me.Ctr2 = New System.Windows.Forms.Label()
        Me.Ctr4 = New System.Windows.Forms.Label()
        Me.Ctr5 = New System.Windows.Forms.Label()
        Me.Ctr6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnVaiZonaCamera = New System.Windows.Forms.Button()
        Me.M4s = New System.Windows.Forms.Label()
        Me.M2s = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.M2b = New System.Windows.Forms.Label()
        Me.M1_Vass = New System.Windows.Forms.Label()
        Me.M2a_SX = New System.Windows.Forms.Label()
        Me.M1s = New System.Windows.Forms.Label()
        Me.M1b = New System.Windows.Forms.Label()
        Me.M1a = New System.Windows.Forms.Label()
        Me.m1A_Vas = New System.Windows.Forms.PictureBox()
        Me.M3s = New System.Windows.Forms.Label()
        Me.M1a_Vass = New System.Windows.Forms.Label()
        Me.M1b_Vass = New System.Windows.Forms.Label()
        Me.M2a_DX = New System.Windows.Forms.Label()
        Me.LabelMano = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Sts3 = New System.Windows.Forms.Label()
        Me.Sts7 = New System.Windows.Forms.Label()
        Me.Ctr3 = New System.Windows.Forms.Label()
        Me.Ctr7 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Gr_Vuoti.SuspendLayout()
        Me.Gr_Repos.SuspendLayout()
        Me.Gr_Punti.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GR_PA.SuspendLayout()
        Me.GR_PB.SuspendLayout()
        Me.Gr_Miss_Mano.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m1A_Vas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'Lab_Act_aLL
        '
        Me.Lab_Act_aLL.BackColor = System.Drawing.Color.LightGray
        Me.Lab_Act_aLL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_Act_aLL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Act_aLL.ForeColor = System.Drawing.Color.Blue
        Me.Lab_Act_aLL.Location = New System.Drawing.Point(369, 12)
        Me.Lab_Act_aLL.Name = "Lab_Act_aLL"
        Me.Lab_Act_aLL.Size = New System.Drawing.Size(350, 25)
        Me.Lab_Act_aLL.TabIndex = 126
        Me.Lab_Act_aLL.Text = """05 = MAGAZZINO STAZ.2 ESAURITO MATERIALE"""
        Me.Lab_Act_aLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_Allarmi
        '
        Me.Lab_Allarmi.BackColor = System.Drawing.Color.Black
        Me.Lab_Allarmi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_Allarmi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Allarmi.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lab_Allarmi.Location = New System.Drawing.Point(12, 12)
        Me.Lab_Allarmi.Name = "Lab_Allarmi"
        Me.Lab_Allarmi.Size = New System.Drawing.Size(240, 25)
        Me.Lab_Allarmi.TabIndex = 154
        Me.Lab_Allarmi.Text = "ALLARMI ATTIVI"
        Me.Lab_Allarmi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_Missione
        '
        Me.Lab_Missione.BackColor = System.Drawing.Color.Black
        Me.Lab_Missione.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_Missione.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Missione.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lab_Missione.Location = New System.Drawing.Point(12, 45)
        Me.Lab_Missione.Name = "Lab_Missione"
        Me.Lab_Missione.Size = New System.Drawing.Size(240, 25)
        Me.Lab_Missione.TabIndex = 156
        Me.Lab_Missione.Text = "MISS ATTIVA"
        Me.Lab_Missione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_Act_M
        '
        Me.Lab_Act_M.BackColor = System.Drawing.Color.LightGray
        Me.Lab_Act_M.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_Act_M.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Act_M.ForeColor = System.Drawing.Color.Blue
        Me.Lab_Act_M.Location = New System.Drawing.Point(370, 45)
        Me.Lab_Act_M.Name = "Lab_Act_M"
        Me.Lab_Act_M.Size = New System.Drawing.Size(350, 25)
        Me.Lab_Act_M.TabIndex = 155
        Me.Lab_Act_M.Text = "###.##"
        Me.Lab_Act_M.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Led_V.png")
        Me.ImageList1.Images.SetKeyName(1, "Led_G.png")
        Me.ImageList1.Images.SetKeyName(2, "Led_R.png")
        '
        'Lab_All
        '
        Me.Lab_All.BackColor = System.Drawing.Color.LightGray
        Me.Lab_All.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_All.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_All.ForeColor = System.Drawing.Color.Blue
        Me.Lab_All.Location = New System.Drawing.Point(258, 12)
        Me.Lab_All.Name = "Lab_All"
        Me.Lab_All.Size = New System.Drawing.Size(73, 25)
        Me.Lab_All.TabIndex = 163
        Me.Lab_All.Text = "###"
        Me.Lab_All.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_Miss
        '
        Me.Lab_Miss.BackColor = System.Drawing.Color.LightGray
        Me.Lab_Miss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_Miss.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Miss.ForeColor = System.Drawing.Color.Blue
        Me.Lab_Miss.Location = New System.Drawing.Point(258, 45)
        Me.Lab_Miss.Name = "Lab_Miss"
        Me.Lab_Miss.Size = New System.Drawing.Size(73, 25)
        Me.Lab_Miss.TabIndex = 164
        Me.Lab_Miss.Text = "###"
        Me.Lab_Miss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Gr_Vuoti
        '
        Me.Gr_Vuoti.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Gr_Vuoti.Controls.Add(Me.B_PL_ch)
        Me.Gr_Vuoti.Controls.Add(Me.B_PL_ap)
        Me.Gr_Vuoti.Controls.Add(Me.Lab_pl)
        Me.Gr_Vuoti.Controls.Add(Me.B_I2on)
        Me.Gr_Vuoti.Controls.Add(Me.B_I2off)
        Me.Gr_Vuoti.Controls.Add(Me.B_I1on)
        Me.Gr_Vuoti.Controls.Add(Me.B_I1off)
        Me.Gr_Vuoti.Controls.Add(Me.Lab_Ill2)
        Me.Gr_Vuoti.Controls.Add(Me.Lab_Ill1)
        Me.Gr_Vuoti.Controls.Add(Me.Lab_Pinza)
        Me.Gr_Vuoti.Controls.Add(Me.B_S1_On)
        Me.Gr_Vuoti.Controls.Add(Me.B_S1_Off)
        Me.Gr_Vuoti.Controls.Add(Me.Lab_Vuoto1)
        Me.Gr_Vuoti.Controls.Add(Me.B_v1_On)
        Me.Gr_Vuoti.Controls.Add(Me.B_v1_Off)
        Me.Gr_Vuoti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gr_Vuoti.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Gr_Vuoti.Location = New System.Drawing.Point(369, 108)
        Me.Gr_Vuoti.Name = "Gr_Vuoti"
        Me.Gr_Vuoti.Size = New System.Drawing.Size(350, 464)
        Me.Gr_Vuoti.TabIndex = 177
        Me.Gr_Vuoti.TabStop = False
        Me.Gr_Vuoti.Text = "COMANDI MANI DI PRESA"
        '
        'B_PL_ch
        '
        Me.B_PL_ch.BackColor = System.Drawing.Color.DarkGray
        Me.B_PL_ch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_PL_ch.ForeColor = System.Drawing.Color.Navy
        Me.B_PL_ch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B_PL_ch.ImageKey = "Windows-Restart-icon2.png"
        Me.B_PL_ch.ImageList = Me.ImageList2
        Me.B_PL_ch.Location = New System.Drawing.Point(172, 380)
        Me.B_PL_ch.Name = "B_PL_ch"
        Me.B_PL_ch.Size = New System.Drawing.Size(75, 68)
        Me.B_PL_ch.TabIndex = 209
        Me.B_PL_ch.Text = "AVANZA"
        Me.B_PL_ch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.B_PL_ch.UseVisualStyleBackColor = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "Windows-Close-Program-icon2.png")
        Me.ImageList2.Images.SetKeyName(1, "Windows-Restart-icon2.png")
        Me.ImageList2.Images.SetKeyName(2, "Windows-Restart-icon.png")
        Me.ImageList2.Images.SetKeyName(3, "Windows-Restart-icon2.png")
        '
        'B_PL_ap
        '
        Me.B_PL_ap.BackColor = System.Drawing.Color.DarkGray
        Me.B_PL_ap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_PL_ap.ForeColor = System.Drawing.Color.Navy
        Me.B_PL_ap.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B_PL_ap.ImageKey = "Windows-Close-Program-icon2.png"
        Me.B_PL_ap.ImageList = Me.ImageList2
        Me.B_PL_ap.Location = New System.Drawing.Point(264, 380)
        Me.B_PL_ap.Name = "B_PL_ap"
        Me.B_PL_ap.Size = New System.Drawing.Size(75, 68)
        Me.B_PL_ap.TabIndex = 208
        Me.B_PL_ap.Text = "RITORNA"
        Me.B_PL_ap.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.B_PL_ap.UseVisualStyleBackColor = False
        '
        'Lab_pl
        '
        Me.Lab_pl.BackColor = System.Drawing.Color.Navy
        Me.Lab_pl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_pl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_pl.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lab_pl.Location = New System.Drawing.Point(14, 380)
        Me.Lab_pl.Name = "Lab_pl"
        Me.Lab_pl.Size = New System.Drawing.Size(136, 68)
        Me.Lab_pl.TabIndex = 207
        Me.Lab_pl.Text = "Pinza Index"
        Me.Lab_pl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'B_I2on
        '
        Me.B_I2on.BackColor = System.Drawing.Color.DarkGray
        Me.B_I2on.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_I2on.ForeColor = System.Drawing.Color.Navy
        Me.B_I2on.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B_I2on.ImageKey = "Windows-Restart-icon2.png"
        Me.B_I2on.ImageList = Me.ImageList2
        Me.B_I2on.Location = New System.Drawing.Point(172, 289)
        Me.B_I2on.Name = "B_I2on"
        Me.B_I2on.Size = New System.Drawing.Size(75, 68)
        Me.B_I2on.TabIndex = 206
        Me.B_I2on.Text = "ON"
        Me.B_I2on.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.B_I2on.UseVisualStyleBackColor = False
        '
        'B_I2off
        '
        Me.B_I2off.BackColor = System.Drawing.Color.DarkGray
        Me.B_I2off.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_I2off.ForeColor = System.Drawing.Color.Navy
        Me.B_I2off.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B_I2off.ImageKey = "Windows-Close-Program-icon2.png"
        Me.B_I2off.ImageList = Me.ImageList2
        Me.B_I2off.Location = New System.Drawing.Point(264, 289)
        Me.B_I2off.Name = "B_I2off"
        Me.B_I2off.Size = New System.Drawing.Size(75, 68)
        Me.B_I2off.TabIndex = 205
        Me.B_I2off.Text = "OFF"
        Me.B_I2off.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.B_I2off.UseVisualStyleBackColor = False
        '
        'B_I1on
        '
        Me.B_I1on.BackColor = System.Drawing.Color.DarkGray
        Me.B_I1on.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_I1on.ForeColor = System.Drawing.Color.Navy
        Me.B_I1on.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B_I1on.ImageKey = "Windows-Restart-icon2.png"
        Me.B_I1on.ImageList = Me.ImageList2
        Me.B_I1on.Location = New System.Drawing.Point(172, 199)
        Me.B_I1on.Name = "B_I1on"
        Me.B_I1on.Size = New System.Drawing.Size(75, 68)
        Me.B_I1on.TabIndex = 204
        Me.B_I1on.Text = "ON"
        Me.B_I1on.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.B_I1on.UseVisualStyleBackColor = False
        '
        'B_I1off
        '
        Me.B_I1off.BackColor = System.Drawing.Color.DarkGray
        Me.B_I1off.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_I1off.ForeColor = System.Drawing.Color.Navy
        Me.B_I1off.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B_I1off.ImageKey = "Windows-Close-Program-icon2.png"
        Me.B_I1off.ImageList = Me.ImageList2
        Me.B_I1off.Location = New System.Drawing.Point(264, 199)
        Me.B_I1off.Name = "B_I1off"
        Me.B_I1off.Size = New System.Drawing.Size(75, 68)
        Me.B_I1off.TabIndex = 203
        Me.B_I1off.Text = "OFF"
        Me.B_I1off.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.B_I1off.UseVisualStyleBackColor = False
        '
        'Lab_Ill2
        '
        Me.Lab_Ill2.BackColor = System.Drawing.Color.Navy
        Me.Lab_Ill2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_Ill2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Ill2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lab_Ill2.Location = New System.Drawing.Point(14, 289)
        Me.Lab_Ill2.Name = "Lab_Ill2"
        Me.Lab_Ill2.Size = New System.Drawing.Size(136, 68)
        Me.Lab_Ill2.TabIndex = 202
        Me.Lab_Ill2.Text = "Illuminatore" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Oled"
        Me.Lab_Ill2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_Ill1
        '
        Me.Lab_Ill1.BackColor = System.Drawing.Color.Navy
        Me.Lab_Ill1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_Ill1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Ill1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lab_Ill1.Location = New System.Drawing.Point(14, 199)
        Me.Lab_Ill1.Name = "Lab_Ill1"
        Me.Lab_Ill1.Size = New System.Drawing.Size(136, 68)
        Me.Lab_Ill1.TabIndex = 201
        Me.Lab_Ill1.Text = "Illuminatore Mano"
        Me.Lab_Ill1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_Pinza
        '
        Me.Lab_Pinza.BackColor = System.Drawing.Color.Navy
        Me.Lab_Pinza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_Pinza.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Pinza.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lab_Pinza.Location = New System.Drawing.Point(14, 109)
        Me.Lab_Pinza.Name = "Lab_Pinza"
        Me.Lab_Pinza.Size = New System.Drawing.Size(136, 68)
        Me.Lab_Pinza.TabIndex = 200
        Me.Lab_Pinza.Text = "Pinza Mano"
        Me.Lab_Pinza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'B_S1_On
        '
        Me.B_S1_On.BackColor = System.Drawing.Color.DarkGray
        Me.B_S1_On.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_S1_On.ForeColor = System.Drawing.Color.Navy
        Me.B_S1_On.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B_S1_On.ImageKey = "Windows-Restart-icon2.png"
        Me.B_S1_On.ImageList = Me.ImageList2
        Me.B_S1_On.Location = New System.Drawing.Point(172, 109)
        Me.B_S1_On.Name = "B_S1_On"
        Me.B_S1_On.Size = New System.Drawing.Size(75, 68)
        Me.B_S1_On.TabIndex = 199
        Me.B_S1_On.Text = "Pinza CH"
        Me.B_S1_On.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.B_S1_On.UseVisualStyleBackColor = False
        '
        'B_S1_Off
        '
        Me.B_S1_Off.BackColor = System.Drawing.Color.DarkGray
        Me.B_S1_Off.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_S1_Off.ForeColor = System.Drawing.Color.Navy
        Me.B_S1_Off.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B_S1_Off.ImageKey = "Windows-Close-Program-icon2.png"
        Me.B_S1_Off.ImageList = Me.ImageList2
        Me.B_S1_Off.Location = New System.Drawing.Point(264, 109)
        Me.B_S1_Off.Name = "B_S1_Off"
        Me.B_S1_Off.Size = New System.Drawing.Size(75, 68)
        Me.B_S1_Off.TabIndex = 198
        Me.B_S1_Off.Text = "Pinza AP"
        Me.B_S1_Off.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.B_S1_Off.UseVisualStyleBackColor = False
        '
        'Lab_Vuoto1
        '
        Me.Lab_Vuoto1.BackColor = System.Drawing.Color.Navy
        Me.Lab_Vuoto1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_Vuoto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Vuoto1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lab_Vuoto1.Location = New System.Drawing.Point(14, 21)
        Me.Lab_Vuoto1.Name = "Lab_Vuoto1"
        Me.Lab_Vuoto1.Size = New System.Drawing.Size(136, 68)
        Me.Lab_Vuoto1.TabIndex = 194
        Me.Lab_Vuoto1.Text = "Vuoto"
        Me.Lab_Vuoto1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'B_v1_On
        '
        Me.B_v1_On.BackColor = System.Drawing.Color.DarkGray
        Me.B_v1_On.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_v1_On.ForeColor = System.Drawing.Color.Navy
        Me.B_v1_On.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B_v1_On.ImageIndex = 1
        Me.B_v1_On.ImageList = Me.ImageList2
        Me.B_v1_On.Location = New System.Drawing.Point(172, 21)
        Me.B_v1_On.Name = "B_v1_On"
        Me.B_v1_On.Size = New System.Drawing.Size(75, 68)
        Me.B_v1_On.TabIndex = 193
        Me.B_v1_On.Text = "Vuoto ON"
        Me.B_v1_On.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.B_v1_On.UseVisualStyleBackColor = False
        '
        'B_v1_Off
        '
        Me.B_v1_Off.BackColor = System.Drawing.Color.DarkGray
        Me.B_v1_Off.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_v1_Off.ForeColor = System.Drawing.Color.Navy
        Me.B_v1_Off.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B_v1_Off.ImageKey = "Windows-Close-Program-icon2.png"
        Me.B_v1_Off.ImageList = Me.ImageList2
        Me.B_v1_Off.Location = New System.Drawing.Point(264, 21)
        Me.B_v1_Off.Name = "B_v1_Off"
        Me.B_v1_Off.Size = New System.Drawing.Size(75, 68)
        Me.B_v1_Off.TabIndex = 192
        Me.B_v1_Off.Text = "Vuoto OFF"
        Me.B_v1_Off.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.B_v1_Off.UseVisualStyleBackColor = False
        '
        'Gr_Repos
        '
        Me.Gr_Repos.Controls.Add(Me.btnHome)
        Me.Gr_Repos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gr_Repos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Gr_Repos.Location = New System.Drawing.Point(1163, 20)
        Me.Gr_Repos.Name = "Gr_Repos"
        Me.Gr_Repos.Size = New System.Drawing.Size(140, 131)
        Me.Gr_Repos.TabIndex = 179
        Me.Gr_Repos.TabStop = False
        Me.Gr_Repos.Text = "REPOS"
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.Controllo.My.Resources.Resources._1465213055_kfm_home
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.Location = New System.Drawing.Point(16, 20)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(104, 104)
        Me.btnHome.TabIndex = 0
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Lab_MagA
        '
        Me.Lab_MagA.BackColor = System.Drawing.Color.Black
        Me.Lab_MagA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_MagA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_MagA.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lab_MagA.Location = New System.Drawing.Point(12, 108)
        Me.Lab_MagA.Name = "Lab_MagA"
        Me.Lab_MagA.Size = New System.Drawing.Size(166, 25)
        Me.Lab_MagA.TabIndex = 180
        Me.Lab_MagA.Text = "MANO ATTIVA"
        Me.Lab_MagA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(12, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 25)
        Me.Label3.TabIndex = 206
        Me.Label3.Text = "Override"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'T_Overr
        '
        Me.T_Overr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_Overr.Format_num = "0"
        Me.T_Overr.Location = New System.Drawing.Point(258, 146)
        Me.T_Overr.Max = 100.0R
        Me.T_Overr.Min = 1.0R
        Me.T_Overr.Msg = False
        Me.T_Overr.Name = "T_Overr"
        Me.T_Overr.Only_Enter = False
        Me.T_Overr.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.T_Overr.Size = New System.Drawing.Size(105, 25)
        Me.T_Overr.TabIndex = 207
        Me.T_Overr.Tag = "1"
        Me.T_Overr.Test_si = False
        Me.T_Overr.Text = "10"
        Me.T_Overr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_Overr.Value = 10.0R
        '
        'Gr_Punti
        '
        Me.Gr_Punti.Controls.Add(Me.Label1)
        Me.Gr_Punti.Controls.Add(Me.T_aa)
        Me.Gr_Punti.Controls.Add(Me.T_za)
        Me.Gr_Punti.Controls.Add(Me.T_ya)
        Me.Gr_Punti.Controls.Add(Me.T_xa)
        Me.Gr_Punti.Controls.Add(Me.Label6)
        Me.Gr_Punti.Controls.Add(Me.Label21)
        Me.Gr_Punti.Controls.Add(Me.Label22)
        Me.Gr_Punti.Controls.Add(Me.Label23)
        Me.Gr_Punti.Controls.Add(Me.Label12)
        Me.Gr_Punti.Controls.Add(Me.T_ao)
        Me.Gr_Punti.Controls.Add(Me.T_zo)
        Me.Gr_Punti.Controls.Add(Me.T_yo)
        Me.Gr_Punti.Controls.Add(Me.T_xo)
        Me.Gr_Punti.Controls.Add(Me.Label14)
        Me.Gr_Punti.Controls.Add(Me.Label16)
        Me.Gr_Punti.Controls.Add(Me.Label18)
        Me.Gr_Punti.Controls.Add(Me.Label20)
        Me.Gr_Punti.Controls.Add(Me.Label4)
        Me.Gr_Punti.Controls.Add(Me.T_as)
        Me.Gr_Punti.Controls.Add(Me.T_zs)
        Me.Gr_Punti.Controls.Add(Me.T_ys)
        Me.Gr_Punti.Controls.Add(Me.T_xs)
        Me.Gr_Punti.Controls.Add(Me.Label19)
        Me.Gr_Punti.Controls.Add(Me.Label13)
        Me.Gr_Punti.Controls.Add(Me.Label15)
        Me.Gr_Punti.Controls.Add(Me.Label17)
        Me.Gr_Punti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gr_Punti.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Gr_Punti.Location = New System.Drawing.Point(726, 222)
        Me.Gr_Punti.Name = "Gr_Punti"
        Me.Gr_Punti.Size = New System.Drawing.Size(176, 596)
        Me.Gr_Punti.TabIndex = 215
        Me.Gr_Punti.TabStop = False
        Me.Gr_Punti.Text = "PUNTO INCOLLAGGIO"
        Me.Gr_Punti.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(10, 399)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 25)
        Me.Label1.TabIndex = 234
        Me.Label1.Text = "Prelievo assemblato"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'T_aa
        '
        Me.T_aa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_aa.Format_num = "0.0"
        Me.T_aa.Location = New System.Drawing.Point(66, 526)
        Me.T_aa.Max = 90.0R
        Me.T_aa.Min = -90.0R
        Me.T_aa.Msg = False
        Me.T_aa.Name = "T_aa"
        Me.T_aa.Only_Enter = False
        Me.T_aa.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.T_aa.Size = New System.Drawing.Size(100, 25)
        Me.T_aa.TabIndex = 233
        Me.T_aa.Tag = "342"
        Me.T_aa.Test_si = False
        Me.T_aa.Text = "0,0"
        Me.T_aa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_aa.Value = 0R
        '
        'T_za
        '
        Me.T_za.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_za.Format_num = "0.0"
        Me.T_za.Location = New System.Drawing.Point(66, 492)
        Me.T_za.Max = 15.0R
        Me.T_za.Min = -15.0R
        Me.T_za.Msg = False
        Me.T_za.Name = "T_za"
        Me.T_za.Only_Enter = False
        Me.T_za.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.T_za.Size = New System.Drawing.Size(100, 25)
        Me.T_za.TabIndex = 232
        Me.T_za.Tag = "340"
        Me.T_za.Test_si = False
        Me.T_za.Text = "0,0"
        Me.T_za.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_za.Value = 0R
        '
        'T_ya
        '
        Me.T_ya.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_ya.Format_num = "0.0"
        Me.T_ya.Location = New System.Drawing.Point(66, 461)
        Me.T_ya.Max = 15.0R
        Me.T_ya.Min = -15.0R
        Me.T_ya.Msg = False
        Me.T_ya.Name = "T_ya"
        Me.T_ya.Only_Enter = False
        Me.T_ya.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.T_ya.Size = New System.Drawing.Size(100, 25)
        Me.T_ya.TabIndex = 231
        Me.T_ya.Tag = "338"
        Me.T_ya.Test_si = False
        Me.T_ya.Text = "0,0"
        Me.T_ya.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_ya.Value = 0R
        '
        'T_xa
        '
        Me.T_xa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_xa.Format_num = "0.0"
        Me.T_xa.Location = New System.Drawing.Point(66, 429)
        Me.T_xa.Max = 15.0R
        Me.T_xa.Min = -15.0R
        Me.T_xa.Msg = False
        Me.T_xa.Name = "T_xa"
        Me.T_xa.Only_Enter = False
        Me.T_xa.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.T_xa.Size = New System.Drawing.Size(100, 25)
        Me.T_xa.TabIndex = 230
        Me.T_xa.Tag = "336"
        Me.T_xa.Test_si = False
        Me.T_xa.Text = "0,0"
        Me.T_xa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_xa.Value = 0R
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(10, 494)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 25)
        Me.Label6.TabIndex = 229
        Me.Label6.Text = "Z"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Black
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label21.Location = New System.Drawing.Point(10, 526)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 25)
        Me.Label21.TabIndex = 228
        Me.Label21.Text = "A"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Black
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label22.Location = New System.Drawing.Point(10, 462)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 25)
        Me.Label22.TabIndex = 227
        Me.Label22.Text = "Y"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Black
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label23.Location = New System.Drawing.Point(10, 430)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 25)
        Me.Label23.TabIndex = 226
        Me.Label23.Text = "X"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(10, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(156, 25)
        Me.Label12.TabIndex = 225
        Me.Label12.Text = "Deposito OLED"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'T_ao
        '
        Me.T_ao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_ao.Format_num = "0.0"
        Me.T_ao.Location = New System.Drawing.Point(66, 159)
        Me.T_ao.Max = 90.0R
        Me.T_ao.Min = -90.0R
        Me.T_ao.Msg = False
        Me.T_ao.Name = "T_ao"
        Me.T_ao.Only_Enter = False
        Me.T_ao.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.T_ao.Size = New System.Drawing.Size(100, 25)
        Me.T_ao.TabIndex = 224
        Me.T_ao.Tag = "326"
        Me.T_ao.Test_si = False
        Me.T_ao.Text = "0,0"
        Me.T_ao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_ao.Value = 0R
        '
        'T_zo
        '
        Me.T_zo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_zo.Format_num = "0.0"
        Me.T_zo.Location = New System.Drawing.Point(66, 125)
        Me.T_zo.Max = 15.0R
        Me.T_zo.Min = -15.0R
        Me.T_zo.Msg = False
        Me.T_zo.Name = "T_zo"
        Me.T_zo.Only_Enter = False
        Me.T_zo.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.T_zo.Size = New System.Drawing.Size(100, 25)
        Me.T_zo.TabIndex = 223
        Me.T_zo.Tag = "324"
        Me.T_zo.Test_si = False
        Me.T_zo.Text = "0,0"
        Me.T_zo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_zo.Value = 0R
        '
        'T_yo
        '
        Me.T_yo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_yo.Format_num = "0.0"
        Me.T_yo.Location = New System.Drawing.Point(66, 91)
        Me.T_yo.Max = 15.0R
        Me.T_yo.Min = -15.0R
        Me.T_yo.Msg = False
        Me.T_yo.Name = "T_yo"
        Me.T_yo.Only_Enter = False
        Me.T_yo.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.T_yo.Size = New System.Drawing.Size(100, 25)
        Me.T_yo.TabIndex = 222
        Me.T_yo.Tag = "322"
        Me.T_yo.Test_si = False
        Me.T_yo.Text = "0,0"
        Me.T_yo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_yo.Value = 0R
        '
        'T_xo
        '
        Me.T_xo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_xo.Format_num = "0.0"
        Me.T_xo.Location = New System.Drawing.Point(66, 57)
        Me.T_xo.Max = 15.0R
        Me.T_xo.Min = -15.0R
        Me.T_xo.Msg = False
        Me.T_xo.Name = "T_xo"
        Me.T_xo.Only_Enter = False
        Me.T_xo.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.T_xo.Size = New System.Drawing.Size(100, 25)
        Me.T_xo.TabIndex = 221
        Me.T_xo.Tag = "320"
        Me.T_xo.Test_si = False
        Me.T_xo.Text = "0,0"
        Me.T_xo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_xo.Value = 0R
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label14.Location = New System.Drawing.Point(10, 124)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 25)
        Me.Label14.TabIndex = 220
        Me.Label14.Text = "Z"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Black
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label16.Location = New System.Drawing.Point(10, 158)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 25)
        Me.Label16.TabIndex = 219
        Me.Label16.Text = "A"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Black
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label18.Location = New System.Drawing.Point(10, 90)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 25)
        Me.Label18.TabIndex = 218
        Me.Label18.Text = "Y"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Black
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label20.Location = New System.Drawing.Point(10, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 25)
        Me.Label20.TabIndex = 217
        Me.Label20.Text = "X"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(10, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 25)
        Me.Label4.TabIndex = 215
        Me.Label4.Text = "Deposito supporto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'T_as
        '
        Me.T_as.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_as.Format_num = "0.0"
        Me.T_as.Location = New System.Drawing.Point(66, 335)
        Me.T_as.Max = 90.0R
        Me.T_as.Min = -90.0R
        Me.T_as.Msg = False
        Me.T_as.Name = "T_as"
        Me.T_as.Only_Enter = False
        Me.T_as.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.T_as.Size = New System.Drawing.Size(100, 25)
        Me.T_as.TabIndex = 214
        Me.T_as.Tag = "334"
        Me.T_as.Test_si = False
        Me.T_as.Text = "0,0"
        Me.T_as.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_as.Value = 0R
        '
        'T_zs
        '
        Me.T_zs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_zs.Format_num = "0.0"
        Me.T_zs.Location = New System.Drawing.Point(66, 301)
        Me.T_zs.Max = 15.0R
        Me.T_zs.Min = -15.0R
        Me.T_zs.Msg = False
        Me.T_zs.Name = "T_zs"
        Me.T_zs.Only_Enter = False
        Me.T_zs.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.T_zs.Size = New System.Drawing.Size(100, 25)
        Me.T_zs.TabIndex = 213
        Me.T_zs.Tag = "332"
        Me.T_zs.Test_si = False
        Me.T_zs.Text = "0,0"
        Me.T_zs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_zs.Value = 0R
        '
        'T_ys
        '
        Me.T_ys.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_ys.Format_num = "0.0"
        Me.T_ys.Location = New System.Drawing.Point(66, 270)
        Me.T_ys.Max = 15.0R
        Me.T_ys.Min = -15.0R
        Me.T_ys.Msg = False
        Me.T_ys.Name = "T_ys"
        Me.T_ys.Only_Enter = False
        Me.T_ys.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.T_ys.Size = New System.Drawing.Size(100, 25)
        Me.T_ys.TabIndex = 212
        Me.T_ys.Tag = "330"
        Me.T_ys.Test_si = False
        Me.T_ys.Text = "0,0"
        Me.T_ys.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_ys.Value = 0R
        '
        'T_xs
        '
        Me.T_xs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_xs.Format_num = "0.0"
        Me.T_xs.Location = New System.Drawing.Point(66, 238)
        Me.T_xs.Max = 15.0R
        Me.T_xs.Min = -15.0R
        Me.T_xs.Msg = False
        Me.T_xs.Name = "T_xs"
        Me.T_xs.Only_Enter = False
        Me.T_xs.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.T_xs.Size = New System.Drawing.Size(100, 25)
        Me.T_xs.TabIndex = 211
        Me.T_xs.Tag = "328"
        Me.T_xs.Test_si = False
        Me.T_xs.Text = "0,0"
        Me.T_xs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_xs.Value = 0R
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Black
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label19.Location = New System.Drawing.Point(10, 302)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 25)
        Me.Label19.TabIndex = 180
        Me.Label19.Text = "Z"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Location = New System.Drawing.Point(10, 334)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 25)
        Me.Label13.TabIndex = 178
        Me.Label13.Text = "A"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Black
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Location = New System.Drawing.Point(10, 270)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 25)
        Me.Label15.TabIndex = 176
        Me.Label15.Text = "Y"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Black
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label17.Location = New System.Drawing.Point(10, 238)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 25)
        Me.Label17.TabIndex = 174
        Me.Label17.Text = "X"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(9, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 25)
        Me.Label10.TabIndex = 216
        Me.Label10.Text = "Correzione visione"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(9, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 25)
        Me.Label11.TabIndex = 172
        Me.Label11.Text = "A"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lt_a
        '
        Me.Lt_a.BackColor = System.Drawing.Color.Silver
        Me.Lt_a.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lt_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lt_a.Location = New System.Drawing.Point(65, 150)
        Me.Lt_a.Name = "Lt_a"
        Me.Lt_a.Size = New System.Drawing.Size(100, 25)
        Me.Lt_a.TabIndex = 171
        Me.Lt_a.Text = "###"
        Me.Lt_a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(9, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 25)
        Me.Label8.TabIndex = 170
        Me.Label8.Text = "Y"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lt_y
        '
        Me.Lt_y.BackColor = System.Drawing.Color.Silver
        Me.Lt_y.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lt_y.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lt_y.Location = New System.Drawing.Point(65, 100)
        Me.Lt_y.Name = "Lt_y"
        Me.Lt_y.Size = New System.Drawing.Size(100, 25)
        Me.Lt_y.TabIndex = 169
        Me.Lt_y.Text = "###"
        Me.Lt_y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(9, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 25)
        Me.Label7.TabIndex = 168
        Me.Label7.Text = "X"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lt_x
        '
        Me.Lt_x.BackColor = System.Drawing.Color.Silver
        Me.Lt_x.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lt_x.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lt_x.Location = New System.Drawing.Point(65, 56)
        Me.Lt_x.Name = "Lt_x"
        Me.Lt_x.Size = New System.Drawing.Size(100, 25)
        Me.Lt_x.TabIndex = 165
        Me.Lt_x.Text = "###"
        Me.Lt_x.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Lt_x)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Lt_y)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Lt_a)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(726, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 197)
        Me.GroupBox1.TabIndex = 217
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'GR_PA
        '
        Me.GR_PA.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GR_PA.Controls.Add(Me.Label29)
        Me.GR_PA.Controls.Add(Me.PP_aa)
        Me.GR_PA.Controls.Add(Me.PP_az)
        Me.GR_PA.Controls.Add(Me.PP_ay)
        Me.GR_PA.Controls.Add(Me.PP_ax)
        Me.GR_PA.Controls.Add(Me.Label30)
        Me.GR_PA.Controls.Add(Me.Label31)
        Me.GR_PA.Controls.Add(Me.Label32)
        Me.GR_PA.Controls.Add(Me.Label33)
        Me.GR_PA.Controls.Add(Me.Label34)
        Me.GR_PA.Controls.Add(Me.PD_aa)
        Me.GR_PA.Controls.Add(Me.PD_az)
        Me.GR_PA.Controls.Add(Me.PD_ay)
        Me.GR_PA.Controls.Add(Me.PD_ax)
        Me.GR_PA.Controls.Add(Me.Label35)
        Me.GR_PA.Controls.Add(Me.Label36)
        Me.GR_PA.Controls.Add(Me.Label37)
        Me.GR_PA.Controls.Add(Me.Label38)
        Me.GR_PA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GR_PA.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GR_PA.Location = New System.Drawing.Point(922, 12)
        Me.GR_PA.Name = "GR_PA"
        Me.GR_PA.Size = New System.Drawing.Size(176, 397)
        Me.GR_PA.TabIndex = 218
        Me.GR_PA.TabStop = False
        Me.GR_PA.Text = "PALLET LATO (A) DX"
        Me.GR_PA.Visible = False
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Black
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label29.Location = New System.Drawing.Point(10, 24)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(156, 30)
        Me.Label29.TabIndex = 225
        Me.Label29.Text = "Prelievo OLED SX"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PP_aa
        '
        Me.PP_aa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PP_aa.Format_num = "0.0"
        Me.PP_aa.Location = New System.Drawing.Point(66, 168)
        Me.PP_aa.Max = 90.0R
        Me.PP_aa.Min = -90.0R
        Me.PP_aa.Msg = False
        Me.PP_aa.Name = "PP_aa"
        Me.PP_aa.Only_Enter = False
        Me.PP_aa.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.PP_aa.Size = New System.Drawing.Size(100, 25)
        Me.PP_aa.TabIndex = 224
        Me.PP_aa.Tag = "278"
        Me.PP_aa.Test_si = False
        Me.PP_aa.Text = "0,0"
        Me.PP_aa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PP_aa.Value = 0R
        '
        'PP_az
        '
        Me.PP_az.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PP_az.Format_num = "0.0"
        Me.PP_az.Location = New System.Drawing.Point(66, 134)
        Me.PP_az.Max = 15.0R
        Me.PP_az.Min = -15.0R
        Me.PP_az.Msg = False
        Me.PP_az.Name = "PP_az"
        Me.PP_az.Only_Enter = False
        Me.PP_az.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.PP_az.Size = New System.Drawing.Size(100, 25)
        Me.PP_az.TabIndex = 223
        Me.PP_az.Tag = "276"
        Me.PP_az.Test_si = False
        Me.PP_az.Text = "0,0"
        Me.PP_az.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PP_az.Value = 0R
        '
        'PP_ay
        '
        Me.PP_ay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PP_ay.Format_num = "0.0"
        Me.PP_ay.Location = New System.Drawing.Point(66, 100)
        Me.PP_ay.Max = 15.0R
        Me.PP_ay.Min = -15.0R
        Me.PP_ay.Msg = False
        Me.PP_ay.Name = "PP_ay"
        Me.PP_ay.Only_Enter = False
        Me.PP_ay.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.PP_ay.Size = New System.Drawing.Size(100, 25)
        Me.PP_ay.TabIndex = 222
        Me.PP_ay.Tag = "274"
        Me.PP_ay.Test_si = False
        Me.PP_ay.Text = "0,0"
        Me.PP_ay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PP_ay.Value = 0R
        '
        'PP_ax
        '
        Me.PP_ax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PP_ax.Format_num = "0.0"
        Me.PP_ax.Location = New System.Drawing.Point(66, 66)
        Me.PP_ax.Max = 15.0R
        Me.PP_ax.Min = -15.0R
        Me.PP_ax.Msg = False
        Me.PP_ax.Name = "PP_ax"
        Me.PP_ax.Only_Enter = False
        Me.PP_ax.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.PP_ax.Size = New System.Drawing.Size(100, 25)
        Me.PP_ax.TabIndex = 221
        Me.PP_ax.Tag = "272"
        Me.PP_ax.Test_si = False
        Me.PP_ax.Text = "0,0"
        Me.PP_ax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PP_ax.Value = 0R
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Black
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label30.Location = New System.Drawing.Point(10, 133)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(50, 25)
        Me.Label30.TabIndex = 220
        Me.Label30.Text = "Z"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Black
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label31.Location = New System.Drawing.Point(10, 167)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(50, 25)
        Me.Label31.TabIndex = 219
        Me.Label31.Text = "A"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Black
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label32.Location = New System.Drawing.Point(10, 99)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(50, 25)
        Me.Label32.TabIndex = 218
        Me.Label32.Text = "Y"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Black
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label33.Location = New System.Drawing.Point(10, 65)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(50, 25)
        Me.Label33.TabIndex = 217
        Me.Label33.Text = "X"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Black
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label34.Location = New System.Drawing.Point(10, 220)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(156, 30)
        Me.Label34.TabIndex = 215
        Me.Label34.Text = "Prelievo OLED DX"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PD_aa
        '
        Me.PD_aa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PD_aa.Format_num = "0.0"
        Me.PD_aa.Location = New System.Drawing.Point(66, 363)
        Me.PD_aa.Max = 90.0R
        Me.PD_aa.Min = -90.0R
        Me.PD_aa.Msg = False
        Me.PD_aa.Name = "PD_aa"
        Me.PD_aa.Only_Enter = False
        Me.PD_aa.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.PD_aa.Size = New System.Drawing.Size(100, 25)
        Me.PD_aa.TabIndex = 214
        Me.PD_aa.Tag = "286"
        Me.PD_aa.Test_si = False
        Me.PD_aa.Text = "0,0"
        Me.PD_aa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PD_aa.Value = 0R
        '
        'PD_az
        '
        Me.PD_az.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PD_az.Format_num = "0.0"
        Me.PD_az.Location = New System.Drawing.Point(66, 329)
        Me.PD_az.Max = 15.0R
        Me.PD_az.Min = -15.0R
        Me.PD_az.Msg = False
        Me.PD_az.Name = "PD_az"
        Me.PD_az.Only_Enter = False
        Me.PD_az.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.PD_az.Size = New System.Drawing.Size(100, 25)
        Me.PD_az.TabIndex = 213
        Me.PD_az.Tag = "284"
        Me.PD_az.Test_si = False
        Me.PD_az.Text = "0,0"
        Me.PD_az.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PD_az.Value = 0R
        '
        'PD_ay
        '
        Me.PD_ay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PD_ay.Format_num = "0.0"
        Me.PD_ay.Location = New System.Drawing.Point(66, 298)
        Me.PD_ay.Max = 15.0R
        Me.PD_ay.Min = -15.0R
        Me.PD_ay.Msg = False
        Me.PD_ay.Name = "PD_ay"
        Me.PD_ay.Only_Enter = False
        Me.PD_ay.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.PD_ay.Size = New System.Drawing.Size(100, 25)
        Me.PD_ay.TabIndex = 212
        Me.PD_ay.Tag = "282"
        Me.PD_ay.Test_si = False
        Me.PD_ay.Text = "0,0"
        Me.PD_ay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PD_ay.Value = 0R
        '
        'PD_ax
        '
        Me.PD_ax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PD_ax.Format_num = "0.0"
        Me.PD_ax.Location = New System.Drawing.Point(66, 266)
        Me.PD_ax.Max = 15.0R
        Me.PD_ax.Min = -15.0R
        Me.PD_ax.Msg = False
        Me.PD_ax.Name = "PD_ax"
        Me.PD_ax.Only_Enter = False
        Me.PD_ax.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.PD_ax.Size = New System.Drawing.Size(100, 25)
        Me.PD_ax.TabIndex = 211
        Me.PD_ax.Tag = "280"
        Me.PD_ax.Test_si = False
        Me.PD_ax.Text = "0,0"
        Me.PD_ax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PD_ax.Value = 0R
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Black
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label35.Location = New System.Drawing.Point(10, 330)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(50, 25)
        Me.Label35.TabIndex = 180
        Me.Label35.Text = "Z"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Black
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label36.Location = New System.Drawing.Point(10, 362)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(50, 25)
        Me.Label36.TabIndex = 178
        Me.Label36.Text = "A"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Black
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label37.Location = New System.Drawing.Point(10, 298)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(50, 25)
        Me.Label37.TabIndex = 176
        Me.Label37.Text = "Y"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.Black
        Me.Label38.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label38.Location = New System.Drawing.Point(10, 266)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(50, 25)
        Me.Label38.TabIndex = 174
        Me.Label38.Text = "X"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GR_PB
        '
        Me.GR_PB.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GR_PB.Controls.Add(Me.Label24)
        Me.GR_PB.Controls.Add(Me.PP_ba)
        Me.GR_PB.Controls.Add(Me.PP_bz)
        Me.GR_PB.Controls.Add(Me.PP_by)
        Me.GR_PB.Controls.Add(Me.PP_bx)
        Me.GR_PB.Controls.Add(Me.Label25)
        Me.GR_PB.Controls.Add(Me.Label26)
        Me.GR_PB.Controls.Add(Me.Label27)
        Me.GR_PB.Controls.Add(Me.Label28)
        Me.GR_PB.Controls.Add(Me.Label39)
        Me.GR_PB.Controls.Add(Me.PD_ba)
        Me.GR_PB.Controls.Add(Me.PD_bz)
        Me.GR_PB.Controls.Add(Me.PD_by)
        Me.GR_PB.Controls.Add(Me.PD_bx)
        Me.GR_PB.Controls.Add(Me.Label40)
        Me.GR_PB.Controls.Add(Me.Label41)
        Me.GR_PB.Controls.Add(Me.Label42)
        Me.GR_PB.Controls.Add(Me.Label43)
        Me.GR_PB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GR_PB.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GR_PB.Location = New System.Drawing.Point(922, 421)
        Me.GR_PB.Name = "GR_PB"
        Me.GR_PB.Size = New System.Drawing.Size(176, 397)
        Me.GR_PB.TabIndex = 219
        Me.GR_PB.TabStop = False
        Me.GR_PB.Text = "PALLET LATO (B) SX"
        Me.GR_PB.Visible = False
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Black
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label24.Location = New System.Drawing.Point(10, 24)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(156, 30)
        Me.Label24.TabIndex = 225
        Me.Label24.Text = "Prelievo OLED SX"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PP_ba
        '
        Me.PP_ba.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PP_ba.Format_num = "0.0"
        Me.PP_ba.Location = New System.Drawing.Point(66, 168)
        Me.PP_ba.Max = 90.0R
        Me.PP_ba.Min = -90.0R
        Me.PP_ba.Msg = False
        Me.PP_ba.Name = "PP_ba"
        Me.PP_ba.Only_Enter = False
        Me.PP_ba.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.PP_ba.Size = New System.Drawing.Size(100, 25)
        Me.PP_ba.TabIndex = 224
        Me.PP_ba.Tag = "294"
        Me.PP_ba.Test_si = False
        Me.PP_ba.Text = "0,0"
        Me.PP_ba.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PP_ba.Value = 0R
        '
        'PP_bz
        '
        Me.PP_bz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PP_bz.Format_num = "0.0"
        Me.PP_bz.Location = New System.Drawing.Point(66, 134)
        Me.PP_bz.Max = 15.0R
        Me.PP_bz.Min = -15.0R
        Me.PP_bz.Msg = False
        Me.PP_bz.Name = "PP_bz"
        Me.PP_bz.Only_Enter = False
        Me.PP_bz.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.PP_bz.Size = New System.Drawing.Size(100, 25)
        Me.PP_bz.TabIndex = 223
        Me.PP_bz.Tag = "292"
        Me.PP_bz.Test_si = False
        Me.PP_bz.Text = "0,0"
        Me.PP_bz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PP_bz.Value = 0R
        '
        'PP_by
        '
        Me.PP_by.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PP_by.Format_num = "0.0"
        Me.PP_by.Location = New System.Drawing.Point(66, 100)
        Me.PP_by.Max = 15.0R
        Me.PP_by.Min = -15.0R
        Me.PP_by.Msg = False
        Me.PP_by.Name = "PP_by"
        Me.PP_by.Only_Enter = False
        Me.PP_by.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.PP_by.Size = New System.Drawing.Size(100, 25)
        Me.PP_by.TabIndex = 222
        Me.PP_by.Tag = "290"
        Me.PP_by.Test_si = False
        Me.PP_by.Text = "0,0"
        Me.PP_by.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PP_by.Value = 0R
        '
        'PP_bx
        '
        Me.PP_bx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PP_bx.Format_num = "0.0"
        Me.PP_bx.Location = New System.Drawing.Point(66, 66)
        Me.PP_bx.Max = 15.0R
        Me.PP_bx.Min = -15.0R
        Me.PP_bx.Msg = False
        Me.PP_bx.Name = "PP_bx"
        Me.PP_bx.Only_Enter = False
        Me.PP_bx.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.PP_bx.Size = New System.Drawing.Size(100, 25)
        Me.PP_bx.TabIndex = 221
        Me.PP_bx.Tag = "288"
        Me.PP_bx.Test_si = False
        Me.PP_bx.Text = "0,0"
        Me.PP_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PP_bx.Value = 0R
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Black
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label25.Location = New System.Drawing.Point(10, 133)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(50, 25)
        Me.Label25.TabIndex = 220
        Me.Label25.Text = "Z"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Black
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label26.Location = New System.Drawing.Point(10, 167)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(50, 25)
        Me.Label26.TabIndex = 219
        Me.Label26.Text = "A"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Black
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label27.Location = New System.Drawing.Point(10, 99)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(50, 25)
        Me.Label27.TabIndex = 218
        Me.Label27.Text = "Y"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Black
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label28.Location = New System.Drawing.Point(10, 65)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(50, 25)
        Me.Label28.TabIndex = 217
        Me.Label28.Text = "X"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.Black
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label39.Location = New System.Drawing.Point(10, 220)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(156, 30)
        Me.Label39.TabIndex = 215
        Me.Label39.Text = "Prelievo OLED DX"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PD_ba
        '
        Me.PD_ba.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PD_ba.Format_num = "0.0"
        Me.PD_ba.Location = New System.Drawing.Point(66, 363)
        Me.PD_ba.Max = 90.0R
        Me.PD_ba.Min = -90.0R
        Me.PD_ba.Msg = False
        Me.PD_ba.Name = "PD_ba"
        Me.PD_ba.Only_Enter = False
        Me.PD_ba.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.PD_ba.Size = New System.Drawing.Size(100, 25)
        Me.PD_ba.TabIndex = 214
        Me.PD_ba.Tag = "302"
        Me.PD_ba.Test_si = False
        Me.PD_ba.Text = "0,0"
        Me.PD_ba.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PD_ba.Value = 0R
        '
        'PD_bz
        '
        Me.PD_bz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PD_bz.Format_num = "0.0"
        Me.PD_bz.Location = New System.Drawing.Point(66, 329)
        Me.PD_bz.Max = 15.0R
        Me.PD_bz.Min = -15.0R
        Me.PD_bz.Msg = False
        Me.PD_bz.Name = "PD_bz"
        Me.PD_bz.Only_Enter = False
        Me.PD_bz.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.PD_bz.Size = New System.Drawing.Size(100, 25)
        Me.PD_bz.TabIndex = 213
        Me.PD_bz.Tag = "300"
        Me.PD_bz.Test_si = False
        Me.PD_bz.Text = "0,0"
        Me.PD_bz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PD_bz.Value = 0R
        '
        'PD_by
        '
        Me.PD_by.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PD_by.Format_num = "0.0"
        Me.PD_by.Location = New System.Drawing.Point(66, 298)
        Me.PD_by.Max = 15.0R
        Me.PD_by.Min = -15.0R
        Me.PD_by.Msg = False
        Me.PD_by.Name = "PD_by"
        Me.PD_by.Only_Enter = False
        Me.PD_by.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.PD_by.Size = New System.Drawing.Size(100, 25)
        Me.PD_by.TabIndex = 212
        Me.PD_by.Tag = "298"
        Me.PD_by.Test_si = False
        Me.PD_by.Text = "0,0"
        Me.PD_by.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PD_by.Value = 0R
        '
        'PD_bx
        '
        Me.PD_bx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PD_bx.Format_num = "0.0"
        Me.PD_bx.Location = New System.Drawing.Point(66, 266)
        Me.PD_bx.Max = 15.0R
        Me.PD_bx.Min = -15.0R
        Me.PD_bx.Msg = False
        Me.PD_bx.Name = "PD_bx"
        Me.PD_bx.Only_Enter = False
        Me.PD_bx.Orig_Bk_Color = System.Drawing.Color.Empty
        Me.PD_bx.Size = New System.Drawing.Size(100, 25)
        Me.PD_bx.TabIndex = 211
        Me.PD_bx.Tag = "296"
        Me.PD_bx.Test_si = False
        Me.PD_bx.Text = "0,0"
        Me.PD_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PD_bx.Value = 0R
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Black
        Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label40.Location = New System.Drawing.Point(10, 330)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(50, 25)
        Me.Label40.TabIndex = 180
        Me.Label40.Text = "Z"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Black
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label41.Location = New System.Drawing.Point(10, 364)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(50, 25)
        Me.Label41.TabIndex = 178
        Me.Label41.Text = "A"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Black
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label42.Location = New System.Drawing.Point(10, 298)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(50, 25)
        Me.Label42.TabIndex = 176
        Me.Label42.Text = "Y"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Black
        Me.Label43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label43.Location = New System.Drawing.Point(10, 266)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(50, 25)
        Me.Label43.TabIndex = 174
        Me.Label43.Text = "X"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Gr_Miss_Mano
        '
        Me.Gr_Miss_Mano.Controls.Add(Me.L_Act_Mano)
        Me.Gr_Miss_Mano.Controls.Add(Me.L_req_Mano)
        Me.Gr_Miss_Mano.Controls.Add(Me.Label48)
        Me.Gr_Miss_Mano.Controls.Add(Me.Label47)
        Me.Gr_Miss_Mano.Controls.Add(Me.B_Prel)
        Me.Gr_Miss_Mano.Controls.Add(Me.B_Depos)
        Me.Gr_Miss_Mano.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gr_Miss_Mano.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Gr_Miss_Mano.Location = New System.Drawing.Point(12, 222)
        Me.Gr_Miss_Mano.Name = "Gr_Miss_Mano"
        Me.Gr_Miss_Mano.Size = New System.Drawing.Size(351, 174)
        Me.Gr_Miss_Mano.TabIndex = 220
        Me.Gr_Miss_Mano.TabStop = False
        Me.Gr_Miss_Mano.Text = "MANO DI PRESA"
        '
        'L_Act_Mano
        '
        Me.L_Act_Mano.BackColor = System.Drawing.Color.LightGray
        Me.L_Act_Mano.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_Act_Mano.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Act_Mano.ForeColor = System.Drawing.Color.Blue
        Me.L_Act_Mano.Location = New System.Drawing.Point(196, 58)
        Me.L_Act_Mano.Name = "L_Act_Mano"
        Me.L_Act_Mano.Size = New System.Drawing.Size(139, 25)
        Me.L_Act_Mano.TabIndex = 210
        Me.L_Act_Mano.Text = "###"
        Me.L_Act_Mano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_req_Mano
        '
        Me.L_req_Mano.BackColor = System.Drawing.Color.LightGray
        Me.L_req_Mano.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_req_Mano.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_req_Mano.ForeColor = System.Drawing.Color.Blue
        Me.L_req_Mano.Location = New System.Drawing.Point(15, 56)
        Me.L_req_Mano.Name = "L_req_Mano"
        Me.L_req_Mano.Size = New System.Drawing.Size(139, 25)
        Me.L_req_Mano.TabIndex = 209
        Me.L_req_Mano.Text = "###"
        Me.L_req_Mano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.Black
        Me.Label48.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label48.Location = New System.Drawing.Point(196, 26)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(139, 25)
        Me.Label48.TabIndex = 208
        Me.Label48.Text = "Attuale"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.Black
        Me.Label47.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label47.Location = New System.Drawing.Point(15, 24)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(139, 25)
        Me.Label47.TabIndex = 207
        Me.Label47.Text = "Richiesta"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'B_Prel
        '
        Me.B_Prel.BackColor = System.Drawing.Color.Gainsboro
        Me.B_Prel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Prel.ForeColor = System.Drawing.Color.Black
        Me.B_Prel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.B_Prel.ImageKey = "Windows-Restart-icon.png"
        Me.B_Prel.ImageList = Me.ImageList2
        Me.B_Prel.Location = New System.Drawing.Point(196, 97)
        Me.B_Prel.Name = "B_Prel"
        Me.B_Prel.Size = New System.Drawing.Size(139, 68)
        Me.B_Prel.TabIndex = 198
        Me.B_Prel.Text = "PRELIEVO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   MANO"
        Me.B_Prel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_Prel.UseVisualStyleBackColor = False
        '
        'B_Depos
        '
        Me.B_Depos.BackColor = System.Drawing.Color.Gainsboro
        Me.B_Depos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Depos.ForeColor = System.Drawing.Color.Black
        Me.B_Depos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.B_Depos.ImageKey = "Windows-Restart-icon.png"
        Me.B_Depos.ImageList = Me.ImageList2
        Me.B_Depos.Location = New System.Drawing.Point(15, 97)
        Me.B_Depos.Name = "B_Depos"
        Me.B_Depos.Size = New System.Drawing.Size(139, 68)
        Me.B_Depos.TabIndex = 197
        Me.B_Depos.Text = "DEPOSITO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   MANO"
        Me.B_Depos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_Depos.UseVisualStyleBackColor = False
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Black
        Me.Label44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(1160, 328)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(50, 25)
        Me.Label44.TabIndex = 226
        Me.Label44.Text = "Z"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label44.Visible = False
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.Black
        Me.Label45.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.White
        Me.Label45.Location = New System.Drawing.Point(1315, 538)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(50, 25)
        Me.Label45.TabIndex = 227
        Me.Label45.Text = "X"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label45.Visible = False
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.Black
        Me.Label46.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.Location = New System.Drawing.Point(1293, 404)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(50, 25)
        Me.Label46.TabIndex = 228
        Me.Label46.Text = "Y"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label46.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label53)
        Me.GroupBox2.Controls.Add(Me.Label52)
        Me.GroupBox2.Controls.Add(Me.Label50)
        Me.GroupBox2.Controls.Add(Me.Label49)
        Me.GroupBox2.Controls.Add(Me.Sts0)
        Me.GroupBox2.Controls.Add(Me.Sts1)
        Me.GroupBox2.Controls.Add(Me.Sts2)
        Me.GroupBox2.Controls.Add(Me.Sts4)
        Me.GroupBox2.Controls.Add(Me.Sts5)
        Me.GroupBox2.Controls.Add(Me.Sts6)
        Me.GroupBox2.Controls.Add(Me.Ctr0)
        Me.GroupBox2.Controls.Add(Me.Ctr1)
        Me.GroupBox2.Controls.Add(Me.Ctr2)
        Me.GroupBox2.Controls.Add(Me.Ctr4)
        Me.GroupBox2.Controls.Add(Me.Ctr5)
        Me.GroupBox2.Controls.Add(Me.Ctr6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Location = New System.Drawing.Point(12, 403)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(351, 295)
        Me.GroupBox2.TabIndex = 231
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MISSIONI MANUALI"
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Black
        Me.Label53.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label53.Location = New System.Drawing.Point(181, 155)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(160, 25)
        Me.Label53.TabIndex = 230
        Me.Label53.Text = "Magazzino DX (B)"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Black
        Me.Label52.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label52.Location = New System.Drawing.Point(6, 154)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(160, 25)
        Me.Label52.TabIndex = 229
        Me.Label52.Text = "Magazzino SX (A)"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Black
        Me.Label50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label50.Location = New System.Drawing.Point(181, 17)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(160, 25)
        Me.Label50.TabIndex = 227
        Me.Label50.Text = "Nastro DX"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.Black
        Me.Label49.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label49.Location = New System.Drawing.Point(6, 17)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(160, 25)
        Me.Label49.TabIndex = 226
        Me.Label49.Text = "Nastro SX"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Sts0
        '
        Me.Sts0.BackColor = System.Drawing.Color.LightGray
        Me.Sts0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Sts0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sts0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Sts0.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Sts0.ImageIndex = 0
        Me.Sts0.ImageList = Me.ImageList1
        Me.Sts0.Location = New System.Drawing.Point(6, 48)
        Me.Sts0.Name = "Sts0"
        Me.Sts0.Size = New System.Drawing.Size(160, 25)
        Me.Sts0.TabIndex = 157
        Me.Sts0.Text = "PREL SUPPORTO"
        Me.Sts0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sts1
        '
        Me.Sts1.BackColor = System.Drawing.Color.LightGray
        Me.Sts1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Sts1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sts1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Sts1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Sts1.ImageIndex = 0
        Me.Sts1.ImageList = Me.ImageList1
        Me.Sts1.Location = New System.Drawing.Point(6, 82)
        Me.Sts1.Name = "Sts1"
        Me.Sts1.Size = New System.Drawing.Size(160, 25)
        Me.Sts1.TabIndex = 158
        Me.Sts1.Text = "BIAD. SUPPORTO"
        Me.Sts1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sts2
        '
        Me.Sts2.BackColor = System.Drawing.Color.LightGray
        Me.Sts2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Sts2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sts2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Sts2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Sts2.ImageIndex = 0
        Me.Sts2.ImageList = Me.ImageList1
        Me.Sts2.Location = New System.Drawing.Point(6, 118)
        Me.Sts2.Name = "Sts2"
        Me.Sts2.Size = New System.Drawing.Size(160, 25)
        Me.Sts2.TabIndex = 159
        Me.Sts2.Text = "DEPOSITA"
        Me.Sts2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sts4
        '
        Me.Sts4.BackColor = System.Drawing.Color.LightGray
        Me.Sts4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Sts4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sts4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Sts4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Sts4.ImageIndex = 0
        Me.Sts4.ImageList = Me.ImageList1
        Me.Sts4.Location = New System.Drawing.Point(6, 185)
        Me.Sts4.Name = "Sts4"
        Me.Sts4.Size = New System.Drawing.Size(160, 25)
        Me.Sts4.TabIndex = 161
        Me.Sts4.Text = "PREL OLED SX"
        Me.Sts4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sts5
        '
        Me.Sts5.BackColor = System.Drawing.Color.LightGray
        Me.Sts5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Sts5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sts5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Sts5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Sts5.ImageIndex = 0
        Me.Sts5.ImageList = Me.ImageList1
        Me.Sts5.Location = New System.Drawing.Point(6, 220)
        Me.Sts5.Name = "Sts5"
        Me.Sts5.Size = New System.Drawing.Size(160, 25)
        Me.Sts5.TabIndex = 162
        Me.Sts5.Text = "PREL OLED DX"
        Me.Sts5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sts6
        '
        Me.Sts6.BackColor = System.Drawing.Color.LightGray
        Me.Sts6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Sts6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sts6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Sts6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Sts6.ImageIndex = 0
        Me.Sts6.ImageList = Me.ImageList1
        Me.Sts6.Location = New System.Drawing.Point(6, 255)
        Me.Sts6.Name = "Sts6"
        Me.Sts6.Size = New System.Drawing.Size(160, 25)
        Me.Sts6.TabIndex = 165
        Me.Sts6.Text = "PREL VASSOIO"
        Me.Sts6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ctr0
        '
        Me.Ctr0.BackColor = System.Drawing.Color.LightGray
        Me.Ctr0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Ctr0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctr0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Ctr0.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ctr0.ImageIndex = 0
        Me.Ctr0.ImageList = Me.ImageList1
        Me.Ctr0.Location = New System.Drawing.Point(181, 48)
        Me.Ctr0.Name = "Ctr0"
        Me.Ctr0.Size = New System.Drawing.Size(160, 25)
        Me.Ctr0.TabIndex = 168
        Me.Ctr0.Text = "PREL SUPPORTO"
        Me.Ctr0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ctr1
        '
        Me.Ctr1.BackColor = System.Drawing.Color.LightGray
        Me.Ctr1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Ctr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctr1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Ctr1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ctr1.ImageIndex = 0
        Me.Ctr1.ImageList = Me.ImageList1
        Me.Ctr1.Location = New System.Drawing.Point(181, 83)
        Me.Ctr1.Name = "Ctr1"
        Me.Ctr1.Size = New System.Drawing.Size(160, 25)
        Me.Ctr1.TabIndex = 169
        Me.Ctr1.Text = "BIAD. SUPPORTO"
        Me.Ctr1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ctr2
        '
        Me.Ctr2.BackColor = System.Drawing.Color.LightGray
        Me.Ctr2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Ctr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctr2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Ctr2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ctr2.ImageIndex = 0
        Me.Ctr2.ImageList = Me.ImageList1
        Me.Ctr2.Location = New System.Drawing.Point(181, 118)
        Me.Ctr2.Name = "Ctr2"
        Me.Ctr2.Size = New System.Drawing.Size(160, 25)
        Me.Ctr2.TabIndex = 170
        Me.Ctr2.Text = "DEPOSITA"
        Me.Ctr2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ctr4
        '
        Me.Ctr4.BackColor = System.Drawing.Color.LightGray
        Me.Ctr4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Ctr4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctr4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Ctr4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ctr4.ImageIndex = 0
        Me.Ctr4.ImageList = Me.ImageList1
        Me.Ctr4.Location = New System.Drawing.Point(181, 185)
        Me.Ctr4.Name = "Ctr4"
        Me.Ctr4.Size = New System.Drawing.Size(160, 25)
        Me.Ctr4.TabIndex = 172
        Me.Ctr4.Text = "PREL OLED SX"
        Me.Ctr4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ctr5
        '
        Me.Ctr5.BackColor = System.Drawing.Color.LightGray
        Me.Ctr5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Ctr5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctr5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Ctr5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ctr5.ImageIndex = 0
        Me.Ctr5.ImageList = Me.ImageList1
        Me.Ctr5.Location = New System.Drawing.Point(181, 220)
        Me.Ctr5.Name = "Ctr5"
        Me.Ctr5.Size = New System.Drawing.Size(160, 25)
        Me.Ctr5.TabIndex = 173
        Me.Ctr5.Text = "PREL OLED DX"
        Me.Ctr5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ctr6
        '
        Me.Ctr6.BackColor = System.Drawing.Color.LightGray
        Me.Ctr6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Ctr6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctr6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Ctr6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ctr6.ImageIndex = 0
        Me.Ctr6.ImageList = Me.ImageList1
        Me.Ctr6.Location = New System.Drawing.Point(181, 255)
        Me.Ctr6.Name = "Ctr6"
        Me.Ctr6.Size = New System.Drawing.Size(160, 25)
        Me.Ctr6.TabIndex = 174
        Me.Ctr6.Text = "PREL VASSOIO"
        Me.Ctr6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label55)
        Me.GroupBox3.Controls.Add(Me.Label56)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Location = New System.Drawing.Point(369, 578)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(351, 120)
        Me.GroupBox3.TabIndex = 232
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MISSIONI MANUALI SCARTI"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.ImageIndex = 0
        Me.Label2.ImageList = Me.ImageList1
        Me.Label2.Location = New System.Drawing.Point(14, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 25)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "DEP SCARTO P1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.LightGray
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.ImageIndex = 0
        Me.Label9.ImageList = Me.ImageList1
        Me.Label9.Location = New System.Drawing.Point(14, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 25)
        Me.Label9.TabIndex = 158
        Me.Label9.Text = "DEP SCARTO P3"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.LightGray
        Me.Label55.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label55.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label55.ImageIndex = 0
        Me.Label55.ImageList = Me.ImageList1
        Me.Label55.Location = New System.Drawing.Point(179, 24)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(160, 25)
        Me.Label55.TabIndex = 168
        Me.Label55.Text = "DEP SCARTO P2"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.Color.LightGray
        Me.Label56.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label56.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label56.ImageIndex = 0
        Me.Label56.ImageList = Me.ImageList1
        Me.Label56.Location = New System.Drawing.Point(179, 59)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(160, 25)
        Me.Label56.TabIndex = 169
        Me.Label56.Text = "DEP SCARTO P4"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnVaiZonaCamera)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(1674, 487)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(185, 131)
        Me.GroupBox4.TabIndex = 233
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "VAI IN ZONA CAMERA"
        '
        'btnVaiZonaCamera
        '
        Me.btnVaiZonaCamera.BackgroundImage = Global.Controllo.My.Resources.Resources._1489158481_photo
        Me.btnVaiZonaCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVaiZonaCamera.Location = New System.Drawing.Point(42, 21)
        Me.btnVaiZonaCamera.Name = "btnVaiZonaCamera"
        Me.btnVaiZonaCamera.Size = New System.Drawing.Size(104, 104)
        Me.btnVaiZonaCamera.TabIndex = 0
        Me.btnVaiZonaCamera.UseVisualStyleBackColor = True
        '
        'M4s
        '
        Me.M4s.BackColor = System.Drawing.Color.Transparent
        Me.M4s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.M4s.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M4s.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.M4s.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.M4s.ImageIndex = 1
        Me.M4s.ImageList = Me.ImageList1
        Me.M4s.Location = New System.Drawing.Point(1689, 735)
        Me.M4s.Name = "M4s"
        Me.M4s.Size = New System.Drawing.Size(170, 25)
        Me.M4s.TabIndex = 230
        Me.M4s.Text = "Scarto Vis. 4 ORIENT"
        Me.M4s.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'M2s
        '
        Me.M2s.BackColor = System.Drawing.Color.Transparent
        Me.M2s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.M2s.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M2s.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.M2s.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.M2s.ImageIndex = 1
        Me.M2s.ImageList = Me.ImageList1
        Me.M2s.Location = New System.Drawing.Point(1689, 664)
        Me.M2s.Name = "M2s"
        Me.M2s.Size = New System.Drawing.Size(170, 25)
        Me.M2s.TabIndex = 229
        Me.M2s.Text = "Scarto Vis. 2 QUAL"
        Me.M2s.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(1213, 432)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(130, 51)
        Me.PictureBox4.TabIndex = 225
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(1160, 356)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 130)
        Me.PictureBox3.TabIndex = 224
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1235, 485)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 50)
        Me.PictureBox1.TabIndex = 223
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'M2b
        '
        Me.M2b.BackColor = System.Drawing.Color.Transparent
        Me.M2b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.M2b.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M2b.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.M2b.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.M2b.ImageIndex = 0
        Me.M2b.ImageList = Me.ImageList1
        Me.M2b.Location = New System.Drawing.Point(1689, 428)
        Me.M2b.Name = "M2b"
        Me.M2b.Size = New System.Drawing.Size(170, 25)
        Me.M2b.TabIndex = 214
        Me.M2b.Text = "M2-Pres. Assemblato"
        Me.M2b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'M1_Vass
        '
        Me.M1_Vass.BackColor = System.Drawing.Color.Transparent
        Me.M1_Vass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.M1_Vass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M1_Vass.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.M1_Vass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.M1_Vass.ImageIndex = 1
        Me.M1_Vass.ImageList = Me.ImageList1
        Me.M1_Vass.Location = New System.Drawing.Point(1689, 314)
        Me.M1_Vass.Name = "M1_Vass"
        Me.M1_Vass.Size = New System.Drawing.Size(170, 25)
        Me.M1_Vass.TabIndex = 213
        Me.M1_Vass.Text = "M1-Vassoio"
        Me.M1_Vass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'M2a_SX
        '
        Me.M2a_SX.BackColor = System.Drawing.Color.Transparent
        Me.M2a_SX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.M2a_SX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M2a_SX.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.M2a_SX.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.M2a_SX.ImageIndex = 0
        Me.M2a_SX.ImageList = Me.ImageList1
        Me.M2a_SX.Location = New System.Drawing.Point(1689, 348)
        Me.M2a_SX.Name = "M2a_SX"
        Me.M2a_SX.Size = New System.Drawing.Size(170, 25)
        Me.M2a_SX.TabIndex = 187
        Me.M2a_SX.Text = "M2 N-SX -Prel. Supp."
        Me.M2a_SX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'M1s
        '
        Me.M1s.BackColor = System.Drawing.Color.Transparent
        Me.M1s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.M1s.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M1s.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.M1s.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.M1s.ImageIndex = 1
        Me.M1s.ImageList = Me.ImageList1
        Me.M1s.Location = New System.Drawing.Point(1689, 631)
        Me.M1s.Name = "M1s"
        Me.M1s.Size = New System.Drawing.Size(170, 25)
        Me.M1s.TabIndex = 184
        Me.M1s.Text = "Scarto Vis. 1 DM"
        Me.M1s.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'M1b
        '
        Me.M1b.BackColor = System.Drawing.Color.Transparent
        Me.M1b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.M1b.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M1b.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.M1b.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.M1b.ImageIndex = 1
        Me.M1b.ImageList = Me.ImageList1
        Me.M1b.Location = New System.Drawing.Point(1689, 248)
        Me.M1b.Name = "M1b"
        Me.M1b.Size = New System.Drawing.Size(170, 25)
        Me.M1b.TabIndex = 183
        Me.M1b.Text = "M1-B Pres OLED"
        Me.M1b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'M1a
        '
        Me.M1a.BackColor = System.Drawing.Color.Transparent
        Me.M1a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.M1a.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M1a.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.M1a.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.M1a.ImageIndex = 1
        Me.M1a.ImageList = Me.ImageList1
        Me.M1a.Location = New System.Drawing.Point(1689, 181)
        Me.M1a.Name = "M1a"
        Me.M1a.Size = New System.Drawing.Size(170, 25)
        Me.M1a.TabIndex = 182
        Me.M1a.Text = "M1-A Pres. OLED"
        Me.M1a.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'm1A_Vas
        '
        Me.m1A_Vas.BackColor = System.Drawing.Color.Transparent
        Me.m1A_Vas.BackgroundImage = CType(resources.GetObject("m1A_Vas.BackgroundImage"), System.Drawing.Image)
        Me.m1A_Vas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.m1A_Vas.Location = New System.Drawing.Point(1135, 4)
        Me.m1A_Vas.Name = "m1A_Vas"
        Me.m1A_Vas.Size = New System.Drawing.Size(753, 759)
        Me.m1A_Vas.TabIndex = 125
        Me.m1A_Vas.TabStop = False
        '
        'M3s
        '
        Me.M3s.BackColor = System.Drawing.Color.Transparent
        Me.M3s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.M3s.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M3s.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.M3s.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.M3s.ImageIndex = 1
        Me.M3s.ImageList = Me.ImageList1
        Me.M3s.Location = New System.Drawing.Point(1689, 698)
        Me.M3s.Name = "M3s"
        Me.M3s.Size = New System.Drawing.Size(170, 25)
        Me.M3s.TabIndex = 235
        Me.M3s.Text = "Scarto Vis. 3 PRE-OR"
        Me.M3s.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'M1a_Vass
        '
        Me.M1a_Vass.BackColor = System.Drawing.Color.Transparent
        Me.M1a_Vass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.M1a_Vass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M1a_Vass.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.M1a_Vass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.M1a_Vass.ImageIndex = 1
        Me.M1a_Vass.ImageList = Me.ImageList1
        Me.M1a_Vass.Location = New System.Drawing.Point(1689, 210)
        Me.M1a_Vass.Name = "M1a_Vass"
        Me.M1a_Vass.Size = New System.Drawing.Size(170, 25)
        Me.M1a_Vass.TabIndex = 236
        Me.M1a_Vass.Text = "M1-A Pres. VASSOIO"
        Me.M1a_Vass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'M1b_Vass
        '
        Me.M1b_Vass.BackColor = System.Drawing.Color.Transparent
        Me.M1b_Vass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.M1b_Vass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M1b_Vass.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.M1b_Vass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.M1b_Vass.ImageIndex = 1
        Me.M1b_Vass.ImageList = Me.ImageList1
        Me.M1b_Vass.Location = New System.Drawing.Point(1689, 278)
        Me.M1b_Vass.Name = "M1b_Vass"
        Me.M1b_Vass.Size = New System.Drawing.Size(170, 25)
        Me.M1b_Vass.TabIndex = 237
        Me.M1b_Vass.Text = "M1-B Pres. VASSOIO"
        Me.M1b_Vass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'M2a_DX
        '
        Me.M2a_DX.BackColor = System.Drawing.Color.Transparent
        Me.M2a_DX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.M2a_DX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M2a_DX.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.M2a_DX.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.M2a_DX.ImageIndex = 0
        Me.M2a_DX.ImageList = Me.ImageList1
        Me.M2a_DX.Location = New System.Drawing.Point(1689, 380)
        Me.M2a_DX.Name = "M2a_DX"
        Me.M2a_DX.Size = New System.Drawing.Size(170, 25)
        Me.M2a_DX.TabIndex = 238
        Me.M2a_DX.Text = "M2 N-DX -Prel. Supp."
        Me.M2a_DX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMano
        '
        Me.LabelMano.BackColor = System.Drawing.Color.LightGray
        Me.LabelMano.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelMano.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMano.ForeColor = System.Drawing.Color.Blue
        Me.LabelMano.Location = New System.Drawing.Point(184, 108)
        Me.LabelMano.Name = "LabelMano"
        Me.LabelMano.Size = New System.Drawing.Size(179, 25)
        Me.LabelMano.TabIndex = 239
        Me.LabelMano.Text = "###"
        Me.LabelMano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(12, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(240, 25)
        Me.Label5.TabIndex = 240
        Me.Label5.Text = "POS CORRENTE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.Color.LightGray
        Me.Label58.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Blue
        Me.Label58.Location = New System.Drawing.Point(369, 77)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(350, 25)
        Me.Label58.TabIndex = 241
        Me.Label58.Text = "###.##"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.Color.LightGray
        Me.Label59.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.Blue
        Me.Label59.Location = New System.Drawing.Point(258, 76)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(73, 25)
        Me.Label59.TabIndex = 242
        Me.Label59.Text = "###"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.Color.LightGray
        Me.Label60.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Blue
        Me.Label60.Location = New System.Drawing.Point(1409, 784)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(479, 25)
        Me.Label60.TabIndex = 244
        Me.Label60.Text = "SUPPORTO PLASMATO CON BIADESIVO IONIZZATO CON OLED"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label61
        '
        Me.Label61.BackColor = System.Drawing.Color.Black
        Me.Label61.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label61.Location = New System.Drawing.Point(1135, 784)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(268, 25)
        Me.Label61.TabIndex = 243
        Me.Label61.Text = "PRESENZA PEZZO SU ROBOT"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label51)
        Me.GroupBox5.Controls.Add(Me.Label57)
        Me.GroupBox5.Controls.Add(Me.Label54)
        Me.GroupBox5.Controls.Add(Me.Sts3)
        Me.GroupBox5.Controls.Add(Me.Sts7)
        Me.GroupBox5.Controls.Add(Me.Ctr3)
        Me.GroupBox5.Controls.Add(Me.Ctr7)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox5.Location = New System.Drawing.Point(12, 704)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(708, 120)
        Me.GroupBox5.TabIndex = 233
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "MISSIONI MANUALI COMUNI"
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.Color.LightGray
        Me.Label57.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label57.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label57.ImageIndex = 0
        Me.Label57.ImageList = Me.ImageList1
        Me.Label57.Location = New System.Drawing.Point(240, 48)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(230, 25)
        Me.Label57.TabIndex = 239
        Me.Label57.Text = "PREL SCARTO DA INCOLL"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.LightGray
        Me.Label54.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label54.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label54.ImageIndex = 0
        Me.Label54.ImageList = Me.ImageList1
        Me.Label54.Location = New System.Drawing.Point(475, 48)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(230, 25)
        Me.Label54.TabIndex = 238
        Me.Label54.Text = "STRAPPA LINER"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sts3
        '
        Me.Sts3.BackColor = System.Drawing.Color.LightGray
        Me.Sts3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Sts3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sts3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Sts3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Sts3.ImageIndex = 0
        Me.Sts3.ImageList = Me.ImageList1
        Me.Sts3.Location = New System.Drawing.Point(5, 48)
        Me.Sts3.Name = "Sts3"
        Me.Sts3.Size = New System.Drawing.Size(230, 25)
        Me.Sts3.TabIndex = 233
        Me.Sts3.Text = "DEP OLED IN INCOLLAGGIO"
        Me.Sts3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sts7
        '
        Me.Sts7.BackColor = System.Drawing.Color.LightGray
        Me.Sts7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Sts7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sts7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Sts7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Sts7.ImageIndex = 0
        Me.Sts7.ImageList = Me.ImageList1
        Me.Sts7.Location = New System.Drawing.Point(5, 17)
        Me.Sts7.Name = "Sts7"
        Me.Sts7.Size = New System.Drawing.Size(230, 25)
        Me.Sts7.TabIndex = 234
        Me.Sts7.Text = "DEPOSITA VASSOIO VUOTO"
        Me.Sts7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ctr3
        '
        Me.Ctr3.BackColor = System.Drawing.Color.LightGray
        Me.Ctr3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Ctr3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctr3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Ctr3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ctr3.ImageIndex = 0
        Me.Ctr3.ImageList = Me.ImageList1
        Me.Ctr3.Location = New System.Drawing.Point(475, 17)
        Me.Ctr3.Name = "Ctr3"
        Me.Ctr3.Size = New System.Drawing.Size(230, 25)
        Me.Ctr3.TabIndex = 235
        Me.Ctr3.Text = "INCOLLA SUPPORTO"
        Me.Ctr3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ctr7
        '
        Me.Ctr7.BackColor = System.Drawing.Color.LightGray
        Me.Ctr7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Ctr7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctr7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Ctr7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ctr7.ImageIndex = 0
        Me.Ctr7.ImageList = Me.ImageList1
        Me.Ctr7.Location = New System.Drawing.Point(240, 17)
        Me.Ctr7.Name = "Ctr7"
        Me.Ctr7.Size = New System.Drawing.Size(230, 25)
        Me.Ctr7.TabIndex = 236
        Me.Ctr7.Text = "FAI CICLO PLASMATURA"
        Me.Ctr7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.LightGray
        Me.Label51.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label51.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label51.ImageIndex = 0
        Me.Label51.ImageList = Me.ImageList1
        Me.Label51.Location = New System.Drawing.Point(5, 80)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(230, 25)
        Me.Label51.TabIndex = 240
        Me.Label51.Text = "VAI IN IONIZZATURA"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label62
        '
        Me.Label62.BackColor = System.Drawing.Color.LightGray
        Me.Label62.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label62.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label62.ImageIndex = 0
        Me.Label62.ImageList = Me.ImageList1
        Me.Label62.Location = New System.Drawing.Point(12, 179)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(240, 40)
        Me.Label62.TabIndex = 245
        Me.Label62.Text = "RIMOZIONE LINER OLED"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form_Robot
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1900, 830)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label62)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label60)
        Me.Controls.Add(Me.Label61)
        Me.Controls.Add(Me.Label59)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelMano)
        Me.Controls.Add(Me.M2a_DX)
        Me.Controls.Add(Me.M1b_Vass)
        Me.Controls.Add(Me.M1a_Vass)
        Me.Controls.Add(Me.M3s)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.M4s)
        Me.Controls.Add(Me.M2s)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Gr_Miss_Mano)
        Me.Controls.Add(Me.GR_PB)
        Me.Controls.Add(Me.GR_PA)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Gr_Punti)
        Me.Controls.Add(Me.M2b)
        Me.Controls.Add(Me.M1_Vass)
        Me.Controls.Add(Me.M2a_SX)
        Me.Controls.Add(Me.M1s)
        Me.Controls.Add(Me.M1b)
        Me.Controls.Add(Me.M1a)
        Me.Controls.Add(Me.T_Overr)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lab_MagA)
        Me.Controls.Add(Me.Gr_Repos)
        Me.Controls.Add(Me.Gr_Vuoti)
        Me.Controls.Add(Me.Lab_Miss)
        Me.Controls.Add(Me.Lab_All)
        Me.Controls.Add(Me.Lab_Missione)
        Me.Controls.Add(Me.Lab_Act_M)
        Me.Controls.Add(Me.Lab_Allarmi)
        Me.Controls.Add(Me.Lab_Act_aLL)
        Me.Controls.Add(Me.m1A_Vas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Robot"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "-"
        Me.Gr_Vuoti.ResumeLayout(False)
        Me.Gr_Repos.ResumeLayout(False)
        Me.Gr_Punti.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GR_PA.ResumeLayout(False)
        Me.GR_PB.ResumeLayout(False)
        Me.Gr_Miss_Mano.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m1A_Vas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents m1A_Vas As PictureBox
    Friend WithEvents Lab_Act_aLL As Label
    Friend WithEvents Lab_Allarmi As Label
    Friend WithEvents Lab_Missione As Label
    Friend WithEvents Lab_Act_M As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Sts0 As Label
    Friend WithEvents Sts1 As Label
    Friend WithEvents Sts2 As Label
    Friend WithEvents Sts5 As Label
    Friend WithEvents Sts4 As Label
    Friend WithEvents Lab_All As Label
    Friend WithEvents Lab_Miss As Label
    Friend WithEvents Sts6 As Label
    Friend WithEvents Ctr6 As Label
    Friend WithEvents Ctr5 As Label
    Friend WithEvents Ctr4 As Label
    Friend WithEvents Ctr2 As Label
    Friend WithEvents Ctr1 As Label
    Friend WithEvents Ctr0 As Label
    Friend WithEvents Gr_Vuoti As GroupBox
    Friend WithEvents B_v1_Off As Button
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents B_v1_On As Button
    Friend WithEvents Lab_Vuoto1 As Label
    Friend WithEvents B_S1_On As Button
    Friend WithEvents B_S1_Off As Button
    Friend WithEvents Gr_Repos As GroupBox
    Friend WithEvents Lab_MagA As Label
    Friend WithEvents M1a As Label
    Friend WithEvents M1b As Label
    Friend WithEvents M1s As Label
    Friend WithEvents M2a_SX As Label
    Friend WithEvents Lab_Pinza As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents T_Overr As Txt_box.T_box
    Friend WithEvents Lab_Ill1 As Label
    Friend WithEvents B_I1on As Button
    Friend WithEvents B_I1off As Button
    Friend WithEvents Lab_Ill2 As Label
    Friend WithEvents B_I2on As Button
    Friend WithEvents B_I2off As Button
    Friend WithEvents B_PL_ch As Button
    Friend WithEvents B_PL_ap As Button
    Friend WithEvents Lab_pl As Label
    Friend WithEvents M1_Vass As Label
    Friend WithEvents M2b As Label
    Friend WithEvents Gr_Punti As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Lt_a As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Lt_y As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents T_as As Txt_box.T_box
    Friend WithEvents T_zs As Txt_box.T_box
    Friend WithEvents T_ys As Txt_box.T_box
    Friend WithEvents T_xs As Txt_box.T_box
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents T_ao As Txt_box.T_box
    Friend WithEvents T_zo As Txt_box.T_box
    Friend WithEvents T_yo As Txt_box.T_box
    Friend WithEvents T_xo As Txt_box.T_box
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents T_aa As Txt_box.T_box
    Friend WithEvents T_za As Txt_box.T_box
    Friend WithEvents T_ya As Txt_box.T_box
    Friend WithEvents T_xa As Txt_box.T_box
    Friend WithEvents Label6 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents GR_PA As GroupBox
    Friend WithEvents Label29 As Label
    Friend WithEvents PP_aa As Txt_box.T_box
    Friend WithEvents PP_az As Txt_box.T_box
    Friend WithEvents PP_ay As Txt_box.T_box
    Friend WithEvents PP_ax As Txt_box.T_box
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents PD_aa As Txt_box.T_box
    Friend WithEvents PD_az As Txt_box.T_box
    Friend WithEvents PD_ay As Txt_box.T_box
    Friend WithEvents PD_ax As Txt_box.T_box
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents GR_PB As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents PP_ba As Txt_box.T_box
    Friend WithEvents PP_bz As Txt_box.T_box
    Friend WithEvents PP_by As Txt_box.T_box
    Friend WithEvents PP_bx As Txt_box.T_box
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents PD_ba As Txt_box.T_box
    Friend WithEvents PD_bz As Txt_box.T_box
    Friend WithEvents PD_by As Txt_box.T_box
    Friend WithEvents PD_bx As Txt_box.T_box
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Gr_Miss_Mano As GroupBox
    Friend WithEvents B_Prel As Button
    Friend WithEvents B_Depos As Button
    Friend WithEvents Lt_x As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents L_Act_Mano As Label
    Friend WithEvents L_req_Mano As Label
    Friend WithEvents M2s As Label
    Friend WithEvents M4s As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnHome As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnVaiZonaCamera As Button
    Friend WithEvents M3s As Label
    Friend WithEvents M1a_Vass As Label
    Friend WithEvents M1b_Vass As Label
    Friend WithEvents M2a_DX As Label
    Friend WithEvents LabelMano As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label57 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Sts3 As Label
    Friend WithEvents Sts7 As Label
    Friend WithEvents Ctr3 As Label
    Friend WithEvents Ctr7 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label62 As Label
End Class

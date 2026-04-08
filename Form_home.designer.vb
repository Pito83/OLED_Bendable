<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_home))
        Me.TimerClk = New System.Windows.Forms.Timer(Me.components)
        Me.TimerGUI = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.M2s = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.M1s = New System.Windows.Forms.Label()
        Me.M2b = New System.Windows.Forms.Label()
        Me.M2a = New System.Windows.Forms.Label()
        Me.M1_Vass = New System.Windows.Forms.Label()
        Me.M1b = New System.Windows.Forms.Label()
        Me.M1a = New System.Windows.Forms.Label()
        Me.Lab_Par = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Lab_All = New System.Windows.Forms.Label()
        Me.Lab_Miss = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.IOT2 = New System.Windows.Forms.GroupBox()
        Me.L_Descriz = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.L_Versione = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.L_Modello = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.L_Prodotto = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bResetBuoni = New System.Windows.Forms.Button()
        Me.bResetScarti = New System.Windows.Forms.Button()
        Me.ContaPezziScarti = New LBSoft.IndustrialCtrls.Meters.LBDigitalMeter()
        Me.ContaPezziBuoni = New LBSoft.IndustrialCtrls.Meters.LBDigitalMeter()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblManoRobotPress = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblIncollaggioPres = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Lab_Vuo_Oled_Dx = New System.Windows.Forms.Label()
        Me.L_V_Oled_Dx = New System.Windows.Forms.Label()
        Me.Lab_Vuo_Biade_Dx = New System.Windows.Forms.Label()
        Me.L_V_Biade_Dx = New System.Windows.Forms.Label()
        Me.Lab_Vuo_Supp_Dx = New System.Windows.Forms.Label()
        Me.L_V_Supp_Dx = New System.Windows.Forms.Label()
        Me.Lab_Vuo_Oled_Sx = New System.Windows.Forms.Label()
        Me.L_V_Oled_Sx = New System.Windows.Forms.Label()
        Me.Lab_Vuo_Biade_Sx = New System.Windows.Forms.Label()
        Me.L_V_Biade_Sx = New System.Windows.Forms.Label()
        Me.Lab_Vuo_Supp_Sx = New System.Windows.Forms.Label()
        Me.L_V_Supp_Sx = New System.Windows.Forms.Label()
        Me.Lab_Vuo_Frame_Dx = New System.Windows.Forms.Label()
        Me.L_V_Frame_Dx = New System.Windows.Forms.Label()
        Me.Lab_Vuo_Frame_Sx = New System.Windows.Forms.Label()
        Me.L_V_Frame_Sx = New System.Windows.Forms.Label()
        Me.Cyc_Ps_Sx = New System.Windows.Forms.Label()
        Me.Cyc_Ps_Dx = New System.Windows.Forms.Label()
        Me.L_PosaggioDx = New System.Windows.Forms.Label()
        Me.P_PsSx_Supp = New System.Windows.Forms.Label()
        Me.P_PsSx_Oled = New System.Windows.Forms.Label()
        Me.P_PsDx_Supp = New System.Windows.Forms.Label()
        Me.P_PsDx_Oled = New System.Windows.Forms.Label()
        Me.L_PosaggioSx = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.LedScarto1 = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.LedScarto2 = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.LedScarto3 = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.LedScarto4 = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.LabScarto1 = New System.Windows.Forms.Label()
        Me.LabScarto2 = New System.Windows.Forms.Label()
        Me.LabScarto3 = New System.Windows.Forms.Label()
        Me.LabScarto4 = New System.Windows.Forms.Label()
        Me.lblPlasmaturaOn = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.lblAllNastri = New System.Windows.Forms.Label()
        Me.lblVuotoIncollaggioDx = New System.Windows.Forms.Label()
        Me.lblVuotoIncollaggioSx = New System.Windows.Forms.Label()
        Me.btnDXReadReq = New System.Windows.Forms.Button()
        Me.btnSXReadReq = New System.Windows.Forms.Button()
        Me.LbLed_OledIncollaggio = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lblIncollaggioCodicePosaggio = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LbLed7 = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LbLed4 = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LbLed5 = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.LbLed6 = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.LabelPresenzaB = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelPresenzaA = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.L_MB_Dentro = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.L_MA_Dentro = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.L_Cod_Sx = New System.Windows.Forms.Label()
        Me.L_Cod_Dx = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbLed3 = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbLed1 = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.LbLed2 = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.Lab_Scarti = New System.Windows.Forms.Label()
        Me.L_All_StAvvitatura = New System.Windows.Forms.Label()
        Me.LabNDx = New System.Windows.Forms.Label()
        Me.LabNSx = New System.Windows.Forms.Label()
        Me.Pr_StFuoriSx = New System.Windows.Forms.Label()
        Me.Pr_StFuoriDx = New System.Windows.Forms.Label()
        Me.L_All_Plasmatura = New System.Windows.Forms.Label()
        Me.L_All_Mag = New System.Windows.Forms.Label()
        Me.L_MB_Fuori = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.L_All_Rob = New System.Windows.Forms.Label()
        Me.L_MA_Fuori = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.L_Barr = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.lblLetturaDatamatrixPCB = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.IOT2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerClk
        '
        Me.TimerClk.Interval = 500
        '
        'TimerGUI
        '
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "1434568607_Arrow-Right.png")
        Me.ImageList2.Images.SetKeyName(1, "1434568607_Arrow-Right - Copia.png")
        Me.ImageList2.Images.SetKeyName(2, "warning_35.png")
        Me.ImageList2.Images.SetKeyName(3, "gnome-session-switch.png")
        Me.ImageList2.Images.SetKeyName(4, "1429107604_Check.png")
        Me.ImageList2.Images.SetKeyName(5, "LQG.png")
        '
        'ImageList3
        '
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList3.Images.SetKeyName(0, "LQV.png")
        Me.ImageList3.Images.SetKeyName(1, "LQG.png")
        Me.ImageList3.Images.SetKeyName(2, "LQR.png")
        Me.ImageList3.Images.SetKeyName(3, "LQB.png")
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.M2s)
        Me.GroupBox1.Controls.Add(Me.M1s)
        Me.GroupBox1.Controls.Add(Me.M2b)
        Me.GroupBox1.Controls.Add(Me.M2a)
        Me.GroupBox1.Controls.Add(Me.M1_Vass)
        Me.GroupBox1.Controls.Add(Me.M1b)
        Me.GroupBox1.Controls.Add(Me.M1a)
        Me.GroupBox1.Controls.Add(Me.Lab_Par)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Lab_All)
        Me.GroupBox1.Controls.Add(Me.Lab_Miss)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(1467, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 283)
        Me.GroupBox1.TabIndex = 188
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ROBOT"
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
        Me.M2s.Location = New System.Drawing.Point(200, 242)
        Me.M2s.Name = "M2s"
        Me.M2s.Size = New System.Drawing.Size(170, 25)
        Me.M2s.TabIndex = 231
        Me.M2s.Text = "Scarto Vis. 2 OLED"
        Me.M2s.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Led_V.png")
        Me.ImageList1.Images.SetKeyName(1, "Led_G.png")
        Me.ImageList1.Images.SetKeyName(2, "Led_R.png")
        Me.ImageList1.Images.SetKeyName(3, "Led_Ar.png")
        Me.ImageList1.Images.SetKeyName(4, "5.png")
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
        Me.M1s.Location = New System.Drawing.Point(16, 242)
        Me.M1s.Name = "M1s"
        Me.M1s.Size = New System.Drawing.Size(170, 25)
        Me.M1s.TabIndex = 230
        Me.M1s.Text = "Scarto Vis. 1 OLED"
        Me.M1s.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.M2b.Location = New System.Drawing.Point(200, 159)
        Me.M2b.Name = "M2b"
        Me.M2b.Size = New System.Drawing.Size(170, 25)
        Me.M2b.TabIndex = 225
        Me.M2b.Text = "M2-Pres. Assemblato"
        Me.M2b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'M2a
        '
        Me.M2a.BackColor = System.Drawing.Color.Transparent
        Me.M2a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.M2a.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M2a.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.M2a.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.M2a.ImageIndex = 0
        Me.M2a.ImageList = Me.ImageList1
        Me.M2a.Location = New System.Drawing.Point(200, 123)
        Me.M2a.Name = "M2a"
        Me.M2a.Size = New System.Drawing.Size(170, 25)
        Me.M2a.TabIndex = 224
        Me.M2a.Text = "M2-Pres. Supporto"
        Me.M2a.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.M1_Vass.Location = New System.Drawing.Point(16, 198)
        Me.M1_Vass.Name = "M1_Vass"
        Me.M1_Vass.Size = New System.Drawing.Size(170, 25)
        Me.M1_Vass.TabIndex = 223
        Me.M1_Vass.Text = "M1-Vassoio"
        Me.M1_Vass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.M1b.Location = New System.Drawing.Point(16, 159)
        Me.M1b.Name = "M1b"
        Me.M1b.Size = New System.Drawing.Size(170, 25)
        Me.M1b.TabIndex = 222
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
        Me.M1a.Location = New System.Drawing.Point(16, 123)
        Me.M1a.Name = "M1a"
        Me.M1a.Size = New System.Drawing.Size(170, 25)
        Me.M1a.TabIndex = 221
        Me.M1a.Text = "M1-A Pres. OLED"
        Me.M1a.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lab_Par
        '
        Me.Lab_Par.BackColor = System.Drawing.Color.DimGray
        Me.Lab_Par.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_Par.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Par.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lab_Par.Location = New System.Drawing.Point(142, 72)
        Me.Lab_Par.Name = "Lab_Par"
        Me.Lab_Par.Size = New System.Drawing.Size(40, 30)
        Me.Lab_Par.TabIndex = 192
        Me.Lab_Par.Text = "###"
        Me.Lab_Par.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_Par.Visible = False
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label27.Location = New System.Drawing.Point(16, 72)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(120, 30)
        Me.Label27.TabIndex = 191
        Me.Label27.Text = "Magazzino"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label27.Visible = False
        '
        'Lab_All
        '
        Me.Lab_All.BackColor = System.Drawing.Color.DimGray
        Me.Lab_All.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_All.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_All.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lab_All.Location = New System.Drawing.Point(330, 33)
        Me.Lab_All.Name = "Lab_All"
        Me.Lab_All.Size = New System.Drawing.Size(40, 30)
        Me.Lab_All.TabIndex = 190
        Me.Lab_All.Text = "##"
        Me.Lab_All.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_Miss
        '
        Me.Lab_Miss.BackColor = System.Drawing.Color.DimGray
        Me.Lab_Miss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_Miss.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Miss.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lab_Miss.Location = New System.Drawing.Point(142, 33)
        Me.Lab_Miss.Name = "Lab_Miss"
        Me.Lab_Miss.Size = New System.Drawing.Size(40, 30)
        Me.Lab_Miss.TabIndex = 189
        Me.Lab_Miss.Text = "##"
        Me.Lab_Miss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label14.Location = New System.Drawing.Point(204, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 30)
        Me.Label14.TabIndex = 188
        Me.Label14.Text = "Allarmi attivi"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Location = New System.Drawing.Point(16, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 30)
        Me.Label13.TabIndex = 187
        Me.Label13.Text = "Missione"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IOT2
        '
        Me.IOT2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IOT2.Controls.Add(Me.L_Descriz)
        Me.IOT2.Controls.Add(Me.Label9)
        Me.IOT2.Controls.Add(Me.L_Versione)
        Me.IOT2.Controls.Add(Me.Label11)
        Me.IOT2.Controls.Add(Me.L_Modello)
        Me.IOT2.Controls.Add(Me.Label6)
        Me.IOT2.Controls.Add(Me.L_Prodotto)
        Me.IOT2.Controls.Add(Me.Label24)
        Me.IOT2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IOT2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.IOT2.Location = New System.Drawing.Point(12, 12)
        Me.IOT2.Name = "IOT2"
        Me.IOT2.Size = New System.Drawing.Size(269, 359)
        Me.IOT2.TabIndex = 226
        Me.IOT2.TabStop = False
        Me.IOT2.Text = "ORDINE PRODUZIONE"
        '
        'L_Descriz
        '
        Me.L_Descriz.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.L_Descriz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Descriz.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Descriz.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.L_Descriz.Location = New System.Drawing.Point(11, 307)
        Me.L_Descriz.Name = "L_Descriz"
        Me.L_Descriz.Size = New System.Drawing.Size(238, 30)
        Me.L_Descriz.TabIndex = 215
        Me.L_Descriz.Text = "######"
        Me.L_Descriz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Navy
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(11, 273)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(238, 30)
        Me.Label9.TabIndex = 214
        Me.Label9.Text = "Descrizione"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_Versione
        '
        Me.L_Versione.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.L_Versione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Versione.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Versione.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.L_Versione.Location = New System.Drawing.Point(11, 135)
        Me.L_Versione.Name = "L_Versione"
        Me.L_Versione.Size = New System.Drawing.Size(238, 30)
        Me.L_Versione.TabIndex = 213
        Me.L_Versione.Text = "######"
        Me.L_Versione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Navy
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(11, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(238, 30)
        Me.Label11.TabIndex = 212
        Me.Label11.Text = "Versione"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_Modello
        '
        Me.L_Modello.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.L_Modello.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Modello.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Modello.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.L_Modello.Location = New System.Drawing.Point(11, 58)
        Me.L_Modello.Name = "L_Modello"
        Me.L_Modello.Size = New System.Drawing.Size(238, 30)
        Me.L_Modello.TabIndex = 211
        Me.L_Modello.Text = "######"
        Me.L_Modello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Navy
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(11, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(238, 30)
        Me.Label6.TabIndex = 210
        Me.Label6.Text = "Modello"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_Prodotto
        '
        Me.L_Prodotto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.L_Prodotto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Prodotto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Prodotto.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.L_Prodotto.Location = New System.Drawing.Point(11, 242)
        Me.L_Prodotto.Name = "L_Prodotto"
        Me.L_Prodotto.Size = New System.Drawing.Size(238, 30)
        Me.L_Prodotto.TabIndex = 199
        Me.L_Prodotto.Text = "######"
        Me.L_Prodotto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Navy
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label24.Location = New System.Drawing.Point(11, 208)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(238, 30)
        Me.Label24.TabIndex = 198
        Me.Label24.Text = "Prodotto"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.bResetBuoni)
        Me.GroupBox2.Controls.Add(Me.bResetScarti)
        Me.GroupBox2.Controls.Add(Me.ContaPezziScarti)
        Me.GroupBox2.Controls.Add(Me.ContaPezziBuoni)
        Me.GroupBox2.Controls.Add(Me.Label40)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Location = New System.Drawing.Point(12, 377)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 441)
        Me.GroupBox2.TabIndex = 227
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Valori produzione"
        '
        'bResetBuoni
        '
        Me.bResetBuoni.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bResetBuoni.BackgroundImage = CType(resources.GetObject("bResetBuoni.BackgroundImage"), System.Drawing.Image)
        Me.bResetBuoni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bResetBuoni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bResetBuoni.Location = New System.Drawing.Point(89, 129)
        Me.bResetBuoni.Name = "bResetBuoni"
        Me.bResetBuoni.Size = New System.Drawing.Size(90, 80)
        Me.bResetBuoni.TabIndex = 246
        Me.bResetBuoni.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bResetBuoni.UseVisualStyleBackColor = False
        Me.bResetBuoni.Visible = False
        '
        'bResetScarti
        '
        Me.bResetScarti.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bResetScarti.BackgroundImage = CType(resources.GetObject("bResetScarti.BackgroundImage"), System.Drawing.Image)
        Me.bResetScarti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bResetScarti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bResetScarti.Location = New System.Drawing.Point(89, 338)
        Me.bResetScarti.Name = "bResetScarti"
        Me.bResetScarti.Size = New System.Drawing.Size(90, 80)
        Me.bResetScarti.TabIndex = 245
        Me.bResetScarti.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bResetScarti.UseVisualStyleBackColor = False
        Me.bResetScarti.Visible = False
        '
        'ContaPezziScarti
        '
        Me.ContaPezziScarti.BackColor = System.Drawing.Color.Black
        Me.ContaPezziScarti.Format = "000000"
        Me.ContaPezziScarti.Location = New System.Drawing.Point(11, 273)
        Me.ContaPezziScarti.Name = "ContaPezziScarti"
        Me.ContaPezziScarti.Renderer = Nothing
        Me.ContaPezziScarti.Signed = False
        Me.ContaPezziScarti.Size = New System.Drawing.Size(238, 56)
        Me.ContaPezziScarti.TabIndex = 243
        Me.ContaPezziScarti.Value = 0R
        '
        'ContaPezziBuoni
        '
        Me.ContaPezziBuoni.BackColor = System.Drawing.Color.Black
        Me.ContaPezziBuoni.Format = "000000"
        Me.ContaPezziBuoni.Location = New System.Drawing.Point(11, 64)
        Me.ContaPezziBuoni.Name = "ContaPezziBuoni"
        Me.ContaPezziBuoni.Renderer = Nothing
        Me.ContaPezziBuoni.Signed = False
        Me.ContaPezziBuoni.Size = New System.Drawing.Size(238, 56)
        Me.ContaPezziBuoni.TabIndex = 242
        Me.ContaPezziBuoni.Value = 0R
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label40.Location = New System.Drawing.Point(11, 228)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(238, 33)
        Me.Label40.TabIndex = 214
        Me.Label40.Text = "SCARTI"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(11, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(238, 33)
        Me.Label8.TabIndex = 210
        Me.Label8.Text = "BUONI"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Cyc_Ps_Sx)
        Me.GroupBox3.Controls.Add(Me.Cyc_Ps_Dx)
        Me.GroupBox3.Controls.Add(Me.L_PosaggioDx)
        Me.GroupBox3.Controls.Add(Me.P_PsSx_Supp)
        Me.GroupBox3.Controls.Add(Me.P_PsSx_Oled)
        Me.GroupBox3.Controls.Add(Me.P_PsDx_Supp)
        Me.GroupBox3.Controls.Add(Me.P_PsDx_Oled)
        Me.GroupBox3.Controls.Add(Me.L_PosaggioSx)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(1467, 344)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(381, 474)
        Me.GroupBox3.TabIndex = 228
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "STAZIONE ASSEMBLAGGIO"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.lblManoRobotPress)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.lblIncollaggioPres)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Lab_Vuo_Oled_Dx)
        Me.GroupBox4.Controls.Add(Me.L_V_Oled_Dx)
        Me.GroupBox4.Controls.Add(Me.Lab_Vuo_Biade_Dx)
        Me.GroupBox4.Controls.Add(Me.L_V_Biade_Dx)
        Me.GroupBox4.Controls.Add(Me.Lab_Vuo_Supp_Dx)
        Me.GroupBox4.Controls.Add(Me.L_V_Supp_Dx)
        Me.GroupBox4.Controls.Add(Me.Lab_Vuo_Oled_Sx)
        Me.GroupBox4.Controls.Add(Me.L_V_Oled_Sx)
        Me.GroupBox4.Controls.Add(Me.Lab_Vuo_Biade_Sx)
        Me.GroupBox4.Controls.Add(Me.L_V_Biade_Sx)
        Me.GroupBox4.Controls.Add(Me.Lab_Vuo_Supp_Sx)
        Me.GroupBox4.Controls.Add(Me.L_V_Supp_Sx)
        Me.GroupBox4.Controls.Add(Me.Lab_Vuo_Frame_Dx)
        Me.GroupBox4.Controls.Add(Me.L_V_Frame_Dx)
        Me.GroupBox4.Controls.Add(Me.Lab_Vuo_Frame_Sx)
        Me.GroupBox4.Controls.Add(Me.L_V_Frame_Sx)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox4.Location = New System.Drawing.Point(16, 217)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(354, 251)
        Me.GroupBox4.TabIndex = 291
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PRESSIONI VUOTO"
        '
        'lblManoRobotPress
        '
        Me.lblManoRobotPress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblManoRobotPress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManoRobotPress.Location = New System.Drawing.Point(183, 211)
        Me.lblManoRobotPress.Name = "lblManoRobotPress"
        Me.lblManoRobotPress.Size = New System.Drawing.Size(70, 25)
        Me.lblManoRobotPress.TabIndex = 225
        Me.lblManoRobotPress.Text = "#.###"
        Me.lblManoRobotPress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Gainsboro
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(85, 211)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 25)
        Me.Label19.TabIndex = 224
        Me.Label19.Text = "Mano robot"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIncollaggioPres
        '
        Me.lblIncollaggioPres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncollaggioPres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncollaggioPres.Location = New System.Drawing.Point(183, 177)
        Me.lblIncollaggioPres.Name = "lblIncollaggioPres"
        Me.lblIncollaggioPres.Size = New System.Drawing.Size(70, 25)
        Me.lblIncollaggioPres.TabIndex = 223
        Me.lblIncollaggioPres.Text = "#.###"
        Me.lblIncollaggioPres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Gainsboro
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(85, 177)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 25)
        Me.Label18.TabIndex = 222
        Me.Label18.Text = "Incollaggio"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_Vuo_Oled_Dx
        '
        Me.Lab_Vuo_Oled_Dx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lab_Vuo_Oled_Dx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Vuo_Oled_Dx.Location = New System.Drawing.Point(277, 139)
        Me.Lab_Vuo_Oled_Dx.Name = "Lab_Vuo_Oled_Dx"
        Me.Lab_Vuo_Oled_Dx.Size = New System.Drawing.Size(70, 25)
        Me.Lab_Vuo_Oled_Dx.TabIndex = 221
        Me.Lab_Vuo_Oled_Dx.Text = "#.###"
        Me.Lab_Vuo_Oled_Dx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L_V_Oled_Dx
        '
        Me.L_V_Oled_Dx.BackColor = System.Drawing.Color.Gainsboro
        Me.L_V_Oled_Dx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_V_Oled_Dx.ForeColor = System.Drawing.Color.Black
        Me.L_V_Oled_Dx.Location = New System.Drawing.Point(188, 139)
        Me.L_V_Oled_Dx.Name = "L_V_Oled_Dx"
        Me.L_V_Oled_Dx.Size = New System.Drawing.Size(83, 25)
        Me.L_V_Oled_Dx.TabIndex = 220
        Me.L_V_Oled_Dx.Text = "Oled"
        Me.L_V_Oled_Dx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_Vuo_Biade_Dx
        '
        Me.Lab_Vuo_Biade_Dx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lab_Vuo_Biade_Dx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Vuo_Biade_Dx.Location = New System.Drawing.Point(277, 103)
        Me.Lab_Vuo_Biade_Dx.Name = "Lab_Vuo_Biade_Dx"
        Me.Lab_Vuo_Biade_Dx.Size = New System.Drawing.Size(70, 25)
        Me.Lab_Vuo_Biade_Dx.TabIndex = 219
        Me.Lab_Vuo_Biade_Dx.Text = "#.###"
        Me.Lab_Vuo_Biade_Dx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L_V_Biade_Dx
        '
        Me.L_V_Biade_Dx.BackColor = System.Drawing.Color.Gainsboro
        Me.L_V_Biade_Dx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_V_Biade_Dx.ForeColor = System.Drawing.Color.Black
        Me.L_V_Biade_Dx.Location = New System.Drawing.Point(188, 103)
        Me.L_V_Biade_Dx.Name = "L_V_Biade_Dx"
        Me.L_V_Biade_Dx.Size = New System.Drawing.Size(83, 25)
        Me.L_V_Biade_Dx.TabIndex = 218
        Me.L_V_Biade_Dx.Text = "Biadesivo"
        Me.L_V_Biade_Dx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_Vuo_Supp_Dx
        '
        Me.Lab_Vuo_Supp_Dx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lab_Vuo_Supp_Dx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Vuo_Supp_Dx.Location = New System.Drawing.Point(277, 66)
        Me.Lab_Vuo_Supp_Dx.Name = "Lab_Vuo_Supp_Dx"
        Me.Lab_Vuo_Supp_Dx.Size = New System.Drawing.Size(70, 25)
        Me.Lab_Vuo_Supp_Dx.TabIndex = 217
        Me.Lab_Vuo_Supp_Dx.Text = "#.###"
        Me.Lab_Vuo_Supp_Dx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L_V_Supp_Dx
        '
        Me.L_V_Supp_Dx.BackColor = System.Drawing.Color.Gainsboro
        Me.L_V_Supp_Dx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_V_Supp_Dx.ForeColor = System.Drawing.Color.Black
        Me.L_V_Supp_Dx.Location = New System.Drawing.Point(188, 66)
        Me.L_V_Supp_Dx.Name = "L_V_Supp_Dx"
        Me.L_V_Supp_Dx.Size = New System.Drawing.Size(83, 25)
        Me.L_V_Supp_Dx.TabIndex = 216
        Me.L_V_Supp_Dx.Text = "Supporto"
        Me.L_V_Supp_Dx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_Vuo_Oled_Sx
        '
        Me.Lab_Vuo_Oled_Sx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lab_Vuo_Oled_Sx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Vuo_Oled_Sx.Location = New System.Drawing.Point(101, 139)
        Me.Lab_Vuo_Oled_Sx.Name = "Lab_Vuo_Oled_Sx"
        Me.Lab_Vuo_Oled_Sx.Size = New System.Drawing.Size(70, 25)
        Me.Lab_Vuo_Oled_Sx.TabIndex = 215
        Me.Lab_Vuo_Oled_Sx.Text = "#.###"
        Me.Lab_Vuo_Oled_Sx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L_V_Oled_Sx
        '
        Me.L_V_Oled_Sx.BackColor = System.Drawing.Color.Gainsboro
        Me.L_V_Oled_Sx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_V_Oled_Sx.ForeColor = System.Drawing.Color.Black
        Me.L_V_Oled_Sx.Location = New System.Drawing.Point(12, 139)
        Me.L_V_Oled_Sx.Name = "L_V_Oled_Sx"
        Me.L_V_Oled_Sx.Size = New System.Drawing.Size(83, 25)
        Me.L_V_Oled_Sx.TabIndex = 214
        Me.L_V_Oled_Sx.Text = "Oled"
        Me.L_V_Oled_Sx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_Vuo_Biade_Sx
        '
        Me.Lab_Vuo_Biade_Sx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lab_Vuo_Biade_Sx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Vuo_Biade_Sx.Location = New System.Drawing.Point(101, 103)
        Me.Lab_Vuo_Biade_Sx.Name = "Lab_Vuo_Biade_Sx"
        Me.Lab_Vuo_Biade_Sx.Size = New System.Drawing.Size(70, 25)
        Me.Lab_Vuo_Biade_Sx.TabIndex = 213
        Me.Lab_Vuo_Biade_Sx.Text = "#.###"
        Me.Lab_Vuo_Biade_Sx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L_V_Biade_Sx
        '
        Me.L_V_Biade_Sx.BackColor = System.Drawing.Color.Gainsboro
        Me.L_V_Biade_Sx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_V_Biade_Sx.ForeColor = System.Drawing.Color.Black
        Me.L_V_Biade_Sx.Location = New System.Drawing.Point(12, 103)
        Me.L_V_Biade_Sx.Name = "L_V_Biade_Sx"
        Me.L_V_Biade_Sx.Size = New System.Drawing.Size(83, 25)
        Me.L_V_Biade_Sx.TabIndex = 212
        Me.L_V_Biade_Sx.Text = "Biadesivo"
        Me.L_V_Biade_Sx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_Vuo_Supp_Sx
        '
        Me.Lab_Vuo_Supp_Sx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lab_Vuo_Supp_Sx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Vuo_Supp_Sx.Location = New System.Drawing.Point(101, 66)
        Me.Lab_Vuo_Supp_Sx.Name = "Lab_Vuo_Supp_Sx"
        Me.Lab_Vuo_Supp_Sx.Size = New System.Drawing.Size(70, 25)
        Me.Lab_Vuo_Supp_Sx.TabIndex = 211
        Me.Lab_Vuo_Supp_Sx.Text = "#.###"
        Me.Lab_Vuo_Supp_Sx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L_V_Supp_Sx
        '
        Me.L_V_Supp_Sx.BackColor = System.Drawing.Color.Gainsboro
        Me.L_V_Supp_Sx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_V_Supp_Sx.ForeColor = System.Drawing.Color.Black
        Me.L_V_Supp_Sx.Location = New System.Drawing.Point(12, 66)
        Me.L_V_Supp_Sx.Name = "L_V_Supp_Sx"
        Me.L_V_Supp_Sx.Size = New System.Drawing.Size(83, 25)
        Me.L_V_Supp_Sx.TabIndex = 210
        Me.L_V_Supp_Sx.Text = "Supporto"
        Me.L_V_Supp_Sx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_Vuo_Frame_Dx
        '
        Me.Lab_Vuo_Frame_Dx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lab_Vuo_Frame_Dx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Vuo_Frame_Dx.Location = New System.Drawing.Point(278, 31)
        Me.Lab_Vuo_Frame_Dx.Name = "Lab_Vuo_Frame_Dx"
        Me.Lab_Vuo_Frame_Dx.Size = New System.Drawing.Size(70, 25)
        Me.Lab_Vuo_Frame_Dx.TabIndex = 13
        Me.Lab_Vuo_Frame_Dx.Text = "#.###"
        Me.Lab_Vuo_Frame_Dx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L_V_Frame_Dx
        '
        Me.L_V_Frame_Dx.BackColor = System.Drawing.Color.Gainsboro
        Me.L_V_Frame_Dx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_V_Frame_Dx.ForeColor = System.Drawing.Color.Black
        Me.L_V_Frame_Dx.Location = New System.Drawing.Point(188, 31)
        Me.L_V_Frame_Dx.Name = "L_V_Frame_Dx"
        Me.L_V_Frame_Dx.Size = New System.Drawing.Size(84, 25)
        Me.L_V_Frame_Dx.TabIndex = 12
        Me.L_V_Frame_Dx.Text = "Frame"
        Me.L_V_Frame_Dx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_Vuo_Frame_Sx
        '
        Me.Lab_Vuo_Frame_Sx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lab_Vuo_Frame_Sx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Vuo_Frame_Sx.Location = New System.Drawing.Point(101, 31)
        Me.Lab_Vuo_Frame_Sx.Name = "Lab_Vuo_Frame_Sx"
        Me.Lab_Vuo_Frame_Sx.Size = New System.Drawing.Size(70, 25)
        Me.Lab_Vuo_Frame_Sx.TabIndex = 11
        Me.Lab_Vuo_Frame_Sx.Text = "#.###"
        Me.Lab_Vuo_Frame_Sx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L_V_Frame_Sx
        '
        Me.L_V_Frame_Sx.BackColor = System.Drawing.Color.Gainsboro
        Me.L_V_Frame_Sx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_V_Frame_Sx.ForeColor = System.Drawing.Color.Black
        Me.L_V_Frame_Sx.Location = New System.Drawing.Point(12, 32)
        Me.L_V_Frame_Sx.Name = "L_V_Frame_Sx"
        Me.L_V_Frame_Sx.Size = New System.Drawing.Size(83, 25)
        Me.L_V_Frame_Sx.TabIndex = 10
        Me.L_V_Frame_Sx.Text = "Frame"
        Me.L_V_Frame_Sx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cyc_Ps_Sx
        '
        Me.Cyc_Ps_Sx.BackColor = System.Drawing.Color.Transparent
        Me.Cyc_Ps_Sx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cyc_Ps_Sx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cyc_Ps_Sx.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Cyc_Ps_Sx.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cyc_Ps_Sx.ImageIndex = 1
        Me.Cyc_Ps_Sx.ImageList = Me.ImageList1
        Me.Cyc_Ps_Sx.Location = New System.Drawing.Point(16, 175)
        Me.Cyc_Ps_Sx.Name = "Cyc_Ps_Sx"
        Me.Cyc_Ps_Sx.Size = New System.Drawing.Size(166, 25)
        Me.Cyc_Ps_Sx.TabIndex = 228
        Me.Cyc_Ps_Sx.Text = "Ciclo"
        Me.Cyc_Ps_Sx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cyc_Ps_Dx
        '
        Me.Cyc_Ps_Dx.BackColor = System.Drawing.Color.Transparent
        Me.Cyc_Ps_Dx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cyc_Ps_Dx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cyc_Ps_Dx.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Cyc_Ps_Dx.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cyc_Ps_Dx.ImageIndex = 1
        Me.Cyc_Ps_Dx.ImageList = Me.ImageList1
        Me.Cyc_Ps_Dx.Location = New System.Drawing.Point(204, 175)
        Me.Cyc_Ps_Dx.Name = "Cyc_Ps_Dx"
        Me.Cyc_Ps_Dx.Size = New System.Drawing.Size(166, 25)
        Me.Cyc_Ps_Dx.TabIndex = 227
        Me.Cyc_Ps_Dx.Text = "Ciclo"
        Me.Cyc_Ps_Dx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'L_PosaggioDx
        '
        Me.L_PosaggioDx.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.L_PosaggioDx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_PosaggioDx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_PosaggioDx.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.L_PosaggioDx.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.L_PosaggioDx.ImageIndex = 5
        Me.L_PosaggioDx.ImageList = Me.ImageList2
        Me.L_PosaggioDx.Location = New System.Drawing.Point(204, 33)
        Me.L_PosaggioDx.Name = "L_PosaggioDx"
        Me.L_PosaggioDx.Size = New System.Drawing.Size(166, 40)
        Me.L_PosaggioDx.TabIndex = 226
        Me.L_PosaggioDx.Text = "Posaggio Dx"
        Me.L_PosaggioDx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'P_PsSx_Supp
        '
        Me.P_PsSx_Supp.BackColor = System.Drawing.Color.Transparent
        Me.P_PsSx_Supp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P_PsSx_Supp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_PsSx_Supp.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.P_PsSx_Supp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.P_PsSx_Supp.ImageIndex = 1
        Me.P_PsSx_Supp.ImageList = Me.ImageList1
        Me.P_PsSx_Supp.Location = New System.Drawing.Point(16, 137)
        Me.P_PsSx_Supp.Name = "P_PsSx_Supp"
        Me.P_PsSx_Supp.Size = New System.Drawing.Size(166, 25)
        Me.P_PsSx_Supp.TabIndex = 225
        Me.P_PsSx_Supp.Text = "Pres. supporto"
        Me.P_PsSx_Supp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'P_PsSx_Oled
        '
        Me.P_PsSx_Oled.BackColor = System.Drawing.Color.Transparent
        Me.P_PsSx_Oled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P_PsSx_Oled.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_PsSx_Oled.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.P_PsSx_Oled.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.P_PsSx_Oled.ImageIndex = 1
        Me.P_PsSx_Oled.ImageList = Me.ImageList1
        Me.P_PsSx_Oled.Location = New System.Drawing.Point(16, 103)
        Me.P_PsSx_Oled.Name = "P_PsSx_Oled"
        Me.P_PsSx_Oled.Size = New System.Drawing.Size(166, 25)
        Me.P_PsSx_Oled.TabIndex = 224
        Me.P_PsSx_Oled.Text = "Pres OLED"
        Me.P_PsSx_Oled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'P_PsDx_Supp
        '
        Me.P_PsDx_Supp.BackColor = System.Drawing.Color.Transparent
        Me.P_PsDx_Supp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P_PsDx_Supp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_PsDx_Supp.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.P_PsDx_Supp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.P_PsDx_Supp.ImageIndex = 1
        Me.P_PsDx_Supp.ImageList = Me.ImageList1
        Me.P_PsDx_Supp.Location = New System.Drawing.Point(204, 137)
        Me.P_PsDx_Supp.Name = "P_PsDx_Supp"
        Me.P_PsDx_Supp.Size = New System.Drawing.Size(166, 25)
        Me.P_PsDx_Supp.TabIndex = 223
        Me.P_PsDx_Supp.Text = "Pres. supporto"
        Me.P_PsDx_Supp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'P_PsDx_Oled
        '
        Me.P_PsDx_Oled.BackColor = System.Drawing.Color.Transparent
        Me.P_PsDx_Oled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P_PsDx_Oled.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_PsDx_Oled.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.P_PsDx_Oled.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.P_PsDx_Oled.ImageIndex = 1
        Me.P_PsDx_Oled.ImageList = Me.ImageList1
        Me.P_PsDx_Oled.Location = New System.Drawing.Point(204, 103)
        Me.P_PsDx_Oled.Name = "P_PsDx_Oled"
        Me.P_PsDx_Oled.Size = New System.Drawing.Size(166, 25)
        Me.P_PsDx_Oled.TabIndex = 222
        Me.P_PsDx_Oled.Text = "Pres OLED"
        Me.P_PsDx_Oled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'L_PosaggioSx
        '
        Me.L_PosaggioSx.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.L_PosaggioSx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_PosaggioSx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_PosaggioSx.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.L_PosaggioSx.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.L_PosaggioSx.ImageIndex = 5
        Me.L_PosaggioSx.ImageList = Me.ImageList2
        Me.L_PosaggioSx.Location = New System.Drawing.Point(16, 33)
        Me.L_PosaggioSx.Name = "L_PosaggioSx"
        Me.L_PosaggioSx.Size = New System.Drawing.Size(166, 40)
        Me.L_PosaggioSx.TabIndex = 221
        Me.L_PosaggioSx.Text = "Posaggio Sx"
        Me.L_PosaggioSx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BackgroundImage = Global.Controllo.My.Resources.Resources.G01541_IMPIANTO_ASSEMBLAGGIO_OLED_FLESSIBILE_Q7_Q9
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.GroupBox9)
        Me.Panel1.Controls.Add(Me.GroupBox8)
        Me.Panel1.Controls.Add(Me.lblPlasmaturaOn)
        Me.Panel1.Controls.Add(Me.lblAllNastri)
        Me.Panel1.Controls.Add(Me.lblVuotoIncollaggioDx)
        Me.Panel1.Controls.Add(Me.lblVuotoIncollaggioSx)
        Me.Panel1.Controls.Add(Me.btnDXReadReq)
        Me.Panel1.Controls.Add(Me.btnSXReadReq)
        Me.Panel1.Controls.Add(Me.LbLed_OledIncollaggio)
        Me.Panel1.Controls.Add(Me.GroupBox7)
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.L_MB_Dentro)
        Me.Panel1.Controls.Add(Me.L_MA_Dentro)
        Me.Panel1.Controls.Add(Me.L_Cod_Sx)
        Me.Panel1.Controls.Add(Me.L_Cod_Dx)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.Lab_Scarti)
        Me.Panel1.Controls.Add(Me.L_All_StAvvitatura)
        Me.Panel1.Controls.Add(Me.LabNDx)
        Me.Panel1.Controls.Add(Me.LabNSx)
        Me.Panel1.Controls.Add(Me.Pr_StFuoriSx)
        Me.Panel1.Controls.Add(Me.Pr_StFuoriDx)
        Me.Panel1.Controls.Add(Me.L_All_Plasmatura)
        Me.Panel1.Controls.Add(Me.L_All_Mag)
        Me.Panel1.Controls.Add(Me.L_MB_Fuori)
        Me.Panel1.Controls.Add(Me.L_All_Rob)
        Me.Panel1.Controls.Add(Me.L_MA_Fuori)
        Me.Panel1.Controls.Add(Me.L_Barr)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Panel1.Location = New System.Drawing.Point(287, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1158, 806)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.LedScarto1)
        Me.GroupBox8.Controls.Add(Me.LedScarto2)
        Me.GroupBox8.Controls.Add(Me.LedScarto3)
        Me.GroupBox8.Controls.Add(Me.LedScarto4)
        Me.GroupBox8.Controls.Add(Me.LabScarto1)
        Me.GroupBox8.Controls.Add(Me.LabScarto2)
        Me.GroupBox8.Controls.Add(Me.LabScarto3)
        Me.GroupBox8.Controls.Add(Me.LabScarto4)
        Me.GroupBox8.Location = New System.Drawing.Point(926, 26)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(229, 105)
        Me.GroupBox8.TabIndex = 279
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "VASSOIO SCARTI"
        '
        'LedScarto1
        '
        Me.LedScarto1.BackColor = System.Drawing.Color.Transparent
        Me.LedScarto1.BlinkInterval = 500
        Me.LedScarto1.Label = ""
        Me.LedScarto1.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.LedScarto1.LedColor = System.Drawing.Color.Purple
        Me.LedScarto1.LedSize = New System.Drawing.SizeF(12.0!, 12.0!)
        Me.LedScarto1.Location = New System.Drawing.Point(15, 29)
        Me.LedScarto1.Name = "LedScarto1"
        Me.LedScarto1.Renderer = Nothing
        Me.LedScarto1.Size = New System.Drawing.Size(15, 15)
        Me.LedScarto1.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off
        Me.LedScarto1.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.LedScarto1.TabIndex = 242
        '
        'LedScarto2
        '
        Me.LedScarto2.BackColor = System.Drawing.Color.Transparent
        Me.LedScarto2.BlinkInterval = 500
        Me.LedScarto2.Label = ""
        Me.LedScarto2.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.LedScarto2.LedColor = System.Drawing.Color.Purple
        Me.LedScarto2.LedSize = New System.Drawing.SizeF(12.0!, 12.0!)
        Me.LedScarto2.Location = New System.Drawing.Point(15, 46)
        Me.LedScarto2.Name = "LedScarto2"
        Me.LedScarto2.Renderer = Nothing
        Me.LedScarto2.Size = New System.Drawing.Size(15, 15)
        Me.LedScarto2.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off
        Me.LedScarto2.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.LedScarto2.TabIndex = 243
        '
        'LedScarto3
        '
        Me.LedScarto3.BackColor = System.Drawing.Color.Transparent
        Me.LedScarto3.BlinkInterval = 500
        Me.LedScarto3.Label = ""
        Me.LedScarto3.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.LedScarto3.LedColor = System.Drawing.Color.Purple
        Me.LedScarto3.LedSize = New System.Drawing.SizeF(12.0!, 12.0!)
        Me.LedScarto3.Location = New System.Drawing.Point(15, 63)
        Me.LedScarto3.Name = "LedScarto3"
        Me.LedScarto3.Renderer = Nothing
        Me.LedScarto3.Size = New System.Drawing.Size(15, 15)
        Me.LedScarto3.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off
        Me.LedScarto3.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.LedScarto3.TabIndex = 244
        '
        'LedScarto4
        '
        Me.LedScarto4.BackColor = System.Drawing.Color.Transparent
        Me.LedScarto4.BlinkInterval = 500
        Me.LedScarto4.Label = ""
        Me.LedScarto4.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.LedScarto4.LedColor = System.Drawing.Color.Purple
        Me.LedScarto4.LedSize = New System.Drawing.SizeF(12.0!, 12.0!)
        Me.LedScarto4.Location = New System.Drawing.Point(15, 80)
        Me.LedScarto4.Name = "LedScarto4"
        Me.LedScarto4.Renderer = Nothing
        Me.LedScarto4.Size = New System.Drawing.Size(15, 15)
        Me.LedScarto4.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off
        Me.LedScarto4.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.LedScarto4.TabIndex = 245
        '
        'LabScarto1
        '
        Me.LabScarto1.AutoSize = True
        Me.LabScarto1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabScarto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabScarto1.Location = New System.Drawing.Point(30, 29)
        Me.LabScarto1.Name = "LabScarto1"
        Me.LabScarto1.Size = New System.Drawing.Size(29, 13)
        Me.LabScarto1.TabIndex = 252
        Me.LabScarto1.Text = "M-P"
        '
        'LabScarto2
        '
        Me.LabScarto2.AutoSize = True
        Me.LabScarto2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabScarto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabScarto2.Location = New System.Drawing.Point(30, 46)
        Me.LabScarto2.Name = "LabScarto2"
        Me.LabScarto2.Size = New System.Drawing.Size(29, 13)
        Me.LabScarto2.TabIndex = 253
        Me.LabScarto2.Text = "M-P"
        '
        'LabScarto3
        '
        Me.LabScarto3.AutoSize = True
        Me.LabScarto3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabScarto3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabScarto3.Location = New System.Drawing.Point(30, 63)
        Me.LabScarto3.Name = "LabScarto3"
        Me.LabScarto3.Size = New System.Drawing.Size(29, 13)
        Me.LabScarto3.TabIndex = 254
        Me.LabScarto3.Text = "M-P"
        '
        'LabScarto4
        '
        Me.LabScarto4.AutoSize = True
        Me.LabScarto4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabScarto4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabScarto4.Location = New System.Drawing.Point(30, 82)
        Me.LabScarto4.Name = "LabScarto4"
        Me.LabScarto4.Size = New System.Drawing.Size(29, 13)
        Me.LabScarto4.TabIndex = 255
        Me.LabScarto4.Text = "M-P"
        '
        'lblPlasmaturaOn
        '
        Me.lblPlasmaturaOn.BackColor = System.Drawing.Color.Transparent
        Me.lblPlasmaturaOn.BlinkInterval = 500
        Me.lblPlasmaturaOn.Label = ""
        Me.lblPlasmaturaOn.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.lblPlasmaturaOn.LedColor = System.Drawing.Color.Lime
        Me.lblPlasmaturaOn.LedSize = New System.Drawing.SizeF(20.0!, 20.0!)
        Me.lblPlasmaturaOn.Location = New System.Drawing.Point(733, 303)
        Me.lblPlasmaturaOn.Name = "lblPlasmaturaOn"
        Me.lblPlasmaturaOn.Renderer = Nothing
        Me.lblPlasmaturaOn.Size = New System.Drawing.Size(27, 27)
        Me.lblPlasmaturaOn.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Blink
        Me.lblPlasmaturaOn.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.lblPlasmaturaOn.TabIndex = 278
        Me.lblPlasmaturaOn.Visible = False
        '
        'lblAllNastri
        '
        Me.lblAllNastri.BackColor = System.Drawing.Color.Transparent
        Me.lblAllNastri.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllNastri.ForeColor = System.Drawing.Color.Red
        Me.lblAllNastri.ImageKey = "warning_35.png"
        Me.lblAllNastri.ImageList = Me.ImageList2
        Me.lblAllNastri.Location = New System.Drawing.Point(605, 577)
        Me.lblAllNastri.Name = "lblAllNastri"
        Me.lblAllNastri.Size = New System.Drawing.Size(109, 58)
        Me.lblAllNastri.TabIndex = 277
        Me.lblAllNastri.Text = "NASTRI"
        Me.lblAllNastri.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblAllNastri.Visible = False
        '
        'lblVuotoIncollaggioDx
        '
        Me.lblVuotoIncollaggioDx.AutoSize = True
        Me.lblVuotoIncollaggioDx.BackColor = System.Drawing.Color.DimGray
        Me.lblVuotoIncollaggioDx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVuotoIncollaggioDx.ForeColor = System.Drawing.Color.Red
        Me.lblVuotoIncollaggioDx.Location = New System.Drawing.Point(705, 440)
        Me.lblVuotoIncollaggioDx.Name = "lblVuotoIncollaggioDx"
        Me.lblVuotoIncollaggioDx.Size = New System.Drawing.Size(92, 20)
        Me.lblVuotoIncollaggioDx.TabIndex = 276
        Me.lblVuotoIncollaggioDx.Text = "VUOTO DX"
        '
        'lblVuotoIncollaggioSx
        '
        Me.lblVuotoIncollaggioSx.AutoSize = True
        Me.lblVuotoIncollaggioSx.BackColor = System.Drawing.Color.DimGray
        Me.lblVuotoIncollaggioSx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVuotoIncollaggioSx.ForeColor = System.Drawing.Color.Red
        Me.lblVuotoIncollaggioSx.Location = New System.Drawing.Point(529, 440)
        Me.lblVuotoIncollaggioSx.Name = "lblVuotoIncollaggioSx"
        Me.lblVuotoIncollaggioSx.Size = New System.Drawing.Size(91, 20)
        Me.lblVuotoIncollaggioSx.TabIndex = 275
        Me.lblVuotoIncollaggioSx.Text = "VUOTO SX"
        '
        'btnDXReadReq
        '
        Me.btnDXReadReq.Location = New System.Drawing.Point(679, 780)
        Me.btnDXReadReq.Name = "btnDXReadReq"
        Me.btnDXReadReq.Size = New System.Drawing.Size(75, 23)
        Me.btnDXReadReq.TabIndex = 274
        Me.btnDXReadReq.Text = "Read REQ."
        Me.btnDXReadReq.UseVisualStyleBackColor = True
        '
        'btnSXReadReq
        '
        Me.btnSXReadReq.Location = New System.Drawing.Point(567, 780)
        Me.btnSXReadReq.Name = "btnSXReadReq"
        Me.btnSXReadReq.Size = New System.Drawing.Size(75, 23)
        Me.btnSXReadReq.TabIndex = 273
        Me.btnSXReadReq.Text = "Read REQ."
        Me.btnSXReadReq.UseVisualStyleBackColor = True
        '
        'LbLed_OledIncollaggio
        '
        Me.LbLed_OledIncollaggio.BackColor = System.Drawing.Color.Transparent
        Me.LbLed_OledIncollaggio.BlinkInterval = 500
        Me.LbLed_OledIncollaggio.Label = ""
        Me.LbLed_OledIncollaggio.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.LbLed_OledIncollaggio.LedColor = System.Drawing.Color.Gray
        Me.LbLed_OledIncollaggio.LedSize = New System.Drawing.SizeF(20.0!, 20.0!)
        Me.LbLed_OledIncollaggio.Location = New System.Drawing.Point(646, 402)
        Me.LbLed_OledIncollaggio.Name = "LbLed_OledIncollaggio"
        Me.LbLed_OledIncollaggio.Renderer = Nothing
        Me.LbLed_OledIncollaggio.Size = New System.Drawing.Size(27, 27)
        Me.LbLed_OledIncollaggio.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Blink
        Me.LbLed_OledIncollaggio.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.LbLed_OledIncollaggio.TabIndex = 272
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lblIncollaggioCodicePosaggio)
        Me.GroupBox7.Controls.Add(Me.Label17)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.LbLed7)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.LbLed4)
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.LbLed5)
        Me.GroupBox7.Controls.Add(Me.LbLed6)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(926, 474)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(229, 152)
        Me.GroupBox7.TabIndex = 271
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "INCOLLAGGIO"
        '
        'lblIncollaggioCodicePosaggio
        '
        Me.lblIncollaggioCodicePosaggio.BackColor = System.Drawing.Color.Transparent
        Me.lblIncollaggioCodicePosaggio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncollaggioCodicePosaggio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblIncollaggioCodicePosaggio.Location = New System.Drawing.Point(9, 119)
        Me.lblIncollaggioCodicePosaggio.Name = "lblIncollaggioCodicePosaggio"
        Me.lblIncollaggioCodicePosaggio.Size = New System.Drawing.Size(206, 24)
        Me.lblIncollaggioCodicePosaggio.TabIndex = 277
        Me.lblIncollaggioCodicePosaggio.Text = "NA"
        Me.lblIncollaggioCodicePosaggio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(9, 94)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(206, 24)
        Me.Label17.TabIndex = 276
        Me.Label17.Text = "CODICE POSAGGIO:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(37, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 13)
        Me.Label16.TabIndex = 269
        Me.Label16.Text = "NESSUN OLED"
        '
        'LbLed7
        '
        Me.LbLed7.BackColor = System.Drawing.Color.Transparent
        Me.LbLed7.BlinkInterval = 500
        Me.LbLed7.Label = ""
        Me.LbLed7.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.LbLed7.LedColor = System.Drawing.Color.Gray
        Me.LbLed7.LedSize = New System.Drawing.SizeF(12.0!, 12.0!)
        Me.LbLed7.Location = New System.Drawing.Point(13, 26)
        Me.LbLed7.Name = "LbLed7"
        Me.LbLed7.Renderer = Nothing
        Me.LbLed7.Size = New System.Drawing.Size(15, 15)
        Me.LbLed7.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.[On]
        Me.LbLed7.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.LbLed7.TabIndex = 268
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 267
        Me.Label5.Text = "OLED OK"
        '
        'LbLed4
        '
        Me.LbLed4.BackColor = System.Drawing.Color.Transparent
        Me.LbLed4.BlinkInterval = 500
        Me.LbLed4.Label = ""
        Me.LbLed4.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.LbLed4.LedColor = System.Drawing.Color.Lime
        Me.LbLed4.LedSize = New System.Drawing.SizeF(12.0!, 12.0!)
        Me.LbLed4.Location = New System.Drawing.Point(13, 76)
        Me.LbLed4.Name = "LbLed4"
        Me.LbLed4.Renderer = Nothing
        Me.LbLed4.Size = New System.Drawing.Size(15, 15)
        Me.LbLed4.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.[On]
        Me.LbLed4.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.LbLed4.TabIndex = 266
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(37, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 265
        Me.Label10.Text = "OLED NOK"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(37, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 13)
        Me.Label15.TabIndex = 264
        Me.Label15.Text = "OLED PRESENTE"
        '
        'LbLed5
        '
        Me.LbLed5.BackColor = System.Drawing.Color.Transparent
        Me.LbLed5.BlinkInterval = 500
        Me.LbLed5.Label = ""
        Me.LbLed5.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.LbLed5.LedColor = System.Drawing.Color.Olive
        Me.LbLed5.LedSize = New System.Drawing.SizeF(12.0!, 12.0!)
        Me.LbLed5.Location = New System.Drawing.Point(13, 44)
        Me.LbLed5.Name = "LbLed5"
        Me.LbLed5.Renderer = Nothing
        Me.LbLed5.Size = New System.Drawing.Size(15, 15)
        Me.LbLed5.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.[On]
        Me.LbLed5.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.LbLed5.TabIndex = 262
        '
        'LbLed6
        '
        Me.LbLed6.BackColor = System.Drawing.Color.Transparent
        Me.LbLed6.BlinkInterval = 500
        Me.LbLed6.Label = ""
        Me.LbLed6.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.LbLed6.LedColor = System.Drawing.Color.Red
        Me.LbLed6.LedSize = New System.Drawing.SizeF(12.0!, 12.0!)
        Me.LbLed6.Location = New System.Drawing.Point(13, 60)
        Me.LbLed6.Name = "LbLed6"
        Me.LbLed6.Renderer = Nothing
        Me.LbLed6.Size = New System.Drawing.Size(15, 15)
        Me.LbLed6.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.[On]
        Me.LbLed6.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.LbLed6.TabIndex = 263
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.LabelPresenzaB)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.LabelPresenzaA)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 157)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(195, 132)
        Me.GroupBox6.TabIndex = 270
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "PRESENZE MAGAZZINI"
        '
        'LabelPresenzaB
        '
        Me.LabelPresenzaB.BackColor = System.Drawing.Color.DimGray
        Me.LabelPresenzaB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelPresenzaB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPresenzaB.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LabelPresenzaB.Location = New System.Drawing.Point(74, 71)
        Me.LabelPresenzaB.Name = "LabelPresenzaB"
        Me.LabelPresenzaB.Size = New System.Drawing.Size(115, 30)
        Me.LabelPresenzaB.TabIndex = 196
        Me.LabelPresenzaB.Text = "###"
        Me.LabelPresenzaB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(6, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 30)
        Me.Label7.TabIndex = 195
        Me.Label7.Text = "MAG. B"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelPresenzaA
        '
        Me.LabelPresenzaA.BackColor = System.Drawing.Color.DimGray
        Me.LabelPresenzaA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelPresenzaA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPresenzaA.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LabelPresenzaA.Location = New System.Drawing.Point(74, 32)
        Me.LabelPresenzaA.Name = "LabelPresenzaA"
        Me.LabelPresenzaA.Size = New System.Drawing.Size(115, 30)
        Me.LabelPresenzaA.TabIndex = 194
        Me.LabelPresenzaA.Text = "##"
        Me.LabelPresenzaA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(6, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 30)
        Me.Label12.TabIndex = 193
        Me.Label12.Text = "MAG. A"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_MB_Dentro
        '
        Me.L_MB_Dentro.BackColor = System.Drawing.Color.Transparent
        Me.L_MB_Dentro.BlinkInterval = 500
        Me.L_MB_Dentro.Label = ""
        Me.L_MB_Dentro.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.L_MB_Dentro.LedColor = System.Drawing.Color.Yellow
        Me.L_MB_Dentro.LedSize = New System.Drawing.SizeF(20.0!, 20.0!)
        Me.L_MB_Dentro.Location = New System.Drawing.Point(400, 260)
        Me.L_MB_Dentro.Name = "L_MB_Dentro"
        Me.L_MB_Dentro.Renderer = Nothing
        Me.L_MB_Dentro.Size = New System.Drawing.Size(27, 27)
        Me.L_MB_Dentro.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Blink
        Me.L_MB_Dentro.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.L_MB_Dentro.TabIndex = 269
        Me.L_MB_Dentro.Visible = False
        '
        'L_MA_Dentro
        '
        Me.L_MA_Dentro.BackColor = System.Drawing.Color.Transparent
        Me.L_MA_Dentro.BlinkInterval = 500
        Me.L_MA_Dentro.Label = ""
        Me.L_MA_Dentro.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.L_MA_Dentro.LedColor = System.Drawing.Color.Yellow
        Me.L_MA_Dentro.LedSize = New System.Drawing.SizeF(20.0!, 20.0!)
        Me.L_MA_Dentro.Location = New System.Drawing.Point(400, 187)
        Me.L_MA_Dentro.Name = "L_MA_Dentro"
        Me.L_MA_Dentro.Renderer = Nothing
        Me.L_MA_Dentro.Size = New System.Drawing.Size(27, 27)
        Me.L_MA_Dentro.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Blink
        Me.L_MA_Dentro.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.L_MA_Dentro.TabIndex = 268
        Me.L_MA_Dentro.Visible = False
        '
        'L_Cod_Sx
        '
        Me.L_Cod_Sx.BackColor = System.Drawing.Color.Transparent
        Me.L_Cod_Sx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_Cod_Sx.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Cod_Sx.ForeColor = System.Drawing.Color.Lime
        Me.L_Cod_Sx.Location = New System.Drawing.Point(433, 187)
        Me.L_Cod_Sx.Name = "L_Cod_Sx"
        Me.L_Cod_Sx.Size = New System.Drawing.Size(51, 29)
        Me.L_Cod_Sx.TabIndex = 267
        Me.L_Cod_Sx.Text = "##"
        Me.L_Cod_Sx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_Cod_Dx
        '
        Me.L_Cod_Dx.BackColor = System.Drawing.Color.Transparent
        Me.L_Cod_Dx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_Cod_Dx.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Cod_Dx.ForeColor = System.Drawing.Color.Lime
        Me.L_Cod_Dx.Location = New System.Drawing.Point(433, 260)
        Me.L_Cod_Dx.Name = "L_Cod_Dx"
        Me.L_Cod_Dx.Size = New System.Drawing.Size(51, 29)
        Me.L_Cod_Dx.TabIndex = 266
        Me.L_Cod_Dx.Text = "##"
        Me.L_Cod_Dx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.LbLed3)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.LbLed1)
        Me.GroupBox5.Controls.Add(Me.LbLed2)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(926, 138)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(229, 100)
        Me.GroupBox5.TabIndex = 264
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "LEGENDA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 13)
        Me.Label4.TabIndex = 267
        Me.Label4.Text = "SCARTO DA PRE-ORIENTAMENTO"
        '
        'LbLed3
        '
        Me.LbLed3.BackColor = System.Drawing.Color.Transparent
        Me.LbLed3.BlinkInterval = 500
        Me.LbLed3.Label = ""
        Me.LbLed3.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.LbLed3.LedColor = System.Drawing.Color.Pink
        Me.LbLed3.LedSize = New System.Drawing.SizeF(12.0!, 12.0!)
        Me.LbLed3.Location = New System.Drawing.Point(13, 55)
        Me.LbLed3.Name = "LbLed3"
        Me.LbLed3.Renderer = Nothing
        Me.LbLed3.Size = New System.Drawing.Size(15, 15)
        Me.LbLed3.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.[On]
        Me.LbLed3.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.LbLed3.TabIndex = 266
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 265
        Me.Label3.Text = "SCARTO DATAMATRIX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 13)
        Me.Label2.TabIndex = 264
        Me.Label2.Text = "SCARTO DA ORIENTAMENTO"
        '
        'LbLed1
        '
        Me.LbLed1.BackColor = System.Drawing.Color.Transparent
        Me.LbLed1.BlinkInterval = 500
        Me.LbLed1.Label = ""
        Me.LbLed1.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.LbLed1.LedColor = System.Drawing.Color.Purple
        Me.LbLed1.LedSize = New System.Drawing.SizeF(12.0!, 12.0!)
        Me.LbLed1.Location = New System.Drawing.Point(13, 23)
        Me.LbLed1.Name = "LbLed1"
        Me.LbLed1.Renderer = Nothing
        Me.LbLed1.Size = New System.Drawing.Size(15, 15)
        Me.LbLed1.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.[On]
        Me.LbLed1.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.LbLed1.TabIndex = 262
        '
        'LbLed2
        '
        Me.LbLed2.BackColor = System.Drawing.Color.Transparent
        Me.LbLed2.BlinkInterval = 500
        Me.LbLed2.Label = ""
        Me.LbLed2.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.LbLed2.LedColor = System.Drawing.Color.Red
        Me.LbLed2.LedSize = New System.Drawing.SizeF(12.0!, 12.0!)
        Me.LbLed2.Location = New System.Drawing.Point(13, 39)
        Me.LbLed2.Name = "LbLed2"
        Me.LbLed2.Renderer = Nothing
        Me.LbLed2.Size = New System.Drawing.Size(15, 15)
        Me.LbLed2.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.[On]
        Me.LbLed2.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.LbLed2.TabIndex = 263
        '
        'Lab_Scarti
        '
        Me.Lab_Scarti.BackColor = System.Drawing.Color.Transparent
        Me.Lab_Scarti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Scarti.ForeColor = System.Drawing.Color.Red
        Me.Lab_Scarti.ImageKey = "warning_35.png"
        Me.Lab_Scarti.ImageList = Me.ImageList2
        Me.Lab_Scarti.Location = New System.Drawing.Point(501, 198)
        Me.Lab_Scarti.Name = "Lab_Scarti"
        Me.Lab_Scarti.Size = New System.Drawing.Size(60, 57)
        Me.Lab_Scarti.TabIndex = 241
        Me.Lab_Scarti.Text = "SCARTI"
        Me.Lab_Scarti.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Lab_Scarti.Visible = False
        '
        'L_All_StAvvitatura
        '
        Me.L_All_StAvvitatura.BackColor = System.Drawing.Color.Transparent
        Me.L_All_StAvvitatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_All_StAvvitatura.ForeColor = System.Drawing.Color.Red
        Me.L_All_StAvvitatura.ImageKey = "warning_35.png"
        Me.L_All_StAvvitatura.ImageList = Me.ImageList2
        Me.L_All_StAvvitatura.Location = New System.Drawing.Point(605, 727)
        Me.L_All_StAvvitatura.Name = "L_All_StAvvitatura"
        Me.L_All_StAvvitatura.Size = New System.Drawing.Size(109, 58)
        Me.L_All_StAvvitatura.TabIndex = 239
        Me.L_All_StAvvitatura.Text = "AVVITATURA"
        Me.L_All_StAvvitatura.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.L_All_StAvvitatura.Visible = False
        '
        'LabNDx
        '
        Me.LabNDx.BackColor = System.Drawing.Color.Transparent
        Me.LabNDx.ImageKey = "1434568607_Arrow-Right - Copia.png"
        Me.LabNDx.ImageList = Me.ImageList2
        Me.LabNDx.Location = New System.Drawing.Point(750, 778)
        Me.LabNDx.Name = "LabNDx"
        Me.LabNDx.Size = New System.Drawing.Size(60, 25)
        Me.LabNDx.TabIndex = 236
        Me.LabNDx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabNDx.Visible = False
        '
        'LabNSx
        '
        Me.LabNSx.BackColor = System.Drawing.Color.Transparent
        Me.LabNSx.ImageKey = "1434568607_Arrow-Right.png"
        Me.LabNSx.ImageList = Me.ImageList2
        Me.LabNSx.Location = New System.Drawing.Point(501, 778)
        Me.LabNSx.Name = "LabNSx"
        Me.LabNSx.Size = New System.Drawing.Size(60, 25)
        Me.LabNSx.TabIndex = 234
        Me.LabNSx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabNSx.Visible = False
        '
        'Pr_StFuoriSx
        '
        Me.Pr_StFuoriSx.BackColor = System.Drawing.Color.Transparent
        Me.Pr_StFuoriSx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pr_StFuoriSx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pr_StFuoriSx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Pr_StFuoriSx.ImageIndex = 1
        Me.Pr_StFuoriSx.ImageList = Me.ImageList3
        Me.Pr_StFuoriSx.Location = New System.Drawing.Point(598, 704)
        Me.Pr_StFuoriSx.Name = "Pr_StFuoriSx"
        Me.Pr_StFuoriSx.Size = New System.Drawing.Size(22, 22)
        Me.Pr_StFuoriSx.TabIndex = 229
        '
        'Pr_StFuoriDx
        '
        Me.Pr_StFuoriDx.BackColor = System.Drawing.Color.Transparent
        Me.Pr_StFuoriDx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pr_StFuoriDx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pr_StFuoriDx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Pr_StFuoriDx.ImageIndex = 1
        Me.Pr_StFuoriDx.ImageList = Me.ImageList3
        Me.Pr_StFuoriDx.Location = New System.Drawing.Point(700, 704)
        Me.Pr_StFuoriDx.Name = "Pr_StFuoriDx"
        Me.Pr_StFuoriDx.Size = New System.Drawing.Size(22, 22)
        Me.Pr_StFuoriDx.TabIndex = 228
        '
        'L_All_Plasmatura
        '
        Me.L_All_Plasmatura.BackColor = System.Drawing.Color.Transparent
        Me.L_All_Plasmatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_All_Plasmatura.ForeColor = System.Drawing.Color.Red
        Me.L_All_Plasmatura.ImageKey = "warning_35.png"
        Me.L_All_Plasmatura.ImageList = Me.ImageList2
        Me.L_All_Plasmatura.Location = New System.Drawing.Point(697, 242)
        Me.L_All_Plasmatura.Name = "L_All_Plasmatura"
        Me.L_All_Plasmatura.Size = New System.Drawing.Size(100, 69)
        Me.L_All_Plasmatura.TabIndex = 192
        Me.L_All_Plasmatura.Text = "PLASMATURA"
        Me.L_All_Plasmatura.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.L_All_Plasmatura.Visible = False
        '
        'L_All_Mag
        '
        Me.L_All_Mag.BackColor = System.Drawing.Color.Transparent
        Me.L_All_Mag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_All_Mag.ForeColor = System.Drawing.Color.Red
        Me.L_All_Mag.ImageKey = "warning_35.png"
        Me.L_All_Mag.ImageList = Me.ImageList2
        Me.L_All_Mag.Location = New System.Drawing.Point(312, 211)
        Me.L_All_Mag.Name = "L_All_Mag"
        Me.L_All_Mag.Size = New System.Drawing.Size(101, 55)
        Me.L_All_Mag.TabIndex = 192
        Me.L_All_Mag.Text = "MAGAZZINO"
        Me.L_All_Mag.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.L_All_Mag.Visible = False
        '
        'L_MB_Fuori
        '
        Me.L_MB_Fuori.BackColor = System.Drawing.Color.Transparent
        Me.L_MB_Fuori.BlinkInterval = 500
        Me.L_MB_Fuori.Label = ""
        Me.L_MB_Fuori.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.L_MB_Fuori.LedColor = System.Drawing.Color.Yellow
        Me.L_MB_Fuori.LedSize = New System.Drawing.SizeF(20.0!, 20.0!)
        Me.L_MB_Fuori.Location = New System.Drawing.Point(299, 260)
        Me.L_MB_Fuori.Name = "L_MB_Fuori"
        Me.L_MB_Fuori.Renderer = Nothing
        Me.L_MB_Fuori.Size = New System.Drawing.Size(27, 27)
        Me.L_MB_Fuori.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Blink
        Me.L_MB_Fuori.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.L_MB_Fuori.TabIndex = 196
        Me.L_MB_Fuori.Visible = False
        '
        'L_All_Rob
        '
        Me.L_All_Rob.BackColor = System.Drawing.Color.Transparent
        Me.L_All_Rob.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_All_Rob.ForeColor = System.Drawing.Color.Red
        Me.L_All_Rob.ImageKey = "warning_35.png"
        Me.L_All_Rob.ImageList = Me.ImageList2
        Me.L_All_Rob.Location = New System.Drawing.Point(613, 109)
        Me.L_All_Rob.Name = "L_All_Rob"
        Me.L_All_Rob.Size = New System.Drawing.Size(89, 56)
        Me.L_All_Rob.TabIndex = 190
        Me.L_All_Rob.Text = "ALL. ROBOT"
        Me.L_All_Rob.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.L_All_Rob.Visible = False
        '
        'L_MA_Fuori
        '
        Me.L_MA_Fuori.BackColor = System.Drawing.Color.Transparent
        Me.L_MA_Fuori.BlinkInterval = 500
        Me.L_MA_Fuori.Label = ""
        Me.L_MA_Fuori.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.L_MA_Fuori.LedColor = System.Drawing.Color.Yellow
        Me.L_MA_Fuori.LedSize = New System.Drawing.SizeF(20.0!, 20.0!)
        Me.L_MA_Fuori.Location = New System.Drawing.Point(299, 187)
        Me.L_MA_Fuori.Name = "L_MA_Fuori"
        Me.L_MA_Fuori.Renderer = Nothing
        Me.L_MA_Fuori.Size = New System.Drawing.Size(27, 27)
        Me.L_MA_Fuori.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Blink
        Me.L_MA_Fuori.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.L_MA_Fuori.TabIndex = 195
        Me.L_MA_Fuori.Visible = False
        '
        'L_Barr
        '
        Me.L_Barr.BackColor = System.Drawing.Color.Transparent
        Me.L_Barr.BlinkInterval = 500
        Me.L_Barr.Label = "BARRIERE"
        Me.L_Barr.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.L_Barr.LedColor = System.Drawing.Color.Yellow
        Me.L_Barr.LedSize = New System.Drawing.SizeF(20.0!, 20.0!)
        Me.L_Barr.Location = New System.Drawing.Point(214, 189)
        Me.L_Barr.Name = "L_Barr"
        Me.L_Barr.Renderer = Nothing
        Me.L_Barr.Size = New System.Drawing.Size(61, 51)
        Me.L_Barr.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Blink
        Me.L_Barr.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.L_Barr.TabIndex = 194
        Me.L_Barr.Visible = False
        '
        'lblLetturaDatamatrixPCB
        '
        Me.lblLetturaDatamatrixPCB.BackColor = System.Drawing.Color.Transparent
        Me.lblLetturaDatamatrixPCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLetturaDatamatrixPCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetturaDatamatrixPCB.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblLetturaDatamatrixPCB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLetturaDatamatrixPCB.ImageIndex = 0
        Me.lblLetturaDatamatrixPCB.ImageList = Me.ImageList1
        Me.lblLetturaDatamatrixPCB.Location = New System.Drawing.Point(6, 23)
        Me.lblLetturaDatamatrixPCB.Name = "lblLetturaDatamatrixPCB"
        Me.lblLetturaDatamatrixPCB.Size = New System.Drawing.Size(311, 56)
        Me.lblLetturaDatamatrixPCB.TabIndex = 224
        Me.lblLetturaDatamatrixPCB.Text = "ABILITAZIONE Lettura Datamatrix PCB"
        Me.lblLetturaDatamatrixPCB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox9.Controls.Add(Me.lblLetturaDatamatrixPCB)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox9.Location = New System.Drawing.Point(3, 704)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(323, 96)
        Me.GroupBox9.TabIndex = 280
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "DATI MACCHINA"
        '
        'Form_home
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1900, 830)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.IOT2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form_home"
        Me.GroupBox1.ResumeLayout(False)
        Me.IOT2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TimerClk As System.Windows.Forms.Timer
    Friend WithEvents TimerGUI As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Lab_Par As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Lab_All As Label
    Friend WithEvents Lab_Miss As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents L_Barr As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents L_MB_Fuori As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents L_MA_Fuori As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents L_All_Rob As Label
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents L_All_Plasmatura As Label
    Friend WithEvents L_All_Mag As Label
    Friend WithEvents IOT2 As GroupBox
    Friend WithEvents L_Prodotto As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents ImageList3 As ImageList
    Friend WithEvents Pr_StFuoriSx As Label
    Friend WithEvents Pr_StFuoriDx As Label
    Friend WithEvents L_Modello As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents L_Versione As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents P_PsSx_Supp As Label
    Friend WithEvents P_PsSx_Oled As Label
    Friend WithEvents P_PsDx_Supp As Label
    Friend WithEvents P_PsDx_Oled As Label
    Friend WithEvents L_PosaggioSx As Label
    Friend WithEvents L_PosaggioDx As Label
    Friend WithEvents L_Descriz As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LabNSx As Label
    Friend WithEvents M1a As Label
    Friend WithEvents M1b As Label
    Friend WithEvents M1_Vass As Label
    Friend WithEvents M2a As Label
    Friend WithEvents M2b As Label
    Friend WithEvents Cyc_Ps_Sx As Label
    Friend WithEvents Cyc_Ps_Dx As Label
    Friend WithEvents L_All_StAvvitatura As Label
    Friend WithEvents Lab_Scarti As Label
    Friend WithEvents ContaPezziScarti As LBSoft.IndustrialCtrls.Meters.LBDigitalMeter
    Friend WithEvents ContaPezziBuoni As LBSoft.IndustrialCtrls.Meters.LBDigitalMeter
    Friend WithEvents bResetBuoni As Button
    Friend WithEvents bResetScarti As Button
    Friend WithEvents M2s As Label
    Friend WithEvents M1s As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Lab_Vuo_Frame_Dx As Label
    Friend WithEvents L_V_Frame_Dx As Label
    Friend WithEvents Lab_Vuo_Frame_Sx As Label
    Friend WithEvents L_V_Frame_Sx As Label
    Friend WithEvents LedScarto4 As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents LedScarto3 As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents LedScarto2 As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents LedScarto1 As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents LabScarto1 As Label
    Friend WithEvents LabScarto4 As Label
    Friend WithEvents LabScarto3 As Label
    Friend WithEvents LabScarto2 As Label
    Friend WithEvents LbLed2 As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents LbLed1 As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents L_Cod_Dx As Label
    Friend WithEvents L_Cod_Sx As Label
    Friend WithEvents L_MB_Dentro As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents L_MA_Dentro As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents LabNDx As Label
    Friend WithEvents Lab_Vuo_Supp_Sx As Label
    Friend WithEvents L_V_Supp_Sx As Label
    Friend WithEvents Lab_Vuo_Oled_Sx As Label
    Friend WithEvents L_V_Oled_Sx As Label
    Friend WithEvents Lab_Vuo_Biade_Sx As Label
    Friend WithEvents L_V_Biade_Sx As Label
    Friend WithEvents Lab_Vuo_Oled_Dx As Label
    Friend WithEvents L_V_Oled_Dx As Label
    Friend WithEvents Lab_Vuo_Biade_Dx As Label
    Friend WithEvents L_V_Biade_Dx As Label
    Friend WithEvents Lab_Vuo_Supp_Dx As Label
    Friend WithEvents L_V_Supp_Dx As Label
    Friend WithEvents LbLed3 As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents LabelPresenzaB As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelPresenzaA As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LbLed_OledIncollaggio As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LbLed4 As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LbLed5 As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents LbLed6 As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents Label16 As Label
    Friend WithEvents LbLed7 As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents btnDXReadReq As Button
    Friend WithEvents btnSXReadReq As Button
    Friend WithEvents lblVuotoIncollaggioSx As Label
    Friend WithEvents lblVuotoIncollaggioDx As Label
    Friend WithEvents lblAllNastri As Label
    Friend WithEvents lblIncollaggioCodicePosaggio As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblManoRobotPress As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblIncollaggioPres As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblPlasmaturaOn As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents lblLetturaDatamatrixPCB As Label
End Class

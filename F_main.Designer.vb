<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_main))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_home = New System.Windows.Forms.ToolStripButton()
        Me.Tool_lavoro = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Robot = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Visioni = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Parametri = New System.Windows.Forms.ToolStripButton()
        Me.Tool_sinottico = New System.Windows.Forms.ToolStripButton()
        Me.Tool_manuali = New System.Windows.Forms.ToolStripButton()
        Me.Tool_pezzi = New System.Windows.Forms.ToolStripButton()
        Me.Tool_esiti = New System.Windows.Forms.ToolStripButton()
        Me.Toll_CelleCarico = New System.Windows.Forms.ToolStripButton()
        Me.Tool_10 = New System.Windows.Forms.ToolStripButton()
        Me.Tool_versione = New System.Windows.Forms.ToolStripButton()
        Me.Tool_magazz = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Exit = New System.Windows.Forms.ToolStripButton()
        Me.Tool_alarm = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Storico = New System.Windows.Forms.ToolStripButton()
        Me.ToolEsiti = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Log_in = New System.Windows.Forms.ToolStripButton()
        Me.Tool_tast_num = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lab_stato = New System.Windows.Forms.Label()
        Me.Lab_versione = New System.Windows.Forms.Label()
        Me.Lab_banco = New System.Windows.Forms.Label()
        Me.Lab_titolo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Msg_text = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pict_run2 = New System.Windows.Forms.PictureBox()
        Me.P_DB = New System.Windows.Forms.PictureBox()
        Me.Lab_th2 = New System.Windows.Forms.Label()
        Me.P_TMSRV = New System.Windows.Forms.PictureBox()
        Me.T_C_alim = New System.Windows.Forms.Label()
        Me.T_alim = New System.Windows.Forms.Label()
        Me.Lab_log = New System.Windows.Forms.Label()
        Me.Led_Test = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.Led_master = New System.Windows.Forms.Label()
        Me.Pict_cam = New System.Windows.Forms.PictureBox()
        Me.Lab_th = New System.Windows.Forms.Label()
        Me.Lab_plc = New System.Windows.Forms.Label()
        Me.Pict_run1 = New System.Windows.Forms.PictureBox()
        Me.Pict_plc = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Lab_Logo = New System.Windows.Forms.Label()
        Me.Pulsantosissimo = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Pict_run2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P_DB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P_TMSRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pict_cam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pict_run1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pict_plc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.DimGray
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripMargin = New System.Windows.Forms.Padding(1)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(55, 55)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_home, Me.Tool_lavoro, Me.Tool_Robot, Me.Tool_Visioni, Me.Tool_Parametri, Me.Tool_sinottico, Me.Tool_manuali, Me.Tool_pezzi, Me.Tool_esiti, Me.Toll_CelleCarico, Me.Tool_10, Me.Tool_versione, Me.Tool_magazz, Me.Tool_Exit, Me.Tool_alarm, Me.Tool_Storico, Me.ToolEsiti, Me.Tool_Log_in, Me.Tool_tast_num})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 930)
        Me.ToolStrip1.Margin = New System.Windows.Forms.Padding(1)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1895, 80)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "Tool"
        '
        'Tool_home
        '
        Me.Tool_home.AutoSize = False
        Me.Tool_home.BackColor = System.Drawing.Color.Silver
        Me.Tool_home.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_home.Image = CType(resources.GetObject("Tool_home.Image"), System.Drawing.Image)
        Me.Tool_home.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_home.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_home.Margin = New System.Windows.Forms.Padding(1)
        Me.Tool_home.Name = "Tool_home"
        Me.Tool_home.Size = New System.Drawing.Size(75, 70)
        Me.Tool_home.Text = "HOME"
        Me.Tool_home.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Tool_lavoro
        '
        Me.Tool_lavoro.AutoSize = False
        Me.Tool_lavoro.BackColor = System.Drawing.Color.Silver
        Me.Tool_lavoro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_lavoro.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_lavoro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_lavoro.Margin = New System.Windows.Forms.Padding(1)
        Me.Tool_lavoro.Name = "Tool_lavoro"
        Me.Tool_lavoro.Size = New System.Drawing.Size(75, 70)
        Me.Tool_lavoro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_lavoro.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'Tool_Robot
        '
        Me.Tool_Robot.AutoSize = False
        Me.Tool_Robot.BackColor = System.Drawing.Color.Silver
        Me.Tool_Robot.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_Robot.Image = CType(resources.GetObject("Tool_Robot.Image"), System.Drawing.Image)
        Me.Tool_Robot.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_Robot.Margin = New System.Windows.Forms.Padding(1)
        Me.Tool_Robot.Name = "Tool_Robot"
        Me.Tool_Robot.Size = New System.Drawing.Size(75, 70)
        Me.Tool_Robot.Text = "Robot"
        Me.Tool_Robot.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_Robot.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'Tool_Visioni
        '
        Me.Tool_Visioni.AutoSize = False
        Me.Tool_Visioni.BackColor = System.Drawing.Color.Silver
        Me.Tool_Visioni.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_Visioni.Image = CType(resources.GetObject("Tool_Visioni.Image"), System.Drawing.Image)
        Me.Tool_Visioni.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_Visioni.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Visioni.Margin = New System.Windows.Forms.Padding(1)
        Me.Tool_Visioni.Name = "Tool_Visioni"
        Me.Tool_Visioni.Size = New System.Drawing.Size(75, 70)
        Me.Tool_Visioni.Text = "Telecamere"
        Me.Tool_Visioni.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_Visioni.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'Tool_Parametri
        '
        Me.Tool_Parametri.AutoSize = False
        Me.Tool_Parametri.BackColor = System.Drawing.Color.DarkGray
        Me.Tool_Parametri.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_Parametri.Image = CType(resources.GetObject("Tool_Parametri.Image"), System.Drawing.Image)
        Me.Tool_Parametri.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_Parametri.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Parametri.Margin = New System.Windows.Forms.Padding(1)
        Me.Tool_Parametri.Name = "Tool_Parametri"
        Me.Tool_Parametri.Size = New System.Drawing.Size(75, 70)
        Me.Tool_Parametri.Text = "PARAMETRI"
        Me.Tool_Parametri.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_Parametri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Tool_sinottico
        '
        Me.Tool_sinottico.AutoSize = False
        Me.Tool_sinottico.BackColor = System.Drawing.Color.DarkGray
        Me.Tool_sinottico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_sinottico.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_sinottico.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_sinottico.Margin = New System.Windows.Forms.Padding(1)
        Me.Tool_sinottico.Name = "Tool_sinottico"
        Me.Tool_sinottico.Size = New System.Drawing.Size(75, 70)
        Me.Tool_sinottico.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_sinottico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Tool_manuali
        '
        Me.Tool_manuali.AutoSize = False
        Me.Tool_manuali.BackColor = System.Drawing.Color.LightYellow
        Me.Tool_manuali.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_manuali.Image = CType(resources.GetObject("Tool_manuali.Image"), System.Drawing.Image)
        Me.Tool_manuali.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_manuali.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_manuali.Margin = New System.Windows.Forms.Padding(1)
        Me.Tool_manuali.Name = "Tool_manuali"
        Me.Tool_manuali.Size = New System.Drawing.Size(75, 70)
        Me.Tool_manuali.Text = "MANUALI"
        Me.Tool_manuali.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_manuali.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Tool_pezzi
        '
        Me.Tool_pezzi.AutoSize = False
        Me.Tool_pezzi.BackColor = System.Drawing.Color.Silver
        Me.Tool_pezzi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_pezzi.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_pezzi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_pezzi.Margin = New System.Windows.Forms.Padding(1)
        Me.Tool_pezzi.Name = "Tool_pezzi"
        Me.Tool_pezzi.Size = New System.Drawing.Size(75, 70)
        Me.Tool_pezzi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_pezzi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Tool_esiti
        '
        Me.Tool_esiti.AutoSize = False
        Me.Tool_esiti.BackColor = System.Drawing.Color.Silver
        Me.Tool_esiti.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_esiti.Image = CType(resources.GetObject("Tool_esiti.Image"), System.Drawing.Image)
        Me.Tool_esiti.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_esiti.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_esiti.Margin = New System.Windows.Forms.Padding(1)
        Me.Tool_esiti.Name = "Tool_esiti"
        Me.Tool_esiti.Size = New System.Drawing.Size(75, 70)
        Me.Tool_esiti.Text = "Sinottico"
        Me.Tool_esiti.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_esiti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Toll_CelleCarico
        '
        Me.Toll_CelleCarico.AutoSize = False
        Me.Toll_CelleCarico.BackColor = System.Drawing.Color.Silver
        Me.Toll_CelleCarico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Toll_CelleCarico.Image = CType(resources.GetObject("Toll_CelleCarico.Image"), System.Drawing.Image)
        Me.Toll_CelleCarico.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Toll_CelleCarico.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Toll_CelleCarico.Margin = New System.Windows.Forms.Padding(1)
        Me.Toll_CelleCarico.Name = "Toll_CelleCarico"
        Me.Toll_CelleCarico.Size = New System.Drawing.Size(75, 70)
        Me.Toll_CelleCarico.Text = "Celle carico"
        Me.Toll_CelleCarico.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Toll_CelleCarico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Tool_10
        '
        Me.Tool_10.AutoSize = False
        Me.Tool_10.BackColor = System.Drawing.Color.Silver
        Me.Tool_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_10.Image = Global.Controllo.My.Resources.Resources._1489158935_Model
        Me.Tool_10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_10.Margin = New System.Windows.Forms.Padding(1)
        Me.Tool_10.Name = "Tool_10"
        Me.Tool_10.Size = New System.Drawing.Size(75, 70)
        Me.Tool_10.Text = "Punti Robot"
        Me.Tool_10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Tool_10.ToolTipText = "Punti Robot"
        '
        'Tool_versione
        '
        Me.Tool_versione.AutoSize = False
        Me.Tool_versione.BackColor = System.Drawing.Color.Gold
        Me.Tool_versione.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_versione.Image = CType(resources.GetObject("Tool_versione.Image"), System.Drawing.Image)
        Me.Tool_versione.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_versione.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_versione.Margin = New System.Windows.Forms.Padding(1)
        Me.Tool_versione.Name = "Tool_versione"
        Me.Tool_versione.Size = New System.Drawing.Size(75, 70)
        Me.Tool_versione.Text = "Sel. Articoli"
        Me.Tool_versione.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_versione.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Tool_magazz
        '
        Me.Tool_magazz.AutoSize = False
        Me.Tool_magazz.BackColor = System.Drawing.Color.Silver
        Me.Tool_magazz.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_magazz.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_magazz.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_magazz.Margin = New System.Windows.Forms.Padding(1)
        Me.Tool_magazz.Name = "Tool_magazz"
        Me.Tool_magazz.Size = New System.Drawing.Size(75, 70)
        Me.Tool_magazz.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_magazz.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'Tool_Exit
        '
        Me.Tool_Exit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Tool_Exit.AutoSize = False
        Me.Tool_Exit.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Tool_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_Exit.Image = CType(resources.GetObject("Tool_Exit.Image"), System.Drawing.Image)
        Me.Tool_Exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_Exit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Exit.Margin = New System.Windows.Forms.Padding(1)
        Me.Tool_Exit.Name = "Tool_Exit"
        Me.Tool_Exit.Size = New System.Drawing.Size(75, 70)
        Me.Tool_Exit.Text = "EXIT"
        Me.Tool_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'Tool_alarm
        '
        Me.Tool_alarm.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Tool_alarm.AutoSize = False
        Me.Tool_alarm.BackColor = System.Drawing.Color.Silver
        Me.Tool_alarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_alarm.Image = CType(resources.GetObject("Tool_alarm.Image"), System.Drawing.Image)
        Me.Tool_alarm.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_alarm.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_alarm.Margin = New System.Windows.Forms.Padding(1)
        Me.Tool_alarm.Name = "Tool_alarm"
        Me.Tool_alarm.Size = New System.Drawing.Size(75, 70)
        Me.Tool_alarm.Text = "Allarmi"
        Me.Tool_alarm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_alarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Tool_Storico
        '
        Me.Tool_Storico.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Tool_Storico.AutoSize = False
        Me.Tool_Storico.BackColor = System.Drawing.Color.LightCyan
        Me.Tool_Storico.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_Storico.Image = CType(resources.GetObject("Tool_Storico.Image"), System.Drawing.Image)
        Me.Tool_Storico.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_Storico.Margin = New System.Windows.Forms.Padding(1)
        Me.Tool_Storico.Name = "Tool_Storico"
        Me.Tool_Storico.Size = New System.Drawing.Size(75, 70)
        Me.Tool_Storico.Text = "STORICO"
        Me.Tool_Storico.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_Storico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolEsiti
        '
        Me.ToolEsiti.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolEsiti.AutoSize = False
        Me.ToolEsiti.BackColor = System.Drawing.Color.LightCyan
        Me.ToolEsiti.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolEsiti.Image = CType(resources.GetObject("ToolEsiti.Image"), System.Drawing.Image)
        Me.ToolEsiti.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolEsiti.Margin = New System.Windows.Forms.Padding(1)
        Me.ToolEsiti.Name = "ToolEsiti"
        Me.ToolEsiti.Size = New System.Drawing.Size(75, 70)
        Me.ToolEsiti.Text = "ESITI"
        Me.ToolEsiti.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolEsiti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Tool_Log_in
        '
        Me.Tool_Log_in.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Tool_Log_in.AutoSize = False
        Me.Tool_Log_in.BackColor = System.Drawing.Color.AliceBlue
        Me.Tool_Log_in.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_Log_in.Image = CType(resources.GetObject("Tool_Log_in.Image"), System.Drawing.Image)
        Me.Tool_Log_in.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_Log_in.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Log_in.Margin = New System.Windows.Forms.Padding(1)
        Me.Tool_Log_in.Name = "Tool_Log_in"
        Me.Tool_Log_in.Size = New System.Drawing.Size(75, 70)
        Me.Tool_Log_in.Text = "UTENTI"
        Me.Tool_Log_in.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_Log_in.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Tool_tast_num
        '
        Me.Tool_tast_num.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Tool_tast_num.AutoSize = False
        Me.Tool_tast_num.BackColor = System.Drawing.Color.AliceBlue
        Me.Tool_tast_num.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_tast_num.Image = CType(resources.GetObject("Tool_tast_num.Image"), System.Drawing.Image)
        Me.Tool_tast_num.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_tast_num.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_tast_num.Margin = New System.Windows.Forms.Padding(1)
        Me.Tool_tast_num.Name = "Tool_tast_num"
        Me.Tool_tast_num.Size = New System.Drawing.Size(75, 70)
        Me.Tool_tast_num.Text = "Tastiera"
        Me.Tool_tast_num.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_tast_num.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Lab_stato)
        Me.Panel2.Controls.Add(Me.Lab_versione)
        Me.Panel2.Controls.Add(Me.Lab_banco)
        Me.Panel2.Controls.Add(Me.Lab_titolo)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(259, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(466, 96)
        Me.Panel2.TabIndex = 14
        '
        'Lab_stato
        '
        Me.Lab_stato.BackColor = System.Drawing.Color.Cyan
        Me.Lab_stato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_stato.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Lab_stato.Location = New System.Drawing.Point(237, 62)
        Me.Lab_stato.Name = "Lab_stato"
        Me.Lab_stato.Size = New System.Drawing.Size(222, 29)
        Me.Lab_stato.TabIndex = 5
        Me.Lab_stato.Text = "##########"
        Me.Lab_stato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_versione
        '
        Me.Lab_versione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lab_versione.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_versione.ForeColor = System.Drawing.Color.MediumOrchid
        Me.Lab_versione.Location = New System.Drawing.Point(108, 30)
        Me.Lab_versione.Name = "Lab_versione"
        Me.Lab_versione.Size = New System.Drawing.Size(280, 22)
        Me.Lab_versione.TabIndex = 5
        Me.Lab_versione.Text = "######"
        Me.Lab_versione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_banco
        '
        Me.Lab_banco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lab_banco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_banco.ForeColor = System.Drawing.Color.ForestGreen
        Me.Lab_banco.Location = New System.Drawing.Point(108, 4)
        Me.Lab_banco.Name = "Lab_banco"
        Me.Lab_banco.Size = New System.Drawing.Size(280, 22)
        Me.Lab_banco.TabIndex = 3
        Me.Lab_banco.Text = "######"
        Me.Lab_banco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_titolo
        '
        Me.Lab_titolo.BackColor = System.Drawing.Color.Lime
        Me.Lab_titolo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_titolo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_titolo.Location = New System.Drawing.Point(5, 62)
        Me.Lab_titolo.Name = "Lab_titolo"
        Me.Lab_titolo.Size = New System.Drawing.Size(222, 29)
        Me.Lab_titolo.TabIndex = 3
        Me.Lab_titolo.Text = "##########"
        Me.Lab_titolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PRODOTTO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(6, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MODELLO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "A.png")
        Me.ImageList1.Images.SetKeyName(1, "B.png")
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Msg_text)
        Me.Panel3.Location = New System.Drawing.Point(731, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(661, 96)
        Me.Panel3.TabIndex = 15
        '
        'Msg_text
        '
        Me.Msg_text.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Msg_text.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Msg_text.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Msg_text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Msg_text.Location = New System.Drawing.Point(1, 1)
        Me.Msg_text.Multiline = True
        Me.Msg_text.Name = "Msg_text"
        Me.Msg_text.ReadOnly = True
        Me.Msg_text.Size = New System.Drawing.Size(656, 92)
        Me.Msg_text.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Pulsantosissimo)
        Me.Panel1.Controls.Add(Me.Pict_run2)
        Me.Panel1.Controls.Add(Me.P_DB)
        Me.Panel1.Controls.Add(Me.Lab_th2)
        Me.Panel1.Controls.Add(Me.P_TMSRV)
        Me.Panel1.Controls.Add(Me.T_C_alim)
        Me.Panel1.Controls.Add(Me.T_alim)
        Me.Panel1.Controls.Add(Me.Lab_log)
        Me.Panel1.Controls.Add(Me.Led_Test)
        Me.Panel1.Controls.Add(Me.Led_master)
        Me.Panel1.Controls.Add(Me.Pict_cam)
        Me.Panel1.Controls.Add(Me.Lab_th)
        Me.Panel1.Controls.Add(Me.Lab_plc)
        Me.Panel1.Controls.Add(Me.Pict_run1)
        Me.Panel1.Controls.Add(Me.Pict_plc)
        Me.Panel1.Location = New System.Drawing.Point(1418, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 96)
        Me.Panel1.TabIndex = 17
        '
        'Pict_run2
        '
        Me.Pict_run2.Image = CType(resources.GetObject("Pict_run2.Image"), System.Drawing.Image)
        Me.Pict_run2.Location = New System.Drawing.Point(50, 60)
        Me.Pict_run2.Name = "Pict_run2"
        Me.Pict_run2.Size = New System.Drawing.Size(30, 30)
        Me.Pict_run2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pict_run2.TabIndex = 65
        Me.Pict_run2.TabStop = False
        Me.Pict_run2.Visible = False
        '
        'P_DB
        '
        Me.P_DB.BackColor = System.Drawing.Color.Transparent
        Me.P_DB.BackgroundImage = CType(resources.GetObject("P_DB.BackgroundImage"), System.Drawing.Image)
        Me.P_DB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.P_DB.Location = New System.Drawing.Point(385, 8)
        Me.P_DB.Name = "P_DB"
        Me.P_DB.Size = New System.Drawing.Size(30, 30)
        Me.P_DB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P_DB.TabIndex = 64
        Me.P_DB.TabStop = False
        Me.P_DB.Visible = False
        '
        'Lab_th2
        '
        Me.Lab_th2.Location = New System.Drawing.Point(47, 40)
        Me.Lab_th2.Name = "Lab_th2"
        Me.Lab_th2.Size = New System.Drawing.Size(40, 15)
        Me.Lab_th2.TabIndex = 63
        Me.Lab_th2.Text = "####"
        Me.Lab_th2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'P_TMSRV
        '
        Me.P_TMSRV.BackColor = System.Drawing.Color.Transparent
        Me.P_TMSRV.BackgroundImage = CType(resources.GetObject("P_TMSRV.BackgroundImage"), System.Drawing.Image)
        Me.P_TMSRV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.P_TMSRV.Location = New System.Drawing.Point(344, 8)
        Me.P_TMSRV.Name = "P_TMSRV"
        Me.P_TMSRV.Size = New System.Drawing.Size(30, 30)
        Me.P_TMSRV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P_TMSRV.TabIndex = 62
        Me.P_TMSRV.TabStop = False
        Me.P_TMSRV.Visible = False
        '
        'T_C_alim
        '
        Me.T_C_alim.Location = New System.Drawing.Point(319, 66)
        Me.T_C_alim.Name = "T_C_alim"
        Me.T_C_alim.Size = New System.Drawing.Size(40, 15)
        Me.T_C_alim.TabIndex = 61
        Me.T_C_alim.Text = "####"
        Me.T_C_alim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.T_C_alim.Visible = False
        '
        'T_alim
        '
        Me.T_alim.Location = New System.Drawing.Point(319, 48)
        Me.T_alim.Name = "T_alim"
        Me.T_alim.Size = New System.Drawing.Size(40, 15)
        Me.T_alim.TabIndex = 60
        Me.T_alim.Text = "####"
        Me.T_alim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.T_alim.Visible = False
        '
        'Lab_log
        '
        Me.Lab_log.BackColor = System.Drawing.Color.Transparent
        Me.Lab_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lab_log.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_log.ForeColor = System.Drawing.Color.Yellow
        Me.Lab_log.Image = CType(resources.GetObject("Lab_log.Image"), System.Drawing.Image)
        Me.Lab_log.Location = New System.Drawing.Point(93, 4)
        Me.Lab_log.Name = "Lab_log"
        Me.Lab_log.Size = New System.Drawing.Size(40, 40)
        Me.Lab_log.TabIndex = 43
        Me.Lab_log.Text = "0"
        Me.Lab_log.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Lab_log.Visible = False
        '
        'Led_Test
        '
        Me.Led_Test.BackColor = System.Drawing.Color.Transparent
        Me.Led_Test.BlinkInterval = 500
        Me.Led_Test.Label = ""
        Me.Led_Test.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Right
        Me.Led_Test.LedColor = System.Drawing.Color.Yellow
        Me.Led_Test.LedSize = New System.Drawing.SizeF(15.0!, 15.0!)
        Me.Led_Test.Location = New System.Drawing.Point(176, 35)
        Me.Led_Test.Margin = New System.Windows.Forms.Padding(0)
        Me.Led_Test.Name = "Led_Test"
        Me.Led_Test.Renderer = Nothing
        Me.Led_Test.Size = New System.Drawing.Size(17, 17)
        Me.Led_Test.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Blink
        Me.Led_Test.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.Led_Test.TabIndex = 42
        Me.Led_Test.Visible = False
        '
        'Led_master
        '
        Me.Led_master.ForeColor = System.Drawing.Color.Blue
        Me.Led_master.Image = CType(resources.GetObject("Led_master.Image"), System.Drawing.Image)
        Me.Led_master.Location = New System.Drawing.Point(175, 12)
        Me.Led_master.Name = "Led_master"
        Me.Led_master.Size = New System.Drawing.Size(18, 18)
        Me.Led_master.TabIndex = 41
        Me.Led_master.Text = "9"
        Me.Led_master.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Led_master.Visible = False
        '
        'Pict_cam
        '
        Me.Pict_cam.Image = CType(resources.GetObject("Pict_cam.Image"), System.Drawing.Image)
        Me.Pict_cam.Location = New System.Drawing.Point(139, 10)
        Me.Pict_cam.Name = "Pict_cam"
        Me.Pict_cam.Size = New System.Drawing.Size(30, 30)
        Me.Pict_cam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pict_cam.TabIndex = 32
        Me.Pict_cam.TabStop = False
        Me.Pict_cam.Visible = False
        '
        'Lab_th
        '
        Me.Lab_th.Location = New System.Drawing.Point(4, 40)
        Me.Lab_th.Name = "Lab_th"
        Me.Lab_th.Size = New System.Drawing.Size(35, 15)
        Me.Lab_th.TabIndex = 30
        Me.Lab_th.Text = "####"
        Me.Lab_th.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_plc
        '
        Me.Lab_plc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lab_plc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_plc.ForeColor = System.Drawing.Color.Blue
        Me.Lab_plc.Location = New System.Drawing.Point(93, 64)
        Me.Lab_plc.Name = "Lab_plc"
        Me.Lab_plc.Size = New System.Drawing.Size(151, 20)
        Me.Lab_plc.TabIndex = 6
        Me.Lab_plc.Text = "######"
        Me.Lab_plc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_plc.Visible = False
        '
        'Pict_run1
        '
        Me.Pict_run1.Image = CType(resources.GetObject("Pict_run1.Image"), System.Drawing.Image)
        Me.Pict_run1.Location = New System.Drawing.Point(6, 60)
        Me.Pict_run1.Name = "Pict_run1"
        Me.Pict_run1.Size = New System.Drawing.Size(30, 30)
        Me.Pict_run1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pict_run1.TabIndex = 2
        Me.Pict_run1.TabStop = False
        Me.Pict_run1.Visible = False
        '
        'Pict_plc
        '
        Me.Pict_plc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pict_plc.Image = CType(resources.GetObject("Pict_plc.Image"), System.Drawing.Image)
        Me.Pict_plc.Location = New System.Drawing.Point(3, 2)
        Me.Pict_plc.Name = "Pict_plc"
        Me.Pict_plc.Size = New System.Drawing.Size(55, 35)
        Me.Pict_plc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Pict_plc.TabIndex = 1
        Me.Pict_plc.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 200
        '
        'Timer3
        '
        Me.Timer3.Interval = 500000
        '
        'Timer4
        '
        Me.Timer4.Interval = 45000
        '
        'Timer5
        '
        Me.Timer5.Interval = 4000
        '
        'Timer6
        '
        Me.Timer6.Interval = 1500
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "Eutomatik_logo.png")
        Me.ImageList2.Images.SetKeyName(1, "Costantin_Inn.jpg")
        Me.ImageList2.Images.SetKeyName(2, "Logo Saiee ok.JPG")
        '
        'Lab_Logo
        '
        Me.Lab_Logo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lab_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lab_Logo.ImageIndex = 1
        Me.Lab_Logo.ImageList = Me.ImageList2
        Me.Lab_Logo.Location = New System.Drawing.Point(3, 2)
        Me.Lab_Logo.Name = "Lab_Logo"
        Me.Lab_Logo.Size = New System.Drawing.Size(250, 96)
        Me.Lab_Logo.TabIndex = 52
        Me.Lab_Logo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Pulsantosissimo
        '
        Me.Pulsantosissimo.Location = New System.Drawing.Point(420, 67)
        Me.Pulsantosissimo.Name = "Pulsantosissimo"
        Me.Pulsantosissimo.Size = New System.Drawing.Size(53, 22)
        Me.Pulsantosissimo.TabIndex = 66
        Me.Pulsantosissimo.Text = "Button1"
        Me.Pulsantosissimo.UseVisualStyleBackColor = True
        Me.Pulsantosissimo.Visible = False
        '
        'F_main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1904, 1011)
        Me.Controls.Add(Me.Lab_Logo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "OLED"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Pict_run2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P_DB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P_TMSRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pict_cam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pict_run1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pict_plc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_lavoro As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_sinottico As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Parametri As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lab_banco As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Lab_titolo As System.Windows.Forms.Label
    Friend WithEvents Tool_home As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_esiti As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_manuali As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_tast_num As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Log_in As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Exit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Lab_versione As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Tool_versione As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_alarm As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Tool_pezzi As System.Windows.Forms.ToolStripButton
    Friend WithEvents Toll_CelleCarico As System.Windows.Forms.ToolStripButton
    Friend WithEvents Pict_plc As System.Windows.Forms.PictureBox
    Friend WithEvents Pict_run1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lab_plc As System.Windows.Forms.Label
    Friend WithEvents Msg_text As System.Windows.Forms.TextBox
    Friend WithEvents Lab_stato As System.Windows.Forms.Label
    Friend WithEvents Tool_Visioni As System.Windows.Forms.ToolStripButton
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Lab_th As System.Windows.Forms.Label
    Friend WithEvents Tool_magazz As System.Windows.Forms.ToolStripButton
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Pict_cam As System.Windows.Forms.PictureBox
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Led_master As System.Windows.Forms.Label
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Led_Test As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents Lab_log As System.Windows.Forms.Label
    Friend WithEvents T_C_alim As Label
    Friend WithEvents T_alim As Label
    Friend WithEvents P_TMSRV As PictureBox
    Friend WithEvents Lab_th2 As Label
    Friend WithEvents P_DB As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Tool_Robot As ToolStripButton
    Friend WithEvents Lab_Logo As Label
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents Tool_Storico As ToolStripButton
    Friend WithEvents ToolEsiti As ToolStripButton
    Friend WithEvents Pict_run2 As PictureBox
    Friend WithEvents Pulsantosissimo As Button
End Class

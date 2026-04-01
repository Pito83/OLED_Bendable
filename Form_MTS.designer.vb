<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_MTS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_MTS))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_OK = New System.Windows.Forms.ToolStripButton()
        Me.Tool_abort = New System.Windows.Forms.ToolStripButton()
        Me.ToolNewDb = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.T_Pr_Des = New System.Windows.Forms.TextBox()
        Me.Txt_BaseAdd = New System.Windows.Forms.TextBox()
        Me.Txt_Consist = New System.Windows.Forms.TextBox()
        Me.Txt_Traceab = New System.Windows.Forms.TextBox()
        Me.Txt_Alarms = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_BaseAddD = New System.Windows.Forms.TextBox()
        Me.Txt_TraceTokD = New System.Windows.Forms.TextBox()
        Me.Txt_ConsTokD = New System.Windows.Forms.TextBox()
        Me.Txt_TraceabD = New System.Windows.Forms.TextBox()
        Me.Txt_ConsistD = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Txt_AlarmTok = New System.Windows.Forms.TextBox()
        Me.Txt_TraceTok = New System.Windows.Forms.TextBox()
        Me.Txt_ConsTok = New System.Windows.Forms.TextBox()
        Me.T_Pr_Id = New Txt_box.T_box()
        Me.T_S_IDs = New Txt_box.T_box()
        Me.T_S_IDd = New Txt_box.T_box()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.T_S_De_s = New System.Windows.Forms.TextBox()
        Me.T_S_De_d = New System.Windows.Forms.TextBox()
        Me.Gr_Fasi = New System.Windows.Forms.GroupBox()
        Me.DG1 = New System.Windows.Forms.DataGridView()
        Me.Sc5 = New Txt_box.T_box()
        Me.Sc4 = New Txt_box.T_box()
        Me.Sc3 = New Txt_box.T_box()
        Me.Sc2 = New Txt_box.T_box()
        Me.Sc1 = New Txt_box.T_box()
        Me.Sc0 = New Txt_box.T_box()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Chk_Cons = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DesD5 = New System.Windows.Forms.TextBox()
        Me.IDD5 = New Txt_box.T_box()
        Me.DesS5 = New System.Windows.Forms.TextBox()
        Me.IDS5 = New Txt_box.T_box()
        Me.DesD4 = New System.Windows.Forms.TextBox()
        Me.DesD3 = New System.Windows.Forms.TextBox()
        Me.DesD2 = New System.Windows.Forms.TextBox()
        Me.DesD1 = New System.Windows.Forms.TextBox()
        Me.DesD0 = New System.Windows.Forms.TextBox()
        Me.DesS4 = New System.Windows.Forms.TextBox()
        Me.DesS3 = New System.Windows.Forms.TextBox()
        Me.DesS2 = New System.Windows.Forms.TextBox()
        Me.DesS1 = New System.Windows.Forms.TextBox()
        Me.DesS0 = New System.Windows.Forms.TextBox()
        Me.IDD4 = New Txt_box.T_box()
        Me.IDD3 = New Txt_box.T_box()
        Me.IDD2 = New Txt_box.T_box()
        Me.IDD1 = New Txt_box.T_box()
        Me.IDD0 = New Txt_box.T_box()
        Me.IDS4 = New Txt_box.T_box()
        Me.IDS3 = New Txt_box.T_box()
        Me.IDS2 = New Txt_box.T_box()
        Me.IDS1 = New Txt_box.T_box()
        Me.IDS0 = New Txt_box.T_box()
        Me.T_Pr_Id_d = New Txt_box.T_box()
        Me.T_Pr_Des_d = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Gr_Fasi.SuspendLayout()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.DimGray
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(50, 50)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_OK, Me.Tool_abort, Me.ToolNewDb})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(8, 709)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1010, 79)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "Tool"
        '
        'Tool_OK
        '
        Me.Tool_OK.AutoSize = False
        Me.Tool_OK.BackColor = System.Drawing.Color.AliceBlue
        Me.Tool_OK.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_OK.Image = CType(resources.GetObject("Tool_OK.Image"), System.Drawing.Image)
        Me.Tool_OK.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_OK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_OK.Margin = New System.Windows.Forms.Padding(2)
        Me.Tool_OK.Name = "Tool_OK"
        Me.Tool_OK.Size = New System.Drawing.Size(75, 67)
        Me.Tool_OK.Text = "OK"
        Me.Tool_OK.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Tool_abort
        '
        Me.Tool_abort.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Tool_abort.AutoSize = False
        Me.Tool_abort.BackColor = System.Drawing.Color.AliceBlue
        Me.Tool_abort.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_abort.Image = CType(resources.GetObject("Tool_abort.Image"), System.Drawing.Image)
        Me.Tool_abort.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_abort.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_abort.Margin = New System.Windows.Forms.Padding(2)
        Me.Tool_abort.Name = "Tool_abort"
        Me.Tool_abort.Size = New System.Drawing.Size(75, 67)
        Me.Tool_abort.Text = "Abort"
        Me.Tool_abort.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_abort.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ToolNewDb
        '
        Me.ToolNewDb.AutoSize = False
        Me.ToolNewDb.BackColor = System.Drawing.Color.DarkGray
        Me.ToolNewDb.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolNewDb.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolNewDb.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolNewDb.Margin = New System.Windows.Forms.Padding(2)
        Me.ToolNewDb.Name = "ToolNewDb"
        Me.ToolNewDb.Size = New System.Drawing.Size(75, 67)
        Me.ToolNewDb.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolNewDb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolNewDb.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1009, 36)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "DSM  SETTINGS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.DarkGray
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(188, 35)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "LINE  ID"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 35)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "LINE  DESCRIPTION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 26)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "BASE ADDRESS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 26)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Consistency Thread name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DarkGray
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 35)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "OPERATION ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 26)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Traceability Thread Name"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 26)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Alarms Thread name"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'T_Pr_Des
        '
        Me.T_Pr_Des.BackColor = System.Drawing.Color.Gainsboro
        Me.T_Pr_Des.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_Pr_Des.Location = New System.Drawing.Point(206, 90)
        Me.T_Pr_Des.Name = "T_Pr_Des"
        Me.T_Pr_Des.Size = New System.Drawing.Size(400, 22)
        Me.T_Pr_Des.TabIndex = 60
        Me.T_Pr_Des.Text = "##"
        Me.T_Pr_Des.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_BaseAdd
        '
        Me.Txt_BaseAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_BaseAdd.Location = New System.Drawing.Point(194, 15)
        Me.Txt_BaseAdd.Name = "Txt_BaseAdd"
        Me.Txt_BaseAdd.Size = New System.Drawing.Size(400, 26)
        Me.Txt_BaseAdd.TabIndex = 61
        Me.Txt_BaseAdd.Text = "##"
        Me.Txt_BaseAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Consist
        '
        Me.Txt_Consist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Consist.Location = New System.Drawing.Point(194, 47)
        Me.Txt_Consist.Name = "Txt_Consist"
        Me.Txt_Consist.Size = New System.Drawing.Size(400, 26)
        Me.Txt_Consist.TabIndex = 62
        Me.Txt_Consist.Text = "#########################"
        Me.Txt_Consist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Traceab
        '
        Me.Txt_Traceab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Traceab.Location = New System.Drawing.Point(194, 111)
        Me.Txt_Traceab.Name = "Txt_Traceab"
        Me.Txt_Traceab.Size = New System.Drawing.Size(400, 26)
        Me.Txt_Traceab.TabIndex = 64
        Me.Txt_Traceab.Text = "##"
        Me.Txt_Traceab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Alarms
        '
        Me.Txt_Alarms.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Alarms.Location = New System.Drawing.Point(366, 178)
        Me.Txt_Alarms.Name = "Txt_Alarms"
        Me.Txt_Alarms.Size = New System.Drawing.Size(467, 29)
        Me.Txt_Alarms.TabIndex = 66
        Me.Txt_Alarms.Text = "##"
        Me.Txt_Alarms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Txt_BaseAddD)
        Me.GroupBox1.Controls.Add(Me.Txt_TraceTokD)
        Me.GroupBox1.Controls.Add(Me.Txt_ConsTokD)
        Me.GroupBox1.Controls.Add(Me.Txt_TraceabD)
        Me.GroupBox1.Controls.Add(Me.Txt_ConsistD)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Txt_AlarmTok)
        Me.GroupBox1.Controls.Add(Me.Txt_TraceTok)
        Me.GroupBox1.Controls.Add(Me.Txt_ConsTok)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_Alarms)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Txt_Traceab)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Txt_Consist)
        Me.GroupBox1.Controls.Add(Me.Txt_BaseAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 460)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1010, 246)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'Txt_BaseAddD
        '
        Me.Txt_BaseAddD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_BaseAddD.Location = New System.Drawing.Point(600, 15)
        Me.Txt_BaseAddD.Name = "Txt_BaseAddD"
        Me.Txt_BaseAddD.Size = New System.Drawing.Size(400, 26)
        Me.Txt_BaseAddD.TabIndex = 78
        Me.Txt_BaseAddD.Text = "##"
        Me.Txt_BaseAddD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_TraceTokD
        '
        Me.Txt_TraceTokD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TraceTokD.Location = New System.Drawing.Point(600, 146)
        Me.Txt_TraceTokD.Name = "Txt_TraceTokD"
        Me.Txt_TraceTokD.Size = New System.Drawing.Size(400, 22)
        Me.Txt_TraceTokD.TabIndex = 77
        Me.Txt_TraceTokD.Text = "##"
        Me.Txt_TraceTokD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_ConsTokD
        '
        Me.Txt_ConsTokD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ConsTokD.Location = New System.Drawing.Point(600, 82)
        Me.Txt_ConsTokD.Name = "Txt_ConsTokD"
        Me.Txt_ConsTokD.Size = New System.Drawing.Size(400, 22)
        Me.Txt_ConsTokD.TabIndex = 76
        Me.Txt_ConsTokD.Text = "##"
        Me.Txt_ConsTokD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_TraceabD
        '
        Me.Txt_TraceabD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TraceabD.Location = New System.Drawing.Point(600, 111)
        Me.Txt_TraceabD.Name = "Txt_TraceabD"
        Me.Txt_TraceabD.Size = New System.Drawing.Size(400, 26)
        Me.Txt_TraceabD.TabIndex = 74
        Me.Txt_TraceabD.Text = "##"
        Me.Txt_TraceabD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_ConsistD
        '
        Me.Txt_ConsistD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ConsistD.Location = New System.Drawing.Point(600, 47)
        Me.Txt_ConsistD.Name = "Txt_ConsistD"
        Me.Txt_ConsistD.Size = New System.Drawing.Size(400, 26)
        Me.Txt_ConsistD.TabIndex = 73
        Me.Txt_ConsistD.Text = "#########################"
        Me.Txt_ConsistD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Silver
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(6, 210)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(182, 26)
        Me.Label24.TabIndex = 72
        Me.Label24.Text = "Alarms Token"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Silver
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(6, 143)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(182, 26)
        Me.Label23.TabIndex = 71
        Me.Label23.Text = "Traceability Token"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Silver
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 79)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(182, 26)
        Me.Label22.TabIndex = 70
        Me.Label22.Text = "Consistency Token"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_AlarmTok
        '
        Me.Txt_AlarmTok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_AlarmTok.Location = New System.Drawing.Point(366, 213)
        Me.Txt_AlarmTok.Name = "Txt_AlarmTok"
        Me.Txt_AlarmTok.Size = New System.Drawing.Size(467, 26)
        Me.Txt_AlarmTok.TabIndex = 69
        Me.Txt_AlarmTok.Text = "##"
        Me.Txt_AlarmTok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_TraceTok
        '
        Me.Txt_TraceTok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TraceTok.Location = New System.Drawing.Point(194, 146)
        Me.Txt_TraceTok.Name = "Txt_TraceTok"
        Me.Txt_TraceTok.Size = New System.Drawing.Size(400, 22)
        Me.Txt_TraceTok.TabIndex = 68
        Me.Txt_TraceTok.Text = "##"
        Me.Txt_TraceTok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_ConsTok
        '
        Me.Txt_ConsTok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ConsTok.Location = New System.Drawing.Point(194, 82)
        Me.Txt_ConsTok.Name = "Txt_ConsTok"
        Me.Txt_ConsTok.Size = New System.Drawing.Size(400, 22)
        Me.Txt_ConsTok.TabIndex = 67
        Me.Txt_ConsTok.Text = "##"
        Me.Txt_ConsTok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'T_Pr_Id
        '
        Me.T_Pr_Id.BackColor = System.Drawing.Color.Gainsboro
        Me.T_Pr_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_Pr_Id.Format_num = "0"
        Me.T_Pr_Id.Location = New System.Drawing.Point(305, 45)
        Me.T_Pr_Id.Max = 99999.0R
        Me.T_Pr_Id.Min = 1.0R
        Me.T_Pr_Id.Msg = False
        Me.T_Pr_Id.Name = "T_Pr_Id"
        Me.T_Pr_Id.Only_Enter = False
        Me.T_Pr_Id.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.T_Pr_Id.Size = New System.Drawing.Size(170, 30)
        Me.T_Pr_Id.TabIndex = 68
        Me.T_Pr_Id.Test_si = False
        Me.T_Pr_Id.Text = "1"
        Me.T_Pr_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_Pr_Id.Value = 1.0R
        '
        'T_S_IDs
        '
        Me.T_S_IDs.BackColor = System.Drawing.Color.Gainsboro
        Me.T_S_IDs.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_S_IDs.Format_num = "0"
        Me.T_S_IDs.Location = New System.Drawing.Point(305, 123)
        Me.T_S_IDs.Max = 99999.0R
        Me.T_S_IDs.Min = 1.0R
        Me.T_S_IDs.Msg = False
        Me.T_S_IDs.Name = "T_S_IDs"
        Me.T_S_IDs.Only_Enter = False
        Me.T_S_IDs.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.T_S_IDs.Size = New System.Drawing.Size(170, 30)
        Me.T_S_IDs.TabIndex = 71
        Me.T_S_IDs.Test_si = False
        Me.T_S_IDs.Text = "1"
        Me.T_S_IDs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_S_IDs.Value = 1.0R
        '
        'T_S_IDd
        '
        Me.T_S_IDd.BackColor = System.Drawing.Color.Gainsboro
        Me.T_S_IDd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_S_IDd.Format_num = "0"
        Me.T_S_IDd.Location = New System.Drawing.Point(714, 123)
        Me.T_S_IDd.Max = 99999.0R
        Me.T_S_IDd.Min = 1.0R
        Me.T_S_IDd.Msg = False
        Me.T_S_IDd.Name = "T_S_IDd"
        Me.T_S_IDd.Only_Enter = False
        Me.T_S_IDd.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.T_S_IDd.Size = New System.Drawing.Size(170, 30)
        Me.T_S_IDd.TabIndex = 72
        Me.T_S_IDd.Test_si = False
        Me.T_S_IDd.Text = "1"
        Me.T_S_IDd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_S_IDd.Value = 1.0R
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DarkGray
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 35)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "OPERATION DESCRIPTION"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'T_S_De_s
        '
        Me.T_S_De_s.BackColor = System.Drawing.Color.Gainsboro
        Me.T_S_De_s.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_S_De_s.Location = New System.Drawing.Point(283, 165)
        Me.T_S_De_s.Name = "T_S_De_s"
        Me.T_S_De_s.Size = New System.Drawing.Size(214, 26)
        Me.T_S_De_s.TabIndex = 74
        Me.T_S_De_s.Text = "##"
        Me.T_S_De_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'T_S_De_d
        '
        Me.T_S_De_d.BackColor = System.Drawing.Color.Gainsboro
        Me.T_S_De_d.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_S_De_d.Location = New System.Drawing.Point(691, 165)
        Me.T_S_De_d.Name = "T_S_De_d"
        Me.T_S_De_d.Size = New System.Drawing.Size(214, 26)
        Me.T_S_De_d.TabIndex = 75
        Me.T_S_De_d.Text = "##"
        Me.T_S_De_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Gr_Fasi
        '
        Me.Gr_Fasi.Controls.Add(Me.DG1)
        Me.Gr_Fasi.Controls.Add(Me.Sc5)
        Me.Gr_Fasi.Controls.Add(Me.Sc4)
        Me.Gr_Fasi.Controls.Add(Me.Sc3)
        Me.Gr_Fasi.Controls.Add(Me.Sc2)
        Me.Gr_Fasi.Controls.Add(Me.Sc1)
        Me.Gr_Fasi.Controls.Add(Me.Sc0)
        Me.Gr_Fasi.Controls.Add(Me.Label21)
        Me.Gr_Fasi.Controls.Add(Me.Label20)
        Me.Gr_Fasi.Controls.Add(Me.Label19)
        Me.Gr_Fasi.Controls.Add(Me.Label18)
        Me.Gr_Fasi.Controls.Add(Me.Label17)
        Me.Gr_Fasi.Controls.Add(Me.Chk_Cons)
        Me.Gr_Fasi.Controls.Add(Me.Label16)
        Me.Gr_Fasi.Controls.Add(Me.DesD5)
        Me.Gr_Fasi.Controls.Add(Me.IDD5)
        Me.Gr_Fasi.Controls.Add(Me.DesS5)
        Me.Gr_Fasi.Controls.Add(Me.IDS5)
        Me.Gr_Fasi.Controls.Add(Me.DesD4)
        Me.Gr_Fasi.Controls.Add(Me.DesD3)
        Me.Gr_Fasi.Controls.Add(Me.DesD2)
        Me.Gr_Fasi.Controls.Add(Me.DesD1)
        Me.Gr_Fasi.Controls.Add(Me.DesD0)
        Me.Gr_Fasi.Controls.Add(Me.DesS4)
        Me.Gr_Fasi.Controls.Add(Me.DesS3)
        Me.Gr_Fasi.Controls.Add(Me.DesS2)
        Me.Gr_Fasi.Controls.Add(Me.DesS1)
        Me.Gr_Fasi.Controls.Add(Me.DesS0)
        Me.Gr_Fasi.Controls.Add(Me.IDD4)
        Me.Gr_Fasi.Controls.Add(Me.IDD3)
        Me.Gr_Fasi.Controls.Add(Me.IDD2)
        Me.Gr_Fasi.Controls.Add(Me.IDD1)
        Me.Gr_Fasi.Controls.Add(Me.IDD0)
        Me.Gr_Fasi.Controls.Add(Me.IDS4)
        Me.Gr_Fasi.Controls.Add(Me.IDS3)
        Me.Gr_Fasi.Controls.Add(Me.IDS2)
        Me.Gr_Fasi.Controls.Add(Me.IDS1)
        Me.Gr_Fasi.Controls.Add(Me.IDS0)
        Me.Gr_Fasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gr_Fasi.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Gr_Fasi.Location = New System.Drawing.Point(8, 203)
        Me.Gr_Fasi.Name = "Gr_Fasi"
        Me.Gr_Fasi.Size = New System.Drawing.Size(1010, 252)
        Me.Gr_Fasi.TabIndex = 76
        Me.Gr_Fasi.TabStop = False
        Me.Gr_Fasi.Text = "DSM Phases"
        Me.Gr_Fasi.Visible = False
        '
        'DG1
        '
        Me.DG1.AllowUserToAddRows = False
        Me.DG1.ColumnHeadersHeight = 26
        Me.DG1.Location = New System.Drawing.Point(6, 16)
        Me.DG1.Name = "DG1"
        Me.DG1.RowHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DG1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DG1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DG1.RowTemplate.Height = 28
        Me.DG1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DG1.ShowCellErrors = False
        Me.DG1.Size = New System.Drawing.Size(161, 192)
        Me.DG1.TabIndex = 93
        '
        'Sc5
        '
        Me.Sc5.BackColor = System.Drawing.Color.Gainsboro
        Me.Sc5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sc5.Format_num = "0"
        Me.Sc5.Location = New System.Drawing.Point(584, 189)
        Me.Sc5.Max = 999.0R
        Me.Sc5.Min = -1.0R
        Me.Sc5.Msg = False
        Me.Sc5.Name = "Sc5"
        Me.Sc5.Only_Enter = False
        Me.Sc5.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.Sc5.Size = New System.Drawing.Size(40, 20)
        Me.Sc5.TabIndex = 109
        Me.Sc5.Test_si = False
        Me.Sc5.Text = "1"
        Me.Sc5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Sc5.Value = 1.0R
        '
        'Sc4
        '
        Me.Sc4.BackColor = System.Drawing.Color.Gainsboro
        Me.Sc4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sc4.Format_num = "0"
        Me.Sc4.Location = New System.Drawing.Point(584, 162)
        Me.Sc4.Max = 999.0R
        Me.Sc4.Min = -1.0R
        Me.Sc4.Msg = False
        Me.Sc4.Name = "Sc4"
        Me.Sc4.Only_Enter = False
        Me.Sc4.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.Sc4.Size = New System.Drawing.Size(40, 20)
        Me.Sc4.TabIndex = 108
        Me.Sc4.Test_si = False
        Me.Sc4.Text = "1"
        Me.Sc4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Sc4.Value = 1.0R
        '
        'Sc3
        '
        Me.Sc3.BackColor = System.Drawing.Color.Gainsboro
        Me.Sc3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sc3.Format_num = "0"
        Me.Sc3.Location = New System.Drawing.Point(584, 134)
        Me.Sc3.Max = 999.0R
        Me.Sc3.Min = -1.0R
        Me.Sc3.Msg = False
        Me.Sc3.Name = "Sc3"
        Me.Sc3.Only_Enter = False
        Me.Sc3.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.Sc3.Size = New System.Drawing.Size(40, 20)
        Me.Sc3.TabIndex = 107
        Me.Sc3.Test_si = False
        Me.Sc3.Text = "1"
        Me.Sc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Sc3.Value = 1.0R
        '
        'Sc2
        '
        Me.Sc2.BackColor = System.Drawing.Color.Gainsboro
        Me.Sc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sc2.Format_num = "0"
        Me.Sc2.Location = New System.Drawing.Point(584, 106)
        Me.Sc2.Max = 999.0R
        Me.Sc2.Min = -1.0R
        Me.Sc2.Msg = False
        Me.Sc2.Name = "Sc2"
        Me.Sc2.Only_Enter = False
        Me.Sc2.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.Sc2.Size = New System.Drawing.Size(40, 20)
        Me.Sc2.TabIndex = 106
        Me.Sc2.Test_si = False
        Me.Sc2.Text = "1"
        Me.Sc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Sc2.Value = 1.0R
        '
        'Sc1
        '
        Me.Sc1.BackColor = System.Drawing.Color.Gainsboro
        Me.Sc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sc1.Format_num = "0"
        Me.Sc1.Location = New System.Drawing.Point(584, 78)
        Me.Sc1.Max = 999.0R
        Me.Sc1.Min = -1.0R
        Me.Sc1.Msg = False
        Me.Sc1.Name = "Sc1"
        Me.Sc1.Only_Enter = False
        Me.Sc1.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.Sc1.Size = New System.Drawing.Size(40, 20)
        Me.Sc1.TabIndex = 105
        Me.Sc1.Test_si = False
        Me.Sc1.Text = "1"
        Me.Sc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Sc1.Value = 1.0R
        '
        'Sc0
        '
        Me.Sc0.BackColor = System.Drawing.Color.Gainsboro
        Me.Sc0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sc0.Format_num = "0"
        Me.Sc0.Location = New System.Drawing.Point(584, 50)
        Me.Sc0.Max = 999.0R
        Me.Sc0.Min = -1.0R
        Me.Sc0.Msg = False
        Me.Sc0.Name = "Sc0"
        Me.Sc0.Only_Enter = False
        Me.Sc0.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.Sc0.Size = New System.Drawing.Size(40, 20)
        Me.Sc0.TabIndex = 104
        Me.Sc0.Test_si = False
        Me.Sc0.Text = "1"
        Me.Sc0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Sc0.Value = 1.0R
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.DarkGray
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(722, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(175, 25)
        Me.Label21.TabIndex = 103
        Me.Label21.Text = "Description"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.DarkGray
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(314, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(175, 25)
        Me.Label20.TabIndex = 102
        Me.Label20.Text = "Description"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.DarkGray
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(683, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 25)
        Me.Label19.TabIndex = 101
        Me.Label19.Text = "ID"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.DarkGray
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(275, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 25)
        Me.Label18.TabIndex = 100
        Me.Label18.Text = "ID"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.DarkGray
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(572, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 25)
        Me.Label17.TabIndex = 99
        Me.Label17.Text = "Scrap"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Chk_Cons
        '
        Me.Chk_Cons.AutoSize = True
        Me.Chk_Cons.BackColor = System.Drawing.Color.Silver
        Me.Chk_Cons.Location = New System.Drawing.Point(354, 225)
        Me.Chk_Cons.Name = "Chk_Cons"
        Me.Chk_Cons.Size = New System.Drawing.Size(15, 14)
        Me.Chk_Cons.TabIndex = 98
        Me.Chk_Cons.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.DarkGray
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(5, 218)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label16.Size = New System.Drawing.Size(283, 25)
        Me.Label16.TabIndex = 97
        Me.Label16.Text = "Consistecy without  (#)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DesD5
        '
        Me.DesD5.BackColor = System.Drawing.Color.Gainsboro
        Me.DesD5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesD5.Location = New System.Drawing.Point(722, 188)
        Me.DesD5.Name = "DesD5"
        Me.DesD5.Size = New System.Drawing.Size(175, 21)
        Me.DesD5.TabIndex = 96
        Me.DesD5.Text = "##"
        Me.DesD5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IDD5
        '
        Me.IDD5.BackColor = System.Drawing.Color.Gainsboro
        Me.IDD5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDD5.Format_num = "0"
        Me.IDD5.Location = New System.Drawing.Point(683, 188)
        Me.IDD5.Max = 999.0R
        Me.IDD5.Min = -1.0R
        Me.IDD5.Msg = False
        Me.IDD5.Name = "IDD5"
        Me.IDD5.Only_Enter = False
        Me.IDD5.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.IDD5.Size = New System.Drawing.Size(35, 20)
        Me.IDD5.TabIndex = 95
        Me.IDD5.Test_si = False
        Me.IDD5.Text = "1"
        Me.IDD5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IDD5.Value = 1.0R
        '
        'DesS5
        '
        Me.DesS5.BackColor = System.Drawing.Color.Gainsboro
        Me.DesS5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesS5.Location = New System.Drawing.Point(314, 188)
        Me.DesS5.Name = "DesS5"
        Me.DesS5.Size = New System.Drawing.Size(175, 21)
        Me.DesS5.TabIndex = 94
        Me.DesS5.Text = "##"
        Me.DesS5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IDS5
        '
        Me.IDS5.BackColor = System.Drawing.Color.Gainsboro
        Me.IDS5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDS5.Format_num = "0"
        Me.IDS5.Location = New System.Drawing.Point(275, 188)
        Me.IDS5.Max = 999.0R
        Me.IDS5.Min = -1.0R
        Me.IDS5.Msg = False
        Me.IDS5.Name = "IDS5"
        Me.IDS5.Only_Enter = False
        Me.IDS5.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.IDS5.Size = New System.Drawing.Size(35, 20)
        Me.IDS5.TabIndex = 93
        Me.IDS5.Test_si = False
        Me.IDS5.Text = "1"
        Me.IDS5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IDS5.Value = 1.0R
        '
        'DesD4
        '
        Me.DesD4.BackColor = System.Drawing.Color.Gainsboro
        Me.DesD4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesD4.Location = New System.Drawing.Point(722, 161)
        Me.DesD4.Name = "DesD4"
        Me.DesD4.Size = New System.Drawing.Size(175, 21)
        Me.DesD4.TabIndex = 91
        Me.DesD4.Text = "##"
        Me.DesD4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DesD3
        '
        Me.DesD3.BackColor = System.Drawing.Color.Gainsboro
        Me.DesD3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesD3.Location = New System.Drawing.Point(722, 133)
        Me.DesD3.Name = "DesD3"
        Me.DesD3.Size = New System.Drawing.Size(175, 21)
        Me.DesD3.TabIndex = 90
        Me.DesD3.Text = "##"
        Me.DesD3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DesD2
        '
        Me.DesD2.BackColor = System.Drawing.Color.Gainsboro
        Me.DesD2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesD2.Location = New System.Drawing.Point(722, 105)
        Me.DesD2.Name = "DesD2"
        Me.DesD2.Size = New System.Drawing.Size(175, 21)
        Me.DesD2.TabIndex = 89
        Me.DesD2.Text = "##"
        Me.DesD2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DesD1
        '
        Me.DesD1.BackColor = System.Drawing.Color.Gainsboro
        Me.DesD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesD1.Location = New System.Drawing.Point(722, 77)
        Me.DesD1.Name = "DesD1"
        Me.DesD1.Size = New System.Drawing.Size(175, 21)
        Me.DesD1.TabIndex = 88
        Me.DesD1.Text = "##"
        Me.DesD1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DesD0
        '
        Me.DesD0.BackColor = System.Drawing.Color.Gainsboro
        Me.DesD0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesD0.Location = New System.Drawing.Point(722, 49)
        Me.DesD0.Name = "DesD0"
        Me.DesD0.Size = New System.Drawing.Size(175, 21)
        Me.DesD0.TabIndex = 87
        Me.DesD0.Text = "##"
        Me.DesD0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DesS4
        '
        Me.DesS4.BackColor = System.Drawing.Color.Gainsboro
        Me.DesS4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesS4.Location = New System.Drawing.Point(314, 161)
        Me.DesS4.Name = "DesS4"
        Me.DesS4.Size = New System.Drawing.Size(175, 21)
        Me.DesS4.TabIndex = 86
        Me.DesS4.Text = "##"
        Me.DesS4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DesS3
        '
        Me.DesS3.BackColor = System.Drawing.Color.Gainsboro
        Me.DesS3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesS3.Location = New System.Drawing.Point(314, 133)
        Me.DesS3.Name = "DesS3"
        Me.DesS3.Size = New System.Drawing.Size(175, 21)
        Me.DesS3.TabIndex = 85
        Me.DesS3.Text = "##"
        Me.DesS3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DesS2
        '
        Me.DesS2.BackColor = System.Drawing.Color.Gainsboro
        Me.DesS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesS2.Location = New System.Drawing.Point(314, 105)
        Me.DesS2.Name = "DesS2"
        Me.DesS2.Size = New System.Drawing.Size(175, 21)
        Me.DesS2.TabIndex = 84
        Me.DesS2.Text = "##"
        Me.DesS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DesS1
        '
        Me.DesS1.BackColor = System.Drawing.Color.Gainsboro
        Me.DesS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesS1.Location = New System.Drawing.Point(314, 77)
        Me.DesS1.Name = "DesS1"
        Me.DesS1.Size = New System.Drawing.Size(175, 21)
        Me.DesS1.TabIndex = 83
        Me.DesS1.Text = "##"
        Me.DesS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DesS0
        '
        Me.DesS0.BackColor = System.Drawing.Color.Gainsboro
        Me.DesS0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesS0.Location = New System.Drawing.Point(314, 49)
        Me.DesS0.Name = "DesS0"
        Me.DesS0.Size = New System.Drawing.Size(175, 21)
        Me.DesS0.TabIndex = 82
        Me.DesS0.Text = "##"
        Me.DesS0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IDD4
        '
        Me.IDD4.BackColor = System.Drawing.Color.Gainsboro
        Me.IDD4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDD4.Format_num = "0"
        Me.IDD4.Location = New System.Drawing.Point(683, 161)
        Me.IDD4.Max = 999.0R
        Me.IDD4.Min = -1.0R
        Me.IDD4.Msg = False
        Me.IDD4.Name = "IDD4"
        Me.IDD4.Only_Enter = False
        Me.IDD4.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.IDD4.Size = New System.Drawing.Size(35, 20)
        Me.IDD4.TabIndex = 81
        Me.IDD4.Test_si = False
        Me.IDD4.Text = "1"
        Me.IDD4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IDD4.Value = 1.0R
        '
        'IDD3
        '
        Me.IDD3.BackColor = System.Drawing.Color.Gainsboro
        Me.IDD3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDD3.Format_num = "0"
        Me.IDD3.Location = New System.Drawing.Point(683, 133)
        Me.IDD3.Max = 999.0R
        Me.IDD3.Min = -1.0R
        Me.IDD3.Msg = False
        Me.IDD3.Name = "IDD3"
        Me.IDD3.Only_Enter = False
        Me.IDD3.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.IDD3.Size = New System.Drawing.Size(35, 20)
        Me.IDD3.TabIndex = 80
        Me.IDD3.Test_si = False
        Me.IDD3.Text = "1"
        Me.IDD3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IDD3.Value = 1.0R
        '
        'IDD2
        '
        Me.IDD2.BackColor = System.Drawing.Color.Gainsboro
        Me.IDD2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDD2.Format_num = "0"
        Me.IDD2.Location = New System.Drawing.Point(683, 105)
        Me.IDD2.Max = 999.0R
        Me.IDD2.Min = -1.0R
        Me.IDD2.Msg = False
        Me.IDD2.Name = "IDD2"
        Me.IDD2.Only_Enter = False
        Me.IDD2.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.IDD2.Size = New System.Drawing.Size(35, 20)
        Me.IDD2.TabIndex = 79
        Me.IDD2.Test_si = False
        Me.IDD2.Text = "1"
        Me.IDD2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IDD2.Value = 1.0R
        '
        'IDD1
        '
        Me.IDD1.BackColor = System.Drawing.Color.Gainsboro
        Me.IDD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDD1.Format_num = "0"
        Me.IDD1.Location = New System.Drawing.Point(683, 77)
        Me.IDD1.Max = 999.0R
        Me.IDD1.Min = -1.0R
        Me.IDD1.Msg = False
        Me.IDD1.Name = "IDD1"
        Me.IDD1.Only_Enter = False
        Me.IDD1.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.IDD1.Size = New System.Drawing.Size(35, 20)
        Me.IDD1.TabIndex = 78
        Me.IDD1.Test_si = False
        Me.IDD1.Text = "1"
        Me.IDD1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IDD1.Value = 1.0R
        '
        'IDD0
        '
        Me.IDD0.BackColor = System.Drawing.Color.Gainsboro
        Me.IDD0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDD0.Format_num = "0"
        Me.IDD0.Location = New System.Drawing.Point(683, 49)
        Me.IDD0.Max = 999.0R
        Me.IDD0.Min = -1.0R
        Me.IDD0.Msg = False
        Me.IDD0.Name = "IDD0"
        Me.IDD0.Only_Enter = False
        Me.IDD0.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.IDD0.Size = New System.Drawing.Size(35, 20)
        Me.IDD0.TabIndex = 77
        Me.IDD0.Test_si = False
        Me.IDD0.Text = "1"
        Me.IDD0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IDD0.Value = 1.0R
        '
        'IDS4
        '
        Me.IDS4.BackColor = System.Drawing.Color.Gainsboro
        Me.IDS4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDS4.Format_num = "0"
        Me.IDS4.Location = New System.Drawing.Point(275, 161)
        Me.IDS4.Max = 999.0R
        Me.IDS4.Min = -1.0R
        Me.IDS4.Msg = False
        Me.IDS4.Name = "IDS4"
        Me.IDS4.Only_Enter = False
        Me.IDS4.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.IDS4.Size = New System.Drawing.Size(35, 20)
        Me.IDS4.TabIndex = 76
        Me.IDS4.Test_si = False
        Me.IDS4.Text = "1"
        Me.IDS4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IDS4.Value = 1.0R
        '
        'IDS3
        '
        Me.IDS3.BackColor = System.Drawing.Color.Gainsboro
        Me.IDS3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDS3.Format_num = "0"
        Me.IDS3.Location = New System.Drawing.Point(275, 133)
        Me.IDS3.Max = 999.0R
        Me.IDS3.Min = -1.0R
        Me.IDS3.Msg = False
        Me.IDS3.Name = "IDS3"
        Me.IDS3.Only_Enter = False
        Me.IDS3.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.IDS3.Size = New System.Drawing.Size(35, 20)
        Me.IDS3.TabIndex = 75
        Me.IDS3.Test_si = False
        Me.IDS3.Text = "1"
        Me.IDS3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IDS3.Value = 1.0R
        '
        'IDS2
        '
        Me.IDS2.BackColor = System.Drawing.Color.Gainsboro
        Me.IDS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDS2.Format_num = "0"
        Me.IDS2.Location = New System.Drawing.Point(275, 105)
        Me.IDS2.Max = 999.0R
        Me.IDS2.Min = -1.0R
        Me.IDS2.Msg = False
        Me.IDS2.Name = "IDS2"
        Me.IDS2.Only_Enter = False
        Me.IDS2.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.IDS2.Size = New System.Drawing.Size(35, 20)
        Me.IDS2.TabIndex = 74
        Me.IDS2.Test_si = False
        Me.IDS2.Text = "1"
        Me.IDS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IDS2.Value = 1.0R
        '
        'IDS1
        '
        Me.IDS1.BackColor = System.Drawing.Color.Gainsboro
        Me.IDS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDS1.Format_num = "0"
        Me.IDS1.Location = New System.Drawing.Point(275, 77)
        Me.IDS1.Max = 999.0R
        Me.IDS1.Min = -1.0R
        Me.IDS1.Msg = False
        Me.IDS1.Name = "IDS1"
        Me.IDS1.Only_Enter = False
        Me.IDS1.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.IDS1.Size = New System.Drawing.Size(35, 20)
        Me.IDS1.TabIndex = 73
        Me.IDS1.Test_si = False
        Me.IDS1.Text = "1"
        Me.IDS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IDS1.Value = 1.0R
        '
        'IDS0
        '
        Me.IDS0.BackColor = System.Drawing.Color.Gainsboro
        Me.IDS0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDS0.Format_num = "0"
        Me.IDS0.Location = New System.Drawing.Point(275, 49)
        Me.IDS0.Max = 999.0R
        Me.IDS0.Min = -1.0R
        Me.IDS0.Msg = False
        Me.IDS0.Name = "IDS0"
        Me.IDS0.Only_Enter = False
        Me.IDS0.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.IDS0.Size = New System.Drawing.Size(35, 20)
        Me.IDS0.TabIndex = 72
        Me.IDS0.Test_si = False
        Me.IDS0.Text = "1"
        Me.IDS0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IDS0.Value = 1.0R
        '
        'T_Pr_Id_d
        '
        Me.T_Pr_Id_d.BackColor = System.Drawing.Color.Gainsboro
        Me.T_Pr_Id_d.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_Pr_Id_d.Format_num = "0"
        Me.T_Pr_Id_d.Location = New System.Drawing.Point(714, 50)
        Me.T_Pr_Id_d.Max = 99999.0R
        Me.T_Pr_Id_d.Min = 1.0R
        Me.T_Pr_Id_d.Msg = False
        Me.T_Pr_Id_d.Name = "T_Pr_Id_d"
        Me.T_Pr_Id_d.Only_Enter = False
        Me.T_Pr_Id_d.Orig_Bk_Color = System.Drawing.Color.Gainsboro
        Me.T_Pr_Id_d.Size = New System.Drawing.Size(170, 30)
        Me.T_Pr_Id_d.TabIndex = 77
        Me.T_Pr_Id_d.Test_si = False
        Me.T_Pr_Id_d.Text = "1"
        Me.T_Pr_Id_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_Pr_Id_d.Value = 1.0R
        '
        'T_Pr_Des_d
        '
        Me.T_Pr_Des_d.BackColor = System.Drawing.Color.Gainsboro
        Me.T_Pr_Des_d.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_Pr_Des_d.Location = New System.Drawing.Point(614, 90)
        Me.T_Pr_Des_d.Name = "T_Pr_Des_d"
        Me.T_Pr_Des_d.Size = New System.Drawing.Size(400, 22)
        Me.T_Pr_Des_d.TabIndex = 78
        Me.T_Pr_Des_d.Text = "##"
        Me.T_Pr_Des_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form_MTS
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1024, 794)
        Me.ControlBox = False
        Me.Controls.Add(Me.T_Pr_Des_d)
        Me.Controls.Add(Me.T_Pr_Id_d)
        Me.Controls.Add(Me.Gr_Fasi)
        Me.Controls.Add(Me.T_S_De_d)
        Me.Controls.Add(Me.T_S_De_s)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.T_S_IDd)
        Me.Controls.Add(Me.T_S_IDs)
        Me.Controls.Add(Me.T_Pr_Id)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.T_Pr_Des)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form_MTS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Gr_Fasi.ResumeLayout(False)
        Me.Gr_Fasi.PerformLayout()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_OK As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_abort As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents T_Pr_Des As TextBox
    Friend WithEvents Txt_BaseAdd As TextBox
    Friend WithEvents Txt_Consist As TextBox
    Friend WithEvents Txt_Traceab As TextBox
    Friend WithEvents Txt_Alarms As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents T_Pr_Id As Txt_box.T_box
    Friend WithEvents T_S_IDs As Txt_box.T_box
    Friend WithEvents T_S_IDd As Txt_box.T_box
    Friend WithEvents Label8 As Label
    Friend WithEvents T_S_De_s As TextBox
    Friend WithEvents T_S_De_d As TextBox
    Friend WithEvents Gr_Fasi As GroupBox
    Friend WithEvents DesD4 As TextBox
    Friend WithEvents DesD3 As TextBox
    Friend WithEvents DesD2 As TextBox
    Friend WithEvents DesD1 As TextBox
    Friend WithEvents DesD0 As TextBox
    Friend WithEvents DesS4 As TextBox
    Friend WithEvents DesS3 As TextBox
    Friend WithEvents DesS2 As TextBox
    Friend WithEvents DesS1 As TextBox
    Friend WithEvents DesS0 As TextBox
    Friend WithEvents IDS4 As Txt_box.T_box
    Friend WithEvents IDS3 As Txt_box.T_box
    Friend WithEvents IDS2 As Txt_box.T_box
    Friend WithEvents IDS1 As Txt_box.T_box
    Friend WithEvents IDS0 As Txt_box.T_box
    Friend WithEvents ToolNewDb As ToolStripButton
    Friend WithEvents IDS5 As Txt_box.T_box
    Friend WithEvents DesD5 As TextBox
    Friend WithEvents DesS5 As TextBox
    Friend WithEvents Chk_Cons As CheckBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Sc5 As Txt_box.T_box
    Friend WithEvents Sc4 As Txt_box.T_box
    Friend WithEvents Sc3 As Txt_box.T_box
    Friend WithEvents Sc2 As Txt_box.T_box
    Friend WithEvents Sc1 As Txt_box.T_box
    Friend WithEvents Sc0 As Txt_box.T_box
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Txt_AlarmTok As TextBox
    Friend WithEvents Txt_TraceTok As TextBox
    Friend WithEvents Txt_ConsTok As TextBox
    Friend WithEvents DG1 As DataGridView
    Friend WithEvents Label19 As Label
    Friend WithEvents IDD5 As Txt_box.T_box
    Friend WithEvents IDD4 As Txt_box.T_box
    Friend WithEvents IDD3 As Txt_box.T_box
    Friend WithEvents IDD2 As Txt_box.T_box
    Friend WithEvents IDD1 As Txt_box.T_box
    Friend WithEvents IDD0 As Txt_box.T_box
    Friend WithEvents Txt_TraceTokD As TextBox
    Friend WithEvents Txt_ConsTokD As TextBox
    Friend WithEvents Txt_TraceabD As TextBox
    Friend WithEvents Txt_ConsistD As TextBox
    Friend WithEvents T_Pr_Id_d As Txt_box.T_box
    Friend WithEvents T_Pr_Des_d As TextBox
    Friend WithEvents Txt_BaseAddD As TextBox
End Class

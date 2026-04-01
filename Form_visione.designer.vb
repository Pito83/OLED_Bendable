<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_visione
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_visione))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_exit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salva = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_test = New System.Windows.Forms.ToolStripButton()
        Me.Tool_tast_num = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Combo_vis = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LbLed1 = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.LbLed2 = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.LbLed3 = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.LbLed4 = New LBSoft.IndustrialCtrls.Leds.LBLed()
        Me.Ck_tlc1 = New System.Windows.Forms.CheckBox()
        Me.Group_tlc = New System.Windows.Forms.GroupBox()
        Me.Ck_tlc2 = New System.Windows.Forms.CheckBox()
        Me.Ck_tlc3 = New System.Windows.Forms.CheckBox()
        Me.Ck_tlc4 = New System.Windows.Forms.CheckBox()
        Me.L_Sim = New System.Windows.Forms.Label()
        Me.chbSimulaPLC = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Silver
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(50, 50)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_exit, Me.ToolStripSeparator1, Me.Tool_salva, Me.ToolStripSeparator2, Me.Tool_test, Me.Tool_tast_num, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 943)
        Me.ToolStrip1.Margin = New System.Windows.Forms.Padding(1)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(914, 55)
        Me.ToolStrip1.TabIndex = 4
        '
        'Tool_exit
        '
        Me.Tool_exit.AutoSize = False
        Me.Tool_exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Tool_exit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_exit.ForeColor = System.Drawing.Color.Red
        Me.Tool_exit.Image = CType(resources.GetObject("Tool_exit.Image"), System.Drawing.Image)
        Me.Tool_exit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_exit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_exit.Name = "Tool_exit"
        Me.Tool_exit.Size = New System.Drawing.Size(60, 50)
        Me.Tool_exit.Text = "EXIT"
        Me.Tool_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(2)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 51)
        '
        'Tool_salva
        '
        Me.Tool_salva.AutoSize = False
        Me.Tool_salva.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_salva.ForeColor = System.Drawing.Color.Red
        Me.Tool_salva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_salva.Margin = New System.Windows.Forms.Padding(1)
        Me.Tool_salva.Name = "Tool_salva"
        Me.Tool_salva.Size = New System.Drawing.Size(60, 50)
        Me.Tool_salva.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_salva.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Margin = New System.Windows.Forms.Padding(2)
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 51)
        '
        'Tool_test
        '
        Me.Tool_test.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Tool_test.AutoSize = False
        Me.Tool_test.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Tool_test.Enabled = False
        Me.Tool_test.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_test.ForeColor = System.Drawing.Color.Blue
        Me.Tool_test.Image = CType(resources.GetObject("Tool_test.Image"), System.Drawing.Image)
        Me.Tool_test.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_test.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_test.Margin = New System.Windows.Forms.Padding(1)
        Me.Tool_test.Name = "Tool_test"
        Me.Tool_test.Size = New System.Drawing.Size(60, 50)
        Me.Tool_test.Text = "ESEGUI"
        Me.Tool_test.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_test.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'Tool_tast_num
        '
        Me.Tool_tast_num.AutoSize = False
        Me.Tool_tast_num.BackColor = System.Drawing.Color.AliceBlue
        Me.Tool_tast_num.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_tast_num.Image = CType(resources.GetObject("Tool_tast_num.Image"), System.Drawing.Image)
        Me.Tool_tast_num.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool_tast_num.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_tast_num.Margin = New System.Windows.Forms.Padding(1)
        Me.Tool_tast_num.Name = "Tool_tast_num"
        Me.Tool_tast_num.Size = New System.Drawing.Size(60, 50)
        Me.Tool_tast_num.Text = "Tastiera"
        Me.Tool_tast_num.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_tast_num.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.Enabled = False
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(52, 52)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.Enabled = False
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 52)
        '
        'Combo_vis
        '
        Me.Combo_vis.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_vis.FormattingEnabled = True
        Me.Combo_vis.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10"})
        Me.Combo_vis.Location = New System.Drawing.Point(318, 12)
        Me.Combo_vis.Name = "Combo_vis"
        Me.Combo_vis.Size = New System.Drawing.Size(1388, 33)
        Me.Combo_vis.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(290, 40)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Selezione Visione"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbLed1
        '
        Me.LbLed1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbLed1.BackColor = System.Drawing.Color.DarkGray
        Me.LbLed1.BlinkInterval = 500
        Me.LbLed1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbLed1.Label = "1"
        Me.LbLed1.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.LbLed1.LedColor = System.Drawing.Color.Red
        Me.LbLed1.LedSize = New System.Drawing.SizeF(30.0!, 30.0!)
        Me.LbLed1.Location = New System.Drawing.Point(1491, 938)
        Me.LbLed1.Name = "LbLed1"
        Me.LbLed1.Renderer = Nothing
        Me.LbLed1.Size = New System.Drawing.Size(60, 50)
        Me.LbLed1.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off
        Me.LbLed1.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.LbLed1.TabIndex = 79
        '
        'LbLed2
        '
        Me.LbLed2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbLed2.BackColor = System.Drawing.Color.DarkGray
        Me.LbLed2.BlinkInterval = 500
        Me.LbLed2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbLed2.Label = "2"
        Me.LbLed2.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.LbLed2.LedColor = System.Drawing.Color.Red
        Me.LbLed2.LedSize = New System.Drawing.SizeF(30.0!, 30.0!)
        Me.LbLed2.Location = New System.Drawing.Point(1557, 938)
        Me.LbLed2.Name = "LbLed2"
        Me.LbLed2.Renderer = Nothing
        Me.LbLed2.Size = New System.Drawing.Size(60, 50)
        Me.LbLed2.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off
        Me.LbLed2.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.LbLed2.TabIndex = 80
        '
        'LbLed3
        '
        Me.LbLed3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbLed3.BackColor = System.Drawing.Color.DarkGray
        Me.LbLed3.BlinkInterval = 500
        Me.LbLed3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbLed3.Label = "3"
        Me.LbLed3.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.LbLed3.LedColor = System.Drawing.Color.Red
        Me.LbLed3.LedSize = New System.Drawing.SizeF(30.0!, 30.0!)
        Me.LbLed3.Location = New System.Drawing.Point(1623, 938)
        Me.LbLed3.Name = "LbLed3"
        Me.LbLed3.Renderer = Nothing
        Me.LbLed3.Size = New System.Drawing.Size(60, 50)
        Me.LbLed3.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off
        Me.LbLed3.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.LbLed3.TabIndex = 81
        '
        'LbLed4
        '
        Me.LbLed4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbLed4.BackColor = System.Drawing.Color.DarkGray
        Me.LbLed4.BlinkInterval = 500
        Me.LbLed4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbLed4.Label = "4"
        Me.LbLed4.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top
        Me.LbLed4.LedColor = System.Drawing.Color.Red
        Me.LbLed4.LedSize = New System.Drawing.SizeF(30.0!, 30.0!)
        Me.LbLed4.Location = New System.Drawing.Point(1689, 938)
        Me.LbLed4.Name = "LbLed4"
        Me.LbLed4.Renderer = Nothing
        Me.LbLed4.Size = New System.Drawing.Size(60, 50)
        Me.LbLed4.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off
        Me.LbLed4.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular
        Me.LbLed4.TabIndex = 82
        '
        'Ck_tlc1
        '
        Me.Ck_tlc1.AutoCheck = False
        Me.Ck_tlc1.BackColor = System.Drawing.Color.Gray
        Me.Ck_tlc1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ck_tlc1.Location = New System.Drawing.Point(353, 957)
        Me.Ck_tlc1.Name = "Ck_tlc1"
        Me.Ck_tlc1.Size = New System.Drawing.Size(74, 31)
        Me.Ck_tlc1.TabIndex = 84
        Me.Ck_tlc1.Text = "Ciclo 1"
        Me.Ck_tlc1.UseVisualStyleBackColor = False
        '
        'Group_tlc
        '
        Me.Group_tlc.BackColor = System.Drawing.Color.Transparent
        Me.Group_tlc.Location = New System.Drawing.Point(10, 70)
        Me.Group_tlc.Name = "Group_tlc"
        Me.Group_tlc.Size = New System.Drawing.Size(1738, 862)
        Me.Group_tlc.TabIndex = 100
        Me.Group_tlc.TabStop = False
        '
        'Ck_tlc2
        '
        Me.Ck_tlc2.AutoCheck = False
        Me.Ck_tlc2.BackColor = System.Drawing.Color.Gray
        Me.Ck_tlc2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ck_tlc2.Location = New System.Drawing.Point(433, 957)
        Me.Ck_tlc2.Name = "Ck_tlc2"
        Me.Ck_tlc2.Size = New System.Drawing.Size(74, 31)
        Me.Ck_tlc2.TabIndex = 101
        Me.Ck_tlc2.Text = "Ciclo 2"
        Me.Ck_tlc2.UseVisualStyleBackColor = False
        '
        'Ck_tlc3
        '
        Me.Ck_tlc3.AutoCheck = False
        Me.Ck_tlc3.BackColor = System.Drawing.Color.Gray
        Me.Ck_tlc3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ck_tlc3.Location = New System.Drawing.Point(513, 957)
        Me.Ck_tlc3.Name = "Ck_tlc3"
        Me.Ck_tlc3.Size = New System.Drawing.Size(74, 31)
        Me.Ck_tlc3.TabIndex = 102
        Me.Ck_tlc3.Text = "Ciclo 3"
        Me.Ck_tlc3.UseVisualStyleBackColor = False
        '
        'Ck_tlc4
        '
        Me.Ck_tlc4.AutoCheck = False
        Me.Ck_tlc4.BackColor = System.Drawing.Color.Gray
        Me.Ck_tlc4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ck_tlc4.Location = New System.Drawing.Point(593, 957)
        Me.Ck_tlc4.Name = "Ck_tlc4"
        Me.Ck_tlc4.Size = New System.Drawing.Size(74, 31)
        Me.Ck_tlc4.TabIndex = 103
        Me.Ck_tlc4.Text = "Ciclo 4"
        Me.Ck_tlc4.UseVisualStyleBackColor = False
        '
        'L_Sim
        '
        Me.L_Sim.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.L_Sim.Location = New System.Drawing.Point(696, 943)
        Me.L_Sim.Name = "L_Sim"
        Me.L_Sim.Size = New System.Drawing.Size(100, 23)
        Me.L_Sim.TabIndex = 104
        Me.L_Sim.Text = "###"
        Me.L_Sim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.L_Sim.Visible = False
        '
        'chbSimulaPLC
        '
        Me.chbSimulaPLC.AutoSize = True
        Me.chbSimulaPLC.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chbSimulaPLC.Location = New System.Drawing.Point(759, 971)
        Me.chbSimulaPLC.Name = "chbSimulaPLC"
        Me.chbSimulaPLC.Size = New System.Drawing.Size(89, 17)
        Me.chbSimulaPLC.TabIndex = 105
        Me.chbSimulaPLC.Text = "SIMULA PLC"
        Me.chbSimulaPLC.UseVisualStyleBackColor = False
        '
        'Form_visione
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1760, 1000)
        Me.ControlBox = False
        Me.Controls.Add(Me.chbSimulaPLC)
        Me.Controls.Add(Me.L_Sim)
        Me.Controls.Add(Me.Ck_tlc4)
        Me.Controls.Add(Me.Ck_tlc3)
        Me.Controls.Add(Me.Ck_tlc2)
        Me.Controls.Add(Me.Group_tlc)
        Me.Controls.Add(Me.Ck_tlc1)
        Me.Controls.Add(Me.LbLed4)
        Me.Controls.Add(Me.LbLed3)
        Me.Controls.Add(Me.LbLed2)
        Me.Controls.Add(Me.LbLed1)
        Me.Controls.Add(Me.Combo_vis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_visione"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_salva As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_exit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Combo_vis As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tool_test As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_tast_num As System.Windows.Forms.ToolStripButton
    Friend WithEvents LbLed1 As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents LbLed2 As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents LbLed3 As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents LbLed4 As LBSoft.IndustrialCtrls.Leds.LBLed
    Friend WithEvents Ck_tlc1 As System.Windows.Forms.CheckBox
    Friend WithEvents Group_tlc As GroupBox
    Friend WithEvents Ck_tlc2 As CheckBox
    Friend WithEvents Ck_tlc3 As CheckBox
    Friend WithEvents Ck_tlc4 As CheckBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents L_Sim As Label
    Friend WithEvents chbSimulaPLC As CheckBox
End Class

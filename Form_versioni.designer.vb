<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_versioni
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_versioni))
        Me.Butt_Abort = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.L_Act_Mod = New System.Windows.Forms.Label()
        Me.Butt_select = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lab_Act_vers = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Comb_Mod = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Comb_Vers = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.L_id_m = New System.Windows.Forms.Label()
        Me.L_Id_v = New System.Windows.Forms.Label()
        Me.lv1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lm1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Lm2 = New System.Windows.Forms.Label()
        Me.lv2 = New System.Windows.Forms.Label()
        Me.L_Consenso = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Butt_Abort
        '
        Me.Butt_Abort.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Butt_Abort.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Butt_Abort.BackgroundImage = CType(resources.GetObject("Butt_Abort.BackgroundImage"), System.Drawing.Image)
        Me.Butt_Abort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Butt_Abort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butt_Abort.Location = New System.Drawing.Point(567, 521)
        Me.Butt_Abort.Name = "Butt_Abort"
        Me.Butt_Abort.Size = New System.Drawing.Size(75, 65)
        Me.Butt_Abort.TabIndex = 1
        Me.Butt_Abort.Text = "Abort"
        Me.Butt_Abort.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Butt_Abort.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Modello attuale"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_Act_Mod
        '
        Me.L_Act_Mod.BackColor = System.Drawing.Color.WhiteSmoke
        Me.L_Act_Mod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_Act_Mod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Act_Mod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.L_Act_Mod.Location = New System.Drawing.Point(203, 9)
        Me.L_Act_Mod.Name = "L_Act_Mod"
        Me.L_Act_Mod.Size = New System.Drawing.Size(432, 40)
        Me.L_Act_Mod.TabIndex = 5
        Me.L_Act_Mod.Text = "HHHH"
        Me.L_Act_Mod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Butt_select
        '
        Me.Butt_select.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Butt_select.BackColor = System.Drawing.Color.Yellow
        Me.Butt_select.BackgroundImage = CType(resources.GetObject("Butt_select.BackgroundImage"), System.Drawing.Image)
        Me.Butt_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Butt_select.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butt_select.Location = New System.Drawing.Point(12, 522)
        Me.Butt_select.Name = "Butt_select"
        Me.Butt_select.Size = New System.Drawing.Size(75, 65)
        Me.Butt_select.TabIndex = 38
        Me.Butt_select.Text = "Conferma"
        Me.Butt_select.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Butt_select.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(11, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 40)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Versione attuale"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_Act_vers
        '
        Me.Lab_Act_vers.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lab_Act_vers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_Act_vers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Act_vers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_Act_vers.Location = New System.Drawing.Point(203, 55)
        Me.Lab_Act_vers.Name = "Lab_Act_vers"
        Me.Lab_Act_vers.Size = New System.Drawing.Size(432, 40)
        Me.Lab_Act_vers.TabIndex = 40
        Me.Lab_Act_vers.Text = "##"
        Me.Lab_Act_vers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Lavender
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(14, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 40)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Selezione  MODELLO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Comb_Mod
        '
        Me.Comb_Mod.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comb_Mod.FormattingEnabled = True
        Me.Comb_Mod.Location = New System.Drawing.Point(261, 133)
        Me.Comb_Mod.Name = "Comb_Mod"
        Me.Comb_Mod.Size = New System.Drawing.Size(305, 37)
        Me.Comb_Mod.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Lavender
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(14, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 40)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Selezione  VERSIONE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Comb_Vers
        '
        Me.Comb_Vers.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comb_Vers.FormattingEnabled = True
        Me.Comb_Vers.Location = New System.Drawing.Point(261, 187)
        Me.Comb_Vers.Name = "Comb_Vers"
        Me.Comb_Vers.Size = New System.Drawing.Size(305, 37)
        Me.Comb_Vers.TabIndex = 53
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'L_id_m
        '
        Me.L_id_m.BackColor = System.Drawing.Color.WhiteSmoke
        Me.L_id_m.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_id_m.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_id_m.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.L_id_m.Location = New System.Drawing.Point(575, 133)
        Me.L_id_m.Name = "L_id_m"
        Me.L_id_m.Size = New System.Drawing.Size(60, 40)
        Me.L_id_m.TabIndex = 54
        Me.L_id_m.Text = "##"
        Me.L_id_m.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_Id_v
        '
        Me.L_Id_v.BackColor = System.Drawing.Color.WhiteSmoke
        Me.L_Id_v.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_Id_v.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Id_v.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.L_Id_v.Location = New System.Drawing.Point(575, 187)
        Me.L_Id_v.Name = "L_Id_v"
        Me.L_Id_v.Size = New System.Drawing.Size(60, 40)
        Me.L_Id_v.TabIndex = 55
        Me.L_Id_v.Text = "##"
        Me.L_Id_v.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lv1
        '
        Me.lv1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lv1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lv1.Location = New System.Drawing.Point(206, 410)
        Me.lv1.Name = "lv1"
        Me.lv1.Size = New System.Drawing.Size(432, 40)
        Me.lv1.TabIndex = 59
        Me.lv1.Text = "##"
        Me.lv1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(14, 410)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 40)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Versione scelta"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lm1
        '
        Me.Lm1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lm1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lm1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lm1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lm1.Location = New System.Drawing.Point(206, 240)
        Me.Lm1.Name = "Lm1"
        Me.Lm1.Size = New System.Drawing.Size(432, 40)
        Me.Lm1.TabIndex = 57
        Me.Lm1.Text = "HHHH"
        Me.Lm1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(14, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 40)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Modello scelto"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lm2
        '
        Me.Lm2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lm2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lm2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lm2.Location = New System.Drawing.Point(206, 289)
        Me.Lm2.Name = "Lm2"
        Me.Lm2.Size = New System.Drawing.Size(432, 40)
        Me.Lm2.TabIndex = 60
        Me.Lm2.Text = "HHHH"
        Me.Lm2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lv2
        '
        Me.lv2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lv2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lv2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lv2.Location = New System.Drawing.Point(206, 459)
        Me.lv2.Name = "lv2"
        Me.lv2.Size = New System.Drawing.Size(432, 40)
        Me.lv2.TabIndex = 61
        Me.lv2.Text = "HHHH"
        Me.lv2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_Consenso
        '
        Me.L_Consenso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L_Consenso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_Consenso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Consenso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.L_Consenso.Location = New System.Drawing.Point(180, 521)
        Me.L_Consenso.Name = "L_Consenso"
        Me.L_Consenso.Size = New System.Drawing.Size(326, 67)
        Me.L_Consenso.TabIndex = 62
        Me.L_Consenso.Text = "Manca consenso cambio prodotto"
        Me.L_Consenso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.L_Consenso.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(12, 361)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 40)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Lettura PCB"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(206, 361)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(432, 40)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "UNK"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.Chartreuse
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSave.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(99, 521)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 65)
        Me.btnSave.TabIndex = 65
        Me.btnSave.Text = "SALVA"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Form_versioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(652, 598)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.L_Consenso)
        Me.Controls.Add(Me.lv2)
        Me.Controls.Add(Me.Lm2)
        Me.Controls.Add(Me.lv1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Lm1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.L_Id_v)
        Me.Controls.Add(Me.L_id_m)
        Me.Controls.Add(Me.Comb_Vers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Comb_Mod)
        Me.Controls.Add(Me.Lab_Act_vers)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Butt_select)
        Me.Controls.Add(Me.L_Act_Mod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Butt_Abort)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_versioni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SELEZIONE VERSIONI"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Butt_Abort As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents L_Act_Mod As System.Windows.Forms.Label
    Friend WithEvents Butt_select As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lab_Act_vers As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Comb_Mod As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Comb_Vers As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents L_id_m As Label
    Friend WithEvents L_Id_v As Label
    Friend WithEvents lv1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Lm1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Lm2 As Label
    Friend WithEvents lv2 As Label
    Friend WithEvents L_Consenso As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSave As Button
End Class

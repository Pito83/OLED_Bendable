<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Login))
        Me.Butt_Abort = New System.Windows.Forms.Button()
        Me.Text_pass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Butt_usb = New System.Windows.Forms.Button()
        Me.Lab_Utente = New System.Windows.Forms.Label()
        Me.Lab_msg = New System.Windows.Forms.Label()
        Me.Lab_data = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Butt_Abort
        '
        Me.Butt_Abort.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Butt_Abort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butt_Abort.Image = CType(resources.GetObject("Butt_Abort.Image"), System.Drawing.Image)
        Me.Butt_Abort.Location = New System.Drawing.Point(443, 221)
        Me.Butt_Abort.Name = "Butt_Abort"
        Me.Butt_Abort.Size = New System.Drawing.Size(89, 86)
        Me.Butt_Abort.TabIndex = 0
        Me.Butt_Abort.Text = "Abort"
        Me.Butt_Abort.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Butt_Abort.UseVisualStyleBackColor = True
        '
        'Text_pass
        '
        Me.Text_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_pass.Location = New System.Drawing.Point(160, 30)
        Me.Text_pass.MaxLength = 10
        Me.Text_pass.Name = "Text_pass"
        Me.Text_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Text_pass.Size = New System.Drawing.Size(120, 38)
        Me.Text_pass.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(3, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(286, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Log IN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(412, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 40)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Log OUT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Butt_usb
        '
        Me.Butt_usb.BackgroundImage = CType(resources.GetObject("Butt_usb.BackgroundImage"), System.Drawing.Image)
        Me.Butt_usb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Butt_usb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butt_usb.Location = New System.Drawing.Point(412, 107)
        Me.Butt_usb.Name = "Butt_usb"
        Me.Butt_usb.Size = New System.Drawing.Size(120, 94)
        Me.Butt_usb.TabIndex = 6
        Me.Butt_usb.Text = "Utente"
        Me.Butt_usb.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Lab_Utente
        '
        Me.Lab_Utente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_Utente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Utente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_Utente.Location = New System.Drawing.Point(3, 107)
        Me.Lab_Utente.Name = "Lab_Utente"
        Me.Lab_Utente.Size = New System.Drawing.Size(403, 42)
        Me.Lab_Utente.TabIndex = 7
        Me.Lab_Utente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_msg
        '
        Me.Lab_msg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_msg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_msg.Location = New System.Drawing.Point(3, 250)
        Me.Lab_msg.Name = "Lab_msg"
        Me.Lab_msg.Size = New System.Drawing.Size(403, 57)
        Me.Lab_msg.TabIndex = 8
        Me.Lab_msg.Text = "##"
        Me.Lab_msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_data
        '
        Me.Lab_data.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lab_data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_data.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_data.Location = New System.Drawing.Point(3, 159)
        Me.Lab_data.Name = "Lab_data"
        Me.Lab_data.Size = New System.Drawing.Size(403, 42)
        Me.Lab_data.TabIndex = 9
        Me.Lab_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 309)
        Me.Controls.Add(Me.Lab_data)
        Me.Controls.Add(Me.Lab_msg)
        Me.Controls.Add(Me.Lab_Utente)
        Me.Controls.Add(Me.Butt_usb)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Text_pass)
        Me.Controls.Add(Me.Butt_Abort)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form_Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Butt_Abort As System.Windows.Forms.Button
    Friend WithEvents Text_pass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Butt_usb As System.Windows.Forms.Button
    Friend WithEvents Lab_Utente As System.Windows.Forms.Label
    Friend WithEvents Lab_msg As System.Windows.Forms.Label
    Friend WithEvents Lab_data As System.Windows.Forms.Label
End Class

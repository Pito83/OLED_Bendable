<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_PopUp99_Exit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_PopUp99_Exit))
        Me.Lab_1 = New System.Windows.Forms.Label()
        Me.TimerGUI = New System.Windows.Forms.Timer(Me.components)
        Me.B_No = New System.Windows.Forms.Button()
        Me.B_Si = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lab_1
        '
        Me.Lab_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Lab_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_1.Location = New System.Drawing.Point(26, 9)
        Me.Lab_1.Name = "Lab_1"
        Me.Lab_1.Size = New System.Drawing.Size(588, 55)
        Me.Lab_1.TabIndex = 9
        Me.Lab_1.Text = "USCIRE DALL'APPLICAZIONE ?"
        Me.Lab_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'B_No
        '
        Me.B_No.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.B_No.BackgroundImage = CType(resources.GetObject("B_No.BackgroundImage"), System.Drawing.Image)
        Me.B_No.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.B_No.ForeColor = System.Drawing.Color.Black
        Me.B_No.ImageKey = "forward.png"
        Me.B_No.Location = New System.Drawing.Point(494, 120)
        Me.B_No.Name = "B_No"
        Me.B_No.Size = New System.Drawing.Size(120, 90)
        Me.B_No.TabIndex = 123
        Me.B_No.UseVisualStyleBackColor = False
        '
        'B_Si
        '
        Me.B_Si.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.B_Si.BackgroundImage = CType(resources.GetObject("B_Si.BackgroundImage"), System.Drawing.Image)
        Me.B_Si.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.B_Si.ForeColor = System.Drawing.Color.Black
        Me.B_Si.ImageKey = "forward.png"
        Me.B_Si.Location = New System.Drawing.Point(26, 120)
        Me.B_Si.Name = "B_Si"
        Me.B_Si.Size = New System.Drawing.Size(120, 90)
        Me.B_Si.TabIndex = 124
        Me.B_Si.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.ImageKey = "forward.png"
        Me.Button1.Location = New System.Drawing.Point(338, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 90)
        Me.Button1.TabIndex = 125
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 45)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "ESCI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(338, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 45)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "RIDUCI"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(494, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 45)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "ANNULLA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(182, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 45)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "ESCI  e " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "spegni PC"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.ImageKey = "forward.png"
        Me.Button2.Location = New System.Drawing.Point(182, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 90)
        Me.Button2.TabIndex = 129
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form_PopUp99_Exit
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(625, 214)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.B_Si)
        Me.Controls.Add(Me.B_No)
        Me.Controls.Add(Me.Lab_1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_PopUp99_Exit"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lab_1 As System.Windows.Forms.Label
    Friend WithEvents TimerGUI As System.Windows.Forms.Timer
    Friend WithEvents B_No As Button
    Friend WithEvents B_Si As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
End Class

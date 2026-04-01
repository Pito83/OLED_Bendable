<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_PopUp_YN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_PopUp_YN))
        Me.Lab_1 = New System.Windows.Forms.Label()
        Me.TimerGUI = New System.Windows.Forms.Timer(Me.components)
        Me.B_No = New System.Windows.Forms.Button()
        Me.B_Si = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Pan_Ok = New System.Windows.Forms.Panel()
        Me.Pan_Canc = New System.Windows.Forms.Panel()
        Me.Pan_Ok.SuspendLayout()
        Me.Pan_Canc.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lab_1
        '
        Me.Lab_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Lab_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_1.Location = New System.Drawing.Point(13, 9)
        Me.Lab_1.Name = "Lab_1"
        Me.Lab_1.Size = New System.Drawing.Size(588, 67)
        Me.Lab_1.TabIndex = 9
        Me.Lab_1.Text = "##########"
        Me.Lab_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerGUI
        '
        Me.TimerGUI.Enabled = True
        Me.TimerGUI.Interval = 5000
        '
        'B_No
        '
        Me.B_No.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.B_No.BackgroundImage = CType(resources.GetObject("B_No.BackgroundImage"), System.Drawing.Image)
        Me.B_No.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.B_No.ForeColor = System.Drawing.Color.Black
        Me.B_No.ImageKey = "forward.png"
        Me.B_No.Location = New System.Drawing.Point(12, 54)
        Me.B_No.Name = "B_No"
        Me.B_No.Size = New System.Drawing.Size(120, 90)
        Me.B_No.TabIndex = 123
        Me.B_No.UseVisualStyleBackColor = False
        '
        'B_Si
        '
        Me.B_Si.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.B_Si.BackgroundImage = CType(resources.GetObject("B_Si.BackgroundImage"), System.Drawing.Image)
        Me.B_Si.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.B_Si.ForeColor = System.Drawing.Color.Black
        Me.B_Si.ImageKey = "forward.png"
        Me.B_Si.Location = New System.Drawing.Point(10, 54)
        Me.B_Si.Name = "B_Si"
        Me.B_Si.Size = New System.Drawing.Size(120, 90)
        Me.B_Si.TabIndex = 124
        Me.B_Si.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 45)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "OK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 45)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "ANNULLA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pan_Ok
        '
        Me.Pan_Ok.BackColor = System.Drawing.Color.Transparent
        Me.Pan_Ok.Controls.Add(Me.Label1)
        Me.Pan_Ok.Controls.Add(Me.B_Si)
        Me.Pan_Ok.Location = New System.Drawing.Point(12, 89)
        Me.Pan_Ok.Name = "Pan_Ok"
        Me.Pan_Ok.Size = New System.Drawing.Size(143, 151)
        Me.Pan_Ok.TabIndex = 129
        '
        'Pan_Canc
        '
        Me.Pan_Canc.BackColor = System.Drawing.Color.Transparent
        Me.Pan_Canc.Controls.Add(Me.Label3)
        Me.Pan_Canc.Controls.Add(Me.B_No)
        Me.Pan_Canc.Location = New System.Drawing.Point(458, 89)
        Me.Pan_Canc.Name = "Pan_Canc"
        Me.Pan_Canc.Size = New System.Drawing.Size(143, 151)
        Me.Pan_Canc.TabIndex = 130
        '
        'Form_PopUp_YN
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(606, 244)
        Me.ControlBox = False
        Me.Controls.Add(Me.Pan_Canc)
        Me.Controls.Add(Me.Pan_Ok)
        Me.Controls.Add(Me.Lab_1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_PopUp_YN"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.Pan_Ok.ResumeLayout(False)
        Me.Pan_Canc.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lab_1 As System.Windows.Forms.Label
    Friend WithEvents TimerGUI As System.Windows.Forms.Timer
    Friend WithEvents B_No As Button
    Friend WithEvents B_Si As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Pan_Ok As Panel
    Friend WithEvents Pan_Canc As Panel
End Class

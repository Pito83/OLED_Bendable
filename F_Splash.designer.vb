<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Splash
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
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Splash))
        Me.tmrAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmrAnimation
        '
        Me.tmrAnimation.Enabled = True
        Me.tmrAnimation.Interval = 15
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(53, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1183, 311)
        Me.Panel1.TabIndex = 0
        '
        'LabStatus
        '
        Me.LabStatus.AutoSize = True
        Me.LabStatus.BackColor = System.Drawing.Color.Transparent
        Me.LabStatus.Font = New System.Drawing.Font("MV Boli", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabStatus.ForeColor = System.Drawing.Color.Black
        Me.LabStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabStatus.Location = New System.Drawing.Point(482, 617)
        Me.LabStatus.Name = "LabStatus"
        Me.LabStatus.Size = New System.Drawing.Size(289, 70)
        Me.LabStatus.TabIndex = 7
        Me.LabStatus.Text = "Service ..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(764, 717)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 87)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "s"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(264, 530)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(785, 87)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Waiting for SQL Server"
        '
        'LabTime
        '
        Me.LabTime.AutoSize = True
        Me.LabTime.BackColor = System.Drawing.Color.Transparent
        Me.LabTime.Font = New System.Drawing.Font("MV Boli", 80.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabTime.ForeColor = System.Drawing.Color.Black
        Me.LabTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabTime.Location = New System.Drawing.Point(507, 676)
        Me.LabTime.Name = "LabTime"
        Me.LabTime.Size = New System.Drawing.Size(143, 139)
        Me.LabTime.TabIndex = 4
        Me.LabTime.Text = "N"
        '
        'F_Splash
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1284, 852)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabTime)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Splash"
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrAnimation As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabStatus As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabTime As Label
End Class

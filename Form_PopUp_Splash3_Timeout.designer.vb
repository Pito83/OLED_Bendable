<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_PopUp_Splash3_Timeout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LabTime = New System.Windows.Forms.Label()
        Me.TimerStay = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabTime
        '
        Me.LabTime.AutoSize = True
        Me.LabTime.BackColor = System.Drawing.Color.Transparent
        Me.LabTime.Font = New System.Drawing.Font("MV Boli", 80.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabTime.Location = New System.Drawing.Point(577, 167)
        Me.LabTime.Name = "LabTime"
        Me.LabTime.Size = New System.Drawing.Size(143, 139)
        Me.LabTime.TabIndex = 0
        Me.LabTime.Text = "N"
        '
        'TimerStay
        '
        Me.TimerStay.Interval = 300
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(233, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(785, 87)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Waiting for SQL Server"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(746, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 87)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "s"
        '
        'LabStatus
        '
        Me.LabStatus.AutoSize = True
        Me.LabStatus.BackColor = System.Drawing.Color.Transparent
        Me.LabStatus.Font = New System.Drawing.Font("MV Boli", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabStatus.Location = New System.Drawing.Point(451, 109)
        Me.LabStatus.Name = "LabStatus"
        Me.LabStatus.Size = New System.Drawing.Size(289, 70)
        Me.LabStatus.TabIndex = 3
        Me.LabStatus.Text = "Service ..."
        '
        'Form_PopUp_Splash3_Timeout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1277, 313)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabTime)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(300, 750)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_PopUp_Splash3_Timeout"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabTime As Label
    Friend WithEvents TimerStay As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabStatus As Label
End Class

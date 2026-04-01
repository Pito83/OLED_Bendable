<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_celleCarico
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FormsPlot_CelleCarico = New ScottPlot.WinForms.FormsPlot()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRefreshOnOff = New System.Windows.Forms.Button()
        Me.btnSalvaGrafico = New System.Windows.Forms.Button()
        Me.brnCaricaGrafico = New System.Windows.Forms.Button()
        Me.lblLastUpdate = New System.Windows.Forms.Label()
        Me.btManualTrigger = New System.Windows.Forms.Button()
        Me.TimerPlot = New System.Windows.Forms.Timer(Me.components)
        Me.TimerUI = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.578947!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.05264!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.42105!))
        Me.TableLayoutPanel1.Controls.Add(Me.FormsPlot_CelleCarico, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 2, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.012048!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.40964!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.45783!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1900, 830)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FormsPlot_CelleCarico
        '
        Me.FormsPlot_CelleCarico.DisplayScale = 0!
        Me.FormsPlot_CelleCarico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormsPlot_CelleCarico.Location = New System.Drawing.Point(32, 28)
        Me.FormsPlot_CelleCarico.Name = "FormsPlot_CelleCarico"
        Me.FormsPlot_CelleCarico.Size = New System.Drawing.Size(1571, 678)
        Me.FormsPlot_CelleCarico.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.405638!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.33807!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.64859!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.607695!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnRefreshOnOff, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSalvaGrafico, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.brnCaricaGrafico, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lblLastUpdate, 1, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.btManualTrigger, 1, 6)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(1609, 28)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 12
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 237.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(288, 678)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'btnRefreshOnOff
        '
        Me.btnRefreshOnOff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRefreshOnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshOnOff.Location = New System.Drawing.Point(18, 23)
        Me.btnRefreshOnOff.Name = "btnRefreshOnOff"
        Me.btnRefreshOnOff.Size = New System.Drawing.Size(179, 44)
        Me.btnRefreshOnOff.TabIndex = 0
        Me.btnRefreshOnOff.Text = "ARRESTA REFRESH"
        Me.btnRefreshOnOff.UseVisualStyleBackColor = True
        Me.btnRefreshOnOff.Visible = False
        '
        'btnSalvaGrafico
        '
        Me.btnSalvaGrafico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSalvaGrafico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvaGrafico.Location = New System.Drawing.Point(18, 123)
        Me.btnSalvaGrafico.Name = "btnSalvaGrafico"
        Me.btnSalvaGrafico.Size = New System.Drawing.Size(179, 44)
        Me.btnSalvaGrafico.TabIndex = 1
        Me.btnSalvaGrafico.Text = "SALVA GRAFICO"
        Me.btnSalvaGrafico.UseVisualStyleBackColor = True
        '
        'brnCaricaGrafico
        '
        Me.brnCaricaGrafico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.brnCaricaGrafico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brnCaricaGrafico.Location = New System.Drawing.Point(18, 173)
        Me.brnCaricaGrafico.Name = "brnCaricaGrafico"
        Me.brnCaricaGrafico.Size = New System.Drawing.Size(179, 44)
        Me.brnCaricaGrafico.TabIndex = 2
        Me.brnCaricaGrafico.Text = "CARICA GRAFICO"
        Me.brnCaricaGrafico.UseVisualStyleBackColor = True
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLastUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.Location = New System.Drawing.Point(18, 667)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(179, 43)
        Me.lblLastUpdate.TabIndex = 3
        Me.lblLastUpdate.Text = "dd/MM/yyyy HH:mm:sss"
        Me.lblLastUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btManualTrigger
        '
        Me.btManualTrigger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btManualTrigger.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btManualTrigger.Location = New System.Drawing.Point(18, 460)
        Me.btManualTrigger.Name = "btManualTrigger"
        Me.btManualTrigger.Size = New System.Drawing.Size(179, 44)
        Me.btManualTrigger.TabIndex = 4
        Me.btManualTrigger.Text = "FORZA LETTURA"
        Me.btManualTrigger.UseVisualStyleBackColor = True
        '
        'TimerPlot
        '
        Me.TimerPlot.Enabled = True
        Me.TimerPlot.Interval = 5000
        '
        'TimerUI
        '
        Me.TimerUI.Enabled = True
        Me.TimerUI.Interval = 200
        '
        'Form_celleCarico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1900, 830)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_celleCarico"
        Me.Text = "Form_celleCarico"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FormsPlot_CelleCarico As ScottPlot.WinForms.FormsPlot
    Friend WithEvents TimerPlot As Timer
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnRefreshOnOff As Button
    Friend WithEvents btnSalvaGrafico As Button
    Friend WithEvents brnCaricaGrafico As Button
    Friend WithEvents TimerUI As Timer
    Friend WithEvents lblLastUpdate As Label
    Friend WithEvents btManualTrigger As Button
End Class

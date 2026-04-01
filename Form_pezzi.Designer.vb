<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_pezzi
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
        Me.Group_sx = New System.Windows.Forms.GroupBox()
        Me.Tot_Count_sx = New LBSoft.IndustrialCtrls.Meters.LBDigitalMeter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.B_rst_b_sx = New System.Windows.Forms.Button()
        Me.L_s_sx = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.L_b_sx = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Group_dx = New System.Windows.Forms.GroupBox()
        Me.Tot_Count_dx = New LBSoft.IndustrialCtrls.Meters.LBDigitalMeter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.L_s_dx = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.L_b_dx = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Group_sx.SuspendLayout()
        Me.Group_dx.SuspendLayout()
        Me.SuspendLayout()
        '
        'Group_sx
        '
        Me.Group_sx.BackColor = System.Drawing.Color.LightBlue
        Me.Group_sx.Controls.Add(Me.Tot_Count_sx)
        Me.Group_sx.Controls.Add(Me.Button3)
        Me.Group_sx.Controls.Add(Me.B_rst_b_sx)
        Me.Group_sx.Controls.Add(Me.L_s_sx)
        Me.Group_sx.Controls.Add(Me.Label7)
        Me.Group_sx.Controls.Add(Me.L_b_sx)
        Me.Group_sx.Controls.Add(Me.Label3)
        Me.Group_sx.Controls.Add(Me.Label1)
        Me.Group_sx.Location = New System.Drawing.Point(2, 2)
        Me.Group_sx.Name = "Group_sx"
        Me.Group_sx.Size = New System.Drawing.Size(425, 230)
        Me.Group_sx.TabIndex = 14
        Me.Group_sx.TabStop = False
        '
        'Tot_Count_sx
        '
        Me.Tot_Count_sx.BackColor = System.Drawing.Color.Black
        Me.Tot_Count_sx.ForeColor = System.Drawing.Color.LawnGreen
        Me.Tot_Count_sx.Format = "0000000"
        Me.Tot_Count_sx.Location = New System.Drawing.Point(6, 181)
        Me.Tot_Count_sx.Name = "Tot_Count_sx"
        Me.Tot_Count_sx.Renderer = Nothing
        Me.Tot_Count_sx.Signed = False
        Me.Tot_Count_sx.Size = New System.Drawing.Size(412, 45)
        Me.Tot_Count_sx.TabIndex = 22
        Me.Tot_Count_sx.Value = 0R
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(328, 116)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 60)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Azzera SCARTI"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'B_rst_b_sx
        '
        Me.B_rst_b_sx.BackColor = System.Drawing.Color.Lime
        Me.B_rst_b_sx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_rst_b_sx.Location = New System.Drawing.Point(328, 53)
        Me.B_rst_b_sx.Name = "B_rst_b_sx"
        Me.B_rst_b_sx.Size = New System.Drawing.Size(90, 60)
        Me.B_rst_b_sx.TabIndex = 18
        Me.B_rst_b_sx.Text = "Azzera BUONI"
        Me.B_rst_b_sx.UseVisualStyleBackColor = False
        '
        'L_s_sx
        '
        Me.L_s_sx.BackColor = System.Drawing.Color.Tomato
        Me.L_s_sx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_s_sx.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_s_sx.Location = New System.Drawing.Point(153, 125)
        Me.L_s_sx.Name = "L_s_sx"
        Me.L_s_sx.Size = New System.Drawing.Size(160, 40)
        Me.L_s_sx.TabIndex = 17
        Me.L_s_sx.Text = "######"
        Me.L_s_sx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Red
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 40)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "SCARTI"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_b_sx
        '
        Me.L_b_sx.BackColor = System.Drawing.Color.PaleGreen
        Me.L_b_sx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_b_sx.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_b_sx.Location = New System.Drawing.Point(153, 63)
        Me.L_b_sx.Name = "L_b_sx"
        Me.L_b_sx.Size = New System.Drawing.Size(160, 40)
        Me.L_b_sx.TabIndex = 15
        Me.L_b_sx.Text = "######"
        Me.L_b_sx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Lime
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 40)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "BUONI"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(412, 40)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "CONTEGGIO PEZZI SINISTRA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Group_dx
        '
        Me.Group_dx.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Group_dx.Controls.Add(Me.Tot_Count_dx)
        Me.Group_dx.Controls.Add(Me.Button4)
        Me.Group_dx.Controls.Add(Me.Button2)
        Me.Group_dx.Controls.Add(Me.L_s_dx)
        Me.Group_dx.Controls.Add(Me.Label8)
        Me.Group_dx.Controls.Add(Me.L_b_dx)
        Me.Group_dx.Controls.Add(Me.Label5)
        Me.Group_dx.Controls.Add(Me.Label2)
        Me.Group_dx.Location = New System.Drawing.Point(832, 2)
        Me.Group_dx.Name = "Group_dx"
        Me.Group_dx.Size = New System.Drawing.Size(425, 230)
        Me.Group_dx.TabIndex = 15
        Me.Group_dx.TabStop = False
        '
        'Tot_Count_dx
        '
        Me.Tot_Count_dx.BackColor = System.Drawing.Color.Black
        Me.Tot_Count_dx.ForeColor = System.Drawing.Color.LawnGreen
        Me.Tot_Count_dx.Format = "0000000"
        Me.Tot_Count_dx.Location = New System.Drawing.Point(6, 181)
        Me.Tot_Count_dx.Name = "Tot_Count_dx"
        Me.Tot_Count_dx.Renderer = Nothing
        Me.Tot_Count_dx.Signed = False
        Me.Tot_Count_dx.Size = New System.Drawing.Size(412, 45)
        Me.Tot_Count_dx.TabIndex = 21
        Me.Tot_Count_dx.Value = 0R
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Red
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(329, 116)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 60)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Azzera SCARTI"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(328, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 60)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Azzera BUONI"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'L_s_dx
        '
        Me.L_s_dx.BackColor = System.Drawing.Color.Tomato
        Me.L_s_dx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_s_dx.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_s_dx.Location = New System.Drawing.Point(153, 125)
        Me.L_s_dx.Name = "L_s_dx"
        Me.L_s_dx.Size = New System.Drawing.Size(160, 40)
        Me.L_s_dx.TabIndex = 18
        Me.L_s_dx.Text = "######"
        Me.L_s_dx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Red
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 40)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "SCARTI"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_b_dx
        '
        Me.L_b_dx.BackColor = System.Drawing.Color.LightGreen
        Me.L_b_dx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_b_dx.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_b_dx.Location = New System.Drawing.Point(153, 63)
        Me.L_b_dx.Name = "L_b_dx"
        Me.L_b_dx.Size = New System.Drawing.Size(160, 40)
        Me.L_b_dx.TabIndex = 16
        Me.L_b_dx.Text = "######"
        Me.L_b_dx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Lime
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 40)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "BUONI"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(412, 40)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "CONTEGGIO PEZZI DESTRA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form_pezzi
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1262, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.Group_dx)
        Me.Controls.Add(Me.Group_sx)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_pezzi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form_pezzi"
        Me.Group_sx.ResumeLayout(False)
        Me.Group_dx.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Group_sx As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents B_rst_b_sx As System.Windows.Forms.Button
    Friend WithEvents L_s_sx As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents L_b_sx As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Group_dx As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents L_s_dx As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents L_b_dx As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Tot_Count_sx As LBSoft.IndustrialCtrls.Meters.LBDigitalMeter
    Friend WithEvents Tot_Count_dx As LBSoft.IndustrialCtrls.Meters.LBDigitalMeter
End Class

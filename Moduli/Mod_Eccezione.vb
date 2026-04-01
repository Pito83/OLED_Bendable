Friend Module Mod_Eccezione

    Private F_Ecc As New Form_Exc
    Private Sys_txt As String = ""
    Private File_Trace As Boolean = False
    Private File_Header As Boolean = False
    Private _R_Step, _L_Step, _modo As UShort
    Private Trace_File As String = Application.StartupPath & "\Allarmi.txt"

    Private thisLock As New Object

    Friend Err_sys As Boolean
    Friend ExcClass As New MyEccezione(False, Application.StartupPath & "\Allarmi.txt", False)
    Friend First_Time, Pop_Ecc_Active As Boolean

    Friend Sub show_eccezione(ByVal myEccezione As Exception)
        Dim testo As String
        testo = "Testo= " + myEccezione.GetBaseException.ToString + vbCrLf + vbCrLf _
        + "Tipo: " + myEccezione.GetType.ToString + vbCrLf _
        + "HelpLink  " + myEccezione.HelpLink + vbCrLf _
        + "Sorgente  " + myEccezione.Source + vbCrLf
        'Sys_txt = Sys_txt & testo & vbCrLf
        'Err_sys = True
        Mostra(testo)
    End Sub
    Friend Sub show_eccezione(ByVal testo As String)
        ' Sys_txt = Sys_txt & testo & vbCrLf
        ' Err_sys = True
        Mostra(testo)
    End Sub
    Private Sub Mostra(ByVal _testo As String)
        ' Dim thisLock As New Object
        ' SyncLock thisLock
        'Sys_txt = Sys_txt & _testo & vbCrLf
        Sys_txt = _testo & vbCrLf
        Err_sys = True
        VFEcc(F_Ecc)
        If File_Trace Then
            Traccia(Sys_txt)
        End If
        Sys_txt = ""
        ' End SyncLock
    End Sub
    Private Delegate Sub VisFormEcc(ByVal _fm As Form_Exc)
    Private Sub VFEcc(ByVal _fm As Form_Exc)
        If _fm.InvokeRequired Then
            Dim d As New VisFormEcc(AddressOf VFEcc)
            _fm.Invoke(d, New Object() {_fm})
        Else
            _fm.TextBox1.Text &= Sys_txt
            _fm.Show()
        End If
    End Sub


    Private Sub Traccia(ByVal _text As String)
        Dim _hed_Str, _lstp As String
        Try
            If File_Header Then
                Dim _ss As String = [Enum].GetName(GetType(MyEccezione._Machine_Mode), _modo)
                _hed_Str = vbTab & "Mode= " & _ss
                If (_L_Step > 0) Or (_R_Step > 0) Then
                    _lstp = vbTab & "Left Step= " & _L_Step.ToString("00") & vbTab & "Right Step= " & _R_Step.ToString("00")
                Else
                    _lstp = ""
                End If
                System.IO.File.AppendAllText(Trace_File, Now.ToString & _hed_Str & _lstp & vbCrLf & _text & vbCrLf)
            Else
                System.IO.File.AppendAllText(Trace_File, Now.ToString & vbCrLf & _text & vbCrLf)
            End If
        Catch ex As Exception

        End Try
    End Sub

#Region "Classe INIT"
    Friend Class MyEccezione
        Friend Enum _Machine_Mode As UShort
            _none = 0
            MANUAL = 1
            AUTOMATIC = 2
            Cycle_Run = 3
            Tool_Change = 4
        End Enum
        Friend Sub New(ByVal _trace As Boolean, ByVal _Trace_File As String, _header As Boolean)
            File_Trace = _trace : File_Header = _header
            Trace_File = _Trace_File
            Sys_txt = ""
            Err_sys = False

            VFEcc(F_Ecc)
        End Sub
        Friend Property Eable_FileTrace As Boolean
            Get
                Return File_Trace
            End Get
            Set(value As Boolean)
                File_Trace = value
            End Set
        End Property
        Friend Property Enable_Header As Boolean
            Get
                Return File_Header
            End Get
            Set(value As Boolean)
                File_Header = value
            End Set
        End Property
        Friend Property Trace_FileName() As String
            Get
                Return Trace_File
            End Get
            Set(value As String)
                Trace_File = value
            End Set
        End Property
        Friend WriteOnly Property Gen_Mode As _Machine_Mode
            Set(value As _Machine_Mode)
                _modo = value
            End Set
        End Property
        Friend WriteOnly Property Right_Step As UShort
            Set(value As UShort)
                _R_Step = value
            End Set
        End Property
        Friend WriteOnly Property Left_Step As UShort
            Set(value As UShort)
                _L_Step = value
            End Set
        End Property
    End Class
#End Region

#Region "Form"
    Private Class Form_Exc

        Inherits System.Windows.Forms.Form
        <System.Diagnostics.DebuggerNonUserCode()> Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Private WithEvents Button2 As System.Windows.Forms.Button
        Friend TextBox1 As System.Windows.Forms.TextBox
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Exc))
            Me.Button2 = New System.Windows.Forms.Button()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.SuspendLayout()
            '
            'Button2
            '
            ' Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Button2.BackColor = System.Drawing.Color.Yellow
            '  Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
            Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button2.ForeColor = System.Drawing.Color.Maroon
            Me.Button2.Location = New System.Drawing.Point(636, 404)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(75, 75)
            Me.Button2.TabIndex = 5
            Me.Button2.Text = "OK"
            Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.Button2.UseVisualStyleBackColor = False
            '
            'TextBox1
            '
            Me.TextBox1.Location = New System.Drawing.Point(3, 2)
            Me.TextBox1.Multiline = True
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.ReadOnly = True
            Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TextBox1.Size = New System.Drawing.Size(720, 488)
            Me.TextBox1.TabIndex = 6
            '
            '
            'Form_err
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.ClientSize = New System.Drawing.Size(723, 491)
            Me.ControlBox = False
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.TextBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            '    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form_err"
            Me.Opacity = 0.8R
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "!!ERRORE!!"
            Me.TopMost = True
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend Sub New()
            InitializeComponent()
            TextBox1.Clear()
        End Sub


        Private Sub Form_Exc_Activated(sender As Object, e As EventArgs) Handles Me.Activated
            ' Pop_Up_Active = True
        End Sub
        Private Sub Me_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        End Sub
        Private Sub Form_Exc_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
            Pop_Ecc_Active = Me.Visible
        End Sub
        Private Sub Form_Exc_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            If First_Time Then
                First_Time = False
                Me.Hide()
            End If
        End Sub
        Private Sub Form_Exc_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            TextBox1.Clear()
        End Sub
        Private Sub Me_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
            Me.Dispose()
        End Sub
        Private Sub Me_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

        End Sub
        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
            TextBox1.Clear()
            Sys_txt = ""
            Err_sys = False
            ' Me.PerformLayout()
            'Application.DoEvents()
            Me.Hide()
            'Application.DoEvents()
        End Sub
    End Class
#End Region
End Module

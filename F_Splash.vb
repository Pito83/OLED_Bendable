Imports System.Drawing.Drawing2D
Imports System.Threading
Imports System.IO

Public Class F_Splash
    Private Durata As Integer = 0
    Protected currentGradientShift As Integer = 10
    Protected gradiantStep As Integer = 5
    Private _OK As Boolean


    Private Sub F_Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '======================settings=============================================
        Dim sst As Object = Nothing
        If read_struct_xml(Articoli_dir & "sett.txt", GetType(settaggi), sst) = True Then
            Sett = CType(sst, settaggi)
        Else
            Defalut_Sett()
        End If
        List_Allarmi = Carica_Allarmi(Main_dir & "\Testi\Allarmi.txt")

        LeggeFileLingue()
        ' LeggeFileLingue("Testi\Testi.txt")
        ' _OK = StartBootloader("a")
    End Sub
    Private Sub F_Splash_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Timer1.Enabled = True
    End Sub
    Private Sub F_Splash_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        tmrAnimation.Stop() : tmrAnimation.Enabled = False
        Timer1.Stop() : Timer1.Enabled = False
    End Sub
    Private Sub F_Splash_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ' Me.Dispose()
    End Sub
    Private Sub tmrAnimation_Tick(sender As Object, e As EventArgs) Handles tmrAnimation.Tick
        Durata += 1

        If Durata < 300 Then
            ' Obtain the Graphics object exposed by the Form.
            Dim grfx As Graphics = CreateGraphics()

            ' Set the font type, text, and determine its size.
            Dim font As New Font("Segoe Print", 110, FontStyle.Bold, GraphicsUnit.Point)
            Dim strText As String = "S.A.I.E.E."
            Dim sizfText As New SizeF(grfx.MeasureString(strText, font))

            ' Set the point at which the text will be drawn: centered
            ' in the client area.
            Dim ptfTextStart As New PointF(CSng(ClientSize.Width - sizfText.Width) / 2, CSng(ClientSize.Height - sizfText.Height) / 2)

            ' Set the gradient start and end point, the latter being adjusted
            ' by a changing value to give the animation affect.
            Dim ptfGradientStart As New PointF(0, 0)
            Dim ptfGradientEnd As New PointF(currentGradientShift, 200)

            ' Instantiate the brush used for drawing the text.
            Dim grBrush As New LinearGradientBrush(ptfGradientStart,
                ptfGradientEnd, Color.DeepSkyBlue, BackColor)
            ' Draw the text centered on the client area.
            grfx.DrawString(strText, font, grBrush, ptfTextStart)
            grfx.Dispose()
            ' Shift the gradient, reversing it when it gets to a certain value.
            currentGradientShift += gradiantStep
            If currentGradientShift = 500 Then
                gradiantStep = -5
            ElseIf currentGradientShift = -50 Then
                gradiantStep = 5
            End If
        Else
            If _OK And Not Pop_Ecc_Active And SQLRunningTimeoutSecondsCounter = -1 Then
                tmrAnimation.Stop() : tmrAnimation.Enabled = False
                Me.Close()
            End If
        End If

        LabTime.Text = (100 - SQLRunningTimeoutSecondsCounter).ToString()
        LabStatus.Text = "Service " + SQLStatusText

    End Sub

    Private Sub Panel2_DoubleClick(sender As Object, e As EventArgs)
        If Not Pop_Ecc_Active Then
            tmrAnimation.Stop() : tmrAnimation.Enabled = False
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        _OK = True
    End Sub
End Class

Imports System.ComponentModel

Public Class Form_PopUp_Splash3_Timeout

    Private alphaLabelName As Integer = 0
    Private Sub Form_PopUp_Splash3_Timeout_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        TimerStay.Dispose()
    End Sub

    Private Sub Form_PopUp_Splash3_Timeout_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TransparencyKey = System.Drawing.Color.Black
        TimerStay.Enabled = True
        Me.Opacity = 0.8
    End Sub

    Private Sub Form_PopUp_Splash3_Timeout_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, &HA1, 2, 0&)
        Me.DefWndProc(msg)
    End Sub

    Private Sub TimerStay_Tick(sender As Object, e As EventArgs) Handles TimerStay.Tick
        LabTime.Text = (100 - SQLRunningTimeoutSecondsCounter).ToString()
        LabStatus.Text = "Service " + SQLStatusText

        If SQLRunningTimeoutSecondsCounter = -1 Then
            TimerStay.Enabled = False
            Me.Close()
        End If
    End Sub
End Class
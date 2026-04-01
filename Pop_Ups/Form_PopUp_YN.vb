Public Class Form_PopUp_YN
    Friend _Label As String
    Friend _Ok, _Canc As Boolean
#Region "Form"
    Private Sub Form_PopUp99_Exit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Lab_1.Text = _Label
        Pan_Ok.Visible = _Ok
        Pan_Canc.Visible = _Canc
    End Sub
    Private Sub Form_PopUp99_Exit_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub
    Private Sub Form_PopUp99_Exito_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
#End Region

    Private Sub B_Si_Click(sender As Object, e As EventArgs) Handles B_Si.Click
        Me.DialogResult = DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub B_No_Click(sender As Object, e As EventArgs) Handles B_No.Click
        Me.DialogResult = DialogResult.Abort
        Me.Close()

    End Sub


End Class
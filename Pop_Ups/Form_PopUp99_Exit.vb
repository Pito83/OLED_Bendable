Public Class Form_PopUp99_Exit
    Friend _Label As String
#Region "Form"
    Private Sub Form_PopUp99_Exit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' Lab_1.Text = _Label
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
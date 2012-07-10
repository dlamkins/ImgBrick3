Imports System.Windows.Forms

Public Class LoadingDialog

    Private Sub bttn_Cancel_Click(sender As Object, e As EventArgs) Handles bttn_Cancel.Click
        mForm.Canceled = True
    End Sub

    Private Sub LoadingDialog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub

End Class

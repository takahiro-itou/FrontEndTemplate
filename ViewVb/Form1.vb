Public Class Form1

    Private Sub RunCount(ByVal message As String)

    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        RunCount(txtCommand.Text)
    End Sub

    Private Sub mnuRunCommand_Click(sender As Object, e As EventArgs) Handles mnuRunCommand.Click
        RunCount(txtCommand.Text)
    End Sub
End Class

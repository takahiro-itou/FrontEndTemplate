Public Class Form1

    Private Sub RunCount(ByVal message As String)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RunCount(txtCommand.Text)
    End Sub

    Private Sub CountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CountToolStripMenuItem.Click
        RunCount(txtCommand.Text)
    End Sub
End Class

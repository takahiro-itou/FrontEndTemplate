Public Class Form1

    Private Sub RunCount(ByVal message As String)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RunCount(TextBox1.Text)
    End Sub

    Private Sub CountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CountToolStripMenuItem.Click
        RunCount(TextBox1.Text)
    End Sub
End Class

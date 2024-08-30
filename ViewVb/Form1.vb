Public Class Form1

''========================================================================
''    指定したコマンドを実行する。
''========================================================================
Private Sub RunCommand(ByVal command As String)

End Sub

''========================================================================
''    「実行」 ボタンのクリックイベントハンドラ。
''
''    入力したコマンドを実行する。
''========================================================================
Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles _
            btnRun.Click
    RunCommand(txtCommand.Text)
End Sub

''========================================================================
''    メニュー「ファイル」－「終了」
''========================================================================
Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles _
            mnuFileExit.Click
    Application.Exit()
End Sub

''========================================================================
''    メニュー「実行」－「コマンドを実行」
''========================================================================

Private Sub mnuRunCommand_Click(sender As Object, e As EventArgs) Handles _
            mnuRunCommand.Click
    RunCommand(txtCommand.Text)
End Sub

End Class

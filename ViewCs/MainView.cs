
namespace ViewCs
{

public partial class MainView : Form
{

    public MainView()
    {
        InitializeComponent();
    }

    //----------------------------------------------------------------
    //    指定したコマンドを実行する。
    //
    private void runCommand(string command)
    {
    }

    //----------------------------------------------------------------
    //    「実行」ボタンのクリックイベントハンドラ。
    //
    //    入力したコマンドを実行する。
    //
    private void btnRun_Click(object sender, EventArgs e)
    {
        runCommand(txtCommand.Text);
    }

    //----------------------------------------------------------------
    //    メニュー「ファイル」－「終了」
    //
    private void mnuFileExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    //----------------------------------------------------------------
    //    メニュー「実行」－「コマンドを実行」
    //
    private void mnuRunCommand_Click(object sender, EventArgs e)
    {
        runCommand(txtCommand.Text);
    }

}

}
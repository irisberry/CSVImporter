using System;
using System.Windows.Forms;

namespace CSVImporter.WinForms.Forms.Base
{
    public abstract partial class BaseUserForm : Form
    {
        // ユーザー関連フォームの基底クラス
        protected Button ExecuteButton;
        protected Button BackButton;

        // 共通のコントロール初期化メソッド
        protected virtual void InitializeCommonControls()
        {
            // 共通のコントロール初期化処理
        }

        // 実行ボタンのクリックイベントハンドラ
        protected abstract void ExecuteButton_Click(object sender, EventArgs e);

        // 戻るボタンのクリックイベントハンドラ
        protected virtual void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

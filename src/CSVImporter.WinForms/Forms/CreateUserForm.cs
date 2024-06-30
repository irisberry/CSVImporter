using CSVImporter.Models.Csv;
using CSVImporter.WinForms.Forms.Base;
using System;

namespace CSVImporter.WinForms.Forms
{
    public partial class CreateUserForm : BaseUserForm
    {
        // ユーザー登録フォームの実装
        public UserData NewUser { get; set; } = new UserData();

        protected override void ExecuteButton_Click(object sender, EventArgs e)
        {
            // ユーザー登録処理
        }
    }
}

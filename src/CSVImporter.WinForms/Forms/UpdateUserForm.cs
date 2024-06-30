using CSVImporter.Models.Csv;
using CSVImporter.WinForms.Forms.Base;
using System;

namespace CSVImporter.WinForms.Forms
{
    public partial class UpdateUserForm : BaseUserForm
    {
        // ユーザー更新フォームの実装
        public UserData UpdatedUser { get; set; } = new UserData();

        public UpdateUserForm(UserData userData)
        {

        }

        protected override void ExecuteButton_Click(object sender, EventArgs e)
        {
            // ユーザー更新処理
        }
    }
}

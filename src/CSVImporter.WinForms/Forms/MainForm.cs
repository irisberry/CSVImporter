using CSVImporter.Core.Interfaces;
using CSVImporter.Models.Csv;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSVImporter.WinForms.Forms
{
    public partial class MainForm : Form
    {
        private ICsvReader csvReader;
        private ICsvWriter csvWriter;
        private IScoreCalculator scoreCalculator;

        public MainForm(ICsvReader csvReader, ICsvWriter csvWriter, IScoreCalculator scoreCalculator)
        {
            this.csvReader = csvReader;
            this.csvWriter = csvWriter;
            this.scoreCalculator = scoreCalculator;
            InitializeComponent();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            testResultsDataGridView.Columns.Add("Name", "名前");
            testResultsDataGridView.Columns.Add("English", "英語");
            testResultsDataGridView.Columns.Add("Math", "数学");
            testResultsDataGridView.Columns.Add("Japanese", "国語");
            testResultsDataGridView.Columns.Add("History", "地歴");
            testResultsDataGridView.Columns.Add("Civics", "公民");
            testResultsDataGridView.Columns.Add("Science", "理科");
            testResultsDataGridView.Columns.Add("Informatics", "情報");
            testResultsDataGridView.Columns.Add("Average", "平均");
            testResultsDataGridView.Columns.Add("Evaluation", "評価");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var userDatas = csvReader.Read(openFileDialog.FileName);
                    UpdateDataGridView(userDatas);
                    UpdateAverageAndTotalScores();
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var userData = GetUserDataFromDataGridView();
                    csvWriter.Write(saveFileDialog.FileName, userData);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            using (var searchForm = new SearchForm())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    // 検索結果を反映
                    UpdateDataGridView(searchForm.SearchResults);
                }
            }
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            if (testResultsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = testResultsDataGridView.SelectedRows[0];
                using (var readUserForm = new ReadUserForm(GetUserDataFromRow(selectedRow)))
                {
                    readUserForm.ShowDialog();
                }
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            using (var createUserForm = new CreateUserForm())
            {
                if (createUserForm.ShowDialog() == DialogResult.OK)
                {
                    // 新しいユーザーをDataGridViewに追加
                    AddUserToDataGridView(createUserForm.NewUser);
                    UpdateAverageAndTotalScores();
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (testResultsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = testResultsDataGridView.SelectedRows[0];
                using (var updateUserForm = new UpdateUserForm(GetUserDataFromRow(selectedRow)))
                {
                    if (updateUserForm.ShowDialog() == DialogResult.OK)
                    {
                        // 更新されたユーザー情報をDataGridViewに反映
                        UpdateUserInDataGridView(selectedRow.Index, updateUserForm.UpdatedUser);
                        UpdateAverageAndTotalScores();
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (testResultsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = testResultsDataGridView.SelectedRows[0];
                using (var deleteUserForm = new DeleteUserForm(GetUserDataFromRow(selectedRow)))
                {
                    if (deleteUserForm.ShowDialog() == DialogResult.OK)
                    {
                        // ユーザーをDataGridViewから削除
                        DeleteUserInDataGridView(selectedRow.Index);
                        UpdateAverageAndTotalScores();
                    }
                }
            }
        }

        private IEnumerable<UserData> GetUserDataFromDataGridView()
        {
            var userData = new List<UserData>();


            return userData;
        }

        private UserData GetUserDataFromRow(DataGridViewRow row)
        {
            var userData = new UserData();

            return userData;
        }

        private void UpdateDataGridView(IEnumerable<UserData> userDatas)
        {

        }

        private void AddUserToDataGridView(UserData userData)
        {

        }

        private void UpdateUserInDataGridView(int index, UserData userData)
        {

        }


        private void DeleteUserInDataGridView(int index)
        {
            testResultsDataGridView.Rows.RemoveAt(index);
        }

        private void UpdateAverageAndTotalScores()
        {

        }
    }
}

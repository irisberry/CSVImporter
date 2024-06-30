using CSVImporter.Core.Interfaces;
using CSVImporter.Core.Services;
using CSVImporter.WinForms.Forms;
using System;
using System.Windows.Forms;

namespace CSVImporter.WinForms
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ICsvReader csvReader = new CsvReader();
            ICsvWriter csvWriter = new CsvWriter();
            IScoreCalculator scoreCalculator = new ScoreCalculator();

            Application.Run(new MainForm(csvReader, csvWriter, scoreCalculator));
        }
    }
}

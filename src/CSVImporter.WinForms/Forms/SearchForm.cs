using CSVImporter.Models.Csv;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSVImporter.WinForms.Forms
{
    public partial class SearchForm : Form
    {
        public IEnumerable<UserData> SearchResults { get; set; } = new List<UserData>();
        public SearchForm()
        {
            InitializeComponent();
        }
    }
}

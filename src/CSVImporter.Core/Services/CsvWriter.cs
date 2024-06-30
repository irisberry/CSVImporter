using CSVImporter.Core.Interfaces;
using CSVImporter.Models.Csv;
using System.Collections.Generic;
using System.IO;

namespace CSVImporter.Core.Services
{
    public class CsvWriter : ICsvWriter
    {
        public void Write(string filePath, IEnumerable<UserData> data)
        {
            using (var writer = new StreamWriter(filePath))
            {
                // CSVファイルの書き込み処理を実装
            }
        }
    }
}

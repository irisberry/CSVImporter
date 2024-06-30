using CSVImporter.Core.Interfaces;
using CSVImporter.Models.Csv;
using System.Collections.Generic;
using System.IO;

namespace CSVImporter.Core.Services
{
    public class CsvReader : ICsvReader
    {
        public IEnumerable<UserData> Read(string filePath)
        {
            var users = new List<UserData>();
            using (var reader = new StreamReader(filePath))
            {
                // CSVファイルの読み込み処理を実装
            }
            return users;
        }
    }
}

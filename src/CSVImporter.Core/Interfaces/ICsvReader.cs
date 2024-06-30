using CSVImporter.Models.Csv;
using System.Collections.Generic;

namespace CSVImporter.Core.Interfaces
{
    public interface ICsvReader
    {
        IEnumerable<UserData> Read(string filePath);
    }
}

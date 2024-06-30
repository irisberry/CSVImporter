using CSVImporter.Models.Csv;
using System.Collections.Generic;

namespace CSVImporter.Core.Interfaces
{
    public interface ICsvWriter
    {
        void Write(string filePath, IEnumerable<UserData> data);
    }

}

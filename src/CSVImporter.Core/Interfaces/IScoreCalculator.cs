using CSVImporter.Models.Csv;
using System.Collections.Generic;

namespace CSVImporter.Core.Interfaces
{
    public interface IScoreCalculator
    {
        double CalcAverageScore(IEnumerable<UserData> results);

        double CalcSumScore(IEnumerable<UserData> results);
    }
}

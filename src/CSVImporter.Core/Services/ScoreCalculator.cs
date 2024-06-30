using CSVImporter.Core.Interfaces;
using CSVImporter.Models.Csv;
using System.Collections.Generic;

namespace CSVImporter.Core.Services
{
    public class ScoreCalculator : IScoreCalculator
    {
        public double CalcAverageScore(IEnumerable<UserData> results)
        {
            return 0.0;
        }

        public double CalcSumScore(IEnumerable<UserData> results)
        {
            return 0.0;
        }
    }
}

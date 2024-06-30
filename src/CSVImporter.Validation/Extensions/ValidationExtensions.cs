using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CSVImporter.Validation.Extensions
{
    public static class ValidationExtensions
    {
        public static string GetErrorMessage(this IEnumerable<ValidationResult> validationResults)
        {
            return string.Join("\n", validationResults.Select(r => r.ErrorMessage));
        }

        public static Dictionary<string, List<string>> GetErrorDictionary(this IEnumerable<ValidationResult> validationResults)
        {
            var errorDictionary = new Dictionary<string, List<string>>();

            foreach (var validationResult in validationResults)
            {
                foreach (var memberName in validationResult.MemberNames)
                {
                    if (!errorDictionary.ContainsKey(memberName))
                    {
                        errorDictionary[memberName] = new List<string>();
                    }
                    errorDictionary[memberName].Add(validationResult.ErrorMessage);
                }
            }

            return errorDictionary;
        }
    }
}

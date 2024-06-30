using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace CSVImporter.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class RegexAttribute : ValidationAttribute
    {
        private readonly string _pattern;

        public RegexAttribute(string pattern)
        {
            _pattern = pattern;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            string stringValue = value.ToString();

            if (Regex.IsMatch(stringValue, _pattern))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult($"入力形式が正しくありません。");
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace CSVImporter.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class MaxLengthAttribute : ValidationAttribute
    {
        private readonly int _maxLength;

        public MaxLengthAttribute(int maxLength)
        {
            _maxLength = maxLength;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            string stringValue = value.ToString();

            if (stringValue.Length <= _maxLength)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult($"最大{_maxLength}文字まで入力可能です。");
        }
    }
}

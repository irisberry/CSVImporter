using System;
using System.ComponentModel.DataAnnotations;

namespace CSVImporter.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class RequiredAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                return new ValidationResult("この項目は必須です。");
            }

            return ValidationResult.Success;
        }
    }
}

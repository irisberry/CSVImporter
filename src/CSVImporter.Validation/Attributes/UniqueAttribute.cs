using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CSVImporter.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class UniqueAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            var property = validationContext.ObjectType.GetProperty(validationContext.MemberName);
            if (property == null)
            {
                return ValidationResult.Success;
            }

            var list = validationContext.ObjectInstance.GetType().GetProperty("Items")?.GetValue(validationContext.ObjectInstance) as IEnumerable<object>;
            if (list == null)
            {
                return ValidationResult.Success;
            }

            var count = list.Count(item => property.GetValue(item)?.Equals(value) == true);

            if (count > 1)
            {
                return new ValidationResult($"'{validationContext.DisplayName}' は一意である必要があります。");
            }

            return ValidationResult.Success;
        }
    }
}

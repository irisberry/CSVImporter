using CSVImporter.Validation.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSVImporter.Validation.Services
{
    public class Validator : IValidator
    {
        public IEnumerable<ValidationResult> Validate(object instance)
        {
            var results = new List<ValidationResult>();
            TryValidate(instance, out var validationResults);
            results.AddRange(validationResults);
            return results;
        }

        public bool TryValidate(object instance, out ICollection<ValidationResult> results)
        {
            results = new List<ValidationResult>();
            return System.ComponentModel.DataAnnotations.Validator.TryValidateObject(instance, new ValidationContext(instance), results, true);
        }
    }
}

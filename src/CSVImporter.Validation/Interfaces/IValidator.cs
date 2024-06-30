using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSVImporter.Validation.Interfaces
{
    public interface IValidator
    {
        IEnumerable<ValidationResult> Validate(object instance);
        bool TryValidate(object instance, out ICollection<ValidationResult> results);
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CSVImporter.Validation.Attributes
{
    public enum CharacterType
    {
        FullWidth,
        HalfWidth
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class CharacterAttribute : ValidationAttribute
    {
        private readonly CharacterType _characterType;

        public CharacterAttribute(CharacterType characterType)
        {
            _characterType = characterType;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            string stringValue = value.ToString();

            bool isValid;
            switch(_characterType)
            {
                case CharacterType.FullWidth:
                    isValid = stringValue.All(c => c > 0xFF);
                    break;
                case CharacterType.HalfWidth:
                    isValid = stringValue.All(c => c <= 0xFF);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(_characterType));
            }

            if (isValid)
            {
                return ValidationResult.Success;
            }

            string errorMessage = _characterType == CharacterType.FullWidth
                ? "全角文字のみ使用できます。"
                : "半角文字のみ使用できます。";

            return new ValidationResult(errorMessage);
        }
    }
}

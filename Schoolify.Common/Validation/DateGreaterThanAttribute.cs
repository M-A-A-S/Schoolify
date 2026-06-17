using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Validation
{
    public class DateGreaterThanAttribute : ValidationAttribute
    {
        private readonly string _comparisonProperty;

        public DateGreaterThanAttribute(string comparisonProperty)
        {
            _comparisonProperty = comparisonProperty;
        }

        protected override ValidationResult? IsValid(
        object? value,
        ValidationContext validationContext)
        {
            var currentValue = value as IComparable;

            var property = validationContext.ObjectType.GetProperty(_comparisonProperty);

            if (property == null)
            {
                return new ValidationResult($"Property '{_comparisonProperty}' not found.");
            }

            var comparisonValue =
                property.GetValue(validationContext.ObjectInstance) as IComparable;

            if (currentValue == null || comparisonValue == null)
            {
                return ValidationResult.Success;
            }

            if (currentValue.CompareTo(comparisonValue) <= 0)
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Validators
{
    public class IsNumeric : ValidationAttribute
    {
        public IsNumeric()
        {

        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            string valor = value as string;
             
            long n;
            bool isNumeric = long.TryParse(valor, out n);

            if (!isNumeric)
            {
                return new ValidationResult($"Solo se permiten ingresar números");

            }

            return ValidationResult.Success;
        }
    }
}

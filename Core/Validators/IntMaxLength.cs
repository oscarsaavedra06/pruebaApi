using System.ComponentModel.DataAnnotations;

namespace Core.Validators
{
    public class IntMaxLength : ValidationAttribute
    {
        private readonly int maxLength;

        public IntMaxLength(int maxLength)
        {
            this.maxLength = maxLength;
        }
        public IntMaxLength()
        {

        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
           
            int maxLengthIn = (int)value;
             
            if (maxLengthIn > maxLength)
            {
                return new ValidationResult($"Solo se permiten ingresar un máximos de {maxLength} dígitos");

            }

            return ValidationResult.Success;
        }

    }
}

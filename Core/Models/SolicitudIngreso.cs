using Core.Validators;
using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class SolicitudIngreso
    {
        [Key]
        public int Id { get; set; }

        [RegularExpression(@"[\p{L} ]+$", ErrorMessage = "Solo se permite ingresar letras")]
        [MaxLength(20, ErrorMessage = "El nombre no debe superar los {1} caracteres")]
        public string Nombre { get; set; }

        [RegularExpression(@"[\p{L} ]+$", ErrorMessage = "Solo se permite ingresar letras")]
        [MaxLength(20, ErrorMessage = "El nombre no debe superar los {1} caracteres")]
        public string Apellido { get; set; }

        [MaxLength(10, ErrorMessage = "Solo se permite ingresar 10 dígitos")]
        [IsNumeric()]
        public string Identificacion { get; set; }

        [RegularExpression("[1-4]", ErrorMessage = "Opción no válida")]
       
        public int IdCasa { get; set; }
        
        [Range(0,99)]
        public int Edad { get; set; }
    }
}

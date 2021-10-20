using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class SolicitudIngreso
    {
        [Key]
        public int Id { get; set; }

        [RegularExpression(@"[\p{L} ]+$", ErrorMessage ="Solo se permite ingresar letras")]
        [MaxLength(20,ErrorMessage ="El nombre no debe superar los {1} caracteres")]
        public string Nombre { get; set; }

        [RegularExpression(@"[\p{L} ]+$", ErrorMessage = "Solo se permite ingresar letras")]
        [MaxLength(20, ErrorMessage = "El nombre no debe superar los {1} caracteres")]
        public string Apellido { get; set; }

        [RegularExpression("[0-9]", ErrorMessage = "Solo se permite ingresar números")]
        
        public int Identificacion { get; set; }

        [RegularExpression("[1-4]", ErrorMessage = "Opción no válida")]
       
        public int IdCasa { get; set; }
    }
}

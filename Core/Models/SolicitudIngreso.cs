using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class SolicitudIngreso
    {
        [Key]
        public int Id { get; set; }

        [RegularExpression("[a-zA-Z]",ErrorMessage ="Solo se permite ingresar letras")]
        [MaxLength(20)]
        public string Nombre { get; set; }

        [RegularExpression("[a-zA-Z]", ErrorMessage = "Solo se permite ingresar letras")]
        [MaxLength(20)]
        public string Apellido { get; set; }

        [RegularExpression("[0-9]", ErrorMessage = "Solo se permite ingresar números")]
        [MaxLength(10)]
        public int Identificacion { get; set; }

        [RegularExpression("[1-4]", ErrorMessage = "Opción no válida")]
        [MaxLength(1)]
        public int IdCasa { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Casa
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nombre { get; set; }
    }
}

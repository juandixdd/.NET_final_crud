using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Rol
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public int status { get; set; }
    }
}

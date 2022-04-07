using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Producto
    {
        /* (Id, Codigo, Nombre, Valor unitario, IVA, Cantidad, Fecha_registro, Estado) */

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Valor_unitario { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Iva { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public DateTime Fecha_registro { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Estado { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public String Categoria { get; set; }

    }
}

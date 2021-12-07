using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProductos.Models
{
    public class productosModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El código es obligatorio")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La categoria es obligatoria")]
        public string Categoria { get; set; }
        [Required(ErrorMessage = "La cantidad es obligatoria")]
        public int Cantidad { get; set; }
        [Required(ErrorMessage = "El precio es obligatorio")]
        public float Precio { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria")]
        public DateTime FechaCreacion { get; set; }
        public string imagen { get; set; }
    }

}

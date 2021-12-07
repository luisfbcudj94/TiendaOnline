using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProductos.Models
{
    public class usuariosModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese un usuario")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Ingrese su contraseña")]
        public string Contraseña { get; set; }
    }
}

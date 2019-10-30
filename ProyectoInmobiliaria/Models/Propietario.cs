using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
    public class Propietario
    {
        [Key]
        public int IdPropietario { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public decimal Dni { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Direccion { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public decimal Telefono { get; set; }    
        
    }
}

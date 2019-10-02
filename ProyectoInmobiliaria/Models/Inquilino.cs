using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
    public class Inquilino
    {
        [Key]
        public int IdInquilino { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Dni { get; set; }
        public string Direccion { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string LugarTrabajo { get; set; }
        [Required]
        public string NombreGarante { get; set; }
        [Required]
        public string ApellidoGarante { get; set; }
        [Required]
        public string DniGarante { get; set; }
        public string DireccionGarante { get; set; }
        [Required, EmailAddress]
        public string EmailGarante { get; set; }
        [Required]
        public string TelefonoGarante { get; set; }
        [Required]
        public string LugarTrabajoGarante { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
    public class Inmueble
    {
        [Key]
        public int IdInmueble { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Uso { get; set; }
        [Required]
        public string Tipo { get; set; }
        public decimal CantidadHabitaciones { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public string Estado { get; set; }
        [Display(Name = "Dueño")]
        public int IdPropietario { get; set; }
        [ForeignKey("IdPropietario")]
        public Propietario Duenio { get; set; }
    }
}

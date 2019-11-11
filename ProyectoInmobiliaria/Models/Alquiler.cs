using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
    public class Alquiler
    {
        [Key]
        public int IdAlquiler { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }
        [Required]
        public DateTime FechaFin { get; set; }
        [Required]
        public decimal Monto { get; set; }
        public int IdInmueble { get; set; }
        public int IdInquilino { get; set; }
        public Inmueble casa { get; set; }
        public Inquilino inquilino { get; set; }

    }
}

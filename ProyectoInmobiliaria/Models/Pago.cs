using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
    public class Pago
    {
        [Key]
        public int IdPagos { get; set; }
        public string Estado { get; set; }
        [Required]
        public DateTime FechaPago { get; set; }
        [Required]
        public Decimal Importe { get; set; }
        public int IdAlquiler { get; set; }
        public Alquiler Alquilado { get; set; }
    }
}

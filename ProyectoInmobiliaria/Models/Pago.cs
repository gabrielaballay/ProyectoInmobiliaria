using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
    public class Pago
    {
        public int IdPagos { get; set; }
        public string Estado { get; set; }
        public DateTime FechaPago { get; set; }
        public Decimal Importe { get; set; }
        public int IdAlquiler { get; set; }
        public Alquiler Alquilado { get; set; }
    }
}

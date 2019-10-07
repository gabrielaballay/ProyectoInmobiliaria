using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
    public class Alquiler
    {
        public int IdAlquiler { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Monto { get; set; }
        public int IdInmueble { get; set; }
        public int IdInquilino { get; set; }
        public Inmueble casa { get; set; }
        public Inquilino inquilino { get; set; }

    }
}

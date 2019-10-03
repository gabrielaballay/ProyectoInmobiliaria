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
        public Inmueble IdInmueble { get; set; }
        public Inquilino IdInquilino { get; set; }
    }
}

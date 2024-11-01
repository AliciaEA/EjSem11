using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReparacionesAutos.Modelos
{
    internal class Auto
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Matricula { get; set; }
        public TipoReparacion TipoReparacion { get; set; }
        public bool Seguro { get; set; }

    }
}

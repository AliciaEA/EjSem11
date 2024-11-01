using ReparacionesAutos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReparacionesAutos.Servicios
{
    internal class RegistroAuto
    {
        public List<Auto> Autos = new List<Auto>();

        public void AgregarAuto(Auto auto)
        {
            Autos.Add(auto);
        }

        public List<Auto> ObtenerAutos()
        {
            return Autos;
        }
    }
}

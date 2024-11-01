using FormPacientes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPacientes.Servicios
{
    internal class RegistroPaciente
    {
        List<Paciente> Pacientes = new List<Paciente>();

        public void AgregarPaciente(Paciente paciente)
        {
            Pacientes.Add(paciente);
        }
        public List<Paciente> ObtenerPacientes()
        {
            return Pacientes;

        }
    }
}

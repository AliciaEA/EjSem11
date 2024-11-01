﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FormPacientes.Modelos
{
    internal class Paciente
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime FechaNac { get; set; }
        public char Genero { get; set; }
        public DepartamentoMedico Departamento { get; set; }
        public string Descripcion {  get; set; }
        public bool Alergias { get; set; }

        public int Edad => CalcularEdad();

        public int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - FechaNac.Year;
            if (FechaNac > fechaActual.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }
    }
}

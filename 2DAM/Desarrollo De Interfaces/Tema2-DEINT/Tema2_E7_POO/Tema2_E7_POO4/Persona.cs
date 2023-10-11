using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_E7_POO4
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad) 
        {
            Nombre = nombre;
            Edad = edad;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + "\nEdad: " + Edad;
        }
    }
}

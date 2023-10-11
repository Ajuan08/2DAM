using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_E7_POO4
{
    internal class Empleado : Persona
    {
        public int Sueldo { get; set; }

        public Empleado(string nombre, int edad ,int sueldo) : base(nombre, edad) 
        {
                Sueldo = sueldo;
        }
        public override string ToString()
        {
            return base.ToString() + "\nSueldo: " + Sueldo;
        }
    }
}

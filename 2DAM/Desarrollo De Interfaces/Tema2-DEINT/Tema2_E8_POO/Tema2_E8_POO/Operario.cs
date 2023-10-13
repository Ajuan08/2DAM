using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_E8_POO
{
    internal class Operario : Empleado
    {
        public Operario(string nombre) : base(nombre)
        {
            Nombre = nombre;
        }
        public override string ToString()
        {
            return "Empleado"+Nombre + "->Operario";
        }
    }
}

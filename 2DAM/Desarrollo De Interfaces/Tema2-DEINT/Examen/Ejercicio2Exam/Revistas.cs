using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Exam
{
    internal class Revistas:Publicacion
    {
        public int NumEdicion { get; set; }

        public Revistas() { }

        public Revistas(string titulo, string autor, DateTime año, int numEdicion) : base(titulo, autor, año)
        {
            NumEdicion = numEdicion;
        }

        public override string ToString()
        {
            return base.ToString() + "\nEl número de Edicion es: " + NumEdicion;
        }
    }
}

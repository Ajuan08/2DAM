using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Exam
{
    internal class Libros:Publicacion
    {
        public int NumPaginas {  get; set; }

        public Libros() { }

        public Libros(string titulo, string autor, DateTime año, int numPaginas) : base(titulo, autor, año)
        {
            NumPaginas = numPaginas;
        }

        public override string ToString()
        {
            return base.ToString() + "\nEl número de páginas son: " + NumPaginas;
        }
    }
}

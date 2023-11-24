using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Exam
{
    internal class ExcepcionAutor:Exception
    {
        public ExcepcionAutor() { }
        public ExcepcionAutor(string message) : base(message) { }
    }
}

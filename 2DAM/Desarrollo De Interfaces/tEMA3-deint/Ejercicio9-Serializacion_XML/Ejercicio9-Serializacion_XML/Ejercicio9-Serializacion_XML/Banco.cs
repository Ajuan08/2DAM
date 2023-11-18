using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9_Serializacion_XML
{
    internal class Banco
    {
        public List<Cliente> Clientes {  get; set; }
        public Banco() 
        {
            Clientes = new List<Cliente>();
        }

    }
}

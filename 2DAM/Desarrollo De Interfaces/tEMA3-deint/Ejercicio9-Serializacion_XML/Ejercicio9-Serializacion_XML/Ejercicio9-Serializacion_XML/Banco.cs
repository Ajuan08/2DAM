using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9_Serializacion_XML
{
    public class Banco
    {
        public List<Cliente> Clientes {  get; set; }
        public Banco() 
        {
            Clientes = new List<Cliente>();
        }

        public void eliminarClienteDNI(string dni)
        {
            foreach (var item in Clientes)
            {
                if(item.DNI.Equals(dni))
                {
                    Clientes.Remove(item);
                    return;
                }
            }
        }

    }
}

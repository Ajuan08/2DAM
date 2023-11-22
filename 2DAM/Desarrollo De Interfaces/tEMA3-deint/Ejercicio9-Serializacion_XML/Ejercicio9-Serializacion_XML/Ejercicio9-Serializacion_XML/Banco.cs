using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9_Serializacion_XML
{
    public class Banco
    {
        public List<Cliente> Clientes { get; set; }


        public Banco()
        {
            Clientes = new List<Cliente>();
        }

        public List<Cliente> getClientes()
        {
            return Clientes;
        }


        public void agregarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);


        }

        public void setCliente(Cliente cliente)
        {
            foreach (var c in Clientes)
            {
                if (c.DNI == cliente.DNI)
                {
                    Clientes.Remove(c);
                    Clientes.Add(cliente);
                    MessageBox.Show("Cliente modificado correctamente", "Información");
                    break;
                }
            }
        }

        public void setClientes(List<Cliente> clientes)
        {
            this.Clientes = clientes;
        }

        internal Cliente buscarClientePorDni(string dniCliente)
        {
            foreach (var c in Clientes)
            {
                if (c.DNI == dniCliente)
                {
                    return c;
                }
            }
            return null;
        }
    }
}

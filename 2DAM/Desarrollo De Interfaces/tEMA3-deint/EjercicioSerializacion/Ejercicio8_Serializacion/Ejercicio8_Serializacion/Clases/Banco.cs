using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ejercicio8_Serializacion.Clases
{
    public class Banco
    {
        public List<Cliente> Clientes { get; set; }

        public XmlSerializer serializer { get; set; }

        public static Banco? Objetos { get; set; }

        public static Banco getInstance()
        {
            if (Objetos == null)
            {
                return new Banco();
            }
            else
            {
                return Objetos;
            }
        }

        public Banco()
        {
            Clientes = new List<Cliente>();
            serializer = new XmlSerializer(typeof(List<Cliente>));
        }

        public void AgregarCliente(string dni, string nombre, string direccion, int edad, string telefono, string numCuenta)
        {
            Cliente cliente = new Cliente(dni, nombre, direccion, edad, telefono, numCuenta);
            Clientes.Add(cliente);

            GuardarClientes();
        }

        public bool ModificarCliente(string dni, string nombre, string direccion, int edad, string telefono, string numCuenta)
        {
            bool modificar = false;

            Cliente? cliente = Clientes.Find(cli => cli.DNI == dni);

            if (cliente != null)
            {
                cliente.DNI = dni;
                cliente.Nombre = nombre;
                cliente.Direccion = direccion;
                cliente.Edad = edad;
                cliente.Telefono = telefono;
                cliente.NumCuenta = numCuenta;

                GuardarClientes();

                modificar = true;
            }

            return modificar;
        }

        public bool EliminarCliente(string dni)
        {
            bool eliminar = false;
            Cliente? cliente = Clientes.Find(cli => cli.DNI == dni);

            if (cliente != null)
            {
                Clientes.Remove(cliente);
                GuardarClientes();
                eliminar = true;
            }
            return eliminar;
        }

        public string MostrarCliente(string dni)
        {
            Cliente? cliente = Clientes.Find(cli => cli.DNI == dni);

            if (cliente != null)
            {
                return cliente.ToString();
            }
            return "";
        }

        public List<string> ObtenerDnis()
        {
            List<string> dnis = new List<string>();

            foreach (Cliente cliente in Clientes)
            {
                dnis.Add(cliente.DNI);
            }
            return dnis;
        }

        public Cliente? ObtenerClientes(string dni)
        {
            return Clientes.Find(cli => cli.DNI == dni);
        }

        public void GuardarClientes()
        {
            using (TextWriter archivo = new StreamWriter("banco.xml"))
            {
                serializer.Serialize(archivo, Clientes);
            }
        }

        public List<Cliente> GetClientes()
        {
            if (File.Exists("banco.xml"))
            {
                using (TextReader leer = new StreamReader("banco.xml"))
                {
                    object? clientes = serializer.Deserialize(leer);

                    if (clientes != null)
                    {
                        return (List<Cliente>)clientes;
                    }

                    return new List<Cliente>();
                }
            }
            return new List<Cliente>();
        }
    }
}

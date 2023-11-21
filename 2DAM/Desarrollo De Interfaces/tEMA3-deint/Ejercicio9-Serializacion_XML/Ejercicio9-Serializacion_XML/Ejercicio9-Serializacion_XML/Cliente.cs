using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ejercicio9_Serializacion_XML
{
    public class Cliente
    {
        [XmlElement("DNI")]
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public int Telefono { get; set; }
        public int NumeroCuentaCorriente { get; set; }

        public Cliente() { }

        public Cliente(string dni, string nombre, string direccion, int edad, int telefono, int numeroCuentaCorriente)
        {
            DNI = dni;
            Nombre = nombre;
            Direccion = direccion;
            Edad = edad;
            Telefono = telefono;
            NumeroCuentaCorriente = numeroCuentaCorriente;
        }
    }
}

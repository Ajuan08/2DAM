using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8_Serializacion.Clases
{
    public class Cliente
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string NumCuenta { get; set; }

        public Cliente() { }

        public Cliente(string dni, string nombre, string direccion, int edad, string telefono, string numCuenta)
        {
            DNI = dni;
            Nombre = nombre;
            Direccion = direccion;
            Edad = edad;
            Telefono = telefono;
            NumCuenta = numCuenta;

        }

        public override string ToString()
        {
            return "El DNI es: " + DNI + "\nEl nombre es: " + Nombre + "\nLa direccion es: " + Direccion + "\nLa edad es de: " + Edad + "\nEl telefono es: " + Telefono + "\nEl numero de cuenta es: " + NumCuenta;
        }
    }
}

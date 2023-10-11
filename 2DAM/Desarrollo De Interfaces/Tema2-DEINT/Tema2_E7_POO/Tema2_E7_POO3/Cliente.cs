using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_E7_POO3
{
    internal class Cliente
    {
        private string DNI;
        private string Nombre;
        double CantidadAhorrada;

        public Cliente(string DNI, string nombre)
        {
            this.DNI = DNI;
            this.Nombre = nombre;
            this.CantidadAhorrada = 0;
        }

        public string dni { get; set; }
        public string nombre { get; set; }

        public void Ingresar(double cantidad)
        {
            CantidadAhorrada += cantidad;
        }

        public void Extraer(double cantidad)
        {
            if (CantidadAhorrada >= cantidad)
            {
                CantidadAhorrada -= cantidad;
            }
            else
            {
                Console.WriteLine("No hay suficiente saldo para realizar la extracción.");
            }
        }

        public double ConsultarSaldo()
        {
            return CantidadAhorrada;
        }
    }
}

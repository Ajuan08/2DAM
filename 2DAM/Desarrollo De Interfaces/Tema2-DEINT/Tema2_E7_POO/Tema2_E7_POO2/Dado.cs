using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_E7_POO2
{
    internal class Dado
    {
        private Random random = new Random();

        public int Valor { get; set; }

        public void Tirar()
        {
            Valor = random.Next(1, 6);
        }

        public void Imprimir()
        {
            Console.WriteLine("El valor del dado es: " + Valor);
        }
    }
}

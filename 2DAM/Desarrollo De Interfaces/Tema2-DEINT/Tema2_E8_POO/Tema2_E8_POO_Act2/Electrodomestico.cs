using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_E8_POO_Act2
{
    internal class Electrodomestico
    {
        public int Peso { get; set; } = 5;
        public int Precio_base { get; set; } = 100;

        List<char> Consumo = new List<char>() { 'A','B','C','D','E','F'};
        List<string> Color = new List<string>() { "blanco", "negro", "rojo", "azul", "gris" };

        public Electrodomestico(int precio_base = 100, string color = "Blanco", string consumo = "F", int peso = 5) 
        {

        }

        public Electrodomestico(int precio_base, int peso)
        {
            Precio_base = precio_base;
            Peso = peso;
        }

       

        public void comprobarConsumoEnergia(char letra)
        {
            if(letra >= 'A' && letra <= 'F')
            {
                
            }
            else
            {
               
            }
        }

        



    }
}

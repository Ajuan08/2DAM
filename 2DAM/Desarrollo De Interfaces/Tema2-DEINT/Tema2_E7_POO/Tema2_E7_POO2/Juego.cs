using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_E7_POO2
{
    internal class Juego
    {
        private Dado[] Dados = new Dado[3];

        public Juego()
        {
            for (int i = 0; i < Dados.Length; i++)
            {
                Dados[i] = new Dado();
            }
        }

        public void Jugar()
        {
            foreach (Dado dado in Dados)
            {
                dado.Tirar();
                dado.Imprimir();
            }

            if (Dados[0].Valor == Dados[1].Valor && Dados[1].Valor == Dados[2].Valor)
            {
                Console.WriteLine("¡Has ganado la partida!");
            }
            else
            {
                Console.WriteLine("Has perdido");
            }
        }
    }

}

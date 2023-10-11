using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_E7_POO
{

    internal class TrianguloIsosceles
    {
        internal int LadosIguales { get; set; }
        private int LadoDesigual { get; set; }
        private int Altura { get; set; }

        public TrianguloIsosceles(int _ladosIguales, int _ladoDesigual, int _altura)
        {
            LadosIguales = _ladosIguales;
            LadoDesigual = _ladoDesigual;
            Altura = _altura;
        }

        public int getLadosIguales()
        {  
            return LadosIguales;
        }

        public int getLadoDesigual()
        {
            return LadoDesigual;
        }

        public int getAltura()
        {
            return Altura;
        }

        public void calcularPerimetro()
        {
            var perimetro = LadosIguales + LadoDesigual;
          
            Console.WriteLine("El perímetro del triangulo es: " +perimetro);
        }

        public void calcularArea()
        {
            var area =   (LadoDesigual * Altura) /2;
            Console.WriteLine("El area del triangulo es: "+area);
        }

    }
}

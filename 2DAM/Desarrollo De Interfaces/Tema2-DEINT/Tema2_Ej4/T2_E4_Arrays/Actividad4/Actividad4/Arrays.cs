using System;
using System.Linq;

namespace Actividad4
{
    public class Arrays
    {
        static void Main(string[] args)
        {
        }

        public static int minValorArray(int[] array)
        {
            int minimo = 0;

            for (int i = 0; i < array.Length; i++)
            {
                 minimo = array.Min();
            }
            return minimo;

            throw new NotImplementedException();
        }
        public static int[] invertirArray(int[] array)
        {
          

            for (int i = 0; i < array.Length; i++)
            {
                 array.Reverse();
            }
            return array;
            throw new NotImplementedException();
        }

        public static int comprobarValorEnArray(int[] array, int valor)
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == valor)
                {
                    return i;
                }
            }
            return -1;

            throw new NotImplementedException();
        }

        public static int calcularModa(int[] entrada)
        {
            if (entrada.Length == 0)
            {
                return 0;
            }

            int moda = entrada[0];
            int numRepe = 0;

            for (int i = 0; i < entrada.Length; i++)
            {
                int contador = 1;

                for (int j = i + 1; j < entrada.Length; j++)
                {
                    if (entrada[i] == entrada[j])
                    {
                        contador++;
                    }
                }

                if (contador > numRepe || (contador == numRepe && entrada[i] > moda))
                {
                    moda = entrada[i];
                    numRepe = contador;
                }
            }

            if (numRepe == 1)
            {
                return entrada[0];
            }

            return moda;
            throw new NotImplementedException();
        }
    }
}

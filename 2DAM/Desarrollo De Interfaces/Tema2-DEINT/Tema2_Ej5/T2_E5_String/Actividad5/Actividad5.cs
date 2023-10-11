using System;
using System.Linq;

namespace Actividad5
{
    public class Actividad5
    {
        static void Main(string[] args)
        {
        }

        public static string devolverString(string[] vs)
        {

           return String.Concat(vs);

            throw new NotImplementedException();
        }

        public static string devolverStringOrdenado(string[] vs)
        {

            Array.Sort(vs);
            return String.Concat(vs);

            throw new NotImplementedException();
        }

        public static int contarCaracter(string[] vs, char v)
        {

            int contador = 0;
            foreach (string s in vs)
            {
                foreach (char caracter in s)
                {
                    if (caracter == v)
                    {
                        contador++;
                    }
                }
            }
            return contador;

            throw new NotImplementedException();
        }

        public static int[] sumarArrays(int[] vs1, int[] vs2)
        {
            int[] arraySuma = new int[vs1.Length];
            for (int i = 0; i < vs1.Length; i++)
            {
                arraySuma[i] = vs1[i] + vs2[i];
            }
            return arraySuma;

            throw new NotImplementedException();
        }

           

        public static int[] multiplicarArrays(int[] vs1, int[] vs2)
        {
            int[] arrayMulti = new int[vs1.Length];
            for (int i = 0; i < vs1.Length; i++)
            {
                arrayMulti[i] = vs1[i] * vs2[i];
            }
            return arrayMulti;

            throw new NotImplementedException();
        }

        public static bool isPalindromo(string entrada)
        {
            string entradaMinusculas = entrada.ToLower().Replace(" ", "");
          
            string entradaInvertida = new string(entradaMinusculas.Reverse().ToArray());
         
            return entradaMinusculas == entradaInvertida;



            throw new NotImplementedException();


        }

        public static int contarPalabras(string entrada)
        {
            if (string.IsNullOrEmpty(entrada))
            {
                return 0;
            }
            string[] palabras = entrada.Split(' ');
            return palabras.Length;

            throw new NotImplementedException();
        }

        public static int contarCaracteres(string entrada)
        {

            if (string.IsNullOrEmpty(entrada))
            {
                
                return 0;
            }
            return entrada.Length;
            throw new NotImplementedException();
        }
    }
}

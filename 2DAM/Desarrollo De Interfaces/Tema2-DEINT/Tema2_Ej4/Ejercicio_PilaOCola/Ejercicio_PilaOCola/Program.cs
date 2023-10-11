using System.Collections;

namespace Ejercicio_PilaOCola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una fórmula");
            string formula = Console.ReadLine();

            Stack pila = new Stack();
            foreach (char caracter in formula)
            {
                if (caracter == '(' || caracter == '[' || caracter == '{')
                {
                    pila.Push(caracter);
                }
                else if (caracter == ')' || caracter == ']' || caracter == '}')
                {
                    if (pila.Count == 0 || !pila.Pop().Equals(caracter))
                    {
                        Console.WriteLine("La fórmula no está balanceada");
                        return;
                    }
                }
            }
            if (pila.Count == 0)
            {
                Console.WriteLine("La fórmula está balanceada");
            }
            else
            {
                Console.WriteLine("La fórmula no está balanceada");
            }
        }
    }
}
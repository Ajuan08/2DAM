namespace Tema2_Ej1
{
    internal class Program
    {

        static bool NumPrimo(int numero)
        {
            if (numero < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
         
        }
        static void Main(string[] args)
        {
            int numerosPrimos = 5;
            int numeroActual = 2;
            int numerosEncontrados = 0;

            Console.WriteLine($"Los numeros primos son: ");

            while (numerosEncontrados < numerosPrimos)
            {
                if (NumPrimo(numeroActual))
                {
                    Console.WriteLine(numeroActual);
                    numerosEncontrados++;
                }
                numeroActual++;
            }

                
        }
    }
}
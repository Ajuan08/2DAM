namespace Generico
{
    internal class Program
    {

        static void Main(string[] args)
        {
            String[] nombres = { "Juan", "Silvia", "Alvaro", "Airam" };
            int[] edades = { 22, 23, 24, 25 };

            Console.WriteLine($"Longitud de array de nombres {CalcularLongitudArray(nombres)}");
            Console.WriteLine($"Longitud de array de edades {CalcularLongitudArray(edades)}");

            int CalcularLongitudArray<T>(T[] array)
            {
                return array.Length;
            }
        }

        
    }
}
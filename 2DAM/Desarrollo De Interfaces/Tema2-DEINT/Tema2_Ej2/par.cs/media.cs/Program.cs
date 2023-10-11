namespace media.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserta 4 números que deseas la media: ");

            double suma = 0;

            for (int i = 0; i < 4; i++)
            {
                double numero = Convert.ToDouble(Console.ReadLine());
                suma += numero;
            }

            double media = suma / 4;

            Console.WriteLine($"La media de los cuatro números es: {media}");
        }
    }
}
namespace par.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Los Números pares divisibles por 3 del 1 al 50 son:");

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
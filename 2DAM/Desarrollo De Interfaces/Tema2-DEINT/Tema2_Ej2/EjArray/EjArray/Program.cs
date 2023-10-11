namespace EjArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //DEFINIR ARRAY
            int[] array;
            array = new int[10];

            //MATRIZ
            int[,] matriz = new int[3,4];

            //RECORRER ARRAY    
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < matriz.Length; j++) { matriz[i,j] = i;
            }
        }
    }
}
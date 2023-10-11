namespace ListaYDiccionario
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                [0] = "Airam",
                [1] = "Alvaro",
                [2] = "Juan"
            };

            foreach (var item in dic)
            {
                Console.WriteLine(item);
            }


        }

    }
}
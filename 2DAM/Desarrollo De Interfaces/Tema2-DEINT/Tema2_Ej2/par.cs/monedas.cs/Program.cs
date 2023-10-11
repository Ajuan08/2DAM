namespace monedas.cs
{
    internal class Program
    {
        static void Main(string[] args)

        {
            {
                int precioProducto = 45;

                Console.Write("Introduce la cantidad en céntimos: ");
                int cantidadIntroducida = Convert.ToInt32(Console.ReadLine());

                int cambio = cantidadIntroducida - precioProducto;

                if (cambio < 0)
                {
                    Console.WriteLine("La cantidad introducida es insuficiente para comprar el producto.");
                }
                else
                {
                    int[] valoresMonedas = { 200, 100, 50, 20, 10, 5 };
                    int[] cantidadesMonedas = new int[valoresMonedas.Length];

                    for (int i = 0; i < valoresMonedas.Length; i++)
                    {
                        int moneda = valoresMonedas[i];
                        int cantidad = cambio / moneda;
                        cantidadesMonedas[i] = cantidad;
                        cambio %= moneda;
                    }

                    Console.WriteLine($"Para dar cambio de {cantidadIntroducida} céntimos, se necesitan:");

                    for (int i = 0; i < valoresMonedas.Length; i++)
                    {
                        if (cantidadesMonedas[i] > 0)
                        {
                            string tipoMoneda = valoresMonedas[i] >= 100 ? "euros" : "céntimos";
                            Console.WriteLine($"{cantidadesMonedas[i]} monedas de {valoresMonedas[i]} {tipoMoneda}");
                        }
                    }
                }
            }
        }
    }
}
using System.Reflection.Metadata.Ecma335;

namespace Ejercicio_Exam_Silla
{
    internal class Program
    {

        class Matriz
        {
            private int[,] valores;
            private int filas;
            private int columnas;

            public Matriz(int filas, int columnas)
            {
                this.filas = filas;
                this.columnas = columnas;
                this.valores = new int[filas, columnas];
            }

            public void IngresarValores()
            {
                Console.WriteLine("Ingrese los valores de la matriz:");
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        while (true)
                        {
                            Console.WriteLine($"Fila {i + 1}, Columna {j + 1}: ");
                            string entrada = Console.ReadLine();
                            if (int.TryParse(entrada, out int valor))
                            {
                                valores[i, j] = valor;
                                break;
                            }
                        }
                    }
                }
            }

            public void CalcularPuntoSilla()
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        int valor = valores[i, j];
                        bool filaMinima = true;
                        bool columnaMaxima = true;

                        for (int k = 0; k < columnas; k++)
                        {
                            if (valores[i, k] < valor)
                            {
                                filaMinima = false;
                                break;
                            }
                        }

                        for (int k = 0; k < filas; k++)
                        {
                            if (valores[k, j] > valor)
                            {
                                columnaMaxima = false;
                                break;
                            }
                        }

                        if (filaMinima && columnaMaxima)
                        {
                            Console.WriteLine($"El punto de silla es: {valor}");
                            return;
                        }
                    }
                }
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Ingrese el número de filas: ");
                int filas = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el número de columnas: ");
                int columnas = int.Parse(Console.ReadLine());

                Matriz matriz = new Matriz(filas, columnas);


                matriz.IngresarValores();
                matriz.CalcularPuntoSilla();

            }
        }
    }
}
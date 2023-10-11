using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_E7_POO3
{
    internal class Banco
    {
        private Cliente[] clientes = new Cliente[3];
        bool salir = false;

        public Banco() 
        {
            clientes[0] = new Cliente("1234", "Pepe");
            clientes[1] = new Cliente("567", "Juan");
            clientes[2] = new Cliente("8910", "Mario");
        }

        public void Operar()
        {
            Console.WriteLine("Introduce el DNI del cliente:");
            string DNI = Console.ReadLine();

            Cliente cliente = BuscarCliente(DNI);

            if (cliente != null)
            {

                do
                {
                    Console.WriteLine("Selecciona la operación (1 para ingresar, 2 para extraer, 3 para salir):");
                    int operacion = Convert.ToInt32(Console.ReadLine());

                    

                    switch (operacion)
                    {
                        case 1:
                            
                            cliente.Ingresar(IntroducirCantidad());
                            break;
                        case 2:
                          
                            cliente.Extraer(IntroducirCantidad());
                            break;
                        case 3:
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Operación no válida.");
                            break;
                    }

                } while (salir == false);
            }
            else
            {
                Console.WriteLine("Cliente no encontrado.");
            }
        }

        private double IntroducirCantidad() 
        {
            Console.WriteLine("Introduce la cantidad:");
            return Convert.ToDouble(Console.ReadLine());
        }
        private void CalcularTotal()
        {
            double total = 0;
            foreach (Cliente cliente in clientes)
            {
                if (cliente != null)
                {
                    total += cliente.ConsultarSaldo();
                }
            }
            Console.WriteLine($"El total de dinero depositado es: {total} euros.");
        }

        private Cliente BuscarCliente(string DNI)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente != null)
                {
                    return cliente;
                }
            }
            return null;
        }

        public void MostrarMenu()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("1. Operar");
                Console.WriteLine("2. Calcular Total");
                Console.WriteLine("3. Salir");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Operar();
                        break;
                    case 2:
                        CalcularTotal();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 3);
        }
    }
}

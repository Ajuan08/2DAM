namespace Tema2_E8_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado[] empleados = new Empleado[]
            {
                new Empleado("Rafa"),
                new Directivo("Mario"),
                new Operario("Alfonso"),
                new Oficial("Luis"),
                new Tecnico("Pablo")
            };
            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine(empleado.ToString());
            }
        }
    }
}
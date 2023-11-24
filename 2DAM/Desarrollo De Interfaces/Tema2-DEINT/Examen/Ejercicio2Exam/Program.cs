using System.Threading.Channels;

namespace Ejercicio2Exam
{
    internal class Program
    {
        static List<Publicacion>todasPublicaciones = new List<Publicacion>();
        static List<Publicacion> publicacionLibro = new List<Publicacion>();
        static List<Publicacion> publicacionRevistas = new List<Publicacion>();
        static int opcion;

        static void Main(string[] args)
        {
            try
            {
                do
                {
                    Console.WriteLine("Introduzca que deseas hacer: ");
                    Console.WriteLine("1.- Agregar un Libro");
                    Console.WriteLine("2.- Agregar una Revista");
                    Console.WriteLine("3.- Mostrar publicaciones por Autor");
                    Console.WriteLine("4.- Mostrar todas las publicaciones");
                    Console.WriteLine("5.- Salir");
                    int opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Introduce el titulo");
                            string titulo = Console.ReadLine();
                            Console.WriteLine("Introduce el autor");
                            string autor = Console.ReadLine();
                            Console.WriteLine("Introduce la fecha de creación");
                            DateTime fecha = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Introduce el numero de páginas");
                            int numPaginas = int.Parse(Console.ReadLine());
                            publicacionLibro.Add(new Libros(titulo, autor, fecha, numPaginas));
                            todasPublicaciones.Add(new Libros(titulo, autor, fecha, numPaginas));
                            break;
                        case 2:
                            Console.WriteLine("Introduce el titulo");
                            string tit = Console.ReadLine();
                            Console.WriteLine("Introduce el autor");
                            string aur = Console.ReadLine();
                            Console.WriteLine("Introduce la fecha de creación");
                            DateTime año = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Introduce el numero de Edicion");
                            int numEdicion = int.Parse(Console.ReadLine());
                            publicacionRevistas.Add(new Revistas(tit, aur, año, numEdicion));
                            todasPublicaciones.Add(new Revistas(tit, aur, año, numEdicion));
                            break;
                        case 3:
                            foreach (var item in todasPublicaciones)
                            {
                                Console.WriteLine(todasPublicaciones.Select(p => p.Autor == item.Autor));
                            }
                            break;
                        case 4:
                            foreach (var item in todasPublicaciones)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            break;

                    }

                } while (opcion != 5);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
        }
    }
}

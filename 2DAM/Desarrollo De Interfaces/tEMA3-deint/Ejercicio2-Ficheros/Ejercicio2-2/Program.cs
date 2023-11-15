using System;
using System.IO;

Console.Write("Introduce el nombre del directorio: ");
string directorio = Console.ReadLine();


if (Directory.Exists(directorio))
{
    
    string[] ficheros = Directory.GetFiles(directorio);
    if (ficheros.Length == 0)
    {
        Console.WriteLine("El directorio no contiene ficheros.");
    }
    else
    {
        
        Console.Write("Introduce la extensión de fichero: ");
        string extension = Console.ReadLine();

        foreach (var item in ficheros)
        {
            if (Path.GetExtension(item) == $".{extension}")
            {
                Console.WriteLine(item);
            }
        }
    }
}
else
{
    Console.WriteLine("El directorio no existe.");
}


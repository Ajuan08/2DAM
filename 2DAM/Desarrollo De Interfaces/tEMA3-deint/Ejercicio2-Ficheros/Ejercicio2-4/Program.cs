using System;
using System.IO;

Console.Write("Introduce la extensión de fichero: ");
string extension = Console.ReadLine();

string directorioActual = Directory.GetCurrentDirectory();

string[] ficheros = Directory.GetFiles(directorioActual, $"*.{extension}");

Console.WriteLine($"Ficheros con la extensión '{extension}':");

foreach (var fichero in ficheros)
{
    Console.WriteLine(fichero);
}

Console.Write("¿Deseas borrar los ficheros?: ");
string respuesta = Console.ReadLine();

if (respuesta == "si")
{
    foreach (var fichero in ficheros)
    {
        File.Delete(fichero);
    }

    string[] ficherosRestantes = Directory.GetFiles(directorioActual);
    Console.WriteLine("Ficheros restantes:");
    foreach (var fichero in ficherosRestantes)
    {
        Console.WriteLine(fichero);
    }
}
else
{
    Console.WriteLine("No se han borrado los ficheros.");
}

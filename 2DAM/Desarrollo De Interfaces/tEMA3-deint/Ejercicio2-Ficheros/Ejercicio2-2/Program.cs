using System;
using System.IO;

Console.WriteLine("Introduce el nombre de un directorio");
string nombreDirectorio = Console.ReadLine();

if (Directory.Exists(nombreDirectorio))
{
    string[] archivos = Directory.GetFiles(nombreDirectorio);
    if (archivos.Length > 0)
    {
        string extensionFichero = calcularExtensionFichero(archivos);
        Console.WriteLine($"El fichero mas reciente es: {extensionFichero}");

    }
    else
    {
        Console.WriteLine($"El directorio {nombreDirectorio} existe, pero no tiene archivos");
    }
}
else
{
    Console.WriteLine($"El directorio no existe");
}

string calcularExtensionFichero(string[] archivos)
{
    Console.WriteLine("Intoduzca una extension para el fichero");
    string extensionObtenida = Console.ReadLine();
    var archivoADevolver = "";

    foreach (var item in archivos)
    {
        

        if (extensionObtenida > )
        {
            fecha = fech;
            archivoADevolver = item;
        }
    }
    return archivoADevolver;
}


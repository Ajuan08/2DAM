using System;
using System.IO;

Console.Write("Introduce el nombre del fichero (con extensión): ");
string fichero = Console.ReadLine();


if (File.Exists(fichero))
{
        Console.Write("Introduce la nueva extensión (sin punto): ");
        string nuevaExtension = Console.ReadLine();

        string rutaArchivo = Path.GetDirectoryName(fichero);
        string nombreSinExtension = Path.GetFileNameWithoutExtension(fichero);

        string nuevoNombreArchivo = Path.Combine(rutaArchivo, $"{nombreSinExtension}.{nuevaExtension}");

        File.Copy(fichero, nuevoNombreArchivo);
        File.Delete(fichero);
        Console.WriteLine($"El archivo se ha copiado con la nueva extensión: {nuevoNombreArchivo}");
}
else
{
    Console.WriteLine("El archivo no existe.");
}

using System;
using System.IO;

Console.WriteLine("Introduce el nombre de un directorio");
string nombreDirectorio = Console.ReadLine();

    if (Directory.Exists(nombreDirectorio))
    {
        string[] archivos = Directory.GetFiles(nombreDirectorio);
        if (archivos.Length > 0)
        {
            string ficheroReciente = calcularFicheroReciente(archivos);
            Console.WriteLine($"El fichero mas reciente es: {ficheroReciente}");
            
        }else
        {
            Console.WriteLine($"El directorio {nombreDirectorio} existe, pero no tiene archivos");
        }
    }
    else
    {
        Console.WriteLine($"El directorio no existe");
    }

string calcularFicheroReciente(string[] archivos)
{
    DateTime fecha = DateTime.MinValue;
    var archivoADevolver = "";

    foreach (var item in archivos)
    {
        DateTime fech = File.GetLastWriteTime(item);

        if (fech > fecha)
        {
            fecha = fech;
            archivoADevolver = item;
        }
    }
    return archivoADevolver;
}



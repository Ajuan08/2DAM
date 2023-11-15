using System;
using System.IO;

Console.Write("Introduce el nombre del directorio: ");
string directorio = Console.ReadLine();


if (Directory.Exists(directorio))
{
    Console.Write("Introduce el nombre del subdirectorio : ");
    string subdirectorio = Console.ReadLine();
    
    string rutaCompleta = Path.Combine(directorio, subdirectorio);
   
    Directory.CreateDirectory(rutaCompleta);
    
    Console.Write("Introduce la extensión de fichero a copiar: ");
    string extension = Console.ReadLine();

    string[] archivos = Directory.GetFiles(directorio);

    foreach (var item in archivos)
    {
        if (Path.GetExtension(item) == $".{extension}")
        {
            string destino = Path.Combine(rutaCompleta, Path.GetFileName(item));
            File.Copy(item, destino);
        }
    }
    Console.WriteLine($"Archivos con extensión '{extension}' copiados al subdirectorio '{subdirectorio}'.");
}
else
{
    Console.WriteLine("El directorio no existe.");
}
    


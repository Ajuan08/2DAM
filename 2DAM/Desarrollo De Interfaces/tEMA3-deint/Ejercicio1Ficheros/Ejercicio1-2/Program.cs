using System;
using System.IO;

Console.WriteLine("Introduzca el nombre de un fichero de texto");
string  nombre = Console.ReadLine();
Console.WriteLine("Introduzca la frase a buscar");
string frase = Console.ReadLine();

FileInfo fileInfo = new FileInfo(nombre);
if (fileInfo.Exists)
{
    string[] palabra = File.ReadAllLines(nombre);
    int contador = 0;
    foreach (var item in palabra)
    {
        contador++;
        if(item == frase)
        {
            Console.WriteLine($"Se encuentra en la linea: {contador}  y la palabra es: {item}");
        }
    }
}
else
{
    Console.WriteLine("El archivo no existe");
}

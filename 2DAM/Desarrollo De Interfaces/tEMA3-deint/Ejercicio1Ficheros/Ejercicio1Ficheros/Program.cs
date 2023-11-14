using System;
using System.IO;


string ficheroOrigen = args[0];
string ficheroDestino = args[1];

try
{
    string contenidoFichero = File.ReadAllText(ficheroOrigen);
    File.WriteAllText(ficheroDestino, contenidoFichero);
    Console.WriteLine($"Se ha copiado correctamente el archivo: {ficheroOrigen} a {ficheroDestino}");

} catch(Exception err)
{
    Console.WriteLine($"Ha ocurrido un error: {err.Message}");
}


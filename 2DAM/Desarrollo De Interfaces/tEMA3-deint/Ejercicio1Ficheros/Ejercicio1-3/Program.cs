using System;
using System.IO;


string ficheroOrigen = args[0];
string ficheroDestino = args[1];

try
{
    File.Copy(ficheroOrigen, ficheroDestino);
    Console.WriteLine($"Se ha copiado correctamente el contenido de {ficheroOrigen} a {ficheroDestino}.");
}
catch(Exception err)
    {
        Console.WriteLine(err.Message);
    }

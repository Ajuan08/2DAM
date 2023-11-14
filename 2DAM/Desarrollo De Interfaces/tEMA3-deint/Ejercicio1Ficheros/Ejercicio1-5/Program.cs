using System;
using System.IO;

Console.WriteLine("Introduce el nombre del primer archivo a combinar");
string archivo1 = Console.ReadLine();
Console.WriteLine("Introduce el nombre del segundo archivo a combinar");
string archivo2 = Console.ReadLine();

try
{
    StreamWriter stream = new StreamWriter(@"S:\GitHub\2DAM\2DAM\Desarrollo De Interfaces\Tema3-DEINT\Ejercicio1Ficheros\Ejercicio1-5");
    string[] contenido1 = File.ReadAllLines(archivo1);
    string[] contenido2 = File.ReadAllLines(archivo2);

} catch(Exception err)
{
    Console.WriteLine(err.Message);
}

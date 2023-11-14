using System;
using System.IO;

string[] contenido = File.ReadAllLines(@"S:\GitHub\2DAM\2DAM\Desarrollo De Interfaces\Tema3-DEINT\Ejercicio1Ficheros\Ejercicio1-6/enteros.txt");
int suma = 0;
foreach (var item in contenido)
{
    var numeroLineas = item.Split(',', ' ');
    foreach (var numeros in numeroLineas)
    {
        Console.WriteLine("Los numeros son:" +numeros);
        suma += int.Parse(numeros);

    }
}
Console.WriteLine($"La suma de los numeros es: {suma}");
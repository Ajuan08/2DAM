using System;
using System.IO;

const string calificaciones = @"S:\GitHub\2DAM\2DAM\Desarrollo De Interfaces\Tema3-DEINT\Ejercicio1Ficheros\Ejercicio1-4/calificaciones.txt";

string[] lineas = File.ReadAllLines(calificaciones);

string alumno = "";
int califInformatica = 0;
int calificacionMates = 0;
double calificacionMatesMedia = 0;

foreach (var item in lineas)
{
    string[] palabra = item.Split(' ');

    if (int.Parse(palabra[1]) > califInformatica)
    {
        alumno = palabra[0];
        califInformatica = int.Parse(palabra[1]);
    }
    calificacionMates += int.Parse(palabra[2]);
}

calificacionMatesMedia = calificacionMates / lineas.Length;

Console.WriteLine($"El mejor Alumno de Informatica es: {alumno} con nota: {califInformatica}");
Console.WriteLine($"La media del grupo en Matemáticas es: {calificacionMatesMedia}");



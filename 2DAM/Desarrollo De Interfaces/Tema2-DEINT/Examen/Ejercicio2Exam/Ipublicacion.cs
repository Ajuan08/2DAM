using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio2Exam
{
    internal class Ipublicacion
    {
        public string Titulo {  get; set; }
        public string Autor {  get; set; }
        public DateTime Año { get; set; }

        public Ipublicacion() { }
        public Ipublicacion(string titulo, string autor, DateTime año)
        {
            validarTitulo(titulo);
            validarAutor(autor);
            Año = año;
        }

        public string MostrarDetalles()
        {
            return "El Título es: "+Titulo+"\nEl autor es: "+Autor+ "\nLa fecha de publicación es: " + Año.ToString("dd/MM/yyyy");
        }

        public void validarTitulo(string titulo)
        {
            if (Regex.IsMatch(titulo, @"^[A-Za-z]{1,}$"))
            {
                Titulo = titulo;
            }
            else
            {
                throw new ExcepcionTitulo("El titulo no es correcto, Ha superado los 30 caracteres o es Nulo");
            }
        }

        public void validarAutor(string autor)
        {
            if(Regex.IsMatch(autor, @"^[A-Za-z]{1,}$"))
            {
                Autor = autor;
            }
            else
            {
                throw new ExcepcionAutor("El autor no es correcto, Ingrese un autor");
            }
        }
    }
}

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Actividad09
{
    public class Actividad9
    {
        static void Main(string[] args)
        {
        }

        public static bool cadenaContenedora(string cadena, string valor)
        {
            string patron = "\\b" + Regex.Escape(valor) + "\\b";
            return Regex.IsMatch(cadena, patron, RegexOptions.IgnoreCase);
        }

        public static bool numeroEntero(string v)
        {
            throw new NotImplementedException();
        }

        public static bool isSpanish(string telefono)
        {
            throw new NotImplementedException();
        }

        public static bool isCorrectEmail(string email)
        {
            throw new NotImplementedException();
        }

        public static bool numeroPositivo(string v)
        {
            throw new NotImplementedException();
        }

        public static bool isOctal(string v)
        {
            throw new NotImplementedException();
        }

        public static bool dni(string v)
        {
            throw new NotImplementedException();
        }

        public static bool fechaFormat(string v)
        {
            throw new NotImplementedException();
        }

        public static bool isBinario(string v)
        {
            throw new NotImplementedException();
        }
    }
}

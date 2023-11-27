using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJardineria.Clases
{
    public class Oficina
    {
        public string CodigoOficina { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string Region { get; set; }
        public string CodigoPostal { get; set; }
        public string Telefono { get; set; }
        public string LineaDireccion1 { get; set; }
        public string LineaDireccion2 { get; set; }


        public Oficina()
        {
        }
        public Oficina(string codigoOficina, string ciudad, string pais, string region, string codigoPostal, string telefono, string lineaDireccion1, string lineaDireccion2)
        {
            CodigoOficina = codigoOficina;
            Ciudad = ciudad;
            Pais = pais;
            Region = region;
            CodigoPostal = codigoPostal;
            Telefono = telefono;
            LineaDireccion1 = lineaDireccion1;
            LineaDireccion2 = lineaDireccion2;
        }
    }

}

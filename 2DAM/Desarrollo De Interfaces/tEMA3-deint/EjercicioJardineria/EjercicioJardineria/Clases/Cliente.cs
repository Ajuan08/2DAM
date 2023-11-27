using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJardineria.Clases
{
    public class Cliente
    {
        public int CodigoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string NombreContacto { get; set; }
        public string ApellidoContacto { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string LineaDireccion1 { get; set; }
        public string LineaDireccion2 { get; set; }
        public string Ciudad { get; set; }
        public string Region { get; set; }
        public string Pais { get; set; }
        public string CodigoPostal { get; set; }
        public int? CodigoEmpleadoRepVentas { get; set; }
        public decimal? LimiteCredito { get; set; }
        public Cliente()
        {
        }
        public Cliente(int codigoCliente, string nombreCliente, string nombreContacto, string apellidoContacto, string telefono, string fax, string lineaDireccion1, string lineaDireccion2, string ciudad, string region, string pais, string codigoPostal, int? codigoEmpleadoRepVentas, decimal? limiteCredito)
        {
            CodigoCliente = codigoCliente;
            NombreCliente = nombreCliente;
            NombreContacto = nombreContacto;
            ApellidoContacto = apellidoContacto;
            Telefono = telefono;
            Fax = fax;
            LineaDireccion1 = lineaDireccion1;
            LineaDireccion2 = lineaDireccion2;
            Ciudad = ciudad;
            Region = region;
            Pais = pais;
            CodigoPostal = codigoPostal;
            CodigoEmpleadoRepVentas = codigoEmpleadoRepVentas;
            LimiteCredito = limiteCredito;
        }
    }

}

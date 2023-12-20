using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRecuDEINT
{
    public class Editorial
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public List<Libro> listaLibros = new List<Libro>();

        public Editorial() { }
        
        public Editorial(int codigo, string  nombre, string direccion) 
        {
            Codigo = codigo;
            Nombre = nombre;
            Direccion = direccion;
        }
    }
}

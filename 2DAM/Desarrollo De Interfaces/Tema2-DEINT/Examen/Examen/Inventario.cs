using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Inventario
    {
        public string Nombre {  get; set; }
        public int Stock { get; set; }

        public Inventario(string nombre, int stock) 
        {
            Nombre = nombre;
            Stock = stock;
        }

        Dictionary<>
        
        
        public override string ToString()
        {
            return "El nombre es:" + Nombre + "\nEl stock es de: " + Stock;
        }
    }
}

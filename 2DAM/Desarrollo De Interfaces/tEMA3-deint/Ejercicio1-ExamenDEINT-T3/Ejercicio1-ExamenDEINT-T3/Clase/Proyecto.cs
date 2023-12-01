using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ejercicio1_ExamenDEINT_T3.Clase
{
    public class Proyecto
    {
        
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime fecha_inicio { get; set; }

        public Proyecto() { }

        public Proyecto(string nombre, string descripcion, DateTime fecha_inicio)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            this.fecha_inicio = fecha_inicio;
        }

        

}
}

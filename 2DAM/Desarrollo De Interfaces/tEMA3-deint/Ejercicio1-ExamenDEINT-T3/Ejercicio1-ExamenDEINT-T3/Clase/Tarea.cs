using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_ExamenDEINT_T3.Clase
{
    internal class Tarea
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_vencimiento { get; set; }
        public string Estado { get; set; }

        public Tarea() { }

        public Tarea(string nombre, string descripcion, DateTime fecha_vencimiento, string estado)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Fecha_vencimiento = fecha_vencimiento;
            Estado = estado;
        }
    }
}

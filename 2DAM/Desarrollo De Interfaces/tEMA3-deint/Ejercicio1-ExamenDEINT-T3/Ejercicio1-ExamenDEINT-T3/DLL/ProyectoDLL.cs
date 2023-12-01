using Ejercicio1_ExamenDEINT_T3.Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_ExamenDEINT_T3.DLL
{
    internal class ProyectoDLL
    {
        public List<Tarea> ListaTarea = new List<Tarea>();
        public void crearXML()
        {
           Directory.CreateDirectory(Directory.GetCurrentDirectory());



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_T3_Acceso_BBDD.Model
{
    internal class Estudiante
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Ciclo { get; set; }
        public string Email { get; set; }
        public byte[] Foto { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Exam_DEINT.Clases
{
    public class Mantenimiento
    {
        public int IdentNum { get; set; }
        public int CodigoDesc {  get; set; }
        public int CodigoVehiculo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin {  get; set; }
        public string Descripcion { get; set; }

        public Mantenimiento() { }

        public Mantenimiento(int identNum, int codigoDesc, int codigoVehiculo, DateTime fechaInicio, DateTime fechaFin, string descripcion)
        {
            IdentNum = identNum;
            CodigoDesc = codigoDesc;
            CodigoVehiculo = codigoVehiculo;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Descripcion = descripcion;
        }
    }
}

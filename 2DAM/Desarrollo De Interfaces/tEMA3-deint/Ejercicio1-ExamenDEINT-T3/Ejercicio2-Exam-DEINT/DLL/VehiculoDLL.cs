using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2_Exam_DEINT.Conexionn;

namespace Ejercicio2_Exam_DEINT.DLL
{
    public class VehiculoDLL
    {
        Conexion conexion;

        public VehiculoDLL()
        {
            conexion = new Conexion();
        }
        public bool añadirVehiculo(int identNum, string matricula, string modelo, string marca, int añoFab, string estado)
        {
            return conexion.EjecutarComandoSinRetornarDatos($"Insert into vehiculo (codigo,matricula,modelo,marca,año_fabricacion,estado) values ('{identNum}','{matricula}','{modelo}','{marca}','{añoFab}','{estado}')");
        }
    }
}


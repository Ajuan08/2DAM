using Ejercicio4_T3_Acceso_BBDD.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4_T3_Acceso_BBDD.DLL
{
    internal class CicloDLL
    {
        Conexion conexion;

        public CicloDLL()
        {
            conexion = new Conexion();
        }
        public bool Agregar(string nombreCiclo)
        {
            return conexion.EjecutarComandoSinRetornarDatos("Insert into Ciclo(nombre) values ('" + nombreCiclo + "')");
        }

        public bool Modificar(string nombreCiclo ,int idCiclo)
        {
            return conexion.EjecutarComandoSinRetornarDatos("UPDATE Ciclo SET nombre = '" + nombreCiclo + "' WHERE id = '" + idCiclo + "'");
        }

        public bool Borrar(int idCiclo)
        {
            return conexion.EjecutarComandoSinRetornarDatos("DELETE FROM Ciclo WHERE id = ('" + idCiclo + "')");
        }

        

        public DataSet MostrarCiclos()
        {
            SqlCommand sentencia = new SqlCommand("Select * from ciclo");
            return conexion.EjecutarSentencia(sentencia);
        }
    }
}

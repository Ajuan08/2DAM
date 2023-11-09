using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio4_T3_Acceso_BBDD.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ejercicio4_T3_Acceso_BBDD.DLL
{
    internal class EstudianteDLL
    {
        Conexion conexion;

        public EstudianteDLL()
        {
            conexion = new Conexion();
        }
        public bool Agregar(string nombreEstudiante, string ape1, string ape2, string correo, byte[] foto)
        {
            return conexion.EjecutarComandoSinRetornarDatos("INSERT INTO Estudiante(nombre, primerApellido, segundoApellido, email, foto) VALUES('" + nombreEstudiante + "', '" + ape1 + "', '" + ape2 + "', '" + correo + "', '" + foto + "')");
        }

        public bool Modificar(string nombreEstudiante, string ape1, string ape2, string correo, byte[] foto, int clave)
        {
            return conexion.EjecutarComandoSinRetornarDatos("UPDATE Estudiante SET nombre ='" + nombreEstudiante + "', primerapellido ='" + ape1 + "', segundoapellido ='" + ape2 + "', email ='" + correo + "', foto ='" + foto + "' WHERE id = '" + clave + "'");
        }

        public bool Borrar(int idEstudiante)
        {
            return conexion.EjecutarComandoSinRetornarDatos("DELETE FROM Estudiante WHERE id = ('" + idEstudiante + "')");
        }

        public DataSet MostrarEstudiante()
        {
            SqlCommand sentencia = new SqlCommand("Select id, nombre, primerapellido, segundoapellido, email from estudiante");
            return conexion.EjecutarSentencia(sentencia);
        }
    }
}


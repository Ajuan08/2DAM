using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRecuDEINT.DLL
{
    public class EditorialesDLL
    {
        private static EditorialesDLL instance;
        private Conexion conexion;

        private EditorialesDLL()
        {
            conexion = new Conexion();
        }
        public static EditorialesDLL GetInstance()
        {
            if (instance == null)
            {
                instance = new EditorialesDLL();
            }
            return instance;
        }

        public void agregarEditorial(int codigo, string nombre, string direccion)
        {
            conexion.EjecutarComandoSinRetornarDatos($"INSERT INTO Editorial(codigo,nombre,direccion) VALUES({codigo},'{nombre}','{direccion}')");
        }

        public void modificarEditorial(int codigo, string nombre, string direccion)
        {
            conexion.EjecutarComandoSinRetornarDatos($"UPDATE Editorial SET codigo= {codigo}, nombre= '{nombre}', direccion= '{direccion}'");
        }

        public void eliminarEditorial(int cod)
        {
            conexion.EjecutarComandoSinRetornarDatos($"DELETE FROM Editorial WHERE codigo= {cod}");
        }

        public DataSet mostrarEditoriales()
        {
            return conexion.EjecutarSentencia("SELECT * FROM Editorial");
        }

        
    }
}

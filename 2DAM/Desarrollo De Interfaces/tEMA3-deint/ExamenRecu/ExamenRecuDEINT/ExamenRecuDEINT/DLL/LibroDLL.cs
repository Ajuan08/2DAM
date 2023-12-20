using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRecuDEINT.DLL
{
    public class LibroDLL
    {
        private static LibroDLL instance;
        private Conexion conexion;

        private LibroDLL()
        {
            conexion = new Conexion();
        }
        public static LibroDLL GetInstance()
        {
            if (instance == null)
            {
                instance = new LibroDLL();
            }
            return instance;
        }

        public void agregarLibro(int isbn, string titulo,string autor,string genero,int ano,int cod_edit)
        {
            conexion.EjecutarComandoSinRetornarDatos($"INSERT INTO Libro(isbn,titulo,autor,genero,año_publicacion,cod_editorial) VALUES({isbn},'{titulo}','{autor}','{genero}',{ano},{cod_edit})");
        }

        public void modificarLibros(int isbn, string titulo, string autor, string genero, int ano, int cod_edit)
        {
            conexion.EjecutarComandoSinRetornarDatos($"UPDATE Libro SET isbn= {isbn}, titulo= '{titulo}', autor= '{autor}', genero= '{genero}', año_publicacion={ano} WHERE cod_editorial={cod_edit}");
        }

        public void eliminarLibro(int cod)
        {
            conexion.EjecutarComandoSinRetornarDatos($"DELETE FROM Libro WHERE cod_editorial= {cod}");
        }

        public DataSet mostrarLibros()
        {
            return conexion.EjecutarSentencia("SELECT * FROM Libro");
        }

        public DataSet listadoPorEditorial(int codEditorial)
        {
            return conexion.EjecutarSentencia($"SELECT * FROM Libro WHERE cod_editorial= {codEditorial}");
        }

        public DataSet busquedaLibros(int genero)
        {
            return conexion.EjecutarSentencia($"SELECT * FROM Libro WHERE genero= {genero}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Exam_DEINT.Conexionn
{
    public class Conexion
    {
        private string cadenaConexion = "Data Source=DAM2-19; Initial Catalog=db.vehiculo; Integrated Security = True";
        SqlConnection sqlConnection;

        public SqlConnection EstablecerConexion()
        {
            this.sqlConnection = new SqlConnection(this.cadenaConexion);
            return this.sqlConnection;
        }

        public bool EjecutarComandoSinRetornarDatos(string strComando)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = strComando;
                sqlCommand.Connection = this.EstablecerConexion();
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable EjecutarComandoRetornarDatos(string strComando)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = strComando;
                sqlCommand.Connection = this.EstablecerConexion();
                sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(strComando, sqlConnection);
                da.Fill(dt);
                sqlConnection.Close();

                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }

        public DataSet EjecutarSentencia(string sqlComando)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = sqlComando;
                sqlCommand.Connection = this.EstablecerConexion();
                adapter.SelectCommand = sqlCommand;
                sqlConnection.Open();
                adapter.Fill(ds);
                sqlConnection.Close();
                return ds;

            }
            catch (Exception)
            {
                return ds;
                throw;
            }
        }

    }
}

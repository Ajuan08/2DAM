﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRecuDEINT
{
    public class Conexion
    {
        private string cadenaConexion = "Data Source=DAM2-19; Initial Catalog=RecuExamen; Integrated Security = True";
        SqlConnection sqlConnection;

        public SqlConnection EstablecerConexion()
        {
            sqlConnection = new SqlConnection(cadenaConexion);
            return sqlConnection;
        }
        public bool EjecutarComandoSinRetornarDatos(string strComando)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = strComando;
                sqlCommand.Connection = EstablecerConexion();
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
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
                sqlCommand.Connection = EstablecerConexion();
                adapter.SelectCommand = sqlCommand;
                sqlConnection.Open();
                adapter.Fill(ds);
                sqlConnection.Close();
                return ds;
            }
            catch (Exception e)
            {
                return ds;
            }
        }
    }
}

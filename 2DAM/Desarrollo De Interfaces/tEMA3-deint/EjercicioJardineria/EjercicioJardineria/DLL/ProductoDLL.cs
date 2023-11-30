using Jardineria.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJardineria.DLL
{
    public class ProductoDLL
    {
        Conexion conexion;

        public ProductoDLL()
        {
            conexion = new Conexion();
        }

        public bool añadirProductos(int codigo_producto, string nombre, string gama, string dimensiones, string proveedor,string descripcion,int cantidad_en_stock, int precio_venta, int precio_proveedor) 
        {
            return conexion.EjecutarComandoSinRetornarDatos($"Insert into producto (codigo_producto,nombre,gama,dimensiones,proveedor,descripcion,cantidad_en_stock,precio_venta,precio_proveedor) values ('{codigo_producto}','{nombre}','{gama}','{dimensiones}','{proveedor}','{descripcion}','{cantidad_en_stock}','{precio_venta}','{precio_proveedor}')");
        }

        public bool eliminarGama(string gama)
        {
            return conexion.EjecutarComandoSinRetornarDatos($"Delete from gama_producto where gama = '{gama}' ");
        }

        public static DataSet ConsultarPedidosEntregados()
        {
            Conexion conexion = new Conexion();
            DataSet resultado = conexion.EjecutarSentencia($"SELECT codigo_pedido, fecha_pedido, fecha_esperada, fecha_entrega, estado, comentarios, codigo_cliente FROM pedido WHERE fecha_entrega=fecha_entrega");

            return resultado;
        }

        public static DataSet ConsultarClientesQueNoPagan()
        {
            Conexion conexion = new Conexion();
            DataSet resultado = conexion.EjecutarSentencia($"SELECT nombre_cliente FROM (SELECT nombre_cliente, cliente.codigo_cliente FROM pedido JOIN cliente ON pedido.codigo_cliente=cliente.codigo_cliente) AS clientes_pedidos JOIN pago ON clientes_pedidos.codigo_cliente=pago.codigo_cliente");

            return resultado;
        }

        public static DataSet ConsultarPrecioMasBaratoYMasCaro()
        {
            Conexion conexion = new Conexion();
            DataSet resultado = conexion.EjecutarSentencia("SELECT MAX(precio_venta) 'Precio más caro', MIN(precio_venta) 'Precio más barato' FROM producto");

            return resultado;
        }

        public List<string> ConsultarEmpleadoJefeDeterminado(int codigoJefe)
        {
            List<string> resultados = new List<string>();
            Conexion conexion = new Conexion();
            DataSet resultado = conexion.EjecutarSentencia($"SELECT * FROM empleado where codigo_jefe = {codigoJefe}");

            foreach (DataRow row in resultado.Tables[0].Rows)
            {
                string datosEmpleado = $"{row["nombre"]} {row["apellido1"]} {row["apellido2"]} {row["email"]}";
                resultados.Add(datosEmpleado);
            }

            return resultados;
        }
    }
}

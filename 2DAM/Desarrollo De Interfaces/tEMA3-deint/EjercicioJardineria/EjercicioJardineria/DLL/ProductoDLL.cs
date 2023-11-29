using Jardineria.Conexion;
using System;
using System.Collections.Generic;
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
    }
}

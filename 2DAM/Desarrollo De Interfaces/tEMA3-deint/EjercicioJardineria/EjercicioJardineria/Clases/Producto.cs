using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJardineria.Clases
{
    public class Producto
    {
        public string CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public string Gama { get; set; }
        public string Dimensiones { get; set; }
        public string Proveedor { get; set; }
        public string Descripcion { get; set; }
        public short CantidadEnStock { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal? PrecioProveedor { get; set; }

        public Producto()
        {
        }

        public Producto(string codigoProducto, string nombre, string gama, string dimensiones, string proveedor, string descripcion, short cantidadEnStock, decimal precioVenta, decimal? precioProveedor)
        {
            CodigoProducto = codigoProducto;
            Nombre = nombre;
            Gama = gama;
            Dimensiones = dimensiones;
            Proveedor = proveedor;
            Descripcion = descripcion;
            CantidadEnStock = cantidadEnStock;
            PrecioVenta = precioVenta;
            PrecioProveedor = precioProveedor;
        }
    }

}

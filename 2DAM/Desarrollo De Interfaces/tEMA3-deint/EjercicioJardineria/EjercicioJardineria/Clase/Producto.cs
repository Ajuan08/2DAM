using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJardineria.Clase
{
    public class Producto
    {
        public int CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public string Gama { get; set; }
        public string Dimensiones { get; set; }
        public string Proveedor { get; set; }
        public string Descripcion { get; set; }
        public int CantidadStock { get; set;}
        public int PrecioVenta { get; set; }
        public int PrecioProveedor { get; set; }

        public Producto() { }
        public Producto(int codigoProducto, string nombre, string gama, string dimensiones, string proveedor, string descripcion, int cantidadStock, int precioVenta, int precioProveedor)
        {
            CodigoProducto = codigoProducto;
            Nombre = nombre;
            Gama = gama;
            Dimensiones = dimensiones;
            Proveedor = proveedor;
            Descripcion = descripcion;
            CantidadStock = cantidadStock;
            PrecioVenta = precioVenta;
            PrecioProveedor = precioProveedor;
        }

        public override string ToString()
        {
            return $"Código: {CodigoProducto}\nNombre: {Nombre}\nGama: {Gama}\nDimensiones: {Dimensiones}\nProveedor: {Proveedor}\nDescripción: {Descripcion}\nCantidad en Stock: {CantidadStock}\nPrecio de Venta: {PrecioVenta}\nPrecio de Proveedor: {PrecioProveedor}";
        }
    }
}

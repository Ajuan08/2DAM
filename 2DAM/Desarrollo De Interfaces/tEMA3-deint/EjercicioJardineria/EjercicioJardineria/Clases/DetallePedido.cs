using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJardineria.Clases
{
    public class DetallePedido
    {
        public int CodigoPedido { get; set; }
        public string CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnidad { get; set; }
        public short NumeroLinea { get; set; }
        public DetallePedido()
        {
        }
        public DetallePedido(int codigoPedido, string codigoProducto, int cantidad, decimal precioUnidad, short numeroLinea)
        {
            CodigoPedido = codigoPedido;
            CodigoProducto = codigoProducto;
            Cantidad = cantidad;
            PrecioUnidad = precioUnidad;
            NumeroLinea = numeroLinea;
        }
    }

}

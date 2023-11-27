using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJardineria.Clases
{
    public class Pedido
    {
        public int CodigoPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEsperada { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string Estado { get; set; }
        public string Comentarios { get; set; }
        public int CodigoCliente { get; set; }
        public Pedido()
        {
        }
        public Pedido(int codigoPedido, DateTime fechaPedido, DateTime fechaEsperada, DateTime? fechaEntrega, string estado, string comentarios, int codigoCliente)
        {
            CodigoPedido = codigoPedido;
            FechaPedido = fechaPedido;
            FechaEsperada = fechaEsperada;
            FechaEntrega = fechaEntrega;
            Estado = estado;
            Comentarios = comentarios;
            CodigoCliente = codigoCliente;
        }
    }

}

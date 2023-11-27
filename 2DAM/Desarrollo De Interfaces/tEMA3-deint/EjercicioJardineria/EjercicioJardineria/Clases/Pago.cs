using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJardineria.Clases
{
    public class Pago
    {
        public int CodigoCliente { get; set; }
        public string FormaPago { get; set; }
        public string IdTransaccion { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Total { get; set; }
        public Pago()
        {
        }
        public Pago(int codigoCliente, string formaPago, string idTransaccion, DateTime fechaPago, decimal total)
        {
            CodigoCliente = codigoCliente;
            FormaPago = formaPago;
            IdTransaccion = idTransaccion;
            FechaPago = fechaPago;
            Total = total;
        }
    }

}

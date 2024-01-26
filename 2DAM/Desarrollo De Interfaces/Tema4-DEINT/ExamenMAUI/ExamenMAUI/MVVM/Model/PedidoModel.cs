using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenMAUI.MVVM.Model
{
    [AddINotifyPropertyChangedInterface]
    public class PedidoModel
    {
        public int calificacion { get; set; }
        public bool estadoPedido { get; set; } 
        public string entregadoPor { get; set; } = "Entregado por: Antonio Juan";
        public DateTime fecha { get; set; }
    }
}

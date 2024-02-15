using Practica10ControlGastos.MVVM.Model;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica10ControlGastos.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class GastosViewModel
    {
        public Transaccion Transaccion { get; set; }

        public List<Transaccion> Transacciones { get; set; }

        public Command AnadirTransaccion { get; set; }

        public double TotalBalance { get; set; }
        public double TotalGastos { get; set; }
        public double TotalIngresos { get; set; }

        public GastosViewModel()
        {
            Transaccion = new Transaccion();
            Transaccion.Fecha = DateTime.Now;
            Recargar();
            CalcularTotalIngresado();
            CalcularTotal();
            
            AnadirTransaccion = new Command(anadirTrans);

        }

        private void anadirTrans()
        {
            
            App.TransaccionRepo.SaveItemWithChildren(Transaccion);
            Recargar();
            CalcularTotalIngresado();
            CalcularTotal();
            Transaccion = new Transaccion();

        }

        private void Recargar()
        {
            Transacciones = App.TransaccionRepo.GetItemWithChildren().ToList();
        }

        private void CalcularTotal()
        {
            TotalBalance = 0;
            TotalBalance = TotalIngresos - TotalGastos;
            
        }

        private void CalcularTotalIngresado()
        {
            TotalIngresos = 0;
            TotalGastos = 0;
            foreach (var item in Transacciones)
            {
                if (item.EsIngreso)
                {
                    TotalIngresos += Double.Parse(item.Cantidad);
                    item.Cantidad = $" + {item.Cantidad} €";
                    
                }
                else
                {
                    TotalGastos += Double.Parse(item.Cantidad);
                    item.Cantidad = $" - {item.Cantidad} €";
                }
            }

        }

    }

}

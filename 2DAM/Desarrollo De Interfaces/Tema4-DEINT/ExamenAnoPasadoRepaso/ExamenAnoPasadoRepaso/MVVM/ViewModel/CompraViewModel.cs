using ExamenAnoPasadoRepaso.MVVM.Model;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExamenAnoPasadoRepaso.MVVM.ViewModel
{
    public class CompraViewModel
    {
        public Compra compra { get; set; }
 
        public ICommand BotonMas { get; set; }
        public ICommand BotonMenos { get; set; }
        public ICommand CommandPagarLuego { get; set; }
        public ICommand CommandPagarAhora { get; set; }


        public CompraViewModel()
        {
            compra = new Compra();

            compra.FechaHoraActual = DateTime.Now;

            BotonMas = new Command(() =>
            {
                compra.PorcentajeDescuento += 10;
            });

            BotonMenos = new Command(() =>
            {
                compra.PorcentajeDescuento -= 10;
            });

            CommandPagarLuego = new Command(() =>
            {
                Application.Current.MainPage.DisplayAlert("Nike Store", "Pedido Guardado", "OK");
            });

            CommandPagarAhora = new Command((s) =>
            {
                Application.Current.MainPage.DisplayAlert("Nike Store", $"Pagado {compra.PrecioTotal}€", "OK");
            });
        }
    }
}

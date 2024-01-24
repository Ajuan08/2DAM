using ExamenAnoPasadoRepaso.MVVM.Model;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExamenAnoPasadoRepaso.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class CompraViewModel
    {
        
        public Compra compra { get; set; }
        public ICommand CommandPagarLuego { get; }
        public ICommand CommandPagarAhora { get; }

        public CompraViewModel()
        {
            compra = new Compra()
            {
                precioLabelHombre = "89,95",
                precioLabelMujer = "95,95"
            };

            CommandPagarLuego = new Command(() =>
            {
                Application.Current.MainPage.DisplayAlert("Nike Store", "Pedido Guardado", "OK");
            });

            CommandPagarAhora = new Command((s) =>
            {
                Application.Current.MainPage.DisplayAlert("Nike Store", "Pagado:167,31€ ", "OK");
            });
        }
    }
}

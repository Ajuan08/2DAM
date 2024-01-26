using ExamenMAUI.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExamenMAUI.MVVM.ViewModel
{
    public class PedidoViewModel
    {
        public PedidoModel pedido { get; set; }
        public ICommand comando1 { get; set; }
        public ICommand comando2 { get; set; }
        public ICommand comando3 { get; set; }
        public ICommand comando4 { get; set; }



        public PedidoViewModel()
        {
            pedido = new PedidoModel();
            pedido.fecha = DateTime.Now;

            comando1 = new Command(() => 
            {
                pedido.calificacion = 1; 
            });

            comando2 = new Command(() =>
            {
                Application.Current.MainPage.DisplayAlert("A domicilio", $"Gracias por su valoracion de un:{pedido.calificacion} ", "OK");
            });

            comando3 = new Command(() =>
            {
                Application.Current.MainPage.DisplayAlert("A domicilio", "Llama al 123456789", "OK");
            });

            comando4 = new Command(() =>
            {
                Application.Current.MainPage.DisplayAlert("A domicilio", "Manda un correo a: adomicilio@adomicilio.com", "OK");
            });
        }   
    }
}

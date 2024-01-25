using EjercicioRepasoMAUI2.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EjercicioRepasoMAUI2.MVVM.ViewModel
{
    public class PruebaViewModel
    {
        public ICommand comando1 { get; set; }
        public PruebaModel pruebaModel { get; set; }

        public ICommand comando2 { get; set; }
        public ICommand comando3 { get; set; }
        public ICommand comando4 { get; set; }

        public PruebaViewModel()
        {
            pruebaModel = new PruebaModel();
            pruebaModel.fecha = DateTime.Now;

            comando1 = new Command(() =>
            {
                Application.Current.MainPage.DisplayAlert("MENSAJE ",$"El nombre es: {pruebaModel.nombre} \n La medida es de: {(double)pruebaModel.medida / 100} m", "Ok");
            });

            comando2 = new Command(() =>
            {
                pruebaModel.medida = 100;
            });
            comando3 = new Command(() =>
            {
                pruebaModel.medida = 200;
            });
            comando4 = new Command(() =>
            {
                pruebaModel.medida = 300;
            });
        }
    }
}

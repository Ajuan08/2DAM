using EjercicioAhorcado.MVVM.ViewModels;
using System.Collections;

namespace EjercicioAhorcado
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new BotonViewModel();
        }



        
    }

}

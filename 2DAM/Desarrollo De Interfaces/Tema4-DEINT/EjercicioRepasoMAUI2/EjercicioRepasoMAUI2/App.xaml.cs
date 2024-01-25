using EjercicioRepasoMAUI2.MVVM.View;

namespace EjercicioRepasoMAUI2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PruebaView();
        }
    }
}

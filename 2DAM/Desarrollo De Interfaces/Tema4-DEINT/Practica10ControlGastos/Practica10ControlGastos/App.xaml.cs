using Practica10ControlGastos.MVVM.View;

namespace Practica10ControlGastos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View1());
        }
    }
}

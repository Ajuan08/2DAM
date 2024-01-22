using Practica6Calculadora.MVVM.View;

namespace Practica6Calculadora
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Calculadora();
        }
    }
}

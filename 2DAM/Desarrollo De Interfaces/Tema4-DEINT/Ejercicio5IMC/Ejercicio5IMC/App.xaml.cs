using Ejercicio5IMC.MVVM.View;

namespace Ejercicio5IMC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new IMCView();
        }
    }
}

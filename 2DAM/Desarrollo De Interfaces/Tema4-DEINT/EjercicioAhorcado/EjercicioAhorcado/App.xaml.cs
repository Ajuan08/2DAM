using EjercicioAhorcado.MVVM.ViewModels;

namespace EjercicioAhorcado
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}

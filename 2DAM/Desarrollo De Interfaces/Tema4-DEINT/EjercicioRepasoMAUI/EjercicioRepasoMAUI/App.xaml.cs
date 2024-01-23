using EjercicioRepasoMAUI.MVVM.View;

namespace EjercicioRepasoMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TareaView();
        }
    }
}

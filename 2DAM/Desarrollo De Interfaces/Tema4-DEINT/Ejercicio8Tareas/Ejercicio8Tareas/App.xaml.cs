using Ejercicio8Tareas.MVVM.View;

namespace Ejercicio8Tareas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Vista1());
        }
    }
}

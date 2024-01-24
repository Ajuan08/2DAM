using ExamenAnoPasadoRepaso.MVVM.View;

namespace ExamenAnoPasadoRepaso
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CompraView();
        }
    }
}

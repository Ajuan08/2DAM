using ExamenMAUI.MVVM.View;

namespace ExamenMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PedidoView();
        }
    }
}

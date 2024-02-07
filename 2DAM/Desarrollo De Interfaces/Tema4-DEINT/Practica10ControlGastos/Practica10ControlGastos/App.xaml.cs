using Practica10ControlGastos.MVVM.Model;
using Practica10ControlGastos.MVVM.View;
using Practica10ControlGastos.Repository;

namespace Practica10ControlGastos
{
    public partial class App : Application
    {
        
        //public static BaseRepository<Usuario> UsuarioRepo { get; private set; }
        //public static BaseRepository<Transaccion> TransaccionRepo { get; private set; }
        
        public App(/*BaseRepository<Usuario> usu, BaseRepository<Transaccion> trans */ )
        {
            InitializeComponent();
            //UsuarioRepo = usu;
            //TransaccionRepo = trans;
            MainPage = new NavigationPage(new View1());
        }
    }
}

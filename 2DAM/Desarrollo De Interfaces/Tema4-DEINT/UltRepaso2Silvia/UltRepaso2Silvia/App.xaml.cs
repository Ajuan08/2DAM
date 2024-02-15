using UltRepaso2Silvia.MVVM.Model;
using UltRepaso2Silvia.MVVM.View;
using UltRepaso2Silvia.Repository;

namespace UltRepaso2Silvia
{
    public partial class App : Application
    {
        public static BaseRepository<Tarea> TareaRepo { get; private set; }
        public App(BaseRepository<Tarea> tarea)
        {
            InitializeComponent();
            TareaRepo = tarea;
            MainPage = new NavigationPage(new Vista1());
        }
    }
}

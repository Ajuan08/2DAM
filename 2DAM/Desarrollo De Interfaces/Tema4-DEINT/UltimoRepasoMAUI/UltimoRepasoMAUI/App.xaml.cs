using UltimoRepasoMAUI.MVVM.Model;
using UltimoRepasoMAUI.MVVM.View;
using UltimoRepasoMAUI.Repository;

namespace UltimoRepasoMAUI
{
    public partial class App : Application
    {
        public static BaseRepository<TareaModel> TareaRepo { get; private set; }

        public App(BaseRepository<TareaModel> tarea)
        {
            InitializeComponent();
            TareaRepo = tarea;
            MainPage = new NavigationPage(new TareaView());
        }
    }
}

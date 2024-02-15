using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltRepaso2Silvia.MVVM.Model;

namespace UltRepaso2Silvia.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class TareaViewModel
    {
        public Tarea Tarea { get; set; } = new Tarea();
        public List<Tarea> Tareas { get; set; }

        public Command GuardarTareaCommand { get; set; }
        public Command EliminarTareaCommand { get; set; }

        public Command EditarTareaCommand { get; set; }

        public Tarea TareaCambiada { get; set; } = new Tarea();

        public TareaViewModel() 
        {
            CargarTareas();
            GuardarTareaCommand = new Command(GuardarTarea);
            EliminarTareaCommand = new Command(EliminarTarea);
            EditarTareaCommand = new Command(EditarTarea);

        }


        public void GuardarTarea()
        {
            App.TareaRepo.SaveItem(Tarea);
            CargarTareas();
        }

        public void EliminarTarea()
        {
           App.TareaRepo.DeleteItem(TareaCambiada);
            CargarTareas();
            App.Current.MainPage.Navigation.PopAsync();

        }

        public void EditarTarea()
        {
            TareaCambiada = Tarea;
            App.Current.MainPage.Navigation.PopAsync();
        }

        public void CargarTareas()
        {
            Tareas = App.TareaRepo.GetItems().ToList();
        }
    }
}

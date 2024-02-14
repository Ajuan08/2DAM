using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimoRepasoMAUI.MVVM.Model;

namespace UltimoRepasoMAUI.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class TareaViewModel
    {
        public TareaModel Tarea { get; set; } = new TareaModel(); 
        public List<TareaModel> Tareas { get; set; }
        public Command GuardarTareaCommand { get; set; }
        public Command EliminarTareaCommand { get; set; }

        public Command GuardarCambios { get; set; }

        public Command EditarTareaCommand { get; set; }

        public TareaModel TareaAEditar { get; set; } = new TareaModel();

        public TareaViewModel()
        {
            CargarTareas();
            GuardarTareaCommand = new Command(GuardarTarea);
            EliminarTareaCommand = new Command(EliminarTarea);
            //EditarTareaCommand = new Command(EditarTarea);
            GuardarCambios = new Command(GuardarCambiosTarea);

        }

        private void EliminarTarea(object obj)
        {
            App.TareaRepo.DeleteItem(Tarea);
            CargarTareas();

        }

        private void GuardarTarea(object obj)
        {
            App.TareaRepo.SaveItem(Tarea);
            CargarTareas();
        }

        public void GuardarCambiosTarea(object obj)
        {
            App.TareaRepo.SaveItem(TareaAEditar);
            CargarTareas();
        }

        //public void EditarTarea(TareaModel tarea)
        //{
        //    TareaAEditar = Tarea;
        //}

        public void CargarTareas()
        {
            Tareas = App.TareaRepo.GetItems();
        }


    }
}

using EjercicioRepasoMAUI.MVVM.Model;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepasoMAUI.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class TareaViewModel
    {
        public Tarea tarea { get; set; }

        public List<Tarea> Tareas { get; set; } = new List<Tarea>();
        public Command GuardarTareaCommand {  get; set; }

        public TareaViewModel() 
        {
            tarea = new Tarea();
            GuardarTareaCommand = new Command(tareaGuardada);

        }

        public void tareaGuardada()
        {
            Tareas.Add(tarea);
            tarea = new Tarea();
        }
    }
}

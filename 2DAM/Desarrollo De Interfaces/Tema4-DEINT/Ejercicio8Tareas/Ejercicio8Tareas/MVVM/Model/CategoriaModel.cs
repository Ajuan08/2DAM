using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8Tareas.MVVM.Model
{
    [AddINotifyPropertyChangedInterface]
    public class CategoriaModel
    {
        public string Nombre { get; set; }
        public int TareasPendientes { get; set; }
        public double Progress { get; set; } = 0.5;
        public ObservableCollection<TareaModel> Tareas { get; set; } = new ObservableCollection<TareaModel>();
    }


}

using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8Tareas.MVVM.Model
{
    [AddINotifyPropertyChangedInterface]
    public class CategoriaModel
    {
        public string Nombre { get; set; }
    }
}

using Ejercicio8Tareas.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8Tareas.Selectors
{
    public class TareaSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var tarea = item as TareaModel;
            if (!tarea.Hecho)
            {
                Application.Current.Resources.TryGetValue("Normal", out var normal);
                return normal as DataTemplate;
            }
            else
            {
                Application.Current.Resources.TryGetValue("Tachado", out var tachado);
                return tachado as DataTemplate;
            }
        }
    }
}

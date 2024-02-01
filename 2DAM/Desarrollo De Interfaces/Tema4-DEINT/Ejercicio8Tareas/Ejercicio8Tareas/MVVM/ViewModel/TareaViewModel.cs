using Ejercicio8Tareas.MVVM.Model;
using Ejercicio8Tareas.MVVM.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8Tareas.MVVM.ViewModel
{
    public class TareaViewModel
    {
        public ObservableCollection<TareaModel> tareaModel { get; set; } = new ObservableCollection<TareaModel>();
        public ObservableCollection<CategoriaModel> categoriaModel { get; set; } = new ObservableCollection<CategoriaModel>();
        public Command AnadirTarea { get; set; }
        public Command AnadirCategoria { get; set; }
        public Command NTarea { get; set; }

        public string NuevoNombre { get; set; }

        public TareaViewModel()
        {
            tareaModel = new ObservableCollection<TareaModel>
            {
                new TareaModel { Nombre = "Actualizar ficheros" },
                new TareaModel { Nombre = "Planear siguiente curso" },
                new TareaModel { Nombre = "ASP.NET en YouTube" },
                new TareaModel { Nombre = "XAML" },
                new TareaModel { Nombre = "JavaScript" }
            };

            categoriaModel = new ObservableCollection<CategoriaModel>
            {
                new CategoriaModel { Nombre = "Curso .NET MAUI" },
                new CategoriaModel { Nombre = "Tutoriales" },
                new CategoriaModel { Nombre = "Compras" }
            };

            AnadirTarea = new Command(AnadirTareaMetodo);
            AnadirCategoria = new Command(AnadirCategoriaMetodo); 
        }

        private void AnadirCategoriaMetodo()
        {
            if (!string.IsNullOrEmpty(NuevoNombre))
            {
                CategoriaModel nuevaCategoria = new CategoriaModel { Nombre = NuevoNombre };
                categoriaModel.Add(nuevaCategoria);
            }
        }

        private void AnadirTareaMetodo()
        {
            if (!string.IsNullOrEmpty(NuevoNombre))
            {
                TareaModel nuevaTarea = new TareaModel { Nombre = NuevoNombre };
                tareaModel.Add(nuevaTarea);

                
                //CategoriaModel categoriaAsignada = categoriaModel.FirstOrDefault();
                //if (categoriaAsignada != null)
                //{
                //    categoriaAsignada.Tareas.Add(nuevaTarea);
                //    ActualizarProgresoCategoria(categoriaAsignada);
                //}
            }
        }

        //public void ActualizarProgresoCategoria(CategoriaModel categoria)
        //{
        //    if (categoria != null)
        //    {
        //        int tareasCompletadas = categoria.Tareas.Count(t => t.Hecho);
        //        int totalTareas = categoria.Tareas.Count;

        //        double progreso = (double)tareasCompletadas / totalTareas;

        //        categoria.Progress = progreso;
        //        categoria.TareasPendientes = totalTareas - tareasCompletadas;
        //    }
        //}

    }
}

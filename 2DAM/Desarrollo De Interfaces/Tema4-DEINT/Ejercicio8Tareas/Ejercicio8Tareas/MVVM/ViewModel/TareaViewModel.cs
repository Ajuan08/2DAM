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
        private static TareaViewModel _instance;

        public ObservableCollection<TareaModel> tareaModel { get; set; } = new ObservableCollection<TareaModel>();
        public ObservableCollection<CategoriaModel> categoriaModel { get; set; } = new ObservableCollection<CategoriaModel>();
        public Command IrAVista2Command { get; set; }
        public Command AnadirTarea { get; set; }
        public Command AnadirCategoria { get; set; }
        public Command NTarea { get; set; }

        public string NuevoNombre { get; set; }

        private TareaViewModel()
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

            IrAVista2Command = new Command(IrAVista2);
            AnadirTarea = new Command(AnadirTareaMetodo);
            AnadirCategoria = new Command(AnadirCategoriaMetodo);

            
        }

        public static TareaViewModel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TareaViewModel();
                }
                return _instance;
            }
        }

        private async void IrAVista2()
        {
            Vista2 v2 = new Vista2();
            await Application.Current.MainPage.Navigation.PushAsync(v2);
        }

        private void AnadirTareaMetodo()
        {
            if (!string.IsNullOrEmpty(NuevoNombre))
            {
                TareaModel nuevaTarea = new TareaModel { Nombre = NuevoNombre };
                tareaModel.Add(nuevaTarea);

                var categoriaConTarea = categoriaModel.FirstOrDefault(c => c.Tareas.Contains(nuevaTarea));
                if (categoriaConTarea != null)
                {
                    ActualizarProgresoCategoria(categoriaConTarea);
                }
            }
        }

        private void ActualizarProgresoCategoria(CategoriaModel categoria)
        {
            categoria.TareasPendientes = categoria.Tareas.Count(t => !t.Hecho);
            categoria.Progress = 1.0 - (double)categoria.TareasPendientes / categoria.Tareas.Count;
            categoria.NTarea = $"{categoria.TareasPendientes} Tareas";
        }

        private void AnadirCategoriaMetodo()
        {
            if (!string.IsNullOrEmpty(NuevoNombre))
            {
                CategoriaModel nuevaCategoria = new CategoriaModel { Nombre = NuevoNombre };
                categoriaModel.Add(nuevaCategoria);
            }
        }

        public void AnadirTareaACategoria(TareaModel nuevaTarea, CategoriaModel categoria)
        {
            tareaModel.Add(nuevaTarea);
            categoria.Tareas.Add(nuevaTarea);
            ActualizarProgresoCategoria(categoria);
        }
    }
}

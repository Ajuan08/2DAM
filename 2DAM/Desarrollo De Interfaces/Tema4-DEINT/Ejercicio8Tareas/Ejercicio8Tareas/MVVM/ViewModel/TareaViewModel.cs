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
        public Command IrAVista2Command { get; set; }
        public Command AnadirTarea { get; set; }

        public string NuevoNombreTarea { get; set; }
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
            IrAVista2Command = new Command(IrAVista2);
            AnadirTarea = new Command(AnadirTareaMetodo);
        }
        private  async void IrAVista2()
        {
            Vista2 v2 = new Vista2();
             await Application.Current.MainPage.Navigation.PushAsync(v2);
        }

        public void AnadirTareaMetodo()
        {
            if (string.IsNullOrEmpty(NuevoNombreTarea))
            {
                TareaModel nuevaTarea = new TareaModel { Nombre = NuevoNombreTarea };
                tareaModel.Add(nuevaTarea);
            }
        }
    }
}

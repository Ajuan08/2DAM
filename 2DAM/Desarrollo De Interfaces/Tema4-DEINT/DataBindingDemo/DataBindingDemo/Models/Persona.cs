using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingDemo.Models
{
    public class Persona : INotifyPropertyChanged
    {
        public string Nombre {
            get { return Nombre; }

            set
            {
                Nombre = value;
                OnPropertyChanged("Nombre");
            }
        
        }
        public int Telefono { get; set; }
        public string Direccion {  get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propName = null )
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs( propName ));
        }
    }
}

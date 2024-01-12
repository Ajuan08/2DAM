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
        private string nombre;
        private int telefono;
        private string direccion;
        public string Nombre
        {
            get { return nombre; }

            set
            {
                nombre = value;
                OnPropertyChanged("Nombre");
            }

        }
        public int Telefono
        {
            get { return telefono; }

            set
            {
                telefono = value;
                OnPropertyChanged("Telefono");
            }

        }

        public string Direccion
        {
            get { return direccion; }

            set
            {
                direccion = value;
                OnPropertyChanged("Direccion");
            }

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5IMC.MVVM.Model
{
    public class IMC : INotifyPropertyChanged
    {
        private int _altura;
        private int _peso;

        public int Altura
        {
            get { return _altura; }
            set
            {
                _altura = value;
                OnPropertyChanged("Altura");
            }
        }

        public int Peso
        {
            get { return _peso; }
            set
            {
                _peso = value;
                OnPropertyChanged("Peso");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}

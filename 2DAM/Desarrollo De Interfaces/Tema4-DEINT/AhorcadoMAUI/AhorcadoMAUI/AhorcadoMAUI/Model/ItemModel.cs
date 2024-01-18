using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoMAUI.Model
{
    class ItemModel : INotifyPropertyChanged
    {
        private string _imagen;
        private string _palabra;
        private string _mensaje;
        private bool _botonesActivos;
        private int _contadorErrores;

        public List<char> Letras { get; set; }
        public string Imagen
        {
            get { return _imagen; }
            set
            {
                _imagen = value;
                OnPropertyChanged("Imagen");
            }
        }

        public string Palabra
        {
            get { return _palabra; }
            set
            {
                _palabra = value;
                OnPropertyChanged("Palabra");
            }
        }

        public string Mensaje
        {
            get { return _mensaje; }
            set
            {
                _mensaje = value;
                OnPropertyChanged("Mensaje");
            }
        }

        public bool BotonesActivos
        {
            get { return _botonesActivos; }
            set
            {
                _botonesActivos = value;
                OnPropertyChanged("BotonesActivos");
            }
        }

        public int ContadorErrores
        {
            get { return _contadorErrores; }
            set
            {
                
                _contadorErrores = value <= 6 ? value : 6;

                OnPropertyChanged("ContadorErrores");
            }
        }

        public ItemModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}

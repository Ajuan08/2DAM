using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAnoPasadoRepaso.MVVM.Model
{
    [AddINotifyPropertyChangedInterface]
    public class Compra
    {
        public double _precioSubtotal = 185.90;

        public int _porcentajeDescuento;
        public double PrecioDescuento { get; set; }

        public double PrecioTotal { get; set; }

        public  DateTime _fechaHoraActual;
        public int PorcentajeDescuento
        {
            get
            {
                return _porcentajeDescuento;
            }
            set
            {
                _porcentajeDescuento = value;
                PrecioDescuento = _precioSubtotal * _porcentajeDescuento / 100;
                PrecioTotal = _precioSubtotal - PrecioDescuento;
            }
        }

        public DateTime FechaHoraActual
        {
            get { return _fechaHoraActual; }
            set
            {
                if (_fechaHoraActual != value)
                {
                    _fechaHoraActual = value;
                }
            }
        }


        public Compra()
        {
            PorcentajeDescuento = 10;
        }

    }
}

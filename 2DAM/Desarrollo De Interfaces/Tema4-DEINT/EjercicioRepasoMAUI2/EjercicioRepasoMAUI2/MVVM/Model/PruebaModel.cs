using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EjercicioRepasoMAUI2.MVVM.Model
{
    [AddINotifyPropertyChangedInterface]
    public class PruebaModel
    {
       public string nombre { get; set; }
        public int medida { get; set; }
        public DateTime fecha { get; set; }
    }
}

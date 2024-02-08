using Practica10ControlGastos.MVVM.Model;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica10ControlGastos.MVVM.ViewModel
{

    public class GastosViewModel
    {
        public Transaccion Transaccion { get; set; }

        public List<Transaccion> Transacciones { get; set; }
        public Usuario usuario { get; set; }

        public Command AnadirTransaccion { get; set; }

        public GastosViewModel()
        {
            Transaccion = new Transaccion();
            AnadirTransaccion = new Command(anadirTrans);

        }

        private void anadirTrans()
        {
            App.TransaccionRepo.SaveItem(Transaccion);
        }


        

    }

}

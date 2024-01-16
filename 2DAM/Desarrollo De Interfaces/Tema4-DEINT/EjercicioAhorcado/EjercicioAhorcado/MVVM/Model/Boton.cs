using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAhorcado.MVVM.Model
{
    public class Boton
    {
        public string palabraSeleccionada;

        public string letra {  get; set; }
        public bool estaActivo { get; set; } = true;

        public Boton(string letra, bool estaActivo) 
        {
            this.letra = letra;
            this.estaActivo = estaActivo;
            
        }
    }
}

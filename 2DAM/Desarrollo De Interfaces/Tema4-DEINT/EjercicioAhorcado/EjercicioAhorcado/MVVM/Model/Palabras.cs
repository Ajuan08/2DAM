using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAhorcado.MVVM.Model
{
    
    public class Palabras
    {
        public List<string> listapalabras { get; set; } = new List<string>();
       
        public Palabras() 
        {
            listapalabras.Add("SILVIA");
            listapalabras.Add("CASA");
            listapalabras.Add("SOL");
            listapalabras.Add("GATO");
            listapalabras.Add("CLASE");
        }

    }
}

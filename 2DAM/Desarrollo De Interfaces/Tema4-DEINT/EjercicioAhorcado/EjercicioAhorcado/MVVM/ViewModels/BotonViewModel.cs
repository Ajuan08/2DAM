using EjercicioAhorcado.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAhorcado.MVVM.ViewModels
{
    public class BotonViewModel
    {
        Boton boton { get; set; }
        public List<string> letras { get; set; }

        public BotonViewModel() 
        {
            Random random = new Random();
            letras = new List<string>();
            letras.Add("A");
            letras.Add("B");
            letras.Add("C");
            letras.Add("D");
            letras.Add("E");
            letras.Add("F");
            letras.Add("G");
            letras.Add("H");
            letras.Add("I");
            letras.Add("J");
            letras.Add("K");
            letras.Add("L");
            letras.Add("M");
            letras.Add("N");
            letras.Add("O");
            letras.Add("P");
            letras.Add("Q");
            letras.Add("R");
            letras.Add("S");
            letras.Add("T");
            letras.Add("U");
            letras.Add("V");
            letras.Add("W");
            letras.Add("X");
            letras.Add("Y");
            letras.Add("Z"); 
        }
    }
}

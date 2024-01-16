using EjercicioAhorcado.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAhorcado.MVVM.Views
{
    public class MainViewModel
    {
        public Palabras Palabras {  get; set; }
        public string Palabraoculta { get; set; }
        public int Intentos { get; set; }
        public int Aciertos { get; set; }
        public int Errores { get; set; }

        public MainViewModel() 
        {
            Palabras = new Palabras();
            Random random = new Random();
            Palabraoculta = Palabras.listapalabras[random.Next(0, Palabras.listapalabras.Count)];
            Intentos = 0;
            Aciertos = 0;
            Errores = 0;
        }
    }
}

using Ejercicio5IMC.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5IMC.MVVM.ViewModel
{
   
    public class IMCViewModel
    {
        public List<IMC> Imc { get; set; } = new List<IMC>();

        public IMCViewModel() 
        {
            Imc.Add(new IMC() { Altura = 180, Peso = 85});
            Imc.Add(new IMC() { Altura = 150, Peso = 90 });
            Imc.Add(new IMC() { Altura = 175, Peso = 60 });
        }
    }
}

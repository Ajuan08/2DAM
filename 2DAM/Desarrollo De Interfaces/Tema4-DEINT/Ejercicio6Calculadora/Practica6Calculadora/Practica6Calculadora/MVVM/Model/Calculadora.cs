using Dangl.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6Calculadora.MVVM.Model
{
    public  class Calculadora
    {
        public static double CalcularFormula(string formula)
        {
            var resultado = Calculator.Calculate(formula);
            if(resultado == null)
            {
                throw new Exception("Se ha producido un error");
            }
            return resultado.Result;
        }
    }
}

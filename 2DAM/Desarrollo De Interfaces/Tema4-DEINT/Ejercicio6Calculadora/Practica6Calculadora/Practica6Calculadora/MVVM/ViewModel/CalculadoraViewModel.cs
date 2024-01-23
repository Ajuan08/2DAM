using PropertyChanged;
using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Practica6Calculadora.MVVM.Model;

namespace Practica6Calculadora.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class CalculadoraViewModel
    {
        public string LabelText { get; set; } = "0";
        public string Resultado { get; set; } = "0";

        public Command<string> CalcularCommand { get; set; }

        public CalculadoraViewModel() 
        {
            CalcularCommand = new Command<string>(AnadirFormula);
        }

        private void AnadirFormula(string valor)
        {
            if(LabelText == "0")
            {
                LabelText = valor;
            }else if(valor == "=") 
            {
                Resultado = Calculadora.CalcularFormula(LabelText).ToString();
                LabelText = Resultado;
            }else if(valor == "AC" || valor == "C")
            {
                LabelText = "0";
            }
            else
            {
                LabelText += valor;
            }
        }
    }
}

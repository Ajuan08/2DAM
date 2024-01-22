using PropertyChanged;
using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Practica6Calculadora.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class CalculadoraViewModel
    {
        public Command ClickCommand { get; }
        public Command IgualCommand { get; }

        private string InputActual;
        private string Operador;
        private double Resultado;

        public string LabelText { get; set; } = "0";

        public CalculadoraViewModel()
        {
            ClickCommand = new Command<string>(OnClick);

            InputActual = "0";
            Operador = string.Empty;
            Resultado = 0;
        }

        public void OnClick(string parameter)
        {
            if (InputActual == "0" || LabelText == "0")
            {
                InputActual = parameter;
            }
            else
            {
                InputActual += parameter;
            }

            LabelText = InputActual;
        }
    }
}

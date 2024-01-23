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

        private string InputActual;
        private string Operador;
        private double Resultado;

        public string LabelText { get; set; } = "0";

        public CalculadoraViewModel()
        {
            ClickCommand = new Command<string>(OnClick);

            InputActual = "0";
            Operador = "+,-,*,/,%";
            Resultado = 0;
        }

        public void OnClick(string parameter)
        {
            if (parameter == "=")
            {
                CalcularResultado();
            }
            else
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
        private void CalcularResultado()
        {
            if (double.TryParse(InputActual, out double inputNumero))
            {
                switch (Operador)
                {
                    case "+":
                        Resultado += inputNumero;
                        break;
                    case "-":
                        Resultado -= inputNumero;
                        break;
                    case "*":
                        Resultado *= inputNumero;
                        break;
                    case "/":
                        Resultado /= inputNumero;
                        break;
                    case "%":
                        Resultado %= inputNumero;
                        break;
                    default:
                        Resultado = inputNumero;
                        break;
                }

                LabelText = Resultado.ToString();
                InputActual = "0";
                Operador = "+,-,*,/,%";
            }
        }
    }
}

using Practica6Calculadora.MVVM.ViewModel;

namespace Practica6Calculadora.MVVM.View;

public partial class Calculadora : ContentPage
{
	public Calculadora()
	{
		InitializeComponent();
        BindingContext = new CalculadoraViewModel();
    }
}
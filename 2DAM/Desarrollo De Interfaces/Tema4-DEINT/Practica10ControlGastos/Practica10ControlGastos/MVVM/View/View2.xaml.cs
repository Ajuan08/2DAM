using Practica10ControlGastos.MVVM.ViewModel;

namespace Practica10ControlGastos.MVVM.View;

public partial class View2 : ContentPage
{
	public View2(GastosViewModel gastosViewModel)
	{
		InitializeComponent();
        BindingContext = gastosViewModel;
    }
}
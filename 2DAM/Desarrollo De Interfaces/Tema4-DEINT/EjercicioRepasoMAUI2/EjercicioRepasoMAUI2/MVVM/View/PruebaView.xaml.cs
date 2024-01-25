using EjercicioRepasoMAUI2.MVVM.ViewModel;

namespace EjercicioRepasoMAUI2.MVVM.View;

public partial class PruebaView : ContentPage
{
	public PruebaView()
	{
		InitializeComponent();
		BindingContext = new PruebaViewModel();
	}
}
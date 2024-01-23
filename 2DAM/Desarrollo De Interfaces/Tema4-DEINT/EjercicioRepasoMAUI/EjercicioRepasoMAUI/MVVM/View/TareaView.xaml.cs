using EjercicioRepasoMAUI.MVVM.ViewModel;

namespace EjercicioRepasoMAUI.MVVM.View;

public partial class TareaView : ContentPage
{
	public TareaView()
	{
		InitializeComponent();
		BindingContext = new TareaViewModel();
	}
}
using ExamenAnoPasadoRepaso.MVVM.ViewModel;

namespace ExamenAnoPasadoRepaso.MVVM.View;

public partial class CompraView : ContentPage
{
	public CompraView()
	{
		InitializeComponent();
		BindingContext = new CompraViewModel();
	}
}
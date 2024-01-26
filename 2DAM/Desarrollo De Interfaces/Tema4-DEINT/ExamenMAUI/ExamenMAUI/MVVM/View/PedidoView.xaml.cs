using ExamenMAUI.MVVM.ViewModel;

namespace ExamenMAUI.MVVM.View;

public partial class PedidoView : ContentPage
{
	public PedidoView()
	{
		InitializeComponent();
		BindingContext = new PedidoViewModel();
	}
}
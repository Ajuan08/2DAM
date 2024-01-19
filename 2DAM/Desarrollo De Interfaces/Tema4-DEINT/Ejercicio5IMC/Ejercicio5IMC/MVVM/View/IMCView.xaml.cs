using Ejercicio5IMC.MVVM.ViewModel;

namespace Ejercicio5IMC.MVVM.View;

public partial class IMCView : ContentPage
{
	public IMCView()
	{
		InitializeComponent();
		BindingContext = new IMCViewModel();
	}
}
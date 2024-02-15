using UltRepaso2Silvia.MVVM.ViewModel;

namespace UltRepaso2Silvia.MVVM.View;

public partial class Vista2 : ContentPage
{
	public Vista2(TareaViewModel tareaViewModel)
	{
		InitializeComponent();
		BindingContext = tareaViewModel;
	}
}
using Ejercicio8Tareas.MVVM.ViewModel;

namespace Ejercicio8Tareas.MVVM.View;

public partial class Vista1 : ContentPage
{
	public Vista1()
	{
		InitializeComponent();
		BindingContext = new TareaViewModel();
		
	}
}
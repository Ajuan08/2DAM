using Ejercicio8Tareas.MVVM.ViewModel;

namespace Ejercicio8Tareas.MVVM.View;

public partial class Vista2 : ContentPage
{
	public Vista2(TareaViewModel tareaViewModel)
	{
		InitializeComponent();
		BindingContext = tareaViewModel;
	}
}
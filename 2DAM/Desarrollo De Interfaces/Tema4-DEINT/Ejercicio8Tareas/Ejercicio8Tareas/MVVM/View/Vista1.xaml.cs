using Ejercicio8Tareas.MVVM.ViewModel;

namespace Ejercicio8Tareas.MVVM.View;

public partial class Vista1 : ContentPage
{
	TareaViewModel tareaViewModel;

    public Vista1()
	{
		InitializeComponent();
		tareaViewModel = new TareaViewModel();
		BindingContext = tareaViewModel;
		
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		Vista2 v2 = new Vista2(tareaViewModel);
		await Application.Current.MainPage.Navigation.PushAsync(v2);
    }
}
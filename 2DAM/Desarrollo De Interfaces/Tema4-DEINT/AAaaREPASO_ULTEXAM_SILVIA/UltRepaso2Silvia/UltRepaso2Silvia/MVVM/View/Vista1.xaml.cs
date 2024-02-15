using UltRepaso2Silvia.MVVM.Model;
using UltRepaso2Silvia.MVVM.ViewModel;

namespace UltRepaso2Silvia.MVVM.View;

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
		Vista2 vista2 = new Vista2(tareaViewModel);
        await App.Current.MainPage.Navigation.PushAsync(vista2);

        Button button = (Button)sender;
        Tarea selectedTask = (Tarea)button.CommandParameter;
        tareaViewModel.TareaCambiada = selectedTask;
    }
}
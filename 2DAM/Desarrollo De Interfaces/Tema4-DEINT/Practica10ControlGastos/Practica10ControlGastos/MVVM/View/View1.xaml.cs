using Practica10ControlGastos.MVVM.ViewModel;

namespace Practica10ControlGastos.MVVM.View;

public partial class View1 : ContentPage
{
    GastosViewModel gastosViewModel;
    public View1()
	{
		InitializeComponent();
		gastosViewModel = new GastosViewModel();
		BindingContext = gastosViewModel;
	}

	protected override void OnAppearing()
	{
        this.ForceLayout();
    }

	private async void Button_Clicked(object sender, EventArgs e)
	{
        View2 v2 = new View2(gastosViewModel);
        await Application.Current.MainPage.Navigation.PushAsync(v2);
    }
}
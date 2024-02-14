using UltimoRepasoMAUI.MVVM.ViewModel;

namespace UltimoRepasoMAUI.MVVM.View;

public partial class TareaView : ContentPage
{
	TareaViewModel viewModel;
	public TareaView()
	{
		InitializeComponent();
		viewModel = new TareaViewModel();
		BindingContext = viewModel;
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		EditarTareaView editarTareaView = new EditarTareaView(viewModel);
        await Navigation.PushAsync(editarTareaView);
    }
}
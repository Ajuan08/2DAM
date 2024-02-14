using UltimoRepasoMAUI.MVVM.ViewModel;

namespace UltimoRepasoMAUI.MVVM.View;

public partial class EditarTareaView : ContentPage
{
    private TareaViewModel viewModel;

    public EditarTareaView(TareaViewModel tareaViewModel)
	{
		InitializeComponent();
        BindingContext = tareaViewModel;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
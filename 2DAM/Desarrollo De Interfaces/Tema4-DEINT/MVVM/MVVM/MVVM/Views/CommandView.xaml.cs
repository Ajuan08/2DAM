using MVVM.MVVM.ViewModels;

namespace MVVM.MVVM.Views;

public partial class CommandView : ContentPage
{
	public CommandView()
	{
		InitializeComponent();
        BindingContext = new CommandViewModel();
    }
}
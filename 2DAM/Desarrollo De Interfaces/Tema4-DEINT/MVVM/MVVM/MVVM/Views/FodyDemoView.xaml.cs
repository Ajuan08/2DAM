using MVVM.MVVM.ViewModels;

namespace MVVM.MVVM.Views;

public partial class FodyDemoView : ContentPage
{
	public FodyDemoView()
	{
		InitializeComponent();
        BindingContext = new FodyDemoViewModel();
    }
}
using MauiAppDemo.Controller;
using MauiAppDemo.Layout_Diseno;

namespace MauiAppDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedPageDemo();
        }
    }
}

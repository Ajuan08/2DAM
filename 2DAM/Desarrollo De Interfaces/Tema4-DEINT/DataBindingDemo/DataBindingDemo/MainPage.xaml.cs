using DataBindingDemo.Models;

namespace DataBindingDemo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Persona persona = new Persona()
            {
                Nombre = "Antonio Juan",
                Direccion = "Calle Larga",
                Telefono = 620987654
            };
            BindingContext = persona;
        }

        
    }

}

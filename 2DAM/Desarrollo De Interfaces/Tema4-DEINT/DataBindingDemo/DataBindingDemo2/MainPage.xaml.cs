
using DataBindingDemo.Models;

namespace DataBindingDemo2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private Persona persona;

        public MainPage()
        {
            InitializeComponent();

            persona = new Persona()
            {
                Nombre = "Antonio Juan",
                Direccion = "Calle Larga",
                Telefono = 620987654
            };
            BindingContext = persona;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            persona.Nombre = "Antonio Juan";
            persona.Direccion = "Calle Larga";
            persona.Telefono = 620987654;

        }
    }

}

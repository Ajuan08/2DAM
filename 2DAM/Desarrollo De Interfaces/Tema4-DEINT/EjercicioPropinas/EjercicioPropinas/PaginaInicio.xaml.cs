namespace EjercicioPropinas
{
    public partial class PaginaInicio : ContentPage
    {
        private double porcentajePropina = 0.0;
        private double sliderValue = 0.0;

        public PaginaInicio()
        {
            InitializeComponent();
        }

        private void BotonSumar_Clicked(object sender, EventArgs e)
        {
            int personas = int.Parse(entradaCuentas.Text);
            entradaCuentas.Text = (personas + 1).ToString();

            CalcularTotal();
        }

        private void BotonRestar_Clicked(object sender, EventArgs e)
        {
            int personas = int.Parse(entradaCuentas.Text);
            if (personas > 1)
            {
                entradaCuentas.Text = (personas - 1).ToString();
                CalcularTotal();
            }
        }

        private void BotonPropina_Clicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                porcentajePropina = double.Parse(button.Text.Trim('%'));
                CalcularPropina();
            }
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            sliderValue = slider.Value;
            CalcularPropina();
            labelPorcentaje.Text = $"Propina: {sliderValue} %";
        }

        private void CalcularPropina()
        {
            double subtotal = double.Parse(entryCuenta.Text);
            double propina = subtotal * (porcentajePropina / 100);
            propinaLabel.Text = $"{propina.ToString("0.00")}€";

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            int personas = int.Parse(entradaCuentas.Text);
            double subtotal = double.Parse(entryCuenta.Text) / personas;

            double propina = double.Parse(propinaLabel.Text.Trim('€'));
            double total = subtotal + propina;

            totalPorPersonasLabel.Text = $"{total.ToString("0.00")}€";
            subtotalLabel.Text = $"{subtotal.ToString("0.00")}€";
        }
    }
}

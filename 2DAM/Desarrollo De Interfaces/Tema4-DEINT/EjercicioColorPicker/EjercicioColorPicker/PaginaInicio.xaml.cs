namespace EjercicioColorPicker;

public partial class PaginaInicio : ContentPage
{
	public PaginaInicio()
	{
		InitializeComponent();

	}

	private void slider_ValueChanged(object sender, EventArgs e)
	{
		int valorSliderRojo = (int)sliderRed.Value;
        int valorSliderVerde = (int)sliderGreen.Value;
        int valorSliderAzul = (int)sliderBlue.Value;
		

		BackgroundColor = Color.FromRgb(valorSliderRojo, valorSliderVerde, valorSliderAzul);
        hexName.Text = $"Hex Value: #{valorSliderRojo:x2}{valorSliderVerde:x2}{valorSliderAzul:x2}";
    }

    private void buttonRandom_Clicked(object sender, EventArgs e)
    {
        Random random = new Random();
		int valorRojo = random.Next(256);
        int valorVerde = random.Next(256);
        int valorAzul = random.Next(256);
		

        BackgroundColor = Color.FromRgb(valorRojo, valorVerde, valorAzul);
		sliderRed.Value = valorRojo;
		sliderBlue.Value = valorAzul;
		sliderGreen.Value = valorVerde;

		hexName.Text = $"Hex Value: #{valorRojo:x2}{valorVerde:x2}{valorAzul:x2}";
    }

}

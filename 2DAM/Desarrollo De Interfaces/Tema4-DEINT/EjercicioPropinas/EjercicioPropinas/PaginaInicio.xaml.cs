namespace EjercicioPropinas;

public partial class PaginaInicio : ContentPage
{
	public PaginaInicio()
	{
		InitializeComponent();
	}
    private void BotonRestar_Clicked(object sender, EventArgs e)
    {
        int valorActual;
        if (int.TryParse(entradaCuentas.Text, out valorActual))
        {

            entradaCuentas.Text = (valorActual - 1).ToString();
        }
    }

    private void BotonSumar_Clicked(object sender, EventArgs e)
    {
        int valorActual;
        if (int.TryParse(entradaCuentas.Text, out valorActual))
        {

            entradaCuentas.Text = (valorActual + 1).ToString();
        }
    }
}
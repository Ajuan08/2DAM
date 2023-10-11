namespace Ejemplo02_Problema1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioGerente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            string tipoEmpleado = "";
            double txt1, descuento, salarioTotal;
            txt1 = Convert.ToDouble(textSalario.Text);
            salarioTotal = 0;
            descuento = 0;
            
            if (radioGerente.Checked == true)
            {
                descuento = 0.20;
                tipoEmpleado = "Gerente";
            }
            else if (radioSubGerente.Checked == true)
            {
                descuento = 0.15;
                tipoEmpleado = "SubGerente";
            }
            else if (radioSecretaria.Checked == true)
            {
                descuento = 0.05;
                tipoEmpleado = "Secretaria";
            }

            double numero = txt1 * descuento;

            salarioTotal = txt1 - numero;

            MessageBox.Show("Nombre: " + textNombre.Text + " \nTipo de Empleado: " + tipoEmpleado + "\nSalario antes de descuentos: €" + textSalario.Text + "\nDescuento: €" + descuento + "\nSalario líquido: €" + salarioTotal);
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
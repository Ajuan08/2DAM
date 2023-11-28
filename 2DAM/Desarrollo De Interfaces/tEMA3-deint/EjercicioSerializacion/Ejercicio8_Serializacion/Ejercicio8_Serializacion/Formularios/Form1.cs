using Ejercicio8_Serializacion.Formularios;

namespace Ejercicio8_Serializacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAgregarCliente_Click(object sender, EventArgs e)
        {
            new AgregarCliente().ShowDialog();
        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
            new EliminarCliente().ShowDialog();
        }

        private void buttonModificarCliente_Click(object sender, EventArgs e)
        {
            new ModificarCliente().ShowDialog();
        }

        private void buttonMostrarCliente_Click(object sender, EventArgs e)
        {
            new MostrarCliente().ShowDialog();
        }
    }
}

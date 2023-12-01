using Ejercicio2_Exam_DEINT.Formularios;

namespace Ejercicio2_Exam_DEINT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AgregarVehiculo().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new VisualizarInventario().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ModificarEstado().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AgregarMantenimiento().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new VisualizarMantenimientos().Show();
        }
    }
}

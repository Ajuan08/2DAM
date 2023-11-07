using Ejercicio4_T3_Acceso_BBDD.frm;

namespace Ejercicio4_T3_Acceso_BBDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCiclo frmCiclo = new frmCiclo();
            frmCiclo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEstudiante frmEstudiante = new frmEstudiante();
            frmEstudiante.ShowDialog();
        }
    }
}
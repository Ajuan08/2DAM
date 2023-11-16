namespace Ejercicio8_Bloc_de_notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                DialogResult resultado = MessageBox.Show("¿Desea guardar el contenido?", "Guardar", MessageBoxButtons.YesNo);


                if (resultado == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    string ficheroGuardado = saveFileDialog.FileName;

                }
                else
                {
                    richTextBox1.Text = "";
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                DialogResult resultado = MessageBox.Show("¿Desea guardar el contenido?", "Guardar", MessageBoxButtons.YesNo);


                if (resultado == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    string ficheroGuardado = saveFileDialog.FileName;

                }
                else
                {
                    richTextBox1.Text = "";
                }
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt; *.rtf);
        }
    }
}

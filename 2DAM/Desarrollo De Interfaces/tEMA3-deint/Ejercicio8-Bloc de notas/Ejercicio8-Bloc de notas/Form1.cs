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

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string ficheroGuardado = saveFileDialog.FileName;

                        File.WriteAllText(ficheroGuardado, richTextBox1.Text);

                        richTextBox1.Text = "";
                    }
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

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string ficheroGuardado = saveFileDialog.FileName;

                        File.WriteAllText(ficheroGuardado, richTextBox1.Text);

                        richTextBox1.Text = "";
                    }
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
            openFileDialog.Filter = "Archivos de texto (*.txt; *.rtf)|*.txt;*.rtf";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string ficheroGuardado = saveFileDialog.FileName;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.LoadFile(openFileDialog.FileName);
                ficheroGuardado = openFileDialog.FileName;

            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt; *.rtf)|*.txt;*.rtf";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string ficheroGuardado = saveFileDialog.FileName;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.LoadFile(openFileDialog.FileName);
                ficheroGuardado = openFileDialog.FileName;

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            bool primeraGuardado;

            if(primeraGuardado = true)
            {
                SaveFileDialog guardarDialogo = new SaveFileDialog();

                if(guardarDialogo.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(guardarDialogo.FileName);
                    string guardarArchivo = guardarDialogo.FileName;
                    primeraGuardado = false;

                }
            }
            else
            {
                richTextBox1.SaveFile();
            }

            
        }
    }
}

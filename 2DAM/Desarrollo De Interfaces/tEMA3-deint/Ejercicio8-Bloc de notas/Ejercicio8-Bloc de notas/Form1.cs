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

                richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
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

                richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                ficheroGuardado = openFileDialog.FileName;

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            bool primeraGuardado;




            if (primeraGuardado = true)
            {
                SaveFileDialog guardarDialogo = new SaveFileDialog();
                guardarDialogo.Filter = "Archivos de texto (*.txt; *.rtf)|*.txt;*.rtf";
                string nombreFichero = guardarDialogo.FileName;
                if (guardarDialogo.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(nombreFichero);

                }
            }
            else
            {

            }


        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
            else
            {
                richTextBox1.SelectAll();
                richTextBox1.Copy();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
            else
            {
                richTextBox1.SelectAll();
                richTextBox1.Copy();
            }
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

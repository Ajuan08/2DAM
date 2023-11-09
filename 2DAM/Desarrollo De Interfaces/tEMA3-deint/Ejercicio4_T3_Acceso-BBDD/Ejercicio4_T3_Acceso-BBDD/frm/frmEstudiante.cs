using Ejercicio4_T3_Acceso_BBDD.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio4_T3_Acceso_BBDD.frm
{
    public partial class frmEstudiante : Form
    {
        EstudianteDLL estudianteDLL;
        private byte[] imagenByte;
        public frmEstudiante()
        {
            estudianteDLL = new EstudianteDLL();
            InitializeComponent();
            dataGridViewEstudiante.DataSource = estudianteDLL.MostrarEstudiante().Tables[0];
        }

        private void buttonExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Selecciona una imagen";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                imagen.Image = Image.FromStream(selectorImagen.OpenFile());
                MemoryStream memoryStream = new MemoryStream();
                imagen.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                imagenByte = memoryStream.ToArray();
            }

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            EstudianteDLL estudianteDLL = new EstudianteDLL();
            estudianteDLL.Agregar(textBoxNombre.Text, textBox1Apellido.Text, textBox2Apellido.Text, textBoxCorreo.Text, imagenByte);

            dataGridViewEstudiante.DataSource = estudianteDLL.MostrarEstudiante().Tables[0];
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            EstudianteDLL estudianteDLL = new EstudianteDLL();
            estudianteDLL.Modificar(textBoxNombre.Text, textBox1Apellido.Text, textBox2Apellido.Text, textBoxCorreo.Text, imagenByte, int.Parse(textBoxClave.Text));

            dataGridViewEstudiante.DataSource = estudianteDLL.MostrarEstudiante().Tables[0];
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            EstudianteDLL estudianteDLL = new EstudianteDLL();
            estudianteDLL.Borrar(int.Parse(textBoxClave.Text));

            dataGridViewEstudiante.DataSource = estudianteDLL.MostrarEstudiante().Tables[0];
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imagen_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {

        }
    }
}

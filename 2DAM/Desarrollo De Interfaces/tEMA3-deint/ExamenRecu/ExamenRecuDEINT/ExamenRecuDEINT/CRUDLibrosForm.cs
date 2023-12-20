using ExamenRecuDEINT.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenRecuDEINT
{
    public partial class CRUDLibrosForm : Form
    {
        public CRUDLibrosForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = LibroDLL.GetInstance().mostrarLibros().Tables[0];

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            LibroDLL.GetInstance().agregarLibro(int.Parse(textBoxISBN.Text), textBoxTitulo.Text, textBoxAutor.Text, textBoxGenero.Text, int.Parse(textBoxAno_Publi.Text), int.Parse(textBoxEditorial.Text));
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            LibroDLL.GetInstance().modificarLibros(int.Parse(textBoxISBN.Text), textBoxTitulo.Text, textBoxAutor.Text, textBoxGenero.Text, int.Parse(textBoxAno_Publi.Text), int.Parse(textBoxEditorial.Text));
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            LibroDLL.GetInstance().eliminarLibro(int.Parse(textBoxEditorial.Text));
        }

        private void textBoxISBN_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBoxISBN.Text, @"^[0-9]{10}$"))
            {
                MessageBox.Show("Se ha producido un error");
            }
        }

        private void textBoxEditorial_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBoxEditorial.Text, @"^[0-9]{2}$"))
            {
                MessageBox.Show("Se ha producido un error");
            }
        }

        private void textBoxAno_Publi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAno_Publi_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBoxAno_Publi.Text, @"^[0-9]{4}$"))
            {
                MessageBox.Show("Se ha producido un error");
            }
        }

        private void buttonListadoEditorial_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = LibroDLL.GetInstance().listadoPorEditorial().Tables[0];
        }

        private void buttonBusquedaGenero_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = LibroDLL.GetInstance().busquedaLibros().Tables[0];
        }

        private void textBoxISBN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

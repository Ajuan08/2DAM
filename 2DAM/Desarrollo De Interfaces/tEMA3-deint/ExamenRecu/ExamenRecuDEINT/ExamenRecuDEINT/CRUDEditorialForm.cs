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
    public partial class CRUDEditorialForm : Form
    {
        public CRUDEditorialForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = EditorialesDLL.GetInstance().mostrarEditoriales().Tables[0];
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            EditorialesDLL.GetInstance().agregarEditorial(int.Parse(textBoxCodigo.Text), textBoxNombre.Text, textBoxDireccion.Text);
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            EditorialesDLL.GetInstance().modificarEditorial(int.Parse(textBoxCodigo.Text), textBoxNombre.Text, textBoxDireccion.Text);
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            EditorialesDLL.GetInstance().eliminarEditorial(int.Parse(textBoxCodigo.Text));
        }

        private void textBoxCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBoxCodigo.Text, @"^\d$"))
            {
                Console.WriteLine("Se ha producido un error");
            }
        }
    }
}

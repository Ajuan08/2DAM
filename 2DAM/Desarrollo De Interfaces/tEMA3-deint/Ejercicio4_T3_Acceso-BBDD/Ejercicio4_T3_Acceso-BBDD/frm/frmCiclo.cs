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
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicio4_T3_Acceso_BBDD.frm
{
    public partial class frmCiclo : Form
    {
        CicloDLL ciclodll;
        public frmCiclo()
        {
            ciclodll = new CicloDLL();
            InitializeComponent();
            dataGridViewCiclo.DataSource = ciclodll.MostrarCiclos().Tables[0];
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string nombreCiclo = textBoxNombreCiclo.Text;
            if (string.IsNullOrEmpty(nombreCiclo))
            {
                MessageBox.Show("Por favor, ingresa un nombre de ciclo antes de agregar");
                return;
            }

            CicloDLL cicloDLL = new CicloDLL();
            cicloDLL.Agregar(textBoxNombreCiclo.Text);

            dataGridViewCiclo.DataSource = cicloDLL.MostrarCiclos().Tables[0];

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            CicloDLL cicloDLL = new CicloDLL();
            cicloDLL.Modificar(textBoxNombreCiclo.Text ,int.Parse(textBoxID.Text));

            dataGridViewCiclo.DataSource = cicloDLL.MostrarCiclos().Tables[0];


        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            CicloDLL cicloDLL = new CicloDLL();
            cicloDLL.Borrar(int.Parse(textBoxID.Text));

            dataGridViewCiclo.DataSource = cicloDLL.MostrarCiclos().Tables[0];
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using EjercicioJardineria.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioJardineria.Formularios
{
    public partial class ConsultarPrecioMasCaroYBarato : Form
    {
        public ConsultarPrecioMasCaroYBarato()
        {
            InitializeComponent();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductoDLL.ConsultarPrecioMasBaratoYMasCaro().Tables[0];
        }
    }
}

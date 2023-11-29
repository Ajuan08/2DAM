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
    public partial class ConsultarClientesQueNoPagan : Form
    {
        public ConsultarClientesQueNoPagan()
        {
            InitializeComponent();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            DataSet clientesNoPagan = ProductoDLL.ConsultarClientesQueNoPagan();

            if (clientesNoPagan.Tables.Count > 0)
            {
                dataGridView1.DataSource = clientesNoPagan.Tables[0];
            }
        }
    }
}

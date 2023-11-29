using EjercicioJardineria.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioJardineria
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void añadirProductos_Click(object sender, EventArgs e)
        {
            new añadirProducto().ShowDialog();
        }

        private void eliminarGama_Click(object sender, EventArgs e)
        {
            new EliminarGama().ShowDialog();
        }

        private void consultarPedidosEntregados_Click(object sender, EventArgs e)
        {
            new ConsultarPedidosEntregados().ShowDialog();
        }

        private void consultarClientesNoPagan_Click(object sender, EventArgs e)
        {
            new ConsultarClientesQueNoPagan().ShowDialog();
        }

        private void consultarPrecioMasCaroYBarato_Click(object sender, EventArgs e)
        {
            new ConsultarPrecioMasCaroYBarato().ShowDialog();
        }
    }
}

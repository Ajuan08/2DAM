using EjercicioJardineria.DLL;
using Jardineria.Conexion;
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
    public partial class ConsultarPedidosEntregados : Form
    {
        Conexion conexion;
        public ConsultarPedidosEntregados()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int mes = comboBoxMes.SelectedIndex;

            if (mes <= 1)
            {
                DataSet pedidos = ProductoDLL.ConsultarPedidosEntregados();

                dataGridView1.DataSource = pedidos.Tables[0];
            }
        }

        private void ConsultarPedidosEntregados_Load(object sender, EventArgs e)
        {

            DataSet dataSet = conexion.EjecutarSentencia("select fecha_entrega from pedido");
            DataTable datos = dataSet.Tables[0];
            foreach (DataRow item in datos.Rows)
            {
                comboBoxMes.Items.Add(item[0]);
            }
        }
    }
}

using EjercicioJardineria.DLL;
using Jardineria.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjercicioJardineria.Formularios
{
    public partial class EliminarGama : Form
    {
        public string Gama { get; set; }
        Conexion conexion;
        public EliminarGama()
        {
            InitializeComponent();
            conexion = new Conexion();
        }
        private void comboBoxGama_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gama = comboBoxGama.Text;
        }
        private void buttonEliminarGama_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea Eliminar el contenido?", "Eliminar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
               
                    ProductoDLL productoDLL = new ProductoDLL();
                    productoDLL.eliminarGama(Gama);
                    MessageBox.Show("Se ha eliminado correctamente");
                    EliminarGama_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Se ha producido un error al eliminar");
            }
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EliminarGama_Load(object sender, EventArgs e)
        {
            DataSet dataSet = conexion.EjecutarSentencia("select gama from gama_producto");
            DataTable datos = dataSet.Tables[0];
            foreach (DataRow item in datos.Rows)
            {
                comboBoxGama.Items.Add(item[0]);
            }
            dataGridView1.DataSource = datos;
        }
    }
}

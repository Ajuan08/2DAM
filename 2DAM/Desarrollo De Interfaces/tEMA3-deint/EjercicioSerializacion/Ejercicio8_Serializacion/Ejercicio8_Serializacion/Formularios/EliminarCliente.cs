using Ejercicio8_Serializacion.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8_Serializacion.Formularios
{
    public partial class EliminarCliente : Form
    {
        private Banco Objetos { get; set; }
        public EliminarCliente()
        {
            InitializeComponent();
            Objetos = Banco.getInstance();
            List<string> dnisClientes = Objetos.ObtenerDnis();

            comboBoxClientes.Items.AddRange(dnisClientes.ToArray());
        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClientes.SelectedItem == null)
            {
                MessageBox.Show("El DNI es incorrecto");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Objetos.EliminarCliente(comboBoxClientes.SelectedItem as string);
                MessageBox.Show("Cliente eliminado correctamente");
                Close();
            }
            catch
            {
                MessageBox.Show("Los datos son inválidos");
            }
        }
    }
}

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
    
    public partial class MostrarCliente : Form
    {
        private Banco Objeto { get; set; }
        public MostrarCliente()
        {
            InitializeComponent();
            Objeto = Banco.getInstance();
            List<string> dnis = Objeto.ObtenerDnis();
            comboBoxClientes.Items.AddRange(dnis.ToArray());
        }

        private void buttonSeleccionarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            if(comboBoxClientes.SelectedItem != null) 
            {
                cliente = Objeto.ObtenerClientes(comboBoxClientes.SelectedItem as string);

                textBoxNombre.Text = cliente.Nombre;
                textBoxDireccion.Text = cliente.Direccion;
                textBoxEdad.Text = cliente.Edad.ToString();
                textBoxTelefono.Text = cliente.Telefono;
                textBoxNumCuenta.Text = cliente.NumCuenta;

            }
        }
    }
}

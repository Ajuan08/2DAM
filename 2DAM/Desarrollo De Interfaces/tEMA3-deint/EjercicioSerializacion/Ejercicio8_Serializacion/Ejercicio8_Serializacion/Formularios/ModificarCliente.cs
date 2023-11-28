using Ejercicio8_Serializacion.Clases;
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

namespace Ejercicio8_Serializacion.Formularios
{
    public partial class ModificarCliente : Form
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string NumCuenta { get; set; }

        private Banco Objeto { get; set; }
        public ModificarCliente()
        {
            InitializeComponent();
            Objeto = Banco.getInstance();
            List<string> dnisClientes = Objeto.ObtenerDnis();

            comboBoxClientes.Items.AddRange(dnisClientes.ToArray());
        }

        private void buttonSeleccionarCliente_Click(object sender, EventArgs e)
        {
            if (comboBoxClientes.SelectedItem != null)
            {
                Cliente cliente = Objeto.ObtenerClientes(comboBoxClientes.SelectedItem as string);

                if (cliente != null)
                {
                    textBoxNombre.Text = cliente.Nombre;
                    textBoxDireccion.Text = cliente.Direccion;
                    textBoxEdad.Text = cliente.Edad.ToString();
                    textBoxTelefono.Text = cliente.Telefono;
                    textBoxNumCuenta.Text = cliente.NumCuenta;
                }
                else
                {
                    MessageBox.Show("Error al obtener la información del cliente.");
                }
            }
        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClientes.SelectedItem == null)
            {
                MessageBox.Show("Error en el DNI");
            }
            else
            {
                Dni = comboBoxClientes.SelectedItem as string;
            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNombre.Text))
            {
                MessageBox.Show("El nombre es Incorrecto");
            }
            else
            {
                Nombre = textBoxNombre.Text;
            }
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDireccion.Text))
            {
                MessageBox.Show("La direccion es Incorrecta");
            }
            else
            {
                Direccion = textBoxDireccion.Text;
            }
        }

        private void textBoxEdad_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(textBoxEdad.Text, out int edad))
            {
                MessageBox.Show("La Edad es Incorrecta");
            }
            else
            {
                Edad = edad;
            }
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBoxTelefono.Text, @"^\d{9}$"))
            {
                MessageBox.Show("El telefono es Incorrecto, debes introducir 9 numeros");
            }
            else
            {
                Telefono = textBoxTelefono.Text;
            }
        }

        private void textBoxNumCuenta_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNumCuenta.Text))
            {
                MessageBox.Show("El numero de cuenta es incorrecto");
            }
            else
            {
                NumCuenta = textBoxNumCuenta.Text;
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Objeto.ModificarCliente(Dni, Nombre, Direccion, Edad, Telefono, NumCuenta);
                MessageBox.Show("El cliente se ha modificado correctamente");
                Close();
            }
            catch
            {
                MessageBox.Show("Los datos son incorrectos");
            }
        }
    }
}

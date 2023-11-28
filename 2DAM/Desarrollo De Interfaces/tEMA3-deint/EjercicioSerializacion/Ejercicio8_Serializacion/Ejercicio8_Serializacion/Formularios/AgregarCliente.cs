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
    public partial class AgregarCliente : Form
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string NumCuenta { get; set; }

        private Banco Objetos { get; set; }
        public AgregarCliente()
        {
            InitializeComponent();

            Objetos = Banco.getInstance();
        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxDNI.Text, @"^[0-9]{8}[A-Z]$"))
            {
                Dni = textBoxDNI.Text;
            }
            else
            {
                Console.WriteLine("El DNI introducido no es correcto");
            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNombre.Text))
            {
                MessageBox.Show("Introduce un nombre");
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
                MessageBox.Show("Introduce una direccion!");
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
                MessageBox.Show("Introduce una Edad!");
            }
            else
            {
                Edad = edad;
            }
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxTelefono.Text, @"^[0-9]{9}"))
            {
                Telefono = textBoxTelefono.Text;
                
            }
            else
            {
                Console.WriteLine("Introduce un telefono válido");
            }
        }

        private void textBoxNumCuenta_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNumCuenta.Text))
            {
                MessageBox.Show("Introduce un numero de cuenta");
            }
            else
            {
                NumCuenta = textBoxNumCuenta.Text;
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Objetos.AgregarCliente(Dni, Nombre, Direccion, Edad, Telefono, NumCuenta);

                MessageBox.Show("Cliente añadido correctamente");
                Close();
            }
            catch
            {
                MessageBox.Show("Error, Los Daton son Incorrectos");
            }
            
        }
    }
}

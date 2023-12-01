using Ejercicio2_Exam_DEINT.Conexionn;
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

namespace Ejercicio2_Exam_DEINT.Formularios
{
    public partial class ModificarEstado : Form
    {
        public int IdenNum { get; set; }

        public string Matricula { get; set; }

        public string Modelo { get; set; }

        public string Marca { get; set; }
        public int AñoFabricacion { get; set; }

        public string Estado { get; set; }

        Conexion conexion;
        public ModificarEstado()
        {
            InitializeComponent();
            conexion = new Conexion();
        }



        private void textBoxMatricula_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(textBoxMatricula.Text, @"^[0-9]{4}[A-Z]{3}$"))
            {
                MessageBox.Show("Se ha producido un error al introducir los datos");
            }
            else
            {
                Matricula = textBoxMatricula.Text;
            }
        }

        private void textBoxModelo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Modelo = textBoxModelo.Text;
            }
            catch
            {
                MessageBox.Show("Se ha producido un error al insertar el Modelo");
            }
            
        }

        private void textBoxMarca_TextChanged(object sender, EventArgs e)
        {
            Marca = textBoxMarca.Text;
        }

        private void textBoxAñoFab_TextChanged(object sender, EventArgs e)
        {
            AñoFabricacion = int.Parse(textBoxAñoFab.Text);
        }

        private void textBoxEstado_TextChanged(object sender, EventArgs e)
        {
            Estado = textBoxEstado.Text;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMatricula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

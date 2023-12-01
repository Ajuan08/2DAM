using Ejercicio2_Exam_DEINT.DLL;
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
using Ejercicio2_Exam_DEINT.Conexionn;

namespace Ejercicio2_Exam_DEINT.Formularios
{

    public partial class AgregarVehiculo : Form
    {
        public int IdenNum { get; set; }

        public string Matricula { get; set; }

        public string Modelo { get; set; }

        public string Marca { get; set; }
        public int AñoFabricacion { get; set; }

        public string Estado { get; set; }
        Conexion conexion;

        public AgregarVehiculo()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void textBoxIdent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                IdenNum = int.Parse(textBoxIdent.Text);
            } catch 
            {
                MessageBox.Show("Error al introducir el código");
            }
           
        }

        private void textBoxMatricula_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(textBoxMatricula.Text, @"^[A-Z]{4}[0-9]{3}$"))
            {
                MessageBox.Show("Se ha introducido incorrectamente la matricula");
            }
            else
            {
                Matricula = textBoxMatricula.Text;
            }
        }

        private void textBoxModelo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxModelo.Text))
            {
                MessageBox.Show("Se tiene que introducir los datos");
            }
            else
            {
                Modelo = textBoxModelo.Text;
            }
           
        }

        private void textBoxMarca_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxModelo.Text))
            {
                MessageBox.Show("Se tiene que introducir la marca");
            }
            else
            {
                Marca = textBoxMarca.Text;
            }
        }

        private void textBoxAñoFab_TextChanged(object sender, EventArgs e)
        {
            AñoFabricacion = int.Parse(textBoxAñoFab.Text);
        }

        private void textBoxEstado_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxModelo.Text))
            {
                MessageBox.Show("Se tiene que introducir el estado");
            }
            else
            {
                Estado = textBoxEstado.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VehiculoDLL vehiculoDLL = new VehiculoDLL();
                vehiculoDLL.añadirVehiculo(IdenNum, Matricula, Modelo, Marca, AñoFabricacion, Estado);
                MessageBox.Show("Se ha añadido correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void textBoxMatricula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

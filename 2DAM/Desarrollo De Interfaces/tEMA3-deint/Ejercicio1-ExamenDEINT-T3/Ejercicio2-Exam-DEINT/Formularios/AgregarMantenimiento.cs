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
    public partial class AgregarMantenimiento : Form
    {
        public int IdentNum { get; set; }
        public int CodigoDesc { get; set; }
        public int CodigoVehiculo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Descripcion { get; set; }

        public AgregarMantenimiento()
        {
            InitializeComponent();
        }

        private void textBoxIdenNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                IdentNum = int.Parse(textBoxIdenNum.Text);
            }
            catch
            {
                MessageBox.Show("Se ha producido un error al introducir el Identificador");
            }

        }

        private void textBoxCodDes_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(textBoxCodDes.Text, @"^[A-Z][0-9]$"))
            {
                MessageBox.Show("Debes introducir el formato correcto");
            }
            else
            {
                CodigoDesc = int.Parse(textBoxCodDes.Text);
            }
        }

        private void textBoxCodVeh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CodigoVehiculo = int.Parse(textBoxCodVeh.Text);
            }
            catch
            {
                MessageBox.Show("Se ha producido un error al introducir el código");
            }

        }

        private void textBoxFechaInicio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FechaInicio = DateTime.Parse(textBoxFechaInicio.Text);
            }
            catch
            {
                MessageBox.Show("Se ha producido un error al introducir la fecha de Inicio");
            }
        }

        private void textBoxFechaFin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FechaFin = DateTime.Parse(textBoxFechaFin.Text);
            }
            catch
            {
                MessageBox.Show("Se ha producido un error al introducir la fecha de Fin");
            }
        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDesc.Text))
            {
                MessageBox.Show("Se ha producido un error al introducir la Descripcion");
            }
            else
            {
                Descripcion = textBoxDesc.Text;
            }
        }
    }
}

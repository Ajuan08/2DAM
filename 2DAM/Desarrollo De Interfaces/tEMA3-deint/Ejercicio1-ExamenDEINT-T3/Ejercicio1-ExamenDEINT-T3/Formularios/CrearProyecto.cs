using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_ExamenDEINT_T3.Formularios
{
    public partial class CrearProyecto : Form
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime fecha_inicio { get; set; }
        public CrearProyecto()
        {
            InitializeComponent();
        }

        private void textBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNombre.Text))
            {
                MessageBox.Show("Se ha producido un error al introducir el nombre");
            }
            else
            {
                Nombre = textBoxNombre.Text;
            }
        }

        private void textBoxDescripcion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDescripcion.Text))
            {
                MessageBox.Show("Se ha producido un error al introducir la descripcion");
            }
            else
            {
                Nombre = textBoxDescripcion.Text;
            }
        }

        private void textBoxFechaInicio_Validating(object sender, CancelEventArgs e)
        {

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            DirectoryInfo directorio = new DirectoryInfo(@"C:\Users\dam\Desktop\GitHub\2DAM\2DAM\Desarrollo De Interfaces\tEMA3-deint\Ejercicio1-ExamenDEINT-T3\Ejercicio1-ExamenDEINT-T3\bin\Debug\net6.0-windows\a");
            if(directorio.Exists ) 
            {
                DirectoryInfo subDirectorio = new DirectoryInfo()
            }
        }
    }
}

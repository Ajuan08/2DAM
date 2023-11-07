using Ejercicio4_T3_Acceso_BBDD.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4_T3_Acceso_BBDD.frm
{
    public partial class frmCiclo : Form
    {
        public frmCiclo()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            CicloDLL cicloDLL = new CicloDLL();
            cicloDLL.Agregar(textBoxNombreCiclo.Text);
        }
    }
}

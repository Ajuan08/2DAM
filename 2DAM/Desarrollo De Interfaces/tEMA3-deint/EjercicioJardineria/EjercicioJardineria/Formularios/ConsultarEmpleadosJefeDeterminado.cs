using EjercicioJardineria.DLL;
using Jardineria.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioJardineria.Formularios
{
    public partial class ConsultarEmpleadosJefeDeterminado : Form
    {
        Conexion conexion;
        public ConsultarEmpleadosJefeDeterminado()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
           int codigoJefe = int.Parse(comboBoxCodJefe.SelectedItem.ToString());
            ProductoDLL consultaEmpleado = new ProductoDLL();
            List<string> resultados = consultaEmpleado.ConsultarEmpleadoJefeDeterminado(codigoJefe);

            if (resultados.Count > 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(resultados.ToArray());
            }
            else
            {
                MessageBox.Show("No se encontraron empleados para el código de jefe proporcionado.");
            }

        }

        private void ConsultarEmpleadosJefeDeterminado_Load(object sender, EventArgs e)
        {
            DataSet dataSet = conexion.EjecutarSentencia("select codigo_jefe from empleado");
            DataTable datos = dataSet.Tables[0];
            foreach (DataRow item in datos.Rows)
            {
                comboBoxCodJefe.Items.Add(item[0]);
            }
        }
    }
}

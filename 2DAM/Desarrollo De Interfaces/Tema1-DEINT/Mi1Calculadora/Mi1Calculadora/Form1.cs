using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mi1Calculadora
{
    public partial class titulo : Form
    {
        public titulo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //agrega item al combo
            cmbop.Items.Clear();
            cmbop.Items.Add("sumar");
            cmbop.Items.Add("Restar");
            //agrega item a la lista
            listadvance.Items.Clear();
            listadvance.Items.Add("Multiplicacion");
            listadvance.Items.Add("Division");
            listadvance.TabIndex = 0;
            //inhabilita el combo y la lista
            cmbop.Enabled = false;
            listadvance.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rbtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn1.Checked == true)
            {
                cmbop.Enabled = true;
                listadvance.Enabled = false;
            }

        }

        private void rbtn2_CheckedChanged(object sender, EventArgs e)
        {
            cmbop.Enabled = false;
            listadvance.Enabled = true;
            //me permite seleccionar el primer elemento de la lista
            listadvance.SelectedIndex = 0;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, r;
            n1 = Convert.ToDouble(txtnum1.Text);
            n2 = Convert.ToDouble(txtnum2.Text);
            if (cmbop.Enabled == true)
            {
                if (cmbop.SelectedItem.ToString() == "sumar") r = n1 + n2;
                else
                    r = n1 - n2;
                MessageBox.Show("El Resultado es " + r.ToString(), "Respuesta");
            }
            if (listadvance.Enabled == true)
            {
                if (listadvance.SelectedItem.ToString() == "Multiplicacion") r =
                n1
                * n2;
                else
                    r = n1 / n2;
                MessageBox.Show("El Resultado es " + r.ToString(),
                "Respuesta");
            }


        }

        private void cmbop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

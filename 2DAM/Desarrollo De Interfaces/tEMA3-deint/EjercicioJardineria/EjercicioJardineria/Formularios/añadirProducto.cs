using EjercicioJardineria.DLL;
using Jardineria.Conexion;
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

namespace EjercicioJardineria.Formularios
{
    public partial class añadirProducto : Form
    {
        public int CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public string Gama { get; set; }
        public string Dimensiones { get; set; }
        public string Proveedor { get; set; }
        public string Descripcion { get; set; }
        public int CantidadStock { get; set; }
        public int PrecioVenta { get; set; }
        public int PrecioProveedor { get; set; }
        Conexion conexion;
        public añadirProducto()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCodProd_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxCodProd.Text, @"^[0-9]{1,}$"))
            {
                CodigoProducto = int.Parse(textBoxCodProd.Text);
            }
            else
            {
                Console.WriteLine("Tienes que introducir un codigo correcto");
            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNombre.Text))
            {
                Console.WriteLine("Tienes que introducir un nombre");
            }
            else
            {
                Nombre = textBoxNombre.Text;
            }
        }

        private void comboBoxGama_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gama = comboBoxGama.Text;
        }

        private void añadirProducto_Load(object sender, EventArgs e)
        {
            DataSet dataSet = conexion.EjecutarSentencia("select gama from gama_producto");
            DataTable datos = dataSet.Tables[0];
            foreach (DataRow item in datos.Rows)
            {
                comboBoxGama.Items.Add(item[0]);
            }
        }

        private void textBoxDimensiones_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDimensiones.Text))
            {
                Console.WriteLine("Tienes que introducir una dimension válida");
            }
            else
            {
                Dimensiones = textBoxDimensiones.Text;
            }
        }

        private void textBoxProveedor_TextChanged(object sender, EventArgs e)
        {
            Proveedor = textBoxProveedor.Text;
        }

        private void textBoxDescripcion_TextChanged(object sender, EventArgs e)
        {
            Descripcion = textBoxDescripcion.Text;
        }

        private void textBoxCantStock_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxCantStock.Text, @"^[0-9]{1,}$"))
            {
                CantidadStock = int.Parse(textBoxCantStock.Text);
            }
            else
            {
                Console.WriteLine("Tienes que introducir una cantidad correcta");
            }
        }

        private void textBoxPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxPrecioVenta.Text, @"^[0-9]{1,}$"))
            {
                PrecioVenta = int.Parse(textBoxPrecioVenta.Text);
            }
            else
            {
                Console.WriteLine("Tienes que introducir un precio correcto");
            }
        }
        private void textBoxPrecioProveedor_TextChanged(object sender, EventArgs e)
        {
            PrecioProveedor = int.Parse(textBoxPrecioProveedor.Text);
        }

        private void buttonAñadirProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoDLL productoDLL = new ProductoDLL();
                productoDLL.añadirProductos(CodigoProducto, Nombre, Gama, Dimensiones, Proveedor, Descripcion, CantidadStock, PrecioVenta, PrecioProveedor);
                MessageBox.Show("Se ha añadido correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

       
    }
}

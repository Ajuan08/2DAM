using System.Data;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio9_Serializacion_XML
{
    public partial class Form1 : Form
    {
        Banco banco = new Banco();
        string rutaArchivo = Directory.GetCurrentDirectory() + "/prueba.xml"; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            CargarClientesDesdeXML();
            actualizarTabla();
            cargarComboBox();
        }

        private void actualizarTabla()
        {
            DataSet dataSet = new DataSet();

            dataSet.ReadXml(rutaArchivo);

            if (dataSet.Tables.Count > 0)
            {
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            else
            {
                MessageBox.Show("No se encontraron datos en el archivo XML.", "Información");
            }

        }



        private void buttonAñadirCliente_Click(object sender, EventArgs e)
        {
            string dni = textBoxDni.Text;
            if (comprobarDni(dni))
            {

                Cliente nuevoCliente = new Cliente(textBoxDni.Text, textBoxNombre.Text, textBoxDireccion.Text, int.Parse(textBoxEdad.Text), int.Parse(textBoxTelefono.Text), int.Parse(textBoxNCuenta.Text));
                banco.agregarCliente(nuevoCliente);

                GuardarClientesEnXML();
                actualizarTabla();
                cargarComboBox();
            }
            else
            {
                MessageBox.Show("El DNI ya existe");
            }
        }
        private void GuardarClientesEnXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Cliente>));

            using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
            {
                serializer.Serialize(fs, banco.getClientes());
            }
        }

        private void CargarClientesDesdeXML()
        {
            if (File.Exists(rutaArchivo))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Cliente>));

                using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open))
                {
                    List<Cliente> clientes = (List<Cliente>)serializer.Deserialize(fs);
                    banco.setClientes(clientes);
                }
            }
        }

        private void cargarComboBox()
        {
            comboBoxDni.Items.Clear();
            comboBoxEliminar.Items.Clear();
            foreach (Cliente cliente in banco.getClientes())
            {
                string dni = cliente.DNI;
                comboBoxDni.Items.Add(dni);
                comboBoxEliminar.Items.Add(dni);
            }
        }

        private Boolean comprobarDni(string dni)
        {
            foreach (var cliente in banco.getClientes())
            {
                if (cliente.DNI == dni)
                {
                    return false;
                }
            }

            return Regex.IsMatch(dni, @"^\d{8}[A-Z]$");

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string dniCliente = comboBoxEliminar.Text;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(rutaArchivo);

            XmlNode nodoCliente = xmlDoc.SelectSingleNode($"//Cliente[Dni='{dniCliente}']");
            if (nodoCliente != null)
            {
                XmlNode nodoPadre = nodoCliente.ParentNode;
                nodoPadre.RemoveChild(nodoCliente);
                xmlDoc.Save(rutaArchivo);
                actualizarTabla();
            }
            cargarComboBox();
        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {

            Cliente nuevoCliente = new Cliente(textBoxDni.Text, textBoxNombre.Text, textBoxDireccion.Text, int.Parse(textBoxEdad.Text), int.Parse(textBoxTelefono.Text), int.Parse(textBoxNCuenta.Text));
            banco.setCliente(nuevoCliente);

            GuardarClientesEnXML();
            actualizarTabla();
            cargarComboBox();
        }

        private void comboDni_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dniCliente = comboBoxDni.Text;
            if (banco.buscarClientePorDni(dniCliente) != null)
            {
                textBoxDni.Text = banco.buscarClientePorDni(dniCliente).DNI;
                textBoxDireccion.Text = banco.buscarClientePorDni(dniCliente).Direccion;
                textBoxEdad.Text = banco.buscarClientePorDni(dniCliente).Edad.ToString();
                textBoxNombre.Text = banco.buscarClientePorDni(dniCliente).Nombre;
                textBoxNCuenta.Text = banco.buscarClientePorDni(dniCliente).NumeroCuentaCorriente.ToString();
                textBoxTelefono.Text = banco.buscarClientePorDni(dniCliente).Telefono.ToString();

            }

        }
    }

}
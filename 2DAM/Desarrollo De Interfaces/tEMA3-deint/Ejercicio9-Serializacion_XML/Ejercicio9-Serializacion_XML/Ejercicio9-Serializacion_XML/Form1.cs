namespace Ejercicio9_Serializacion_XML
{
    public partial class Form1 : Form
    {
        private Banco banco;
        public Form1()
        {
            InitializeComponent();
            banco = new Banco();
            MostrarClientesEnDataGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nombre_Click(object sender, EventArgs e)
        {

        }

        private void buttonAñadirCliente_Click(object sender, EventArgs e)
        {
            string dni = textBoxDni.Text;
            string nombre = textBoxNombre.Text;
            string direccion = textBoxDireccion.Text;
            int edad, telefono, numeroCuenta;

            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(direccion) ||
                !int.TryParse(textBoxEdad.Text, out edad) || !int.TryParse(textBoxTelefono.Text, out telefono) ||
                !int.TryParse(textBoxNCuenta.Text, out numeroCuenta))
            {
                MessageBox.Show("Por favor, ingresa datos válidos en todos los campos.");
                return;
            }

            Cliente nuevoCliente = new Cliente
            {
                DNI = dni,
                Nombre = nombre,
                Direccion = direccion,
                Edad = edad,
                Telefono = telefono,
                NumeroCuentaCorriente = numeroCuenta
            };
            banco.Clientes.Add(nuevoCliente);
            LimpiarCamposFormulario();

            MostrarClientesEnDataGridView();
        }

        private void MostrarClientesEnDataGridView()
        {
            {
                if (dataGridView1.Columns.Count == 0)
                {
                    dataGridView1.Columns.Add("DNI", "DNI");
                    dataGridView1.Columns.Add("Nombre", "Nombre");
                    dataGridView1.Columns.Add("Direccion", "Dirección");
                    dataGridView1.Columns.Add("Edad", "Edad");
                    dataGridView1.Columns.Add("Telefono", "Teléfono");
                    dataGridView1.Columns.Add("NumeroCuentaCorriente", "Nº Cuenta Corriente");
                }
                dataGridView1.Rows.Clear();

                foreach (Cliente cliente in banco.Clientes)
                {
                    dataGridView1.Rows.Add(cliente.DNI, cliente.Nombre, cliente.Direccion, cliente.Edad, cliente.Telefono, cliente.NumeroCuentaCorriente);
                }
            }
        }


        private void LimpiarCamposFormulario()
        {
            textBoxDni.Text = "";
            textBoxNombre.Text = "";
            textBoxDireccion.Text = "";
            textBoxEdad.Text = "";
            textBoxTelefono.Text = "";
            textBoxNCuenta.Text = "";
        }

        private void buttonModificarCliente_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
namespace Ejercicio9_Serializacion_XML
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dni = new Label();
            textBoxDni = new TextBox();
            nombre = new Label();
            textBoxNombre = new TextBox();
            direccion = new Label();
            textBoxDireccion = new TextBox();
            edad = new Label();
            textBoxEdad = new TextBox();
            telefono = new Label();
            textBoxTelefono = new TextBox();
            numeroCuenta = new Label();
            textBoxNCuenta = new TextBox();
            buttonAñadirCliente = new Button();
            dataGridView1 = new DataGridView();
            comboBoxModificar = new ComboBox();
            labelModificar = new Label();
            comboBoxEliminar = new ComboBox();
            labelEliminar = new Label();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dni
            // 
            dni.AutoSize = true;
            dni.Location = new Point(35, 63);
            dni.Name = "dni";
            dni.Size = new Size(33, 15);
            dni.TabIndex = 0;
            dni.Text = "DNI: ";
            dni.TextAlign = ContentAlignment.TopCenter;
            dni.Click += label1_Click;
            // 
            // textBoxDni
            // 
            textBoxDni.Location = new Point(35, 92);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(100, 23);
            textBoxDni.TabIndex = 1;
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Location = new Point(218, 63);
            nombre.Name = "nombre";
            nombre.Size = new Size(54, 15);
            nombre.TabIndex = 2;
            nombre.Text = "Nombre:";
            nombre.TextAlign = ContentAlignment.TopCenter;
            nombre.Click += nombre_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(218, 92);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(159, 23);
            textBoxNombre.TabIndex = 3;
            // 
            // direccion
            // 
            direccion.AutoSize = true;
            direccion.Location = new Point(35, 150);
            direccion.Name = "direccion";
            direccion.Size = new Size(60, 15);
            direccion.TabIndex = 4;
            direccion.Text = "Direccion:";
            direccion.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(35, 181);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(186, 23);
            textBoxDireccion.TabIndex = 5;
            // 
            // edad
            // 
            edad.AutoSize = true;
            edad.Location = new Point(290, 150);
            edad.Name = "edad";
            edad.Size = new Size(36, 15);
            edad.TabIndex = 6;
            edad.Text = "Edad:";
            edad.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(290, 181);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(70, 23);
            textBoxEdad.TabIndex = 7;
            // 
            // telefono
            // 
            telefono.AutoSize = true;
            telefono.Location = new Point(35, 238);
            telefono.Name = "telefono";
            telefono.Size = new Size(55, 15);
            telefono.TabIndex = 8;
            telefono.Text = "Telefono:";
            telefono.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(35, 272);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(186, 23);
            textBoxTelefono.TabIndex = 9;
            // 
            // numeroCuenta
            // 
            numeroCuenta.AutoSize = true;
            numeroCuenta.Location = new Point(40, 322);
            numeroCuenta.Name = "numeroCuenta";
            numeroCuenta.Size = new Size(68, 15);
            numeroCuenta.TabIndex = 10;
            numeroCuenta.Text = "Nº Cuenta: ";
            numeroCuenta.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxNCuenta
            // 
            textBoxNCuenta.Location = new Point(40, 360);
            textBoxNCuenta.Name = "textBoxNCuenta";
            textBoxNCuenta.Size = new Size(186, 23);
            textBoxNCuenta.TabIndex = 11;
            // 
            // buttonAñadirCliente
            // 
            buttonAñadirCliente.Location = new Point(532, 209);
            buttonAñadirCliente.Name = "buttonAñadirCliente";
            buttonAñadirCliente.Size = new Size(119, 23);
            buttonAñadirCliente.TabIndex = 12;
            buttonAñadirCliente.Text = "Añadir Cliente";
            buttonAñadirCliente.UseVisualStyleBackColor = true;
            buttonAñadirCliente.Click += buttonAñadirCliente_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(243, 238);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(507, 267);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBoxModificar
            // 
            comboBoxModificar.FormattingEnabled = true;
            comboBoxModificar.Location = new Point(445, 63);
            comboBoxModificar.Name = "comboBoxModificar";
            comboBoxModificar.Size = new Size(121, 23);
            comboBoxModificar.TabIndex = 17;
            comboBoxModificar.SelectedIndexChanged += comboBoxModificar_SelectedIndexChanged;
            // 
            // labelModificar
            // 
            labelModificar.AutoSize = true;
            labelModificar.Location = new Point(465, 28);
            labelModificar.Name = "labelModificar";
            labelModificar.Size = new Size(101, 15);
            labelModificar.TabIndex = 18;
            labelModificar.Text = "Modificar Cliente:";
            labelModificar.Click += label1_Click_1;
            // 
            // comboBoxEliminar
            // 
            comboBoxEliminar.FormattingEnabled = true;
            comboBoxEliminar.Location = new Point(629, 63);
            comboBoxEliminar.Name = "comboBoxEliminar";
            comboBoxEliminar.Size = new Size(121, 23);
            comboBoxEliminar.TabIndex = 19;
            comboBoxEliminar.SelectedIndexChanged += comboBoxEliminar_SelectedIndexChanged;
            // 
            // labelEliminar
            // 
            labelEliminar.AutoSize = true;
            labelEliminar.Location = new Point(649, 28);
            labelEliminar.Name = "labelEliminar";
            labelEliminar.Size = new Size(82, 15);
            labelEliminar.TabIndex = 20;
            labelEliminar.Text = "Borrar Cliente:";
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(465, 170);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 23);
            buttonModificar.TabIndex = 21;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(649, 170);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 22;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 540);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonModificar);
            Controls.Add(labelEliminar);
            Controls.Add(comboBoxEliminar);
            Controls.Add(labelModificar);
            Controls.Add(comboBoxModificar);
            Controls.Add(dataGridView1);
            Controls.Add(buttonAñadirCliente);
            Controls.Add(textBoxNCuenta);
            Controls.Add(numeroCuenta);
            Controls.Add(textBoxTelefono);
            Controls.Add(telefono);
            Controls.Add(textBoxEdad);
            Controls.Add(edad);
            Controls.Add(textBoxDireccion);
            Controls.Add(direccion);
            Controls.Add(textBoxNombre);
            Controls.Add(nombre);
            Controls.Add(textBoxDni);
            Controls.Add(dni);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dni;
        private TextBox textBoxDni;
        private Label nombre;
        private TextBox textBoxNombre;
        private Label direccion;
        private TextBox textBoxDireccion;
        private Label edad;
        private TextBox textBoxEdad;
        private Label telefono;
        private TextBox textBoxTelefono;
        private Label numeroCuenta;
        private TextBox textBoxNCuenta;
        private Button buttonAñadirCliente;
        private DataGridView dataGridView1;
        private ComboBox comboBoxModificar;
        private Label labelModificar;
        private ComboBox comboBoxEliminar;
        private Label labelEliminar;
        private Button buttonModificar;
        private Button buttonEliminar;
    }
}
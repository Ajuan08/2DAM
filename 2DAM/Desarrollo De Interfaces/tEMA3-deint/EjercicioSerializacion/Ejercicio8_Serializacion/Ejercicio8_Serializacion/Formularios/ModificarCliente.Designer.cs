namespace Ejercicio8_Serializacion.Formularios
{
    partial class ModificarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonModificar = new Button();
            textBoxNumCuenta = new TextBox();
            label6 = new Label();
            textBoxTelefono = new TextBox();
            label5 = new Label();
            textBoxEdad = new TextBox();
            label4 = new Label();
            textBoxDireccion = new TextBox();
            label3 = new Label();
            textBoxNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboBoxClientes = new ComboBox();
            buttonSeleccionarCliente = new Button();
            SuspendLayout();
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(605, 361);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(110, 31);
            buttonModificar.TabIndex = 26;
            buttonModificar.Text = "Modificar Cliente";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // textBoxNumCuenta
            // 
            textBoxNumCuenta.Location = new Point(237, 395);
            textBoxNumCuenta.Name = "textBoxNumCuenta";
            textBoxNumCuenta.Size = new Size(265, 23);
            textBoxNumCuenta.TabIndex = 25;
            textBoxNumCuenta.TextChanged += textBoxNumCuenta_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(242, 377);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 24;
            label6.Text = "Número Cuenta";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(237, 332);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(265, 23);
            textBoxTelefono.TabIndex = 23;
            textBoxTelefono.TextChanged += textBoxTelefono_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(242, 314);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 22;
            label5.Text = "Teléfono";
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(237, 267);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(265, 23);
            textBoxEdad.TabIndex = 21;
            textBoxEdad.TextChanged += textBoxEdad_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 249);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 20;
            label4.Text = "Edad";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(237, 195);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(265, 23);
            textBoxDireccion.TabIndex = 19;
            textBoxDireccion.TextChanged += textBoxDireccion_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 177);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 18;
            label3.Text = "Direccion";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(237, 125);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(265, 23);
            textBoxNombre.TabIndex = 17;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 107);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 16;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 43);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 14;
            label1.Text = "DNI";
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(237, 73);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(254, 23);
            comboBoxClientes.TabIndex = 27;
            comboBoxClientes.SelectedIndexChanged += comboBoxClientes_SelectedIndexChanged;
            // 
            // buttonSeleccionarCliente
            // 
            buttonSeleccionarCliente.Location = new Point(541, 72);
            buttonSeleccionarCliente.Name = "buttonSeleccionarCliente";
            buttonSeleccionarCliente.Size = new Size(130, 23);
            buttonSeleccionarCliente.TabIndex = 28;
            buttonSeleccionarCliente.Text = "Seleccionar Cliente";
            buttonSeleccionarCliente.UseVisualStyleBackColor = true;
            buttonSeleccionarCliente.Click += buttonSeleccionarCliente_Click;
            // 
            // ModificarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSeleccionarCliente);
            Controls.Add(comboBoxClientes);
            Controls.Add(buttonModificar);
            Controls.Add(textBoxNumCuenta);
            Controls.Add(label6);
            Controls.Add(textBoxTelefono);
            Controls.Add(label5);
            Controls.Add(textBoxEdad);
            Controls.Add(label4);
            Controls.Add(textBoxDireccion);
            Controls.Add(label3);
            Controls.Add(textBoxNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModificarCliente";
            Text = "ModificarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonModificar;
        private TextBox textBoxNumCuenta;
        private Label label6;
        private TextBox textBoxTelefono;
        private Label label5;
        private TextBox textBoxEdad;
        private Label label4;
        private TextBox textBoxDireccion;
        private Label label3;
        private TextBox textBoxNombre;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxClientes;
        private Button buttonSeleccionarCliente;
    }
}
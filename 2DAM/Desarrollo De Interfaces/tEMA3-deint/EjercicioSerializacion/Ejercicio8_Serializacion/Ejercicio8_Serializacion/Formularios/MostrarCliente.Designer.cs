namespace Ejercicio8_Serializacion.Formularios
{
    partial class MostrarCliente
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
            label1 = new Label();
            label2 = new Label();
            textBoxNombre = new TextBox();
            label3 = new Label();
            textBoxDireccion = new TextBox();
            label4 = new Label();
            textBoxEdad = new TextBox();
            label5 = new Label();
            textBoxTelefono = new TextBox();
            label6 = new Label();
            textBoxNumCuenta = new TextBox();
            comboBoxClientes = new ComboBox();
            buttonSeleccionarCliente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(243, 40);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 29;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 104);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 30;
            label2.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(243, 122);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(265, 23);
            textBoxNombre.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 174);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 32;
            label3.Text = "Direccion";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(243, 192);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(265, 23);
            textBoxDireccion.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 246);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 34;
            label4.Text = "Edad";
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(243, 264);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(265, 23);
            textBoxEdad.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 311);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 36;
            label5.Text = "Teléfono";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(243, 329);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(265, 23);
            textBoxTelefono.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(248, 374);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 38;
            label6.Text = "Número Cuenta";
            // 
            // textBoxNumCuenta
            // 
            textBoxNumCuenta.Location = new Point(243, 392);
            textBoxNumCuenta.Name = "textBoxNumCuenta";
            textBoxNumCuenta.Size = new Size(265, 23);
            textBoxNumCuenta.TabIndex = 39;
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(243, 70);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(254, 23);
            comboBoxClientes.TabIndex = 41;
            // 
            // buttonSeleccionarCliente
            // 
            buttonSeleccionarCliente.Location = new Point(547, 69);
            buttonSeleccionarCliente.Name = "buttonSeleccionarCliente";
            buttonSeleccionarCliente.Size = new Size(130, 23);
            buttonSeleccionarCliente.TabIndex = 42;
            buttonSeleccionarCliente.Text = "Seleccionar Cliente";
            buttonSeleccionarCliente.UseVisualStyleBackColor = true;
            buttonSeleccionarCliente.Click += buttonSeleccionarCliente_Click;
            // 
            // MostrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSeleccionarCliente);
            Controls.Add(comboBoxClientes);
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
            Name = "MostrarCliente";
            Text = "MostrarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxNombre;
        private Label label3;
        private TextBox textBoxDireccion;
        private Label label4;
        private TextBox textBoxEdad;
        private Label label5;
        private TextBox textBoxTelefono;
        private Label label6;
        private TextBox textBoxNumCuenta;
        private ComboBox comboBoxClientes;
        private Button buttonSeleccionarCliente;
    }
}
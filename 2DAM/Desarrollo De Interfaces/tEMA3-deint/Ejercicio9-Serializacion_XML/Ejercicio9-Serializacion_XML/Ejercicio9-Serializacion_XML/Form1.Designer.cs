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
            comboBoxDni = new ComboBox();
            labelModificar = new Label();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxEliminar = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dni
            // 
            dni.Location = new Point(0, 0);
            dni.Name = "dni";
            dni.Size = new Size(100, 23);
            dni.TabIndex = 27;
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
            nombre.Location = new Point(0, 0);
            nombre.Name = "nombre";
            nombre.Size = new Size(100, 23);
            nombre.TabIndex = 26;
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
            buttonAñadirCliente.Location = new Point(530, 198);
            buttonAñadirCliente.Name = "buttonAñadirCliente";
            buttonAñadirCliente.Size = new Size(119, 23);
            buttonAñadirCliente.TabIndex = 12;
            buttonAñadirCliente.Text = "Añadir Cliente";
            buttonAñadirCliente.UseVisualStyleBackColor = true;
            buttonAñadirCliente.Click += buttonAñadirCliente_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Location = new Point(261, 272);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(537, 223);
            dataGridView1.TabIndex = 25;
            // 
            // comboBoxDni
            // 
            comboBoxDni.Location = new Point(475, 92);
            comboBoxDni.Name = "comboBoxDni";
            comboBoxDni.Size = new Size(121, 23);
            comboBoxDni.TabIndex = 24;
            // 
            // labelModificar
            // 
            labelModificar.Location = new Point(0, 0);
            labelModificar.Name = "labelModificar";
            labelModificar.Size = new Size(100, 23);
            labelModificar.TabIndex = 23;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(465, 150);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 23);
            buttonModificar.TabIndex = 21;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(649, 150);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 22;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(521, 62);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 28;
            label1.Text = "Modificar/Eliminar Cliente";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 51);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 29;
            label2.Text = "DNI:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 51);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 30;
            label3.Text = "Nombre:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBoxEliminar
            // 
            comboBoxEliminar.Location = new Point(634, 92);
            comboBoxEliminar.Name = "comboBoxEliminar";
            comboBoxEliminar.Size = new Size(121, 23);
            comboBoxEliminar.TabIndex = 31;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 540);
            Controls.Add(comboBoxEliminar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonModificar);
            Controls.Add(labelModificar);
            Controls.Add(comboBoxDni);
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
            Text = "v";
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
        private ComboBox comboBoxDni;
        private Label labelModificar;
        private Button buttonModificar;
        private Button buttonEliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxEliminar;
    }
}
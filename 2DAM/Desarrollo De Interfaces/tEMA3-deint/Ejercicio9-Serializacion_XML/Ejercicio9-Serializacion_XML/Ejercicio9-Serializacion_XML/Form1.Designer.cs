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
            buttonModificarCliente = new Button();
            buttonEliminarCliente = new Button();
            buttonMostrarCliente = new Button();
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
            buttonAñadirCliente.Location = new Point(620, 92);
            buttonAñadirCliente.Name = "buttonAñadirCliente";
            buttonAñadirCliente.Size = new Size(119, 23);
            buttonAñadirCliente.TabIndex = 12;
            buttonAñadirCliente.Text = "Añadir Cliente";
            buttonAñadirCliente.UseVisualStyleBackColor = true;
            buttonAñadirCliente.Click += buttonAñadirCliente_Click;
            // 
            // buttonModificarCliente
            // 
            buttonModificarCliente.Location = new Point(620, 165);
            buttonModificarCliente.Name = "buttonModificarCliente";
            buttonModificarCliente.Size = new Size(119, 22);
            buttonModificarCliente.TabIndex = 13;
            buttonModificarCliente.Text = "Modificar Cliente";
            buttonModificarCliente.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarCliente
            // 
            buttonEliminarCliente.Location = new Point(620, 231);
            buttonEliminarCliente.Name = "buttonEliminarCliente";
            buttonEliminarCliente.Size = new Size(119, 22);
            buttonEliminarCliente.TabIndex = 14;
            buttonEliminarCliente.Text = "Eliminar Cliente";
            buttonEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // buttonMostrarCliente
            // 
            buttonMostrarCliente.Location = new Point(620, 306);
            buttonMostrarCliente.Name = "buttonMostrarCliente";
            buttonMostrarCliente.Size = new Size(119, 22);
            buttonMostrarCliente.TabIndex = 15;
            buttonMostrarCliente.Text = "Mostrar Cliente";
            buttonMostrarCliente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonMostrarCliente);
            Controls.Add(buttonEliminarCliente);
            Controls.Add(buttonModificarCliente);
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
        private Button buttonModificarCliente;
        private Button buttonEliminarCliente;
        private Button buttonMostrarCliente;
    }
}
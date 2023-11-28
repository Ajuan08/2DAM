namespace Ejercicio8_Serializacion.Formularios
{
    partial class AgregarCliente
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
            textBoxDNI = new TextBox();
            textBoxNombre = new TextBox();
            label2 = new Label();
            textBoxDireccion = new TextBox();
            label3 = new Label();
            textBoxEdad = new TextBox();
            label4 = new Label();
            textBoxTelefono = new TextBox();
            label5 = new Label();
            textBoxNumCuenta = new TextBox();
            label6 = new Label();
            buttonAgregar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 49);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(249, 67);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(265, 23);
            textBoxDNI.TabIndex = 2;
            textBoxDNI.TextChanged += textBoxDNI_TextChanged;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(249, 131);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(265, 23);
            textBoxNombre.TabIndex = 4;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 113);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(249, 201);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(265, 23);
            textBoxDireccion.TabIndex = 6;
            textBoxDireccion.TextChanged += textBoxDireccion_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 183);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Direccion";
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(249, 273);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(265, 23);
            textBoxEdad.TabIndex = 8;
            textBoxEdad.TextChanged += textBoxEdad_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 255);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 7;
            label4.Text = "Edad";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(249, 338);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(265, 23);
            textBoxTelefono.TabIndex = 10;
            textBoxTelefono.TextChanged += textBoxTelefono_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(254, 320);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 9;
            label5.Text = "Teléfono";
            // 
            // textBoxNumCuenta
            // 
            textBoxNumCuenta.Location = new Point(249, 401);
            textBoxNumCuenta.Name = "textBoxNumCuenta";
            textBoxNumCuenta.Size = new Size(265, 23);
            textBoxNumCuenta.TabIndex = 12;
            textBoxNumCuenta.TextChanged += textBoxNumCuenta_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(254, 383);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 11;
            label6.Text = "Número Cuenta";
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(617, 367);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(110, 31);
            buttonAgregar.TabIndex = 13;
            buttonAgregar.Text = "Agregar Cliente";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // AgregarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAgregar);
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
            Controls.Add(textBoxDNI);
            Controls.Add(label1);
            Name = "AgregarCliente";
            Text = "AgregarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxDNI;
        private TextBox textBoxNombre;
        private Label label2;
        private TextBox textBoxDireccion;
        private Label label3;
        private TextBox textBoxEdad;
        private Label label4;
        private TextBox textBoxTelefono;
        private Label label5;
        private TextBox textBoxNumCuenta;
        private Label label6;
        private Button buttonAgregar;
    }
}
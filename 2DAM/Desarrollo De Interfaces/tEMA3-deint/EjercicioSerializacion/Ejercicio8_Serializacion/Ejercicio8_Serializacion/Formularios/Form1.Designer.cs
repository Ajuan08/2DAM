namespace Ejercicio8_Serializacion
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
            buttonAgregarCliente = new Button();
            buttonModificarCliente = new Button();
            buttonEliminarCliente = new Button();
            buttonMostrarCliente = new Button();
            SuspendLayout();
            // 
            // buttonAgregarCliente
            // 
            buttonAgregarCliente.Location = new Point(130, 102);
            buttonAgregarCliente.Name = "buttonAgregarCliente";
            buttonAgregarCliente.Size = new Size(141, 74);
            buttonAgregarCliente.TabIndex = 0;
            buttonAgregarCliente.Text = "Agregar Cliente";
            buttonAgregarCliente.UseVisualStyleBackColor = true;
            buttonAgregarCliente.Click += buttonAgregarCliente_Click;
            // 
            // buttonModificarCliente
            // 
            buttonModificarCliente.Location = new Point(130, 227);
            buttonModificarCliente.Name = "buttonModificarCliente";
            buttonModificarCliente.Size = new Size(141, 74);
            buttonModificarCliente.TabIndex = 1;
            buttonModificarCliente.Text = "Modificar Cliente";
            buttonModificarCliente.UseVisualStyleBackColor = true;
            buttonModificarCliente.Click += buttonModificarCliente_Click;
            // 
            // buttonEliminarCliente
            // 
            buttonEliminarCliente.Location = new Point(451, 102);
            buttonEliminarCliente.Name = "buttonEliminarCliente";
            buttonEliminarCliente.Size = new Size(141, 74);
            buttonEliminarCliente.TabIndex = 2;
            buttonEliminarCliente.Text = "Eliminar Cliente";
            buttonEliminarCliente.UseVisualStyleBackColor = true;
            buttonEliminarCliente.Click += buttonEliminarCliente_Click;
            // 
            // buttonMostrarCliente
            // 
            buttonMostrarCliente.Location = new Point(451, 227);
            buttonMostrarCliente.Name = "buttonMostrarCliente";
            buttonMostrarCliente.Size = new Size(141, 74);
            buttonMostrarCliente.TabIndex = 3;
            buttonMostrarCliente.Text = "Mostrar Clientes";
            buttonMostrarCliente.UseVisualStyleBackColor = true;
            buttonMostrarCliente.Click += buttonMostrarCliente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonMostrarCliente);
            Controls.Add(buttonEliminarCliente);
            Controls.Add(buttonModificarCliente);
            Controls.Add(buttonAgregarCliente);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAgregarCliente;
        private Button buttonModificarCliente;
        private Button buttonEliminarCliente;
        private Button buttonMostrarCliente;
    }
}

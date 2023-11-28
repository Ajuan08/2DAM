namespace Ejercicio8_Serializacion.Formularios
{
    partial class EliminarCliente
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
            buttonEliminar = new Button();
            label1 = new Label();
            comboBoxClientes = new ComboBox();
            SuspendLayout();
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(335, 185);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(117, 35);
            buttonEliminar.TabIndex = 0;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(374, 112);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 1;
            label1.Text = "DNI";
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(276, 139);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(237, 23);
            comboBoxClientes.TabIndex = 2;
            comboBoxClientes.SelectedIndexChanged += comboBoxClientes_SelectedIndexChanged;
            // 
            // EliminarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxClientes);
            Controls.Add(label1);
            Controls.Add(buttonEliminar);
            Name = "EliminarCliente";
            Text = "EliminarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEliminar;
        private Label label1;
        private ComboBox comboBoxClientes;
    }
}
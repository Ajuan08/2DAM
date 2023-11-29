namespace EjercicioJardineria.Formularios
{
    partial class ConsultarEmpleadosJefeDeterminado
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
            comboBoxCodJefe = new ComboBox();
            buttonBuscar = new Button();
            label1 = new Label();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // comboBoxCodJefe
            // 
            comboBoxCodJefe.FormattingEnabled = true;
            comboBoxCodJefe.Location = new Point(199, 84);
            comboBoxCodJefe.Name = "comboBoxCodJefe";
            comboBoxCodJefe.Size = new Size(121, 23);
            comboBoxCodJefe.TabIndex = 8;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(371, 84);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(91, 23);
            buttonBuscar.TabIndex = 6;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 55);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 5;
            label1.Text = "Código del Jefe";
            // 
            // listView1
            // 
            listView1.Location = new Point(116, 137);
            listView1.Name = "listView1";
            listView1.Size = new Size(527, 247);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ConsultarEmpleadosJefeDeterminado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(comboBoxCodJefe);
            Controls.Add(buttonBuscar);
            Controls.Add(label1);
            Name = "ConsultarEmpleadosJefeDeterminado";
            Text = "ConsultarEmpleadosJefeDeterminado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCodJefe;
        private Button buttonBuscar;
        private Label label1;
        private ListView listView1;
    }
}
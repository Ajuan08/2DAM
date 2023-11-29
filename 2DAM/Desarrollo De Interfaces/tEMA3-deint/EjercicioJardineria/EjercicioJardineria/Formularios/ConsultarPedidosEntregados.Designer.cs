namespace EjercicioJardineria.Formularios
{
    partial class ConsultarPedidosEntregados
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
            buttonBuscar = new Button();
            dataGridView1 = new DataGridView();
            comboBoxMes = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 50);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 1;
            label1.Text = "Introduce el mes";
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(341, 79);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(91, 23);
            buttonBuscar.TabIndex = 2;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(113, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(515, 258);
            dataGridView1.TabIndex = 3;
            // 
            // comboBoxMes
            // 
            comboBoxMes.FormattingEnabled = true;
            comboBoxMes.Location = new Point(169, 79);
            comboBoxMes.Name = "comboBoxMes";
            comboBoxMes.Size = new Size(121, 23);
            comboBoxMes.TabIndex = 4;
            // 
            // ConsultarPedidosEntregados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxMes);
            Controls.Add(dataGridView1);
            Controls.Add(buttonBuscar);
            Controls.Add(label1);
            Name = "ConsultarPedidosEntregados";
            Text = "ConsultarPedidosEntregados";
            Load += ConsultarPedidosEntregados_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button buttonBuscar;
        private DataGridView dataGridView1;
        private ComboBox comboBoxMes;
    }
}
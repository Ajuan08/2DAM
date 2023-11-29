namespace EjercicioJardineria.Formularios
{
    partial class ConsultarClientesQueNoPagan
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
            dataGridView1 = new DataGridView();
            buttonConsultar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(126, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(569, 286);
            dataGridView1.TabIndex = 0;
            // 
            // buttonConsultar
            // 
            buttonConsultar.Location = new Point(335, 50);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(129, 36);
            buttonConsultar.TabIndex = 1;
            buttonConsultar.Text = "CONSULTAR";
            buttonConsultar.UseVisualStyleBackColor = true;
            buttonConsultar.Click += buttonConsultar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 21);
            label1.Name = "label1";
            label1.Size = new Size(183, 15);
            label1.TabIndex = 2;
            label1.Text = "Consultar Clientes Que No Pagan";
            // 
            // ConsultarClientesQueNoPagan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonConsultar);
            Controls.Add(dataGridView1);
            Name = "ConsultarClientesQueNoPagan";
            Text = "ConsultarClientesQueNoPagan";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonConsultar;
        private Label label1;
    }
}
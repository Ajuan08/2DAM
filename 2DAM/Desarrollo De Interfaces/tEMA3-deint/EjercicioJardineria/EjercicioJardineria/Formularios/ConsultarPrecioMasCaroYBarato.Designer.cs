﻿namespace EjercicioJardineria.Formularios
{
    partial class ConsultarPrecioMasCaroYBarato
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
            buttonConsultar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 37);
            label1.Name = "label1";
            label1.Size = new Size(218, 15);
            label1.TabIndex = 5;
            label1.Text = "Consultar Precio más Caro y más Barato";
            // 
            // buttonConsultar
            // 
            buttonConsultar.Location = new Point(325, 66);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(129, 36);
            buttonConsultar.TabIndex = 4;
            buttonConsultar.Text = "CONSULTAR";
            buttonConsultar.UseVisualStyleBackColor = true;
            buttonConsultar.Click += buttonConsultar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(116, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(569, 286);
            dataGridView1.TabIndex = 3;
            // 
            // ConsultarPrecioMasCaroYBarato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonConsultar);
            Controls.Add(dataGridView1);
            Name = "ConsultarPrecioMasCaroYBarato";
            Text = "ConsultarPrecioMasCaroYBarato";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonConsultar;
        private DataGridView dataGridView1;
    }
}
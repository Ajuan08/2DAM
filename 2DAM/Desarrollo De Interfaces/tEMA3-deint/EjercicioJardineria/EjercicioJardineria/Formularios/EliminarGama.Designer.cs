namespace EjercicioJardineria.Formularios
{
    partial class EliminarGama
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
            comboBoxGama = new ComboBox();
            label1 = new Label();
            buttonEliminarGama = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxGama
            // 
            comboBoxGama.FormattingEnabled = true;
            comboBoxGama.Location = new Point(233, 71);
            comboBoxGama.Name = "comboBoxGama";
            comboBoxGama.Size = new Size(171, 23);
            comboBoxGama.TabIndex = 0;
            comboBoxGama.SelectedIndexChanged += comboBoxGama_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 44);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Gama";
            // 
            // buttonEliminarGama
            // 
            buttonEliminarGama.Location = new Point(267, 113);
            buttonEliminarGama.Name = "buttonEliminarGama";
            buttonEliminarGama.Size = new Size(110, 41);
            buttonEliminarGama.TabIndex = 2;
            buttonEliminarGama.Text = "Eliminar Gama";
            buttonEliminarGama.UseVisualStyleBackColor = true;
            buttonEliminarGama.Click += buttonEliminarGama_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(91, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(519, 214);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // EliminarGama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(buttonEliminarGama);
            Controls.Add(label1);
            Controls.Add(comboBoxGama);
            Name = "EliminarGama";
            Text = "EliminarGama";
            Load += EliminarGama_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxGama;
        private Label label1;
        private Button buttonEliminarGama;
        private DataGridView dataGridView1;
    }
}
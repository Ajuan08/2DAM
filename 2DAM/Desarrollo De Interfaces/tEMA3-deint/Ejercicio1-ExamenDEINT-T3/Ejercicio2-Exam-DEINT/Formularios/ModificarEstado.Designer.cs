namespace Ejercicio2_Exam_DEINT.Formularios
{
    partial class ModificarEstado
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
            buttonModificar = new Button();
            textBoxEstado = new TextBox();
            label6 = new Label();
            textBoxAñoFab = new TextBox();
            label5 = new Label();
            textBoxMarca = new TextBox();
            label4 = new Label();
            textBoxModelo = new TextBox();
            label3 = new Label();
            textBoxMatricula = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(562, 306);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(140, 67);
            buttonModificar.TabIndex = 25;
            buttonModificar.Text = "MODIFICAR";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // textBoxEstado
            // 
            textBoxEstado.Location = new Point(380, 264);
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.Size = new Size(100, 23);
            textBoxEstado.TabIndex = 24;
            textBoxEstado.TextChanged += textBoxEstado_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(380, 230);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 23;
            label6.Text = "Estado";
            // 
            // textBoxAñoFab
            // 
            textBoxAñoFab.Location = new Point(380, 187);
            textBoxAñoFab.Name = "textBoxAñoFab";
            textBoxAñoFab.Size = new Size(100, 23);
            textBoxAñoFab.TabIndex = 22;
            textBoxAñoFab.TextChanged += textBoxAñoFab_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(380, 153);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 21;
            label5.Text = "Año Fabricacion";
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(380, 112);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(100, 23);
            textBoxMarca.TabIndex = 20;
            textBoxMarca.TextChanged += textBoxMarca_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(380, 78);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 19;
            label4.Text = "Marca";
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(98, 264);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(100, 23);
            textBoxModelo.TabIndex = 18;
            textBoxModelo.TextChanged += textBoxModelo_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 230);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 17;
            label3.Text = "Modelo";
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.Location = new Point(98, 187);
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(100, 23);
            textBoxMatricula.TabIndex = 16;
            textBoxMatricula.TextChanged += textBoxMatricula_TextChanged;
            textBoxMatricula.Validating += textBoxMatricula_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 153);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 15;
            label2.Text = "Matricula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 78);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 13;
            label1.Text = "Identificador";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(98, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 26;
            // 
            // ModificarEstado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(buttonModificar);
            Controls.Add(textBoxEstado);
            Controls.Add(label6);
            Controls.Add(textBoxAñoFab);
            Controls.Add(label5);
            Controls.Add(textBoxMarca);
            Controls.Add(label4);
            Controls.Add(textBoxModelo);
            Controls.Add(label3);
            Controls.Add(textBoxMatricula);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModificarEstado";
            Text = "ModificarEstado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonModificar;
        private TextBox textBoxEstado;
        private Label label6;
        private TextBox textBoxAñoFab;
        private Label label5;
        private TextBox textBoxMarca;
        private Label label4;
        private TextBox textBoxModelo;
        private Label label3;
        private TextBox textBoxMatricula;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
    }
}
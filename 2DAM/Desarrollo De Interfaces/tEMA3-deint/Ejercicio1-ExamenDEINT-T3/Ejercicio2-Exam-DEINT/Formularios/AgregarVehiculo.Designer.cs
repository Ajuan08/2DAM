namespace Ejercicio2_Exam_DEINT.Formularios
{
    partial class AgregarVehiculo
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
            textBoxMatricula = new TextBox();
            label2 = new Label();
            textBoxModelo = new TextBox();
            label3 = new Label();
            textBoxMarca = new TextBox();
            label4 = new Label();
            textBoxAñoFab = new TextBox();
            label5 = new Label();
            textBoxEstado = new TextBox();
            label6 = new Label();
            button1 = new Button();
            textBoxIdent = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 77);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Identificador";
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.Location = new Point(113, 186);
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(100, 23);
            textBoxMatricula.TabIndex = 3;
            textBoxMatricula.TextChanged += textBoxMatricula_TextChanged;
            textBoxMatricula.Validating += textBoxMatricula_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 152);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Matricula";
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(113, 263);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(100, 23);
            textBoxModelo.TabIndex = 5;
            textBoxModelo.TextChanged += textBoxModelo_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 229);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Modelo";
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(395, 111);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(100, 23);
            textBoxMarca.TabIndex = 7;
            textBoxMarca.TextChanged += textBoxMarca_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(395, 77);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Marca";
            // 
            // textBoxAñoFab
            // 
            textBoxAñoFab.Location = new Point(395, 186);
            textBoxAñoFab.Name = "textBoxAñoFab";
            textBoxAñoFab.Size = new Size(100, 23);
            textBoxAñoFab.TabIndex = 9;
            textBoxAñoFab.TextChanged += textBoxAñoFab_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(395, 152);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 8;
            label5.Text = "Año Fabricacion";
            // 
            // textBoxEstado
            // 
            textBoxEstado.Location = new Point(395, 263);
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.Size = new Size(100, 23);
            textBoxEstado.TabIndex = 11;
            textBoxEstado.TextChanged += textBoxEstado_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(395, 229);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 10;
            label6.Text = "Estado";
            // 
            // button1
            // 
            button1.Location = new Point(577, 305);
            button1.Name = "button1";
            button1.Size = new Size(140, 67);
            button1.TabIndex = 12;
            button1.Text = "AÑADIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxIdent
            // 
            textBoxIdent.Location = new Point(113, 111);
            textBoxIdent.Name = "textBoxIdent";
            textBoxIdent.Size = new Size(100, 23);
            textBoxIdent.TabIndex = 1;
            textBoxIdent.TextChanged += textBoxIdent_TextChanged;
            // 
            // AgregarVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
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
            Controls.Add(textBoxIdent);
            Controls.Add(label1);
            Name = "AgregarVehiculo";
            Text = "AgregarVehiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxMatricula;
        private Label label2;
        private TextBox textBoxModelo;
        private Label label3;
        private TextBox textBoxMarca;
        private Label label4;
        private TextBox textBoxAñoFab;
        private Label label5;
        private TextBox textBoxEstado;
        private Label label6;
        private Button button1;
        private TextBox textBoxIdent;
    }
}
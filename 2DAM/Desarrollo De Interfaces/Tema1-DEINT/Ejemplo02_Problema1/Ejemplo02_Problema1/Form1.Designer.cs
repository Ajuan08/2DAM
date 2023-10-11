namespace Ejemplo02_Problema1
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
            textNombre = new TextBox();
            Nombre = new Label();
            label1 = new Label();
            textSalario = new TextBox();
            label2 = new Label();
            radioGerente = new RadioButton();
            radioSubGerente = new RadioButton();
            radioSecretaria = new RadioButton();
            botonCalcular = new Button();
            SuspendLayout();
            // 
            // textNombre
            // 
            textNombre.Location = new Point(208, 131);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 0;
            textNombre.TextChanged += textNombre_TextChanged;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(146, 134);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(429, 134);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Salario";
            // 
            // textSalario
            // 
            textSalario.Location = new Point(477, 131);
            textSalario.Name = "textSalario";
            textSalario.Size = new Size(100, 23);
            textSalario.TabIndex = 3;
            textSalario.TextChanged += textSalario_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 67);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 4;
            label2.Text = "PROBLEMA 1";
            // 
            // radioGerente
            // 
            radioGerente.AutoSize = true;
            radioGerente.Location = new Point(208, 230);
            radioGerente.Name = "radioGerente";
            radioGerente.Size = new Size(66, 19);
            radioGerente.TabIndex = 5;
            radioGerente.TabStop = true;
            radioGerente.Text = "Gerente";
            radioGerente.UseVisualStyleBackColor = true;
            radioGerente.CheckedChanged += radioGerente_CheckedChanged;
            // 
            // radioSubGerente
            // 
            radioSubGerente.AutoSize = true;
            radioSubGerente.Location = new Point(342, 230);
            radioSubGerente.Name = "radioSubGerente";
            radioSubGerente.Size = new Size(86, 19);
            radioSubGerente.TabIndex = 6;
            radioSubGerente.TabStop = true;
            radioSubGerente.Text = "SubGerente";
            radioSubGerente.UseVisualStyleBackColor = true;
            // 
            // radioSecretaria
            // 
            radioSecretaria.AutoSize = true;
            radioSecretaria.Location = new Point(492, 230);
            radioSecretaria.Name = "radioSecretaria";
            radioSecretaria.Size = new Size(76, 19);
            radioSecretaria.TabIndex = 7;
            radioSecretaria.TabStop = true;
            radioSecretaria.Text = "Secretaria";
            radioSecretaria.UseVisualStyleBackColor = true;
            // 
            // botonCalcular
            // 
            botonCalcular.Location = new Point(342, 304);
            botonCalcular.Name = "botonCalcular";
            botonCalcular.Size = new Size(75, 23);
            botonCalcular.TabIndex = 8;
            botonCalcular.Text = "Calcular";
            botonCalcular.UseVisualStyleBackColor = true;
            botonCalcular.Click += botonCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botonCalcular);
            Controls.Add(radioSecretaria);
            Controls.Add(radioSubGerente);
            Controls.Add(radioGerente);
            Controls.Add(label2);
            Controls.Add(textSalario);
            Controls.Add(label1);
            Controls.Add(Nombre);
            Controls.Add(textNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNombre;
        private Label Nombre;
        private Label label1;
        private TextBox textSalario;
        private Label label2;
        private RadioButton radioGerente;
        private RadioButton radioSubGerente;
        private RadioButton radioSecretaria;
        private Button botonCalcular;
    }
}
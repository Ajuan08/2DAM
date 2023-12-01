namespace Ejercicio1_ExamenDEINT_T3.Formularios
{
    partial class AgregarTareas
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
            textBoxNombre = new TextBox();
            textBoxDescripcion = new TextBox();
            label2 = new Label();
            textBoxFechaVenci = new TextBox();
            label3 = new Label();
            textBoxEstado = new TextBox();
            label4 = new Label();
            buttonAgregarTareas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 81);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(178, 116);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 1;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(178, 203);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(100, 23);
            textBoxDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 168);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripcion";
            // 
            // textBoxFechaVenci
            // 
            textBoxFechaVenci.Location = new Point(484, 116);
            textBoxFechaVenci.Name = "textBoxFechaVenci";
            textBoxFechaVenci.Size = new Size(100, 23);
            textBoxFechaVenci.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 81);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 4;
            label3.Text = "FechaVencimiento";
            // 
            // textBoxEstado
            // 
            textBoxEstado.Location = new Point(484, 203);
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.Size = new Size(100, 23);
            textBoxEstado.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 168);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Estado";
            // 
            // buttonAgregarTareas
            // 
            buttonAgregarTareas.Location = new Point(302, 269);
            buttonAgregarTareas.Name = "buttonAgregarTareas";
            buttonAgregarTareas.Size = new Size(136, 47);
            buttonAgregarTareas.TabIndex = 8;
            buttonAgregarTareas.Text = "AGREGAR TAREAS";
            buttonAgregarTareas.UseVisualStyleBackColor = true;
            // 
            // AgregarTareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAgregarTareas);
            Controls.Add(textBoxEstado);
            Controls.Add(label4);
            Controls.Add(textBoxFechaVenci);
            Controls.Add(label3);
            Controls.Add(textBoxDescripcion);
            Controls.Add(label2);
            Controls.Add(textBoxNombre);
            Controls.Add(label1);
            Name = "AgregarTareas";
            Text = "AgregarTareas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNombre;
        private TextBox textBoxDescripcion;
        private Label label2;
        private TextBox textBoxFechaVenci;
        private Label label3;
        private TextBox textBoxEstado;
        private Label label4;
        private Button buttonAgregarTareas;
    }
}
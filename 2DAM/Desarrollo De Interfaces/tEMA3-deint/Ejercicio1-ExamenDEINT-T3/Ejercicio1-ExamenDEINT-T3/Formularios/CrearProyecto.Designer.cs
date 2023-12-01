namespace Ejercicio1_ExamenDEINT_T3.Formularios
{
    partial class CrearProyecto
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
            label3 = new Label();
            textBoxFechaInicio = new TextBox();
            buttonCrear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(320, 42);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(320, 74);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(164, 23);
            textBoxNombre.TabIndex = 1;
            textBoxNombre.Validating += textBoxNombre_Validating;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(320, 145);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(164, 23);
            textBoxDescripcion.TabIndex = 3;
            textBoxDescripcion.Validating += textBoxDescripcion_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(320, 113);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 187);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha Inicio";
            // 
            // textBoxFechaInicio
            // 
            textBoxFechaInicio.Location = new Point(320, 225);
            textBoxFechaInicio.Name = "textBoxFechaInicio";
            textBoxFechaInicio.Size = new Size(164, 23);
            textBoxFechaInicio.TabIndex = 5;
            textBoxFechaInicio.Validating += textBoxFechaInicio_Validating;
            // 
            // buttonCrear
            // 
            buttonCrear.Location = new Point(330, 288);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(141, 47);
            buttonCrear.TabIndex = 6;
            buttonCrear.Text = "CREAR";
            buttonCrear.UseVisualStyleBackColor = true;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // CrearProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCrear);
            Controls.Add(textBoxFechaInicio);
            Controls.Add(label3);
            Controls.Add(textBoxDescripcion);
            Controls.Add(label2);
            Controls.Add(textBoxNombre);
            Controls.Add(label1);
            Name = "CrearProyecto";
            Text = "CrearProyecto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNombre;
        private TextBox textBoxDescripcion;
        private Label label2;
        private Label label3;
        private TextBox textBoxFechaInicio;
        private Button buttonCrear;
    }
}
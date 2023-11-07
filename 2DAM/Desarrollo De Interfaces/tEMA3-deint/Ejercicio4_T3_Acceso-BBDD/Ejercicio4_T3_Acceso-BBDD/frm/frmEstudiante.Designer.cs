namespace Ejercicio4_T3_Acceso_BBDD.frm
{
    partial class frmEstudiante
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
            imagen = new PictureBox();
            dataGridView1 = new DataGridView();
            buttonExaminar = new Button();
            labelClave = new Label();
            labelNombre = new Label();
            label1Apellido = new Label();
            textBoxClave = new TextBox();
            textBoxNombre = new TextBox();
            label2Apellido = new Label();
            textBox1Apellido = new TextBox();
            textBox2Apellido = new TextBox();
            labelCorreo = new Label();
            labelCiclo = new Label();
            textBoxCorreo = new TextBox();
            textBoxCiclo = new TextBox();
            buttonApagar = new Button();
            buttonModificar = new Button();
            buttonBorrar = new Button();
            buttonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)imagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // imagen
            // 
            imagen.Location = new Point(33, 15);
            imagen.Name = "imagen";
            imagen.Size = new Size(139, 221);
            imagen.TabIndex = 0;
            imagen.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(70, 316);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(673, 122);
            dataGridView1.TabIndex = 1;
            // 
            // buttonExaminar
            // 
            buttonExaminar.Location = new Point(33, 276);
            buttonExaminar.Name = "buttonExaminar";
            buttonExaminar.Size = new Size(139, 23);
            buttonExaminar.TabIndex = 2;
            buttonExaminar.Text = "Examinar";
            buttonExaminar.UseVisualStyleBackColor = true;
            buttonExaminar.Click += button1_Click;
            // 
            // labelClave
            // 
            labelClave.AutoSize = true;
            labelClave.Location = new Point(230, 24);
            labelClave.Name = "labelClave";
            labelClave.Size = new Size(36, 15);
            labelClave.TabIndex = 3;
            labelClave.Text = "Clave";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(416, 24);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 4;
            labelNombre.Text = "Nombre";
            // 
            // label1Apellido
            // 
            label1Apellido.AutoSize = true;
            label1Apellido.Location = new Point(230, 99);
            label1Apellido.Name = "label1Apellido";
            label1Apellido.Size = new Size(89, 15);
            label1Apellido.TabIndex = 5;
            label1Apellido.Text = "Primer Apellido";
            // 
            // textBoxClave
            // 
            textBoxClave.Location = new Point(230, 54);
            textBoxClave.Name = "textBoxClave";
            textBoxClave.Size = new Size(100, 23);
            textBoxClave.TabIndex = 6;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(416, 54);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(285, 23);
            textBoxNombre.TabIndex = 7;
            // 
            // label2Apellido
            // 
            label2Apellido.AutoSize = true;
            label2Apellido.Location = new Point(416, 99);
            label2Apellido.Name = "label2Apellido";
            label2Apellido.Size = new Size(101, 15);
            label2Apellido.TabIndex = 8;
            label2Apellido.Text = "Segundo Apellido";
            // 
            // textBox1Apellido
            // 
            textBox1Apellido.Location = new Point(230, 135);
            textBox1Apellido.Name = "textBox1Apellido";
            textBox1Apellido.Size = new Size(170, 23);
            textBox1Apellido.TabIndex = 9;
            // 
            // textBox2Apellido
            // 
            textBox2Apellido.Location = new Point(416, 135);
            textBox2Apellido.Name = "textBox2Apellido";
            textBox2Apellido.Size = new Size(220, 23);
            textBox2Apellido.TabIndex = 10;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(230, 177);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(43, 15);
            labelCorreo.TabIndex = 11;
            labelCorreo.Text = "Correo";
            // 
            // labelCiclo
            // 
            labelCiclo.AutoSize = true;
            labelCiclo.Location = new Point(230, 221);
            labelCiclo.Name = "labelCiclo";
            labelCiclo.Size = new Size(34, 15);
            labelCiclo.TabIndex = 12;
            labelCiclo.Text = "Ciclo";
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(230, 195);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(406, 23);
            textBoxCorreo.TabIndex = 13;
            // 
            // textBoxCiclo
            // 
            textBoxCiclo.Location = new Point(230, 239);
            textBoxCiclo.Name = "textBoxCiclo";
            textBoxCiclo.Size = new Size(406, 23);
            textBoxCiclo.TabIndex = 14;
            // 
            // buttonApagar
            // 
            buttonApagar.Location = new Point(230, 276);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(75, 23);
            buttonApagar.TabIndex = 15;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(334, 276);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 23);
            buttonModificar.TabIndex = 16;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Location = new Point(431, 276);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(75, 23);
            buttonBorrar.TabIndex = 17;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(529, 276);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 18;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // frmEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonBorrar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonApagar);
            Controls.Add(textBoxCiclo);
            Controls.Add(textBoxCorreo);
            Controls.Add(labelCiclo);
            Controls.Add(labelCorreo);
            Controls.Add(textBox2Apellido);
            Controls.Add(textBox1Apellido);
            Controls.Add(label2Apellido);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxClave);
            Controls.Add(label1Apellido);
            Controls.Add(labelNombre);
            Controls.Add(labelClave);
            Controls.Add(buttonExaminar);
            Controls.Add(dataGridView1);
            Controls.Add(imagen);
            Name = "frmEstudiante";
            Text = "frmEstudiante";
            ((System.ComponentModel.ISupportInitialize)imagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imagen;
        private DataGridView dataGridView1;
        private Button buttonExaminar;
        private Label labelClave;
        private Label labelNombre;
        private Label label1Apellido;
        private TextBox textBoxClave;
        private TextBox textBoxNombre;
        private Label label2Apellido;
        private TextBox textBox1Apellido;
        private TextBox textBox2Apellido;
        private Label labelCorreo;
        private Label labelCiclo;
        private TextBox textBoxCorreo;
        private TextBox textBoxCiclo;
        private Button buttonApagar;
        private Button buttonModificar;
        private Button buttonBorrar;
        private Button buttonCancelar;
    }
}
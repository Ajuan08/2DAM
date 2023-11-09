namespace Ejercicio4_T3_Acceso_BBDD.frm
{
    partial class frmCiclo
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
            labelID = new Label();
            labelNombreCiclo = new Label();
            textBoxID = new TextBox();
            textBoxNombreCiclo = new TextBox();
            buttonAgregar = new Button();
            buttonModificar = new Button();
            buttonBorrar = new Button();
            buttonCancelar = new Button();
            dataGridViewCiclo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCiclo).BeginInit();
            SuspendLayout();
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(31, 25);
            labelID.Name = "labelID";
            labelID.Size = new Size(18, 15);
            labelID.TabIndex = 0;
            labelID.Text = "ID";
            // 
            // labelNombreCiclo
            // 
            labelNombreCiclo.AutoSize = true;
            labelNombreCiclo.Location = new Point(217, 25);
            labelNombreCiclo.Name = "labelNombreCiclo";
            labelNombreCiclo.Size = new Size(84, 15);
            labelNombreCiclo.TabIndex = 1;
            labelNombreCiclo.Text = "Nombre Ciclo:";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(31, 54);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 2;
            // 
            // textBoxNombreCiclo
            // 
            textBoxNombreCiclo.Location = new Point(217, 54);
            textBoxNombreCiclo.Name = "textBoxNombreCiclo";
            textBoxNombreCiclo.Size = new Size(379, 23);
            textBoxNombreCiclo.TabIndex = 3;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(40, 101);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(91, 27);
            buttonAgregar.TabIndex = 4;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(197, 101);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(91, 27);
            buttonModificar.TabIndex = 5;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Location = new Point(339, 101);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(91, 27);
            buttonBorrar.TabIndex = 6;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(471, 101);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(91, 27);
            buttonCancelar.TabIndex = 7;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // dataGridViewCiclo
            // 
            dataGridViewCiclo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCiclo.Location = new Point(45, 157);
            dataGridViewCiclo.Name = "dataGridViewCiclo";
            dataGridViewCiclo.RowTemplate.Height = 25;
            dataGridViewCiclo.Size = new Size(564, 256);
            dataGridViewCiclo.TabIndex = 8;
            // 
            // frmCiclo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewCiclo);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonBorrar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonAgregar);
            Controls.Add(textBoxNombreCiclo);
            Controls.Add(textBoxID);
            Controls.Add(labelNombreCiclo);
            Controls.Add(labelID);
            Name = "frmCiclo";
            Text = "frmCiclo";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCiclo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelID;
        private Label labelNombreCiclo;
        private TextBox textBoxID;
        private TextBox textBoxNombreCiclo;
        private Button buttonAgregar;
        private Button buttonModificar;
        private Button buttonBorrar;
        private Button buttonCancelar;
        private DataGridView dataGridViewCiclo;
    }
}
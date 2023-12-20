namespace ExamenRecuDEINT
{
    partial class CRUDLibrosForm
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
            textBoxISBN = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxTitulo = new TextBox();
            label3 = new Label();
            textBoxAutor = new TextBox();
            label4 = new Label();
            textBoxAno_Publi = new TextBox();
            label5 = new Label();
            textBoxEditorial = new TextBox();
            buttonAgregar = new Button();
            buttonModificar = new Button();
            buttonBorrar = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            textBoxGenero = new TextBox();
            buttonListadoEditorial = new Button();
            buttonBusquedaGenero = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(37, 60);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(100, 23);
            textBoxISBN.TabIndex = 0;
            textBoxISBN.TextChanged += textBoxISBN_TextChanged;
            textBoxISBN.Validating += textBoxISBN_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 42);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 1;
            label1.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 101);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "Titulo";
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(37, 119);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(100, 23);
            textBoxTitulo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 198);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "Autor";
            // 
            // textBoxAutor
            // 
            textBoxAutor.Location = new Point(37, 216);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(100, 23);
            textBoxAutor.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 251);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 7;
            label4.Text = "Año_Publicacion";
            // 
            // textBoxAno_Publi
            // 
            textBoxAno_Publi.Location = new Point(37, 269);
            textBoxAno_Publi.Name = "textBoxAno_Publi";
            textBoxAno_Publi.Size = new Size(100, 23);
            textBoxAno_Publi.TabIndex = 6;
            textBoxAno_Publi.TextChanged += textBoxAno_Publi_TextChanged;
            textBoxAno_Publi.Validating += textBoxAno_Publi_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 309);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 9;
            label5.Text = "Editorial";
            // 
            // textBoxEditorial
            // 
            textBoxEditorial.Location = new Point(37, 327);
            textBoxEditorial.Name = "textBoxEditorial";
            textBoxEditorial.Size = new Size(100, 23);
            textBoxEditorial.TabIndex = 8;
            textBoxEditorial.Validating += textBoxEditorial_Validating;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(303, 342);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 23);
            buttonAgregar.TabIndex = 10;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(424, 342);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 23);
            buttonModificar.TabIndex = 11;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Location = new Point(542, 342);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(75, 23);
            buttonBorrar.TabIndex = 12;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(279, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(384, 216);
            dataGridView1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 154);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 15;
            label6.Text = "Genero";
            // 
            // textBoxGenero
            // 
            textBoxGenero.Location = new Point(37, 172);
            textBoxGenero.Name = "textBoxGenero";
            textBoxGenero.Size = new Size(100, 23);
            textBoxGenero.TabIndex = 14;
            // 
            // buttonListadoEditorial
            // 
            buttonListadoEditorial.Location = new Point(303, 392);
            buttonListadoEditorial.Name = "buttonListadoEditorial";
            buttonListadoEditorial.Size = new Size(141, 23);
            buttonListadoEditorial.TabIndex = 16;
            buttonListadoEditorial.Text = "Listado Por Editorial";
            buttonListadoEditorial.UseVisualStyleBackColor = true;
            buttonListadoEditorial.Click += buttonListadoEditorial_Click;
            // 
            // buttonBusquedaGenero
            // 
            buttonBusquedaGenero.Location = new Point(476, 392);
            buttonBusquedaGenero.Name = "buttonBusquedaGenero";
            buttonBusquedaGenero.Size = new Size(141, 23);
            buttonBusquedaGenero.TabIndex = 17;
            buttonBusquedaGenero.Text = "Busqueda Por Genero";
            buttonBusquedaGenero.UseVisualStyleBackColor = true;
            buttonBusquedaGenero.Click += buttonBusquedaGenero_Click;
            // 
            // CRUDLibrosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBusquedaGenero);
            Controls.Add(buttonListadoEditorial);
            Controls.Add(label6);
            Controls.Add(textBoxGenero);
            Controls.Add(dataGridView1);
            Controls.Add(buttonBorrar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonAgregar);
            Controls.Add(label5);
            Controls.Add(textBoxEditorial);
            Controls.Add(label4);
            Controls.Add(textBoxAno_Publi);
            Controls.Add(label3);
            Controls.Add(textBoxAutor);
            Controls.Add(label2);
            Controls.Add(textBoxTitulo);
            Controls.Add(label1);
            Controls.Add(textBoxISBN);
            Name = "CRUDLibrosForm";
            Text = "CRUDLibrosForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxISBN;
        private Label label1;
        private Label label2;
        private TextBox textBoxTitulo;
        private Label label3;
        private TextBox textBoxAutor;
        private Label label4;
        private TextBox textBoxAno_Publi;
        private Label label5;
        private TextBox textBoxEditorial;
        private Button buttonAgregar;
        private Button buttonModificar;
        private Button buttonBorrar;
        private DataGridView dataGridView1;
        private Label label6;
        private TextBox textBoxGenero;
        private Button buttonListadoEditorial;
        private Button buttonBusquedaGenero;
    }
}
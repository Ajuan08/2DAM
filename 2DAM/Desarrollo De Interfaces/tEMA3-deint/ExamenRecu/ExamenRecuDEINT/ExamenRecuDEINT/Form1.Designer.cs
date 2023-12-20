namespace ExamenRecuDEINT
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
            buttonCRUDLibros = new Button();
            buttonCRUDEditorial = new Button();
            SuspendLayout();
            // 
            // buttonCRUDLibros
            // 
            buttonCRUDLibros.Location = new Point(182, 184);
            buttonCRUDLibros.Name = "buttonCRUDLibros";
            buttonCRUDLibros.Size = new Size(127, 45);
            buttonCRUDLibros.TabIndex = 0;
            buttonCRUDLibros.Text = "CRUD Libros";
            buttonCRUDLibros.UseVisualStyleBackColor = true;
            buttonCRUDLibros.Click += buttonCRUDLibros_Click;
            // 
            // buttonCRUDEditorial
            // 
            buttonCRUDEditorial.Location = new Point(417, 184);
            buttonCRUDEditorial.Name = "buttonCRUDEditorial";
            buttonCRUDEditorial.Size = new Size(127, 45);
            buttonCRUDEditorial.TabIndex = 1;
            buttonCRUDEditorial.Text = "CRUD Editorial";
            buttonCRUDEditorial.UseVisualStyleBackColor = true;
            buttonCRUDEditorial.Click += buttonCRUDEditorial_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCRUDEditorial);
            Controls.Add(buttonCRUDLibros);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCRUDLibros;
        private Button buttonCRUDEditorial;
    }
}

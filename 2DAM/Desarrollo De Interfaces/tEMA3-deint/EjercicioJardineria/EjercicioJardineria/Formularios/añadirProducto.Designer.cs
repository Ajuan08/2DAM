namespace EjercicioJardineria.Formularios
{
    partial class añadirProducto
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
            textBoxCodProd = new TextBox();
            label2 = new Label();
            textBoxNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxDimensiones = new TextBox();
            textBoxProveedor = new TextBox();
            textBoxDescripcion = new TextBox();
            textBoxCantStock = new TextBox();
            textBoxPrecioVenta = new TextBox();
            textBoxPrecioProveedor = new TextBox();
            buttonAñadirProducto = new Button();
            comboBoxGama = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 48);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Código_Producto*";
            label1.Click += label1_Click;
            // 
            // textBoxCodProd
            // 
            textBoxCodProd.Location = new Point(41, 79);
            textBoxCodProd.Name = "textBoxCodProd";
            textBoxCodProd.Size = new Size(120, 23);
            textBoxCodProd.TabIndex = 1;
            textBoxCodProd.TextChanged += textBoxCodProd_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 48);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre*";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(229, 79);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(120, 23);
            textBoxNombre.TabIndex = 3;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(420, 48);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Gama*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 153);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 7;
            label4.Text = "Dimensiones";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(229, 153);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 8;
            label5.Text = "Proveedor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(420, 153);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 9;
            label6.Text = "Descripcion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 258);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 10;
            label7.Text = "Cantidad Stock*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(229, 258);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 11;
            label8.Text = "Precio_Venta*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(414, 258);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 12;
            label9.Text = "Precio_Proveedor";
            // 
            // textBoxDimensiones
            // 
            textBoxDimensiones.Location = new Point(41, 198);
            textBoxDimensiones.Name = "textBoxDimensiones";
            textBoxDimensiones.Size = new Size(120, 23);
            textBoxDimensiones.TabIndex = 13;
            textBoxDimensiones.TextChanged += textBoxDimensiones_TextChanged;
            // 
            // textBoxProveedor
            // 
            textBoxProveedor.Location = new Point(229, 198);
            textBoxProveedor.Name = "textBoxProveedor";
            textBoxProveedor.Size = new Size(120, 23);
            textBoxProveedor.TabIndex = 14;
            textBoxProveedor.TextChanged += textBoxProveedor_TextChanged;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(420, 198);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(120, 23);
            textBoxDescripcion.TabIndex = 15;
            textBoxDescripcion.TextChanged += textBoxDescripcion_TextChanged;
            // 
            // textBoxCantStock
            // 
            textBoxCantStock.Location = new Point(41, 301);
            textBoxCantStock.Name = "textBoxCantStock";
            textBoxCantStock.Size = new Size(120, 23);
            textBoxCantStock.TabIndex = 16;
            textBoxCantStock.TextChanged += textBoxCantStock_TextChanged;
            // 
            // textBoxPrecioVenta
            // 
            textBoxPrecioVenta.Location = new Point(229, 301);
            textBoxPrecioVenta.Name = "textBoxPrecioVenta";
            textBoxPrecioVenta.Size = new Size(120, 23);
            textBoxPrecioVenta.TabIndex = 17;
            textBoxPrecioVenta.TextChanged += textBoxPrecioVenta_TextChanged;
            // 
            // textBoxPrecioProveedor
            // 
            textBoxPrecioProveedor.Location = new Point(414, 301);
            textBoxPrecioProveedor.Name = "textBoxPrecioProveedor";
            textBoxPrecioProveedor.Size = new Size(120, 23);
            textBoxPrecioProveedor.TabIndex = 18;
            textBoxPrecioProveedor.TextChanged += textBoxPrecioProveedor_TextChanged;
            // 
            // buttonAñadirProducto
            // 
            buttonAñadirProducto.Location = new Point(573, 334);
            buttonAñadirProducto.Name = "buttonAñadirProducto";
            buttonAñadirProducto.Size = new Size(202, 71);
            buttonAñadirProducto.TabIndex = 19;
            buttonAñadirProducto.Text = "AÑADIR PRODUCTO";
            buttonAñadirProducto.UseVisualStyleBackColor = true;
            buttonAñadirProducto.Click += buttonAñadirProducto_Click;
            // 
            // comboBoxGama
            // 
            comboBoxGama.FormattingEnabled = true;
            comboBoxGama.Location = new Point(419, 79);
            comboBoxGama.Name = "comboBoxGama";
            comboBoxGama.Size = new Size(121, 23);
            comboBoxGama.TabIndex = 20;
            comboBoxGama.SelectedIndexChanged += comboBoxGama_SelectedIndexChanged;
            // 
            // añadirProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxGama);
            Controls.Add(buttonAñadirProducto);
            Controls.Add(textBoxPrecioProveedor);
            Controls.Add(textBoxPrecioVenta);
            Controls.Add(textBoxCantStock);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxProveedor);
            Controls.Add(textBoxDimensiones);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxNombre);
            Controls.Add(label2);
            Controls.Add(textBoxCodProd);
            Controls.Add(label1);
            Name = "añadirProducto";
            Text = "añadirProducto";
            Load += añadirProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxCodProd;
        private Label label2;
        private TextBox textBoxNombre;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxDimensiones;
        private TextBox textBoxProveedor;
        private TextBox textBoxDescripcion;
        private TextBox textBoxCantStock;
        private TextBox textBoxPrecioVenta;
        private TextBox textBoxPrecioProveedor;
        private Button buttonAñadirProducto;
        private ComboBox comboBoxGama;
    }
}
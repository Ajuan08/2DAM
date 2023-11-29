namespace EjercicioJardineria
{
    partial class FormPrincipal
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
            añadirProductos = new Button();
            eliminarGama = new Button();
            consultarPedidosEntregados = new Button();
            consultarEmpleadosJefeDeterminado = new Button();
            consultarClientesNoPagan = new Button();
            consultarPrecioMasCaroYBarato = new Button();
            SuspendLayout();
            // 
            // añadirProductos
            // 
            añadirProductos.Location = new Point(57, 98);
            añadirProductos.Name = "añadirProductos";
            añadirProductos.Size = new Size(151, 56);
            añadirProductos.TabIndex = 0;
            añadirProductos.Text = "AñadirProductos";
            añadirProductos.UseVisualStyleBackColor = true;
            añadirProductos.Click += añadirProductos_Click;
            // 
            // eliminarGama
            // 
            eliminarGama.Location = new Point(306, 98);
            eliminarGama.Name = "eliminarGama";
            eliminarGama.Size = new Size(151, 56);
            eliminarGama.TabIndex = 1;
            eliminarGama.Text = "Eliminar Gama";
            eliminarGama.UseVisualStyleBackColor = true;
            eliminarGama.Click += eliminarGama_Click;
            // 
            // consultarPedidosEntregados
            // 
            consultarPedidosEntregados.Location = new Point(538, 98);
            consultarPedidosEntregados.Name = "consultarPedidosEntregados";
            consultarPedidosEntregados.Size = new Size(151, 56);
            consultarPedidosEntregados.TabIndex = 2;
            consultarPedidosEntregados.Text = "Consultar Pedidos Entregados";
            consultarPedidosEntregados.UseVisualStyleBackColor = true;
            consultarPedidosEntregados.Click += consultarPedidosEntregados_Click;
            // 
            // consultarEmpleadosJefeDeterminado
            // 
            consultarEmpleadosJefeDeterminado.Location = new Point(57, 228);
            consultarEmpleadosJefeDeterminado.Name = "consultarEmpleadosJefeDeterminado";
            consultarEmpleadosJefeDeterminado.Size = new Size(151, 56);
            consultarEmpleadosJefeDeterminado.TabIndex = 3;
            consultarEmpleadosJefeDeterminado.Text = "Consultar empleados de un jefe determinado";
            consultarEmpleadosJefeDeterminado.UseVisualStyleBackColor = true;
            // 
            // consultarClientesNoPagan
            // 
            consultarClientesNoPagan.Location = new Point(306, 228);
            consultarClientesNoPagan.Name = "consultarClientesNoPagan";
            consultarClientesNoPagan.Size = new Size(151, 56);
            consultarClientesNoPagan.TabIndex = 4;
            consultarClientesNoPagan.Text = "Consultar Clientes que no pagan";
            consultarClientesNoPagan.UseVisualStyleBackColor = true;
            consultarClientesNoPagan.Click += consultarClientesNoPagan_Click;
            // 
            // consultarPrecioMasCaroYBarato
            // 
            consultarPrecioMasCaroYBarato.Location = new Point(538, 228);
            consultarPrecioMasCaroYBarato.Name = "consultarPrecioMasCaroYBarato";
            consultarPrecioMasCaroYBarato.Size = new Size(151, 56);
            consultarPrecioMasCaroYBarato.TabIndex = 5;
            consultarPrecioMasCaroYBarato.Text = "Consultar Precio del producto mas caro y mas barato";
            consultarPrecioMasCaroYBarato.UseVisualStyleBackColor = true;
            consultarPrecioMasCaroYBarato.Click += consultarPrecioMasCaroYBarato_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(consultarPrecioMasCaroYBarato);
            Controls.Add(consultarClientesNoPagan);
            Controls.Add(consultarEmpleadosJefeDeterminado);
            Controls.Add(consultarPedidosEntregados);
            Controls.Add(eliminarGama);
            Controls.Add(añadirProductos);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button añadirProductos;
        private Button eliminarGama;
        private Button consultarPedidosEntregados;
        private Button consultarEmpleadosJefeDeterminado;
        private Button consultarClientesNoPagan;
        private Button consultarPrecioMasCaroYBarato;
    }
}
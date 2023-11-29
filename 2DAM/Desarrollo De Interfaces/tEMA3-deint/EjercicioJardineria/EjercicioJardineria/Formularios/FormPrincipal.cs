﻿using EjercicioJardineria.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioJardineria
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void añadirProductos_Click(object sender, EventArgs e)
        {
            new añadirProducto().ShowDialog();
        }

        private void eliminarGama_Click(object sender, EventArgs e)
        {
            new EliminarGama().ShowDialog();
        }
    }
}

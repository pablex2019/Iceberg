﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICEBERG.Presentacion.Presentadores;
using ICEBERG.Presentacion.Interfaces;

namespace ICEBERG.Presentacion.Vistas.Proveedor
{
    public partial class Nuevo : Form, IProveedor
    {
        private readonly ProveedorPresentador proveedorPresentador;

        public Nuevo()
        {
            InitializeComponent();
            proveedorPresentador = new ProveedorPresentador(this);
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            proveedorPresentador.AgregarProveedor(this);
        }
    }
}

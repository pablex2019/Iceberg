using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICEBERG.Presentacion.Interfaces;
using ICEBERG.Presentacion.Presentadores;

namespace ICEBERG.Presentacion.Vistas.Proveedor
{
    public partial class Inicio : Form, IProveedor
    {
        public int id;
        private readonly ProveedorPresentador proveedorPresentador;

        public Inicio()
        {
            InitializeComponent();
            proveedorPresentador = new ProveedorPresentador(this);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Vistas.Proveedor.Nuevo nuevo = new Nuevo();
            nuevo.ShowDialog();
            bindingSource1.DataSource = proveedorPresentador.Listado();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                Vistas.Proveedor.Editar Editar = new Vistas.Proveedor.Editar();
                Editar.id = id;
                Editar.BindingSource = bindingSource1;
                Editar.ShowDialog();
            }
            else
            {
                MostrarMensaje("Debe seleccionar un registro");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            proveedorPresentador.EliminarProveedor(id);
            bindingSource1.DataSource = proveedorPresentador.Listado();
        }

        public void MostrarMensaje(string mensaje)
        {
            if (!string.IsNullOrEmpty(mensaje)) { MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = proveedorPresentador.Listado();
        }
    }
}

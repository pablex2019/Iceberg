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
    public partial class Editar : Form, IProveedor
    {
        public int id;
        public BindingSource BindingSource;

        private readonly ProveedorPresentador proveedorPresentador;

        public Editar()
        {
            InitializeComponent();
            proveedorPresentador = new ProveedorPresentador(this);
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            var proveedor = proveedorPresentador.ObtenerProveedor(id);
            txtRazonSocial.Text = proveedor.RazonSocial;
            txtCuit.Text = proveedor.Cuit;
            txtCuil.Text = proveedor.Cuil;
            txtDni.Text = proveedor.Dni.ToString();
            txtNombres.Text = proveedor.Nombre;
            txtApellidos.Text = proveedor.Apellido;
            txtDomicilio.Text = proveedor.Domicilio;
            txtCorreoElectronico.Text = proveedor.CorreoElectronico;
            txtTelefonoFijo.Text = proveedor.TelefonoFijo.ToString();
            txtCelular.Text = proveedor.Celular.ToString();
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
            proveedorPresentador.EditarProveedor(this, id);
            BindingSource.DataSource = proveedorPresentador.Listado();
        }
    }
}

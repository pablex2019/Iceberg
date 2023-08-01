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

namespace ICEBERG.Presentacion.Vistas.Cliente
{
    public partial class Editar : Form, ICliente
    {
        public int id;
        public BindingSource BindingSource;

        private readonly ClientePresentador clientePresentador;

        public Editar()
        {
            InitializeComponent();
            clientePresentador = new ClientePresentador(this);
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clientePresentador.EditarCliente(this,id);
            BindingSource.DataSource = clientePresentador.Listado();
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            var cliente = clientePresentador.ObtenerCliente(id);
            txtDni.Text = cliente.Dni.ToString();
            txtNombres.Text = cliente.Nombre;
            txtApellidos.Text = cliente.Apellido;
            txtDomicilio.Text = cliente.Domicilio;
            txtTelefonoFijo.Text = cliente.TelefonoFijo.ToString();
            txtCelular.Text = cliente.Celular.ToString();
            txtCorreoElectronico.Text = cliente.CorreoElectronico;
            txtSaldoDeudor.Text = cliente.SaldoDeudor.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

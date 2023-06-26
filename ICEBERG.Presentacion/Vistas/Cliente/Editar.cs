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
        private ClientePresentador clientePresentador;

        public Editar()
        {
            InitializeComponent();
            clientePresentador = new ClientePresentador(null);
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clientePresentador.EditarCliente(this,id);
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            var cliente = clientePresentador.ObtenerCliente(id);
            txtNombres.Text = cliente.Nombres;
            txtApellidos.Text = cliente.Apellidos;
            txtDomicilio.Text = cliente.Domicilio;
            txtDNI.Text = cliente.DNI.ToString();
            txtTelefonoFijo.Text = cliente.TelefonoFijo.ToString();
            txtCelular.Text = cliente.Celular.ToString();
            txtCorreoElectronico.Text = cliente.CorreoElectronico;
            txtSaldoDeudor.Text = cliente.SaldoDeudor.ToString();
        }
    }
}

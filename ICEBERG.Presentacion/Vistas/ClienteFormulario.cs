using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICEBERG.Presentacion.Interfaces;
using ICEBERG.Presentacion.Modelos;
using ICEBERG.Presentacion.Presentadores;

namespace ICEBERG.Presentacion.Vistas
{
    public partial class ClienteFormulario : Form,ICliente
    {
        private ClientePresentador ClientePresentador;

        public ClienteFormulario()
        {
            InitializeComponent();
            ClientePresentador = new ClientePresentador(this);
        }

        public event EventHandler AgregarClienteClicked;


        public string Nombres { get { return txtNombre.Text; } set { txtNombre.Text = value; } }
        public string Apellidos { get { return txtApellido.Text; } set { txtApellido.Text = value; } }
        public string Domicilio { get { return txtDomicilio.Text; } set { txtDomicilio.Text = value; } }
        public int TelefonoFijo { get { return Convert.ToInt32(txtTelefonoFijo.Text); } set { txtTelefonoFijo.Text = this.txtTelefonoFijo.Text; } }
        public int Celular { get { return Convert.ToInt32(txtCelular.Text); } set { txtCelular.Text = txtCelular.Text; } }
        public string CorreoElectronico { get { return txtCorreoElectronico.Text; } set { txtCorreoElectronico.Text = value; } }
        public float SaldoDeudor { get { return float.Parse(txtSaldoDeudor.Text); } set { txtSaldoDeudor.Text = txtSaldoDeudor.Text; } }
        public void MostrarMensaje(string mensaje) { MessageBox.Show(mensaje);}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AgregarClienteClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

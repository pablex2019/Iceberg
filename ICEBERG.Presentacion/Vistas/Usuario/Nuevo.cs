using System;
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

namespace ICEBERG.Presentacion.Vistas.Usuario
{
    public partial class Nuevo : Form,IUsuario
    {
        private readonly UsuarioPresentador usuarioPresentador;

        public Nuevo()
        {
            InitializeComponent();
            usuarioPresentador = new UsuarioPresentador(this);
        }

        private void Nuevo_Load(object sender, EventArgs e)
        {
            cboDnis.DataSource = usuarioPresentador.ObtenerDniEmpleados();
            cboPerfiles.DataSource = usuarioPresentador.ObtenerPerfiles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            usuarioPresentador.AgregarUsuario(this);
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cboDnis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDnis.Text != "Seleccione")
            {
                var _empleado = usuarioPresentador.ObtenerEmpleadosSeleccionado(cboDnis.Text);
                txtApellidoyNombre.Text = _empleado.Apellido + ", " + _empleado.Nombre;
                txtLegajo.Text = _empleado.Legajo.ToString();
            }
        }
    }
}

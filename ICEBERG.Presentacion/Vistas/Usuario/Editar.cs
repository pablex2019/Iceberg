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

namespace ICEBERG.Presentacion.Vistas.Usuario
{
    public partial class Editar : Form, IUsuario
    {
        public int id;
        public List<string> _dnis;
        public List<string> _perfiles;
        public BindingSource BindingSource;

        private readonly UsuarioPresentador usuarioPresentador;

        public Editar()
        {
            InitializeComponent();
            usuarioPresentador = new UsuarioPresentador(this);
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
            usuarioPresentador.EditarUsuario(this, id);
            BindingSource.DataSource = usuarioPresentador.Listado();
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            var usuario = usuarioPresentador.ObtenerUsuario(id);
            cboDnis.DataSource = _dnis;
            cboPerfiles.DataSource = _perfiles;
            cboDnis.SelectedItem = usuario.Empleado.Dni;
            cboPerfiles.SelectedItem = usuario.Perfil.Descripción;
            txtApellidoyNombre.Text = usuario.Empleado.Apellido+", "+usuario.Empleado.Nombre;
            txtLegajo.Text = usuario.Empleado.Legajo.ToString();
            txtUsuario.Text = usuario.Nombre.ToString();
            txtClave.Text = usuario.Clave;
        }
    }
}

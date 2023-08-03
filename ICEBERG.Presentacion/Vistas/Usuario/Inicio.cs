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
    public partial class Inicio : Form, IUsuario
    {
        public int id;
        private readonly UsuarioPresentador usuarioPresentador;

        public Inicio()
        {
            InitializeComponent();
            usuarioPresentador = new UsuarioPresentador(this);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Vistas.Usuario.Nuevo nuevo = new Nuevo();
            nuevo.ShowDialog();
            bindingSource1.DataSource = usuarioPresentador.Listado();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                Vistas.Usuario.Editar Editar = new Vistas.Usuario.Editar();
                Editar.id = id;
                Editar._dnis = usuarioPresentador.ObtenerDniEmpleados();
                Editar._perfiles = usuarioPresentador.ObtenerPerfiles();
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
            usuarioPresentador.EliminarUsuario(id);
            bindingSource1.DataSource = usuarioPresentador.Listado();
        }

        public void MostrarMensaje(string mensaje)
        {
            if (!string.IsNullOrEmpty(mensaje)) { MessageBox.Show(mensaje); }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = usuarioPresentador.Listado();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value == null ? 0 : Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}

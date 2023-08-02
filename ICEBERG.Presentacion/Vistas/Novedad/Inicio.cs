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

namespace ICEBERG.Presentacion.Vistas.Novedad
{
    public partial class Inicio : Form,INovedad
    {
        public int id;
        public string _usuario;
        private readonly NovedadPresentador novedadPresentador;

        public Inicio()
        {
            InitializeComponent();
            novedadPresentador = new NovedadPresentador(this);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Vistas.Novedad.Nuevo nuevo = new Nuevo();
            nuevo.usuario = _usuario;
            nuevo.ShowDialog();
            bindingSource1.DataSource = novedadPresentador.Listado();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                Vistas.Novedad.Editar Editar = new Vistas.Novedad.Editar();
                Editar.id = id;
                Editar.usuario = _usuario;
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
            novedadPresentador.EliminarNovedad(id);
            bindingSource1.DataSource = novedadPresentador.Listado();
        }

        public void MostrarMensaje(string mensaje)
        {
            if (!string.IsNullOrEmpty(mensaje)) { MessageBox.Show(mensaje); }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = novedadPresentador.Listado();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value == null ? 0 : Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}

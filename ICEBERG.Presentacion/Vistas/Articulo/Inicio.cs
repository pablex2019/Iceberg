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

namespace ICEBERG.Presentacion.Vistas.Articulo
{
    public partial class Inicio : Form,IArticulo
    {
        public int id;
        private readonly ArticuloPresentador articuloPresentador;

        public Inicio()
        {
            InitializeComponent();
            articuloPresentador = new ArticuloPresentador(this);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Vistas.Articulo.Nuevo nuevo = new Nuevo();
            nuevo.ShowDialog();
            bindingSource1.DataSource = articuloPresentador.Listado();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                Vistas.Articulo.Editar Editar = new Vistas.Articulo.Editar();
                Editar.id = id;
                Editar._categorias = articuloPresentador.ObtenerCategorias();
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
            articuloPresentador.EliminarArticulo(id);
            bindingSource1.DataSource = articuloPresentador.Listado();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = articuloPresentador.Listado();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value == null ? 0 : Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }

        public void MostrarMensaje(string mensaje)
        {
            if (!string.IsNullOrEmpty(mensaje)) { MessageBox.Show(mensaje); }
        }
    }
}

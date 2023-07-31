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

namespace ICEBERG.Presentacion.Vistas.Categoría
{
    public partial class Inicio : Form, ICategoría
    {
        public int id;
        private readonly CategoríaPresentador categoríaPresentador;

        public Inicio()
        {
            InitializeComponent();
            categoríaPresentador = new CategoríaPresentador(this);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Vistas.Categoría.Nuevo nuevo = new Nuevo();
            nuevo.ShowDialog();
            bindingSource1.DataSource = categoríaPresentador.Listado();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                Vistas.Categoría.Editar Editar = new Vistas.Categoría.Editar();
                Editar.id = id;
                Editar._rubros = categoríaPresentador.ObtenerRubros();
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
            categoríaPresentador.EliminarCategoría(id);
            bindingSource1.DataSource = categoríaPresentador.Listado();
        }

        public void MostrarMensaje(string mensaje)
        {
            if (!string.IsNullOrEmpty(mensaje)) { MessageBox.Show(mensaje); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value == null ? 0 : Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = categoríaPresentador.Listado();
        }
    }
}

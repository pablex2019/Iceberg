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

namespace ICEBERG.Presentacion.Vistas.Rubro
{
    public partial class Inicio : Form,IRubro
    {
        public int id;
        private readonly RubroPresentador rubroPresentador;

        public Inicio()
        {
            InitializeComponent();
            rubroPresentador = new RubroPresentador(this);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Vistas.Rubro.Nuevo nuevo = new Nuevo();
            nuevo.ShowDialog();
            bindingSource1.DataSource = rubroPresentador.Listado();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                Vistas.Rubro.Editar Editar = new Vistas.Rubro.Editar();
                Editar.id = id;
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
            rubroPresentador.EliminaRubro(id);
            bindingSource1.DataSource = rubroPresentador.Listado();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = rubroPresentador.Listado();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value == null ? 0 : Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }

        public void MostrarMensaje(string mensaje)
        {
            if (!string.IsNullOrEmpty(mensaje)) { MessageBox.Show(mensaje); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

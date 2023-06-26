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
    public partial class Index : Form,ICliente
    {
        public int id;
        private readonly ClientePresentador clientePresentador;

        public Index()
        {
            InitializeComponent();
            clientePresentador = new ClientePresentador(this);
        }

        public void MostrarMensaje(string mensaje)
        {
            if(!string.IsNullOrEmpty(mensaje)){ MessageBox.Show(mensaje); }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Vistas.Cliente.Nuevo nuevo = new Nuevo();
            nuevo.ShowDialog();
            bindingSource1.DataSource = clientePresentador.Listado();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = clientePresentador.Listado();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                Vistas.Cliente.Editar Editar = new Vistas.Cliente.Editar();
                Editar.id = id;
                Editar.ShowDialog();
            }
            else
            {
                MostrarMensaje("Debe seleccionar un registro");
            }
            bindingSource1.DataSource = clientePresentador.Listado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clientePresentador.EliminarCliente(id);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value == null ? 0 : Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}

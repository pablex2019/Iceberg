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

namespace ICEBERG.Presentacion.Vistas.Empleado
{
    public partial class Inicio : Form, IEmpleado
    {
        public int id;
        private readonly EmpleadoPresentador empleadoPresentador;

        public Inicio()
        {
            InitializeComponent();
            empleadoPresentador = new EmpleadoPresentador(this);
        }

        public void MostrarMensaje(string mensaje)
        {
            if (!string.IsNullOrEmpty(mensaje)) { MessageBox.Show(mensaje); }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Vistas.Empleado.Nuevo nuevo = new Nuevo();
            nuevo.ShowDialog();
            bindingSource1.DataSource = empleadoPresentador.Listado();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                Vistas.Empleado.Editar Editar = new Vistas.Empleado.Editar();
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
            empleadoPresentador.EliminarEmpleado(id);
            bindingSource1.DataSource = empleadoPresentador.Listado();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = empleadoPresentador.Listado();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value == null ? 0 : Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}

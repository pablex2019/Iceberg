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

namespace ICEBERG.Presentacion.Vistas.Pedido
{
    public partial class Nuevo : Form,IPedido
    {
        public int idArticulo;
        public string _usuario;
        private readonly PedidoPresentador pedidoPresentador;

        public Nuevo()
        {
            InitializeComponent();
            pedidoPresentador = new PedidoPresentador(this);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtApellidoyNombre.Text) && dataGridView2.Rows.Count>0)
            {
                pedidoPresentador.AgregarPedido(this);
            }
            else
            {
                MostrarMensaje("Debe seleccionar un cliente y/o agregar articulos al pedido");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCantidad.Text) && !string.IsNullOrEmpty(txtDescripción.Text))
            {
                double venta = 0.0;
                double costo = 0.0;
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = txtCodigo.Text;
                dataGridView2.Rows[n].Cells[1].Value = txtDescripción.Text;
                dataGridView2.Rows[n].Cells[2].Value = txtCantidad.Text;
                dataGridView2.Rows[n].Cells[3].Value = txtPrecioCosto.Text;
                dataGridView2.Rows[n].Cells[4].Value = txtPrecioPedido.Text;

                dataGridView2.Rows[n].Cells[5].Value = Convert.ToDouble(Convert.ToDouble(txtPrecioCosto.Text) * Convert.ToDouble(txtCantidad.Text));
                dataGridView2.Rows[n].Cells[6].Value = Convert.ToDouble(Convert.ToDouble(txtPrecioPedido.Text) * Convert.ToDouble(txtCantidad.Text));

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    string id = Convert.ToString(dataGridView2.Rows[i].Cells[0].Value);
                    string descripcion = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    double precioCosto = Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value);
                    double precioPedido = Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value);
                    double cantidad = Convert.ToDouble(dataGridView2.Rows[i].Cells[4].Value);
                    double subtotalCosto = Convert.ToDouble(dataGridView2.Rows[i].Cells[5].Value);
                    double subtotalVenta = Convert.ToDouble(dataGridView2.Rows[i].Cells[6].Value);
                    venta += subtotalVenta;
                    costo += subtotalCosto;
                }
                txtTotal.Text = venta.ToString();
                txtCosto.Text = costo.ToString();
            }
            else
            {
                MostrarMensaje("Debe ingresar una cantidad y/o seleccionar un articulo");
            }
            
        }

        private void Nuevo_Load(object sender, EventArgs e)
        {
            txtNumeroPedido.Text = pedidoPresentador.ObtenerNumeroPedido().ToString();
            txtEmpleado.Text = pedidoPresentador.ObtenerApellidoyNombreDelEmpleado(this);
            txtCodigo.Hide();
            cboClientes.DataSource = pedidoPresentador.ObtenerDniClientes();
            dgvArticulos.DataSource = pedidoPresentador.ObtenerArticulos();
            rbMenor.Checked=true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            double subtotal = 0.0;
            double costo = 0.0;
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.RemoveAt(item.Index);
            }
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                costo += Convert.ToInt32(dataGridView2.Rows[i].Cells[5].Value);
                subtotal += Convert.ToInt32(dataGridView2.Rows[i].Cells[6].Value);
            }
            txtTotal.Text = subtotal.ToString();
            txtCosto.Text = costo.ToString();
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClientes.Text != "Seleccione")
            {
                var _cliente = pedidoPresentador.ObtenerClienteSeleccionado(cboClientes.Text);
                txtApellidoyNombre.Text = _cliente.Apellido + ", " + _cliente.Nombre;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idArticulo = dgvArticulos.Rows[e.RowIndex].Cells[0].Value == null ? 0 : Convert.ToInt32(dgvArticulos.Rows[e.RowIndex].Cells[0].Value);
            if (idArticulo != 0)
            {
                txtCodigo.Text = dgvArticulos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripción.Text = dgvArticulos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrecioCosto.Text = dgvArticulos.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (rbMenor.Checked == true)
                {
                    txtPrecioPedido.Text = dgvArticulos.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
                else
                {
                    txtPrecioPedido.Text = dgvArticulos.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
            }
        }

        private void btnLineaDePedidos_Click(object sender, EventArgs e)
        {
            new Vistas.Pedido.LineaDePedido().ShowDialog();
        }

        private void btnFinalizarLineaDePedidos_Click(object sender, EventArgs e)
        {

        }
    }
}

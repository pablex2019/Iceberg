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
    public partial class LineaDePedido : Form,ILineaDePedido
    {
        private readonly LineaDePedidoPresentador lineaDePedidoPresentador;

        public LineaDePedido()
        {
            InitializeComponent();
            lineaDePedidoPresentador = new LineaDePedidoPresentador(this);
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LineaDePedido_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lineaDePedidoPresentador.ListadoLineaDePedidos();
        }
    }
}

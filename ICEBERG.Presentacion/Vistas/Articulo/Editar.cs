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
    public partial class Editar : Form, IArticulo
    {
        public int id;
        public List<string> _categorias;
        public BindingSource BindingSource;

        private readonly ArticuloPresentador articuloPresentador;

        public Editar()
        {
            InitializeComponent();
            articuloPresentador = new ArticuloPresentador(this);
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
            articuloPresentador.EditarArticulo(this, id);
            BindingSource.DataSource = articuloPresentador.Listado();
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            var articulo = articuloPresentador.ObtenerArticulo(id);
            cboCategorías.DataSource = _categorias;
            cboCategorías.SelectedItem = articulo.Categoría.Descripción;
            txtCodigo.Text = articulo.Codigo.ToString();
            txtDescripción.Text = articulo.Descripción;
            txtPrecioCosto.Text = articulo.PrecioCosto.ToString();
            txtPrecioPedidoPorMenor.Text = articulo.PrecioPedidoPorMenor.ToString();
            txtPrecioPedidoPorMayor.Text = articulo.PrecioPedidoPorMayor.ToString();
        }
    }
}

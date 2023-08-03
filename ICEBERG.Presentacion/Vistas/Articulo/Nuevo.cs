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

namespace ICEBERG.Presentacion.Vistas.Articulo
{
    public partial class Nuevo : Form, IArticulo
    {
        private readonly ArticuloPresentador articuloPresentador;

        public Nuevo()
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
            articuloPresentador.AgregarArticulo(this);
        }

        private void Nuevo_Load(object sender, EventArgs e)
        {
            cboCategorías.DataSource = articuloPresentador.ObtenerCategorias();
        }
    }
}

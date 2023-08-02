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

namespace ICEBERG.Presentacion.Vistas.Novedad
{
    public partial class Editar : Form, INovedad
    {
        public int id;
        public string usuario;
        public BindingSource BindingSource;


        private readonly NovedadPresentador novedadPresentador;

        public Editar()
        {
            InitializeComponent();
            novedadPresentador = new NovedadPresentador(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            novedadPresentador.EditarNovedad(this, id);
            BindingSource.DataSource = novedadPresentador.Listado();
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            var novedad = novedadPresentador.ObtenerNovedad(id);
            richTextBox1.Text = novedad.Descripción;
        }
    }
}

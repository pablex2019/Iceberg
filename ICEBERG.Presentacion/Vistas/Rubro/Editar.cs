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
    public partial class Editar : Form, IRubro
    {
        public int id;
        public BindingSource BindingSource;

        private readonly RubroPresentador rubroPresentador;

        public Editar()
        {
            InitializeComponent();
            rubroPresentador = new RubroPresentador(this);
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            rubroPresentador.EditarRubro(this, id);
            BindingSource.DataSource = rubroPresentador.Listado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void Editar_Load(object sender, EventArgs e)
        {
            var rubro = rubroPresentador.ObtenerRubro(id);
            txtDescripción.Text = rubro.Descripción;
        }
    }
}

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

namespace ICEBERG.Presentacion.Vistas.Rubro
{
    public partial class Nuevo : Form, IRubro
    {
        private readonly RubroPresentador rubroPresentador;

        public Nuevo()
        {
            InitializeComponent();
            rubroPresentador = new RubroPresentador(this);
        }

        public void MostrarMensaje(string mensaje)
        {
            if (!string.IsNullOrEmpty(mensaje)) { MessageBox.Show(mensaje); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            rubroPresentador.AgregarRubro(this);
        }
    }
}

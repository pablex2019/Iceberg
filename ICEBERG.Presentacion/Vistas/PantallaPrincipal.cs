using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICEBERG.Presentacion.Vistas
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            Vistas.Cliente.Index index = new Cliente.Index();
            index.MdiParent = this;
            index.Show();
        }

        private void mnuProveedores_Click(object sender, EventArgs e)
        {
            Vistas.Proveedor.Index index = new Proveedor.Index();
            index.MdiParent = this;
            index.Show();
        }
    }
}

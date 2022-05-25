using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class panel : Form
    {
        public panel()
        {
            InitializeComponent();
        }

        private void mnuArticulos_Click(object sender, EventArgs e)
        {
            new Vistas.Articulos.Indice().ShowDialog();
        }
    }
}

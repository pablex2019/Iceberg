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
            Vistas.Cliente.Inicio index = new Cliente.Inicio();
            index.MdiParent = this;
            index.Show();
        }

        private void mnuProveedores_Click(object sender, EventArgs e)
        {
            Vistas.Proveedor.Inicio index = new Proveedor.Inicio();
            index.MdiParent = this;
            index.Show();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro/a de salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch(result)
            {
                case DialogResult.Yes:
                    this.Close();
                    new IniciarSesion().Show();
                    break;
            }
        }

        private void mnuArticulos_Click(object sender, EventArgs e)
        {
           
        }

        private void mnuRubros_Click(object sender, EventArgs e)
        {
            Vistas.Rubro.Inicio index = new Rubro.Inicio();
            index.MdiParent = this;
            index.Show();
        }

        private void mnuCategorías_Click(object sender, EventArgs e)
        {
            Vistas.Categoría.Inicio index = new Categoría.Inicio();
            index.MdiParent = this;
            index.Show();
        }

        private void mnuEmpleados_Click(object sender, EventArgs e)
        {
            Vistas.Empleado.Inicio index = new Empleado.Inicio();
            index.MdiParent = this;
            index.Show();
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            Vistas.Usuario.Inicio index = new Usuario.Inicio();
            index.MdiParent = this;
            index.Show();
        }
    }
}

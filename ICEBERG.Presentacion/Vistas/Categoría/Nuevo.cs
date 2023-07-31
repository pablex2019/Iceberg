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

namespace ICEBERG.Presentacion.Vistas.Categoría
{
    public partial class Nuevo : Form,ICategoría
    {
        private readonly CategoríaPresentador categoríaPresentador;

        public Nuevo()
        {
            InitializeComponent();
            categoríaPresentador = new CategoríaPresentador(this);
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            categoríaPresentador.AgregarCategoría(this);
        }

        private void Nuevo_Load(object sender, EventArgs e)
        {
            cboRubros.DataSource = categoríaPresentador.ObtenerRubros();
        }
    }
}

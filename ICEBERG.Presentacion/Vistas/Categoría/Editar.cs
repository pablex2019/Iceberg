
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

namespace ICEBERG.Presentacion.Vistas.Categoría
{
    public partial class Editar : Form, ICategoría
    {
        public int id;
        public List<string> _rubros;
        public BindingSource BindingSource;

        private readonly CategoríaPresentador categoríaPresentador;
        
        public Editar()
        {
            InitializeComponent();
            categoríaPresentador = new CategoríaPresentador(this);
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            var categoria = categoríaPresentador.ObtenerCategoría(id);
            cboRubros.DataSource = _rubros;
            cboRubros.SelectedItem = categoria.Rubro.Descripción;
            txtDescripción.Text = categoria.Descripción;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            categoríaPresentador.EditarCategoría(this, id);
            BindingSource.DataSource = categoríaPresentador.Listado();
        }
    }
}

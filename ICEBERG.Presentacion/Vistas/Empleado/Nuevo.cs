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

namespace ICEBERG.Presentacion.Vistas.Empleado
{
    public partial class Nuevo : Form,IEmpleado
    {
        private readonly EmpleadoPresentador empleadoPresentador;

        public Nuevo()
        {
            InitializeComponent();
            empleadoPresentador = new EmpleadoPresentador(this);
        }

        public void MostrarMensaje(string mensaje)
        {
            if (!string.IsNullOrEmpty(mensaje)) { MessageBox.Show(mensaje); }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            empleadoPresentador.AgregarEmpleado(this);
        }
    }
}

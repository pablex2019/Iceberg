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
    public partial class Editar : Form, IEmpleado
    {
        public int id;
        public BindingSource BindingSource;

        private readonly EmpleadoPresentador empleadoPresentador;

        public Editar()
        {
            InitializeComponent();
            empleadoPresentador = new EmpleadoPresentador(this);
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            var empleado = empleadoPresentador.ObtenerEmpleado(id);
            txtLegajo.Text = empleado.Legajo.ToString();
            txtCuil.Text = empleado.Cuil;
            txtCuit.Text = empleado.Cuit;
            txtDni.Text = empleado.Dni.ToString();
            txtNombre.Text = empleado.Nombre;
            txtApellido.Text = empleado.Apellido;
            txtDomicilio.Text = empleado.Domicilio;
            txtCorreoElectronico.Text = empleado.CorreoElectronico;
            txtTelefonoFijo.Text = empleado.TelefonoFijo.ToString();
            txtCelular.Text = empleado.Celular.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            empleadoPresentador.EditarEmpleado(this, id);
            BindingSource.DataSource = empleadoPresentador.Listado();
        }
    }
}

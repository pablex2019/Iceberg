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

namespace ICEBERG.Presentacion.Vistas
{
    public partial class IniciarSesion : Form,IUsuario
    {
        private readonly UsuarioPresentador usuarioPresentador;

        public IniciarSesion()
        {
            InitializeComponent();
            usuarioPresentador = new UsuarioPresentador(this);
        }

        public void MostrarMensaje(string mensaje)
        {
            if (!string.IsNullOrEmpty(mensaje)) { MessageBox.Show(mensaje); }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            usuarioPresentador.VerificarExistenciaUsuario(this);
        }
    }
}

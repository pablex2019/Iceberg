using Presentacion.Interfaz;
using Presentacion.Presentador;
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
    public partial class IniciarSesion : Form, IIniciarSesion
    {
        private IniciarSesionPresentador _IniciarSesion;

        public IniciarSesion()
        {
            InitializeComponent();
            _IniciarSesion = new IniciarSesionPresentador(this,"Usuarios");
        }

        public void IniciarVista()
        {
            _IniciarSesion.IniciarVista(txtUsuario,txtClave);
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {
            IniciarVista();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            _IniciarSesion.Ingresar(txtUsuario,txtClave,this);
        }
    }
}

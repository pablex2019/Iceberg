using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Presentacion.Interfaces;
using ICEBERG.Presentacion.Vistas;
using ICEBERG.Objetos;
using ICEBERG.Dominio;

namespace ICEBERG.Presentacion.Presentadores
{
    public class UsuarioPresentador
    {
        private readonly IUsuario usuarioVista;
        private readonly UsuarioServicios usuariosServicios;
        private readonly EmpleadoServicios empleadoServicios;

        public UsuarioPresentador(IUsuario vista)
        {
            usuarioVista = vista;
            usuariosServicios = new UsuarioServicios();
            empleadoServicios = new EmpleadoServicios();
        }
        public List<Object> Listado()
        {
            return usuariosServicios.ListadoUsuarios();
        }
        public Usuario ObtenerUsuario(int id)
        {
            return usuariosServicios.ObtenerUsuario(id);
        }
        public void EditarUsuario(Vistas.Usuario.Editar editar, int id)
        {
            Usuario usuario = new Usuario()
            {
                Nombre = editar.txtUsuario.Text,
                Clave = editar.txtClave.Text,
                Empleado = usuariosServicios.ObtenerEmpleadoPorLegajo(Convert.ToInt32(editar.txtLegajo.Text)),
                Perfil = usuariosServicios.ObtenerPerfil(editar.cboPerfiles.Text),
                Estado = false
            };
            usuariosServicios.ABMUsuario(usuario, 2, id);
            usuarioVista.MostrarMensaje("Usuario editada");
            editar.Close();
        }
        public void EliminarUsuario(int id)
        {
            if (id != 0)
            {
                usuariosServicios.ABMUsuario(null, 3, id);
                usuarioVista.MostrarMensaje("Usuario eliminado");
            }
            else
            {
                usuarioVista.MostrarMensaje("Debe seleccionar un registro");
            }
        }
        public void AgregarUsuario(Vistas.Usuario.Nuevo nuevo)
        {
            Usuario usuario = new Usuario()
            {
                Nombre = nuevo.txtUsuario.Text,
                Clave = nuevo.txtClave.Text,
                Empleado = usuariosServicios.ObtenerEmpleadoPorLegajo(Convert.ToInt32(nuevo.txtLegajo.Text)),
                Perfil = usuariosServicios.ObtenerPerfil(nuevo.cboPerfiles.Text),
                Estado = false
            };
            usuariosServicios.ABMUsuario(usuario, 1, 0);
            usuarioVista.MostrarMensaje("Usuario agregado");
        }
        public List<string> ObtenerPerfiles()
        {
            return usuariosServicios.ListadoPerfiles();
        }
        public List<string> ObtenerDniEmpleados()
        {
            List<string> listado = new List<string>();
            listado.Insert(0, "Seleccione");
            foreach(var i in empleadoServicios.ListadoEmpleados())
            {
                listado.Add(i.Dni.ToString());
            }
            return listado;
        }
        public Empleado ObtenerEmpleadosSeleccionado(string dni)
        {
            return usuariosServicios.ObtenerEmpleadoPorDni(Convert.ToInt32(dni));
        }
        public void VerificarExistenciaUsuario(Vistas.IniciarSesion iniciarSesion)
        {
            if (!string.IsNullOrEmpty(iniciarSesion.txtUsuario.Text) && !string.IsNullOrEmpty(iniciarSesion.txtClave.Text)){
                if (usuariosServicios.VerificarExitencia(iniciarSesion.txtUsuario.Text,iniciarSesion.txtClave.Text) == true)
                {
                    PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
                    pantallaPrincipal.usuario = iniciarSesion.txtUsuario.Text;
                    pantallaPrincipal.Show();
                    iniciarSesion.Hide();
                }
                else
                {
                    usuarioVista.MostrarMensaje("El usuario y/o contraseña incorrectos");
                }
            }
            else
            {
                usuarioVista.MostrarMensaje("Completar campo usuario y/o contraseña");
            }
            
        }
    }
}

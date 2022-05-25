using Newtonsoft.Json;
using Presentacion.Interfaz;
using Presentacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Presentador
{
    public class IniciarSesionPresentador
    {
        #region Estructuras de Archivos JSON
        private string Archivo { get; set; }
        private Datos.Acceso Acceso { get; set; }
        private List<Modelo.Usuario> ListaUsuarios { get; set; }
        private string DatosArticulos;
        #endregion

        private readonly IIniciarSesion _vista;
        private Usuario _usuario; 

        public IniciarSesionPresentador(IIniciarSesion vista,string _Archivo)
        {
            _vista = vista;
            Acceso = new Datos.Acceso(_Archivo);
            _usuario = new Usuario();
        }
        #region Json Lectura y Escritura de Archivo
        private void Leer()
        {
            this.DatosArticulos = Acceso.Leer();
            this.ListaUsuarios = this.DatosArticulos?.Length > 0 ? JsonConvert.DeserializeObject<List<Modelo.Usuario>>(this.DatosArticulos) : new List<Usuario>();
        }
        public void Guardar()
        {
            //Convierto todos los datos a string
            this.DatosArticulos = JsonConvert.SerializeObject(this.ListaUsuarios);
            this.Acceso.Guardar(this.DatosArticulos);
        }
        #endregion
        public bool ExisteUsuario(string NombreUsuario, string Clave)
        {
            Leer();
            return ListaUsuarios.Any(x => x.NombreUsuario == NombreUsuario && x.Clave == Clave);
        }
        public void IniciarVista(TextBox NombreUsuario, TextBox Clave)
        {
            Clave.Text = NombreUsuario.Text = string.Empty;
        } 
        public void Ingresar(TextBox NombreUsuario, TextBox Clave, Vista.IniciarSesion IniciarSesion)
        {
            if (ExisteUsuario(NombreUsuario.Text, Clave.Text) == true)
            {
                IniciarSesion.Hide();
                new Vista.panel().Show();
            }
            else
            {
                MessageBox.Show("No existe el usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}

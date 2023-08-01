using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Objetos;
using ICEBERG.Datos;

namespace ICEBERG.Dominio
{
    public class UsuarioServicios
    {
        private IcebergDbContext IcebergDbContext;

        public UsuarioServicios()
        {
            IcebergDbContext = new IcebergDbContext();
        }

        public void ABMUsuario(Usuario usuario, int operacion, int id)
        {
            var _usuario = id == 0 ? null : IcebergDbContext.Usuarios.Where(x => x.UsuarioId == id).First();
            switch (operacion)
            {
                case 1:
                    try
                    {
                        IcebergDbContext.Usuarios.Add(usuario);
                        IcebergDbContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                    break;
                case 2:
                    try
                    {
                        _usuario.Nombre = usuario.Nombre;
                        _usuario.Clave = usuario.Clave;
                        _usuario.Estado = false;
                        _usuario.Empleado = usuario.Empleado;
                        _usuario.Perfil = usuario.Perfil;
                        IcebergDbContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                    break;
                case 3:
                    try
                    {
                        _usuario.Estado = true;
                        IcebergDbContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                    break;
            }
        }
        public List<string> ListadoPerfiles()
        {
            return IcebergDbContext.Perfiles.Select(x=>x.Descripción).ToList();
        }
        public List<Object> ListadoUsuarios()
        {
            var listado = (from usuario in IcebergDbContext.Usuarios
                           join empleado in IcebergDbContext.Empleados on usuario.Empleado.EmpleadoId equals empleado.EmpleadoId
                           join perfil in IcebergDbContext.Perfiles on usuario.Perfil.PerfilId equals perfil.PerfilId
                           where usuario.Estado == false
                           select new
                           {
                               ApellidoyNombre = empleado.Apellido + ", " + empleado.Nombre,
                               Legajo = empleado.Legajo,
                               Usuario = usuario.Nombre,
                               Perfil = perfil.Descripción
                           });
            return listado.ToList<Object>();
        }

        public Usuario ObtenerUsuario(int Id)
        {
            Usuario _user = new Usuario();

            var listado = (from usuario in IcebergDbContext.Usuarios
                           join empleado in IcebergDbContext.Empleados on usuario.Empleado.EmpleadoId equals empleado.EmpleadoId
                           join perfil in IcebergDbContext.Perfiles on usuario.Perfil.PerfilId equals perfil.PerfilId
                           where usuario.Estado == false
                           select new
                           {
                               Apellido = empleado.Apellido, 
                               Nombre = empleado.Nombre,
                               Legajo = empleado.Legajo,
                               Usuario = usuario.Nombre,
                               Perfil = perfil.Descripción
                           });

            _user.Nombre = listado.ToList().First().Usuario;
            _user.Empleado = ObtenerEmpleadoPorLegajo(listado.ToList().First().Legajo);
            _user.Perfil = ObtenerPerfil(listado.ToList().First().Perfil);

            return _user;
        }
        public Perfil ObtenerPerfil(string nombre)
        {
            return IcebergDbContext.Perfiles.Where(x => x.Descripción == nombre).First();
        }
        public Empleado ObtenerEmpleadoPorLegajo(int legajo)
        {
            return IcebergDbContext.Empleados.Where(x => x.Legajo == legajo).First();
        }
        public Empleado ObtenerEmpleadoPorDni(int dni)
        {
            return IcebergDbContext.Empleados.Where(x => x.Dni == dni).First();
        }
    }
}

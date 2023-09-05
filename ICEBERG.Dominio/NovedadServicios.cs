using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Dominio;
using ICEBERG.Datos;

namespace ICEBERG.Aplicación
{
    public class NovedadServicios
    {
        private IcebergDbContext IcebergDbContext;

        public NovedadServicios()
        {
            IcebergDbContext = new IcebergDbContext();
        }
        public void ABMNovedad(Novedad novedad, int operacion, int id)
        {
            var _novedad = id == 0 ? null : IcebergDbContext.Novedades.Where(x => x.NovedadId == id).First();
            switch (operacion)
            {
                case 1:
                    try
                    {
                        IcebergDbContext.Novedades.Add(novedad);
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
                        _novedad.Descripción = novedad.Descripción;
                        _novedad.Estado = false;
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
                        _novedad.Estado = true;
                        IcebergDbContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                    break;
            }
        }

        public List<Object> ListadoNovedades()
        {
            var listado = (from novedad in IcebergDbContext.Novedades
                           join usuario in IcebergDbContext.Usuarios on novedad.Usuario.UsuarioId equals usuario.UsuarioId
                           join empleado in IcebergDbContext.Empleados on usuario.Empleado.EmpleadoId equals empleado.EmpleadoId
                           where novedad.Estado == false
                           select new
                           {
                               NovedadId = novedad.NovedadId,
                               Usuario = usuario.Nombre,
                               ApellidoyNombre = empleado.Apellido + ", " + empleado.Nombre,
                               novedad.Descripción,
                           });
            return listado.ToList<Object>();
        }

        public Novedad ObtenerNovedad(int Id)
        {
            Novedad nov = new Novedad();

            var listado = (from novedad in IcebergDbContext.Novedades
                            join usuario in IcebergDbContext.Usuarios on novedad.Usuario.UsuarioId equals usuario.UsuarioId
                            join empleado in IcebergDbContext.Empleados on usuario.Empleado.EmpleadoId equals empleado.EmpleadoId
                            where novedad.Estado == false
                            select new
                            {
                                NovedadId = novedad.NovedadId,
                                Usuario = usuario.Nombre,
                                ApellidoyNombre = empleado.Apellido + ", " + empleado.Nombre,
                                novedad.Descripción,
                            });

            nov.NovedadId = listado.ToList().First().NovedadId;
            nov.Usuario = ObtenerUsuarioPorNombreUsuario(listado.ToList().First().Usuario);
            nov.Descripción = listado.ToList().First().Descripción;
            
            return nov;
        }
        public Usuario ObtenerUsuarioPorNombreUsuario(string nombre)
        {
            return IcebergDbContext.Usuarios.Where(x => x.Nombre == nombre).First();
        }
    }
}

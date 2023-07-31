using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Objetos;
using ICEBERG.Datos;

namespace ICEBERG.Dominio
{
    public class EmpleadoServicios
    {
        private IcebergDbContext IcebergDbContext;

        public EmpleadoServicios()
        {
            IcebergDbContext = new IcebergDbContext();
        }

        public void ABMEmpleado(Empleado empleado, int operacion, int id)
        {
            var _empleado = id == 0 ? null : IcebergDbContext.Empleados.Where(x => x.EmpleadoId == id).First();
            switch (operacion)
            {
                case 1:
                    try
                    {
                        IcebergDbContext.Empleados.Add(empleado);
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
                        _empleado.Legajo = empleado.Legajo;
                        _empleado.Cuit = empleado.Cuit;
                        _empleado.Cuil = empleado.Cuil;
                        _empleado.Dni = empleado.Dni;
                        _empleado.Nombre = empleado.Nombre;
                        _empleado.Apellido = empleado.Apellido;
                        _empleado.Domicilio = empleado.Domicilio;
                        _empleado.CorreoElectronico = empleado.CorreoElectronico;
                        _empleado.TelefonoFijo = empleado.TelefonoFijo;
                        _empleado.Celular = empleado.Celular;
                        _empleado.Estado = false;
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
                        _empleado.Estado = true;
                        IcebergDbContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                    break;
            }
        }

        public List<Empleado> ListadoEmpleados()
        {
            return IcebergDbContext.Empleados.Where(x=>x.Estado == false).ToList();
        }

        public Empleado ObtenerEmpleado(int Id)
        {
            return IcebergDbContext.Empleados.Where(x => x.EmpleadoId == Id).First();
        }
    }
}

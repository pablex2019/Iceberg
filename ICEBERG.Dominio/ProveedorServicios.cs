using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Objetos;
using ICEBERG.Datos;

namespace ICEBERG.Dominio
{
    public class ProveedorServicios
    {
        private IcebergDbContext IcebergDbContext;

        public ProveedorServicios()
        {
            IcebergDbContext = new IcebergDbContext();
        }

        public void ABMProveedor(Proveedor proveedor, int operacion, int id)
        {
            var _proveedor = id == 0 ? null : IcebergDbContext.Proveedores.Where(x => x.ProveedorId == id).First();
            switch (operacion)
            {
                case 1:
                    try
                    {
                        IcebergDbContext.Proveedores.Add(proveedor);
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
                        _proveedor.RazonSocial = _proveedor.RazonSocial;
                        _proveedor.Cuit = proveedor.Cuit;
                        _proveedor.Cuil = proveedor.Cuil;
                        _proveedor.Dni = proveedor.Dni;
                        _proveedor.Nombre = proveedor.Nombre;
                        _proveedor.Apellido = proveedor.Apellido;
                        _proveedor.Domicilio = proveedor.Domicilio;
                        _proveedor.CorreoElectronico = proveedor.CorreoElectronico;
                        _proveedor.TelefonoFijo = proveedor.TelefonoFijo;
                        _proveedor.Celular = proveedor.Celular;
                        _proveedor.Estado = false;
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
                        _proveedor.Estado = true;
                        IcebergDbContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                    break;
            }
        }

        public List<Proveedor> ListadoProveedores()
        {
            return IcebergDbContext.Proveedores.ToList();
        }

        public Proveedor ObtenerProveedor(int Id)
        {
            return IcebergDbContext.Proveedores.Where(x => x.ProveedorId == Id).First();
        }
    }
}

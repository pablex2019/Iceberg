using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Dominio;
using ICEBERG.Datos;

namespace ICEBERG.Aplicación
{
    public class ClienteServicios
    {
        private IcebergDbContext IcebergDbContext;

        public ClienteServicios()
        {
            IcebergDbContext = new IcebergDbContext();
        }

        public void ABMCliente(Cliente cliente,int operacion,int id)
        {
            var _cliente = id == 0 ? null: IcebergDbContext.Clientes.Where(x => x.ClienteId == id).First();
            switch (operacion)
            {
                case 1:
                    try
                    {
                        IcebergDbContext.Clientes.Add(cliente);
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
                        _cliente.Dni = cliente.Dni;
                        _cliente.Nombre = cliente.Nombre;
                        _cliente.Apellido = cliente.Apellido;
                        _cliente.Domicilio = cliente.Domicilio;
                        _cliente.TelefonoFijo = cliente.TelefonoFijo;
                        _cliente.Celular = cliente.Celular;
                        _cliente.CorreoElectronico = cliente.CorreoElectronico;
                        _cliente.SaldoDeudor = cliente.SaldoDeudor;
                        _cliente.Estado = false;
                        IcebergDbContext.SaveChanges();
                    }
                    catch(Exception ex)
                    {
                        ex.ToString();
                    }
                    break;
                case 3:
                    try
                    {
                        _cliente.Estado = true;
                        IcebergDbContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                    break;
            }
        }

        public List<Cliente> ListadoClientes()
        {
            return IcebergDbContext.Clientes.Where(x=>x.Estado == false).ToList();
        }

        public Cliente ObtenerCliente(int Id)
        {
            return IcebergDbContext.Clientes.Where(x => x.ClienteId == Id).First();
        }
    }
}

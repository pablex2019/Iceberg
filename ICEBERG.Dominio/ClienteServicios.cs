using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Objetos;
using ICEBERG.Datos;

namespace ICEBERG.Dominio.Servicios
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
                        _cliente.Nombres = cliente.Nombres;
                        _cliente.Apellidos = cliente.Apellidos;
                        _cliente.Nombres = cliente.Nombres;
                        _cliente.DNI = cliente.DNI;
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
                        IcebergDbContext.Clientes.Remove(cliente);
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
            return IcebergDbContext.Clientes.ToList();
        }

        public Cliente ObtenerCliente(int Id)
        {
            return IcebergDbContext.Clientes.Where(x => x.ClienteId == Id).First();
        }
    }
}

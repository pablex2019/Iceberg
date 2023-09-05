using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Dominio;
using ICEBERG.Datos;

namespace ICEBERG.Aplicación
{
    public class PedidoServicios
    {
        private IcebergDbContext IcebergDbContext;

        public PedidoServicios()
        {
            IcebergDbContext = new IcebergDbContext();
        }
        public int ObtenerNumeroPedido()
        {
            int numero = 0;
            if (IcebergDbContext.Pedidos.Where(x=>x.Estado == false).ToList().Count == 0)
            {
                numero = 1;
            }
            else
            {
                numero = IcebergDbContext.Pedidos.Where(x => x.Estado == false)
                    .ToList()
                    .Select(x => x.PedidoId).LastOrDefault() + 1;
            }
            return numero;
        }
        public string ObtenerApellidoyNombreDelEmpleado(string nombreusuario)
        {
            var apellido = (from usuario in IcebergDbContext.Usuarios
                            join empleado in IcebergDbContext.Empleados on usuario.Empleado.EmpleadoId equals empleado.EmpleadoId
                            where usuario.Nombre == nombreusuario
                            select empleado).First().Apellido;
            var nombre = (from usuario in IcebergDbContext.Usuarios
                          join empleado in IcebergDbContext.Empleados on usuario.Empleado.EmpleadoId equals empleado.EmpleadoId
                          where usuario.Nombre == nombreusuario
                          select empleado).First().Nombre;

            return apellido + ", " + nombre;
        }
        public Cliente ObtenerClientePorDni(int dni)
        {
            return IcebergDbContext.Clientes.Where(x => x.Dni == dni).First();
        }
        public Usuario ObtenerUsuarioPorNombreUsuario(string nombre)
        {
            return IcebergDbContext.Usuarios.Where(x => x.Nombre == nombre).First();
        }
        public bool AgregarPedido(Pedido pedido)
        {
            bool agregado = false;
            try
            {
                IcebergDbContext.Pedidos.Add(pedido);
                IcebergDbContext.SaveChanges();
                agregado = true;
            }
            catch (Exception ex)
            {
                ex.ToString();
                agregado = false;
            }
            return agregado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;
using ICEBERG.Objetos;

namespace ICEBERG.Datos
{
    public class IcebergDbContext: DbContext
    {
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<ArticuloPedido> ArticulosPedidos { get; set; }
        public DbSet<ArticuloProveedor> ArticulosProveedores { get; set; }
        public DbSet<Categoría> Categorías { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<LineaPedido> LineasPedidos { get; set; }
        public DbSet<Novedad> Novedades { get; set; }
        public DbSet<OpciónMenu> OpciónesMenus { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Perfil> Perfiles { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Rubro> Rubros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        public IcebergDbContext() : base("name=IcebergDeveloper") { }


    }
}

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
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }

        public IcebergDbContext() : base("name=IcebergDeveloper") { }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG.Dominio
{
    public class ArticuloProveedor
    {
        public int ArticuloProveedorId { get; set; }
        public Articulo Articulo { get; set; }
        public Proveedor Proveedor { get; set; }
    }
}

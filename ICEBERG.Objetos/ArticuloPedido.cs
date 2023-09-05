using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG.Dominio
{
    public class ArticuloPedido
    {
        public int ArticuloPedidoId { get; set; }
        public Articulo Articulo { get; set; }
        public Pedido Pedido { get; set; }
    }
}

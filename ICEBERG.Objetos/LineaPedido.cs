using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG.Objetos
{
    public class LineaPedido
    {
        public int LineaPedidoId { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Required]
        public Pedido Pedido { get; set; }
        public int Cantidad { get; set; }
        public float ImportePedidosAcumulados { get; set; }
        public float ImporteCostosPedidosAcumulados { get; set; }
        public bool Estado { get; set; }
    }
}

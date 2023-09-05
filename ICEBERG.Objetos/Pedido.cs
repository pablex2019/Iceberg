using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG.Dominio
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime FechaHora { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        [Required]
        public float ImportePedido { get; set; }
        [Required]
        public float ImporteCostoDelPedido { get; set; }
        public bool Estado { get; set; }
    }
}

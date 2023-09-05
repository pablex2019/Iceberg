using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG.Dominio
{
    public class Articulo
    {
        public int ArticuloId { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Required]
        public string Descripción { get; set; }
        public float? PrecioCosto { get; set; }
        public float? PrecioPedidoPorMenor { get; set; }
        public float? PrecioPedidoPorMayor { get; set; }
        public DateTime FechaHora { get; set; }
        [Required]
        public Categoría Categoría { get; set; }
        public bool Estado { get; set; }
    }
}

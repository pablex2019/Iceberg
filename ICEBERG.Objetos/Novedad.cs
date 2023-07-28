using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG.Objetos
{
    public class Novedad
    {
        public int NovedadId { get; set; }
        public DateTime FechaHora { get; set; }
        [Required]
        public string Descripción { get; set; }
        [Required]
        public bool Estado { get; set; }
    }
}

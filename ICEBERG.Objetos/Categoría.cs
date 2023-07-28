using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG.Objetos
{
    public class Categoría
    {
        public int CategoríaId { get; set; }
        [Required]
        public string Descripción { get; set; }
        public Rubro Rubro { get; set; }
        public bool Estado { get; set; }
    }
}

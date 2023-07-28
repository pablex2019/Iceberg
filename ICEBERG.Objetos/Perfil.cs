using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG.Objetos
{
    public class Perfil
    {
        public int PerfilId { get; set; }
        [Required]
        public string Descripción { get; set; }
        public bool Estado { get; set; }
    }
}

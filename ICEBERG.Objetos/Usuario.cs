using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG.Dominio
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Clave { get; set; }
        public Empleado Empleado { get; set; }
        public Perfil Perfil { get; set; }
        public bool Estado { get; set; }
    }
}

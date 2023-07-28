using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG.Objetos
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        [Required]
        public int Legajo { get; set; }
        [Required]
        public string Cuit { get; set; }
        public string Cuil { get; set; }
        public int? Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public string CorreoElectronico { get; set; }
        public int? TelefonoFijo { get; set; }
        [Required]
        public int Celular { get; set; }
        public bool Estado { get; set; }
    }
}

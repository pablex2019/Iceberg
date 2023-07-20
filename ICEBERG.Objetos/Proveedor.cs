using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG.Objetos
{
    public class Proveedor
    {
        public int ProveedorId { get; set; }
        [Required]
        public string RazonSocial { get; set; }
        [Required]
        public string Cuit { get; set; }
        public string Cuil { get; set; }
        public string DNI { get; set; } 
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        [Required]
        public string Domicilio { get; set; }
        [Required]
        public string CorreoElectronico { get; set; }
        public int? TelefonoFijo { get; set; }
        [Required]
        public int Celular { get; set; }
        public bool Estado { get; set; }
    }
}

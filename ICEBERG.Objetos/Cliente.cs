using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG.Objetos
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string Domicilio { get; set; }
        public int? DNI { get; set; }
        public int? TelefonoFijo { get; set; }
        [Required]
        public int Celular { get; set; }
        [Required]
        public string CorreoElectronico { get; set; }
        public float? SaldoDeudor { get; set; }
        public bool Estado { get; set; }
    }
}

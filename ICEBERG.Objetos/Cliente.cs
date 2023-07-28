﻿using System;
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
        public int? Dni { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Domicilio { get; set; }
        public int? TelefonoFijo { get; set; }
        [Required]
        public int Celular { get; set; }
        public string CorreoElectronico { get; set; }
        public float? SaldoDeudor { get; set; }
        public bool Estado { get; set; }
    }
}

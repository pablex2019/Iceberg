namespace ICEBERG.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(255)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(255)]
        public string Domicilio { get; set; }

        [StringLength(255)]
        public string TelefonoFijo { get; set; }

        [Required]
        [StringLength(255)]
        public string Celular { get; set; }

        [Required]
        [StringLength(255)]
        public string CorreoElectronico { get; set; }

        public double SaldoDeudor { get; set; }

        public bool Estado { get; set; }
    }
}

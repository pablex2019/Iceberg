using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG.Presentacion.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Domicilio { get; set; }
        public int TelefonoFijo { get; set; }
        public int Celular { get; set; }
        public string CorreoElectronico { get; set; }
        public float SaldoDeudor { get; set; }
        public bool Estado { get; set; }
    }
}

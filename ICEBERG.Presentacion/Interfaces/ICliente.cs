using ICEBERG.Presentacion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG.Presentacion.Interfaces
{
    public interface ICliente
    {
        string Nombres { get; set; }
        string Apellidos { get; set; }
        string Domicilio { get; set; }
        int TelefonoFijo { get; set; }
        int Celular { get; set; }
        string CorreoElectronico { get; set; }
        float SaldoDeudor { get; set; }

        void MostrarMensaje(string mensaje);

        event EventHandler AgregarClienteClicked;
    }
}

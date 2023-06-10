using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Presentacion.Modelos;
using ICEBERG.Datos;

namespace ICEBERG.Presentacion.Servicios
{
    public class ClienteRespositorio
    {

        public void AgregarCliente(Modelos.Cliente cliente)
        {
            using (var iceberg = new Datos.Iceberg())
            {
                Dominio.Cliente clienteRespositorio = new Dominio.Cliente
                {
                    Nombres = cliente.Nombres,
                    Apellidos = cliente.Apellidos,
                    Domicilio = cliente.Domicilio,
                    TelefonoFijo = cliente.TelefonoFijo.ToString(),
                    Celular = cliente.Celular.ToString(),
                    CorreoElectronico = cliente.CorreoElectronico,
                    SaldoDeudor = cliente.SaldoDeudor,
                    Estado = cliente.Estado,
                };
                iceberg.Set<Dominio.Cliente>().Add(clienteRespositorio);
                iceberg.SaveChanges();
            }
        }
    }
}

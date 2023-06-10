using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Presentacion.Interfaces;
using ICEBERG.Presentacion.Vistas;
using ICEBERG.Presentacion.Modelos;
using ICEBERG.Presentacion.Servicios;
namespace ICEBERG.Presentacion.Presentadores
{
    public class ClientePresentador
    {
        private readonly ICliente clienteVista;
        private readonly ClienteRespositorio clienteRespositorio;

        public ClientePresentador(ICliente vista)
        {
            clienteVista = vista;
            clienteVista.AgregarClienteClicked += AgregarCliente;
            clienteRespositorio = new ClienteRespositorio();
        }
        public void AgregarCliente(object sender, EventArgs e)
        {
            string nombres = clienteVista.Nombres;
            string apellidos = clienteVista.Apellidos;
            string domicilio = clienteVista.Domicilio;
            int TelefonoFijo = clienteVista.TelefonoFijo;
            int Celular = clienteVista.Celular;
            string CorreoElectronico = clienteVista.CorreoElectronico;
            float SaldoDeudor = clienteVista.SaldoDeudor;
            bool Estado = true;

            Modelos.Cliente cliente = new  Modelos.Cliente
            {
                Nombres = nombres,
                Apellidos = apellidos,
                Domicilio = domicilio,
                TelefonoFijo = TelefonoFijo,
                Celular = Celular,
                CorreoElectronico = CorreoElectronico,
                SaldoDeudor = SaldoDeudor,
                Estado = Estado
            };
            clienteRespositorio.AgregarCliente(cliente);
            clienteVista.MostrarMensaje("Cliente agregado");
        }
    }
}

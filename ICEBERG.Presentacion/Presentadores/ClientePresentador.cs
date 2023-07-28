using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Presentacion.Interfaces;
using ICEBERG.Presentacion.Vistas;
using ICEBERG.Objetos;
using ICEBERG.Dominio.Servicios;
using System.Windows.Forms;

namespace ICEBERG.Presentacion.Presentadores
{
    public class ClientePresentador
    {
        private readonly ICliente clienteVista;
        private readonly ClienteServicios clienteServicios;

        public ClientePresentador(ICliente vista)
        {
            clienteVista = vista;
            clienteServicios = new ClienteServicios();
        }
        public List<Cliente> Listado()
        {
            return clienteServicios.ListadoClientes();
        }
        public Cliente ObtenerCliente(int id)
        {
            return clienteServicios.ObtenerCliente(id);
        }
        public void EditarCliente(Vistas.Cliente.Editar editar,int id)
        {
            Cliente cliente = new Cliente()
            {
                Nombre = editar.txtNombres.Text,
                Apellido = editar.txtApellidos.Text,
                Domicilio = editar.txtDomicilio.Text,
                Dni = editar.txtDNI.Text == "" ? 0: Convert.ToInt32(editar.txtDNI.Text),
                TelefonoFijo = Convert.ToInt32(editar.txtTelefonoFijo.Text),
                Celular = Convert.ToInt32(editar.txtCelular.Text),
                CorreoElectronico = editar.txtCorreoElectronico.Text,
                SaldoDeudor = float.Parse(editar.txtSaldoDeudor.Text),
                Estado = false
            };
            clienteServicios.ABMCliente(cliente,2,id);
            clienteVista.MostrarMensaje("Cliente editado");
            editar.Close();
        }
        public void EliminarCliente(int id)
        {
            if (id != 0)
            {
                clienteServicios.ABMCliente(null,3,id);
                clienteVista.MostrarMensaje("Cliente Eliminado");
            }
            else
            {
                clienteVista.MostrarMensaje("Debe seleccionar un registro");
            }
        }
        public void AgregarCliente(Vistas.Cliente.Nuevo nuevo)
        {
            Cliente cliente = new Cliente()
            {
                Nombre = nuevo.txtNombres.Text,
                Apellido = nuevo.txtApellidos.Text,
                Domicilio = nuevo.txtDomicilio.Text,
                TelefonoFijo = Convert.ToInt32(nuevo.txtTelefonoFijo.Text),
                Celular = Convert.ToInt32(nuevo.txtCelular.Text),
                CorreoElectronico = nuevo.txtCorreoElectronico.Text,
                SaldoDeudor = float.Parse(nuevo.txtSaldoDeudor.Text),
                Estado = false
            };
            clienteServicios.ABMCliente(cliente,1,0);
            clienteVista.MostrarMensaje("Cliente agregado");
        }
    }
}

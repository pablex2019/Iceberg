using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Presentacion.Interfaces;
using ICEBERG.Presentacion.Vistas;
using ICEBERG.Dominio;
using ICEBERG.Aplicación;

namespace ICEBERG.Presentacion.Presentadores
{
    public class PedidoPresentador
    {
        private readonly IPedido pedidoVista;
        private readonly PedidoServicios pedidoServicios;
        private readonly ClienteServicios clienteServicios;
        private readonly ArticuloServicios articuloServicios;
        private readonly UsuarioServicios usuarioServicios;

        public PedidoPresentador(IPedido vista)
        {
            pedidoVista = vista;
            pedidoServicios = new PedidoServicios();
            clienteServicios = new ClienteServicios();
            articuloServicios = new ArticuloServicios();
            usuarioServicios = new UsuarioServicios();
        }
        public int ObtenerNumeroPedido()
        {
            return pedidoServicios.ObtenerNumeroPedido();
        }
        public string ObtenerApellidoyNombreDelEmpleado(Vistas.Pedido.Nuevo nuevo)
        {
            return pedidoServicios.ObtenerApellidoyNombreDelEmpleado(nuevo._usuario);
        }
        public List<string> ObtenerDniClientes()
        {
            List<string> listado = new List<string>();
            listado.Insert(0, "Seleccione");
            foreach (var i in clienteServicios.ListadoClientes())
            {
                listado.Add(i.Dni.ToString());
            }
            return listado;
        }
        public Cliente ObtenerClienteSeleccionado(string dni)
        {
            return pedidoServicios.ObtenerClientePorDni(Convert.ToInt32(dni));
        }
        public List<Object> ObtenerArticulos()
        {
            return articuloServicios.ListadoArticulos();
        }
        public void AgregarPedido(Vistas.Pedido.Nuevo nuevo)
        {
            Pedido pedido = new Pedido()
            {
                FechaHora = DateTime.Now,
                ImportePedido = float.Parse(nuevo.txtTotal.Text),
                ImporteCostoDelPedido = float.Parse(nuevo.txtCosto.Text),
                Estado = false,
                Cliente = pedidoServicios.ObtenerClientePorDni(Convert.ToInt32(nuevo.cboClientes.Text)),
                Usuario = pedidoServicios.ObtenerUsuarioPorNombreUsuario(nuevo._usuario),
            };
            if (pedidoServicios.AgregarPedido(pedido) == true)
            {
                pedidoVista.MostrarMensaje("Pedido registrado");
            }
            else
            {
                pedidoVista.MostrarMensaje("No se puedo registrar el pedido");
            }
        }
    }
}

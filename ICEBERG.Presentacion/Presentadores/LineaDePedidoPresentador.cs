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
    public class LineaDePedidoPresentador
    {
        private readonly ILineaDePedido lineaDePedidoVista;

        public LineaDePedidoPresentador(ILineaDePedido vista)
        {
            lineaDePedidoVista = vista;
        }
        public List<LineaPedido> ListadoLineaDePedidos()
        {
            return null;
        }
    }
}

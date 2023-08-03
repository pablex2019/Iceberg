using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Presentacion.Interfaces;
using ICEBERG.Presentacion.Vistas;
using ICEBERG.Objetos;
using ICEBERG.Dominio;

namespace ICEBERG.Presentacion.Presentadores
{
    public class ArticuloPresentador
    {
        private readonly IArticulo articuloVista;
        private readonly ArticuloServicios articuloServicios;
        private readonly CategoríaServicios categoríaServicios;

        public ArticuloPresentador(IArticulo vista)
        {
            articuloVista = vista;
            articuloServicios = new ArticuloServicios();
            categoríaServicios = new CategoríaServicios();
        }
        public List<Object> Listado()
        {
            return articuloServicios.ListadoArticulos();
        }
        public Articulo ObtenerArticulo(int id)
        {
            return articuloServicios.ObtenerArticulo(id);
        }
        public void EditarArticulo(Vistas.Articulo.Editar editar, int id)
        {
            Articulo articulo = new Articulo()
            {
                Codigo = Convert.ToInt32(editar.txtCodigo.Text),
                Descripción = editar.txtDescripción.Text,
                PrecioCosto = float.Parse(editar.txtPrecioCosto.Text),
                PrecioPedidoPorMenor = float.Parse(editar.txtPrecioPedidoPorMenor.Text),
                PrecioPedidoPorMayor = float.Parse(editar.txtPrecioPedidoPorMayor.Text),
                Categoría = articuloServicios.ObtenerCategoríaDelArticulo(editar.cboCategorías.Text),
            };
            articuloServicios.ABMArticulo(articulo, 2, id);
            articuloVista.MostrarMensaje("Articulo editada");
            editar.Close();
        }
        public void EliminarArticulo(int id)
        {
            if (id != 0)
            {
                articuloServicios.ABMArticulo(null, 3, id);
                articuloVista.MostrarMensaje("Articulo eliminada");
            }
            else
            {
                articuloVista.MostrarMensaje("Debe seleccionar un registro");
            }
        }
        public void AgregarArticulo(Vistas.Articulo.Nuevo nuevo)
        {
            Articulo articulo = new Articulo()
            {
                Codigo = Convert.ToInt32(nuevo.txtCodigo.Text),
                Descripción = nuevo.txtDescripción.Text,
                PrecioCosto = float.Parse(nuevo.txtPrecioCosto.Text),
                PrecioPedidoPorMenor = float.Parse(nuevo.txtPrecioPedidoPorMenor.Text),
                PrecioPedidoPorMayor = float.Parse(nuevo.txtPrecioPedidoPorMayor.Text),
                FechaHora = DateTime.Now,
                Categoría = articuloServicios.ObtenerCategoríaDelArticulo(nuevo.cboCategorías.Text),
                Estado = false,
            };
            articuloServicios.ABMArticulo(articulo, 1, 0);
            articuloVista.MostrarMensaje("Articulo agregada");
        }
        public List<string> ObtenerCategorias()
        {
            return articuloServicios.ObtenerCategorias();
        }
    }
}

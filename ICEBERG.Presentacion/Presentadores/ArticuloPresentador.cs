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
        //private readonly ArticuloServicios categoríaServicios;
        private readonly CategoríaServicios categoríaServicios;

        public ArticuloPresentador(IArticulo vista)
        {
            articuloVista = vista;
            categoríaServicios = new CategoríaServicios();
        }
        public List<Object> Listado()
        {
            return categoríaServicios.ListadoCategorías();
        }
        public Categoría ObtenerCategoría(int id)
        {
            return categoríaServicios.ObtenerCategoría(id);
        }
        public void EditarCategoría(Vistas.Categoría.Editar editar, int id)
        {
            Categoría categoría = new Categoría()
            {
                Rubro = categoríaServicios.ObtenerRubroDeLaCategoría(editar.cboRubros.Text),
                Descripción = editar.txtDescripción.Text,
                Estado = false
            };
            categoríaServicios.ABMCategoría(categoría, 2, id);
            //categoríaVista.MostrarMensaje("Categoría editada");
            editar.Close();
        }
        public void EliminarCategoría(int id)
        {
            if (id != 0)
            {
                categoríaServicios.ABMCategoría(null, 3, id);
                //categoríaVista.MostrarMensaje("Categoría eliminada");
            }
            else
            {
                //categoríaVista.MostrarMensaje("Debe seleccionar un registro");
            }
        }
        public void AgregarCategoría(Vistas.Categoría.Nuevo nuevo)
        {
            Categoría categoría = new Categoría()
            {
                Rubro = categoríaServicios.ObtenerRubroDeLaCategoría(nuevo.cboRubros.Text),
                Descripción = nuevo.txtDescripción.Text,
                Estado = false
            };
            categoríaServicios.ABMCategoría(categoría, 1, 0);
            //categoríaVista.MostrarMensaje("Categoría agregada");
        }
        public List<string> ObtenerCategorias()
        {
            List<string> lista = new List<string>();
            return lista;
        }
    }
}

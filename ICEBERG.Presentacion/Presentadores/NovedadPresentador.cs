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
    public class NovedadPresentador
    {
        private readonly INovedad novedadVista;
        private readonly NovedadServicios novedadServicios;

        public NovedadPresentador(INovedad vista)
        {
            novedadVista = vista;
            novedadServicios = new NovedadServicios();
        }
        public List<Object> Listado()
        {
            return novedadServicios.ListadoNovedades();
        }
        public Novedad ObtenerNovedad(int id)
        {
            return novedadServicios.ObtenerNovedad(id);
        }
        public void EditarNovedad(Vistas.Novedad.Editar editar, int id)
        {
            Novedad novedad = new Novedad()
            {
                FechaHora = DateTime.Now,
                Descripción = editar.richTextBox1.Text,
                Usuario = novedadServicios.ObtenerUsuarioPorNombreUsuario(editar.usuario),
                Estado = false
            };
            novedadServicios.ABMNovedad(novedad, 2, id);
            novedadVista.MostrarMensaje("Novedad editada");
            editar.Close();
        }
        public void EliminarNovedad(int id)
        {
            if (id != 0)
            {
                novedadServicios.ABMNovedad(null, 3, id);
                novedadVista.MostrarMensaje("Novedad eliminada");
            }
            else
            {
                novedadVista.MostrarMensaje("Debe seleccionar un registro");
            }
        }
        public void AgregarNovedad(Vistas.Novedad.Nuevo nuevo)
        {
            Novedad novedad = new Novedad()
            {
                FechaHora = DateTime.Now,
                Descripción = nuevo.richTextBox1.Text,
                Usuario = novedadServicios.ObtenerUsuarioPorNombreUsuario(nuevo.usuario),
                Estado = false
            }; 
            novedadServicios.ABMNovedad(novedad, 1, 0);
            novedadVista.MostrarMensaje("Novedad agregada");
        }
    }
}
